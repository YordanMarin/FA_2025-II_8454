num = int(input("Ingrese un número entero: "))
suma = 0
print()

for i in range(1,num+1):
    print(i)

    if i %2 ==0:
        suma += i

print("\nSuma de pares: ",suma)
