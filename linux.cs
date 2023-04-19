using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System;





namespace svg
{
    internal class Program
    {
        

        static void Main(string[] args)
            
        {
            if (args.Length > 0)
            {
                // Lê todas as linhas do arquivo
                string[] linhas = System.IO.File.ReadAllLines(args[0]);
                using (StreamWriter file = new StreamWriter(args[0]+".svg"))
                {
                    file.WriteLine("<svg width=\"800\" height=\"800\" viewBox=\"0 0 200 200\" xmlns=\"http://www.w3.org/2000/svg\">\r\n");
                    file.WriteLine("<rect width=\"100%\" height=\"100%\" fill=\"#00f\"/>\r\n");
                    {
                        foreach (string linha in linhas) // Percorre cada linha do arquivo
                        {
                            if (linha.StartsWith("line")) // Verifica se a linha começa com a string "line,0,0,100"
                            {
                                // Separa as coordenadas da linha
                                string[] coords = linha.Split(',');
                                if (coords.Length > 3)
                                {
                                    string s = "";
                                    s = "<line x1=\"" + coords[1] + "\" y1=\"" + coords[2] + "\" x2=\"" + coords[3] + "\" y2=\"" + coords[4] + "\" stroke=\"#fff\" stroke-width=\"2\"/>\r\n";
                                    file.WriteLine(s);
                                }
                            }
                            // Desenha a linha no objeto 

                        }
                        file.WriteLine("</svg>\r\n");
                        file.Close();
                    }
                }
           ;
            }
        }
        

}
}
