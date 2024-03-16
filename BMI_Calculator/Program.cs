using System;

namespace BMI_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Body Mass Index (BMI) Calculator\n");

            double weight = 0;
            double height = 0;

            try
            {
                // Input for weight in kilograms
                Console.Write("Enter your weight (in kilograms): ");
                weight = Convert.ToDouble(Console.ReadLine());

                // Input for height in meters
                Console.Write("Enter your height (in meters): ");
                height = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception e )
            {
                Console.WriteLine($"{e.Message}. Run the program again!!");
                return;
            }

            // Calculate BMI
            double bmi = CalculateBMI(weight, height);

            // Print BMI and health recommendations
            Console.WriteLine($"\nYour BMI is: {bmi:F2}");

            // Determine BMI category and provide health recommendations
            string category = GetBMICategory(bmi);
            Console.WriteLine($"Category: {category}");

            PrintHealthRecommendations(category);

            // Check for extreme BMI values and display medical alert
            CheckMedicalAlert(bmi);

            Console.WriteLine("\nThank you for using my BMI calculator!");
        }

        // Function to calculate BMI
        static double CalculateBMI(double weight, double height)
        {
            return weight / (height * height);
        }

        // Function to determine BMI category
        static string GetBMICategory(double bmi)
        {
            if (bmi < 18.5)
                return "Underweight";
            else if (bmi >= 18.5 && bmi < 25)
                return "Normal weight";
            else if (bmi >= 25 && bmi < 30)
                return "Overweight";
            else
                return "Obese";
        }

        // Function to print health recommendations based on BMI category
        static void PrintHealthRecommendations(string category)
        {
            Console.WriteLine("\nHealth Recommendations:");

            switch (category)
            {
                case "Underweight":
                    Console.WriteLine("- Increase calorie intake with nutrient-rich foods.");
                    Console.WriteLine("- Incorporate strength training to build muscle mass.");
                    Console.WriteLine("- Consider exercises like squats, lunges, and push-ups.");
                    break;
                case "Normal weight":
                    Console.WriteLine("- Maintain a balanced diet and regular exercise routine.");
                    Console.WriteLine("- Monitor weight and adjust diet as needed.");                    
                    Console.WriteLine("- Engage in a variety of exercises such as walking, jogging, and cycling.");
                    break;
                case "Overweight":
                    Console.WriteLine("- Adopt a balanced diet with portion control.");
                    Console.WriteLine("- Engage in regular aerobic exercise to burn calories.");                    
                    Console.WriteLine("- Include exercises like brisk walking, swimming, and dancing.");
                    break;
                case "Obese":
                    Console.WriteLine("- Seek guidance from a healthcare professional for weight management.");
                    Console.WriteLine("- Implement lifestyle changes to improve overall health.");                    
                    Console.WriteLine("- Start with low-impact exercises such as swimming, cycling, or elliptical training.");
                    break;
                default:
                    Console.WriteLine("No specific recommendations available.");
                    break;
            }
        }

        // Function to check for extreme BMI values and display medical alert
        static void CheckMedicalAlert(double bmi)
        {
            if (bmi < 16 || bmi > 40)
            {
                Console.WriteLine("\n*** MEDICAL ALERT: Your BMI is in an extreme range. Please consult a healthcare professional immediately. ***");
            }
        }
    }
}
