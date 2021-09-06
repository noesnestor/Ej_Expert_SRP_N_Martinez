Clase: 
"AppointmentService"

Responsabilidades:
Armar una consulta médica con un identificador.
Conocer la localidad donde se hará la consulta.
Conocer al paciente.
Conocer al médico.
Conocer la fecha y hora.

Colaboradores:
Medico
Paciente

--------------------------

Clase:
"Paciente"

Responsabilidades:
Armar un perfil de paciente
Conocer el nombre.
Conocer el teléfono.
Conocer la cédula.
Conocer la edad.

--------------------------

Clase:
"Medico"

Responsabilidades:
Armar un perfil del médico
Conocer el nombre
Conocer su especialidad

--------------------------

Clase:
Validador

Responsabilidades:
Validar que los datos introducidos por cada clase son correctos.

Colaboradores:
Paciente
Medico
AppointmentService

