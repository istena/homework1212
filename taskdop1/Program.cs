int funck(int n){
    int res=1;
    for(int i=1;i<=n;i++) res=res*i;
    return res;
}
Console.Clear();
Console.Write("Введите строку: ");
string b1 = Convert.ToString(Console.ReadLine());
char [] stroka = new char [b1.Length];
for(int i=0;i<b1.Length;i++){
    stroka[i]=b1[i];
}

string rez="";
for(int i=0;i<funck(b1.Length);i++){
    rez+=stroka[i];
    for(int j=0;j<b1.Length-1;j++){
        rez+=stroka[i+1+j];
    }
   
}
