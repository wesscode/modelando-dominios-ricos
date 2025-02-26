# Modelando domínios ricos

# DDD (Domain Driven Design):
Desenvolvimento voltado para o domínio, onde amadurecemos o modelo expressando de forma clara o negócio.

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
  - Apresentation
  - Application
  - Domain
  - Infrastructure

## Dicas sobre DDD:
- Interface de marcação: IAggregateRoot, indentifica que aquela entidade é uma *Raiz de agregação*
- Entidade: Setar propriedade somente pelo o construtor ou adhoc setters, propriedades sempre privadas.
- Value Objects: Agregador de valor para uma entidade, Imutável e não possue identidade.
- A entidade tem que se validar, não pode ser criada de forma inválida, tem que ter o setters privados, deve possuir seus comportamentos.
- Trabalhe com serviço de domínio com ações conhecidas pela sua linguagem ubíqua, todo serviço de domínio tem que ser conhecido e aprovado pelo o Domain Expert.

# Teorema CAP:
  - **Consistency:** Garantia da consistência dos dados.
  - **Availability:** Escalabilidade e disponibilidade onde garante que o app, não pare e retorne o dado mesmo que seja o mais antigo, mas estará disponível.
  - **Partition Tolerance:** Replicação de várias instâncias que mesmo que partes do app falhe, outras continuem funcionando.
    
## CQRS(Command Query Responsability Segregation)
  - **Command Stack:** Representam uma intenção de mudança no estado de uma entidade.
    São expressivos e representam uma única intenção de negócio. Ex: AumentarSalarioFuncionarioCommand
       
  - **Query Stack:** É a forma de obter dados de um banco ou origem de dados para atender
    as necessidades da aplicação.
    
  - **Porque usar CQRS ?** Prevenir a saturação do banco de dados quando você possui uma grande volumetria de escrita e leitura na base da dados.

  _Esse padrão aborda a consistência eventual seguindo o teorema CAP._
    
## EVENTO X COMMANDS
  - **Comandos:** Expressam "intenções" de negócio, ações únicas que representam um "use case" e registram no banco.
  Ex: AdicionarNovoClienteCommand
      InativarProdutoCommand
      AlterarSalarioFuncionarioCommand

  - **Eventos:** É sobre o passado, algo que já aconteceu, eventos comunicam o resultado de um comando. Esses eventos geralmente são lançados para confirmar o sucesso da operação mas também servem para que outra parte da aplicação ao capturar esse evento inicie outro processo de negócio (enviar um e-mail, emitir uma NF).
  Ex: NovoClienteAdicionadoEvent
      ProdutoInativadoEvent
      SalarioFuncionarioAlteradoEvent

## MediatR
Biblioteca que implementa o padrão mediator, utilizado para reduzir dependência de comunicação entre objetos centralizando a comunicação em um único mediador.
Nós ajuda na implementação das separações de responsabilidades facilitando na aplicação do padrão CQRS.

## Sagas
O padrão Saga é um padrão de design de arquitetura usado para gerenciar transações distribuídas em sistemas de microserviços. Em um ambiente de microserviços, uma única operação pode envolver vários serviços independentes, e garantir a consistência dos dados em tais cenários pode ser um desafio.

Aplicável para apps distribuídos em rede. Ex: Mensageria como RabbitMQ e Apache Kafka.

# Event Sourcing
Guardar a histórias de nossas entidades
Ajuda em: Entender o comportamento do usuário a partir dos eventos gerados de cada ação do usuário.
O quanto é importante saber em que ordem os itens foram adicionados ?

**- Fatores sobre event sourcing:**
- Todos os eventos dizem sobre o que houve no PASSADO
- Eventos são uma expressão da linguagem ubíqua
- Não são imperativos e utilizam verbos no passado
- São sempre adicionados, nunca excluídos
- É possível realizar o "Replay" para conhecer o estado anterior da entidade


# Técnica Sobre o app:
**Services:** Modelagem dos nossos contextos
**WebApp:** Aplicações webs(apresentation)