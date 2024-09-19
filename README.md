# Projeto 3 - Sistema gerenciador de reservas de hotel

## Requisitos

-   O sistema deve receber requisições para criar reservas de hospedagem.
-   Cada reserva deve durar 1 dia;
-   Validações para que uma reserva seja agendada:
-   O quarto deve estar disponível na data especificada;
-   O hóspede deve estar ativo.
-   Ao final da requisição, o sistema deve:
-   Enviar e-mail para o hóspede notificando-o sobre o resultado de sua reserva (sucesso ou falha) e detalhes

## Classes sugeridas

-   Hóspede

    -   ID: String;
    -   Nome: String;
    -   Email: String;
    -   Ativo: Boolean;

-   Quarto

    -   ID: String;
    -   Número: String;
    -   Categoria: String;

-   Reserva
    -   ID: String;
    -   Hospede: Hospede;
    -   Quarto: Quarto;
    -   Data: Data/Hora;

## Endpoints

-   POST /quartos/:idQuarto/reservas
-   Esse endpoint deve criar uma reserva para o hóspede especificado no quarto especificado.
-   Parâmetros
    -   URL: ID do quarto
    -   Corpo da requisição:
        -   ID do hóspede
        -   Data da reserva
-   Retorno: Reserva

-   POST /categorias/:nomeCategoria/reservas
-   Esse endpoint deve criar uma reserva para o hóspede especificado com um quarto disponível e aleatoriamente selecionado dentro da categoria especificada.
-   Parâmetros
    -   URL: Nome da categoria
    -   Corpo da requisição:
        -   ID do hóspede
        -   Data da reserva
-   Retorno: Reserva
