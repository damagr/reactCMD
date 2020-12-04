﻿using System;

namespace DevSolutions
{
    public static class Menus
    {
        public static int MainMenu()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\t\t\tMENU PRINCIPAL\n");
            Console.WriteLine("Selecciona una opción del menú: " +
                 "\n1. Instalar Chocolatey (Necesario para el funcionamiento de la APP)" +
                 "\n2. Instalar NodeJs (Requiere Chocolatey) (Necesario para el funcionamiento de la APP)" + 
                 "\n3. React (Abrir proyecto, iniciar nuevo, instalación librerias y dependencias)" +
                 "\n4. Librerias Javascript (lodash, underscore, browserify)" +
                 "\n5. Utilidades Web (Instalar/iniciar Live-Server/MailDev)" +
                 "\n6. Instalaciones genéricas (Instalar/desinstalar Xampp)" +
                 "\n7. Salir");

            int mainMenu = int.Parse(Console.ReadLine());

            return mainMenu;
        }

        public static int ReactMenu()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\t\t\t\tMENU REACT\n");
            Console.WriteLine("Aclaración: Cuando el asistente nos pida que le indiquemos la ruta donde se almacenan " +
               "los proyectos no letenemos que indicar el directorio del proyecto en concreto que queremos iniciar," +
               "tenemos que indicar solamente el directorio que almacena todos los proyectos que tenemos\n");
            Console.WriteLine("Selecciona una opción del menú: " +
               "\n1. Abrir un proyecto existente (React-Native) (Hace falta tener instaladas NPM, Node, Java8)" +
               "\n2. Iniciar un proyecto nuevo (React-Native) (Hace falta tener instaladas NPM, Node, Java8)" +
               "\n3. Iniciar un proyecto nuevo (React) (Hace falta tener instaladas NPM, Node)" +
               "\n4. Instalar librerias React Native Elements y Vector Icons (Por proyecto) (Requiere Node)" +
               "\n5. Instalar Java8 (Requiere NodeJs)" +
               "\n6. Instalar NPM (Global) - (Requiere NodeJs)" +
               "\n7. Instalar Android Studio (Requiere Chocolatey)" +
               "\n8. Salir");

            int reactMenu = int.Parse(Console.ReadLine());

            return reactMenu;
        }

        public static int JavascriptLibraries()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\t\t\tMENU JAVASCRIPT\n");
            Console.WriteLine("Aclaración: Cuando el asistente nos pida que le indiquemos la ruta donde se almacenan " +
            "los proyectos no letenemos que indicar el directorio del proyecto en concreto que queremos iniciar," +
            "tenemos que indicar solamente el directorio que almacena todos los proyectos que tenemos\n");
            Console.WriteLine("Selecciona una opción del menú: " +
               "\n1. Instalar lodash (Globalmente) (Requiere Node)" +
               "\n2. Instalar underscore (Globalmente) (Requiere Node)" +
               "\n3. Instalar browserify (Por proyecto) (Requiere Node)" +
               "\n4. Salir");

            int nodeMenu = int.Parse(Console.ReadLine());

            return nodeMenu;
        }

        public static int GenericInstall()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\t\t\tMENU INSTALACIONES GENÉRICAS\n");
            Console.WriteLine("Selecciona una opción del menú: " +
               "\n1. Instalar Xampp (Requiere Chocolatey)" +
               "\n2. Desinstalar Xampp (Requiere Chocolatey)" +
               "\n3. Salir");

            int genericMenu = int.Parse(Console.ReadLine());

            return genericMenu;
        }

        public static int WebTools()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\t\t\t\tMENU WEB\n");
            Console.WriteLine("Aclaración: Cuando el asistente nos pida que le indiquemos la ruta donde se almacenan " +
               "los proyectos no letenemos que indicar el directorio del proyecto en concreto que queremos iniciar," +
               "tenemos que indicar solamente el directorio que almacena todos los proyectos que tenemos\n");
            Console.WriteLine("Selecciona una opción del menú: " +
               "\n1. Instalar Live-Server (Globalmente) (Requiere Node) (Requiere Google Chrome)" +
               "\n2. Instalar MailDev (Globalmente) (Requiere Node)" +
               "\n3. Iniciar Live-Server (Requiere Live-Server)" +
               "\n4. Iniciar MailDev (Requiere MailDev)" +
               "\n5. Salir");

            int webMenu = int.Parse(Console.ReadLine());

            return webMenu;
        }
    }
}
