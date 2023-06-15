import pandas as pd
import pickle
import random

df = pd.read_csv('UNSW_NB15_testing-set.csv')

with open('model_1_logistic_regression', 'rb') as file:
    model = pickle.load(file)


df = df.iloc[:,1:]

input = df.drop(columns=['label', 'ct_state_ttl', 'proto_udp'],axis=1)

sonuc = model.predict(input)

rastgele_sayi = random.randint(0, 175341)


if(sonuc[rastgele_sayi] == 1) :
    print("a")
elif(sonuc[rastgele_sayi] == 2) :
    print("b")
elif(sonuc[rastgele_sayi] == 3) :
    print("c")
elif(sonuc[rastgele_sayi] == 4) :
    print("d")
elif(sonuc[rastgele_sayi] == 5) :
    print("e")
elif(sonuc[rastgele_sayi] == 6) :
    print("f")
else:
    print("yanlis deger")
