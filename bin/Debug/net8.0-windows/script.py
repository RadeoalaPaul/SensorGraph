import serial
import re
import pathlib
from pathlib import Path

var = 0
ok = True
valori_umiditate = []
valori_temperatura = []

fisier_umiditate = Path("G:/visual studio/proiectSAIV/mipatemp/MIPATemp/bin/Debug/net8.0-windows/hum.txt")
fisier_temperatura = Path("G:/visual studio/proiectSAIV/mipatemp/MIPATemp/bin/Debug/net8.0-windows/temp.txt")

ser = serial.Serial(
    port='COM5',
    baudrate=9600, 
    timeout=2
)

def scriere_fisier(data):
    if(data == temp):
        fisier_temperatura.open(mode="w", encoding="utf-8")
        with fisier_temperatura.open(mode="a", encoding="utf-8") as file:
            for i in range(0,len(temp)):
                file.write(str(temp[i]) + "\n")
    if(data == um):
        fisier_umiditate.open(mode="w", encoding="utf-8")
        with fisier_umiditate.open(mode="a", encoding="utf-8") as file:
            for i in range(0,len(um)):
                file.write(str(um[i]) + "\n")
                
def prelucrare_umiditate(text):
    text = re.findall(r"(\d{2,3}.\d{2,3})\s%",text)
    valori_umiditate.append(text)

def prelucrare_temperatura(text):
    text = re.findall(r"(\d{2,3}.\d{2,3})\sC",text)
    valori_temperatura.append(text)

while ok and var != 9:
    response = ser.readline().decode('utf-8') #citim din arduino
    var+=1
    prelucrare_umiditate(response)
    prelucrare_temperatura(response)

um = [item[0] for item in valori_umiditate if item]
temp = [item[0] for item in valori_temperatura if item]

for i in range(0,len(um)):
    um[i] = float(um[i])
for i in range(0,len(temp)):
    temp[i] = float(temp[i])

scriere_fisier(um)
scriere_fisier(temp)

ser.close()