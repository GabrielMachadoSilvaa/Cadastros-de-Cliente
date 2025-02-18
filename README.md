📋 Sistema de Cadastro - C# Windows Forms + MySQL
Este projeto é um sistema de cadastro desenvolvido em C# Windows Forms com MySQL, permitindo operações de inclusão, edição, exclusão e consulta de registros.

🔹 Tecnologias Utilizadas
C# (Windows Forms)
MySQL (Banco de dados)
MySQL Workbench
XAMPP (para o servidor MySQL)

🛠️ Pré-requisitos
Para executar este projeto corretamente, certifique-se de ter instalado:
✅ XAMPP (para rodar o servidor MySQL)
✅ MySQL Workbench (para gerenciar o banco de dados)
✅ Visual Studio (para rodar o projeto em C#)

🏛️ Banco de Dados
Antes de rodar a aplicação, crie o banco de dados executando o seguinte script no MySQL Workbench:

sql

CREATE DATABASE ExemploDB;
USE ExemploDB;

CREATE TABLE Usuarios (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(50) NOT NULL,
    Idade INT NOT NULL
);

📌 Estrutura do Projeto
Form1.cs → Interface principal do sistema
Conexao.cs → Classe de conexão com o banco de dados
Cadastro.cs → Classe responsável pelas operações CRUD

🚀 Como Executar
Inicie o servidor MySQL pelo XAMPP
Execute o script SQL no MySQL Workbench
Clone o repositório 
Abra o projeto no Visual Studio
Configure a string de conexão no código para apontar para o seu banco MySQL
Execute a aplicação

📜 Licença
Este projeto está sob a licença MIT.

