# inicialização dos pesos iniciais 
wPesos = [0, 3, 3]

# constante de direcionamento
x0 = 1

# inputs com suas entradas (0 e 1) e saída (2)
inputs = [[0, 0, 0], [0, 1, 0], [1, 0, 0], [1, 1, 1]]

# função net
def net(i):
    if i >= 0:
        return 1
    else:
        return 0

# função de exibir os pesos simples
def exibirPesos(array):
    for index, peso in enumerate(array):
        print("w", index, " = ", peso)

# condicional do while
deuBom = False

# valor start do loop
x = 0

while not deuBom:
    y = net((wPesos[0] * x0) + (wPesos[1] * inputs[x][0]) + (wPesos[2] * inputs[x][1]))

    if y == inputs[x][2]:
        print('\nDeu certo na ' + str(x+1) + '° repeticao! \n-> Resultado final dos pesos:')
        deuBom = True
    else:
        wPesos[0] = wPesos[0] + x0 * (inputs[x][2] - y) * x0
        wPesos[1] = wPesos[1] + x0 * (inputs[x][2] - y) * inputs[x][0]
        wPesos[2] = wPesos[2] + x0 * (inputs[x][2] - y) * inputs[x][1]
        print('\nRealizando mais um recalculo de pesos...\n')
        x += 1

    exibirPesos(wPesos)






