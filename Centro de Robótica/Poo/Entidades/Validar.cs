using System.Text.RegularExpressions;

static class Validar
{
    private static bool ValidarEmail(string email)
    {
        // Padrão Regex
        string padraoEmail = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        return Regex.IsMatch(email, padraoEmail);
    }
    private static bool ValidarSenha(string senha)
    {
        //Senha é minimo 6, caracteres, numeros, letras maiusculas e minusculas
        string padraoSenha = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{6,}$";
        return Regex.IsMatch(senha, padraoSenha);
    }
    public static bool ValidarEmailSenha(string email, string senha)
    {
        return ValidarEmail(email) && ValidarSenha(senha);
    }
}