# VK-Internship-WebAPI
Необходимо реализовать API приложение на ASP.NET Core.
# Требования бизнес-логики и ограничения:
- Формат запроса/ответа - Json
* Методы API должны быть асинхронными
- В качестве СУБД необходимо использовать PostgreSQL
* В качестве ORM необхоидмо использовать EntityFrameworkCore
- В качестве моделей данных должны использоваться следующие сущности:
   - user(id, login, password, created_date, user_group_id, user_state_id)
   - user_group(id, code, description)
   - user_state(id, code, description)