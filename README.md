# Memorun-Game

## Introduction
Suffering from Alzheimer’s, Sam starts to lose his memories of his loved ones. As a floppy disk that stores memories, you are going to retrieve Sam’s memories by collecting items from his past. With a small memo written by Sam’s wife, Nancy, attached to each item, the heartwarming story between Sam and Nancy slowly expands in front of you. Will you be able to find all the lost memories and bring them back to Sam?

## Character Bios
Disky: A pink floppy disk with arms and legs. Body consists of electronic elements, optical devices and magnetics. Clearly something from the 80s but the exterior is still shiny. Disky can not only store data but also human memories, as the game is set in the future where memories can be materialized and saved. He belongs to Sam, an elderly Alzheimer patient. Just like Sam, Disky is a character that belongs to the past and is going to obsolete. In the game, the player will play as Disky and help Sam to collect his lost memories. Disky does not give up on Sam, and helping Sam is a way for him to prove himself useful and resistant. 
Sam: Sam, the elder guy who is diagnosed with Alzheimer. He previously worked as a computer engineer, siting and working in his cubicle for most of his life. He met his lover once on a tram carriage, there was a small crackling flame lit between her and Sam. Getting to know each other, fell in love, and they never lost each other since then; until one day confusion captures Sam, he asked his beloved one, "Who are you?". Now, from sunrise to sunset, Sam is put under care in the nursing house, bearing the suffer of Alzheimer’s. 
Sam only appears in the ending game scene which is not included in the demo version. Players will get to know Sam through the memos attached to each collectable item, written by his wife Nancy. After reading more and more memos, players will slowly reveal a complete story of Sam’s past, his relationship with Nancy, and who he really is as an individual.

## Rough Plot
Original game design involves a series of game scenes where the player/Disky will collect mementos that bear Sam’s lost memories. The current playable game demo includes a game title page, preliminary dialogue, an initial game scene/level - Sam’s garage, and an ending dialogue directing to the next level/game scene.

![Picture2](https://user-images.githubusercontent.com/60665347/136727318-7fbc2449-0e8a-4f61-9f6d-fff28970cda8.png)

Upon entering the game, the player will land at the initial game title scene with a logo indicating ‘Memorun’ in pixel font and a background image showing the portrait of the main player-character - Disky heading to a mysterious entrance leading to an unknown journey. 

After left clicking the ‘START GAME’ button, the player/Disky will start a dialogue with an unknown NPC (the character is designed without a physical appearance, only exists as a mysterious voice) indicated as ??? in the game. ??? will explain the purpose of the journey and lead the player/Disky into the first game level/scene - Sam’s garage. In the garage, the player/Disky will search for 5 items, each attached with a handwritten memo by Sam’s wife Nancy. After successfully collecting all items required, the player will left click on mouse to see an ending dialogue with ??? leading to the next level. 

The complete game will include a destination/final scene of Sam’s nursing house where the player/Disky will hand over the collected memories to their owner. At this point, the game is over, indicating that the player has successfully completed their mission.

## Gameplay Description
Memorun’s gameplay mainly consists of collecting five collectable objects with Sam’s memories. The main character, Disky, can be controlled by players with WASD and Arrow Keys on the keyboard to move the position. To control the viewpoint perspective, players can move the mouse. The game scene uses gravity so that if the player presses the space key, Disky will jump and then land onto the ground. The Rigid Body constrain is applied onto Disky, so that physical contact is simulated between himself and other game objects, such as the wall and ground.

The collecting and inventory system contain four parts, the point and click controlling, the disappear of the collected objects, the appearing of the memos and collected objects on the inventory UI, and the transition to enter the ending scene after all five items are collected. Firstly, there is a C# script applying onto the collectable objects. If the center point targets at the collectable object and player left clicks the mouse, two actions will happen. On one hand, the objects will disappear using a “disabled” function. On the other hand, the objects in the inventory UI are initially displayed as outlines, after clicking on the specific collatable object, the responding object’s outline will be filled. When the shape is filled after the click, a memo written by Nancy will pop up for ten seconds for the players to read it. The inventory system has a calculation function for the total objects collected. The value is initially set to 0, and once an object collected, it will plus one until the value equal to 5 to enter the ending scene. 


## Gameplay Description
Memorun’s gameplay mainly consists of collecting five collectable objects with Sam’s memories. The main character, Disky, can be controlled by players with WASD and Arrow Keys on the keyboard to move the position. To control the viewpoint perspective, players can move the mouse. The game scene uses gravity so that if the player presses the space key, Disky will jump and then land onto the ground. The Rigid Body constrain is applied onto Disky, so that physical contact is simulated between himself and other game objects, such as the wall and ground.

The collecting and inventory system contain four parts, the point and click controlling, the disappear of the collected objects, the appearing of the memos and collected objects on the inventory UI, and the transition to enter the ending scene after all five items are collected. Firstly, there is a C# script applying onto the collectable objects. If the center point targets at the collectable object and player left clicks the mouse, two actions will happen. On one hand, the objects will disappear using a “disabled” function. On the other hand, the objects in the inventory UI are initially displayed as outlines, after clicking on the specific collatable object, the responding object’s outline will be filled. When the shape is filled after the click, a memo written by Nancy will pop up for ten seconds for the players to read it. The inventory system has a calculation function for the total objects collected. The value is initially set to 0, and once an object collected, it will plus one until the value equal to 5 to enter the ending scene. 





## Contributors
Jie Guan, Grace Yuan, Renee Ge, Wei Zhang, Nuo Chen

## Reference
https://craftgames.co/unity-3d-fps-movement/
