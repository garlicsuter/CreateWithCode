# CreateWithCode
 Unity Learn "Create with Code" Projects

All the projects in one place!
# Challege 4 (soccer) fixes
- After importing the Challenge 4 assets, the Unit 4 player texture is removed, re-add it.

- When attempting to remedy Challenge 4 problem 1, scene isn't playable because EnemyX.cs script is missing a GameObject reference to PlayerGoal. Fixed by using a tag on Player Goal:

private void Awake()
    {
            playerGoal = GameObject.FindGameObjectWithTag("PlayerGoal");
    }

# Lab 4
I copied the Lab 3 from Unit 3 into my Unit 4 Assets folder, renamed it Lab 4.