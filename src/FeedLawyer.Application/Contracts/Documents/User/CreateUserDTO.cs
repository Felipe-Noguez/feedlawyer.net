using FeedLawyer.Application.Contracts.Documents.Role;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedLawyer.Application.Contracts.Documents.User
{
    /// <summary>
    /// Esta classe é um Data Transfer Object (DTO) usado para receber dados
    /// de uma requisição HTTP, neste caso, para criar um novo usuário.
    ///
    /// O uso de 'record' com esta sintaxe (conhecida como "construtor primário")
    /// é uma funcionalidade do C# 9.0 que simplifica a definição de tipos
    /// focados em dados.
    ///
    /// Vantagens desta sintaxe:
    /// 1. Imutabilidade: As propriedades 'UserName', 'Password', 'Email' e 'Role'
    ///    são automaticamente definidas como 'public init', tornando o objeto imutável
    ///    após a criação. Isso é ideal para DTOs de entrada, pois os dados
    ///    não devem ser alterados após o recebimento.
    /// 2. Construtor Automático: O compilador gera automaticamente um construtor
    ///    que recebe todos os parâmetros, eliminando a necessidade de escrever
    ///    o código boilerplate (repetitivo).
    /// 3. Métodos Essenciais: O 'record' também sobrescreve automaticamente os métodos
    ///    'Equals', 'GetHashCode' e 'ToString()', facilitando a comparação de
    ///    objetos e a depuração.
    ///
    /// Motivo de estar na camada de Application:
    /// A camada de Application é a fronteira entre o Domínio e a Apresentação (API).
    /// Os DTOs são a forma mais comum de transportar dados entre essas camadas,
    /// mantendo o Domínio limpo e isolado de detalhes da API, como a serialização JSON.
    /// </summary>
    /// <param name="UserName"></param>
    /// <param name="Password"></param>
    /// <param name="Email"></param>
    /// <param name="Roles"></param>
    public record CreateUserDTO(string UserName,
    string Password,
    string Email,
    List<CreateRoleUser> Roles);
}
