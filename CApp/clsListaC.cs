using System;
using System.Collections.Generic;
using System.Text;

namespace CApp
{
    public class clsListaC
    {
        class Nodo
        {
            public int info;
            public Nodo sig;
        }
        //Atributos
        private Nodo tope, rear;
        int cant;
        //Constructor 
        public clsListaC()
        {
            tope = null;
            rear = null;
            int cant = 0;
        }
        public bool Vacia()
        {
            return tope == null;
        }
        //Insertar un nodo al final de la lista circular
        public clsListaC AddDespues(int ele)
        {
            clsListaC L = new clsListaC();
            Nodo nuevo = new Nodo();
            nuevo.info = ele;
            nuevo.sig = tope;
            if (Vacia() == true)
            {
                tope = nuevo;
                rear = nuevo;
                cant++;
            }
            else
            {
                rear.sig = nuevo;
                rear = nuevo;
                cant++;
            }
            //Actualizando a L
            L.tope = tope;
            L.rear = rear;
            return L;

        }
        //Insertar un nodo al inicio de la lista circular
        public clsListaC AddPrimero(int ele)
        {
            clsListaC L = new clsListaC();
            Nodo nuevo = new Nodo();
            nuevo.info = ele;
            nuevo.sig = tope;
            if (Vacia())
            {
                tope = nuevo;
                rear = nuevo;
                cant++;
            }
            else
            {
                rear.sig = nuevo;
                tope = nuevo;
                cant++;
                
            }
            //Actualizando a L
            L.tope = tope;
            L.rear = rear;
            return L;
        }
        //Insertar un nodo en la lista circular después de otro nodo.
        public clsListaC AddDespues(int elex,int ele)
        {
            clsListaC L = new clsListaC();
            Nodo actual = tope;
            Nodo pos = tope.sig;
            bool existe = false;
            if (Vacia() == false)
            {
                int i = 1;
                while((i<=cant)&& (existe == false))
                {
                    if (actual.info == elex)
                    {
                        existe = true;
                        Nodo Nuevo = new Nodo();
                        Nuevo.info = ele;
                        Nuevo.sig = pos;
                        actual.sig = Nuevo;
                    }
                    actual = pos;
                    pos = pos.sig;
                    i++;
                }
            }
            //Actualizando a L
            L.tope = tope;
            L.rear = rear;
            return L;
        }
        // Insertar un nodo en la lista circular antes de otro nodo.
        public clsListaC AddAntes(int elex,int ele)
        {
            clsListaC L = new clsListaC();
            Nodo anterior = null;
            Nodo actual = tope;
            bool existe = false;
            if (Vacia() == false)
            {
                int i = 1;
                while ((i <= cant) && (existe == false))
                {
                    if (actual.info == elex)
                    {
                        Nodo nuevo = new Nodo();
                        nuevo.info = ele;
                        nuevo.sig = actual;
                        anterior.sig = nuevo;
                    }
                    anterior = actual;
                    actual = actual.sig;
                    i++;
                }
            }
            //Actualizando a L
            L.tope = tope;
            L.rear = rear;
            return L;


        }
        //Eliminar un nodo de la lista circular
        //Eliminar el primer nodo de la lista circular.
        public clsListaC DelPrimero()
        {
            clsListaC L = new clsListaC();
            Nodo pos;
            pos = tope;
            if (pos == null) //si fuera una Lista vacia
            {
                L.tope = tope;
                L.rear = rear;
                return L;
            }
            tope = pos.sig;
            pos = null;
            rear.sig = tope;
            //Actualizando a L
            L.tope = tope;
            L.rear = rear;
            return L;
        }
        public clsListaC DelUltimo()
        {
            clsListaC L = new clsListaC();
            Nodo anterior = null;
            Nodo actual = tope;
            Nodo pos = tope.sig;
            if ((Vacia() == false) && (tope == rear))
            {
                tope = null;
                rear = null;
            }
            else
            {
                if (Vacia() == false)
                {
                    while (pos != tope)
                    {
                        anterior = actual;
                        actual = pos;
                        pos = pos.sig;
                    }
                    actual.sig = tope;
                   
                    rear =actual;
                    actual = null;
                }
            }
            //Actualizando a L
            L.tope = tope;
            L.rear = rear;
            return L;
        }






    }
}
