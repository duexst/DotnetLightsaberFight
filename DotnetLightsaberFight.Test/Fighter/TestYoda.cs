using DotnetLightsaberFight.Fighter;
using NUnit.Framework;

namespace DotnetLightsaberFight.Test
{
   [TestFixture]

   public class TestYoda
   {
      IFighter yoda;

      [SetUp]
      public void Setup( )
      {
         //Arrange
         yoda = new Yoda( );
      }

      [Test]
      public void TestLightsaber_colorIsBlue( )
      {
         //Arrange

         //Act
         var actualLightsaber = yoda.Lightsaber;

         //Assert
         var actualColor = actualLightsaber.Color;
         Assert.AreEqual( LightsaberColor.Blue, actualColor );
      }

      [Test]
      public void TestName_nameIsYoda( )
      {
         //Arrange

         //Act
         var actualName = yoda.Name;

         //Assert
         Assert.AreEqual( "Yoda", actualName );
      }

      [Test]
      public void TestVitality_vitalityIs120( )
      {
         //Act
         var actualVitality = yoda.Vitality;

         //Assert
         Assert.AreEqual( 120, actualVitality );
      }

   }
}