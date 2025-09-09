def ejer1():
    nombre = input("Ingrese su nombre: ")
    carrera = input("Ingrese su carrera: ")

    print(f"\n {nombre},bienvenido al curso de fundamentos de algoritmo de la carrera {carrera}")

def ejer2():
    print("\"Sebastian\"")

def ejer3():
    num1=int(input("Ingrese número1 :"))
    num2=int(input("Ingrese número2 :"))

    print("Suma: ", (num1+num2))
    print("Resta: ", (num1-num2))
    print("Multiplicación: ", (num1*num2))
    print("División: ", (num1/num2))

import math #importando libreria math

def ejer4():
    num = float(input("ingrese número decimal: "))

    raiz = math.sqrt(num)
    redo = round(num,2)
    cubo = math.pow(num,3)
    cubica = num ** (1/3)

    print("Raiz cuadra: ", raiz)
    print("Redondeado: ", redo)
    print("al cubo: ", cubo)
    print("Raiz cubica: ", cubica)

ejer4()