/*
 * 1. Criar um vetor com 1000 posições;
 * 2. A cada 4 posições, substituir o 4o por 0;
 * 3. Randomizar as 3 posições anteriores ao 0 entre os números de 2 a 250;
 * 4. Criar um vetor de sáida com 250 posições;
 * 5. Para o primeiro elemento fazer a média entre os 3 elementos anteriores
 * do outro vetor e para o segundo substituir por 0, e assim por diante;
 */

// atribuições
int[] vetoraux = new int[1000];
int contador = 1;
var aleatorio = new Random();
int[] vetorSaida = new int[250];
int indiceSaida = 0;

// cria o indice i para o vetor auxiliar
for (int i = 0; i < vetoraux.Length; i++)
{
    contador++;

    // após a contagem atingir a quarta posição, ele determina o valor dos últimos 4 índices
    if (contador > 4)
    {
        vetoraux[i] = 0;
        vetoraux[i - 1] = aleatorio.Next(5, 250);
        vetoraux[i - 2] = aleatorio.Next(5, 250);
        vetoraux[i - 3] = aleatorio.Next(5, 250);

        // impede o indice do vetor saida de ser superior a 250 (capacidade máxima do vetor saída)
        if (indiceSaida >= 250)
        {
            break;
        }

        // realiza a média dos 3 primeiros números do vetor auxiliar e os coloca na posição 0 do vetor saida
        vetorSaida[indiceSaida] = (vetoraux[i - 1] + vetoraux[i - 2] + vetoraux[i - 3]) / 3;
        // pula dois endereços, considerando que a 2a posição do vetor saida é 0
        indiceSaida += 2;

        contador = 1;
    }
}
// transforma o vetor em string e o mostra na tela
string saida = string.Join(", ", vetorSaida);
Console.WriteLine(saida);
Console.Read();