namespace CampaniaVacunacion
{
    class Program
    {
        static void Main(string[] args)
        {
            // ================================
            // 1. Crear conjunto de 500 ciudadanos
            // ================================
            HashSet<string> ciudadanos = new HashSet<string>();

            for (int i = 1; i <= 500; i++)
            {
                ciudadanos.Add($"Ciudadano {i}");
            }

            // ================================
            // 2. Crear conjunto vacunados Pfizer (75)
            // ================================
            HashSet<string> vacunadosPfizer = new HashSet<string>();

            for (int i = 1; i <= 75; i++)
            {
                vacunadosPfizer.Add($"Ciudadano {i}");
            }

            // ================================
            // 3. Crear conjunto vacunados AstraZeneca (75)
            // ================================
            HashSet<string> vacunadosAstraZeneca = new HashSet<string>();

            for (int i = 50; i < 125; i++)
            {
                vacunadosAstraZeneca.Add($"Ciudadano {i}");
            }

            // ================================
            // OPERACIONES DE TEORÍA DE CONJUNTOS
            // ================================

            // Unión (Pfizer ∪ AstraZeneca)
            HashSet<string> vacunadosTotales = new HashSet<string>(vacunadosPfizer);
            vacunadosTotales.UnionWith(vacunadosAstraZeneca);

            // Ciudadanos no vacunados (Total - Vacunados)
            HashSet<string> noVacunados = new HashSet<string>(ciudadanos);
            noVacunados.ExceptWith(vacunadosTotales);

            // Ambas dosis (Intersección)
            HashSet<string> ambasDosis = new HashSet<string>(vacunadosPfizer);
            ambasDosis.IntersectWith(vacunadosAstraZeneca);

            // Solo Pfizer (Pfizer - AstraZeneca)
            HashSet<string> soloPfizer = new HashSet<string>(vacunadosPfizer);
            soloPfizer.ExceptWith(vacunadosAstraZeneca);

            // Solo AstraZeneca (AstraZeneca - Pfizer)
            HashSet<string> soloAstraZeneca = new HashSet<string>(vacunadosAstraZeneca);
            soloAstraZeneca.ExceptWith(vacunadosPfizer);

            // ================================
            // MOSTRAR RESULTADOS
            // ================================

            Console.WriteLine("=== RESULTADOS CAMPAÑA DE VACUNACIÓN ===\n");

            Console.WriteLine($"Ciudadanos no vacunados: {noVacunados.Count}");
            Console.WriteLine($"Ciudadanos con ambas dosis: {ambasDosis.Count}");
            Console.WriteLine($"Ciudadanos solo Pfizer: {soloPfizer.Count}");
            Console.WriteLine($"Ciudadanos solo AstraZeneca: {soloAstraZeneca.Count}");

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}