# XRTS_TEMPLATE
The pre-made starter project for the first Tech Leverage Assignment. It contains a solid framework from which the assignment brief requirements can be fulfilled.

## Rudimentary Level Editor
Objects can be placed by pressing [Left Mouse Button], and can be removed by pressing [Right Mouse Button]. The chosen object to spawn can be changed via the scroll wheel. Three objects are set up for spawning already: a construct (the target our enemies should hunt down), a wall (this should block our enemy), and a test enemy (has some of the aesthetic functionality, and some other helper scripts already embedded).

## Enemy Attacking & Animation
The pre-made enemy prefab has some of the functionality required to deliver an aesthetically appealing and functional foe. It has a basic configuration to handle velocity based running animations (with some assets already integrated), as well as attacking animations. To assist with creating enemy behaviour - a simple script also handles the functionality of attacking and damaging nearby targets, and integrates with the animation system.

## General Core Functionality
There are a variety of scripts on the Managers GameObject that are designed to streamline simple application functionality (reloading and exiting the game). As well there are some simplistic helper scripts that automatically attach new enemies and constructs when they are made so that a single point of reference can be utilised to track in-game instances. 
