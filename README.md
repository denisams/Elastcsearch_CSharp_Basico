# Elastcsearch_CSharp_Basico
Uma conexão simples do C Sharp com o Elasticsearch no docker

Baixar o ElasticSearch no Docker: docker pull elasticsearch:6.4.0
Executar localmente: docker run --restart=always -d --name elasticsearch -p 9200:9200 -e "http.host=0.0.0.0" -e "transport.host=127.0.0.1" elasticsearch:6.4.0

#curl de teste
curl -u elastic:changeme -XGET 'http://localhost:9200/'

Curl de inserir dados no elastc search

curl --location --request POST 'localhost:9200/livros/livros/1' \
--header 'Content-Type: application/json' \
--data-raw '{
    "Titulo": "O Cara Perdido", 
    "Isbn": "19844" 
}'

------------------

curl --location --request POST 'localhost:9200/livros/livros/2' \
--header 'Content-Type: application/json' \
--data-raw '{
    "Titulo": "Incêndio em alto mar", 
    "Isbn": "99999" 
}'


Curl Buscar dados
curl --location --request GET 'http://localhost:9200/livros/_search'


Usado no Visual Studio para Conexão com o Nest
install-package NEST
