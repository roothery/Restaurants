# 🍽️ Restaurants API
Projeto de uma API em **.NET 8.0**, aplicando princípios da **Clean Architecture**, **CQRS**, **MediatR** e **Entity Framework**, com testes unitários e de integração utilizando o **xUnit**.

---

## 🧱 Estrutura do Projeto
A solução está organizada em camadas, conforme os princípios da Clean Architecture:
```
├── src/
│ ├── Restaurants.API (Projeto principal da API – ponto de entrada da aplicação)
│ ├── Restaurants.Application (Lógica de aplicação – regras de negócio e orquestração)
│ ├── Restaurants.Domain (Núcleo da aplicação – entidades e regras de domínio)
│ └── Restaurants.Infrastructure (Código de infraestrutura – banco de dados, arquivos, etc)
├── tests/
│ ├── Restaurants.API.Tests (Testes unitários da API)
│ ├── Restaurants.Application.Tests
│ ├── Restaurants.Infrastructure.Tests
```

---

## 📦 Pacotes e Bibliotecas Utilizadas
A solução utiliza diversos pacotes e bibliotecas do ecossistema .NET:

- **Serilog**  
  Utilizado para geração de logs estruturados. É uma biblioteca flexível e fácil de configurar.

- **MediatR**  
  Implementa o padrão CQRS (Command Query Responsibility Segregation), separando comandos (ações que alteram o estado) de consultas (ações que leem o estado).

- **Entity Framework Core**  
  ORM que facilita o acesso ao banco de dados utilizando objetos do domínio, abstraindo tabelas e colunas.

- **Azure Storage Account**  
  Usado para manipulação de blobs (arquivos binários como imagens, documentos, etc).

- **Microsoft Identity**  
  Gerencia autenticação, autorização e controle de acesso de usuários na API.

> ℹ️ Consulte a documentação oficial de cada biblioteca para exemplos e informações detalhadas de uso.

---

## 🚀 Primeiros Passos

### ✅ Pré-requisitos
- [.NET 8.0 SDK](https://dotnet.microsoft.com/)
- [Visual Studio 2022 ou superior](https://visualstudio.microsoft.com/)

### 🛠️ Build do Projeto
Abra o arquivo `Restaurants.sln` no Visual Studio e selecione **Build Solution** (`Ctrl+Shift+B`).

### ▶️ Execução
Defina o projeto `Restaurants.API` como **Startup Project** e execute a aplicação (`F5`).

---

## 🧪 Testes
Os testes estão localizados no diretório `tests/*`. Você pode executá-los utilizando o Test Explorer do Visual Studio.

---

## 📡 Endpoints da API

| Método  | Rota                                         | Autenticação   | Descrição                                         |
|---------|----------------------------------------------|----------------|---------------------------------------------------|
| `GET`   | `/api/restaurants`                           | ✅ Bearer Token | Lista restaurantes com filtros e paginação       |
| `GET`   | `/api/restaurants/{id}`                      | ✅ Bearer Token | Retorna os detalhes de um restaurante            |
| `GET`   | `/api/restaurants/{id}/dishes`               | ✅ Bearer Token | Lista os pratos de um restaurante                |
| `GET`   | `/api/restaurants/{id}/dishes/{dishId}`      | ❌ Não requerida| Detalhes de um prato específico                  |
| `POST`  | `/api/restaurants`                           | ✅ Bearer Token | Cria um novo restaurante                         |
| `DELETE`| `/api/restaurants/{id}`                      | ✅ Bearer Token | Remove um restaurante                            |
| `DELETE`| `/api/restaurants/{id}/dishes`               | ❌ Não requerida| Remove todos os pratos de um restaurante         |
