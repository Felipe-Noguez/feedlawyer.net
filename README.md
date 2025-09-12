## Sistema de avaliação de demosntração.

- Comando para instalação do Entity Framework Core tools (link com a documentação abaixo):
```bash
dotnet tool install --global dotnet-ef
```
https://learn.microsoft.com/en-us/ef/core/cli/dotnet


- Script SQL para criar as "roles" no Postgresql:
```bash
INSERT INTO public."Roles"
("Id", "Name")
VALUES(gen_random_uuid(), 'ADMINISTRATOR');

INSERT INTO public."Roles"
("Id", "Name")
VALUES(gen_random_uuid(), 'LAWYER');

INSERT INTO public."Roles"
("Id", "Name")
VALUES(gen_random_uuid(), 'CLIENT');
```

- Salvando as alterações não comitadas:
```bash
git stash save "feat: create user with role"
```

- Cria a branch e traz do stash as alterações:
```bash
git stash branch feat/create-user-with-role
```