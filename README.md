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

## MediatR

## Sagas
