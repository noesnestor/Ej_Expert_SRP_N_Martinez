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
"ValidadorMedico"

Responsabilidades:
Validar que los datos introducidos para la clase "Medico" sean correctos.

Colaboradores:
Medico

--------------------------

Clase:
"ValidadorPaciente"

Responsabilidades:
Validar que los datos introducidos para la clase "Paciente" sean correctos.

Colaboradores:
Paciente

--------------------------

Clase:
"ValidadorAppointmentService"

Responsabilidades:
Validar que los datos introducidos para la clase "AppointmentService" sean correctos.

Colaboradores:
AppointmentService


