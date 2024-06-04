/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
    class Doar { 
        string nomeDoador = "", nomeLivroDoado = "", nomeAutor = "";
        
        public void MsnDoador ()
        {
           Console.WriteLine (nomeDoador+ " Obrigada Por doar o livro : "); 
           Console.WriteLine (nomeLivroDoado+", de "+ nomeAutor); 
           Console.WriteLine ("Os amantes da literatura mais necessitados agradece!"); 
          
        }
    
    class Livraria     
    {
        int escolhaMenu = 0;
        int escolhaTipo =0;
        int escolhaLivro = 4;
        double [] precoLivros = {10.20,15.30,20.30};
        string [] tiposLivros = {"ROMANCE", "SOCIAIS","ASSOMBROSOS"};
        
    
            public void cabecario ()
            {
                Console.WriteLine("***************************************");
                Console.WriteLine("         Livraria Sintra               ");
                Console.WriteLine("***************************************");
            }
            public void Menu ()
            {   
               
                Console.WriteLine("***************************************");
                Console.WriteLine("         Livraria Sintra               ");
                Console.WriteLine("***************************************");
                Console.WriteLine("Escolha uma das opções: " );
                Console.WriteLine("1 - Comprar livro");
                Console.WriteLine("2 - Doar livro");
                Console.WriteLine("3 - Sair");
                escolhaMenu = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                //LIMPATELA
            }
            
            static void Main()
            {   Livraria livros = new Livraria();
                Doar doacaoLivro = new Doar ();
                livros.Menu();
                
        
               bool emServico = true;  // a livraria está em serviço até escolher sair
        while ( emServico ) 
        {
            livros.Menu();
        
            switch (livros.escolhaMenu)
            {
                case 1:
                  //while (livros.escolhaLivro == 4)
                  //{
                    livros.cabecario();
                    Console.WriteLine("Escolha o tipo de livro que esta procurando: ");
                    Console.WriteLine ("1- "+livros.tiposLivros[0]);
                    Console.WriteLine ("2- "+livros.tiposLivros[1]);
                    Console.WriteLine ("3- "+livros.tiposLivros[2]);
                    livros.escolhaTipo = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    
                    if (livros.escolhaTipo == 1)
                    { 
                        livros.cabecario();
                        Console.WriteLine ("            "+livros.tiposLivros[0]+"                                  ");
                        Console.WriteLine ("1- Mil beijos de garoto, de Tillie Cole | "+ livros.precoLivros [0].ToString("0.00")+"€");
                        Console.WriteLine("2- Um verão na Itália, de Carrie Elks | "+ livros.precoLivros [1].ToString("0.00")+"€");
                        Console.WriteLine("3- Vergonha, de Brittainy C. Cherry | "+ livros.precoLivros [2].ToString("0.00")+"€");
                        Console.WriteLine("4- Voltar");
                        livros.escolhaLivro = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                    
                        if (livros.escolhaLivro == 1 || livros.escolhaLivro == 2 || livros.escolhaLivro == 3)
                        {
                            //LIMPATELA
                            livros.cabecario();
                            Console.WriteLine("*** Parabens pela compra! Volte Sempre ***");
                        }
                        else
                            {
                                  //LIMPA TELA 
                                  livros.Menu(); // volta apenas para o menu não entra
                            }
                    }
                    
                    if (livros.escolhaTipo == 2)
                        {
                            livros.cabecario();
                            Console.WriteLine ("            "+livros.tiposLivros[1]+"                                  ");
                            Console.WriteLine ("1- Utopia, de Roberto Coll | "+ livros.precoLivros [0].ToString("0.00")+"€");
                            Console.WriteLine("2- A Sociedade, de Carlos Souza | "+ livros.precoLivros [1].ToString("0.00")+"€");
                            Console.WriteLine("3- A verdade não dita, de Daniel C. Charlles | "+ livros.precoLivros [2].ToString("0.00")+"€");
                            Console.WriteLine("4- Voltar");
                            livros.escolhaLivro = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            
                            if (livros.escolhaLivro == 1 || livros.escolhaLivro == 2 || livros.escolhaLivro == 3)
                            {
                                //LIMPATELA
                                livros.cabecario();
                                Console.WriteLine("*** Parabens pela compra! Volte Sempre ***");
                            }
                            else
                            {
                                  //LIMPA TELA 
                                  livros.Menu(); // volta apenas para o menu não entra
                            }
                        
                        }
                   
                    if (livros.escolhaTipo == 3)
                    { 
                        livros.cabecario();
                        Console.WriteLine ("            "+livros.tiposLivros[2]+"                                  ");
                        Console.WriteLine ("1- Na Madrugada, de Tina Cole | "+ livros.precoLivros [0].ToString("0.00")+"€");
                        Console.WriteLine("2- A noite da minha vida, de Carla Elks | "+ livros.precoLivros [1].ToString("0.00")+"€");
                        Console.WriteLine("3- A coisa, de Bianca C. Cherry | "+ livros.precoLivros [2].ToString("0.00")+"€");
                        Console.WriteLine("4- Voltar");
                        livros.escolhaLivro = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                    
                        if (livros.escolhaLivro == 1 || livros.escolhaLivro == 2 || livros.escolhaLivro == 3)
                        {
                            //LIMPATELA
                            livros.cabecario();
                            Console.WriteLine("*** Parabens pela compra! Volte Sempre ***");
                          
                        }
                        else
                            {
                                  //LIMPA TELA 
                                  livros.Menu(); // volta apenas para o menu 
                            }
                    }
                  //}    
                    break;
                    case 2:
                        livros.cabecario();
                        Console.WriteLine ("Digite seu nome: ");
                        doacaoLivro.nomeDoador=Console.ReadLine();
                        Console.WriteLine ("Digite o nome do livro: ");
                        doacaoLivro.nomeLivroDoado=Console.ReadLine();
                        Console.WriteLine ("Digite o nome do autor: ");
                        doacaoLivro.nomeAutor=Console.ReadLine();
                        Console.Clear();
                        livros.cabecario();
                        doacaoLivro.MsnDoador ();
                     break;
                    case 3:
                    emServico = false;
                    Console.WriteLine("Xau!!!");
                    break;
                    default:
                    Console.WriteLine("Opção inválida!!!");
                    Console.ReadKey();
                    break;
                 }
                 if (emServico == true)
                 {
                 Console.Write("Tecle para continuar");
                 Console.ReadKey();
                 }
                 
           
            }
                 
        }
            
             
            
        }
    }