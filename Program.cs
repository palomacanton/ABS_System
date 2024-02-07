using ABS_System.Models;

string opcao = "";
bool condicao = true;
Console.WriteLine("Digite sua escolha: \n1 - Coca\n2 - Guaraná\n3 - Suco de Laranja\n4 - Suco de Uva");

while(condicao == true){
    switch (Console.ReadLine())
    {
        case "1":
            opcao = "Coca";
            condicao = false;
            break;

        case "2":
            opcao = "Guaraná";
            condicao = false;
            break;

        case "3":
            opcao = "Suco de Laranja";
            condicao = false;
            break;

        case "4":
            opcao = "Suco de Uva";
            condicao = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            condicao = true;
            break;
    }
}


if(opcao == "Coca"){
    Coca coca = new();
    coca.Escolha();
    coca.OpcaoGelo();
    coca.ComerNoRestaurante();
    coca.PedidoRealizado();
}else {
    if(opcao == "Guaraná"){
        Guarana guarana = new();
        guarana.Escolha();
        guarana.OpcaoGelo();
        guarana.ComerNoRestaurante();
        guarana.PedidoRealizado();
    }else{
        if(opcao == "Suco de Laranja"){
            SucoDeLaranja sucoDeLaranja = new();
            sucoDeLaranja.Escolha();
            sucoDeLaranja.OpcaoGelo();
            sucoDeLaranja.ComerNoRestaurante();
            sucoDeLaranja.PedidoRealizado();
        }else{
            if(opcao == "Suco de Uva"){
                SucoDeUva sucoDeUva = new();
                sucoDeUva.Escolha();
                sucoDeUva.OpcaoGelo();
                sucoDeUva.ComerNoRestaurante();
                sucoDeUva.PedidoRealizado();
            }
        }
    }
}

