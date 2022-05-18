//A series open book exam
//Multichoice questions
#include <cstdio>
#include <string>
#include <cstdlib>
#include <iostream>
#include <windows.h>
#include <manipulations.h>
#include <iomanip>
#include <fstream>
#include "html1.h"


//#define
using namespace std;
// A N S W E R S
#include "category.h"
#include "AgricultureGrade5Test1.h"
#include "scienceGrade3Paper2.h"
#include "validateInputAnswers.h"
#include "answersDefinition.h"


#define IGNORE_MAX 256




//Q U E S T I O N S
char charQuestion1;
char charQuestion2;
char charQuestion3;
char charQuestion4;
char charQuestion5;
char charQuestion6;
char charQuestion7;
char charQuestion8;
char charQuestion9;
char charQuestion10;
char charQuestion11;
char charQuestion12;
char charQuestion13;
char charQuestion14;
char charQuestion15;
char charQuestion16;
char charQuestion17;
char charQuestion18;
char charQuestion19;
char charQuestion20;
char charQuestion21;
char charQuestion22;
char charQuestion23;
char charQuestion24;
char charQuestion25;
char charQuestion26;
char charQuestion27;
char charQuestion28;
char charQuestion29;
char charQuestion30;
char charQuestion31;
char charQuestion32;
char charQuestion33;
char charQuestion34;
char charQuestion35;
char charQuestion36;
char charQuestion37;
char charQuestion38;
char charQuestion39;
char charQuestion40;
char charQuestion41;
char charQuestion42;
char charQuestion43;
char charQuestion44;
char charQuestion45;
char charQuestion46;
char charQuestion47;
char charQuestion48;
char charQuestion49;
char charQuestion50;




int answer;
char option;
char yesNo;

string userName;
string surname;


int count = 0;
int Total50 = 50;
int Total40 = 40;
int Total30 = 30;
int Total25 = 25;
int Total20 = 20;
int Total15 = 15;
int Total10 = 10;
int Total5 = 5;


ofstream my("Answers.txt");

void identifyYourself(void)
{
    cout << "\n\tEnter your name : \n" << endl;
    cout << "\t";
    getline(cin,userName);

    cout << "\n\tEnter your surname : \n" << endl;
    cout << "\t";
    getline(cin,surname);
    cout << "\n\n";
}


void validateAnswers1(void)
{
    /**VALIDATE QUESTION ONE**/


if(charQuestion1 > 64 && charQuestion1 <70 || charQuestion1 > 96 && charQuestion1 <102 )
{

}


else

{
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t";  cout << "L A S T   W A R N I N G" << endl;
    cout << "" << endl;
    cout << "" << endl;
    MessageBox(NULL," Answer with A, B, C, D, E","  ERROR ^_^",MB_OK | MB_ICONWARNING);
    cout << "\t"; cout << "Re enter answer for question 1." << " Answer " << charQuestion1 << " not in range." << " Answer with A, B, C, D, E"<< endl;
    cout << "" << endl;
    cout << "" << endl;
    cout << "   "; cin >> setw(1) >> charQuestion1;
    my << charQuestion1 << endl;
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');

cout << "" << endl;
cout << "" << endl;
}



}


void validateAnswers2(void)
{


    /**VALIDATE QUESTION TWO**/
 if(charQuestion2 > 64 && charQuestion2 <70 || charQuestion2 > 96 && charQuestion2 <102 )

{

}
else

{
    cout << "" << endl;
    cout << "" << endl;

    cout << "\t";  cout << "L A S T   W A R N I N G" << endl;
    cout << "" << endl;
    cout << "" << endl;
   MessageBox(NULL," Answer with A, B, C, D, E","  ERROR ^_^",MB_OK | MB_ICONWARNING);
   cout << "\t"; cout << "Re enter answer for question 2." << " Answer " << charQuestion2 << " not in range." << " Answer with A, B, C, D, E"<< endl;
   cout << "" << endl;
   cout << "" << endl;
   cout << "\t"; cin >> setw(1) >> charQuestion2;
   my << charQuestion2 << endl;
   cin.clear();
   cin.ignore(IGNORE_MAX,'\n');
   cout << "" << endl;
   cout << "" << endl;
}


}


void validateAnswers3(void)
{


    /**VALIDATE QUESTION THREE**/
 if(charQuestion3 > 64 && charQuestion3 <70 || charQuestion3 > 96 && charQuestion3 <102 )

{

}
else

{
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t";  cout << "L A S T   W A R N I N G" << endl;
    cout << "" << endl;
    cout << "" << endl;
    MessageBox(NULL," Answer with A, B, C, D, E","  ERROR ^_^",MB_OK | MB_ICONWARNING);
    cout << "\t"; cout << "Re enter answer for question 3." << " Answer " << charQuestion3 << " not in range." << " Answer with A, B, C, D, E"<< endl;
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t"; cin >> setw(1) >> charQuestion3;
    my << charQuestion3 << endl;
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;
}


}


void validateAnswers4(void)
{
    /**VALIDATE QUESTION SIX**/


if(charQuestion4 > 64 && charQuestion4 <70 || charQuestion4 > 96 && charQuestion4 <102 )
{

}


else

{
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t";  cout << "L A S T   W A R N I N G" << endl;
    cout << "" << endl;
    cout << "" << endl;
    MessageBox(NULL," Answer with A, B, C, D, E","  ERROR ^_^",MB_OK | MB_ICONWARNING);
    cout << "\t"; cout << "Re enter answer for question 4." << " Answer " << charQuestion4 << " not in range." << " Answer with A, B, C, D, E"<< endl;
    cout << "" << endl;
    cout << "" << endl;
    cout << "   "; cin >> setw(1) >> charQuestion4;
    my << charQuestion4 << endl;
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;
}



}


void validateAnswers5(void)
{


    /**VALIDATE QUESTION TWO**/
 if(charQuestion5 > 64 && charQuestion5 <70 || charQuestion5 > 96 && charQuestion5 <102 )

{

}
else

{
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t";  cout << "L A S T   W A R N I N G" << endl;
    cout << "" << endl;
    cout << "" << endl;
    MessageBox(NULL," Answer with A, B, C, D, E","  ERROR ^_^",MB_OK | MB_ICONWARNING);
    cout << "\t"; cout << "Re enter answer for question 5." << " Answer " << charQuestion5 << " not in range." << " Answer with A, B, C, D, E"<< endl;
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t"; cin >> setw(1) >> charQuestion5;
    my << charQuestion5 << endl;
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;
}


}




void validateAnswers6(void)
{
    /**VALIDATE QUESTION SIX**/


if(charQuestion6 > 64 && charQuestion6 <70 || charQuestion6 > 96 && charQuestion6 <102 )
{

}


else

{
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t";  cout << "L A S T   W A R N I N G" << endl;
    cout << "" << endl;
    cout << "" << endl;
    MessageBox(NULL," Answer with A, B, C, D, E","  ERROR ^_^",MB_OK | MB_ICONWARNING);
    cout << "\t"; cout << "Re enter answer for question 6." << " Answer " << charQuestion6 << " not in range." << " Answer with A, B, C, D, E"<< endl;
    cout << "" << endl;
    cout << "" << endl;
    cout << "   "; cin >> setw(1) >> charQuestion6;
    my << charQuestion6 << endl;
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;
}



}


void validateAnswers7(void)
{


    /**VALIDATE QUESTION TWO**/
 if(charQuestion7 > 64 && charQuestion7 <70 || charQuestion7 > 96 && charQuestion7 <102 )

{

}
else

{
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t";  cout << "L A S T   W A R N I N G" << endl;
    cout << "" << endl;
    cout << "" << endl;
    MessageBox(NULL," Answer with A, B, C, D, E","  ERROR ^_^",MB_OK | MB_ICONWARNING);
    cout << "\t"; cout << "Re enter answer for question 7." << " Answer " << charQuestion7 << " not in range." << " Answer with A, B, C, D, E"<< endl;
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t"; cin >> setw(1) >> charQuestion7;
    my << charQuestion7 << endl;
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;
}


}


void validateAnswers8(void)
{


    /**VALIDATE QUESTION THREE**/
 if(charQuestion8 > 64 && charQuestion8 <70 || charQuestion8 > 96 && charQuestion8 <102 )

{

}
else

{
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t";  cout << "L A S T   W A R N I N G" << endl;
    cout << "" << endl;
    cout << "" << endl;
    MessageBox(NULL," Answer with A, B, C, D, E","  ERROR ^_^",MB_OK | MB_ICONWARNING);
    cout << "\t"; cout << "Re enter answer for question 8." << " Answer " << charQuestion8 << " not in range." << " Answer with A, B, C, D, E"<< endl;
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t"; cin >> setw(1) >> charQuestion8;
    my << charQuestion8 << endl;
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;
}


}



void validateAnswers9(void)
{


    /**VALIDATE QUESTION FOUR**/
 if(charQuestion9 > 64 && charQuestion9 <70 || charQuestion9 > 96 && charQuestion9 <102 )

{

}
else

{
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t";  cout << "L A S T   W A R N I N G" << endl;
    cout << "" << endl;
    cout << "" << endl;
    MessageBox(NULL," Answer with A, B, C, D, E","  ERROR ^_^",MB_OK | MB_ICONWARNING);
    cout << "\t"; cout << "Re enter answer for question 9." << " Answer " << charQuestion9 << " not in range." << " Answer with A, B, C, D, E"<< endl;
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t"; cin >> setw(1) >> charQuestion9;
    my << charQuestion9 << endl;
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;
}


}


void validateAnswers10(void)
{


    /**VALIDATE QUESTION FIVE**/
 if(charQuestion10 > 64 && charQuestion10 <70 || charQuestion10 > 96 && charQuestion10 <102 )

{

}
else

{
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t";  cout << "L A S T   W A R N I N G" << endl;
    cout << "" << endl;
    cout << "" << endl;
    MessageBox(NULL," Answer with A, B, C, D, E","  ERROR ^_^",MB_OK | MB_ICONWARNING);
    cout << "\t"; cout << "Re enter answer for question 10." << " Answer " << charQuestion10 << " not in range." << " Answer with A, B, C, D, E"<< endl;
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t"; cin >> setw(1) >> charQuestion10;
    my << charQuestion10 << endl;
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;
}


}


void validateAnswers11(void)
{
    /**VALIDATE QUESTION ONE**/


if(charQuestion11 > 64 && charQuestion11 <70 || charQuestion11 > 96 && charQuestion11 <102 )
{

}


else

{
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t";  cout << "L A S T   W A R N I N G" << endl;
    cout << "" << endl;
    cout << "" << endl;
    MessageBox(NULL," Answer with A, B, C, D, E","  ERROR ^_^",MB_OK | MB_ICONWARNING);
    cout << "\t"; cout << "Re enter answer for question 11." << " Answer " << charQuestion11 << " not in range." << " Answer with A, B, C, D, E"<< endl;
    cout << "" << endl;
    cout << "" << endl;
    cout << "   "; cin >> setw(1) >> charQuestion11;
    my << charQuestion11 << endl;
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;
}



}


