# c576-draft01-Clare-Stumpf
c576-draft01-Clare-Stumpf created by GitHub Classroom

Notes: Build doesn't seem to be working properly. Some features will work when I'm testing them in Unity but not in the build. I don't know why.

Theme: Management Simulation

Feature: Toolbuilding & Analytics

Learning Objectives: Insurance

Features Implemented
1. There's a main menu (You can quit the game from here, play, or visit a non-existant options menu)
2. A Grid Shows up with random geological including trees and water
3. Exit Takes You Back to the Main Menu
4. You can buy buildings (each have risk profile, price, and revenue) and place them on the grid through the building button at the bottom
5. For each building, you need to choose an insurance option through the insurance button at the bottom
6. The finances button will show a summary of financial results after each year, but that isn't implemented yet. The info is just printed in the Debug.Log();
7. Loss Info Shows the Loss Amounts and Probabilities for Low, Medium, and High Risk Profiles
8. Hitting Play will simulate random losses and calculate the losses, revenue, and amount covered by insurance
9. After a set number of years (currently set at 2 just for testing), it prints in the console whether you won or lost (do you have more or less than what you started with?)
10. Linked Firebase to Unity Project (doesn't do anything right now)

Features To Be Implemented
1. Have the ability to see financial summary (currently just in debug)
2. Have the ability to see past financial History
3. Connect Text Boxes to Code to Change Building Options and Insurance Options for each year
4. Have it pull up the insurance menu immediately after buying a building
5. Actually do the math to get good numbers
6. Be able to close a submenu by clicking the submenu button again instead of having to click the exit button on the submenu
7. Make Cash Available formatted with commas
8. Make the layout of the Submenus way better
9. Create an in-game tutorial
10. Implement options menu in main menu
11. Create a Game Over Screen (with graphs of performance???)
12. Implement Better Firebase and Tool Stuff
13. Have Geological Features Impact the risk profile

Bug Fixes
1. You shouldn't be able to click on trees and water
2. You shouldn't be able to buy more than you can afford

Potential Stretch Goals
1. Basic Procedural Generation (Lakes, rivers, or forests could form)
2. Add Scoreboard
3. Add Option to Delete Building or Change Insurance Each Year
3. Immediately calculates stuff but maybe make a delay where you can see losses happening in real time (like in that coffee shop simulator game from coolmath) like perhaps like news headlines
4. Add Difficulty Setting
5. Ability to pay for risk prevention/reduction like fire resistant materials that would lower impact of trees and forests on the buildings risk profile
6. After a couple of years, companies stop offering floor or fire protection, but you can add it with an endoresement for extra cost
7. Include limits
8. Revenue fluctuates depending on when in the year the loss happens -> Business Interruption Insurance
9. If you have to borrow money, interest rates


