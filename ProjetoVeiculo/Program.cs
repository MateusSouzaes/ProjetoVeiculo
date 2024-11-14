

Veiculo v1 = new Veiculo();
v1._placa = "QBE-8324";
v1._modelo = "Saveiro G6";

try
{
    v1.SetNiv("0561561");

}catch(Exception e)
{
    Console.WriteLine(e.Message);
}

Console.WriteLine(v1._placa);
Console.WriteLine(v1._modelo);

/*try
{
    v1.SetNiv("12345678901234567");

}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}*/

Console.WriteLine(v1.GetNiv());


