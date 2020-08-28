using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace KitBasico{

  

    public class Movimiento : MonoBehaviour{


        [Header("Movimiento")]
        [SerializeField]
        private Vector3 direccion = Vector3.left;
        [SerializeField]
        private float distancia = 5.0f;
        [SerializeField]
        private float velocidad = 10.0f;    
        [Header("Elementos")]
        [SerializeField]
        private Transform entidad = null;


        private Vector3 posinicial,postarget;

        private void Start(){

            direccion /= direccion.magnitude; 

            if (entidad == null) {
                Debug.LogError("No se selecciono una entidad.");
                return;
            }
            posinicial = entidad.position;
            postarget = posinicial + direccion * distancia;
        }


        private void Update(){
            if (entidad == null)
                return;
            entidad.position = Vector3.MoveTowards(entidad.position, postarget, velocidad * Time.deltaTime);
        }


    }


}