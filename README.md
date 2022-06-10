# API-Conexao
Api que conecta no mysql que esta rodando em container 

# Comando que cria tabela do Banco do Mysql

CREATE TABLE `produtos` (
  `id` bigint NOT NULL AUTO_INCREMENT,
  `nome` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
)
