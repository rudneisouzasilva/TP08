# TP08: Cadastro de Disciplinas

Aplicação desktop em C# (Windows Forms, .NET Framework 4.7.2) para cadastrar disciplinas em um banco SQL Server, organizada em camadas.

## Funcionalidades

Na tela **Disciplinas** é possível inserir, ler, atualizar e excluir disciplinas (código, descrição e carga horária).

## Estrutura

| Camada | Arquivo |
|---|---|
| Interface | `Disciplinas.cs` |
| Regras de negócio | `DisciplinasBLL.cs` |
| Acesso a dados | `DisciplinasDAL.cs` |
| Modelo | `Disciplina.cs` |

A pasta `lib/` tem a DLL `ClassErro`, usada para o tratamento de erros, e o código-fonte dela em `ClassErro.zip`.

## Como rodar

1. Crie o banco `Disciplinas` no SQL Server LocalDB (`(LocalDB)\MSSQLLocalDB`) com a tabela usada pelo projeto, por exemplo:

   ```sql
   CREATE TABLE tbDisciplinas (
       cd_disciplina INT PRIMARY KEY,
       ds_disciplina VARCHAR(100) NOT NULL,
       qt_hora INT NOT NULL
   );
   ```

2. Abra `TP08.sln` no Visual Studio e rode o projeto (F5).
