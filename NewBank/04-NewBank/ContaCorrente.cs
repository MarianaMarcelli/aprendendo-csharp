﻿


public class ContaCorrente
{
    public string titular;
    public int conta;
    public int agencia;
    public double saldo = 100;

    //quando possui retorno é mais comumente chamada de função
    public bool Sacar(double valor)
    {
        if (this.saldo < valor)
        {
            return false;
        }

        saldo -= valor;
        return true;
    }
    //função sem retorno (void) é mais comumente chamada de método
    public void Depositar(double valor)
    {
        this.saldo += valor;
    }

    //funções com mais de um argumento
    public bool Transferir(double valor, ContaCorrente contaDestino)
    {
        if (this.saldo < valor)
        {
            return false;
        }

        this.saldo -= valor;
        contaDestino.Depositar(valor);
        return true;

    }
}