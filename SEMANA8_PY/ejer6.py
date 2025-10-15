dolar = 3.78
euro = 4.20

def conv_d():
    return soles/dolar

def conv_e():
    return soles / euro

while True:
    soles = float(input("Ingrese el monto en soles: "))

    print("\n1. Para convertir a dolares")
    print("2. Para convertir a euros")
    print("3. Salir")

    opc = int(input("\nIngrese una opción: "))

    match opc:
        case 1:print("\nDolares: ", round(conv_d()))
        case 2: print("\nEuros: ", round(conv_e()))
        case 3: exit()
        case _: print("\nOpción no válida.")

    conti = input("\n¿Desea continuar? presione (y): ")
    if conti != "y": break