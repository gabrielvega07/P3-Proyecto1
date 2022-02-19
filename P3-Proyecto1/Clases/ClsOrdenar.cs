using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoN1.Clases
{
    internal class ClsOrdenar
    {
        String[,] equipos= new String[12,10];
        String[] nombreClub = new String[12];
        int[] J = new int[12];
        int[] PTS = new int[12];
        int[] G = new int[12];
        int[] E = new int[12];
        int[] P = new int[12];
        int[] GF = new int[12];
        int[] GC = new int[12];
        int[] DG = new int[12];
        public String[,] ordenar(String[,] clubs)
        {
            for (int x = 0; x < J.Length; x++)
            {
                nombreClub[x] = clubs[x, 1];
                J[x] = Convert.ToInt32(clubs[x, 2]);
                PTS[x] = Convert.ToInt32(clubs[x, 3]);
                G[x] = Convert.ToInt32(clubs[x, 4]);
                E[x] = Convert.ToInt32(clubs[x, 5]);
                P[x] = Convert.ToInt32(clubs[x, 6]);
                GF[x] = Convert.ToInt32(clubs[x, 7]);
                GC[x] = Convert.ToInt32(clubs[x, 8]);
                DG[x] = Convert.ToInt32(clubs[x, 9]);
            }

            int tem_J, tem_PTS,tem_G,tem_E,tem_P,tem_GF,tem_GC,tem_DG;
            String temp_nombreClub;
            for(int i=0; i< (J.Length-1); i++)
            {
                for(int j=0; j< (J.Length - 1); j++)
                {
                    //Ordenar por Puntos
                    if (PTS[j] < PTS[j + 1])
                    {
                       tem_PTS= PTS[j];
                       temp_nombreClub = nombreClub[j];
                       tem_J=J[j];
                       tem_G=G[j];
                       tem_E=E[j];
                       tem_P=P[j];
                       tem_GF=GF[j];
                       tem_GC=GC[j];
                       tem_DG=DG[j];
                       PTS[j]=PTS[j+1];
                       nombreClub[j]=nombreClub[j+1];
                       J[j]=J[j+1];
                       G[j]=G[j+1];
                       E[j]=E[j+1];
                       P[j]=P[j+1];
                       GF[j]=GF[j+1];
                       GC[j]=GC[j+1];
                       DG[j]=DG[j+1];
                       PTS[j + 1] = tem_PTS;
                       nombreClub[j + 1] = temp_nombreClub;
                       J[j + 1] = tem_J;
                       G[j + 1] = tem_G;
                       E[j + 1] = tem_E;
                       P[j + 1] = tem_P;
                       GF[j + 1] = tem_GF;
                       GC[j + 1] = tem_GC;
                       DG[j + 1] = tem_DG;
                    }
                    //Ordenar Diferencia Goles
                    else if(DG[j] < DG[j + 1])
                    {
                        tem_PTS = PTS[j];
                        temp_nombreClub = nombreClub[j];
                        tem_J = J[j];
                        tem_G = G[j];
                        tem_E = E[j];
                        tem_P = P[j];
                        tem_GF = GF[j];
                        tem_GC = GC[j];
                        tem_DG = DG[j];
                        PTS[j] = PTS[j + 1];
                        nombreClub[j] = nombreClub[j + 1];
                        J[j] = J[j + 1];
                        G[j] = G[j + 1];
                        E[j] = E[j + 1];
                        P[j] = P[j + 1];
                        GF[j] = GF[j + 1];
                        GC[j] = GC[j + 1];
                        DG[j] = DG[j + 1];
                        PTS[j + 1] = tem_PTS;
                        nombreClub[j + 1] = temp_nombreClub;
                        J[j + 1] = tem_J;
                        G[j + 1] = tem_G;
                        E[j + 1] = tem_E;
                        P[j + 1] = tem_P;
                        GF[j + 1] = tem_GF;
                        GC[j + 1] = tem_GC;
                        DG[j + 1] = tem_DG;
                    }

                }
            }



            for(int y=0; y < clubs.GetLength(0); y++) {

                equipos[y, 0] = (y + 1) +"";
                equipos[y, 1] = nombreClub[y];
                equipos[y, 2] = J[y] +"";
                equipos[y, 3] = PTS[y] + "";
                equipos[y, 4] = G[y] + "";
                equipos[y, 5] = E[y] + "";
                equipos[y, 6] = P[y] + "";
                equipos[y, 7] = GF[y] + "";
                equipos[y, 8] = GC[y] + "";
                equipos[y, 9] = DG[y] + "";
            }

            return equipos;
          
        }
    }
}







       

