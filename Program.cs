﻿using System;

class JogoDosDados{
    static void Main(){
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Random jogada = new Random();

        int primeiroDado = jogada.Next(1,7);
        int segundoDado = jogada.Next(1,7);
        int terceiroDado = jogada.Next(1,7);
        int bonus = 0;
        int totalDePontos = primeiroDado + segundoDado + terceiroDado;
        string bonificacao = "";
        string anuncioDeBonificacao = "";
        string fimDeJogo = "";

        if(primeiroDado == segundoDado || primeiroDado == terceiroDado || segundoDado == terceiroDado){
            bonificacao = "dupla";
            bonus+= 2;
        }

        if(primeiroDado == segundoDado && primeiroDado == terceiroDado){
            bonificacao = "tripla";
            bonus+= 6;
        }

        totalDePontos+=bonus;

        fimDeJogo = totalDePontos >= 15 ? "Parabéns, você venceu o jogo!" : "Que pena! Você perdeu o jogo...";

        anuncioDeBonificacao = bonificacao != "" ? "Você obteve bonificação" : "Você não obteve bonificação";

         Console.WriteLine($@"
        1º DADO: {primeiroDado}
        2º DADO: {segundoDado}
        3º DADO: {terceiroDado}

        {anuncioDeBonificacao} {bonificacao}

        Bônus: {bonus}

        Tota de pontos: {totalDePontos}

        {fimDeJogo}
        ");

    }
}