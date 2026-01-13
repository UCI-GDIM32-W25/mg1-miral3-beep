[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## Devlog
1. Mira Liu, she/her
2. The plan that I wrote for MG1 in class connects to my code in how the player initiates the seed planting. This would be achieved through the Instantiate method, which would place the plant prefabs at the player's current position in the scene. This would be under the Player class, specifically within the PlantSeed method. As seeds are planted, the GameController updates the UI -- in this case, it would be through the _plantCountUI field (under Player class). The UpdateSeeds method can be called with (_numSeedsLeft, _numSeedsPlanted) because those fields store the number of seeds. Under the PlantCountUI class, under UpdateSeeds, the UI text is updated using if statements that update depending on the seedsLeft and seedsPlanted fields. 



## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites
