IVAN WAGNER

# resumo-do-lab
Este repositório contém o resumo das lições aprendidas durante o desenvolvimento do lab na DIO

# Resumo de Aprendizado - Microsoft Azure AZ-900

## 1. Como Criar uma Conta Gratuita no Microsoft Azure

Para criar uma conta gratuita no Microsoft Azure, siga os seguintes passos:

1. Acesse o [site oficial do Azure](https://azure.microsoft.com/).
2. Clique em **Iniciar gratuitamente**.
3. Faça login com sua conta Microsoft ou crie uma nova.
4. Preencha as informações solicitadas, incluindo detalhes de pagamento (um cartão de crédito é necessário para verificar a identidade, mas não será cobrado durante o período gratuito).
5. Após o cadastro, você terá acesso a serviços gratuitos, como 12 meses de recursos gratuitos e US$ 200 de crédito inicial por 30 dias.

## 2. Diferenças entre Nuvem Pública, Privada e Híbrida

- **Nuvem Pública**:  
  É a oferta de serviços de computação (armazenamento, servidores, rede, etc.) de terceiros pela internet, como o Microsoft Azure, que compartilha a infraestrutura com outros usuários. É ideal para empresas que querem reduzir custos e focar em inovação, sem a necessidade de manter infraestrutura própria.

- **Nuvem Privada**:  
  Nesse modelo, os recursos de computação são usados exclusivamente por uma única organização. Ela pode ser hospedada no data center da própria empresa ou em um provedor terceirizado. É ideal para organizações que necessitam de maior controle sobre seus dados e conformidade regulatória.

- **Nuvem Híbrida**:  
  Combina os benefícios da nuvem pública e privada, permitindo que as empresas hospedem algumas aplicações ou serviços na nuvem pública, enquanto mantêm dados sensíveis em um ambiente privado. Esse modelo oferece flexibilidade e segurança, permitindo otimização de recursos.

## 3. Diferença entre CapEx e OpEx

- **CapEx (Capital Expenditure - Despesas de Capital)**:  
  Refere-se ao investimento inicial em ativos físicos, como servidores, data centers ou infraestrutura de TI. É uma despesa que envolve altos custos iniciais, e a empresa adquire a propriedade do ativo, que é depreciado ao longo do tempo.

- **OpEx (Operational Expenditure - Despesas Operacionais)**:  
  Refere-se às despesas contínuas e variáveis para manter a operação, como custos de serviços na nuvem. Em um modelo OpEx, a empresa paga apenas pelos recursos que utiliza, oferecendo mais flexibilidade e menor compromisso financeiro inicial.

## Conclusão

Esses conceitos fundamentais do Azure são cruciais para a adoção de soluções em nuvem, ajudando a escolher o melhor modelo de nuvem e a entender como otimizar custos, seja por CapEx ou OpEx, ao construir sua infraestrutura de TI.

# Benefícios da Nuvem

## 1. **Escalabilidade**
A nuvem oferece a capacidade de aumentar ou diminuir recursos de acordo com a demanda. Isso permite que as empresas ajustem sua infraestrutura de TI conforme as necessidades do negócio crescem ou diminuem, sem a necessidade de grandes investimentos em hardware.

## 2. **Custo-Efetivo**
Com a nuvem, as empresas evitam altos investimentos iniciais em infraestrutura (CapEx), optando por pagar apenas pelos recursos que utilizam (OpEx). Isso reduz o desperdício e torna os custos mais previsíveis e flexíveis.

## 3. **Acesso Global**
Os serviços de nuvem podem ser acessados de qualquer lugar, a qualquer momento, através da internet. Isso facilita o trabalho remoto, a colaboração em tempo real e o acesso a informações em várias localidades geográficas.

## 4. **Manutenção Reduzida**
A manutenção da infraestrutura de TI, como atualizações de hardware e software, é gerenciada pelo provedor de nuvem. Isso permite que as empresas foquem mais em suas atividades principais, sem se preocupar com a gestão e manutenção de servidores.

## 5. **Segurança**
Os principais provedores de nuvem, como Microsoft Azure, AWS e Google Cloud, investem pesadamente em medidas de segurança, incluindo criptografia de dados, controle de acesso, firewalls e atualizações automáticas de segurança. Isso ajuda a proteger dados contra ameaças cibernéticas.

## 6. **Recuperação de Desastres**
As soluções de nuvem oferecem redundância e backups automatizados que facilitam a recuperação de dados e a continuidade dos negócios em caso de falhas ou desastres, sem a necessidade de manter infraestruturas complexas para recuperação de desastres.

## 7. **Desempenho e Inovação**
Os serviços de nuvem permitem acesso a tecnologias de ponta, como inteligência artificial, machine learning, big data e analytics, que são atualizadas regularmente pelos provedores de nuvem. Isso dá às empresas a capacidade de inovar rapidamente sem precisar construir ou manter essa tecnologia internamente.

## 8. **Elasticidade**
Os recursos de TI podem ser ajustados dinamicamente para atender à variação de carga de trabalho, garantindo que as aplicações possam lidar com picos de uso sem comprometer o desempenho e sem a necessidade de provisionamento manual.

## 9. **Mobilidade**
A nuvem permite que os colaboradores acessem informações de qualquer lugar, facilitando o trabalho remoto e colaborativo, e oferecendo um ambiente de trabalho mais ágil e eficiente.

## 10. **Automação**
Muitas tarefas de gerenciamento, como provisionamento de servidores, balanceamento de carga e monitoramento, podem ser automatizadas na nuvem. Isso reduz a necessidade de intervenção manual e diminui a chance de erros.

## Conclusão
A adoção da nuvem traz uma série de benefícios que vão desde a redução de custos até a melhoria da agilidade e segurança, permitindo que as empresas inovem e escalem seus negócios de forma eficiente.

# Tipos de Serviços de Nuvem

## 1. **IaaS (Infrastructure as a Service - Infraestrutura como Serviço)**

### O que é?
IaaS oferece infraestrutura de TI virtualizada por meio da internet. As empresas podem alugar recursos de computação, como servidores, armazenamento, e rede, sem precisar adquirir hardware físico.

### Exemplos:
- Microsoft Azure
- Amazon Web Services (AWS)
- Google Cloud

### Benefícios:
- Redução de custos com infraestrutura física.
- Escalabilidade flexível de acordo com a demanda.
- Controle sobre a infraestrutura, com a capacidade de instalar e gerenciar sistemas operacionais e aplicativos.

---

## 2. **PaaS (Platform as a Service - Plataforma como Serviço)**

### O que é?
PaaS fornece uma plataforma que permite às empresas desenvolver, executar e gerenciar aplicativos sem a complexidade de construir e manter a infraestrutura necessária. Ele oferece ferramentas de desenvolvimento, banco de dados, e ambientes de execução prontos para uso.

### Exemplos:
- Azure App Service
- Google App Engine
- Heroku

### Benefícios:
- Agilidade no desenvolvimento e lançamento de aplicativos.
- Gerenciamento simplificado de infraestrutura e middleware.
- Foco no desenvolvimento de software, enquanto o provedor gerencia a infraestrutura subjacente.

---

## 3. **SaaS (Software as a Service - Software como Serviço)**

### O que é?
SaaS entrega aplicativos completos por meio da internet, acessíveis por um navegador web. Os usuários podem acessar o software sem precisar instalá-lo localmente, e todo o gerenciamento do aplicativo é feito pelo provedor de serviços.

### Exemplos:
- Microsoft 365
- Google Workspace
- Salesforce

### Benefícios:
- Sem necessidade de instalação ou manutenção local.
- Atualizações automáticas de software.
- Acessível de qualquer dispositivo com conexão à internet.

---

## Conclusão

Cada um desses modelos de serviço na nuvem oferece diferentes níveis de controle, flexibilidade e gerenciamento. As empresas podem escolher entre IaaS, PaaS e SaaS, dependendo de suas necessidades, seja para hospedar infraestrutura, desenvolver aplicativos ou consumir software pronto.