void validateAnswers12(void)
{


    /**VALIDATE QUESTION TWO**/
 if(charQuestion12 > 64 && charQuestion12 <70 || charQuestion12 > 96 && charQuestion12 <102 )

{

}
else

{
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t";  cout << "L A S T   W A R N I N G" << endl;
    cout << "" << endl;
    cout << "" << endl;
    MessageBox(NULL," Answer with A, B, C, D, E","  ERROR ^_^",MB_OK | MB_ICONWARNING);
    cout << "\t"; cout << "Re enter answer for question 12." << " Answer " << charQuestion12 << " not in range." << " Answer with A, B, C, D, E"<< endl;
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t"; cin >> setw(1) >> charQuestion12;
    my << charQuestion12 << endl;
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;
}


}


void validateAnswers13(void)
{


    /**VALIDATE QUESTION THREE**/
 if(charQuestion13 > 64 && charQuestion13 <70 || charQuestion13 > 96 && charQuestion13 <102 )

{

}
else

{
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t";  cout << "L A S T   W A R N I N G" << endl;
    cout << "" << endl;
    cout << "" << endl;
    MessageBox(NULL," Answer with A, B, C, D, E","  ERROR ^_^",MB_OK | MB_ICONWARNING);
    cout << "\t"; cout << "Re enter answer for question 13." << " Answer " << charQuestion13 << " not in range." << " Answer with A, B, C, D, E"<< endl;
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t"; cin >> setw(1) >> charQuestion13;
    my << charQuestion13 << endl;
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;
}


}


void validateAnswers14(void)
{
    /**VALIDATE QUESTION SIX**/


if(charQuestion14 > 64 && charQuestion14 <70 || charQuestion14 > 96 && charQuestion14 <102 )
{

}


else

{
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t";  cout << "L A S T   W A R N I N G" << endl;
    cout << "" << endl;
    cout << "" << endl;
    MessageBox(NULL," Answer with A, B, C, D, E","  ERROR ^_^",MB_OK | MB_ICONWARNING);
    cout << "\t"; cout << "Re enter answer for question 14." << " Answer " << charQuestion14 << " not in range." << " Answer with A, B, C, D, E"<< endl;
    cout << "" << endl;
    cout << "" << endl;
    cout << "   "; cin >> setw(1) >> charQuestion14;
    my << charQuestion14 << endl;
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;
}



}


void validateAnswers15(void)
{


    /**VALIDATE QUESTION TWO**/
 if(charQuestion15 > 64 && charQuestion15 <70 || charQuestion15 > 96 && charQuestion15 <102 )

{

}
else

{
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t";  cout << "L A S T   W A R N I N G" << endl;
    cout << "" << endl;
    cout << "" << endl;
    MessageBox(NULL," Answer with A, B, C, D, E","  ERROR ^_^",MB_OK | MB_ICONWARNING);
    cout << "\t"; cout << "Re enter answer for question 15." << " Answer " << charQuestion15 << " not in range." << " Answer with A, B, C, D, E"<< endl;
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t"; cin >> setw(1) >> charQuestion15;
    my << charQuestion15 << endl;
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;
}


}




void validateAnswers16(void)
{
    /**VALIDATE QUESTION SIX**/


if(charQuestion16 > 64 && charQuestion16 <70 || charQuestion16 > 96 && charQuestion16 <102 )
{

}


else

{
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t";  cout << "L A S T   W A R N I N G" << endl;
    cout << "" << endl;
    cout << "" << endl;
    MessageBox(NULL," Answer with A, B, C, D, E","  ERROR ^_^",MB_OK | MB_ICONWARNING);
    cout << "\t"; cout << "Re enter answer for question 16." << " Answer " << charQuestion16 << " not in range." << " Answer with A, B, C, D, E"<< endl;
    cout << "" << endl;
    cout << "" << endl;
    cout << "   "; cin >> setw(1) >> charQuestion16;
    my << charQuestion16 << endl;
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;
}



}


void validateAnswers17(void)
{


    /**VALIDATE QUESTION TWO**/
 if(charQuestion17 > 64 && charQuestion17 <70 || charQuestion17 > 96 && charQuestion17 <102 )

{

}
else

{
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t";  cout << "L A S T   W A R N I N G" << endl;
    cout << "" << endl;
    cout << "" << endl;
    MessageBox(NULL," Answer with A, B, C, D, E","  ERROR ^_^",MB_OK | MB_ICONWARNING);
    cout << "\t"; cout << "Re enter answer for question 17." << " Answer " << charQuestion17 << " not in range." << " Answer with A, B, C, D, E"<< endl;
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t"; cin >> setw(1) >> charQuestion17;
    my << charQuestion17 << endl;
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;
}


}


void validateAnswers18(void)
{


    /**VALIDATE QUESTION THREE**/
 if(charQuestion18 > 64 && charQuestion18 <70 || charQuestion18 > 96 && charQuestion18 <102 )

{

}
else

{
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t";  cout << "L A S T   W A R N I N G" << endl;
    cout << "" << endl;
    cout << "" << endl;
    MessageBox(NULL," Answer with A, B, C, D, E","  ERROR ^_^",MB_OK | MB_ICONWARNING);
    cout << "\t"; cout << "Re enter answer for question 18." << " Answer " << charQuestion18 << " not in range." << " Answer with A, B, C, D, E"<< endl;
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t"; cin >> setw(1) >> charQuestion18;
    my << charQuestion18 << endl;
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;
}


}



void validateAnswers19(void)
{


    /**VALIDATE QUESTION FOUR**/
 if(charQuestion19 > 64 && charQuestion19 <70 || charQuestion19 > 96 && charQuestion19 <102 )

{

}
else

{
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t";  cout << "L A S T   W A R N I N G" << endl;
    cout << "" << endl;
    cout << "" << endl;
    MessageBox(NULL," Answer with A, B, C, D, E","  ERROR ^_^",MB_OK | MB_ICONWARNING);
    cout << "\t"; cout << "Re enter answer for question 19." << " Answer " << charQuestion19 << " not in range." << " Answer with A, B, C, D, E"<< endl;
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t"; cin >> setw(1) >> charQuestion19;
    my << charQuestion19 << endl;
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;
}


}


void validateAnswers20(void)
{


    /**VALIDATE QUESTION FIVE**/
 if(charQuestion20 > 64 && charQuestion20 <70 || charQuestion20 > 96 && charQuestion20 <102 )

{

}
else

{
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t";  cout << "L A S T   W A R N I N G" << endl;
    cout << "" << endl;
    cout << "" << endl;
    MessageBox(NULL," Answer with A, B, C, D, E","  ERROR ^_^",MB_OK | MB_ICONWARNING);
    cout << "\t"; cout << "Re enter answer for question 20." << " Answer " << charQuestion20 << " not in range." << " Answer with A, B, C, D, E"<< endl;
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t"; cin >> setw(1) >> charQuestion20;
    my << charQuestion20 << endl;
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;
}


}




void validateAnswers21(void)
{
    /**VALIDATE QUESTION ONE**/


if(charQuestion21 > 64 && charQuestion21 <70 || charQuestion21 > 96 && charQuestion21 <102 )
{

}


else

{
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t";  cout << "L A S T   W A R N I N G" << endl;
    cout << "" << endl;
    cout << "" << endl;
    MessageBox(NULL," Answer with A, B, C, D, E","  ERROR ^_^",MB_OK | MB_ICONWARNING);
    cout << "\t"; cout << "Re enter answer for question 21." << " Answer " << charQuestion21 << " not in range." << " Answer with A, B, C, D, E"<< endl;
    cout << "" << endl;
    cout << "" << endl;
    cout << "   "; cin >> setw(1) >> charQuestion21;
    my << charQuestion21 << endl;
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;
}



}


void validateAnswers22(void)
{


    /**VALIDATE QUESTION TWO**/
 if(charQuestion22 > 64 && charQuestion22 <70 || charQuestion22 > 96 && charQuestion22 <102 )

{

}
else

{
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t";  cout << "L A S T   W A R N I N G" << endl;
    cout << "" << endl;
    cout << "" << endl;
    MessageBox(NULL," Answer with A, B, C, D, E","  ERROR ^_^",MB_OK | MB_ICONWARNING);
    cout << "\t"; cout << "Re enter answer for question 22." << " Answer " << charQuestion22 << " not in range." << " Answer with A, B, C, D, E"<< endl;
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t"; cin >> setw(1) >> charQuestion22;
    my << charQuestion22 << endl;
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;
}


}


void validateAnswers23(void)
{


    /**VALIDATE QUESTION THREE**/
 if(charQuestion23 > 64 && charQuestion23 <70 || charQuestion23 > 96 && charQuestion23 <102 )

{

}
else

{
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t";  cout << "L A S T   W A R N I N G" << endl;
    cout << "" << endl;
    cout << "" << endl;
    MessageBox(NULL," Answer with A, B, C, D, E","  ERROR ^_^",MB_OK | MB_ICONWARNING);
    cout << "\t"; cout << "Re enter answer for question 23." << " Answer " << charQuestion23 << " not in range." << " Answer with A, B, C, D, E"<< endl;
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t"; cin >> setw(1) >> charQuestion23;
    my << charQuestion23 << endl;
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;
}


}


void validateAnswers24(void)
{
    /**VALIDATE QUESTION SIX**/


if(charQuestion24 > 64 && charQuestion24 <70 || charQuestion24 > 96 && charQuestion24 <102 )
{

}


else

{
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t";  cout << "L A S T   W A R N I N G" << endl;
    cout << "" << endl;
    cout << "" << endl;
    MessageBox(NULL," Answer with A, B, C, D, E","  ERROR ^_^",MB_OK | MB_ICONWARNING);
    cout << "\t"; cout << "Re enter answer for question 24." << " Answer " << charQuestion24 << " not in range." << " Answer with A, B, C, D, E"<< endl;
    cout << "" << endl;
    cout << "" << endl;
    cout << "   "; cin >> setw(1) >> charQuestion24;
    my << charQuestion24 << endl;
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;
}



}


void validateAnswers25(void)
{


    /**VALIDATE QUESTION TWO**/
 if(charQuestion25 > 64 && charQuestion25 <70 || charQuestion25 > 96 && charQuestion25 <102 )

{

}
else

{
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t";  cout << "L A S T   W A R N I N G" << endl;
    cout << "" << endl;
    cout << "" << endl;
    MessageBox(NULL," Answer with A, B, C, D, E","  ERROR ^_^",MB_OK | MB_ICONWARNING);
    cout << "\t"; cout << "Re enter answer for question 25." << " Answer " << charQuestion25 << " not in range." << " Answer with A, B, C, D, E"<< endl;
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t"; cin >> setw(1) >> charQuestion25;
    my << charQuestion25 << endl;
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;
}


}




