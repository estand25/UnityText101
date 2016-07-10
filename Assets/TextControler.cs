using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextControler : MonoBehaviour {
	// Text on the gamee screen
	public Text text;
	
	// Consistent for the individual game states
	private enum States {cell,swimInpool,bed_of_leaves,dark_hole,main_cave,left_cave,near_fish,block_cave,freedom};
	
	// The players current State
	private States myState;
	
	
	// Use this for initialization
	void Start () {
	
		// Setting the initial Game state (Start Game)
		myState = States.cell;
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		
		// If..Else statement the handes the route of the text
		if(myState == States.cell){cell();}
		else if (myState == States.swimInpool){swim_pool();}
		else if (myState == States.bed_of_leaves){bedOfLeaves();}
		else if (myState == States.dark_hole){darkHole();}
		else if (myState == States.main_cave){mainCave();}
		else if (myState == States.left_cave){leftCave();}
		else if (myState == States.near_fish){nearFish();}
		else if (myState == States.block_cave){blockCave();}
		else if (myState == States.freedom){freedom();}
	}
	
	// Method that handles the Cell state
	void cell(){
		// Text read-out for this state
		text.text = "The last thing I remember was crashing on a green-blue world similar to earth. "+
			    "I was in a circular square cell made of green plants I think. In the right-hand corner, "+
				"there are giant leaves I am assuming is my bed. On the other side is a pool of water next "+
			    "to greenie fruit plant that I am assuming is my food and water supply. "+
			    "I was in the center of the cell and finally noticed the dark hole in the bottom of the cell.\n\n"+
				"Press P to swim in the Pool, B to view the Bed, H to jump in the dark Hole";
		
		//If..else statement that handle changeing the 
		// state per player selection
		if(Input.GetKeyDown(KeyCode.P)){myState = States.swimInpool;}
		else if(Input.GetKeyDown(KeyCode.B)){myState = States.bed_of_leaves;}
		else if(Input.GetKeyDown(KeyCode.H)){myState = States.dark_hole;}				
	}
	
	// Method that handles the Swin Pool state
	void swim_pool(){
		text.text = "The water feels great, and I love being clean. I decide to go a little bit deeper into the pool. "+
			    "I am a couple of feet underwater when I notice a little tunnel that appears to lead to a giant cave.\n\n"+
				"Press C to go into the Cave, G to return to the center of the Green cell";
		
		//If..else statement that handle changeing the 
		// state per player selection
		if(Input.GetKeyDown(KeyCode.C)){myState = States.main_cave;}
		else if(Input.GetKeyDown(KeyCode.G)){myState = States.cell;}
	}
	
	//Method that handle the Bed of Leaves stats
	void bedOfLeaves(){
		text.text = "I have seen movies about silver back gorillas and they had beds just like this. "+
			    "For the first time since waking-up, I started thinking about how I got into this cell and where was my crew.\n\n"+
				"Press G to return to the center of the Green cell";
		
		//If..else statement that handle changeing the 
		// state per player selection
		if(Input.GetKeyDown(KeyCode.G)){myState = States.cell;}
	}
	
	//Method that handle the dark hole state
	void darkHole(){
		text.text = "I jumped into the dark hole and that was it.\n\n"+
			    "Your died.... Press P to Play Game";
		
		//If..else statement that handle changeing the 
		// state per player selection
		if(Input.GetKeyDown(KeyCode.P)){myState = States.cell;}
	}
	
	//Method that handle the Main Cave state
	void mainCave(){
		text.text = "I swam through the tunnel that connected my little pool with what appears to be a much larger underground river. "+
		        "I notice an assortment of different plants and fish life. I also notice two other caves. One to the right that appears blocked, "+
				"but with a little bit of time could be opened. Another cave on the left and a couple of very unusual fish at the bottom of the river.\n\n"+
				"Press P to swim back into the Pool, R to unblock and swim into the Right cave, L to go into the Left Cave, and F to look at the unusual Fish";
		
		//If..else statement that handle changeing the 
		// state per player selection
		if(Input.GetKeyDown(KeyCode.P)){myState = States.swimInpool;}
		else if(Input.GetKeyDown(KeyCode.R)){myState = States.block_cave;}
		else if(Input.GetKeyDown(KeyCode.L)){myState = States.left_cave;}
		else if(Input.GetKeyDown(KeyCode.F)){myState = States.near_fish;}
	}
	
	//Method that handle the Left Cave state
	void leftCave(){
		text.text = "I swim into the Left most cave and find a little air pocket at the top. I swim up to the air pocket and look around. "+
			    "There is nothing, but underwater plants and me.\n\n"+
				"Press C to return to the main Cave";
		
		//If..else statement that handle changeing the 
		// state per player selection
		if(Input.GetKeyDown(KeyCode.C)){myState = States.main_cave;}
	}
	
	//Method that handle the Near Fish state
	void nearFish(){
		text.text = "I’m not sure why I had the need to swim near these fish, but something about them reminds me of a fish from earth. "+
			    "It is not until I am 5 feet away from the fish that I know why they look so familiar. Sharks have not changed on earth for millions of years. "+
			    "No point changing if you are already at the top of the food chain. One of the giant sharks move to me and takes a bite. "+
				"I do not remember anything after that.\n\n"+
				"Your died.... Press P to Play Game";
		
		//If..else statement that handle changeing the 
		// state per player selection
		if(Input.GetKeyDown(KeyCode.P)){myState = States.cell;}
	}
	
	//Method that handle the Block Cave state
	void blockCave(){
		text.text = "I swam up to the right cave and started moving rocks. It only took me a couple of minutes and I went through to the cave entrance. "+
			    "I swam through to find another tunnel but at the top of this one, I could see the light. I do not know what is at the top waiting for me, "+
			    "but better off trying than sitting and waiting.\n\n"+
				"Press F to get out of the water and good to Freedom or C to return to the main Cave";
		
		//If..else statement that handle changeing the 
		// state per player selection
		if(Input.GetKeyDown(KeyCode.F)){myState = States.freedom;}
		else if(Input.GetKeyDown(KeyCode.C)){myState = States.main_cave;}
	}
	
	//Method that handle the Freedom state
	void freedom(){
		text.text = "I move out of the water and look around. What I see surprises me. I was standing on the bank of a river inside of a jungle, "+
			    "with trees so big I couldn’t see the sun. Next to one of the trees I saw my first alien and to my surprise he looked a lot like me "+
			    "except for the extra hair, but next to him is one of my crewmates. On seeing me the crewmen winks and calls me over. "+
			    "At least I know I am not alone.\n\n"+
				"You are free from the cell and with friend; maybe... \n\n"+
				"Press P to Play Game";
		
		//If..else statement that handle changeing the 
		// state per player selection
		if(Input.GetKeyDown(KeyCode.P)){myState = States.cell;}
	}
}
