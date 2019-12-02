# Keras.Net_Sample

# 개요
[Keras.Net](https://github.com/SciSharp/Keras.NET)과 [Google Teachable Machine](https://teachablemachine.withgoogle.com)을 활용한 Winform에서의 Keras 샘플.

# Python 설치 방법
## 1. Python 3.6 설치
1.1. 인스톨러 다운로드
 - https://www.python.org/downloads/release/python-365/

1.2. 설치 시 옵션
 - Advanced Options에서 `Install for all users`, `Add Python to environment variables` 체크
 
   (환경변수 설정이 안되어 있을경우 파이썬을 찾지 못해 Exception 발생)
 
## 2. Keras 설치
```
pip install --upgrade pip
pip install --upgrade setuptools
pip install tensorflow keras pillow
```

# Build 방법
 - CPU Target을 x64로 설정 후 빌드 (x86에서 실행 불가)

# 결과
 - label.txt의 순서대로 매칭 확률 출력. ex) [[9.9984777e-01 5.2654912e-05 9.1804341e-06 9.0343616e-05]]
