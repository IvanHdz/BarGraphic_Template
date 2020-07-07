using System.Collections.Generic;
using System.Windows.Media;

namespace BarGraphic.Template
{
    public class Graphs
    {
        public Graphs()
        {
            this.LlenarEtiquetas();
            this.LlenarGrafico();
        }

        private void LlenarEtiquetas()
        {
            this.Etiquetas = new List<string>();
            this.Etiquetas.Add("Línea 1");
            this.Etiquetas.Add("Línea 2");
            this.Etiquetas.Add("Línea 3");
            this.Etiquetas.Add("Línea 4");
            this.Etiquetas.Add("Línea 5");
        }

        private void LlenarGrafico()
        {
            this.GraficoLista = new List<GraphModel>();

            this.GraficoLista.Add(new GraphModel
            {
                Duracion = 800,
                SeccionLista = new List<SectionModel>()
                {
                    new SectionModel { Duracion = 25.5 },
                    new SectionModel { Duracion = 30.2, Color = Colors.Magenta },
                    new SectionModel { Duracion = 28.4 },
                    new SectionModel { Duracion = 25.3, Color = Colors.Maroon }
                }
            });
            this.GraficoLista.Add(new GraphModel
            {
                Duracion = 800,
                SeccionLista = new List<SectionModel>()
                {
                    new SectionModel { Duracion = 35.3, Color = Colors.AliceBlue },
                    new SectionModel { Duracion = 31.2, Color = Colors.Aqua },
                    new SectionModel { Duracion = 36.4, Color = Colors.Azure },
                    new SectionModel { Duracion = 38.3, Color = Colors.Bisque },
                    new SectionModel { Duracion = 50.4, Color = Colors.BlanchedAlmond },
                    new SectionModel { Duracion = 38.3, Color = Colors.Blue }
                }
            });
            this.GraficoLista.Add(new GraphModel
            {
                Duracion = 800,
                SeccionLista = new List<SectionModel>()
                {
                    new SectionModel { Duracion = 45.2, Color = Colors.Beige },
                    new SectionModel { Duracion = 50.6, Color = Colors.CadetBlue },
                }
            });
            this.GraficoLista.Add(new GraphModel
            {
                Duracion = 800,
                SeccionLista = new List<SectionModel>()
                {
                    new SectionModel { Duracion = 38.1, Color = Colors.Chocolate },
                    new SectionModel { Duracion = 33.4, Color = Colors.Fuchsia },
                    new SectionModel { Duracion = 50.1, Color = Colors.Coral },
                }
            });
            this.GraficoLista.Add(new GraphModel
            {
                Duracion = 800,
                SeccionLista = new List<SectionModel>()
                {
                    new SectionModel { Duracion = 28.8, Color = Colors.Cyan },
                    new SectionModel { Duracion = 29.4, Color = Colors.DodgerBlue },
                    new SectionModel { Duracion = 41.1, Color = Colors.Gold },
                    new SectionModel { Duracion = 35.7, Color = Colors.ForestGreen },
                    new SectionModel { Duracion = 51.3, Color = Colors.Orange },
                }
            });
        }

        public List<GraphModel> GraficoLista { get; set; }

        public List<string> Etiquetas { get; set; }
    }
}