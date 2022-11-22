
int[,] numeros = new int[4,4];

numeros[0,0] = 10;
numeros[0,1] = 20;
numeros[0,2] = 30;
numeros[0,3] = 40;
numeros[1,0] = 12;
numeros[1,1] = 43;
numeros[1,2] = 33;
numeros[1,3] = 54;
numeros[2,0] = 6;
numeros[2,1] = 65;
numeros[2,2] = 34;
numeros[2,3] = 6;
numeros[3,0] = 34;
numeros[3,1] = 67;
numeros[3,2] = 56;
numeros[3,3] = 75;

for(int i = 0; i < 4; i++){
    for(int j = 0; j < 4; j++){
        Console.Write(numeros[i,j]+ "  ");
    }
    Console.WriteLine();
    
}


