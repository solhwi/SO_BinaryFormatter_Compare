# SO_BinaryFormatter_Compare

> AssetBundle로부터 LoadAsset<T>(string path) 를 이용한 Scriptable Object 10000개 Load

> BinaryFormatter.Deserialize()를 이용한 Binary File 10000개 파싱 및 Load

비교하기

현재는 Scriptable Object가 5배 정도 빠름

하지만

System.IO.File.ReadAllBytes(file_name); ㅡ> byte

Encoding.UTF8.GetString(_binary); ㅡ> string

로 Deserialize 코드를 변경해야합니다.
