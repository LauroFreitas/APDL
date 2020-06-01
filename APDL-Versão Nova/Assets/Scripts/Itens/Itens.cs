using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public abstract class Itens 
{
    public GameObject itemPrefab;
    public ItensType tipo;
    public bool ativador;
    public abstract void Desativar();
}
public class Chave : Itens 
{
    public Chave(ItensType tipo) 
    {
        this.tipo = tipo;
    }

    public override void Desativar()
    {
        itemPrefab.SetActive(false);
    }
}
public class Lanterna : Itens 
{
    public Lanterna(ItensType tipo) 
    {
        this.tipo = tipo;
    }

    public override void Desativar()
    {
        itemPrefab.SetActive(false);
    }
}
public class Remedio:Itens
{
    public Remedio(ItensType tipo)
    {
        this.tipo = tipo;
    }

    public override void Desativar()
    {
        itemPrefab.SetActive(false);
    }
}
public class Pilha : Itens 
{
    public Pilha(ItensType tipo)
    {
        this.tipo = tipo;
    }
    public override void Desativar()
    {
      itemPrefab.SetActive(false);
    }
}
