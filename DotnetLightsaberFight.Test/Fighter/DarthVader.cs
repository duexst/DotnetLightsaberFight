using DotnetLightsaberFight.Fighter;
using NUnit.Framework;

namespace DotnetLightsaberFight.Test
{
   [TestFixture]

   public class TestDarthVader
   {
      IFighter darthVader;

      [SetUp]
      public void Setup( )
      {
         //Arrange
         darthVader = new DarthVader( ); 
      }

      [Test]
      public void TestLightsaber_colorIsRed( )
      {
         //Arrange

         //Act
         var actualLightsaber = darthVader.Lightsaber;

         //Assert
         var actualColor = actualLightsaber.Color;
         Assert.AreEqual( LightsaberColor.Red, actualColor );
      }

      [Test]
      public void TestName_nameIsDarthVader( )
      {
         //Arrange

         //Act
         var actualName = darthVader.Name;

         //Assert
         Assert.AreEqual( "DarthVader", actualName );
      }

      [Test]
      public void TestVitality_vitalityIs100( )
      {
         //Act
         var actualVitality = darthVader.Vitality;

         //Assert
         Assert.AreEqual( 100, actualVitality );
      }

   }
}