void validateAnswers26(void)
{
    /**VALIDATE QUESTION SIX**/


if(charQuestion26 > 64 && charQuestion26 <70 || charQuestion26 > 96 && charQuestion26 <102 )
{

}


else

{
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t";  cout << "L A S T   W A R N I N G" << endl;
    cout << "" << endl;
    cout << "" << endl;
    MessageBox(NULL," Answer with A, B, C, D, E","  ERROR ^_^",MB_OK | MB_ICONWARNING);
    cout << "\t"; cout << "Re enter answer for question 26." << " Answer " << charQuestion26 << " not in range." << " Answer with A, B, C, D, E"<< endl;
    cout << "" << endl;
    cout << "" << endl;
    cout << "   "; cin >> setw(1) >> charQuestion26;
    my << charQuestion26 << endl;
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;
}



}


void validateAnswers27(void)
{


    /**VALIDATE QUESTION TWO**/
 if(charQuestion27 > 64 && charQuestion27 <70 || charQuestion27 > 96 && charQuestion27 <102 )

{

}
else

{
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t";  cout << "L A S T   W A R N I N G" << endl;
    cout << "" << endl;
    cout << "" << endl;
    MessageBox(NULL," Answer with A, B, C, D, E","  ERROR ^_^",MB_OK | MB_ICONWARNING);
    cout << "\t"; cout << "Re enter answer for question 27." << " Answer " << charQuestion27 << " not in range." << " Answer with A, B, C, D, E"<< endl;
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t"; cin >> setw(1) >> charQuestion27;
    my << charQuestion27 << endl;
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;
}


}


void validateAnswers28(void)
{


    /**VALIDATE QUESTION THREE**/
 if(charQuestion28 > 64 && charQuestion28 <70 || charQuestion28 > 96 && charQuestion28 <102 )

{

}
else

{
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t";  cout << "L A S T   W A R N I N G" << endl;
    cout << "" << endl;
    cout << "" << endl;
    MessageBox(NULL," Answer with A, B, C, D, E","  ERROR ^_^",MB_OK | MB_ICONWARNING);
    cout << "\t"; cout << "Re enter answer for question 28." << " Answer " << charQuestion28 << " not in range." << " Answer with A, B, C, D, E"<< endl;
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t"; cin >> setw(1) >> charQuestion28;
    my << charQuestion28 << endl;
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;
}


}



void validateAnswers29(void)
{


    /**VALIDATE QUESTION FOUR**/
 if(charQuestion29 > 64 && charQuestion29 <70 || charQuestion29 > 96 && charQuestion29 <102 )

{

}
else

{
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t";  cout << "L A S T   W A R N I N G" << endl;
    cout << "" << endl;
    cout << "" << endl;
    MessageBox(NULL," Answer with A, B, C, D, E","  ERROR ^_^",MB_OK | MB_ICONWARNING);
    cout << "\t"; cout << "Re enter answer for question 29." << " Answer " << charQuestion29 << " not in range." << " Answer with A, B, C, D, E"<< endl;
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t"; cin >> setw(1) >> charQuestion29;
    my << charQuestion29 << endl;
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;
}


}


void validateAnswers30(void)
{


    /**VALIDATE QUESTION FIVE**/
 if(charQuestion30 > 64 && charQuestion30 <70 || charQuestion30 > 96 && charQuestion30 <102 )

{

}
else

{
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t";  cout << "L A S T   W A R N I N G" << endl;
    cout << "" << endl;
    cout << "" << endl;
    MessageBox(NULL," Answer with A, B, C, D, E","  ERROR ^_^",MB_OK | MB_ICONWARNING);
    cout << "\t"; cout << "Re enter answer for question 30." << " Answer " << charQuestion30 << " not in range." << " Answer with A, B, C, D, E"<< endl;
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t"; cin >> setw(1) >> charQuestion30;
    my << charQuestion30 << endl;
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;
}


}


void validateAnswers31(void)
{
    /**VALIDATE QUESTION ONE**/


if(charQuestion31 > 64 && charQuestion31 <70 || charQuestion31 > 96 && charQuestion31 <102 )
{

}


else

{
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t";  cout << "L A S T   W A R N I N G" << endl;
    cout << "" << endl;
    cout << "" << endl;
    MessageBox(NULL," Answer with A, B, C, D, E","  ERROR ^_^",MB_OK | MB_ICONWARNING);
    cout << "\t"; cout << "Re enter answer for question 31." << " Answer " << charQuestion31 << " not in range." << " Answer with A, B, C, D, E"<< endl;
    cout << "" << endl;
    cout << "" << endl;
    cout << "   "; cin >> setw(1) >> charQuestion31;
    my << charQuestion31 << endl;
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;
}



}


void validateAnswers32(void)
{


    /**VALIDATE QUESTION TWO**/
 if(charQuestion32 > 64 && charQuestion32 <70 || charQuestion32 > 96 && charQuestion32 <102 )

{

}
else

{
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t";  cout << "L A S T   W A R N I N G" << endl;
    cout << "" << endl;
    cout << "" << endl;
    MessageBox(NULL," Answer with A, B, C, D, E","  ERROR ^_^",MB_OK | MB_ICONWARNING);
    cout << "\t"; cout << "Re enter answer for question 32." << " Answer " << charQuestion32 << " not in range." << " Answer with A, B, C, D, E"<< endl;
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t"; cin >> setw(1) >> charQuestion32;
    my << charQuestion32 << endl;
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;
}


}


void validateAnswers33(void)
{


    /**VALIDATE QUESTION THREE**/
 if(charQuestion33 > 64 && charQuestion33 <70 || charQuestion33 > 96 && charQuestion33 <102 )

{

}
else

{
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t";  cout << "L A S T   W A R N I N G" << endl;
    cout << "" << endl;
    cout << "" << endl;
    MessageBox(NULL," Answer with A, B, C, D, E","  ERROR ^_^",MB_OK | MB_ICONWARNING);
    cout << "\t"; cout << "Re enter answer for question 33." << " Answer " << charQuestion33 << " not in range." << " Answer with A, B, C, D, E"<< endl;
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t"; cin >> setw(1) >> charQuestion33;
    my << charQuestion33 << endl;
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;
}


}


void validateAnswers34(void)
{
    /**VALIDATE QUESTION SIX**/


if(charQuestion34 > 64 && charQuestion34 <70 || charQuestion34 > 96 && charQuestion34 <102 )
{

}


else

{
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t";  cout << "L A S T   W A R N I N G" << endl;
    cout << "" << endl;
    cout << "" << endl;
    MessageBox(NULL," Answer with A, B, C, D, E","  ERROR ^_^",MB_OK | MB_ICONWARNING);
    cout << "\t"; cout << "Re enter answer for question 34." << " Answer " << charQuestion34 << " not in range." << " Answer with A, B, C, D, E"<< endl;
    cout << "" << endl;
    cout << "" << endl;
    cout << "   "; cin >> setw(1) >> charQuestion34;
    my << charQuestion34 << endl;
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;
}



}


void validateAnswers35(void)
{


    /**VALIDATE QUESTION TWO**/
 if(charQuestion35 > 64 && charQuestion35 <70 || charQuestion35 > 96 && charQuestion35 <102 )

{

}
else

{
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t";  cout << "L A S T   W A R N I N G" << endl;
    cout << "" << endl;
    cout << "" << endl;
    MessageBox(NULL," Answer with A, B, C, D, E","  ERROR ^_^",MB_OK | MB_ICONWARNING);
    cout << "\t"; cout << "Re enter answer for question 35." << " Answer " << charQuestion35 << " not in range." << " Answer with A, B, C, D, E"<< endl;
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t"; cin >> setw(1) >> charQuestion35;
    my << charQuestion35 << endl;
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;
}


}




void validateAnswers36(void)
{
    /**VALIDATE QUESTION SIX**/


if(charQuestion36 > 64 && charQuestion36 <70 || charQuestion36 > 96 && charQuestion36 <102 )
{

}


else

{
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t";  cout << "L A S T   W A R N I N G" << endl;
    cout << "" << endl;
    cout << "" << endl;
    MessageBox(NULL," Answer with A, B, C, D, E","  ERROR ^_^",MB_OK | MB_ICONWARNING);
    cout << "\t"; cout << "Re enter answer for question 36." << " Answer " << charQuestion36 << " not in range." << " Answer with A, B, C, D, E"<< endl;
    cout << "" << endl;
    cout << "" << endl;
    cout << "   "; cin >> setw(1) >> charQuestion36;
    my << charQuestion36 << endl;
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;
}



}


void validateAnswers37(void)
{


    /**VALIDATE QUESTION TWO**/
 if(charQuestion37 > 64 && charQuestion37 <70 || charQuestion37 > 96 && charQuestion37 <102 )

{

}
else

{
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t";  cout << "L A S T   W A R N I N G" << endl;
    cout << "" << endl;
    cout << "" << endl;
    MessageBox(NULL," Answer with A, B, C, D, E","  ERROR ^_^",MB_OK | MB_ICONWARNING);
    cout << "\t"; cout << "Re enter answer for question 37." << " Answer " << charQuestion37 << " not in range." << " Answer with A, B, C, D, E"<< endl;
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t"; cin >> setw(1) >> charQuestion37;
    my << charQuestion37 << endl;
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;
}


}


void validateAnswers38(void)
{


    /**VALIDATE QUESTION THREE**/
 if(charQuestion38 > 64 && charQuestion38 <70 || charQuestion38 > 96 && charQuestion38 <102 )

{

}
else

{
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t";  cout << "L A S T   W A R N I N G" << endl;
    cout << "" << endl;
    cout << "" << endl;
    MessageBox(NULL," Answer with A, B, C, D, E","  ERROR ^_^",MB_OK | MB_ICONWARNING);
    cout << "\t"; cout << "Re enter answer for question 38." << " Answer " << charQuestion38 << " not in range." << " Answer with A, B, C, D, E"<< endl;
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t"; cin >> setw(1) >> charQuestion38;
    my << charQuestion38 << endl;
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;
}


}



void validateAnswers39(void)
{


    /**VALIDATE QUESTION FOUR**/
 if(charQuestion39 > 64 && charQuestion39 <70 || charQuestion39 > 96 && charQuestion39 <102 )

{

}
else

{
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t";  cout << "L A S T   W A R N I N G" << endl;
    cout << "" << endl;
    cout << "" << endl;
    MessageBox(NULL," Answer with A, B, C, D, E","  ERROR ^_^",MB_OK | MB_ICONWARNING);
    cout << "\t"; cout << "Re enter answer for question 39." << " Answer " << charQuestion39 << " not in range." << " Answer with A, B, C, D, E"<< endl;
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t"; cin >> setw(1) >> charQuestion39;
    my << charQuestion39 << endl;
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;
}


}


