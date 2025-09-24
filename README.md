
# Caso: Simulación de Cajero Automático

**Actividad:**
Desarrollar en C# los siguientes programas:

Desarrollar un programa en C# que simule el funcionamiento de un cajero
automático básico. El sistema debe permitir al usuario interactuar con un menú
que ofrece varias opciones:

- Consultar saldo
- Retirar dinero
- Depositar dinero
- Salir

Además, debe validar los montos y limitar los intentos fallidos.

**Descripción del problema:**

Un cliente llega al cajero automático para realizar operaciones. Inicialmente
tiene un saldo de S/. 1000. El cajero debe permitirle:

1. Consultar su saldo actual.

2. Retirar dinero, con las siguientes condiciones:

- No se puede retirar más de S/ 500 por operación.
- El retiro no puede superar el saldo disponible.
- Si el retiro es inválido, se incrementa un contador de intentos fallidos.
- A los 3 intentos fallidos, el sistema debe bloquear el retiro.

3. Depositar dinero, validando que el monto sea mayor a 0.

4. Salir del sistema.

El programa debe funcionar en un bucle hasta que el usuario seleccione la
opción "Salir" o se bloqueen los intentos.

## Reglas adicionales

- El programa debe usar métodos void para mostrar mensajes o
información.

- El programa debe usar métodos con return para validar montos y
actualizar saldo.

- No se deben usar clases ni objetos, sólo métodos estáticos en un mismo
archivo/programa.

- El programa debe mantener un menú en bucle hasta salir.


## 🚀 Info del Grupo

**Integrantes:**

```bash
Machuca Ramírez, Luis Miguel     n00420048@upn.pe

Pacheco Ibarra, Juan Carlos      n00119355@upn.pe

Palomino Delgado, Cesar Jairo    n00479037@upn.pe

Quispe Guzman, Victor Antonio    n00419399@upn.pe
```