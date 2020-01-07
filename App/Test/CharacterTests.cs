using App;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Test
{
    public class CharacterTests
    {
        public class NameTests
        {
            [Fact]
            public void GetsName()
            {
                // Arrange
                string charName = "Grungo";
                Character character = new Character(charName);

                // Act
                string actual = character.Name;

                // Assert
                Assert.Equal(charName, actual);
            }

            [Fact]
            public void SetsName()
            {
                // Arrange
                string charName = "Grungo";
                Character character = new Character("");

                // Act
                character.Name = charName;
                string actual = character.Name;

                // Assert
                Assert.Equal(charName, actual);
            }
        }

        public class AlignmentTests
        {
            [Fact]
            public void GetsAlignment()
            {
                // Arrange
                Alignment alignment = Alignment.Neutral;
                Character character = new Character();

                // Act
                Alignment actual = character.Alignment;

                // Assert
                Assert.Equal(alignment, actual);
            }

            [Fact]
            public void SetsAlignment()
            {
                // Arrange
                Alignment alignment = Alignment.Evil;
                Character character = new Character();

                // Act
                character.Alignment = alignment;
                Alignment actual = character.Alignment;

                // Assert
                Assert.Equal(alignment, actual);
            }

            [Theory]
            [InlineData(Alignment.Neutral)]
            [InlineData(Alignment.Good)]
            [InlineData(Alignment.Evil)]
            public void ValidValues(Alignment alignment)
            {
                // Arrange
                Character character = new Character();

                // Act
                character.Alignment = alignment;
                Alignment actual = character.Alignment;

                // Assert
                Assert.Equal(alignment, actual);
            }
        }

        public class ArmorClassTests
        {
            [Fact]
            public void DefaultIs10()
            {
                // Arrange
                int armorClass = 10;
                Character character = new Character();

                // Act
                int actual = character.ArmorClass;

                // Assert
                Assert.Equal(armorClass, actual);
            }

            //[Fact]
            //public void SetsArmorClass()
            //{
            //    // Arrange
            //    Alignment alignment = Alignment.Evil;
            //    Character character = new Character();

            //    // Act
            //    character.Alignment = alignment;
            //    Alignment actual = character.Alignment;

            //    // Assert
            //    Assert.Equal(alignment, actual);
            //}
        }
    }
}
