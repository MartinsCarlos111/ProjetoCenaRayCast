# ProjetoCenaRayCast

Nós utilizamos o conceito de RayCast para fazer um projétil que ao atingir os objetos exerce uma força sobre eles,
além de fazer um contador de pontos que identifica quando um objeto é atingido.

Utilizamos o conceito prefab para gerar alvos, e peças para uma cena em efeito dominó, o prefab dos alvos contém uma logica
que permite o sistema gerar mais alvos de forma aleatória, a cada alvo que entra em colisão com o projétil.

Para aplicar conceitos de iluminação, tornamos o ambiente noturno e criamos uma lanterna utilizando um componente de iluminação(Spot Ligth), 
referenciamos ele no código fazendo um botão de ativação. 
