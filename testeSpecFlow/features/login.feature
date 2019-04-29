Feature: Permitirlogin na pagina

Scenario: Permitir login com sucesso
	Given Dado que estou na pagina "https://automation-sandbox.herokuapp.com/"
	When Eu informar "demouser" no campo "login"
	And Eu informar "abc123" no campo "senha"
	And Eu clicar no botao "btnlogar"
	Then Dever ser apresentado o text "Invoice" no campo "label"
