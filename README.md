# 🚀 Мое Первое API

<div align="center">

![ASP.NET Core](https://img.shields.io/badge/ASP.NET_Core-6.0-purple?style=for-the-badge)
![C#](https://img.shields.io/badge/C%23-10.0-blue?style=for-the-badge)
![GitHub Pages](https://img.shields.io/badge/GitHub_Pages-Online-green?style=for-the-badge)

*Учебный проект по созданию веб-API на ASP.NET Core*

</div>

## 📖 О проекте

Это мой первый опыт создания API 🎯  
Я научился создавать веб-сервисы, которые могут:
- ✅ Принимать запросы из интернета
- ✅ Хранить и обрабатывать данные  
- ✅ Возвращать результаты

## 🛠️ Что умеет этот API

| Функция | Метод | Путь | Описание |
|---------|--------|------|-----------|
| 📋 Получить все имена | `GET` | `/api/names` | Возвращает список всех имен |
| ➕ Добавить имя | `POST` | `/api/names` | Добавляет новое имя |
| 🔍 Найти имя | `GET` | `/api/names/{id}` | Находит имя по ID |
| ✏️ Изменить имя | `PUT` | `/api/names/{id}` | Обновляет имя по ID |
| 🗑️ Удалить имя | `DELETE` | `/api/names/{id}` | Удаляет имя по ID |

## 🎯 Быстрый старт

🏗️ Структура проекта
my-first-api/
├── 📁 src/SimpleApi/          # 🎯 Исходный код API
│   ├── 📁 Controllers/        # 🎮 Контроллеры API
│   ├── 📄 Program.cs          # ⚙️ Главный файл приложения
│   └── 📄 SimpleApi.csproj    # 📦 Файл проекта
├── 📄 index.html              # 🎨 Демо-страница
└── 📄 README.md               # 📚 Эта документация

💻 Технологии
ASP.NET Core 6.0 - фреймворк для веб-API

C# 10 - язык программирования

Swagger/OpenAPI - документация API

GitHub Pages - хостинг статичных сайтов

### 1. 📥 Скачать и установить
```bash
# Клонировать репозиторий
git clone https://github.com/akumakusss123/my-first-api.git

# Перейти в папку проекта  
cd my-first-api/src/SimpleApi
