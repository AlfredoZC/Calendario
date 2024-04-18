Console.WriteLine("Ingrese el tiempo 1. Verano 2. Invierno 3. Otoño 4. Primavera ");
int option = int.Parse(Console.ReadLine());

switch (option){

    case 1:
        Console.WriteLine("Diciembre a marzo");
        break;
    case 2:
        Console.WriteLine("julio semtiembre ");
        break;
    case 3: 
        Console.WriteLine("otoño abril a junio");
        break;
    case 4: 
        Console.WriteLine("octubre noviembre");
        break;
    case 5:
        Console.WriteLine("Ingrese una opcio real porfavor");
        break;
}