void validateAnswers40(void)
{


    /**VALIDATE QUESTION FIVE**/
 if(charQuestion40 > 64 && charQuestion40 <70 || charQuestion40 > 96 && charQuestion40 <102 )

{

}
else

{
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t";  cout << "L A S T   W A R N I N G" << endl;
    cout << "" << endl;
    cout << "" << endl;
    MessageBox(NULL," Answer with A, B, C, D, E","  ERROR ^_^",MB_OK | MB_ICONWARNING);
    cout << "\t"; cout << "Re enter answer for question 40." << " Answer " << charQuestion40 << " not in range." << " Answer with A, B, C, D, E"<< endl;
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t"; cin >> setw(1) >> charQuestion40;
    my << charQuestion40 << endl;
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;
}


}



void validateAnswers41(void)
{
    /**VALIDATE QUESTION ONE**/


if(charQuestion41 > 64 && charQuestion41 <70 || charQuestion41 > 96 && charQuestion41 <102 )
{

}


else

{
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t";  cout << "L A S T   W A R N I N G" << endl;
    cout << "" << endl;
    cout << "" << endl;
    MessageBox(NULL," Answer with A, B, C, D, E","  ERROR ^_^",MB_OK | MB_ICONWARNING);
    cout << "\t"; cout << "Re enter answer for question 41." << " Answer " << charQuestion41 << " not in range." << " Answer with A, B, C, D, E"<< endl;
    cout << "" << endl;
    cout << "" << endl;
    cout << "   "; cin >> setw(1) >> charQuestion41;
    my << charQuestion41 << endl;
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;
}



}


void validateAnswers42(void)
{


    /**VALIDATE QUESTION TWO**/
 if(charQuestion42 > 64 && charQuestion42 <70 || charQuestion42 > 96 && charQuestion42 <102 )

{

}
else

{
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t";  cout << "L A S T   W A R N I N G" << endl;
    cout << "" << endl;
    cout << "" << endl;
    MessageBox(NULL," Answer with A, B, C, D, E","  ERROR ^_^",MB_OK | MB_ICONWARNING);
    cout << "\t"; cout << "Re enter answer for question 42." << " Answer " << charQuestion42 << " not in range." << " Answer with A, B, C, D, E"<< endl;
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t"; cin >> setw(1) >> charQuestion42;
    my << charQuestion42 << endl;
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;
}


}


void validateAnswers43(void)
{


    /**VALIDATE QUESTION THREE**/
 if(charQuestion43 > 64 && charQuestion43 <70 || charQuestion43 > 96 && charQuestion43 <102 )

{

}
else

{
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t";  cout << "L A S T   W A R N I N G" << endl;
    cout << "" << endl;
    cout << "" << endl;
    MessageBox(NULL," Answer with A, B, C, D, E","  ERROR ^_^",MB_OK | MB_ICONWARNING);
    cout << "\t"; cout << "Re enter answer for question 43." << " Answer " << charQuestion43 << " not in range." << " Answer with A, B, C, D, E"<< endl;
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t"; cin >> setw(1) >> charQuestion43;
    my << charQuestion43 << endl;
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;
}


}


void validateAnswers44(void)
{
    /**VALIDATE QUESTION SIX**/


if(charQuestion44 > 64 && charQuestion44 <70 || charQuestion44 > 96 && charQuestion44 <102 )
{

}


else

{
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t";  cout << "L A S T   W A R N I N G" << endl;
    cout << "" << endl;
    cout << "" << endl;
    MessageBox(NULL," Answer with A, B, C, D, E","  ERROR ^_^",MB_OK | MB_ICONWARNING);
    cout << "\t"; cout << "Re enter answer for question 44." << " Answer " << charQuestion44 << " not in range." << " Answer with A, B, C, D, E"<< endl;
    cout << "" << endl;
    cout << "" << endl;
    cout << "   "; cin >> setw(1) >> charQuestion44;
    my << charQuestion44 << endl;
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;
}



}


void validateAnswers45(void)
{


    /**VALIDATE QUESTION TWO**/
 if(charQuestion45 > 64 && charQuestion45 <70 || charQuestion45 > 96 && charQuestion45 <102 )

{

}
else

{
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t";  cout << "L A S T   W A R N I N G" << endl;
    cout << "" << endl;
    cout << "" << endl;
    MessageBox(NULL," Answer with A, B, C, D, E","  ERROR ^_^",MB_OK | MB_ICONWARNING);
    cout << "\t"; cout << "Re enter answer for question 45." << " Answer " << charQuestion45 << " not in range." << " Answer with A, B, C, D, E"<< endl;
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t"; cin >> setw(1) >> charQuestion45;
    my << charQuestion45 << endl;
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;
}


}




void validateAnswers46(void)
{
    /**VALIDATE QUESTION SIX**/



    /**VALIDATE QUESTION TWO**/
 if(charQuestion46 > 64 && charQuestion46 <70 || charQuestion46 > 96 && charQuestion46 <102 )

{

}
else

{
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t";  cout << "L A S T   W A R N I N G" << endl;
    cout << "" << endl;
    cout << "" << endl;
    MessageBox(NULL," Answer with A, B, C, D, E","  ERROR ^_^",MB_OK | MB_ICONWARNING);
    cout << "\t"; cout << "Re enter answer for question 46." << " Answer " << charQuestion46 << " not in range." << " Answer with A, B, C, D, E"<< endl;
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t"; cin >> setw(1) >> charQuestion46;
    my << charQuestion46 << endl;
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;
}


}


void validateAnswers47(void)
{


    /**VALIDATE QUESTION TWO**/
 if(charQuestion47 > 64 && charQuestion47 <70 || charQuestion47 > 96 && charQuestion47 <102 )

{

}
else

{
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t";  cout << "L A S T   W A R N I N G" << endl;
    cout << "" << endl;
    cout << "" << endl;
    MessageBox(NULL," Answer with A, B, C, D, E","  ERROR ^_^",MB_OK | MB_ICONWARNING);
    cout << "\t"; cout << "Re enter answer for question 47." << " Answer " << charQuestion47 << " not in range." << " Answer with A, B, C, D, E"<< endl;
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t"; cin >> setw(1) >> charQuestion47;
    my << charQuestion47 << endl;
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;
}


}


void validateAnswers48(void)
{


    /**VALIDATE QUESTION THREE**/
 if(charQuestion48 > 64 && charQuestion48 <70 || charQuestion48 > 96 && charQuestion48 <102 )

{

}
else

{
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t";  cout << "L A S T   W A R N I N G" << endl;
    cout << "" << endl;
    cout << "" << endl;
    MessageBox(NULL," Answer with A, B, C, D, E","  ERROR ^_^",MB_OK | MB_ICONWARNING);
    cout << "\t"; cout << "Re enter answer for question 48." << " Answer " << charQuestion48 << " not in range." << " Answer with A, B, C, D, E"<< endl;
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t"; cin >> setw(1) >> charQuestion48;
    my << charQuestion48 << endl;
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;
}


}



void validateAnswers49(void)
{


    /**VALIDATE QUESTION FOUR**/
 if(charQuestion49 > 64 && charQuestion49 <70 || charQuestion49 > 96 && charQuestion49 <102 )

{

}
else

{
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t";  cout << "L A S T   W A R N I N G" << endl;
    cout << "" << endl;
    cout << "" << endl;
    MessageBox(NULL," Answer with A, B, C, D, E","  ERROR ^_^",MB_OK | MB_ICONWARNING);
    cout << "\t"; cout << "Re enter answer for question 49." << " Answer " << charQuestion49 << " not in range." << " Answer with A, B, C, D, E"<< endl;
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t"; cin >> setw(1) >> charQuestion49;
    my << charQuestion49 << endl;
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;
}


}


void validateAnswers50(void)
{


    /**VALIDATE QUESTION FIVE**/
 if(charQuestion50 > 64 && charQuestion50 <70 || charQuestion50 > 96 && charQuestion50 <102 )

{

}
else

{
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t";  cout << "L A S T   W A R N I N G" << endl;
    cout << "" << endl;
    cout << "" << endl;
    MessageBox(NULL," Answer with A, B, C, D, E","  ERROR ^_^",MB_OK | MB_ICONWARNING);
    cout << "\t"; cout << "Re enter answer for question 50." << " Answer " << charQuestion50 << " not in range." << " Answer with A, B, C, D, E"<< endl;
    cout << "" << endl;
    cout << "" << endl;
    cout << "\t"; cin >> setw(1) >> charQuestion50;
    my << charQuestion50 << endl;
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;
}


}



