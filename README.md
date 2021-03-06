# CRI Summer School 2017
### Summary
* [Presentation](#presentation)
* [Health Game](#health-game)
* [Photos](#photos)

# [Presentation](#summary)
## What is the CRI ?

The Center for Reseach and Interdisciplinarity (CRI : *Centre de Recherches Interdisciplinaire* in Paris) is dedicated to **training through research**, especially in Biology, and alternative ways to learn. Their method is based on  collective intelligence and learning by doing.

More info here : [*CRI Website*](https://cri-paris.org/)

## The Labs Summer School
The CRI Summer School is a **7 week challenge-based program**, hosted by the CRI GameLab and MakerLab.
In it, 50 international students, from a variety of fields, join forces to learn through masterclasses, workshops, hackathons, and by **developing projects tackling the UN’s Sustainable Development Goals** – specifically Health & Environment.

*How?*

By creating games and making devices that benefit from **digital fabrication** *(3D printing, rapid prototyping, etc.)*. Experts in serious game making, medicine, environmental science, digital fabrication, frugal innovation – and more! – mentor groups of students as they hack their way to a better world.

All the projects made by students  were exposed at the **Cite des Sciences et de l'Industrie** in Paris on **August 4th 2017**.

More about the CLaSS 2017 :
* [Projects' Presentation](http://projects.class2017.cri-paris.org/)
* [Twitter](https://twitter.com/SDGCLaSS)
* [Google Drive](https://drive.google.com/drive/folders/0B9utIJzYBJwXcVhMSkEzVTFrb2c)

### Programm
![Timeline](/img/timeline.png)

# [Health Game](#summary)


<p align="center"><br>
<img src="https://github.com/LineChan/CRI_SummerSchool/blob/master/img/team.png"><br>
<i>Our team at the Cite des Sciences et de l'Industrie</i>
</p>


## Context
### Problematic
The **spine** is one of the most used articulation : more than **1500 times a day** ! People from 15 to 45 years old are the most concerned and one in two kids already experienced it. Thus **lower back pain** is the second reason why people consult their general practitioner. It results in a **2.3 million euro bill** to the Medical Benefit Fund. (1)

Back pains mainly come from our **sedentary lifestyle** and its consequences, meaning our partial inactivity. Most of the time no medical care nor further exams are necessary. The best way to prevent back pains or get rid of is to stretch and strengthen it. Therefore **personal habits** have an important role to play in these situations.

As a solution awareness campaigns were launched. Medical books were distributed (*“Osons parler”*) and doctors started to use interpretative guides with their patients. However their **impact is limited** :
* most of the time people don’t feel concerned until they experience back pain
* knowing the right positions isn’t adopting them because training is needed to correct body postures. A study showed that 70% of the patients don’t practice at home exercises given by their practitioner. (2)

We would like our game to tackle down these two problems at the same time. 

### What are the current available solutions ?
We look up at companies on the market and found [Motek Force Link](https://www.motekforcelink.com/products/), a rehabilitation center in Amsterdam specialized in **balance disorder**. With their partnerships dedicated to recovering technologies and virtual reality they have a huge infrastructure with high technologies. [MIRA Rehab](https://www.motekforcelink.com/products/) in London also releases therapeutic games on movement recognitions thanks to a camera. 

Because we wanted to create **something affordable** (with an investement less than 100euros),  we hunt for startups working on back pains with IoT devices. [Thuasne](http://monmaldedos.fr/) and [Koondal](http://koondal.fr/) offer their users to track their activities during the day and thanks to a chatbot or an app their would receive yoga postures according to the data collected and the exercises the users want to practice. We contacted Koondal and met them. They lent us some materials so we can **quickly start to work on our project**.

### Target
Because the major part of the population is concerned we think that a massive target can be reached. Indeed more than **70% of the people play video games**, gender parity is mostly respected and more than one in four players is on smartphone. Most of the people (more than 70%) play for fun and only 10% of them to learn something. (1) This reinforced the idea that we have to make **the educational part as discreet as possible** so we can target a larger public.

<p align="center">
<img src="https://github.com/LineChan/CRI_SummerSchool/blob/master/img/videogamepenetration.png"><br>
<i>Video game penetration and age repartition (%)<br>
How to read : “between October 2012 and March 2013, 86.1% of the French population between 6 and 9 years old played a video game and 26.2% of players are between 35 and 49 years old”*</i><br>
</p>

Because of the technology we use (*mobile application, virtual reality headset*), we reduced our target to **people from 18 to 50 years old**, meaning we aim at groups with more than 60% of players. We also decided to remove younger players because a **smartphone** is required to play the game. Moreover the gameplay is based on **enigma** and puzzles in **virtual reality**  so it might be over complicated for kids or young teens.

##### Sources : 
- (1) : pdf of the INPES about back pain [INPES](http://inpes.santepubliquefrance.fr/70000/dp/05/dp050127.pdf])

- (2) : TED conference on gamification of physical therapy [TED.com](https://www.ted.com/talks/cosmin_mihaiu_physical_therapy_is_boring_play_a_game_instead#t-264985)

## Our project
We wanted to develop an educative game that could prevent people from back pains by encouraging them to **exercise regularly** or by **supervising their rehabilitation**. Indeed doctors would be able to **save the positions their patient have to practice** and have a **feedback** on their performances. Because we wanted users to enjoy the game so they spend a significant time playing, we focused on the entertainment aspect (non repetitive, increasing difficulty, graphics etc). For our project, statistics will be visible on the screen at the end of the demo but the idea is that the doctor would be able to receive the data (via a web interface for instance).

To be sure our game is safe (meaning it doesn't hurt people who already have back problems), we contacted **three differents physcial therapists** and asked them for advices. All of them though it was a good initiative and made observations, but infortunatelly none of them had the time to advice us for the postures. Indeed, in the middle of summer they were all too busy or on vacations before the end of the Summer School.

### Specs
We used **Arduino boards** developed by the CRI called a Movuino. It has an **accelerometer** and an **altimeter**. The board is hung with a belt to mesure the **different positions of the center of gravity**.

The  sensor has to  be placed as vertical as possible on the back. A **smartphone** with the application is needed, and a **virtual reality headset**. Any headset will do the job, but a contextual key is necessary to move and interact with objects. For practical reasons we use Google Cardboards that cost around 10 euros for the cheapest ones. For the game engine we use **Unity** and **Autodesk Maya** for the graphics.

<p align="center"><br>
<img src="https://github.com/LineChan/CRI_SummerSchool/blob/master/img/alternativecontrollers.png"><br>
<i> A Google Carboard, a Movuino and its protective case made with a 3D printer</i><br>
</p>

### Exposition at the Cite des Sciences
During the exposition, the public was able to test our prototype with the virtual reality application and the motion gaming parts. We had a questionnaire to gather feedback for future improvements. People who visited our booth were from different ages and backgrounds so their observations were very diverse too and helped us a lot.

A game designer was really intesrested by our  project because a **physical therapist from the Cochin Hospital** (*in Paris*) recently contacted him to create a **medicinal game** on back pain prevention. We kept his contact in case we need to reach him again.

<p align="center"><br>
<img src="https://github.com/LineChan/CRI_SummerSchool/blob/master/img/francoistaddei.png"><br>
<i>Francois Taddei, the CRI's director testing our game</i>
</p>

### What's next ?
Everything we've done is Open Source and we documented everything so the CRI's can use our project if there is an opportunity. For now, the project is paused because of the end of Summer School.
We think that if a doctor is looking for a game similar to us, it means the project might interest other people and be continued by the next CRI's students.

# [Photos](#photos)

![](/img/.png)
<p align="center"><br>
<img src="https://github.com/LineChan/CRI_SummerSchool/blob/master/img/francoispiuzzi.png"><br>
<img src="https://github.com/LineChan/CRI_SummerSchool/blob/master/img/frugalmedicalhardware.png"><br>
<i>Workshop on making frugal medical hardwares with François Piuzzi </i><br><br>
<img src="https://github.com/LineChan/CRI_SummerSchool/blob/master/img/curtwhite.png"><br>
<i> Hacking wearable devices during a workshop with Curt White </i>
<img src="https://github.com/LineChan/CRI_SummerSchool/blob/master/img/fablab.png"><br>
<i> Messing around in the MakerLab </i>
</p>
