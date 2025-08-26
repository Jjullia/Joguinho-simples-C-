# Joguinho-simples-C-
Este é um projeto simples para iniciantes em C#, onde o jogador tenta adivinhar um número secreto entre 1 e 100, gerado pelo computador. O jogo, rodado no console, oferece dicas como "muito alto" ou "muito baixo" a cada tentativa. O objetivo é adivinhar o número no menor número de palpites possível, aprendendo conceitos básicos de programação.

Funcionalidades
Geração de Número Aleatório: O jogo gera um número inteiro aleatório entre 1 e 100 no início de cada partida.
Entrada do Jogador: O programa solicita ao jogador que digite seu palpite. A entrada é validada para garantir que seja um número válido.
Sistema de Dicas: Após cada palpite, o programa compara a tentativa do jogador com o número secreto e fornece uma das seguintes dicas:
"Seu palpite está muito baixo. Tente um número maior."
"Seu palpite está muito alto. Tente um número menor."
Contagem de Tentativas: O jogo registra e exibe o número de tentativas que o jogador levou para acertar o número.
Mensagem de Vitória: Quando o jogador acerta o número, uma mensagem de parabéns é exibida, mostrando o número secreto e a quantidade de tentativas que ele precisou.
Loop do Jogo: O programa permite que o jogador jogue novamente após acertar o número, ou encerrar a aplicação.

Requisitos Técnicos
Linguagem: C#

Ambiente: Console Application

Conceitos de Programação:

Variáveis e Tipos de Dados: Para armazenar o número secreto, o palpite do jogador e a contagem de tentativas.

Estruturas de Controle:

if/else if/else: Para verificar a condição do palpite do jogador e fornecer a dica correta.

while ou do-while: Para criar um loop que continua o jogo até o número ser adivinhado.

Métodos e Funções: Utilização de métodos como Console.WriteLine para exibir mensagens, e Console.ReadLine para obter a entrada do usuário.

Classe Random: Para gerar o número aleatório.

Conversão de Tipos: A entrada do usuário (string) precisará ser convertida para um número inteiro (int) para a comparação.

Como funciona
O jogo começa gerando um número aleatório.

O programa entra em um loop infinito que só é quebrado quando o jogador adivinha o número correto.

Dentro do loop, o programa pede um palpite ao jogador.

O palpite é lido, validado e convertido.

O programa compara o palpite com o número secreto.

Com base na comparação, ele exibe uma das dicas.

A contagem de tentativas é incrementada a cada palpite.

Quando o palpite é igual ao número secreto, o loop é encerrado, e a mensagem de vitória é mostrada.

O programa pergunta se o jogador quer jogar novamente.
