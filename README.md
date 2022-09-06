# Placar ping pong
Um placar de tênis de mesa, completo, em C# (forms .NET)

![placar](https://user-images.githubusercontent.com/66328408/188745808-406da540-ae47-473e-817e-52247c2b805e.png)
Essa é a aparência do placar, tem uma navegação simples e até instruções de como usar.

Ao abrir o projeto no Visual Studio, você deverá alterar o arquivo "conexao.cs", incluindo um banco de dados válido.
![image](https://user-images.githubusercontent.com/66328408/130221604-53027a76-9524-4a3c-8ea9-c5f30e713fda.png) <br><br>
Seu banco de dados deverá ter a tabela "tb01_resultados", com os seguintes campos:
![image](https://user-images.githubusercontent.com/66328408/130221993-a42e9f01-0f93-4f24-9f02-b25ea2fdb6f6.png)
(exemplo no phpmyadmin).

É possível usar um banco de dados local, utilizando por exemplo o Laragon, disponível em: https://laragon.org/download/index.html.
Após iniciar, clique em MENU, e navegue até MySQL <br><br>
![image](https://user-images.githubusercontent.com/66328408/130222497-bafb9434-a7e5-4d9b-9af5-a9f9214b7b45.png) <br>
Você pode alterar a senha root (na primeira imagem, essa senha é o Pdw, setado como "micael",
e selecionar phpMyAdmin ou HeidiSQL (recomendado phpMyAdmin).

Após o banco de dados estar conectado, o projeto deve funcionar.

Siga o caminho para chegar no aplicativo > C:\Users\...\Placar-Ping-Pong\Placar-Ping-Pong\bin\Debug > Placar-Ping-Pong (aplicativo)
você pode criar um atalho desse aplicativo e deixar na sua pasta de preferência.
![image](https://user-images.githubusercontent.com/66328408/130223632-6059a74a-16ba-449f-92ad-3b4184be9fbd.png)


<br><br>

Caso queira utilizar uma versão mais simples, que não grave os registros, você pode apenas baixar o Placar Simples e executá-lo. :)