void htmlTest1()
{



    cout << "\n";
    cout << "\t";cout << "HTML TEST 1" << endl;
    cout << "\n";

    /**QUESTION 1 */


    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion1HTMLTest1[i] << endl;
        cout << "" << endl;
    }


    cout << "\t"; cin >> setw(1) >> setw(1) >> charQuestion1;
    validateAnswers1();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');


    cout << "" << endl;
    cout << "" << endl;


    /**QUESTION 2*/

    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion2HTMLTest1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion2;
    validateAnswers2();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;

    cout << "\n";

    /**QUESTION 3*/

    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion3HTMLTest1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion3;
    validateAnswers3();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;

    /**QUESTION 4*/
    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion4HTMLTest1[i] << endl;
        cout << "" << endl;
    }


    cout << "\t"; cin >> setw(1) >> charQuestion4;
    validateAnswers4();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;


    /**QUESTION 5*/
    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion5HTMLTest1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion5;
    validateAnswers5();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;


     /**QUESTION 6*/

   for(int i=0; i< 5; i++)
    {
        cout << arrQuestion6HTMLTest1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion6;
    validateAnswers6();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;


    /**QUESTION 7*/

    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion7HTMLTest1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion7;
    validateAnswers7();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;

    cout << "\n";

    /**QUESTION 8*/

    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion8HTMLTest1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion8;
    validateAnswers8();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;

    /**QUESTION 9*/
    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion9HTMLTest1[i] << endl;
        cout << "" << endl;
    }


    cout << "\t"; cin >> setw(1) >> charQuestion9;
    validateAnswers9();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;


    /**QUESTION 10*/
    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion10HTMLTest1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion10;
    validateAnswers10();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;


        /**QUESTION 11 */


    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion11HTMLTest1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion11;
    validateAnswers11();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;


    /**QUESTION 12*/

    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion12HTMLTest1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion12;
    validateAnswers12();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;

    //cout << "\n";

    /**QUESTION 13*/

    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion13HTMLTest1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion13;
    validateAnswers13();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;

    /**QUESTION 14*/
    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion14HTMLTest1[i] << endl;
        cout << "" << endl;
    }


    cout << "\t"; cin >> setw(1) >> charQuestion14;
    validateAnswers14();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;


    /**QUESTION 15*/
    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion15HTMLTest1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion15;
    validateAnswers15();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;

       /**QUESTION 16*/
    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion16HTMLTest1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion16;
    validateAnswers16();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;


    /**QUESTION 17*/

    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion17HTMLTest1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion17;
    validateAnswers17();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;


    //cout << "\n";

    /**QUESTION 18*/

    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion18HTMLTest1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion18;
    validateAnswers18();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;

    /**QUESTION 19*/
    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion19HTMLTest1[i] << endl;
        cout << "" << endl;
    }


    cout << "\t"; cin >> setw(1) >> charQuestion19;
    validateAnswers19();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;


    /**QUESTION 20*/
    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion20HTMLTest1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion20;
    validateAnswers20();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;


     /**QUESTION 21 */


    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion21HTMLTest1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion21;
    validateAnswers21();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;


    /**QUESTION 22*/

    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion22HTMLTest1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion22;
    validateAnswers22();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;

    /**QUESTION 23*/

    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion23HTMLTest1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion23;
    validateAnswers23();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;

    /**QUESTION 24*/
    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion24HTMLTest1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion24;
    validateAnswers24();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;


    /**QUESTION 25*/
    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion25HTMLTest1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion25;
    validateAnswers25();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;


     /**QUESTION 26*/

    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion26HTMLTest1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion26;
    validateAnswers26();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;


    /**QUESTION 27*/

    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion27HTMLTest1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion27;
    validateAnswers27();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;

    //cout << "\n";

    /**QUESTION 28*/

    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion28HTMLTest1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion28;
    validateAnswers28();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;


    /**QUESTION 29*/
    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion29HTMLTest1[i] << endl;
        cout << "" << endl;
    }


    cout << "\t"; cin >> setw(1) >> charQuestion29;
    validateAnswers29();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;


    /**QUESTION 30*/
    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion30HTMLTest1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion30;
    validateAnswers30();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;


        /**QUESTION 31 */


    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion31HTMLTest1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion31;
    validateAnswers31();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;


    /**QUESTION 32*/

    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion32HTMLTest1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion32;
    validateAnswers32();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;

    //cout << "\n";

    /**QUESTION 33*/

    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion33HTMLTest1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion33;
    validateAnswers33();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;


    /**QUESTION 34*/
    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion34HTMLTest1[i] << endl;
        cout << "" << endl;
    }


    cout << "\t"; cin >> setw(1) >> charQuestion34;
    validateAnswers34();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;


    /**QUESTION 35*/
    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion35HTMLTest1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion35;
    validateAnswers35();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;


   /**QUESTION 36*/
    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion36HTMLTest1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion36;
    validateAnswers36();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;


    /**QUESTION 37*/

    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion37HTMLTest1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion37;
    validateAnswers37();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;

    //cout << "\n";

    /**QUESTION 38*/

    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion38HTMLTest1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion38;
    validateAnswers38();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;


    /**QUESTION 39*/
    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion39HTMLTest1[i] << endl;
        cout << "" << endl;
    }


    cout << "\t"; cin >> setw(1) >> charQuestion39;
    validateAnswers39();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;


    /**QUESTION 40*/
    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion40HTMLTest1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion40;
    validateAnswers40();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;


    /**QUESTION 41 */


    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion41HTMLTest1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion41;
    validateAnswers41();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;


    /**QUESTION 42*/

    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion42HTMLTest1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion42;
    validateAnswers42();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;

    //cout << "\n";

    /**QUESTION 43*/

    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion43HTMLTest1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion43;
    validateAnswers43();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;


    /**QUESTION 44*/
    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion44HTMLTest1[i] << endl;
        cout << "" << endl;
    }


    cout << "\t"; cin >> setw(1) >> charQuestion44;
    validateAnswers44();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;



    /**QUESTION 45*/
    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion45HTMLTest1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion45;
    validateAnswers45();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;


     /**QUESTION 46*/

    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion46HTMLTest1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion46;
    validateAnswers46();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;


    /**QUESTION 47*/

    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion47HTMLTest1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion47;
    validateAnswers47();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;

    //cout << "\n";

    /**QUESTION 48*/

    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion48HTMLTest1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion48;
    validateAnswers48();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;

    /**QUESTION 49*/
    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion49HTMLTest1[i] << endl;
        cout << "" << endl;
    }


    cout << "\t"; cin >> setw(1) >> charQuestion49;
    validateAnswers49();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;


    /**QUESTION 50*/
    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion50HTMLTest1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion50;
    validateAnswers50();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;





    /**MARKING THE EXAM */
    cout << "\n" << endl;

		if (charQuestion1 == 65 || charQuestion1 == 97)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 1 => " << defChoiceA << " is the answer" << " not " << charQuestion1 << endl;
		my << "\tQuestion 1 => " << defChoiceA << " is the answer" << " not " << charQuestion1  << endl;
			}

if (charQuestion2 == 66 || charQuestion2 == 98)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 2 => " << defChoiceB << " is the answer" << " not " << charQuestion2 << endl;
		my << "\tQuestion 2 => " << defChoiceB << " is the answer" << " not " << charQuestion2  << endl;
			}

    if (charQuestion3 == 67 || charQuestion3 == 99)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 3 => " << defChoiceC << " is the answer" << " not " << charQuestion3 << endl;
		my << "\tQuestion 3 => " << defChoiceC << " is the answer" << " not " << charQuestion3  << endl;
			}


    if (charQuestion4 == 68 || charQuestion4 == 100)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 4 => " << defChoiceD << " is the answer" << " not " << charQuestion4 << endl;
		my << "\tQuestion 4 => " << defChoiceD << " is the answer" << " not " << charQuestion4  << endl;
			}



    if (charQuestion5 == 65 || charQuestion5 == 97)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 5 => " << defChoiceA << " is the answer" << " not " << charQuestion5 << endl;
		my << "\tQuestion 5 => " << defChoiceA << " is the answer" << " not " << charQuestion5  << endl;
			}


    if (charQuestion6 == 65 || charQuestion6 == 97)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 6 => " << defChoiceA << " is the answer" << " not " << charQuestion6 << endl;
		my << "\tQuestion 6 => " << defChoiceA << " is the answer" << " not " << charQuestion6  << endl;
			}

if (charQuestion7 == 66 || charQuestion7 == 98)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 7 => " << defChoiceB << " is the answer" << " not " << charQuestion7 << endl;
		my << "\tQuestion 7 => " << defChoiceB << " is the answer" << " not " << charQuestion7  << endl;
			}

			if (charQuestion8 == 67 || charQuestion8 == 99)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 8 => " << defChoiceC << " is the answer" << " not " << charQuestion8 << endl;
		my << "\tQuestion 8 => " << defChoiceC << " is the answer" << " not " << charQuestion8  << endl;
			}


			if (charQuestion9 == 67 || charQuestion9 == 99)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 9 => " << defChoiceC << " is the answer" << " not " << charQuestion9 << endl;
		my << "\tQuestion 9 => " << defChoiceC << " is the answer" << " not " << charQuestion9  << endl;
			}


    if (charQuestion10 == 68 || charQuestion10 == 100)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 10 => " << defChoiceD << " is the answer" << " not " << charQuestion10 << endl;
		my << "\tQuestion 10 => " << defChoiceD << " is the answer" << " not " << charQuestion10  << endl;
			}


		if (charQuestion11 == 65 || charQuestion11 == 97)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 11 => " << defChoiceA << " is the answer" << " not " << charQuestion11 << endl;
		my << "\tQuestion 11 => " << defChoiceA << " is the answer" << " not " << charQuestion11  << endl;
			}

if (charQuestion12 == 66 || charQuestion12 == 98)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 12 => " << defChoiceB << " is the answer" << " not " << charQuestion12 << endl;
		my << "\tQuestion 12 => " << defChoiceB << " is the answer" << " not " << charQuestion12  << endl;
			}

    if (charQuestion13 == 67 || charQuestion13 == 99)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 13 => " << defChoiceC << " is the answer" << " not " << charQuestion13 << endl;
		my << "\tQuestion 13 => " << defChoiceC << " is the answer" << " not " << charQuestion13  << endl;
			}


    if (charQuestion14 == 68 || charQuestion14 == 100)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 14 => " << defChoiceD << " is the answer" << " not " << charQuestion14 << endl;
		my << "\tQuestion 14 => " << defChoiceD << " is the answer" << " not " << charQuestion14  << endl;
			}



    if (charQuestion15 == 65 || charQuestion15 == 97)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 15 => " << defChoiceA << " is the answer" << " not " << charQuestion15 << endl;
		my << "\tQuestion 15 => " << defChoiceA << " is the answer" << " not " << charQuestion15  << endl;
			}

    if (charQuestion16 == 65 || charQuestion16 == 97)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 16 => " << defChoiceA << " is the answer" << " not " << charQuestion16 << endl;
		my << "\tQuestion 16 => " << defChoiceA << " is the answer" << " not " << charQuestion16  << endl;
			}

if (charQuestion17 == 66 || charQuestion17 == 98)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 17 => " << defChoiceB << " is the answer" << " not " << charQuestion17 << endl;
		my << "\tQuestion 17 => " << defChoiceB << " is the answer" << " not " << charQuestion17  << endl;
			}

    if (charQuestion18 == 67 || charQuestion18 == 99)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 18 => " << defChoiceC << " is the answer" << " not " << charQuestion18 << endl;
		my << "\tQuestion 18 => " << defChoiceC << " is the answer" << " not " << charQuestion18  << endl;
			}


    if (charQuestion19 == 68 || charQuestion19 == 100)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 19 => " << defChoiceD << " is the answer" << " not " << charQuestion19 << endl;
		my << "\tQuestion 19 => " << defChoiceD << " is the answer" << " not " << charQuestion19  << endl;
			}



    if (charQuestion20 == 65 || charQuestion20 == 97)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 20 => " << defChoiceA << " is the answer" << " not " << charQuestion20 << endl;
		my << "\tQuestion 20 => " << defChoiceA << " is the answer" << " not " << charQuestion20  << endl;
			}


				if (charQuestion21 == 65 || charQuestion21 == 97)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 21 => " << defChoiceA << " is the answer" << " not " << charQuestion21 << endl;
		my << "\tQuestion 21 => " << defChoiceA << " is the answer" << " not " << charQuestion21  << endl;
			}

if (charQuestion22 == 66 || charQuestion22 == 98)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 22 => " << defChoiceB << " is the answer" << " not " << charQuestion22 << endl;
		my << "\tQuestion 22 => " << defChoiceB << " is the answer" << " not " << charQuestion22  << endl;
			}

    if (charQuestion23 == 67 || charQuestion23 == 99)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 23 => " << defChoiceC << " is the answer" << " not " << charQuestion23 << endl;
		my << "\tQuestion 23 => " << defChoiceC << " is the answer" << " not " << charQuestion23  << endl;
			}


    if (charQuestion24 == 68 || charQuestion24 == 100)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 24 => " << defChoiceD << " is the answer" << " not " << charQuestion24 << endl;
		my << "\tQuestion 24 => " << defChoiceD << " is the answer" << " not " << charQuestion24  << endl;
			}



    if (charQuestion25 == 65 || charQuestion25 == 97)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 25 => " << defChoiceA << " is the answer" << " not " << charQuestion25 << endl;
		my << "\tQuestion 25 => " << defChoiceA << " is the answer" << " not " << charQuestion25  << endl;
			}


    if (charQuestion26 == 65 || charQuestion26 == 97)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 26 => " << defChoiceA << " is the answer" << " not " << charQuestion26 << endl;
		my << "\tQuestion 26 => " << defChoiceA << " is the answer" << " not " << charQuestion26  << endl;
			}

