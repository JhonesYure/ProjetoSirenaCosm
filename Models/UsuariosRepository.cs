using MySqlConnector;
using System;
using System.Collections.Generic;

namespace ATV4PI.Models
{
    public class UsuariosRepository
    {
        private const string DadosConexao =  "Database=Sirena;Data Source=localhost;User Id=root";
       
       public void TestConexao()
       {
           MySqlConnection conexao = new MySqlConnection(DadosConexao);
           conexao.Open();
           Console.WriteLine("Sirena Está Online");
           conexao.Close();
       }
    //INSERIR
       public void inserir(Usuarios user)
       {
           MySqlConnection conexao = new MySqlConnection(DadosConexao);
           conexao.Open();

           string Query = "INSERT INTO Usuarios (Nome,Sobrenome,Email,DataNascimento,CPF,Telefone,Sexo,Senha) VALUES (@Nome,@Sobrenome,@Email,@DataNascimento,@CPF,@Telefone,@Sexo,@Senha)";

           MySqlCommand Comando = new MySqlCommand(Query,conexao);

           Comando.Parameters.AddWithValue("@Nome", user.Nome);
           Comando.Parameters.AddWithValue("@Sobrenome", user.Sobrenome);
           Comando.Parameters.AddWithValue("@Email", user.Email);
           Comando.Parameters.AddWithValue("@DataNascimento", user.DataNascimento);
           Comando.Parameters.AddWithValue("@CPF", user.CPF);
           Comando.Parameters.AddWithValue("@Telefone", user.Telefone);
           Comando.Parameters.AddWithValue("@Sexo", user.Sexo);
           Comando.Parameters.AddWithValue("@Senha", user.Senha);

           Comando.ExecuteNonQuery();

           conexao.Close();
       }   
    //ATUALIZAR
       public void atualizar(Usuarios user)
       {
           MySqlConnection conexao = new MySqlConnection(DadosConexao);
           conexao.Open();

           string Query = "UPDATE Usuarios SET Nome=@Nome,Sobrenome=@Sobrenome,Email=@Email,DataNascimento=@DataNascimento,CPF=@CPF,Telefone=@Telefone,Sexo=@Sexo,Senha=@Senha WHERE Id=@Id";

           MySqlCommand Comando = new MySqlCommand(Query,conexao);

           Comando.Parameters.AddWithValue("@Nome", user.Nome);
           Comando.Parameters.AddWithValue("@Sobrenome", user.Sobrenome);
           Comando.Parameters.AddWithValue("@Email", user.Email);
           Comando.Parameters.AddWithValue("@DataNascimento", user.DataNascimento);
           Comando.Parameters.AddWithValue("@CPF", user.CPF);
           Comando.Parameters.AddWithValue("@Telefone", user.Telefone);
           Comando.Parameters.AddWithValue("@Sexo", user.Sexo);
           Comando.Parameters.AddWithValue("@Senha", user.Senha);
           Comando.Parameters.AddWithValue("@Id", user.Id);

           Comando.ExecuteNonQuery();

           conexao.Close();
       }  
    //DELETAR
        public void deletar(Usuarios user)
        {
            MySqlConnection conexao = new MySqlConnection(DadosConexao);
           conexao.Open();

           string Query = "DELETE FROM Usuarios WHERE Id=@Id";

           MySqlCommand Comando = new MySqlCommand(Query,conexao);

           Comando.Parameters.AddWithValue("@Id", user.Id);

           Comando.ExecuteNonQuery();

           conexao.Close();
        }   
    //LISTA DE USUSARIOS
        public List<Usuarios> Lista()
        {
            MySqlConnection conexao = new MySqlConnection(DadosConexao);
            conexao.Open();

            List<Usuarios> listaUser = new List<Usuarios>();

            string Query = "SELECT * FROM Usuarios";

            MySqlCommand Comando = new MySqlCommand(Query,conexao);

            MySqlDataReader Reader = Comando.ExecuteReader();

            while(Reader.Read())
            {
                Usuarios userFind = new Usuarios();

                userFind.Id = Reader.GetInt32("Id");

              if(!Reader.IsDBNull(Reader.GetOrdinal("Nome"))){
                userFind.Nome = Reader.GetString("Nome");}

              if(!Reader.IsDBNull(Reader.GetOrdinal("Sobrenome"))){
                userFind.Sobrenome = Reader.GetString("Sobrenome");}

              if(!Reader.IsDBNull(Reader.GetOrdinal("Email"))){
                userFind.Email = Reader.GetString("Email");}

              if(!Reader.IsDBNull(Reader.GetOrdinal("DataNascimento"))){
                userFind.DataNascimento = Reader.GetDateTime("DataNascimento");}

              if(!Reader.IsDBNull(Reader.GetOrdinal("CPF"))){
                userFind.CPF = Reader.GetString("CPF");}

              if(!Reader.IsDBNull(Reader.GetOrdinal("Telefone"))){
                userFind.Telefone = Reader.GetString("Telefone");}

              if(!Reader.IsDBNull(Reader.GetOrdinal("Sexo"))){
                userFind.Sexo = Reader.GetString("Sexo");}

              if(!Reader.IsDBNull(Reader.GetOrdinal("Senha"))){
                userFind.Senha = Reader.GetString("Senha");}

                listaUser.Add(userFind);
            }
             
             return listaUser;
        }
    //BUSCAR ID 
           public Usuarios buscarId(int Id)
           {
              MySqlConnection conexao = new MySqlConnection(DadosConexao);
           conexao.Open();

           Usuarios userFind = new Usuarios();

           string Query = "SELECT * FROM Usuarios WHERE Id=@Id";

           MySqlCommand Comando = new MySqlCommand(Query,conexao);
           Comando.Parameters.AddWithValue("Id", Id);

           MySqlDataReader Reader = Comando.ExecuteReader();

            if(Reader.Read())
            {
              userFind.Id = Reader.GetInt32("Id");
                
              if(!Reader.IsDBNull(Reader.GetOrdinal("Nome"))){
                userFind.Nome = Reader.GetString("Nome");}

              if(!Reader.IsDBNull(Reader.GetOrdinal("Sobrenome"))){
                userFind.Sobrenome = Reader.GetString("Sobrenome");}

              if(!Reader.IsDBNull(Reader.GetOrdinal("Email"))){
                userFind.Email = Reader.GetString("Email");}

              if(!Reader.IsDBNull(Reader.GetOrdinal("DataNascimento"))){
                userFind.DataNascimento = Reader.GetDateTime("DataNascimento");}

              if(!Reader.IsDBNull(Reader.GetOrdinal("CPF"))){
                userFind.CPF = Reader.GetString("CPF");}

              if(!Reader.IsDBNull(Reader.GetOrdinal("Telefone"))){
                userFind.Telefone = Reader.GetString("Telefone");}

              if(!Reader.IsDBNull(Reader.GetOrdinal("Sexo"))){
                userFind.Sexo = Reader.GetString("Sexo");}

              if(!Reader.IsDBNull(Reader.GetOrdinal("Senha"))){
                userFind.Senha = Reader.GetString("Senha");}
            }
            conexao.Close();

            return userFind;

           }     
    //VALIDAR LOGIN
           public Usuarios validar(Usuarios user)
           {
               MySqlConnection conexao = new MySqlConnection(DadosConexao);
            conexao.Open();

            Usuarios userFind = null;

            string Query = "SELECT * FROM Usuarios WHERE Email=@Email and Senha=@Senha";

            MySqlCommand Comando = new MySqlCommand(Query,conexao);

            Comando.Parameters.AddWithValue("@Email", user.Email);
            Comando.Parameters.AddWithValue("@Senha", user.Senha);

            MySqlDataReader Reader = Comando.ExecuteReader();

            if(Reader.Read())
            {
                userFind = new Usuarios();

                
                userFind.Id = Reader.GetInt32("Id");
                
              if(!Reader.IsDBNull(Reader.GetOrdinal("Nome"))){
                userFind.Nome = Reader.GetString("Nome");}

              if(!Reader.IsDBNull(Reader.GetOrdinal("Sobrenome"))){
                userFind.Sobrenome = Reader.GetString("Sobrenome");}

              if(!Reader.IsDBNull(Reader.GetOrdinal("Email"))){
                userFind.Email = Reader.GetString("Email");}

              if(!Reader.IsDBNull(Reader.GetOrdinal("DataNascimento"))){
                userFind.DataNascimento = Reader.GetDateTime("DataNascimento");}

              if(!Reader.IsDBNull(Reader.GetOrdinal("CPF"))){
                userFind.CPF = Reader.GetString("CPF");}

              if(!Reader.IsDBNull(Reader.GetOrdinal("Telefone"))){
                userFind.Telefone = Reader.GetString("Telefone");}

              if(!Reader.IsDBNull(Reader.GetOrdinal("Sexo"))){
                userFind.Sexo = Reader.GetString("Sexo");}

              if(!Reader.IsDBNull(Reader.GetOrdinal("Senha"))){
                userFind.Senha = Reader.GetString("Senha");}
            }
            conexao.Close();

            return userFind;
           }         
             
        
    }
}