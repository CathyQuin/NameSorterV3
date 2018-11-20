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
                TestList.AddItem(TestData1);

                Assert.True(TestList.GetItemDisplayValue(0) == TestData1);
            }

            [Fact]
            public void ListObjectIsSorted() {
                ISortList TestList = Factory.CreateSortList();

                string TestData1 = "Lady Madonna";
                string TestData2 = "Joe Andrew Smith";
                string TestData3 = "Apple Fruitcake";
                string TestData4 = "Lumpy Lumbah";
                string TestData5 = "Donny Dumbo";

                TestList.AddItem(TestData1);
                TestList.AddItem(TestData2);
                TestList.AddItem(TestData3);
                TestList.AddItem(TestData4);
                TestList.AddItem(TestData5);

                TestList.DoSorting();

                Assert.True(TestList.GetItemDisplayValue(0) == TestData5); // Dumbo, Donny
                Assert.True(TestList.GetItemDisplayValue(1) == TestData3); // Fruitcake, Apple
                Assert.True(TestList.GetItemDisplayValue(2) == TestData4); // Lumbah, Lumpy
                Assert.True(TestList.GetItemDisplayValue(3) == TestData1); // Madonna, Lady
                Assert.True(TestList.GetItemDisplayValue(4) == TestData2); // Smith, Joe Andrew

            }
        }

        /* Testing ListReader class */
               public class UT3TestListReader {

                   readonly string FileLocation = "./unsorted-names-list.txt";

                   [Fact]
                   public void ListReaderIsCreated() {
                       IListReader MyReader = Factory.CreateListReader(FileLocation);
                       Assert.True(MyReader != null);
                   }

                   [Fact]
                   public void ListReaderIsFilled() {
                       IListReader MyReader = Factory.CreateListReader(FileLocation);
                       string MyOutput = MyReader.OutputList();
                       Assert.True(MyOutput != "");
                   }
               }
         
    }
}

