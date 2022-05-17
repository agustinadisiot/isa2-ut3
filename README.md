# Repo de pruebas para Ejercicios UT3

## Estructura del repo
  - ejercicios-ut3.sln solución de ejemplo de Estudiante
  - ejercicios-ut3 - directorio conteniendo todos los proyectos de la solución


## REST Api

- GET http://localhost:5000/api/estudiante - retorna todos los estudiantes que fueron creados en memoria
- GET http://localhost:5000/api/estudiante/[id] - retorna los datos de un estudiante con id = [id]

- POST http://localhost:5000/api/estudiante - crear nuevo estudiante, ej. para body:
  
  ```
  {
   "Nombre":"Carina",
   "Apellido":"Fontan",
   "NroEstudiante":123456
  }
  ```
 - PUT http://localhost:5000/api/estudiante - editar un estudiante ya existente, ej. para body:
  
    ```
    {
     "Id":1,
     "Nombre":"Carina",
     "Apellido":"Fontan",
     "NroEstudiante":123456
    }
    ```
  - DELETE http://localhost:5000/api/estudiante/[id] - elimina el estudiante con id = [id]

