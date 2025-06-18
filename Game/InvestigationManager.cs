namespace Sensors
{
    internal class InvestigationManager
    {
        Iranian irn = new Iranian(Iranian.RankAgentEnum.Foot_Soldier);
        private static int score = 0 ;
        private int turn { get; set; } = 0;
        
        public InvestigationManager() { }
        
        public void runProcess()
        {
            while (score < irn.rankValue)
            {
                if (turn <= 10)
                {
                    irn.ShowWeaknesses();
                    string choice = UI.Play();
                    this.turn++;
                    switch (choice)
                    {
                        case "1":
                            score += irn.GetMatchCount("Thermal");
                            showscore();
                            break;
                        case "2":
                            score += irn.GetMatchCount("Audio");
                            showscore();
                            break;
                        case "3":
                            score += irn.GetMatchCount("Motion");
                            showscore();
                            break;
                        case "4":
                            score += irn.GetMatchCount("Pulse");
                            showscore();
                            break;
                        case "5":
                            score += irn.GetMatchCount("Magnetic");
                            showscore();
                            break;
                        case "6":
                            score += irn.GetMatchCount("Signal");
                            showscore();
                            break;
                        case "7":
                            score += irn.GetMatchCount("Light");
                            showscore();
                            break;
                        default:
                            Console.WriteLine("Invalid choice, please try again.");
                            runProcess();

                            break;
                    }
                }
                else 
                {

                } 
            }
            
        }
        public void showscore()
        {
            Console.WriteLine($"the iranian {irn.Name}wounded {score}/{irn.rankValue}");
            
        }


    }
}