if (charQuestion27 == 66 || charQuestion27 == 98)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 27 => " << defChoiceB << " is the answer" << " not " << charQuestion27 << endl;
		my << "\tQuestion 27 => " << defChoiceB << " is the answer" << " not " << charQuestion27  << endl;
			}

			if (charQuestion28 == 67 || charQuestion28 == 99)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 28 => " << defChoiceC << " is the answer" << " not " << charQuestion28 << endl;
		my << "\tQuestion 28 => " << defChoiceC << " is the answer" << " not " << charQuestion28  << endl;
			}



    if (charQuestion29 == 67 || charQuestion29 == 99)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 29 => " << defChoiceC << " is the answer" << " not " << charQuestion29 << endl;
		my << "\tQuestion 29 => " << defChoiceC << " is the answer" << " not " << charQuestion29  << endl;
			}


    if (charQuestion30 == 68 || charQuestion30 == 100)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 30 => " << defChoiceD << " is the answer" << " not " << charQuestion30 << endl;
		my << "\tQuestion 30 => " << defChoiceD << " is the answer" << " not " << charQuestion30  << endl;
			}


		if (charQuestion31 == 65 || charQuestion31 == 97)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 31 => " << defChoiceA << " is the answer" << " not " << charQuestion31 << endl;
		my << "\tQuestion 31 => " << defChoiceA << " is the answer" << " not " << charQuestion31  << endl;
			}

if (charQuestion32 == 66 || charQuestion32 == 98)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 32 => " << defChoiceB << " is the answer" << " not " << charQuestion32 << endl;
		my << "\tQuestion 32 => " << defChoiceB << " is the answer" << " not " << charQuestion32  << endl;
			}

    if (charQuestion33 == 67 || charQuestion33 == 99)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 33 => " << defChoiceC << " is the answer" << " not " << charQuestion33 << endl;
		my << "\tQuestion 33 => " << defChoiceC << " is the answer" << " not " << charQuestion33  << endl;
			}


    if (charQuestion34 == 68 || charQuestion34 == 100)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 34 => " << defChoiceD << " is the answer" << " not " << charQuestion34 << endl;
		my << "\tQuestion 34 => " << defChoiceD << " is the answer" << " not " << charQuestion34  << endl;
			}



    if (charQuestion35 == 65 || charQuestion35 == 97)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 35 => " << defChoiceA << " is the answer" << " not " << charQuestion35 << endl;
		my << "\tQuestion 35 => " << defChoiceA << " is the answer" << " not " << charQuestion35  << endl;
			}

    if (charQuestion36 == 65 || charQuestion36 == 97)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 36 => " << defChoiceA << " is the answer" << " not " << charQuestion36 << endl;
		my << "\tQuestion 36 => " << defChoiceA << " is the answer" << " not " << charQuestion36  << endl;
			}

if (charQuestion37 == 66 || charQuestion37 == 98)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 37 => " << defChoiceB << " is the answer" << " not " << charQuestion37 << endl;
		my << "\tQuestion 37 => " << defChoiceB << " is the answer" << " not " << charQuestion37  << endl;
			}

    if (charQuestion38 == 67 || charQuestion38 == 99)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 38 => " << defChoiceC << " is the answer" << " not " << charQuestion38 << endl;
		my << "\tQuestion 38 => " << defChoiceC << " is the answer" << " not " << charQuestion38  << endl;
			}


    if (charQuestion39 == 68 || charQuestion39 == 100)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 39 => " << defChoiceD << " is the answer" << " not " << charQuestion39 << endl;
		my << "\tQuestion 39 => " << defChoiceD << " is the answer" << " not " << charQuestion39  << endl;
			}



    if (charQuestion40 == 65 || charQuestion40 == 97)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 40 => " << defChoiceA << " is the answer" << " not " << charQuestion40 << endl;
		my << "\tQuestion 40 => " << defChoiceA << " is the answer" << " not " << charQuestion40  << endl;
			}


		if (charQuestion41 == 65 || charQuestion41 == 97)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 41 => " << defChoiceA << " is the answer" << " not " << charQuestion41 << endl;
		my << "\tQuestion 41 => " << defChoiceA << " is the answer" << " not " << charQuestion41  << endl;
			}

if (charQuestion42 == 66 || charQuestion42 == 98)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 42 => " << defChoiceB << " is the answer" << " not " << charQuestion42 << endl;
		my << "\tQuestion 42 => " << defChoiceB << " is the answer" << " not " << charQuestion42  << endl;
			}

    if (charQuestion43 == 67 || charQuestion43 == 99)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 43 => " << defChoiceC << " is the answer" << " not " << charQuestion43 << endl;
		my << "\tQuestion 43 => " << defChoiceC << " is the answer" << " not " << charQuestion43  << endl;
			}


    if (charQuestion44 == 68 || charQuestion44 == 100)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 44 => " << defChoiceD << " is the answer" << " not " << charQuestion44 << endl;
		my << "\tQuestion 44 => " << defChoiceD << " is the answer" << " not " << charQuestion44  << endl;
			}



    if (charQuestion45 == 65 || charQuestion45 == 97)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 45 => " << defChoiceA << " is the answer" << " not " << charQuestion45 << endl;
		my << "\tQuestion 45 => " << defChoiceA << " is the answer" << " not " << charQuestion45  << endl;
			}

    if (charQuestion46 == 65 || charQuestion46 == 97)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 46 => " << defChoiceA << " is the answer" << " not " << charQuestion46 << endl;
		my << "\tQuestion 46 => " << defChoiceA << " is the answer" << " not " << charQuestion46  << endl;
			}

if (charQuestion47 == 66 || charQuestion47 == 98)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 47 => " << defChoiceB << " is the answer" << " not " << charQuestion47 << endl;
		my << "\tQuestion 47 => " << defChoiceB << " is the answer" << " not " << charQuestion47  << endl;
			}

    if (charQuestion48 == 67 || charQuestion48 == 99)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 48 => " << defChoiceC << " is the answer" << " not " << charQuestion48 << endl;
		my << "\tQuestion 48 => " << defChoiceC << " is the answer" << " not " << charQuestion48  << endl;
			}


    if (charQuestion49 == 68 || charQuestion49 == 100)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 49 => " << defChoiceD << " is the answer" << " not " << charQuestion49 << endl;
		my << "\tQuestion 49 => " << defChoiceD << " is the answer" << " not " << charQuestion49  << endl;
			}



    if (charQuestion50 == 65 || charQuestion50 == 97)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 50 => " << defChoiceA << " is the answer" << " not " << charQuestion50 << endl;
		my << "\tQuestion 50 => " << defChoiceA << " is the answer" << " not " << charQuestion50  << endl;
			}

    cout << "\n" << endl;
    /**RESULT*/

    cout << "\tHTML TEST 1\n" << endl;

    cout << "\t" <<userName << " " << surname << "\n" << endl;

    cout << "\tYour result is : " << endl;
		cout << "\t";	cout << count << " out of " << Total50 << endl;

     my << "\n" << endl;
     my << "\tHTML TEST 1" << endl;

     my << "\n\t" << endl;

     my << "\t" << userName << " " << surname << "\n" << endl;

		my << "\tYour result is : " << endl;
		my << "\t";my << count << " out of " << Total50 << endl;

			cin.ignore(10, '\n');
			cin.get();



}

