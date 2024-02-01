# Aplicação Console com Cores Personalizadas

Este é um exemplo de código que utiliza a função `ColorText` para imprimir texto colorido no console. A função aceita uma string representando o nome da cor, tanto em maiúsculas quanto em minúsculas, e utiliza a enumeração `ConsoleColor` para configurar a cor do texto.

## Função ColorText

A função `ColorText` está localizada no início do código. Aqui está um resumo de como ela funciona:

```csharp
public static void ColorText(string texto, string cor)
{
    // Tenta converter a string 'cor' para um valor do enum ConsoleColor.
    // O parâmetro 'true' indica que a conversão é insensível a maiúsculas/minúsculas.
    // A variável 'consoleColor' será usada para armazenar o resultado da conversão com o 'out' definindo a saída do resultado.
    if (!Enum.TryParse<ConsoleColor>(cor, true, out ConsoleColor consoleColor))
    {
        // Lança uma exceção indicando que a cor é inválida se a conversão falhar.
        throw new ArgumentException("Cor inválida", nameof(cor));
    }

    Console.ForegroundColor = consoleColor;

    Console.WriteLine(texto);

    // Volta a cor original do console.
    Console.ResetColor();

    // Exemplo de uso:
    ColorText("Hello World! Esta mensagem está em magenta.", "Magenta");
}
```
