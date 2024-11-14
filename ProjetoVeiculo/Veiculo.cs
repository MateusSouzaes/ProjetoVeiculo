



public class Veiculo
{
    private string _niv;
    public string _modelo;
    public string _placa;



    public void SetNiv(string niv)
    {
        if (niv.Length == 17)
        {
            _niv = niv;
        }
        else
        {
            throw new Exception("O NIV está fora do padrão, precisa ter 17 caracteres");
        }
    }
    public string GetNiv()
    {
        return _niv;

    }


}


