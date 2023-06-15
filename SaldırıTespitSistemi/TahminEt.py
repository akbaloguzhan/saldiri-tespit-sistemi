import csv

import numpy as np
import pandas as pd
from sklearn.preprocessing import MinMaxScaler
from sklearn import preprocessing
from sklearn.model_selection import train_test_split


df = pd.read_csv('UNSW_NB15_testing-set.csv')

df[df['service'] == '-']
df['service'].replace('-','null',inplace=True)

df1 = pd.concat([df[df['proto'] == df['proto'].value_counts().index[0]],
          df[df['proto'] == df['proto'].value_counts().index[1]],
          df[df['proto'] == df['proto'].value_counts().index[2]],
          df[df['proto'] == df['proto'].value_counts().index[3]],
          df[df['proto'] == df['proto'].value_counts().index[4]],
          df[df['proto'] == df['proto'].value_counts().index[5]]])

categoric_columns = df.select_dtypes(include='object').columns[:-1]
df_categories = df[categoric_columns].copy()
df_categories = pd.get_dummies(df_categories,columns=categoric_columns)

df2 = pd.concat([df,df_categories],axis = 1)
df2.drop(columns=categoric_columns,inplace=True)

numerical_columns = list(df.select_dtypes(include='number').columns)
numerical_columns.remove('id')
numerical_columns.remove('label')

minmax_scaler = MinMaxScaler(feature_range=(0, 1))
def normalization(df,columns):
    for i in columns:
        arr = df[i]
        arr = np.array(arr)
        df[i] = minmax_scaler.fit_transform(arr.reshape(len(arr),1))
    return df

df3 = normalization(df2.copy(),numerical_columns)

binary_labels = pd.DataFrame(df3.label.map(lambda x:'normal' if x==0 else 'anormal'))
df4 = df3.copy()
df4['label'] = binary_labels
le1 = preprocessing.LabelEncoder()
encoder_labels = binary_labels.apply(le1.fit_transform)
df4['label'] = encoder_labels

df5 = df3.copy()
multi_labels = pd.DataFrame(df5.attack_cat)
df5 = pd.get_dummies(df5, columns=['attack_cat'])
le2 = preprocessing.LabelEncoder()
encoder_labels = multi_labels.apply(le2.fit_transform)
df5['label'] = encoder_labels

numerical_columns.append('label')
correlation_binary = df4[numerical_columns].corr()

numerical_columns = list(df5.select_dtypes(include='number').columns)
corr_multi = df5[numerical_columns].corr()

corr_ybin = abs(correlation_binary['label'])
highest_corr_bin = corr_ybin[corr_ybin >0.25]

df6 = df4[highest_corr_bin.index].copy()

corr_ymulti = abs(corr_multi['label'])
highest_corr_multi = corr_ymulti[corr_ymulti >0.25]

df7 = df5[highest_corr_multi.index].copy()
df7 = df7.iloc[:,1:]

X = df7.drop(columns=['label'],axis=1)
y = df7['label']
X_train,X_test,y_train,y_test = train_test_split(X, y, test_size=0.20, random_state=0, stratify=y)


df7.to_csv('UNSW_NB15_testing-set.csv', index=False)