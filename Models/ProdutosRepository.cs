using MySqlConnector;
using System;
using System.Collections.Generic;
namespace ATV4PI.Models
{
    public class ProdutosRepository
    {
          private const string DadosConexao =  "Database=Sirena;Data Source=localhost;User Id=root";

          public int Usuario {get;set;}
       
       public void TestConexao()
       {
           MySqlConnection conexao = new MySqlConnection(DadosConexao);
           conexao.Open();
           Console.WriteLine("Vamos as Compras ?");
           conexao.Close();
       }
    //INSERIR
        public void inserir(Produtos prod)
        {
            MySqlConnection conexao = new MySqlConnection(DadosConexao);
           conexao.Open();

           string Query = "INSERT INTO Produtos (IdUsuario, ValorProduto, Quantidade, ValorTotal) VALUES (@IdUsuario, @ValorProduto, @Quantidade, @ValorTotal)";

           MySqlCommand Comando = new MySqlCommand(Query,conexao);

           Comando.Parameters.AddWithValue("IdUsuario", prod.IdUsuario);
           Comando.Parameters.AddWithValue("ValorProduto", prod.ValorProduto);
           Comando.Parameters.AddWithValue("Quantidade", prod.Quantidade);
           Comando.Parameters.AddWithValue("ValorTotal", prod.ValorTotal);

           Comando.ExecuteNonQuery();

           conexao.Close();
        }  
    //REMOVER 
        public void deletar(Produtos prod)
        {
            MySqlConnection conexao = new MySqlConnection(DadosConexao);
           conexao.Open();

           string Query = "DELETE FROM Produtos WHERE IdUsuario=@IdUsuario";

           MySqlCommand Comando = new MySqlCommand(Query,conexao);

           Comando.Parameters.AddWithValue("@IdUsuario", prod.IdUsuario);

           Comando.ExecuteNonQuery();

           conexao.Close();
        }      
    //LISTA 
        public List<Produtos> produtos()
        {
           MySqlConnection conexao = new MySqlConnection(DadosConexao);
           conexao.Open();

           List<Produtos> listaprod = new List<Produtos>();
           List<Usuarios> ListaUser = new List<Usuarios>();

           string Query = "SELECT * FROM Produtos";

           MySqlCommand Comando = new MySqlCommand(Query,conexao);

           MySqlDataReader Reader = Comando.ExecuteReader();

           while(Reader.Read())
           {
               Produtos produtoFind = new Produtos();
               Usuarios userfind = new Usuarios();

               produtoFind.IdProduto = Reader.GetInt32("IdProduto");
               
               if (!Reader.IsDBNull(Reader.GetOrdinal("ValorProduto"))){
               produtoFind.ValorProduto = Reader.GetDouble("ValorProduto");}

               if (!Reader.IsDBNull(Reader.GetOrdinal("Quantidade"))){
               produtoFind.Quantidade = Reader.GetInt32("Quantidade");}
               
               if (!Reader.IsDBNull(Reader.GetOrdinal("ValorTotal"))){
               produtoFind.ValorTotal = Reader.GetDouble("ValorTotal");}

               listaprod.Add(produtoFind);
           }

           conexao.Close();

           
           return listaprod;
        }
    //BUSCAR ID
        public Produtos buscarId(int IdProduto)
        {
            MySqlConnection conexao = new MySqlConnection(DadosConexao);
           conexao.Open();

           Produtos produtoFind = new Produtos();

           string Query = "SELECT * FROM Produtos WHERE IdProdutos=@IdProdutos";

           MySqlCommand Comando = new MySqlCommand(Query,conexao);

           Comando.Parameters.AddWithValue("IdProduto", IdProduto);

           MySqlDataReader Reader = Comando.ExecuteReader();

           if(Reader.Read())
           {
               produtoFind.IdProduto = Reader.GetInt32("IdProduto");

              if (!Reader.IsDBNull(Reader.GetOrdinal("ValorProduto"))){
               produtoFind.ValorProduto = Reader.GetDouble("ValorProduto");}

               if (!Reader.IsDBNull(Reader.GetOrdinal("Quantidade"))){
               produtoFind.Quantidade = Reader.GetInt32("Quantidade");}
               
               if (!Reader.IsDBNull(Reader.GetOrdinal("ValorTotal"))){
               produtoFind.ValorTotal = Reader.GetDouble("ValorTotal");}
           }

           conexao.Close();

           return produtoFind;
        }    
//UPDATE
        public void atualizar(Produtos prod)
        {
           MySqlConnection conexao = new MySqlConnection(DadosConexao);
           conexao.Open();

           string Query = "UPDATE Produtos SET ValorProduto=@ValorProduto, Quantidade=@Quantidade, ValorTotal=@ValorTotal WHERE IdUsuario=@IdUsuario";

           MySqlCommand Comando = new MySqlCommand(Query,conexao);

           Comando.Parameters.AddWithValue("@ValorProduto", prod.ValorProduto);
           Comando.Parameters.AddWithValue("@Quantidade", prod.Quantidade);
           Comando.Parameters.AddWithValue("@ValorTotal", prod.ValorTotal);
           Comando.Parameters.AddWithValue("@IdUsuario", prod.IdUsuario);

           Comando.ExecuteNonQuery();

           conexao.Close();
        }      
    
  
       
    }
}