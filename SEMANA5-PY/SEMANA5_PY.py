edad = int(input("Ingrese una edad: "))
print()
if edad >=18:
    print("Puede votar.")
    if edad >=25:
        print("Puede ser candidato a un cargo politico")
    else:
        print("No puede ser candidato a un cargo politico")
else:
    print("No puede votar.")
