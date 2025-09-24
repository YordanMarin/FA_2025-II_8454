filas = int(input("Ingrese cantidad de filas: "))
columnas = int(input("Ingrese cantidad de columnas: "))
print()
i = 1

while i<=filas:
    j = 1
    while j<=columnas:
        print("*", end=" ")
        j+=1
    print()
    i+=1