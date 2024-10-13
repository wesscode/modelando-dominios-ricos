# Modelando domínios ricos

## Modelagem estratégica
  - Linguagem Ubíqua
  - Context Map
  - Bounded Context
  
## Modelagem tática
 - Domain Module
 - Value Objects(VO)
 - Entidades
 - Agregações
 - Domain Services
 - Repositórios
 - Eventos de domínio

## Camadas
  - Apresentação
  - Aplicação
  - Domain
  - Infra

# Teorema CAP:
  - **Consistency:** Garantia da consistência dos dados.
  - **Availability:** Escalabilidade e disponibilidade onde garante que o app, não pare e retorne o dado mesmo que seja o mais antigo, mas estará disponível.
  - **Partition Tolerance:** Replicação de várias instâncias que mesmo que partes do app falhe, outras continuem funcionando.
    
## CQRS(Command Query Responsability Segregation)
  - **Command Stack:** Representam uma intenção de mudança no estado de uma entidade.
    São expressivos e representam uma única intenção de negócio. Ex: AumentarSalarioFuncionarioCommand
       
  - **Query Stack:** É a forma de obter dados de um banco ou origem de dados para atender
    as necessidades da aplicação.
    
  - Como sincronizar as bases
    
## EVENTO X COMMANDS
  - **Comandos:** Expressam "intenções" de negócio, ações únicas que representam um "use case" e registram no banco.
  - **Eventos:** São sobre o passado, algo que já aconteceu, eventos comunicam o resultado de um comando. Esses eventos geralmente são lançados para confirmar o sucesso da operação mas também servem para que outra parte da aplicação ao capturar esse evento inicie outro processo de negócio (enviar um e-mail, emitir uma NF).
## MediatR

## Sagas

# Event Sourcing
Guardar a histórias de nossas entidades
Ajuda em: Entender o comportamento do usuário a partir dos eventos gerados de cada ação do usuário.
O quanto é importante saber em que ordem os itens foram adicionados ?

# Fatores sobre event sourcing
- Todos os eventos dizem sobre o que houve no PASSADO
- Eventos são uma expressão da linguagem ubíqua
- Não são imperativos e utilizam verbos no passado
- São sempre adicionados, nunca excluídos
- É possível realizar o "Replay" para conhecer o estado anterior da entidade
