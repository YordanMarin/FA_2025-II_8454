def ejer1():
    edad = int(input("Ingrese su edad: "))

    if edad < 18:
        print("Menor de edad.")
    elif edad <=64:
        print("Adulto.")
    else:
        print("Adulto mayor")

def ejer2():
    an = int(input("Ingrese el año: "))

    if (an % 4 == 0 and an % 100 != 0) or an % 400==0:
        print("El año es bisiesto")
    else:
        print("El año no es bisiesto")

    if(an % 2 == 0):
        print("El año es par")
    else:
        print("El año es impar")

def ejer3():
    monto = float(input("Ingrese monto en soles: "))

    print("\n1. Dolares\n2. Euros")

    opcion = int(input("Ingrese una opción: "))

    print()
    match opcion:
        case 1: print("Dolares: ", round((monto/3.75),2))
        case 2: print("Euros: ", monto/4.05)
        case _: print("Opción incorrecta!")

import math

def ejer4():
    print("Bienvenidos al programa de desarrollo de áreas\n")

    print("1. Cuadrado")
    print("2. Rectangulo")
    print("3. triangulo")
    print("4. Circulo\n")

    opcion = int(input("Ingrese una opción: "))

    match opcion:
        case 1:
            lado = int(input("Ingrese lado: "))
            print("Área de cuadrado: ", lado*lado)
        case 2:
            bse = int(input("Ingrese la base: "))
            alt = int(input("Ingrese la altura: "))
            print("Área de rectangulo: ", bse*alt)
        case 3:
            bse2 = int(input("Ingrese la base: "))
            alt2 = int(input("Ingrese la altura: "))
            print("Área del triangulo: ", (bse2*alt2)/2)
        case 4:
            radio = float(input("Ingrese la radio: "))
            print("Área del circulo: ", round((math.pi * radio**2),2))
        case _: print("Opción incorrecta!")
        
ejer4()
