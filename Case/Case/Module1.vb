Module Module1

    Sub Main()
        Dim num1 As String
        Dim flag As String = "off"
        While flag = "off"
            Console.WriteLine("(1) The GM is Scratch, right?")
            Console.WriteLine("(2) Are they in the same world they were born in or a new world entirely?")
            Console.WriteLine("(3) Are they being teleported to a carbon copy or Crossroads in the middle of nowhere?")
            Console.WriteLine("(4) What do Kasha and Misha have to do with the game? Do they think Caine has anything to do with it?")
            Console.WriteLine("(5) Who is Scratch's favorite player so far?")
            Console.WriteLine("(6) Why did Piers eat Junn's eyes?")
            Console.WriteLine("(7) How does time work outside of the game? Do they have family that's worried sick?")
            Console.WriteLine("(8) Do the Masterminds know about what's going on inside the hotel?")
            Console.WriteLine("(9) Are the hosts of the game both homophobes and child haters?")
            Console.WriteLine("(10) Is the festival actually the Death Game itself?")
            'Console.WriteLine("(11) ")
            Console.WriteLine("Please enter a selection")

            num1 = Console.ReadLine()
            Select Case num1
                Case 1
                    Console.WriteLine("Well, to put it simply, yes.")
                Case 2
                    Console.WriteLine("I will assure you, they are all in Crossroads, Ohio.")
                Case 3
                    Console.WriteLine("Once again, they are all in Crossroads, Ohio.")
                Case 4
                    Console.WriteLine("Mmmm, but what about everyone else? Are you simply assuming that they have something to do with it because of
seemingly suspicious behaviour? Without thinking that maybe everyone has something to do with it somehow? I think there's bigger things you need to focus your attention on.")
                Case 5
                    Console.WriteLine("Well, Scratch really likes Allen. He appears to be the most difficult to break of the group and Scratch is all in for the challenge.")
                Case 6
                    Console.WriteLine("Very soon, you will understand.")
                Case 7
                    Console.WriteLine("That's a complicated question. Truthfully, I can't answer that yet.")
                Case 8
                    Console.WriteLine("Yes, yes they do. At all times, even.")
                Case 9
                    Console.WriteLine("No. No he is not. He's simply finding something he can latch on to and exploit.")
                Case 10
                    Console.WriteLine("To that, I say who knows?")
                Case Else
                    flag = "on"
                    Console.WriteLine("That isn't an option. The program will now close. Please open it again if you have any more questions.")

            End Select
        End While
        Console.ReadLine()

    End Sub

End Module
