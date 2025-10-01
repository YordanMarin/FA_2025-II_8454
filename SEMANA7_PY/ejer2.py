import random

print("**********************************************")
print("*    BIENVENIDOS AL JUEGO ADIVINADOR         *")
print("*                                            *")
print("*  1. Ud. adivinara un número entre 1 y 20   *")
print("*  2. Ud. Tiene 3 intentos                   *")
print("*  3. Ud. tendra una pista por cada error    *")
print("**********************************************")

secreto = random.randint(1,20)
intentos = 3

while intentos > 0:
    num = int(input("\nIngrese el número: "))

    if num == secreto:
        print("\nAdivinaste el número!")
        break
    else:
        intentos-=1
        if(num > secreto):
            print(f"\nPista: El número es menor. Le quedan {intentos} intentos")
        else:
            print(f"\nPista: El número es mayor. Le quedan {intentos} intentos")
else: print(f"\nJuego terminado. No logro adivinar el número {secreto}")
