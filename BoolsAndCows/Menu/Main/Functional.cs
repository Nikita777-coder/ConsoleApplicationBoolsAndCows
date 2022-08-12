namespace BoolsAndCows.MenuClasses
{
    /// <summary>
    /// Main functions of Game.
    /// </summary>
    interface MainFunctions
    {
        /// <summary>
        /// Draw greeting picture.
        /// </summary>
        void Greeting(); 
        
        /// <summary>
        /// Launch game.
        /// </summary>
        void Game();
        //void Settings(); - in processed 
        
        /// <summary>
        /// Exit from game
        /// </summary>
        void Exit();
    }
}