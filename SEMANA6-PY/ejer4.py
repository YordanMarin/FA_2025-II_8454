g = input("Genere una contraseña: ")

print("\n--------------------------------------------------------")
print("   BIEVENIDOS AL SISTEMA DE VALIDACIÓN DE CONTRASEÑAS   ")
print("                                                        ")
print("   1. Ud. tiene 3 intentos                              ")
print("--------------------------------------------------------")

intentos = 3

while(intentos > 0):
    c = input("\nIngrese su contraseña: ")

    if g == c:
        print("\nAcceso concebido. Bienvenido al sistema!")
        break
    else:
        intentos-=1
        print(f"Contraseña incorrecta! te quedan {intentos} intentos.")

else: print("\nAcceso denegado, Ud culmino todos sus intentos.")