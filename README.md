# transire
Projeto de avaliação técnica para o Instituto Transire

1. Projeto
	Loja de produtos online, com cadastro de produtos e categorias.
	Desenvolvido em ASP.Net utilizando MVC 5, Entity Framework, Razor e Bootstrap.
	Banco de dados SQL Server Express 2017
2. Configuração
	Banco de dados:
		- Executar Scripts localizados na pasta SQL Scripts na ordem:
			1. create_db_transirestore.sql
			2. create_tbl_category.sql
			3. create_tbl_product.sql
	Aplicaction Deploy IIS:
		- Publicar o conteúdo da pasta Deploy no IIS