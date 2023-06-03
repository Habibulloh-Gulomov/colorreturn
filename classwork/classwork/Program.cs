using classwork;
using System.Collections;
using System.Collections.Generic;

//ArrayList arList = new ArrayList()
//{
//    1,"bill",300,4.5F
//};
//foreach (var item in  arList)
//{

//    Console.WriteLine(item);
//}

//for (int i = 0; i < arList.Count; i++)
//{
//    Console.WriteLine(arList[i]);
//}


var colors = new Dictionary<string, int>
{
    {"black",0 },
    {"brown",1 },
    {"red",2 },
    {"orange",3 },
    {"yellow",4 },
    {"green",5 },
    {"blue",6 },
    {"violet",7 },
    {"grey",8 },
    {"white",9 }
};
var inner = colors["grey"]; // type color
var result = ColorReturn.ColorNumReturn(colors["black"]);

Console.WriteLine(result);