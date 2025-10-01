p = i = 0

while True:
    num = int(input("Ingrese ún número entero: "))

    if num < 0: break
    if num % 2 ==0: p+=1
    else: i+=1

print("\nCantidad pares: ",p)
print("Cantidad impares: ",i)

