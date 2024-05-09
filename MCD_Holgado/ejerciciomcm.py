import unittest

"subalgoritmo que halla el mcd de dos numeros(a,b)"
def maximocomundiv(a, b):
    "Implementar el algoritmo de euclides"
    while b != 0:
        a, b = b, a % b
    return a

"Usando la misma funcion para hallar mcd de 4 numeros"
def Mcd_4_numeros(nro1, nro2, nro3, nro4):
    a_1 = maximocomundiv(nro1, nro2)
    a_2 = maximocomundiv(nro3, nro4)
    a_final = maximocomundiv(a_1, a_2)
    return a_final


class Testmaximocomundiv(unittest.TestCase):

    def test_mcd(self):
        
        esperado=4
        actual= Mcd_4_numeros(12,4,24,8)
        self.assertEqual(esperado, actual)

if __name__ == "__main__":
    unittest.main()