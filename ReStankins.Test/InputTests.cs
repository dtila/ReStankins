using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ReStankins.Test
{
    [TestClass]
    public class InputTests
    {
        [TestMethod]
        public void WhenTables_AreMany_TheyAreMerged()
        {
            var table1 = new Table(1, 1);
            var table2 = new Table(2, 2);

            var accesible = new AccesibleTestTransformer();
            using (var transformation = new MergeTwoTablesTransformation(accesible, "dummy"))
            {
                table1.AppendTo(transformation);
                table2.AppendTo(transformation);
            }

            Assert.AreEqual(accesible.Tables.Count, 1);
            Assert.AreEqual(accesible.Trees.Count, 0);
            Assert.AreEqual(accesible.Tables[0].Rows, 3);
            Assert.AreEqual(accesible.Tables[0].Columns, 3);
        }
    }


}
