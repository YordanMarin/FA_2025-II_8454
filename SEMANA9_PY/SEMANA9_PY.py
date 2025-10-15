from Triangulo import Triangulo
from Cuadrado import Cuadrado
c = Cuadrado()
t = Triangulo()

def menu1() -> None:
    print("BIENVENIDO AL SISTEMA DE CALCULO DE ÁREA Y PERÍMETRO\n")
    print("********** Menú de opciones **********")
    print("*         1. Triángulo               *")
    print("*         2. Cuadrado                *")
    print("*         3. Rectángulo              *")
    print("*         4. Trapecio                *")
    print("*         0. Salir                   *")
    print("**************************************\n")

def menu2() -> int:
    print("\n***** Seleccione una opción ********")
    print("*         1. Calcular área         *")
    print("*         2. Calcular perímetro    *")
    print("************************************\n")
    opc = int(input("Ingrese una opción: "))
    return opc

while True:
    menu1()
    while True:
        opc = int(input("Ingrese una opción: "))
        if opc in (0, 1, 2, 3, 4): break
        else: print("Opción incorrecta. Intente de nuevo.\n")

    match opc:
        case 0:
            print("\nGracias por usar el sistema. ¡Hasta luego!")
            exit() #quit()
        case 1:
            opc2 = menu2()
            match opc2:
                case 1: t.area()
                case 2: t.perimetro()
                case _: print("Opción incorrecta.\n")
        case 2:
            opc2 = menu2()
            l = int(input("\nIngrese el lado del cuadrado: "))

            match opc2:
                case 1: c.area(l)
                case 2: c.perimetro(l)
                case _: print("Opción incorrecta.\n")
        case 3:print()
        case 4:print()

    while True:
        conti = input("\n¿Desea continuar? (s/n): ")
        if conti in ('s', 'n',): break
        else: print("Opción incorrecta. Intente de nuevo.\n")

    if conti == 'n': 
        print("\nGracias por usar el sistema. ¡Hasta luego!")
        break


