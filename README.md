# SO_BinaryFormatter_Compare

> Resources.Load() 를 이용한 Scriptable Object 10000개 Load

> BinaryFormatter.Deserialize()를 이용한 Binary File 10000개 파싱 및 Load

비교하기

현재는 Scriptable Object가 8배 정도 빠름

하지만

1. Resource.Load 함수를 사용할 수 없는 것을 감안해야함 ㅡ> 에셋 번들로 수정
2. 회사 것이 BinaryFormatter.Deserialize()보다 빠를 수 있음