void AgricultureGrade5Test1(void)
{



    cout << "\n";
    cout << "\t";cout << "AGRICULTURE GRADE 5 TEST 1" << endl;
    cout << "\n";

    /**QUESTION 1 */


    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion1AgricultureGrade5Test1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion1;
    validateAnswers1();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;


    /**QUESTION 2*/

    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion2AgricultureGrade5Test1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion2;
    validateAnswers2();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;

    cout << "\n";

    /**QUESTION 3*/

    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion3AgricultureGrade5Test1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion3;
    validateAnswers3();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;

    /**QUESTION 4*/
    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion4AgricultureGrade5Test1[i] << endl;
        cout << "" << endl;
    }


    cout << "\t"; cin >> setw(1) >> charQuestion4;
    validateAnswers4();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;


    /**QUESTION 5*/
    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion5AgricultureGrade5Test1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion5;
    validateAnswers5();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;


     /**QUESTION 6*/

    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion6AgricultureGrade5Test1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion6;
    validateAnswers6();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;


    /**QUESTION 7*/

    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion7AgricultureGrade5Test1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion7;
    validateAnswers7();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;

    cout << "\n";

    /**QUESTION 8*/

    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion8AgricultureGrade5Test1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion8;
    validateAnswers8();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;

    /**QUESTION 9*/
    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion9AgricultureGrade5Test1[i] << endl;
        cout << "" << endl;
    }


    cout << "\t"; cin >> setw(1) >> charQuestion9;
    validateAnswers9();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;


    /**QUESTION 10*/
    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion10AgricultureGrade5Test1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion10;
    validateAnswers10();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;


        /**QUESTION 11 */


    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion11AgricultureGrade5Test1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion11;
    validateAnswers11();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;


    /**QUESTION 12*/

    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion12AgricultureGrade5Test1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion12;
    validateAnswers12();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;

    //cout << "\n";

    /**QUESTION 13*/

    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion13AgricultureGrade5Test1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion13;
    validateAnswers13();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;

    /**QUESTION 14*/
    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion14AgricultureGrade5Test1[i] << endl;
        cout << "" << endl;
    }


    cout << "\t"; cin >> setw(1) >> charQuestion14;
    validateAnswers14();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;


    /**QUESTION 15*/
    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion15AgricultureGrade5Test1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion15;
    validateAnswers15();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;


   /**QUESTION 16*/
    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion16AgricultureGrade5Test1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion16;
    validateAnswers16();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;


    /**QUESTION 17*/

    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion17AgricultureGrade5Test1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion17;
    validateAnswers17();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;


    //cout << "\n";

    /**QUESTION 18*/

    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion18AgricultureGrade5Test1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion18;
    validateAnswers18();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;

    /**QUESTION 19*/
    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion19AgricultureGrade5Test1[i] << endl;
        cout << "" << endl;
    }


    cout << "\t"; cin >> setw(1) >> charQuestion19;
    validateAnswers19();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;


    /**QUESTION 20*/
    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion20AgricultureGrade5Test1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion20;
    validateAnswers20();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;


     /**QUESTION 21 */


    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion21AgricultureGrade5Test1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion21;
    validateAnswers21();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;


    /**QUESTION 22*/

    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion22AgricultureGrade5Test1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion22;
    validateAnswers22();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;

    /**QUESTION 23*/

    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion23AgricultureGrade5Test1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion23;
    validateAnswers23();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;

    /**QUESTION 24*/
    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion24AgricultureGrade5Test1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion24;
    validateAnswers24();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;


    /**QUESTION 25*/
    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion25AgricultureGrade5Test1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion25;
    validateAnswers25();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;


     /**QUESTION 26*/

    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion26AgricultureGrade5Test1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion26;
    validateAnswers26();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;


    /**QUESTION 27*/

    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion27AgricultureGrade5Test1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion27;
    validateAnswers27();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;

    //cout << "\n";

    /**QUESTION 28*/

    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion28AgricultureGrade5Test1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion28;
    validateAnswers28();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;


    /**QUESTION 29*/
    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion29AgricultureGrade5Test1[i] << endl;
        cout << "" << endl;
    }


    cout << "\t"; cin >> setw(1) >> charQuestion29;
    validateAnswers29();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;


    /**QUESTION 30*/
    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion30AgricultureGrade5Test1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion30;
    validateAnswers30();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;


        /**QUESTION 31 */


    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion31AgricultureGrade5Test1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion31;
    validateAnswers31();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;


    /**QUESTION 32*/

    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion32AgricultureGrade5Test1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion32;
    validateAnswers32();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;

    //cout << "\n";

    /**QUESTION 33*/

    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion33AgricultureGrade5Test1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion33;
    validateAnswers33();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;


    /**QUESTION 34*/
    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion34AgricultureGrade5Test1[i] << endl;
        cout << "" << endl;
    }


    cout << "\t"; cin >> setw(1) >> charQuestion34;
    validateAnswers34();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;


    /**QUESTION 35*/
    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion35AgricultureGrade5Test1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion35;
    validateAnswers35();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;


   /**QUESTION 36*/
    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion36AgricultureGrade5Test1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion36;
    validateAnswers36();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;


    /**QUESTION 37*/

    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion37AgricultureGrade5Test1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion37;
    validateAnswers37();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;

    //cout << "\n";

    /**QUESTION 38*/

    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion38AgricultureGrade5Test1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion38;
    validateAnswers38();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;


    /**QUESTION 39*/
    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion39AgricultureGrade5Test1[i] << endl;
        cout << "" << endl;
    }


    cout << "\t"; cin >> setw(1) >> charQuestion39;
    validateAnswers39();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;


    /**QUESTION 40*/
    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion40AgricultureGrade5Test1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion40;
    validateAnswers40();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;


    /**QUESTION 41 */


    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion41AgricultureGrade5Test1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion41;
    validateAnswers41();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;


    /**QUESTION 42*/

    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion42AgricultureGrade5Test1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion42;
    validateAnswers42();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;

    //cout << "\n";

    /**QUESTION 43*/

    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion43AgricultureGrade5Test1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion43;
    validateAnswers43();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;


    /**QUESTION 44*/
    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion44AgricultureGrade5Test1[i] << endl;
        cout << "" << endl;
    }


    cout << "\t"; cin >> setw(1) >> charQuestion44;
    validateAnswers44();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;



    /**QUESTION 45*/
    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion45AgricultureGrade5Test1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion45;
    validateAnswers45();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;


     /**QUESTION 46*/

    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion46AgricultureGrade5Test1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion46;
    validateAnswers46();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;


    /**QUESTION 47*/

    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion47AgricultureGrade5Test1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion47;
    validateAnswers47();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;

    //cout << "\n";

    /**QUESTION 48*/

    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion48AgricultureGrade5Test1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion48;
    validateAnswers48();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;

    /**QUESTION 49*/
    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion49AgricultureGrade5Test1[i] << endl;
        cout << "" << endl;
    }


    cout << "\t"; cin >> setw(1) >> charQuestion49;
    validateAnswers49();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;


    /**QUESTION 50*/
    for(int i=0; i< 5; i++)
    {
        cout << arrQuestion50AgricultureGrade5Test1[i] << endl;
        cout << "" << endl;
    }

    cout << "\t"; cin >> setw(1) >> charQuestion50;
    validateAnswers50();
    cin.clear();
    cin.ignore(IGNORE_MAX,'\n');
    cout << "" << endl;
    cout << "" << endl;




    /**MARKING THE EXAM */
    cout << "\n" << endl;

		if (charQuestion1 == 65 || charQuestion1 == 97)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 1 => " << defChoiceA << " is the answer" << " not " << charQuestion1 << endl;
		my << "\tQuestion 1 => " << defChoiceA << " is the answer" << " not " << charQuestion1  << endl;
			}

if (charQuestion2 == 66 || charQuestion2 == 98)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 2 => " << defChoiceB << " is the answer" << " not " << charQuestion2 << endl;
		my << "\tQuestion 2 => " << defChoiceB << " is the answer" << " not " << charQuestion2  << endl;
			}

    if (charQuestion3 == 67 || charQuestion3 == 99)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 3 => " << defChoiceC << " is the answer" << " not " << charQuestion3 << endl;
		my << "\tQuestion 3 => " << defChoiceC << " is the answer" << " not " << charQuestion3  << endl;
			}


    if (charQuestion4 == 68 || charQuestion4 == 100)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 4 => " << defChoiceD << " is the answer" << " not " << charQuestion4 << endl;
		my << "\tQuestion 4 => " << defChoiceD << " is the answer" << " not " << charQuestion4  << endl;
			}



    if (charQuestion5 == 65 || charQuestion5 == 97)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 5 => " << defChoiceA << " is the answer" << " not " << charQuestion5 << endl;
		my << "\tQuestion 5 => " << defChoiceA << " is the answer" << " not " << charQuestion5  << endl;
			}


    if (charQuestion6 == 65 || charQuestion6 == 97)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 6 => " << defChoiceA << " is the answer" << " not " << charQuestion6 << endl;
		my << "\tQuestion 6 => " << defChoiceA << " is the answer" << " not " << charQuestion6  << endl;
			}

if (charQuestion7 == 66 || charQuestion7 == 98)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 7 => " << defChoiceB << " is the answer" << " not " << charQuestion7 << endl;
		my << "\tQuestion 7 => " << defChoiceB << " is the answer" << " not " << charQuestion7  << endl;
			}

			if (charQuestion8 == 67 || charQuestion8 == 99)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 8 => " << defChoiceC << " is the answer" << " not " << charQuestion8 << endl;
		my << "\tQuestion 8 => " << defChoiceC << " is the answer" << " not " << charQuestion8  << endl;
			}


			if (charQuestion9 == 67 || charQuestion9 == 99)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 9 => " << defChoiceC << " is the answer" << " not " << charQuestion9 << endl;
		my << "\tQuestion 9 => " << defChoiceC << " is the answer" << " not " << charQuestion9  << endl;
			}


    if (charQuestion10 == 68 || charQuestion10 == 100)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 10 => " << defChoiceD << " is the answer" << " not " << charQuestion10 << endl;
		my << "\tQuestion 10 => " << defChoiceD << " is the answer" << " not " << charQuestion10  << endl;
			}


		if (charQuestion11 == 65 || charQuestion11 == 97)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 11 => " << defChoiceA << " is the answer" << " not " << charQuestion11 << endl;
		my << "\tQuestion 11 => " << defChoiceA << " is the answer" << " not " << charQuestion11  << endl;
			}

if (charQuestion12 == 66 || charQuestion12 == 98)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 12 => " << defChoiceB << " is the answer" << " not " << charQuestion12 << endl;
		my << "\tQuestion 12 => " << defChoiceB << " is the answer" << " not " << charQuestion12  << endl;
			}

    if (charQuestion13 == 67 || charQuestion13 == 99)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 13 => " << defChoiceC << " is the answer" << " not " << charQuestion13 << endl;
		my << "\tQuestion 13 => " << defChoiceC << " is the answer" << " not " << charQuestion13  << endl;
			}


    if (charQuestion14 == 68 || charQuestion14 == 100)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 14 => " << defChoiceD << " is the answer" << " not " << charQuestion14 << endl;
		my << "\tQuestion 14 => " << defChoiceD << " is the answer" << " not " << charQuestion14  << endl;
			}



    if (charQuestion15 == 65 || charQuestion15 == 97)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 15 => " << defChoiceA << " is the answer" << " not " << charQuestion15 << endl;
		my << "\tQuestion 15 => " << defChoiceA << " is the answer" << " not " << charQuestion15  << endl;
			}

    if (charQuestion16 == 65 || charQuestion16 == 97)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 16 => " << defChoiceA << " is the answer" << " not " << charQuestion16 << endl;
		my << "\tQuestion 16 => " << defChoiceA << " is the answer" << " not " << charQuestion16  << endl;
			}

if (charQuestion17 == 66 || charQuestion17 == 98)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 17 => " << defChoiceB << " is the answer" << " not " << charQuestion17 << endl;
		my << "\tQuestion 17 => " << defChoiceB << " is the answer" << " not " << charQuestion17  << endl;
			}

    if (charQuestion18 == 67 || charQuestion18 == 99)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 18 => " << defChoiceC << " is the answer" << " not " << charQuestion18 << endl;
		my << "\tQuestion 18 => " << defChoiceC << " is the answer" << " not " << charQuestion18  << endl;
			}


    if (charQuestion19 == 68 || charQuestion19 == 100)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 19 => " << defChoiceD << " is the answer" << " not " << charQuestion19 << endl;
		my << "\tQuestion 19 => " << defChoiceD << " is the answer" << " not " << charQuestion19  << endl;
			}



    if (charQuestion20 == 65 || charQuestion20 == 97)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 20 => " << defChoiceA << " is the answer" << " not " << charQuestion20 << endl;
		my << "\tQuestion 20 => " << defChoiceA << " is the answer" << " not " << charQuestion20  << endl;
			}


				if (charQuestion21 == 65 || charQuestion21 == 97)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 21 => " << defChoiceA << " is the answer" << " not " << charQuestion21 << endl;
		my << "\tQuestion 21 => " << defChoiceA << " is the answer" << " not " << charQuestion21  << endl;
			}

