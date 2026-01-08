using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teste : MonoBehaviour
{
    [SerializeField] private GameObject _vxf;

	public void AparecerEfeito()
{
_vxf.SetActive(true);
}

	public void DesaparecerEfeito()
{
_vxf.SetActive(false);
}
}
