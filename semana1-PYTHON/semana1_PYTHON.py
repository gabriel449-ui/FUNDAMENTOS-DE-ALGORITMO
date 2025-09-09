def ejer1():
    nombre = input("Ingrese su nombre: ")
    carrera = input("Ingrese su carrera: ")

ejer1()

def ejer2():
    print("\"Gabriel\"")

ejer2()

def ejer3():
    num1 = int(input("Ingrese numero 1: "))
    num2 = int(input("Ingrese numero 2: "))
    print("suma: ", (num1+num2))
    print("resta: ", (num1-num2))
    print("multiplicacion: ", (num1*num2))
    print("divicion: ", (num1/num2))

ejer3()

import math #importando libreria math
def ejer4():
    num = float(input("Ingrese el numero decimal: "))

    raiz = math.sqrt(num)
    redo = round(num, 2)
    cubo = math.pow(num, 3)
    cubica = num ** (1/3)

    print("raiz cuadrada: ",raiz)
    print("redondeado: ",redo)
    print("elevado a la 3: ",cubo)
    print("raiz cubica: ",cubica)

ejer4()

def ejer5():
    num = input("Ingrese un numero: ")

    entero = int(num)
    decim = float(num)

    print("rest: ", (entero % 2))
    print("decimal: ", (deci / 3))

ejer5()






 