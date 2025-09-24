cant = int(input("Ingrese la cantidad de números: "))
par = impar = ceros = 0
print()

for i in range(1,cant+1):
    num = int(input(f"Ingrese número {i}: "))

    if(num % 2 == 0):
        par+=1
    elif num==0:
        ceros+=1
    else:
        impar+=1
print("\nCantidad de pares: ", par)
print("Cantidad de impares: ",impar)
print("Cantidad de ceros: ",ceros)