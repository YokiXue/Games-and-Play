public static class StoryFiller
{
    public static StoryNode FillStory()
    {
        var root = CreateNode(
            "Welcome to Purr-fect Journey! You are a curious and adventurous cat, living on the highline at NYUAD campus. One day, you decide to explore beyond your usual haunts and set out on a journey. Where will you go?",
            new[] {
            "Follow the scent of fresh tuna to D2",
            "Venture into the depths of the library in search of ancient cat lore"
            });

        var node1 = CreateNode(
            "The aroma of delicious food filled your nostrils, and you couldn't resist the temptation to sneak in and steal a bite. However, as you approached the food counter, you noticed a group of hoomans guarding the area. You had to come up with a plan.",
            new[] {
              "Use your charm to distract the humans",
              "Sneak around the humans to the tuna",
              "Ask a student to help you",
              "Go to the library instead"});


        var node2 = CreateNode(
            "You let out a soft meow and started rubbing your head against one of the hoomans' legs. They were delighted by your friendliness and started petting you. One of them picked you up and pet you. This plan failed",
            new[] {
            "Other plans",
            "Take a nap in the sun"});

        var node3 = CreateNode(
           "It's so nice to have a nap in the sun, but you are starving after waking up.",
           new[] {
            "Tuna plans again"});

        var node4 = CreateNode(
           "Silly hoomans, no one seemed to understand what your meows meant",
           new[] {
            "Other plans"});

        var node5 = CreateNode(
           "You tried to sneak past the hoomans, but they noticed you and shooed you away. You decided to hide for a while and wait for another chance",
           new[] {
            "Hide and Wait"});

        var node6 = CreateNode(
            "It seemed that more and more hoomans coming to guard their food",
            new[] {
            "Keep waiting",
            "Other plans"});

        var node6Bis = CreateNode(
           "After taking a nap, you found yourself having a great rest and running faster to sneak around the hoomans",
           new[] {
            "Wait for the best chance",
            "Let's do it now",
            "Give up"});

        var node7 = CreateNode(
          "Even more students came to D2 to eat",
          new[] {
            "Give up this plan"});

        var node8 = CreateNode(
           "You eventually made your way to the tuna. However, as you were about to take a bite, the hooman caught up to you and scooped you up.",
           new[] {
            "...Let's go to the library instead"});

        var node9 = CreateNode(
          "As you made your way through the library, you stumbled upon an ancient manuscript. It was written in a language that you couldn't understand, but you knew it contained valuable cat knowledge. You had to find a way to decipher it.",
          new[] {
            "Ask another cat",
            "Scratch at the manuscript",
            "Ask a librarian"});

        
        var node10 = CreateNode(
          "Other cats are too busy with meowing at hoomans",
          new[] {
            "Go to D2 instead"});

        var node11 = CreateNode(
         "The librarian did not understand your meows. She reported to the public safety to take your out of library",
         new[] {
            "Go to D2 instead"});

        var node12 = CreateNode(
          "Looks like there is nothing. You are hesitating whether to continue",
          new[] {
            "Continue scratching at the manuscript",
            "Go to D2 instead"});

        var node13 = CreateNode(
          "You finally reveal the biggest secret of this school： CAMPUS CATS RULE NYUAD",
          new[] {
            "Finish the journey"});

        root.NextNode[0] = node1;
        root.NextNode[1] = node9;

        node1.NextNode[0] = node2;
        node1.NextNode[1] = node5;
        node1.NextNode[2] = node4;
        node1.NextNode[3] = node9;

        node2.NextNode[0] = node1;
        node2.NextNode[1] = node3;

        node3.NextNode[0] = node1;
        node3.OnNodeVisited = () =>
        {
            node5.NextNode[0] = node6Bis;
        };

        node4.NextNode[0] = node1;

        node5.NextNode[0] = node6;

        node6.NextNode[0] = node7;
        node6.NextNode[1] = node1;

        node6Bis.NextNode[0] = node7;
        node6Bis.NextNode[1] = node8;
        node6Bis.NextNode[2] = node1;

        node7.NextNode[0] = node1;

        node8.NextNode[0] = node9;
      
        node9.NextNode[2] = node11;
        node9.NextNode[1] = node12;

        node9.NextNode[0] = node10;

        node10.NextNode[0] = node1;


        node11.NextNode[0] = node1;
        

        node12.NextNode[1] = node1;
        node12.NextNode[0] = node13;

        node13.IsFinal = true;

        return root;
    }

    private static StoryNode CreateNode(string history, string[] options)
    {
        var node = new StoryNode
        {
            History = history,
            Answers = options,
            NextNode = new StoryNode[options.Length]
        };
        return node;
    }
}
