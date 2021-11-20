using DotnetLightsaberFight.Fighter;
using NUnit.Framework;

namespace DotnetLightsaberFight.Test
{
   [TestFixture]

   public class TestLuke
   {
      IFighter luke;

      [SetUp]
      public void Setup( )
      {
         //Arrange
         luke = new Luke( );
      }

      [Test]
      public void TestLightsaber_colorIsGreen( )
      {
         //Arrange

         //Act
         var actualLightsaber = luke.Lightsaber;

         //Assert
         var actualColor = actualLightsaber.Color;
         Assert.AreEqual( LightsaberColor.Green, actualColor );
      }

      [Test]
      public void TestName_nameIsLuke( )
      {
         //Arrange

         //Act
         var actualName = luke.Name;

         //Assert
         Assert.AreEqual( "Luke", actualName );
      }

      [Test]
      public void TestVitality_vitalityIs80( )
      {
         //Act
         var actualVitality = luke.Vitality;

         //Assert
         Assert.AreEqual( 80, actualVitality );
      }

   }
}