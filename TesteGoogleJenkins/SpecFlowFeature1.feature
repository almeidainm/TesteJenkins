#language: pt-br
Funcionalidade: Acessa o Google e verifica se a busca retornou com sucesso


Cenário: Acessar o Google
	Dado que eu acesse o Google
	E digite "Inmetrics" na busca
	Quando clico no botão buscar
	Então verifico se o site da inmetrics voltou na busca
