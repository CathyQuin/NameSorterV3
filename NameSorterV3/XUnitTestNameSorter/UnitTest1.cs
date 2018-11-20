using System;
using Xunit;
using NameSorterV3;

namespace XUnitTestNameSorter {
    public class UnitTest1 {
        /* Testing Person class */
        public class UT1TestPerson {

            [Fact]
            public void PersonObjectIsCreatedWithPrintName() {

                string TestData = "Cathy Ferguson";

                IListItem TestPerson = Factory.CreateListItem(TestData);
                Assert.True(TestPerson.GetDisplayValue() == TestData);
            }

            [Fact]
            public void PersonObjectIsCreatedWithSortName() {

                string TestData = "Cathryn Gaye Ferguson";
                string AnswerData = "Ferguson Cathryn Gaye";

                IListItem TestPerson = Factory.CreateListItem(TestData);
                Assert.True(TestPerson.GetSortValue() == AnswerData);
            }
        }

        /* Testing PersonList class */
        public class UT2TestPersonList {

            [Fact]
            public void ListObjectIsCreated() {

                ISortList TestList = Factory.CreateSortList();
                int tempNum = TestList.ListCount();
                Assert.True(tempNum == 0);
            }

            [Fact]
            public void ListObjectHasOneRecord() {

                ISortList TestList = Factory.CreateSortList();
                string TestData1 = "Lady Madonna";
                TestList.AddPerson(TestData1);

                Assert.True(TestList.GetItemDisplayName(0) == TestData1);
            }

            [Fact]
            public void ListObjectIsSorted() {
                ISortList TestList = Factory.CreateSortList();

                string TestData1 = "Lady Madonna";
                string TestData2 = "Joe Andrew Smith";
                string TestData3 = "Apple Fruitcake";
                string TestData4 = "Lumpy Lumbah";
                string TestData5 = "Donny Dumbo";

                TestList.AddPerson(TestData1);
                TestList.AddPerson(TestData2);
                TestList.AddPerson(TestData3);
                TestList.AddPerson(TestData4);
                TestList.AddPerson(TestData5);

                TestList.DoSorting();

                Assert.True(TestList.GetItemDisplayName(0) == TestData5); // Dumbo, Donny
                Assert.True(TestList.GetItemDisplayName(1) == TestData3); // Fruitcake, Apple
                Assert.True(TestList.GetItemDisplayName(2) == TestData4); // Lumbah, Lumpy
                Assert.True(TestList.GetItemDisplayName(3) == TestData1); // Madonna, Lady
                Assert.True(TestList.GetItemDisplayName(4) == TestData2); // Smith, Joe Andrew

            }
        }

        /* Testing ListReader class */
        /*       public class UT3TestListReader {

                   readonly string FileLocation = "./unsorted-names-list.txt";

                   [Fact]
                   public void ListReaderIsCreated() {
                       ListReader MyReader = new ListReader(FileLocation);
                       Assert.True(MyReader != null);
                   }

                   [Fact]
                   public void ListReaderIsFilled() {
                       ListReader MyReader = new ListReader(FileLocation);
                       string MyOutput = MyReader.OutputList();
                       Assert.True(MyOutput != "");
                   }
               }
         */
    }
}

