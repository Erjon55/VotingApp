Voting’s Application
-This application is created to help administrators put voting’s info for a State with its voting units and parties. It calculates overall votes etc.

1.	We have the first form that shows up when we open the application and it has these methods:
•	Add info for the voting that further opens a new form (2);
•	It can be saved and opened with the options from the Menu or from Toolstrip;
•	(further explanation below)

![image](https://user-images.githubusercontent.com/78550877/177059467-7db80a4a-adb7-4037-afd9-6eab544d7fa0.png)



2.	Next it is required to select a Voting Unit from the combobox and click add



![image](https://user-images.githubusercontent.com/78550877/177059473-063b8407-bf06-4167-b09d-d9a87d1dded9.png)



3.	After clicking add this form shows up in which we have to provide info about the Party name and how many votes that part has in Unit 1 of the 6 Units. After that we can see which voting unit it is, the number of parties it has, and also we can add new votes to an existing party (if the party is already on the list it will update only the number of votes).



![image](https://user-images.githubusercontent.com/78550877/177059480-a9649a00-1aa6-4449-973a-6da8f9f52b45.png)







Then the info we provided will be taken to the other form (2) and there we can see how the whole form looks.


![image](https://user-images.githubusercontent.com/78550877/177059484-5d3229b1-d3a1-4b28-b824-399cfc8161ea.png)











Here we can see how it should look after all the information is fulfilled, we also can see the overall number of parties that participated in this voting session.

This information will go to the first form (1) and it will look something like this : 



![image](https://user-images.githubusercontent.com/78550877/177059486-08644419-7d9d-4726-a6b5-941a447428a2.png)









The listbox on the right shows us the overall number of parties and their overall individual votes. The listbox on the left uses D’Hondt algorithm and shows which party gets how many ministers (from 120 available).

D’Hondt method takes the number of chairs for ministers, the number of parites and also an array of the total Parties involved in the voting string[] party with another array double[] votes which stores the votings of the same party at the same index (like a Map style). From this information we build the D’Hont table





for (int m = 0; m < chairs; m++)


            {
            
                for (int n = 0; n < party.Length; n++)
                
                {
                
                    if (m == 0)
                    
                        dhondtTable[m, n] = votes[n];
                        
                    else
                    
                        dhondtTable[m, n] = dhondtTable[0, n] / (m + 1);
                        
                }
                
            }
            
            
(Better using code than explaining half a page how a loop works)
After this we get the element with maximum value from the table and store it to an array of numbers(long as the number of the parties) and delete the maximum element from the table initializing it to 0.0, so that we can find the next maximum element and put in the array. (this step is completed by using the separate method 
public static int getMaxElement(double[,] dTable, int pN, int pM)
After we find the number of chairs each part will have we add them to a listbox as pairs: 
Party x gets y Ministers, where x is a member of the array party and y is a member of the last array we created.

The main functionalities of this project are finished and ready to use, it has room for more development and adaptation depending on what kind of voting takes place. 
(This is version 1.0, in version 2.0 there will be included some progress bars, chars drawings etc). 
