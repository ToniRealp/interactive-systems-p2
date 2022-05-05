# Modifications

### Different sheep speeds

To make the game more fun the sheeps are instantiated with random speeds between a defined range.

### Hay machine overclock mode

Basically the hay machine can enter a boost mode where it doubles the speed and fire rate. We can activate this mode 
by holding the shift key. To balance the mechanic it comes together with a resource meter that we will have to manage properly
to keep up with the sheep.

### Lives

I added a live system, every time one of our sheep die we lose one life, it is indicated in the UI by 3 sheep sprites.

### Score

To add a goal to the game I added a score system, each time we hit a sheep a punctuation will be added to our score depending
on the speed of the sheep. The goal of the game is reaching the highest score possible.

### Menu

I added interactivity to the title screen provided, so we can reset and start our game. 

### Scene management

Simple, when we lose all of our lives we get sent to the title screen were we can restart our game.

### Event system

To make all the programming more simple I added an event system that I also used in the previous practice.
Making the code more robust and decoupled. Also it really helps with the pain of dragging multiple gameObjects through the hierarchy.