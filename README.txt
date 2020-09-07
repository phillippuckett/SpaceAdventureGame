Basic console-application/adventure-quest built using the .NET framework.

//KEY//

UX/GameFlow = '>'
[x] = GOOD
[ ] = NOT GOOD, **specific action is required**

--------------------------------------------------------------------------------------
//UX/GAMEFLOW//

       [x] TravelTo: Cargo Bay : Introduction > 
               [x] Option Yes = Console stops
               [x] Option No = Back to 'TravelTo'
                   
        [x] Options: Venus, Earth, Lune, Mars, Europa > 
               [x] Option Leave = 'TravelTo'...
               [x] Option Trade = Merchant Transaction > 'TravelTo'
               [ ] Option Lune >
                       Acquired > VictoryScreen > Merchant bidding farewell > CockpitScreen **PATCHED but not fixed entirely; needs to be prettier**
                       Denied > still prints "you have received __" 'TravelTo' **PATCHED, but not fixed entirely; needs to be prettier**
                       
----------------------------------------------------------------------------------------
//OTHER POTENTIAL IMPROVEMENTS//
[ ] Migrate everything from Console-dependent to Console-INDEPENDENT
 
[ ] Get rid of 'static' modifiers
 
[ ] Enum / List statements for the option menu's regarding Planets which SHOULD be objects but aren't - in the ideal sense of the word
 
[ ] Needs mroe dialogue, and a smoother trade interface - currently it's abrupt and ugly
 
[ ] Complicate the economy a little more where different planets require different resources for trade - as opposed to the merchant just giving you stuff
