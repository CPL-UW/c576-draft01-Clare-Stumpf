# c576-draft01-Clare-Stumpf
c576-draft01-Clare-Stumpf created by GitHub Classroom

Notes: Build doesn't seem to be working properly. Some features will work when I'm testing them in Unity but not in the build. I don't know why.

Theme: Management Simulation

Feature: Toolbuilding & Analytics

Learning Objectives: Insurance

Features Implemented
1. There's a main menu (You can quit the game from here, play, or visit the instructions menu)
2. A Grid Shows up with random geological including trees and water
3. Exit Takes You Back to the Main Menu
4. You can buy buildings (each have risk profile, price, and revenue) and place them on the grid through the building button at the bottom
5. For each building, you need to choose an insurance option
6. The finances menu shows a summary of financial results after each year, and you can browse results from multiple years
7. Loss Info Shows the Loss Amounts and Probabilities for Low, Medium, and High Risk Profiles
8. Hitting Play will simulate random losses and calculate the losses, revenue, and amount covered by insurance
9. After a set number of years, it prints in the console whether you won or lost (do you have more or less than what you started with?)
10. Linked Firebase to Unity Project (doesn't do much right now)

Features To Be Implemented
1. Actually do the math to get good numbers
2. Create a Game Over Screen (with graphs of performance???)
3. Implement Analytics Stuff
4. Have Geological Features Impact the risk profile
5. Give a notification if they don't have enough money to buy stuff
6. Don't let them buy another building if they haven't placed the first

Bug Fixes
1. You shouldn't be able to click on trees and water - Solved
2. You shouldn't be able to buy more than you can afford - Solved
3. It isn't calculated some totals that are displayed in the finances submenu correctly - Solved
4. Year Label is 1 off, I think


Potential Stretch Goals
1. Basic Procedural Generation (Lakes, rivers, or forests could form)
2. Add Scoreboard
3. Add Option to Delete Building or Change Insurance Each Year
4. Connect Text Boxes to Code to Change Building Options and Insurance Options for each year
5. Immediately calculates stuff but maybe make a delay where you can see losses happening in real time (like in that coffee shop simulator game from coolmath) like perhaps like news headlines
6. Add Difficulty Setting
7. Ability to pay for risk prevention/reduction like fire resistant materials that would lower impact of trees and forests on the buildings risk profile
8. After a couple of years, companies stop offering floor or fire protection, but you can add it with an endoresement for extra cost
9. Include limits
10. Revenue fluctuates depending on when in the year the loss happens -> Business Interruption Insurance
11. If you have to borrow money, interest rates
12. Add interactive tutorial


