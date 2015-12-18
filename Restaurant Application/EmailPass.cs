using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Application
{
    class EmailPass
    {
    string _firstname;
    string _lastname;


    public EmailPass(string firstname, string pass )
	{
        _firstname = firstname;
        _lastname = pass;
	}


    public string Firstname
    {
        get { return _firstname; }
        set { _firstname = value; }
    }
    public string Lastname
    {
        get { return _lastname; }
        set { _lastname = value; }
    }
    }
}
