class Triangulo:
    @staticmethod
    def area() -> None:
        b = int(input("\nIngrese la base: "))
        h = int(input("Ingrese la altura: "))
        print("\nÁrea: ", (b*h)/2)
    @staticmethod
    def perimetro() -> None:
        a = int(input("\nIngrese el lado 1: "))
        b = int(input("Ingrese el lado 2: "))
        c = int(input("Ingrese el lado 3: "))
        print("\nPerímetro: ", a+b+c)

