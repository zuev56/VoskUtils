REST API для работы с VOSK (ASR).
Vosk работает через WebSocket, что часто может быть неудобно.

Данная REST API принимает
- *.wav 8000 KHz 16 bit (может работать без конвертации)
- *.mp3, *.wma и другие форматы аудиофайлов, которые FFmpeg может преобразовать в файл .wav с заданными характеристиками

Возвращает либо JSON (детальный вывод), либо text/plain в зависимости от хедера Accept.

Пример вызова:
```
curl http://my-server:7075/vosk/transcribe \
  --request POST \
  --header 'Content-Type: multipart/form-data' \
  --header 'Accept: text/plain' \
  --form 'input.mp3=@input.mp3'
```

**Перед развёртыванием при необходимости стоит заменить linux-amd64 на нужную архитектуру процессора в \Vosk.WebApi\Dockerfile**
