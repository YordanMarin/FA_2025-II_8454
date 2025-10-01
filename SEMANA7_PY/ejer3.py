while True:
    num = int(input("Ingrese número entero: "))
    suma = 0

    for i in range(1,num+1):
        print(i, end=" ")
        suma += i
    print("\n\nSuma: ",suma)

    opc = input("\n¿Desea coontinuar? (S/N): ")
    if(opc == "N"):
        break


