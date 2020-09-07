using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class View
    {
        //SPACE//
        public static void TitleScreen()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(@"                                                                                                                       ");
            Console.WriteLine(@"o               .                          .                            .                   .                          ");
            Console.WriteLine(@"                                                                                                                       ");
            Console.WriteLine(@"       .                 .     .         .             . .                                                             ");
            Console.WriteLine(@"                                                                                                                       ");
            Console.WriteLine(@"   .    o                  .                                     .                                                  o  ");
            Console.WriteLine(@"                                                            |                                                          ");
            Console.WriteLine(@"                     .                                    - O -              .                      .                  ");
            Console.WriteLine(@"    |                                            .          |                                                          ");
            Console.WriteLine(@"  - O -       .                      .                                              .                                  ");
            Console.WriteLine(@"    |                       ___   ___ ___ ___  ___ _____   _____   ___ ___ ___  ___ _____          .                   ");
            Console.WriteLine(@"       .                   .| |   | | | | | \  | | |  _|   |  _ \  | | | | | \ .| | |  _|                         .    ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(@"                            | |   | | | | |  \ | | | |_  . | |_| | | | | | |  \ | | | |_                o              ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"   .                        | |   | | | | | |\\| | |  _|   |    /  | | | | | |\\| | |  _|                              ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(@"             .              | |__ | |_| | | | \  | | |_    | |\ \  | |_| | | | \  | | |                                ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(@"                            |____| \___/. |_|  \_| |___|  .|_| |_|  \___/  |_|  \_| |___|   .               .          ");
            Console.WriteLine(@"                         .                                                                                             ");
            Console.WriteLine(@"         .                                                  o     .    o                  .                            ");
            Console.WriteLine(@"                             .                                                                                         ");
            Console.WriteLine(@" .                                                 .                  .                 .     .         .             .");
            Console.WriteLine(@"                                                                                                                       ");
            Console.WriteLine(@"                .                          .                   o               .                          .            ");
            Console.WriteLine(@"                                                                                                                       ");
            Console.WriteLine(@"                                                                                                                       ");
            Console.WriteLine(@"       .                 .       .              .             . .                                o                     ");
        }

        //CARGO BAY//
        public static void CargoBay()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(@"   /___\\\\\\    \ /    /________\                                                   /________\     \ /    //////___\  ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"   .::####::.     |     .::####::.  _______________________________________________  .::####::.      |     .::####::.  ");
            Console.WriteLine(@"  .::::##::::.    |    .::::##:::://               .                               \\.:::##::::.     |    .::::##::::. ");
            Console.WriteLine(@" .::::::::::::.   |   .::::::::::||  .        +             .                 .     ||::::::::::.    |   .::::::::::::.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"..:.:.::::.:.:..  |  ..:.:.::::..||                    .                            ||.:.::::.:.:.   |  ..:.:.::::.:.:.");
            Console.WriteLine(@".....:.::.:...... | .......:..:..||       .                           .             ||..:.::.:.....  | ......:.::.:....");
            Console.WriteLine(@"......:..:........| ........:....||                 .            o       .          ||...:..:....... |........:..:.....");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(@"______ ... ... ...|. ... ... ... ||        .         (#)                            || ... ... ... ..|... .... ________");
            Console.WriteLine(@"      |\. _______ |.. .. .. .. ..||            .                    .          .    ||.. .. .. .. .. .   '    | _______");
            Console.WriteLine(@"      | \|       |\ . . . . . . .|| .       .     .                    _|_          ||. . . . . . . |       | ||'======");
            Console.WriteLine(@"_____ | _|______ | | __. . . . . ||            .               .        |           || . ___________| |     | ||       ");
            Console.WriteLine(@"     |\|        |\ |  _|\__ .  . ||     *                    .   .                  ||  /|          | |     | ||       ");
            Console.WriteLine(@"     | |        | |  |:   :|\     \\_______________________________________________//   || |        | |     | ||       ");
            Console.WriteLine(@"     | |        | |  |:   :||___________________________________________________________|| |        | |     | ||       ");
            Console.WriteLine(@"     | |        | |  |_____|/        -           -           -           -              \|__________| |     | ||       ");
            Console.WriteLine(@"     | |________|/    -                      -                 -                       -            |       | ||' -  _ ");
            Console.WriteLine(@"_____|/                                -                          -                                  '  .     ||.______");
            Console.WriteLine(@"                               _                                     _                                     '  |________");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"                                                                                                                       ");
            Console.WriteLine(@"                 __                                                      __                                            ");
            Console.WriteLine(@"                                                                                                                       ");
            Console.WriteLine(@"                                                                                                                       ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"                                                                                                                       ");
            Console.WriteLine(@"                                                                                  ____                                 ");
            Console.WriteLine(@"                                                                                                                       ");
        }


        //VENUS//
        public static void Venus()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(@"..................................................................::::///////:::..........::::::::::............::::://");
            Console.WriteLine(@".............!.................................................::::///(`  ).///::.....:::::///_////::::::.........::://");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(@"..................../......................................:::::////(     ).///:::...::://.:(`  )`.///:::.........::///");
            Console.WriteLine(@"....:`...................................................:::::::////(       '`.//::://///:(   .    ))//:::.......:::///");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"................./................................::::::::::///.=(`(      .   )//://.--  `.  (    ) )///::......:::////");
            Console.WriteLine(@"........`..,g88R:::::::......................::::::://////  //((    (..__.:'-'///.+(   )   ` _`  ) )//:::........::////");
            Console.WriteLine(@"..........d888(`  ).:::............::::::::::::::///(   `./////`(       ) )///////(   .  )     (   )//:::........::////");
            Console.WriteLine(@".-..--==..q8888    :::::::.....:::::://///////////((    ._              //////////        /        /////:::....::://///");
            Console.WriteLine(@"..........`88(     ).=--::::::::::///.+(`  )`./////:   `.     `(       ) )///////(   .  )///  (   )  ._///::::::://////");
            Console.WriteLine(@")......::::::(       '`.:::::::://  :(   .    )////(     )      ` __.:'   )/////(   (   ))//// `-'.-(`  )////::////////");
            Console.WriteLine(@"....::::.+(`(      .   )///////.--  `.  (    ) )////(  )  )  ( )////// --'///////`- __.' /////// :(      ))////////////");
            Console.WriteLine(@":::::::((    (..__.:'-'/////.=(   )   ` _`  ) )/////   .-'  (_.'//////////.')////////////////////`(    )  ))///////////");
            Console.WriteLine(@"`. ::: `(       ) )/////////(   .  )     (   )///////////////////////////(_  )/////////////////////` __.:'/////////////");
            Console.WriteLine(@" ._               //////////                 ////////////////////////////////////////////////////////////////////////  ");
            Console.WriteLine(@"  )      ` __.:'   )///////(   (   ))     `-'.:(`  )////////////////////////////////////////////////////////      /    ");
            Console.WriteLine(@")  )  ( )       --'/////////`- __.'/////////:(      ))//////////////////////////////////////////////////       /       ");
            Console.WriteLine(@".-'  (_.'          .')//////////////////////`(    )  ))///////////////////////////////////////////  /        /         ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"                  (_  )/////////////////////////` __.:'/////////////////////////////////////////  /         /          ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(@"                 ` `      `-------__------------------------------------------------------__/ /        /               ");
            Console.WriteLine(@"                  .      -   __       ``................................................./   /        :                ");
            Console.WriteLine(@"                   .            `...::''''''':::..............:::::::''''''''''::.....::/   /        /                 ");
            Console.WriteLine(@"               ::::  `-._..,;::::::.;:`--' ,..;`-.--..._____.._.-.''''.: :: ::  `-._.',;:::/      .-/                  ");
            Console.WriteLine(@";:::,.  ,;::::  ::    `-. ,.;::::... .; ,;::::::. ,;:::;.,;:::,.  ,;::::  : :    `-. ,.;::::...:.;:/                   ");
            Console.WriteLine(@" ,.;:::::., .;::. :::: ::. ,;::: ,:::   .;:::::::., ,.;:::,.;:::::.,   .;::. :::: ::. ,;::: ,:::   .;::::'             ");
            Console.WriteLine(@":::::.., .;:::::.,.:; ______.......___ ,.;::::::::; .., .,::::::.., .;:::::.,.:; ______.......___ ,.;::::::::; ..,  .,:");
            Console.WriteLine(@":..___.....-----::::::::::::::::::::::::::::::............____...---......---.---:::::::::::::::::::::::::-.--........'");
            Console.WriteLine(@":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine(@"::::::::'::'::':'':':'''' '''' ''' ''' '' '' ' ' '  '  '  '   '  '  ' ' ' '' '' ''' ''' '''' '''':'':':'::'::':::::::::");
            Console.WriteLine(@"::::':':'''' '''' ''' ''' '' '' ' ' '  '   '                              '   '  ' ' ' '' '' ''' ''' '''' '''':':':::::");
            Console.ForegroundColor = ConsoleColor.White;
        }

        //EARTH//
        public static void Earth()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"                                                                                                                       ");
            Console.WriteLine(@"                                                                                                                       ");
            Console.WriteLine(@"###)_   (##  ##))        _(##  ##)`-_(#)  ( ## )`- _(#))_             (#(## `-__(#)#))_    _((##`-(##)__.-(##`-_      (");
            Console.WriteLine(@"##    )_       ###)      (#(##     ##)  ((###     )    ###` _        (#(#   )#)     ###`-_((###(              ))##)_(( ");
            Console.WriteLine(@"#__________)_____##`-_ _'____________ (###_______________###_`_-_  ((###         #`_-____-(###___________________###_`-");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(@". . .  .  .   .                                                                                        .    .  .  . . .");
            Console.WriteLine(@".. .. .. . . . .  .  .   .                                                                   .   .  .  . . . . .. .. ..");
            Console.WriteLine(@"::.::.::.::.:.:.:.:.:... ... .. .. .. . . . .  .  .   .     .   .  .  . . . . .. .. .. ... ... ...:.:.:.:.:.::.::.::.::");
            Console.WriteLine(@":::::::::::::::.:::.:::.:::.::.::.::.::.:.:.:.:.:... ... . ... ... ...:.:.:.:.:.::.::.::.::.:::.:::.:::.:::::::::::::::");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(@"-----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(@" ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~");
            Console.WriteLine(@"~~ ~~  ~~ ~~  ~~ ~~  ~~ ~~  ~~ ~~  ~~ ~~  ~~ ~~  ~~ ~~  ~~ ~~  ~~ ~~  ~~ ~~  ~~ ~~  ~~ ~~  ~~ ~~  ~~ ~~  ~~ ~~  ~~ ~~  ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"***~  *********~   *********~    ~********~     ~********~     ~********~     ~********~    ~*********   ~********  ~**");
            Console.WriteLine(@"#####~~  ##########~  ~~~~   ~###########~    ~~~~   ~############~    ~~~~   ~###########~   ~~~~  ~##########  ~~####");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@":::::::...........:::::::::::::::::::::.......................::::::::::::::::::::::::::::.......................::::::");
            Console.WriteLine(@"'''':::............................:::'''''''''''''::::....................................:::::'''''''''''''''''''':::");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(@" ,.;::wYwYwYwYwY;::. :::: ::. ,;wYwYwYwYwY::   .;:::::::., ,.;:::wYwYwYwYwY::.,   .;::.wYw:::::. ,;::: ,:wYwYwYw::::::w");
            Console.WriteLine(@"YwYwYwYwYwYwYwYwYwYwYwYwYwYwYwYwYwYwYwYwYwYwYwYwY:::wYwYSwYwYwYwYwYwYwYwYwYwYwYwY:::YwYwYwYw::::wYwYwYwYwYwYwYwYwYwYwYw");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@" ,.;:::::wYwYwYwYwYwYwYwY:: ::. ,;::: wYwYwYwYwY:::::::., ,.;:::,.;:::::., wYwYwYwYwY:::: ::. ,;:wYwYwY::   .;:::::::. ");
            Console.WriteLine(@":::::'       wYwYwYwYwYwY ,;;::::.      wYwYwYwYwYwY ,;;::::. ,wYwYwYwYwYwY::            `'       wYwY;;::::. ,;:::    ");
            Console.WriteLine(@":..___.....-----::::::::::::::::::::::::::::::............____...---......---.---:::::::::::::::::::::::::-.--........'");
            Console.WriteLine(@":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine(@"::::::::'::'::':'':':'''' '''' ''' ''' '' '' ' ' '  '  '  '   '  '  ' ' ' '' '' ''' ''' '''' '''':'':':'::'::':::::::::");
            Console.WriteLine(@"::::':':'''' '''' ''' ''' '' '' ' ' '  '   '                              '   '  ' ' ' '' '' ''' ''' '''' '''':':':::::");
            Console.ForegroundColor = ConsoleColor.White;
        }

        //MUNE//
        public static void Lune()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(@"                                                           _____        ");
            Console.WriteLine(@"                                                       ,-:` (;',`'-,    ");
            Console.WriteLine(@"                                                     .'-;_,;--':-;_,'.  ");
            Console.WriteLine(@"                                                    /;   '/----:;-_`.-` ");
            Console.WriteLine(@"                                                   :-'`.('`-----/` ` \`:");
            Console.WriteLine(@"                                                   :-.--`)`-.---\_   /-:");
            Console.WriteLine(@"                                                   :-----(   `,---\  |':");
            Console.WriteLine(@"                                                    `-----| .'-----`-'/ ");
            Console.WriteLine(@"                                                     `.---|/--------.'  ");
            Console.WriteLine(@"                                                       `'-._____.-      ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(@"            ______.._      _..________    _____                                                                        ");
            Console.WriteLine(@"__.._.-.''''.: ::::  `-._.',;::::::.;:`--' ,..;`-.--..._____.._.-.''''.:  :: ::  `-._.',;::::::.;:`--' ,..;`-.--...___ ");
            Console.WriteLine(@";:::,.  ,;::::  ::    `-. ,.;::::... .; ,;::::::. ,;:::;.,;:::,.  ,;::::   : :    `-. ,.;::::... .; ,;::::::. ,;:::;., ");
            Console.WriteLine(@" ,.;:::::., .;::. :::: ::. ,;::: ,:::   .;:::::::., ,.;:::,.;:::::.,    .;::. :::: ::. ,;::: ,:::   .;:::::::., ,.;::: ");
            Console.WriteLine(@":::::.., .;:::::.,.:; ______.......___ ,.;::::::::; .., .,::::::.., .;:::::.,.:; ______ .......___ ,.;::::::::; .., .,:");
            Console.WriteLine(@":::::'                                     `,;;::::. ,;::: :::::'                                      `,;;::::. ,;::: ");
            Console.WriteLine(@"     ,;:.         .:,                ,.;            ,__,;.      ,;:.         .:,                 ,.;            ,__,;. ");
            Console.WriteLine(@"                        -.                    .- ..                                -.                    .-..          ");
            Console.WriteLine(@"  .-..      ._.         ._.    ,; '       __   `--'          .-..      ._.         ._.    ,; '       __   `--'         ");
            Console.WriteLine(@"  `--'                                                       `--'                                                      ");
            Console.WriteLine(@":..___.....-----::::::::::::::::::::::::::::::............____...---......---.---:::::::::::::::::::::::::-.--........'");
            Console.WriteLine(@":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine(@"::::::::'::'::':'':':'''' '''' ''' ''' '' '' ' ' '  '  '  '   '  '  ' ' ' '' '' ''' ''' '''' '''':'':':'::'::':::::::::");
            Console.WriteLine(@"::::':':'''' '''' ''' ''' '' '' ' ' '  '   '                              '   '  ' ' ' '' '' ''' ''' '''' '''':':':::::");
            Console.ForegroundColor = ConsoleColor.White;
        }

        //MARS//
        public static void Mars()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(@"////::::..................                                                                      ..................::::/");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(@" \////::::::::..........................                                          ...........................:::::::://");
            Console.WriteLine(@"  \///////::::::::::::..................( )..........................................................::::::::::::///'  ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(@"    `//////////:::::::::::::::..........................................___.................:::::::::::::::::////'  '  ");
            Console.WriteLine(@"        ` \///////////::::::::::::::::::::::::::::::::::::::::::::::::.'###`.::::::::::::::::::::::::::::://///   /    ");
            Console.WriteLine(@"            `      `////////:::::::::::::::::::::::::::::::::::::::::: ##### :::::::::::::::::::::::////////'   /      ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"              `        `//////////////////////////////////////////////'.___.'/////////////////////////'  /     /       ");
            Console.WriteLine(@"            `    `       `////////////////////////////////////////////////////////////////////.' .'           '        ");
            Console.WriteLine(@"                 ` `      `-------__........................................................'  /        /              ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(@"                  .      -   __       ``::::::::::::::...............::::::'''''''''''''''/   /        :               ");
            Console.WriteLine(@"                   .            `...::''''''':::...............:::::::''''''''''::.....::/   /        /                ");
            Console.WriteLine(@"               ::::  `-._..,;::::::.;:`--' ,..;`-.--..._____..._.-.''''.: :: ::  `-._.',;:::/      .-/                 ");
            Console.WriteLine(@";:::,.  ,;::::  ::    `-. ,.;::::... .; ,;::::::. ,;:::;..,;:::,.  ,;::::  : :    `-. ,.;::::...:.;:/                  ");
            Console.WriteLine(@" ,.;:::::., .;::. :::: ::. ,;::: ,:::   .;:::::::., ,.;:::,..;:::::.,   .;::. :::: ::. ,;::: ,:::   .;::::'            ");
            Console.WriteLine(@":::::.., .;:::::.,.:; ______.......___ ,.;::::::::; .., .,::::::..., .;:::::.,.:; ______.......___ ,.;::::::::; .., .,:");
            Console.WriteLine(@"                        -.                    .- ..                                   -.                   .-..        ");
            Console.WriteLine(@"  .-..      ._.         ._.    ,; '       __   `--'          .-..      ._.           ._.    ,; '       __   `--'       ");
            Console.WriteLine(@"  `--'                                                       `--'                                                      ");
            Console.WriteLine(@":..___.....-----::::::::::::::::::::::::::::::............____...---......---.---:::::::::::::::::::::::::-.--........'");
            Console.WriteLine(@":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine(@"::::::::'::'::':'':':'''' '''' ''' ''' '' '' ' ' '  '  '  '   '  '  ' ' ' '' '' ''' ''' '''' '''':'':':'::'::':::::::::");
            Console.WriteLine(@"::::':':'''' '''' ''' ''' '' '' ' ' '  '   '                              '   '  ' ' ' '' '' ''' ''' '''' '''':':':::::");
            Console.ForegroundColor = ConsoleColor.White;
        }

        //EUROPA//
        public static void Europa()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(@" - - - = = = = = = = = = = = = = = = = = - - -'                                                                        ");
            Console.WriteLine(@"  .........................................    '                                                  (@)                  ");
            Console.WriteLine(@" = = = = = = = = = = = = = = = = = = = = = - -  '   ..                                                            . ..:");
            Console.WriteLine(@" ######################################====~~~~ :   ..... . .                                               . . .....::");
            Console.WriteLine(@" = = = = = = = = = = = = = = = = = = = = = - -  :   ::..:..:... .. .. .. . . .   .   .   . . . .. .. .. .. ...:..:..:::");
            Console.WriteLine(@" ...........................................    '   :::..:..:.(#)....... .. .. . . . . . .. .. ...........:..:..:::::::");
            Console.WriteLine(@" #####################################====~~~~  .   :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(@"###)_   (##  ##))        _(##  ##)`-_(#)  ( ## )`- _(#))_             (#(## `-__(#)#))_    _((##`-(##)__.-(##`-_      (");
            Console.WriteLine(@"##    )_       ###)      (#(##     ##)  ((###     )    ###` _        (#(#   )#)     ###`-_((###(      #####   ))##)_(( ");
            Console.WriteLine(@"#__________)_____##`-_ _/____________ (###_______________###_`_-_  ((###         #`_-____-(###___________________###_`-");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(@" ~~~##################### .-  `-.#######~~~~  ' .:##;::::::::::::::::::::::::::::::::::::::::::::::::___::::::::::::;##");
            Console.WriteLine(@" ~~~~##################  '       ; ####~~~~  '.:#######;:::::::::::::::::::::::::::::::::::::::::::.'###`.:::::::;#####");
            Console.WriteLine(@"      .................. ` ___  .....      ' .:###################################################:  ###  :############");
            Console.WriteLine(@" - - = = = = = = = = = = = = = = - - - - ' .:######################( )#############################'.___.'#############");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(@"------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(@" ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ----");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ");
            Console.WriteLine(@"~~ ~~  ~~ ~~  ~~ ~~  ~~ ~~  ~~ ~~  ~~ ~~  ~~ ~~  ~~ ~~  ~~ ~~  ~~ ~~  ~~ ~~  ~~ ~~  ~~ ~~  ~~ ~~  ~~ ~~  ~~ ~~  ~~ ~~  ~");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(@"***~  *********~   *********~    ~********~     ~********~     ~********~     ~********~    ~*********   ~********  ~***");
            Console.WriteLine(@"#####~~  ##########~  ~~~~   ~###########~    ~~~~   ~############~    ~~~~   ~###########~   ~~~~  ~##########  ~~#####");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@":..___.....-----::::::::::::::::::::::::::::::............____...---......---.---:::::::::::::::::::::::::-.--.........'");
            Console.WriteLine(@"::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine(@"::::::::'::'::':'':':'''' '''' ''' ''' '' '' ' ' '  '  '  '   '  '  ' ' ' '' '' ''' ''' '''' '''':'':':'::'::'::::::::::");
            Console.WriteLine(@"::::':':'''' '''' ''' ''' '' '' ' ' '  '   '                              '   '  ' ' ' '' '' ''' ''' '''' '''':':'::::::");
        }

        public static void Cockpit()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(@"....................................................|  _______________  |..............................................");
            Console.WriteLine(@"....................................................| |               | |..............................................");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(@"::::::::::::::::::::::::::::::::::::::::::::::::::::| |    |  -  |    | |::::::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine(@" ___________________________________________________| |_______________| |_____________________________________________ ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"/                .                                  |___________________|                      +         .            \");
            Console.WriteLine(@"\        .              .          .                         | |                                         .            /");
            Console.WriteLine(@"_\_______________                                            |[.]         .             .                          . //");
            Console.WriteLine(@"| ______________ |                            .             [:]                                                     //:");
            Console.WriteLine($"|| Fuel        {Resource.Fuel}|      .                                                  .                      .                 /::");
            Console.WriteLine($"|| Water       {Resource.Water}|                              .                                                                  /:::");
            Console.WriteLine($"|| Food        {Resource.Food}|                    .             -         O        .                                  .       /::::");
            Console.WriteLine($"|| Gold        {Resource.Gold}|                                  .                                .                           /:::::");
            Console.WriteLine(@"||______________||         .                                                                                   //::::::");
            Console.WriteLine(@"|________________|                                             .                 .     .                .     //::::::/");
            Console.WriteLine(@" _______________/                        .              .                                                    //::::::/ ");
            Console.WriteLine(@" /_/__  _\__________________                                         .           |              ____________//______/_ ");
            Console.WriteLine(@"|     || _______________  |:|.     *         .       ___________________   .   - o -           |::|  _______________  |");
            Console.WriteLine(@"|     || | PLANETARY    | |:|                       |  _______________  |        |     .       |::| | PART I        | |");
            Console.WriteLine(@"| (#) || | PIRATES      | |:|_______________________| |               | |______________________|::| | THE BECKONING | |");
            Console.WriteLine(@"| (#) || |              | |:|_______________________| |               | |______________________|::| |               | |");
            Console.WriteLine(@"|     || |______________| |:|....................   | |               | |   ...................|::| |_______________| |");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(@"|     ||__________________|_|_______________________| |     | + |     | |______________________|::|    ___________    |");
            Console.WriteLine(@"| (#) |:::::::/  _ (::)  _   _   /|             _   | |               | |   _                /:|::|   |__|__|__|__|   |");
            Console.WriteLine(@"|     |::::::/  //  ||  //  //  / |           (\_/) | |_______________| | (\_/)             /::|::|   |__|__|__|  |   |");
            Console.WriteLine(@"|     |:::::/  //  //  //  //  /  |           |:#:| |___________________| |:#:|            /:::|::|   |__|__|__|__|   |");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(@"| (#) |::::(::)/  /(::)(::)/  /  /            |:#:|     |:::::::::::|     |:#:|             `::|::|   |__|__|__|  |   |");
            Console.WriteLine(@"|     |:::/ ||/  // ||/ ||/  /  /             |:#:|      \........./      |:#:|               `|::|   |_____|__|__|   |");
            Console.WriteLine(@"|_____|__/__________________/  /              \.#'\       \_______/       /'#./                 `.|___________________|");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Merchant()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"                                                        ____                                                           ");
            Console.WriteLine(@"                                                     o=o==)_)_                                                         ");
            Console.WriteLine(@"                            _________________________/._:__:_.\________                                                ");
            Console.WriteLine(@"                        __/____________  /|_CRUISER BOI   _//  ||       ' .                                            ");
            Console.WriteLine(@"                      '--/        /   / /_________________/:__.'.`.________:'_._                                       ");
            Console.WriteLine(@"                     '__/_______ /   /______._____._____________:________________'._                                   ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(@"                     |          |(#)|(_____/     / /(====/ /(==o  | ::::::::::::::: |=o                                ");
            Console.WriteLine(@"                     |__________|(#)|(_____\_____\ \(====\ \(==o  |_:::::::::::::::_|=o                                ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(@"                     ' --\       \   \       \\###\\      \      ||##  /---------/## //                                ");
            Console.WriteLine(@"                      '.__\_______\___\_______\\###\\______\____.:.___/---------/___.'                                 ");
            Console.WriteLine(@"                            './  )_ \          /===//     \  \_______/_________/                                       ");
            Console.WriteLine(@"                             /_ /    \________/===//_______\.--.|________/_.'                                          ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(@"                             //'         \\  /===//         |__|           \\                                          ");
            Console.WriteLine(@"                           ''''          '''/===//           ||            ''''                                        ");
            Console.WriteLine(@"                                           /===//           ''''                     ____                              ");
            Console.WriteLine(@"                                                                                    _|__|_                             ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"                                                                                     (**)                              ");
            Console.WriteLine(@"                                                                                    /[}{])                             ");
            Console.WriteLine(@"                                                                                   | ][][                              ");
        }

        //public static void CruiserBoi()
        //{
        //    Console.ForegroundColor = ConsoleColor.White;
        //    Console.WriteLine(@"                                                        ____                                                           ");
        //    Console.WriteLine(@"                                                     o=o==)_)_                                                         ");
        //    Console.WriteLine(@"                            _________________________/._:__:_.\________                                                ");
        //    Console.WriteLine(@"                        __/____________  /|_CRUISER BOI   _//  ||       ' .                                            ");
        //    Console.WriteLine(@"                      '--/        /   / /_________________/:__.'.`.________:'_._                                       ");
        //    Console.WriteLine(@"                     '__/_______ /   /______._____._____________:________________'._                                   ");
        //    Console.ForegroundColor = ConsoleColor.Gray;
        //    Console.WriteLine(@"                     |          |(#)|(_____/     / /(====/ /(==o  | ::::::::::::::: |=o                                ");
        //    Console.WriteLine(@"                     |__________|(#)|(_____\_____\ \(====\ \(==o  |_:::::::::::::::_|=o                                ");
        //    Console.ForegroundColor = ConsoleColor.DarkGray;
        //    Console.WriteLine(@"                     ' --\       \   \       \\###\\      \      ||##  /---------/## //                                ");
        //    Console.WriteLine(@"                      '.__\_______\___\_______\\###\\______\____.:.___/---------/___.'                                 ");
        //    Console.WriteLine(@"                            './  )_ \          /===//     \  \_______/_________/                                       ");
        //    Console.WriteLine(@"                             /_ /    \________/===//_______\.--.|________/_.'                                          ");
        //    Console.ForegroundColor = ConsoleColor.Gray;
        //    Console.WriteLine(@"                             //'         \\  /===//         |__|           \\                                          ");
        //    Console.WriteLine(@"                           ''''          '''/===//           ||            ''''                                        ");
        //    Console.WriteLine(@"                                           /===//           ''''                                                       ");
        //    Console.ForegroundColor = ConsoleColor.White;
        //}

        public static void PiratesLeaving()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(@"                                                                                                       |               ");
            Console.WriteLine(@" .                .                          .             o              .                   .      - O -             ");
            Console.WriteLine(@"                                                                                                       |               ");
            Console.WriteLine(@"                                                                                                                       ");
            Console.WriteLine(@"    .           .                    _.._        _.--.._                                                               ");
            Console.WriteLine(@"                                .-'```````-.   .' . _.'                                                .               ");
            Console.WriteLine(@"                            .-'----_      ` '--`'. /                                                                   ");
            Console.WriteLine(@"                           ' '---___`````        `.`''                                                                 ");
            Console.WriteLine(@"                           \        `````---.._  //###..                                                               ");
            Console.WriteLine(@"                             `-.-.____._ .     ``\\###:::..                                                            ");
            Console.WriteLine(@"         .                      '--_ /- .-''''--' '. '  ''''                            .                              ");
            Console.WriteLine(@"                                    |` |       '``. |                                                                  ");
            Console.WriteLine(@"                                     `-_-_     .   '.                                                       .          ");
            Console.WriteLine(@"                                                                                                                       ");
            Console.WriteLine(@"                                                                                                                       ");
            Console.WriteLine(@"                                                                                                                       ");
            Console.WriteLine(@"                                 .                   .                                           .                     ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(@"                                                               ... _____________.'''._____                    .        ");
            Console.WriteLine(@"                           .                              ...::##//___/ //_______/_'. _____'._                         ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"                                                .          :::::|___|# (__(__((==((=8:|_______|:8                      ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(@"                                                          '''::##\\__\ |   \__\  \_'.(#/   /(#.'                       ");
            Console.WriteLine(@"                                                               ''' '''-\___________\::____. '                          ");
            Console.WriteLine(@"                                                                                                                       ");
            Console.WriteLine(@"          .                 .     .         .             . .                                o                         ");
            Console.WriteLine(@"                                                                                                                       ");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void PiratesBoarding()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(@"                                                                                                       |               ");
            Console.WriteLine(@" .                .                          .             o              .                   .      - O -             ");
            Console.WriteLine(@"                                                                                                       |               ");
            Console.WriteLine(@"                                                    `. ___                                                             ");
            Console.WriteLine(@"    .           .                             __, ' __`.                _..----....____                                ");
            Console.WriteLine(@"                                 __...--.'``;.   ,.   ;``--..__     .', -._    _.- '                    .              ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(@"                            _..-''------ - '   `'   `'   `'     O ``-''._(,; ') _,'                                    ");
            Console.WriteLine(@"                          ,'________________                          \`-._`-','                                       ");
            Console.WriteLine(@"                           `._              ```````````------...___   '-.._' -:                                        ");
            Console.WriteLine(@"                              ```--.._      ,.   ┌┐ ┌─┐╔╗ ╔═╗╔═╗   ````--...__\-.                                      ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(@"         .                            `.--. `-`  ├┴┐├┤ ╠╩╗║ ║╠═╝ ____ |  |`             .                              ");
            Console.WriteLine(@"                                        `. `.    └─┘└─┘╚═╝╚═╝╩      ,'`````.  ;  ;`                                    ");
            Console.WriteLine(@"                            .             `._`.        __________   `.      \'__/`                          .          ");
            Console.WriteLine(@"                                             `-:._____ / ______ / ___ / ____`.     \  `                                ");
            Console.WriteLine(@"                                                /        |       `._    `.    \                                        ");
            Console.WriteLine(@"                                               /         `._________`-.   `.   `.___                                   ");
            Console.WriteLine(@"                                .             /     .                       `------'`          .                       ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(@"                      ... _____________.'''._/___                    .                                                 ");
            Console.WriteLine(@"                 ...::##//___/ //_______/_'. _____'._                                                    .             ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"       .          :::::|___|# (__(__((==((=8:|_______|:8                                                               ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(@"                 '''::##\\__\ |   \__\  \_'.(#/   /(#.'                                                                ");
            Console.WriteLine(@"                      ''' '''-\___________\::____. '                                     .                             ");
            Console.WriteLine(@"                                                                                                                       ");
            Console.WriteLine(@"          .                 .     .         .             . .                                o                         ");
            Console.WriteLine(@"                                                                                                                       ");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Victory()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(@"                                                                                                       |               ");
            Console.WriteLine(@" .                .                          .             o              .                   .      - O -             ");
            Console.WriteLine(@"                                                                                                       |               ");
            Console.WriteLine(@"                                                                                                                       ");
            Console.WriteLine(@"          .                 .     .         .             . .                                                          ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(@"                                                                                                                       ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"                                   __    __ ___   __     __   ___   ___   __    __       .                     .       ");
            Console.WriteLine(@"                       |           | \  / | | |  / |    / |   | |  / _ \  | \  | |            o        .               ");
            Console.WriteLine(@"    .                - O -         |  \/  | | | / /__  / /__  | | | / \ | |  \ | |                                     ");
            Console.WriteLine(@"                .      |           | |\/| | | | |__  | |__  | | | | | | | | |\\| |       .                             ");
            Console.WriteLine(@"                                   | |  | | | |   / /    / /  | | | \_/ | | | \  |                .                    ");
            Console.WriteLine(@"         .                         |_|  |_| |_|  |_/  . |_/   |_|  \___/  |_|  \_|                           .         ");
            Console.WriteLine(@"                                                                                                                       ");
            Console.WriteLine(@"                 ___     ___  .  ___     ___   __    __ _____   ___    ___    __   ___ ___ _____ _____                 ");
            Console.WriteLine(@"                / _ \   / _ \   / _ \   / _ \  | \  / | |  _ \. | |.   | |   / |   | | | | |  _| |  _ \                ");
            Console.WriteLine(@"               | |_| | | | |_| | | |_| | / \ | |  \/  | | |_| | | |    | |  / /__  | |_| | | |_  | | \ |               ");
            Console.WriteLine(@"               |  _  | | |  _  | |  _  | | | | | |\/| | |  __/  | |    | |  |__  | |  _  | |  _| | | | |               ");
            Console.WriteLine(@"         .     | | | | | |_| | | |_| | | \_/ | | |  | | | |     | |__  | |    / /  | | | | | |_  | |_/ |               ");
            Console.WriteLine(@"   o           |_| |_|  \___/   \___/   \___/  |_|  |_| |_|     |____| |_|   |_/   |_| |_| |___| |____/   .            ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(@"                                                                                                                       ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(@" .                                                                .                 .     .         .              .   ");
            Console.WriteLine(@"                                                                                                                       ");
            Console.WriteLine(@"                                                                                                                       ");
            Console.WriteLine(@"                   .                   .                   o               .                          .                ");
            Console.WriteLine(@"                                                                                                                       ");
            Console.WriteLine(@"          .                 .     .         .             . .                                o                         ");
            Console.WriteLine(@"                                                                                                                       ");
        }

        public static void Over()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(@" .                                                                .                 .     .         .                  ");
            Console.WriteLine(@"                                                                                                                       ");
            Console.WriteLine(@"                                                                                                                       ");
            Console.WriteLine(@"                                                                                                                       ");
            Console.WriteLine(@".                      .                   :                                          .                                ");
            Console.WriteLine(@"                                                                                                                       ");
            Console.WriteLine(@".                                                                                                          |           ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(@".                 .                           .             o              .                   .         - O -         ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(@"                              ___     ___   __    __ _____     ___   ___ ___ _____ _____                   |           ");
            Console.WriteLine(@"       .                   . / _ \   / _ \  | \  / | |  _|    / _ \  | | | | |  _| |  _ \.                             ");
            Console.WriteLine(@"                      |     | | |_| | |_| | |  \/  | | |_    | / \ | | | | | | |_  | |_| |    o        .               ");
            Console.WriteLine(@"   .                - O -   | | ___ |  _  | | |\/| | |  _|   | | | | | \_/ | |  _| |    /                              ");
            Console.WriteLine(@"             .        |     | |_| | | | | | | |  | | | |_    | \_/ |  \   /  | |_  | |\ \                              ");
            Console.WriteLine(@"                             \__,_| |_| |_| |_|  |_| |___|    \___/    \_/   |___| |_| |_|   .                         ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(@"                                                                                                                       ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(@"      .                                                       .                                                        ");
            Console.WriteLine(@"                                                                                                                       ");
            Console.WriteLine(@" .                                                                .                 .     .         .              .   ");
            Console.WriteLine(@"                                                                                                                       ");
            Console.WriteLine(@"                                                                                                                       ");
            Console.WriteLine(@"                  .                    .                   o               .        |                 .                ");
            Console.WriteLine(@"                                                                                  - O -                                ");
            Console.WriteLine(@"                                                                                    |                                  ");
            Console.WriteLine(@"       .                    .     .         .             . .                                o                         ");
            Console.WriteLine(@"                                                                                                                       ");
            Console.WriteLine(@"                                                                                                                       ");
        }
    }

}
