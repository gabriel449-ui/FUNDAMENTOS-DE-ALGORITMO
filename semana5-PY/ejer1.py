edad = int(imput("ingrese la edad"))

if edad >= 18:
    print("elegible para votar")
    if edad >= 25:
        print("elegible para ser un candidato")
    else:
        print("no es elegible para ser un candidato")
else:
    print("no es elegible para votar")
