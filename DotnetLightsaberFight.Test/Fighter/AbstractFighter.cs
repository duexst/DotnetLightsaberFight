using DotnetLightsaberFight.Fighter;
using NUnit.Framework;

namespace DotnetLightsaberFight.Test
{
   [TestFixture]

   public class TestAbstractFighter
   {
      //Arrange
      public class UnknownFighter : AbstractFighter
      {
         public UnknownFighter() : base("Unknown", 100, new[] { Aim.Defense, Aim.Attack } ) { }
      }

      //Arrange
      IFighter unknown;

      [SetUp]
      public void Setup( )
      {
         //Arrange
         unknown = new UnknownFighter( );
      }

      [Test]
      public void TestLightsaber_ColorIsUnknown( )
      {
         //Arrange
         //Act
         var actualColor = unknown.Lightsaber.Color;
         //Assert
         Assert.AreEqual( LightsaberColor.Unknown, actualColor );
      }

      [Test]
      public void TestChangeVitality_IsChangedAccordingly( )
      {
         //Arrange
         //Act
         unknown.ChangeVitality( -20 );
         var actualVitality = unknown.Vitality;
         //Assert
         // Assert.AreEqual( 100 - 20, actualVitality );
         Assert.AreEqual(100 - 30, actualVitality);
      }

      [Test]
      public void TestIsDead_isTrueWhen0( )
      {
         //Arrange
         //Act
         unknown.ChangeVitality( -unknown.Vitality );
         var actualDeadness = unknown.IsDead();
         //Assert
         Assert.IsTrue( actualDeadness );
      }

      /*
      [Test]
      public void TestNextAim_iterateArrayCorrectly( )
      {
         //Arrange
         //Act
         Aim actualAim1 = unknown.NextAim( );
         Aim actualAim2 = unknown.NextAim( );
         Aim actualAim3 = unknown.NextAim( );
         //Assert
         Assert.AreEqual( Aim.Attack, actualAim1, "NextAim1");
         Assert.AreEqual( Aim.Defense, actualAim2, "NextAim2" );
         Assert.AreEqual( Aim.Attack, actualAim3, "NextAim3" );
      }
      */

      //Better
      [Test]
      [TestCase(0, Aim.Attack)]
      [TestCase(1, Aim.Defense)]
      [TestCase(2, Aim.Attack)]
      public void TestNextAim_iterateArrayCorrectly(int n, Aim correct)
      {
         //Arrange (Prepare previous)
         for(int i = 0; i < n; i++)
         {
            unknown.NextAim();
         }

         //Act
         var actualAim = unknown.NextAim();

         //Assert
         Assert.AreEqual(correct, actualAim);
      }

   }
}