import pandas as pd
import pickle
import random

df = pd.read_csv(r'C:\Users\ogzhn\Desktop\saldiri-tespit-sistemi-main\SaldırıTespitSistemi\UNSW_NB15_testing-set.csv')

with open(r'C:\Users\ogzhn\Desktop\saldiri-tespit-sistemi-main\SaldırıTespitSistemi\model_1_knn', 'rb') as file:
    model = pickle.load(file)


df = df.iloc[:,1:]
df1 = df.copy()


input = df.drop(columns=['label', 'ct_state_ttl', 'proto_udp'],axis=1)

sonuc = model.predict(input)

rastgele_sayi = random.randint(0, 175341)

if(sonuc[rastgele_sayi] == 1) :
    print("Analysis Saldırısı Gerçekleşti")
elif(sonuc[rastgele_sayi] == 2) :
    print("Backdoor Saldırısı Gerçekleşti")
elif(sonuc[rastgele_sayi] == 3) :
    print("DoS Saldırısı Gerçekleşti")
elif(sonuc[rastgele_sayi] == 4) :
    print("Exploits Saldırısı Gerçekleşti")
elif(sonuc[rastgele_sayi] == 5) :
    print("Fuzzers Saldırısı Gerçekleşti")
elif(sonuc[rastgele_sayi] == 6) :
    print("Generic Saldırısı Gerçekleşti")
elif(sonuc[rastgele_sayi] == 7) :
    print("Reconnaissance Saldırısı Gerçekleşti")
elif(sonuc[rastgele_sayi] == 8) :
    print("Shellcode Saldırısı Gerçekleşti")
elif(sonuc[rastgele_sayi] == 9) :
    print("Worms Saldırısı Gerçekleşti")
else:
    print("yanlis deger")
