using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class CombatTests
{
    // A Test behaves as an ordinary method

    [Test]
    public void CombatWinnerTests()
    {
        Unit test1Char = new Unit();
        Unit test2Char = new Unit();
        Unit test3Char = new Unit();

        Unit oponent1char = new Unit();
        Unit oponent2char = new Unit();
        Unit oponent3char = new Unit();

        //en este caso gana el "jugador"
        test1Char.level = 5;
        test1Char.UnitName = "TestPlayer 1";
        oponent1char.level = 3;
        oponent1char.UnitName = "TestOponent 1";

        //en este caso pierde el "jugador"
        test2Char.level = 5;
        test1Char.UnitName = "TestPlayer 2";
        oponent2char.level = 5;
        oponent2char.UnitName = "TestOponent 2";

        //en este caso pierde el "jugador"
        test3Char.level = 3;
        test1Char.UnitName = "TestPlayer 3";
        oponent3char.level = 5;
        oponent3char.UnitName = "TestOponent 3";


        Assert.AreEqual(test1Char.UnitName, test1Char.Combat(oponent1char).UnitName); // la idea es que devuelva la unidad que gan� y se compara el nombre con el quese espera que gane

        Assert.AreEqual(oponent2char.UnitName, test2Char.Combat(oponent2char).UnitName);

        Assert.AreEqual(oponent3char.UnitName, test3Char.Combat(oponent3char).UnitName);


        // Use the Assert class to test conditions
    }

    [Test]

    public void TestWinnnerLevel()
    {
        Unit test1Char = new Unit();
        Unit test2Char = new Unit();
        Unit test3Char = new Unit();

        Unit oponent1char = new Unit();
        Unit oponent2char = new Unit();
        Unit oponent3char = new Unit();

        //en este caso gana el "jugador"
        test1Char.level = 5;
        test1Char.UnitName = "TestPlayer 1";
        oponent1char.level = 3;
        oponent1char.UnitName = "TestOponent 1";

        //en este caso pierde el "jugador"
        test2Char.level = 5;
        test1Char.UnitName = "TestPlayer 2";
        oponent2char.level = 5;
        oponent2char.UnitName = "TestOponent 2";

        //en este caso pierde el "jugador"
        test3Char.level = 3;
        test1Char.UnitName = "TestPlayer 3";
        oponent3char.level = 5;
        oponent3char.UnitName = "TestOponent 3";

        Assert.AreEqual(8, test1Char.Combat(oponent1char).level); // la idea es que devuelva la unidad que gan� y se compara el nivel con el que se espera

        Assert.AreEqual(10, test2Char.Combat(oponent2char).level);

        Assert.AreEqual(8, test3Char.Combat(oponent3char).level);
    }


}
