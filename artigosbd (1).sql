-- phpMyAdmin SQL Dump
-- version 4.7.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 16-Jun-2017 às 04:08
-- Versão do servidor: 10.1.22-MariaDB
-- PHP Version: 7.1.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `artigosbd`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `artigos`
--

CREATE TABLE `artigos` (
  `id` int(11) NOT NULL,
  `titulo` varchar(60) NOT NULL,
  `conteudo` varchar(5000) NOT NULL,
  `categoria` varchar(25) NOT NULL,
  `data` date NOT NULL,
  `feedback` varchar(500) DEFAULT NULL,
  `autor` varchar(25) NOT NULL,
  `revisor` varchar(25) DEFAULT NULL,
  `status` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `artigos`
--

INSERT INTO `artigos` (`id`, `titulo`, `conteudo`, `categoria`, `data`, `feedback`, `autor`, `revisor`, `status`) VALUES
(12, 'Teste', 'Dias terríveis aqueles. É preciso repetir e repetir e recontar para que não sejam esquecidos. \"Os dias eram assim\" são guarnecidos de didatismo imprescindível. Pesquisas indicam que muitos, não só os jovens, desconhecem esse pedaço tenebroso do Brasil, ignoram a prática da tortura e a repressão dos governos militares.\r\n\r\nQuem viveu o golpe de 1964 e suas consequências, sabe a história. Quem não viveu, investigue, vasculhe, para não cair na cilada do discurso fácil da volta dos militares para “moralizar” o país. Quem disse que moralizaram?', 'Politico', '2017-06-15', 'Bom artigo', 'ivanjr', 'ivanjr', 'Publicado'),
(13, 'A Era do Centro', 'Se a Era dos Extremos, com suas catástrofes, crises econômicas, guerras, revoluções e polarização ideológica, teve como marco temporal a Sarajevo de 1914 e de 1991, é bem possível que a larga maioria conquistada por Emmanuel Macron nas eleições para a Assembleia Nacional Francesa venha a ser entendida, no futuro, como o limiar da Era do Centro.\r\n\r\nNela, os extremos expressam contratendências regressivas, que tendem a perder densidade por não responderem aos desafios de um planeta em reorganização.\r\n\r\nA base material do mundo está em mutação, as classes sociais se fragmentaram, o “chão de fábrica” é inteiramente diferente da época do fordismo, a ideia de rupturas perdeu sentido, mas as forças tradicionais, à esquerda e à direita, não percebem que “uma nova mudança em breve vai acontecer e que o passado é uma roupa que não nos serve mais”, como já cantava o visionário Belchior, em 1976.\r\n\r\nCom um programa abertamente reformista, pró Europa e globalizante, Macron é o primeiro político a r', 'Politico', '2017-06-15', 'Conteudo improrio', 'ivanjr', 'ivanjr', 'Cancelado'),
(14, 'A bola não pode faltar', 'A bola é um objeto utilizado por várias pessoas em diversos desportos. A bola é por vezes esférica, mas pode ter algumas outras formas, como a oblonga (apenas em alguns casos especiais, como a bola de rúgbi). Ou a quadrada ( que é usada somente em jogos de dominó). A bola pode ser oca e repleta de ar, como a bola de futebol, ou sólida, como a bola de bilhar ou de golfe. Na maioria dos jogos, as jogadas acontecem em função do estado da bola que vai ser acertada, chutada ou lançada pelos jogadores.\r\n\r\nNo futebol, esporte que é paixão em todo o Brasil, um acessório que sempre será indispensável é a bola. Pode-se jogar num campo de várzea, ou até no meio da rua, com um time de camisas e um sem camisas e também com um time descalço. Pode marcar o tamanho do gol com pedaços de madeira, mas se não tiver a bola não da de jogar. O objeto que é considerado muito importante em mais de trinta modalidades esportivas desde o jogo de bolinha de gude até o boliche. A bola está presente desde os tempos primitivos quando era usada por crianças em suas brincadeiras e normalmente era feita por vários materiais. Uma bola não precisa necessariamente ser redonda, por exemplo, da bola de futebol americano que é pontiaguda em duas extremidades.\r\n\r\nO forro pode ser de algodão ou poliéster que cobre toda a câmara e a quantidade de gomos nas bolas profissionais são em um total de 32 e a cobertura totalmente em couro PVC, poliuretano ou material sintético. Bolas coladas são menos resistentes, que as costuradas são muito mais indicadas, sendo que as  mais costuradas à mão são muito mais bem feitas e um pouco caras. O importante em um jogo de futebol é além da segurança a diversão. Com uma boa bola adequada ao tipo de modalidade escolhida é possível você marcar vários gols incríveis e obter efeitos impressionantes apenas com um pouco de jeito para chutar e estilo próprio. Independente da bola, o futebol será sempre um vício uma febre entre a maioria dos brasileiros.', 'Esportivo', '2017-06-15', 'Artigo muito bom', 'SergioLourosa', 'didiplay', 'Publicado'),
(15, 'Brasileiros investem em curso de inglês para eventos esporti', 'O Brasil nos próximos anos será sede dos maiores eventos esportivos do mundo. Com a chegada da Copa do Mundo (2014) e as Olímpiadas (2016) no país, muitos brasileiros veem em um futuro próximo mais oportunidades de trabalho. Alguns já até estão se preparando para isso, como é o caso de pessoas que estão investindo em cursos de idiomas para aprender a falar inglês, o espanhol e outras línguas de diferentes países que virão para o Brasil.\r\n\r\nDe acordo com a Empresa Brasileira de Infraestrutura Aeroportuária (INFRAERO), o Brasil registrou mais de 4,5 milhões de desembarques internacionais, somente no primeiro semestre de 2012. A agitação desses turistas no país movimentou US$ 2,47 bilhões até abril deste ano, um acréscimo de 8,9% em relação ao ano passado.\r\n\r\nA aproximação desses eventos no país já está causando impacto na economia brasileira. O setor educacional está bem aquecido com o interesse dos brasileiros em aprender outro idioma. Em outros eventos esportivos que já aconteceram pelo mundo, o inglês se mostrou o idioma predominante nas competições.\r\n\r\nA Fifa anunciou em agosto de 2012 a vaga para voluntários da Copa de 2014 e mais 105 mil candidatos se inscreveram entre eles estrangeiros de 130 países. O programa de voluntários oferece um lanche, brindes e uniforme. Pode parecer pouco, mas para quem deseja se relacionar com pessoas de outros países essa é uma boa oportunidade. Por isso aprender um segundo idioma é tão importante.\r\n\r\nUma das sedes da Copa do Mundo de 2014, Porto Alegre, está investindo em curso de inglês e espanhol para 600 agentes de trânsito. A iniciativa visa preparar os agentes para orientar e interagir com os turistas no evento esportivo. A movimentação dos brasileiros para o aprimoramento de uma nova língua em busca de mais oportunidades no mercado mostra que os eventos esportivos deixarão um legado não só econômico, mas também social e cultural no país.', 'Esportivo', '2017-06-15', 'Artigo improprio', 'SergioLourosa', 'didiplay', 'Publicado'),
(16, ' Tecnologia, inovação e competitividade da indústria brasile', 'O novo cenário mundial competitivo e globalizado está impregnado por mudanças no social, no tecnológico e, principalmente, no aspecto mental da forma de entender as organizações e suas relações. Essas mudanças têm trazido ameaças à sobrevivência das indústrias em boa parte do mundo, sobretudo em países como o Brasil, que se encontram ainda marcados pela cultura do repasse dos custos de um sistema operacional arcaico, pela baixa qualificação da mão de obra e pelo atraso tecnológico, salvo alguns segmentos industriais, abarcando, em geral, as grandes indústrias. Este quadro tem levado a necessidade de busca de novos parâmetros de gestão, que garantam a satisfação do cliente com um produto de qualidade e com menor custo. A sobrevivência das empresas industriais, nesta nova ordem mundial, está em garantir a vantagem competitiva. Para tanto, a questão tecnológica é uma das molas mestras para o sucesso deste intento.\r\n\r\nA tecnologia materializa-se como benefício efetivo às organizações através da implementação da inovação tecnológica, ou seja, a aplicação do conhecimento adquirido pela pesquisa, nos processos de gestão da organização. As políticas específicas de estímulo à inovação tecnológica têm como objeto garantir os desdobramentos da pesquisa científica e tecnológica, com vista ao desenvolvimento regional. A diversidade dos caminhos tecnológicos adotados pelas empresas, por si só, não garante o seu desenvolvimento, que só se concretiza com a implementação e difusão da inovação tecnológica. Dessa forma, a competitividade tem como um dos seus pilares a tecnologia; contudo, a tecnologia só resulta em vantagem competitiva com a sua inovação e difusão. Ressalvando-se que a inovação deve ser também entendida como a adoção de novos processos de gestão, buscando a racionalização e a eficácia empresarial.\r\n\r\n \r\n\r\nOs avanços tecnológicos tornam-se importantes, sobretudo no segmento das micro, pequenas e médias indústrias, que representam mais de 95% do setor industrial nacional. Esta faixa percentual se aplica também para a realidade industrial baiana. Todavia, as indústrias de menor porte carecem de financiamento com condições facilitadas e ágeis, recursos humanos capacitados, maior associativismo, confiança em parcerias e informações de mercado, que lhes possibilitem o acesso à inovação tecnológica, como ferramenta para o incremento de sua produtividade e competitividade.', 'Tecnologico', '2017-06-15', 'Não recusado.', 'didiplay', 'didiplay', 'Cancelado'),
(17, 'Como os bilionários da tecnologia pretendem salvar o mundo', 'É praticamente impossível encontrar um ser humano melhor do que Bill Gates, por diversos motivos. Ele e sua esposa, Melinda, possuem há mais de 20 anos a Bill & Melina Gates Foundation, uma organização que atua no combate à fome e problemas de saúde no mundo todo, especialmente, nos países mais pobres. O casal já doou, apenas para esta fundação, mais de 30 BILHÕES de dólares.\r\n\r\nEntre as obras estão a famosa máquina que transforma dejetos humanos em água potável, a revolução nos banheiros indianos, desenvolvimento agrícola e o combate às doenças como malária, tuberculose, etc.\r\n\r\nSuas boas-ações, que remontam ao início dos anos 90, chamou a atenção de um outro bilionário gente boa: Warren Buffett, um megainvestidor de Wall Street. A parceria que mudaria o mundo começou em 2006 quando ele procurou Bill para fazer uma doação à Fundação e ajudar nas lutas que o criador da Microsoft estava empenhado.\r\n\r\nBuffett, que já era um filantropo, ficou ainda mais fascinado com a ideia de repartir o muito que tinha para ajudar os menos sortudos. Fez mais doações, conversou com o casal Gates e, após alguns anos, eles tiveram a ideia de criar algo maior do que tudo isso. Algo que chamassem aqueles que tem condições a ajudar os necessitados. Assim nasceu o The Giving Pledge.', 'Tecnologico', '2017-06-15', 'Muito bom', 'didiplay', 'didiplay', 'Publicado');

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuarios`
--

CREATE TABLE `usuarios` (
  `usuario` varchar(50) NOT NULL,
  `senha` varchar(10) NOT NULL,
  `perfil` int(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `usuarios`
--

INSERT INTO `usuarios` (`usuario`, `senha`, `perfil`) VALUES
('DidiPlay', '1', 2),
('Ivan', '1', 1),
('IvanJr', '1', 3),
('SergioLourosa', 'pepa', 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `artigos`
--
ALTER TABLE `artigos`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`usuario`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `artigos`
--
ALTER TABLE `artigos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
