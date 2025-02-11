namespace Tasks
{
    public class Task2
    {
        /*
         * Construa um método que receba uma string contendo um valor e retorne um bool de acordo com a validação:
         * 
         * 3 Letras maiúsculas
         * 4 digitos (0-9)
         * 1 letra minúscula
         * 
         * Exemplos de entradas validas: 
         * 1 - ABC1234a
         * 2 - QAZ0987b
         * 3 - WSX1324c
         * 
         * Exemplos de entradas inválidas: 
         * 1 - ABC-1234
         * 2 - QAZ1987
         * 3 - abc1324
         * 4 - az111W
         */
        public static bool CheckInput(string input) 
        {

             if (string.IsNullOrEmpty(input) || input.Length != 8)
        return false;

    int upperCount = 0;
    int digitCount = 0;
    int lowerCount = 0;

    foreach (char c in input)
    {
        if (char.IsUpper(c))
            upperCount++;
        else if (char.IsDigit(c))
            digitCount++;
        else if (char.IsLower(c))
            lowerCount++;
    }

    return upperCount == 3 && digitCount == 4 && lowerCount == 1;
         }
    }
}
