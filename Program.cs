using System;
using System.Collections.Generic;
using System.Text;




namespace Atividade1LP2
{
    class Program
    {
         

        static void Main(string[] args)
        {
            Banco Teste = new Banco("Teste");
            Agencia a = new Agencia("a");
            Agencia b = new Agencia("b");
            Agencia c = new Agencia("c");

            
            Teste.AdicionarAgencia(a);
            Teste.AdicionarAgencia(b);
            Teste.AdicionarAgencia(c);

            
            ContaCorrente pessoa1 = new ContaCorrente("Maria");
            ContaPoupanca pessoa2 = new ContaPoupanca(100, DateTime.Now, "Joana");
            ContaCorrente pessoa3 = new ContaCorrente("Jose");
            ContaPoupanca pessoa4 = new ContaPoupanca(100, DateTime.Now, "Pedro");
            ContaCorrente pessoa5 = new ContaCorrente("Janaina");
            ContaPoupanca pessoa6 = new ContaPoupanca(100, DateTime.Now, "Alice");

           
            pessoa1.Depositar(100);
            pessoa2.Depositar(150);
            pessoa3.Depositar(200);
            pessoa4.Depositar(250);
            pessoa5.Depositar(300);
            pessoa6.Depositar(350);
          
            a.AdicionarContaCorrente(pessoa1);
            a.AdicionarContaPoupanca(pessoa2);
            b.AdicionarContaCorrente(pessoa3);
            b.AdicionarContaPoupanca(pessoa4);
            c.AdicionarContaCorrente(pessoa5);
            c.AdicionarContaPoupanca(pessoa6);

          
            int opcao = 1, redundancia = 0;
            while (opcao != 0)
            {
                Console.WriteLine("BEM VINDO(A)!!");
                Console.WriteLine("Digite uma das opcoes abaixo:");
                Console.WriteLine("1-----Abrir Conta");
                Console.WriteLine("2-----Fechar Conta");
                Console.WriteLine("3--Consultar Saldo");
                Console.WriteLine("4---Depositar Saldo");
                Console.WriteLine("5----Sacar Saldo");
                Console.WriteLine("6----Transferir Saldo");
                Console.WriteLine("0-----Para sair");

                opcao = Int32.Parse(Console.ReadLine());

                if (opcao == 0)
                {
                    Console.WriteLine("A disposicao!");
                    return;
                }
                else if (opcao == 1)
                {
                    
                    Console.Clear();
                    int aux;
                    string nomeAgencia;
                    Agencia novaconta;
                    Console.WriteLine("Abrindo Conta");
                    Console.WriteLine("Listas de Agências Disponíveis");
                    Teste.ListarAgencia();
                    Console.WriteLine("Digite o Nome da Agencia que deseja abrir uma conta:\n");
                    nomeAgencia = Console.ReadLine();
                    Console.Clear();
                    novaconta = Teste.BuscarAgencia(nomeAgencia);

                    if (novaconta == null)
                    {
                        Console.WriteLine("Voltando Para o menu inicial");
                        continue;
                    }
                    

                    Console.WriteLine("Digite 1, para conta Poupança");
                    Console.WriteLine("Digite 2, para conta Corrente");
                    aux = Int32.Parse(Console.ReadLine());
                    if (aux == 1)
                    {
                        

                        string nome;
                        Console.WriteLine("Digite o Seu nome");
                        nome = Console.ReadLine();
                        ContaPoupanca nova = new ContaPoupanca(100, DateTime.Now, nome);
                        novaconta.AdicionarContaPoupanca(nova);
                        Console.Clear();
                        Console.WriteLine("Parabéns " + nome + " Agora voce é um Cliente do Banco Teste");
                        Console.ReadKey();
                        continue;
                    }
                    else if (aux == 2)
                    {
                        
                        string nome;

                        Console.WriteLine("Digite o Seu nome");
                        nome = Console.ReadLine();
                        ContaCorrente nova = new ContaCorrente(nome);
                        novaconta.AdicionarContaCorrente(nova);
                        Console.Clear();
                        Console.WriteLine("Parabéns " + nome + " Agora voce é um Cliente do Banco Teste");
                        Console.ReadKey();
                        continue;
                    }


                }
                else if (opcao == 2)
                {

                    Console.Clear();
                    int aux;
                    string nomeAgencia;
                    Agencia excluirconta;
                    Console.WriteLine("Fechando Conta");
                    Console.WriteLine("Listas de Agências Disponíveis");
                    Teste.ListarAgencia();
                    Console.WriteLine("Digite o Nome da Agencia que sua conta é cadastrada:\n");
                    nomeAgencia = Console.ReadLine();
                    Console.Clear();
                    excluirconta = Teste.BuscarAgencia(nomeAgencia);

                    if (excluirconta == null)
                    {
                        Console.WriteLine("Voltando Para o menu inicial");
                        continue;
                    }
                    

                    Console.WriteLine("Para conta Poupança Digite 1");
                    Console.WriteLine("Para conta Corrente Digite 2");
                    aux = Int32.Parse(Console.ReadLine());
                    if (aux == 1)
                    {
                        

                        string nome;
                        Console.WriteLine("Digite o Seu nome");
                        nome = Console.ReadLine();
                        excluirconta.ExcluircontaP(nome);
                        Console.ReadKey();
                        continue;
                    }
                    else if (aux == 2)
                    {
                        
                        string nome;
                        Console.WriteLine("Digite o Seu nome");
                        nome = Console.ReadLine();
                        excluirconta.Excluirconta(nome);
                        Console.ReadKey();
                        continue;

                    }


                }
                else if (opcao == 3)
                {
                    Console.Clear();
                    Console.WriteLine("CONSULTANDO SALDO:");
                    string nomeAgencia;
                    int aux;
                    Agencia consultarsaldo;
                    Console.WriteLine("Listas de Agências");
                    Teste.ListarAgencia();
                    Console.WriteLine("Digite o Nome da sua Agencia");
                    nomeAgencia = Console.ReadLine();
                    consultarsaldo = Teste.BuscarAgencia(nomeAgencia);
                    if (consultarsaldo == null)
                    {
                        Console.WriteLine("Voltando Para o menu inicial");
                        continue;
                    }
                    Console.Clear();
                    Console.WriteLine("Para Consultar Saldo de conta Poupança Digite 1");
                    Console.WriteLine("Para Consultar Saldo de conta Corrente Digite 2");
                    aux = Int32.Parse(Console.ReadLine());
                    if (aux == 1)
                    {
                        
                        ContaPoupanca consultar;
                        string cliente;
                        Console.WriteLine("Digite o Nome do Titular da Conta");
                        cliente = Console.ReadLine();
                        consultar = consultarsaldo.BuscarClienteP(cliente);
                        if (consultar == null)
                        {
                            Console.WriteLine("Voltando Para o menu inicial");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Seu Saldo é: " + consultar.Saldo);
                            Console.ReadKey();
                        }

                    }
                    if (aux == 2)
                    {
                        
                        ContaCorrente consultar;
                        string cliente;
                        Console.WriteLine("Digite o Nome do Titular da Conta");
                        cliente = Console.ReadLine();
                        consultar = consultarsaldo.BuscarCliente(cliente);
                        if (consultar == null)
                        {
                            Console.WriteLine("Voltando Para o menu inicial");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Seu Saldo é: " + consultar.Saldo);
                            Console.ReadKey();
                        }

                    }

                }
                else if (opcao == 4)
                {
                   
                    Console.Clear();
                    Console.WriteLine("DEPOSINTANDO SALDO:");
                    string nomeAgencia;
                    int aux;
                    Agencia depositandosaldo;
                    Console.WriteLine("Listas de Agências");
                    Teste.ListarAgencia();
                    Console.WriteLine("Digite o Nome da sua Agencia");
                    nomeAgencia = Console.ReadLine();
                    depositandosaldo = Teste.BuscarAgencia(nomeAgencia);
                    if (depositandosaldo == null)
                    {
                        Console.WriteLine("Voltando Para o menu inicial");
                        continue;
                    }
                    Console.Clear();
                    Console.WriteLine("Para Consultar Saldo de conta Poupança Digite 1");
                    Console.WriteLine("Para Consultar Saldo de conta Corrente Digite 2");
                    aux = Int32.Parse(Console.ReadLine());
                    if (aux == 1)
                    {
                        
                        ContaPoupanca depositar;
                        string cliente;
                        Console.WriteLine("Digite o Nome do Titular da Conta");
                        cliente = Console.ReadLine();
                        depositar = depositandosaldo.BuscarClienteP(cliente);
                        if (depositar == null)
                        {
                            Console.WriteLine("Voltando Para o menu inicial");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Digite o Valor do Depósito");
                            decimal valor;
                            valor = decimal.Parse(Console.ReadLine());
                            depositar.Depositar(valor);
                            Console.WriteLine(valor + " Foi depositado com Sucesso na conta: " + depositar.Titular);
                            Console.ReadKey();
                            continue;
                        }

                    }
                    if (aux == 2)
                    {
                        ContaCorrente depositar;
                        string cliente;
                        Console.WriteLine("Digite o Nome do Titular da Conta");
                        cliente = Console.ReadLine();
                        depositar = depositandosaldo.BuscarCliente(cliente);
                        if (depositar == null)
                        {
                            Console.WriteLine("Voltando Para o menu inicial");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Digite o Valor do Depósito");
                            decimal valor;
                            valor = decimal.Parse(Console.ReadLine());
                            depositar.Depositar(valor);
                            Console.WriteLine(valor + " Foi depositado com Sucesso na conta:" + depositar.Titular);
                            Console.ReadKey();
                            continue;
                        }
                    }
                }
                else if (opcao == 5)
                {
                    
                    Console.Clear();
                    Console.WriteLine("SACANDO SALDO:");
                    string nomeAgencia;
                    int aux;
                    Agencia sacandosaldo;
                    Console.WriteLine("Listas de Agências");
                    Teste.ListarAgencia();
                    Console.WriteLine("Digite o Nome da sua Agencia");
                    nomeAgencia = Console.ReadLine();
                    sacandosaldo = Teste.BuscarAgencia(nomeAgencia);
                    if (sacandosaldo == null)
                    {
                        Console.WriteLine("Voltando Para o menu inicial");
                        continue;
                    }
                    Console.Clear();
                    Console.WriteLine("Para Sacar Saldo de conta Poupança Digite 1");
                    Console.WriteLine("Para Sacar Saldo de conta Corrente Digite 2");
                    aux = Int32.Parse(Console.ReadLine());
                    if (aux == 1)
                    {
                        ContaPoupanca sacar;
                        string cliente;
                        Console.WriteLine("Digite o Nome do Titular da Conta");
                        cliente = Console.ReadLine();
                        sacar = sacandosaldo.BuscarClienteP(cliente);
                        if (sacar == null)
                        {
                            Console.WriteLine("Voltando Para o menu inicial");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Digite o Valor do Depósito");
                            decimal valor;
                            valor = decimal.Parse(Console.ReadLine());
                            sacar.Sacar(valor);
                            Console.WriteLine(valor + " Foi sacado com Sucesso da conta:" + sacar.Titular);
                            Console.ReadKey();
                            continue;
                        }

                    }
                    if (aux == 2)
                    {
                        ContaCorrente sacar;
                        string cliente;
                        Console.WriteLine("Digite o Nome do Titular da Conta");
                        cliente = Console.ReadLine();
                        sacar = sacandosaldo.BuscarCliente(cliente);
                        if (sacar == null)
                        {
                            Console.WriteLine("Voltando Para o menu inicial");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Digite o Valor do Depósito");
                            decimal valor;
                            valor = decimal.Parse(Console.ReadLine());
                            sacar.Sacar(valor);
                            Console.WriteLine(valor + " Foi sacado com Sucesso da conta:" + sacar.Titular);
                            Console.ReadKey();
                            continue;
                        }
                    }
                }
                else if (opcao == 6)
                {
                    Console.WriteLine("TRANSFERINDO SALDO:");
                    string nomeAgencia;
                    int aux;
                    Agencia trasnferir;
                    Console.WriteLine("Listas de Agências");
                    Teste.ListarAgencia();
                    Console.WriteLine("Digite o Nome da sua Agencia");
                    nomeAgencia = Console.ReadLine();
                    trasnferir = Teste.BuscarAgencia(nomeAgencia);
                    if (trasnferir == null)
                    {
                        Console.WriteLine("Voltando Para o menu inicial");
                        continue;
                    }
                    Console.Clear();
                    Console.WriteLine("Para Trasferir Saldo de conta Poupança Digite 1");
                    Console.WriteLine("Para Transferir Saldo de conta Corrente Digite 2");
                    aux = Int32.Parse(Console.ReadLine());
                    if (aux == 1)
                    {
                        
                        ContaPoupanca trasferirP;
                        string cliente;
                        Console.WriteLine("Digite o Nome do Titular da Conta");
                        cliente = Console.ReadLine();
                        trasferirP = trasnferir.BuscarClienteP(cliente);
                        if (trasferirP == null)
                        {
                            Console.WriteLine("Voltando Para o menu inicial");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Digite o Valor a Ser tranferido: ");
                            decimal valor = decimal.Parse(Console.ReadLine());
                            

                            Console.Clear();
                            Console.WriteLine("BUSCANDO CONTA A TRANSFERIR DINHEIRO");
                            Agencia trasnferir2;
                            Console.WriteLine("Listas de Agências");
                            Teste.ListarAgencia();
                            Console.WriteLine("Digite o Nome da sua Agencia");
                            nomeAgencia = Console.ReadLine();
                            trasnferir2 = Teste.BuscarAgencia(nomeAgencia);
                            if (trasnferir2 == null)
                            {
                                Console.WriteLine("Voltando Para o menu inicial");
                                continue;
                            }
                            Console.Clear();
                            Console.WriteLine("Para Trasferir Saldo para conta Poupança Digite 1");
                            Console.WriteLine("Para Transferir Saldo para conta Corrente Digite 2");
                            aux = Int32.Parse(Console.ReadLine());
                            if (aux == 1)
                            {
                                ContaPoupanca receber;
                                string cliente2;
                                Console.WriteLine("Digite o Nome do Titular da Conta");
                                cliente2 = Console.ReadLine();
                                receber = trasnferir2.BuscarClienteP(cliente2);
                                if (receber == null)
                                {
                                    Console.WriteLine("Voltando Para o menu inicial");
                                    continue;
                                }
                                

                                trasferirP.Sacar(valor);
                                receber.Depositar(valor);
                                Console.WriteLine(valor + " For retirado da conta: " + trasferirP.Titular + " e " + valor + "Foi depositado na conta: " + receber.Titular);
                                Console.ReadKey();
                                continue;
                            }
                            else if (aux == 2)
                            {
                                ContaCorrente receber;
                                string cliente2;
                                Console.WriteLine("Digite o Nome do Titular da Conta");
                                cliente2 = Console.ReadLine();
                                receber = trasnferir2.BuscarCliente(cliente2);
                                if (receber == null)
                                {
                                    Console.WriteLine("Voltando Para o menu inicial");
                                    continue;
                                }
                                

                                trasferirP.Sacar(valor);
                                receber.Depositar(valor);
                                Console.WriteLine(valor + " For retirado da conta: " + trasferirP.Titular + " e " + valor + "Foi depositado na conta: " + receber.Titular);
                                Console.ReadKey();
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("Opção inválida");
                                Console.WriteLine("Voltando ao menu iniciar");
                                Console.ReadKey();
                                continue;
                            }

                        }

                    }
                    if (aux == 2)
                    {
                        
                        ContaCorrente trasferirP;
                        string cliente;
                        Console.WriteLine("Digite o Nome do Titular da Conta");
                        cliente = Console.ReadLine();
                        trasferirP = trasnferir.BuscarCliente(cliente);
                        if (trasferirP == null)
                        {
                            Console.WriteLine("Voltando Para o menu inicial");
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Digite o Valor a Ser tranferido: ");
                            decimal valor = decimal.Parse(Console.ReadLine());
                            

                            Console.Clear();
                            Console.WriteLine("BUSCANDO CONTA A TRANSFERIR DINHEIRO");
                            Agencia trasnferir2;
                            Console.WriteLine("Listas de Agências");
                            Teste.ListarAgencia();
                            Console.WriteLine("Digite o Nome da sua Agencia");
                            nomeAgencia = Console.ReadLine();
                            trasnferir2 = Teste.BuscarAgencia(nomeAgencia);
                            if (trasnferir2 == null)
                            {
                                Console.WriteLine("Voltando Para o menu inicial");
                                continue;
                            }
                            Console.Clear();
                            Console.WriteLine("Para Trasferir Saldo para conta Poupança Digite 1");
                            Console.WriteLine("Para Transferir Saldo para conta Corrente Digite 2");
                            aux = Int32.Parse(Console.ReadLine());
                            if (aux == 1)
                            {
                                ContaPoupanca receber;
                                string cliente2;
                                Console.WriteLine("Digite o Nome do Titular da Conta");
                                cliente2 = Console.ReadLine();
                                receber = trasnferir2.BuscarClienteP(cliente2);
                                if (receber == null)
                                {
                                    Console.WriteLine("Voltando Para o menu inicial");
                                    continue;
                                }
                                

                                trasferirP.Sacar(valor);
                                receber.Depositar(valor);
                                Console.WriteLine(valor + " For retirado da conta: " + trasferirP.Titular + " e " + valor + "Foi depositado na conta: " + receber.Titular);
                                Console.ReadKey();
                                continue;
                            }
                            else if (aux == 2)
                            {
                                ContaCorrente receber;
                                string cliente2;
                                Console.WriteLine("Digite o Nome do Titular da Conta");
                                cliente2 = Console.ReadLine();
                                receber = trasnferir2.BuscarCliente(cliente2);
                                if (receber == null)
                                {
                                    Console.WriteLine("Voltando Para o menu inicial");
                                    continue;
                                }
                                
                                trasferirP.Sacar(valor);
                                receber.Depositar(valor);
                                Console.WriteLine(valor + " For retirado da conta: " + trasferirP.Titular + " e " + valor + "Foi depositado na conta: " + receber.Titular);
                                Console.ReadKey();
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("Opção inválida");
                                Console.WriteLine("Voltando ao menu iniciar");
                                Console.ReadKey();
                                continue;
                            }
                        }

                    }
                }
            }
        }
    }
}