if (charQuestion22 == 66 || charQuestion22 == 98)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 22 => " << defChoiceB << " is the answer" << " not " << charQuestion22 << endl;
		my << "\tQuestion 22 => " << defChoiceB << " is the answer" << " not " << charQuestion22  << endl;
			}

    if (charQuestion23 == 67 || charQuestion23 == 99)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 23 => " << defChoiceC << " is the answer" << " not " << charQuestion23 << endl;
		my << "\tQuestion 23 => " << defChoiceC << " is the answer" << " not " << charQuestion23  << endl;
			}


    if (charQuestion24 == 68 || charQuestion24 == 100)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 24 => " << defChoiceD << " is the answer" << " not " << charQuestion24 << endl;
		my << "\tQuestion 24 => " << defChoiceD << " is the answer" << " not " << charQuestion24  << endl;
			}



    if (charQuestion25 == 65 || charQuestion25 == 97)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 25 => " << defChoiceA << " is the answer" << " not " << charQuestion25 << endl;
		my << "\tQuestion 25 => " << defChoiceA << " is the answer" << " not " << charQuestion25  << endl;
			}


    if (charQuestion26 == 65 || charQuestion26 == 97)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 26 => " << defChoiceA << " is the answer" << " not " << charQuestion26 << endl;
		my << "\tQuestion 26 => " << defChoiceA << " is the answer" << " not " << charQuestion26  << endl;
			}

if (charQuestion27 == 66 || charQuestion27 == 98)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 27 => " << defChoiceB << " is the answer" << " not " << charQuestion27 << endl;
		my << "\tQuestion 27 => " << defChoiceB << " is the answer" << " not " << charQuestion27  << endl;
			}

			if (charQuestion28 == 67 || charQuestion28 == 99)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 28 => " << defChoiceC << " is the answer" << " not " << charQuestion28 << endl;
		my << "\tQuestion 28 => " << defChoiceC << " is the answer" << " not " << charQuestion28  << endl;
			}



    if (charQuestion29 == 67 || charQuestion29 == 99)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 29 => " << defChoiceC << " is the answer" << " not " << charQuestion29 << endl;
		my << "\tQuestion 29 => " << defChoiceC << " is the answer" << " not " << charQuestion29  << endl;
			}


    if (charQuestion30 == 68 || charQuestion30 == 100)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 30 => " << defChoiceD << " is the answer" << " not " << charQuestion30 << endl;
		my << "\tQuestion 30 => " << defChoiceD << " is the answer" << " not " << charQuestion30  << endl;
			}


		if (charQuestion31 == 65 || charQuestion31 == 97)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 31 => " << defChoiceA << " is the answer" << " not " << charQuestion31 << endl;
		my << "\tQuestion 31 => " << defChoiceA << " is the answer" << " not " << charQuestion31  << endl;
			}

if (charQuestion32 == 66 || charQuestion32 == 98)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 32 => " << defChoiceB << " is the answer" << " not " << charQuestion32 << endl;
		my << "\tQuestion 32 => " << defChoiceB << " is the answer" << " not " << charQuestion32  << endl;
			}

    if (charQuestion33 == 67 || charQuestion33 == 99)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 33 => " << defChoiceC << " is the answer" << " not " << charQuestion33 << endl;
		my << "\tQuestion 33 => " << defChoiceC << " is the answer" << " not " << charQuestion33  << endl;
			}


    if (charQuestion34 == 68 || charQuestion34 == 100)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 34 => " << defChoiceD << " is the answer" << " not " << charQuestion34 << endl;
		my << "\tQuestion 34 => " << defChoiceD << " is the answer" << " not " << charQuestion34  << endl;
			}



    if (charQuestion35 == 65 || charQuestion35 == 97)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 35 => " << defChoiceA << " is the answer" << " not " << charQuestion35 << endl;
		my << "\tQuestion 35 => " << defChoiceA << " is the answer" << " not " << charQuestion35  << endl;
			}

    if (charQuestion36 == 65 || charQuestion36 == 97)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 36 => " << defChoiceA << " is the answer" << " not " << charQuestion36 << endl;
		my << "\tQuestion 36 => " << defChoiceA << " is the answer" << " not " << charQuestion36  << endl;
			}

if (charQuestion37 == 66 || charQuestion37 == 98)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 37 => " << defChoiceB << " is the answer" << " not " << charQuestion37 << endl;
		my << "\tQuestion 37 => " << defChoiceB << " is the answer" << " not " << charQuestion37  << endl;
			}

    if (charQuestion38 == 67 || charQuestion38 == 99)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 38 => " << defChoiceC << " is the answer" << " not " << charQuestion38 << endl;
		my << "\tQuestion 38 => " << defChoiceC << " is the answer" << " not " << charQuestion38  << endl;
			}


    if (charQuestion39 == 68 || charQuestion39 == 100)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 39 => " << defChoiceD << " is the answer" << " not " << charQuestion39 << endl;
		my << "\tQuestion 39 => " << defChoiceD << " is the answer" << " not " << charQuestion39  << endl;
			}



    if (charQuestion40 == 65 || charQuestion40 == 97)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 40 => " << defChoiceA << " is the answer" << " not " << charQuestion40 << endl;
		my << "\tQuestion 40 => " << defChoiceA << " is the answer" << " not " << charQuestion40  << endl;
			}


		if (charQuestion41 == 65 || charQuestion41 == 97)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 41 => " << defChoiceA << " is the answer" << " not " << charQuestion41 << endl;
		my << "\tQuestion 41 => " << defChoiceA << " is the answer" << " not " << charQuestion41  << endl;
			}

if (charQuestion42 == 66 || charQuestion42 == 98)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 42 => " << defChoiceB << " is the answer" << " not " << charQuestion42 << endl;
		my << "\tQuestion 42 => " << defChoiceB << " is the answer" << " not " << charQuestion42  << endl;
			}

    if (charQuestion43 == 67 || charQuestion43 == 99)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 43 => " << defChoiceC << " is the answer" << " not " << charQuestion43 << endl;
		my << "\tQuestion 43 => " << defChoiceC << " is the answer" << " not " << charQuestion43  << endl;
			}


    if (charQuestion44 == 68 || charQuestion44 == 100)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 44 => " << defChoiceD << " is the answer" << " not " << charQuestion44 << endl;
		my << "\tQuestion 44 => " << defChoiceD << " is the answer" << " not " << charQuestion44  << endl;
			}



    if (charQuestion45 == 65 || charQuestion45 == 97)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 45 => " << defChoiceA << " is the answer" << " not " << charQuestion45 << endl;
		my << "\tQuestion 45 => " << defChoiceA << " is the answer" << " not " << charQuestion45  << endl;
			}

    if (charQuestion46 == 65 || charQuestion46 == 97)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 46 => " << defChoiceA << " is the answer" << " not " << charQuestion46 << endl;
		my << "\tQuestion 46 => " << defChoiceA << " is the answer" << " not " << charQuestion46  << endl;
			}

if (charQuestion47 == 66 || charQuestion47 == 98)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 47 => " << defChoiceB << " is the answer" << " not " << charQuestion47 << endl;
		my << "\tQuestion 47 => " << defChoiceB << " is the answer" << " not " << charQuestion47  << endl;
			}

    if (charQuestion48 == 67 || charQuestion48 == 99)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 48 => " << defChoiceC << " is the answer" << " not " << charQuestion48 << endl;
		my << "\tQuestion 48 => " << defChoiceC << " is the answer" << " not " << charQuestion48  << endl;
			}


    if (charQuestion49 == 68 || charQuestion49 == 100)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 49 => " << defChoiceD << " is the answer" << " not " << charQuestion49 << endl;
		my << "\tQuestion 49 => " << defChoiceD << " is the answer" << " not " << charQuestion49  << endl;
			}



    if (charQuestion50 == 65 || charQuestion50 == 97)
            {
         count += 1;


		}
	else
		{
		count += 0;
		cout << "\t";	cout << "Question 50 => " << defChoiceA << " is the answer" << " not " << charQuestion50 << endl;
		my << "\tQuestion 50 => " << defChoiceA << " is the answer" << " not " << charQuestion50  << endl;
			}

    cout << "\n" << endl;
    /**RESULT*/

    cout << "\n" << endl;
    /**RESULT*/

    cout << "\tAGRICULTURE GRADE 5 TEST 1\n" << endl;

    cout << "\t" <<userName << " " << surname << "\n" << endl;

    cout << "\tYour result is : " << endl;
		cout << "\t";	cout << count << " out of " << Total50 << endl;

     my << "\n" << endl;
     my << "\tAGRICULTURE GRADE 5 TEST 1" << endl;

     my << "\n\t" << endl;

     my << "\t" << userName << " " << surname << "\n" << endl;

		my << "\tYour result is : " << endl;
		my << "\t";my << count << " out of " << Total50 << endl;

			cin.ignore(10, '\n');
			cin.get();


}

void scienceGrade3Paper2(void)
{


}



int main(int nNumberofArgs, char* pszArgs[])
{
    cout << "\t"; cout << "****************************************************************************************" << endl;
    cout << "" << endl;
    cout << "                              E  X  A  M  I  N  A  T  I  O  N" << endl;
    cout << "" << endl;

    cout << "\t"; cout << "****************************************************************************************" << endl;
    cout << "" << endl;

    identifyYourself();

    cout << "\t"; cout << "SELECT YOUR SEARCH CRITERIA" << endl;
    cout << "" << endl;
    cout << "\t"; cout << " SELECT " << endl;
    cout << "" << endl;



    cout << "\t"; cout << "1  => Grade 3" << endl;
    cout << "\t"; cout << "2  => Grade 4" << endl;
    cout << "\t"; cout << "3  => Grade 5" << endl;
    cout << "\t"; cout << "4  => Grade 6" << endl;
    cout << "\t"; cout << "5  => Grade 7" << endl;
    cout << "\t"; cout << "10 => INFORMATION TECHNOLOGY" << endl;
    cout << "\t" << endl;
    cout << "\t"; cin >> setw(3) >> answer;
    cout << "\t" << endl;

/**IF STATEMENT TO SELECT SUBJECT OPTIONS*/
    if (answer == 1)
            {
        cout << strGrade3;

        cout << "\t"; cin >> setw(1) >> option;

        cout << "\t" << endl;

        /**SELECT TEST*/
        if(option == '1')
        {
            //AgricultureGrade3Test1();
        }
        else if(option == '2')
        {
           // htmlTest1();
        }

        }
    else if(answer == 2)
    {
        cout << strGrade4;

        cout << "\t"; cin >> setw(1) >> option;

        cout << "\t" << endl;

        /**SELECT TEST*/
        if(option == '1')
        {
            //AgricultureGrade4Test1();
        }
        else if(option == '2')
        {
           // htmlTest1();
        }
    }

    else if(answer == 3)
    {
        cout << strGrade5;

        cout << "\t"; cin >> setw(1) >> option;

        cout << "\t" << endl;

        /**SELECT TEST*/
        if(option == '1')
        {
            AgricultureGrade5Test1();
        }
        else if(option == '2')
        {
           // htmlTest1();
        }
    }

    else if(answer == 10)
    {
        cout << strBITH;

        cout << "\t"; cin >> setw(3) >> option;

        cout << "\t" << endl;

        /**SELECT TEST*/
        if(option == '1')
        {

            htmlTest1();
        }
        else if(option == '2')
        {
           // ccnaTest1();
        }
    }

}
