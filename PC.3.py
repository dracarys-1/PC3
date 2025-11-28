
# Programa que pide 5 números y determina si son positivos, negativos o cero
# Además, indica si son pares o impares

for i in range(5):  # estructura repetitiva
    numero = int(input(f"Ingrese el número {i+1}: "))

    # Condicional anidada
    if numero > 0:
        print("Es positivo")
        if numero % 2 == 0:
            print("Además, es par")
        else:
            print("Además, es impar")
    elif numero < 0:
        print("Es negativo")
        if numero % 2 == 0:
            print("Además, es par")
        else:
            print("Además, es impar")
    else:
        print("Es cero")
