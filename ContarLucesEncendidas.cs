/* Aparecer un objeto luego de encender X cantidad de luces */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContarLucesEncendidas : MonoBehaviour
{
  /* Arreglo de luces que queremos prender antes */
	public Light[] lucesAcontar;
  
  /* Objeto que queremos mostrar */
	public GameObject objetoMostrar;
  
  /* Contador para ir guardando las luces que se están encendiendo */
	public int contador=0;

    void Update()
    {
      /* Si el contador actual es menor al tamaño del arreglo de luces */
    	if(contador<lucesAcontar.Length){
      
        /* Si la luz actual está encendida */
    		if(lucesAcontar[contador].enabled == true){
        
          /* Suma 1 al contador */
    			contador++;
    		}
        
      /*Si el contador actual es igual a la cantidad de luces que queremos encender */
    	}else if(contador==lucesAcontar.Length){
      
        /* Aparecemos el objeto */
    		objetoMostrar.SetActive(true);
    	}
    }
}
