/////////////////////////////////////////////////
//                                             //
// Automatically generated by the              //
// AddonGenerator script by Arya               //
//                                             //
/////////////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class FireplaceNewSandstone1Addon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new FireplaceNewSandstone1AddonDeed();
			}
		}

		[ Constructable ]
		public FireplaceNewSandstone1Addon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 1181 );
			AddComponent( ac, -2, 0, 0 );
			ac = new AddonComponent( 1181 );
			AddComponent( ac, -2, 1, 0 );
			ac = new AddonComponent( 1181 );
			AddComponent( ac, 3, 1, 0 );
			ac = new AddonComponent( 1181 );
			AddComponent( ac, 3, 0, 0 );
			ac = new AddonComponent( 1181 );
			AddComponent( ac, 3, -1, 0 );
			ac = new AddonComponent( 1181 );
			AddComponent( ac, 2, -1, 0 );
			ac = new AddonComponent( 1181 );
			AddComponent( ac, -2, -1, 0 );
			ac = new AddonComponent( 1181 );
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 1181 );
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 1181 );
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 1181 );
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 1181 );
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 1181 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 1181 );
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 1181 );
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 1181 );
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 1181 );
			AddComponent( ac, 2, 0, 0 );
			ac = new AddonComponent( 1181 );
			AddComponent( ac, 2, 1, 0 );
			ac = new AddonComponent( 350 );
			AddComponent( ac, 2, 0, 0 );
			ac = new AddonComponent( 351 );
			AddComponent( ac, -2, 0, 0 );
			ac = new AddonComponent( 352 );
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 352 );
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 352 );
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 352 );
			AddComponent( ac, 2, -1, 0 );
			ac = new AddonComponent( 352 );
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 353 );
			AddComponent( ac, -2, -1, 0 );
			ac = new AddonComponent( 365 );
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 368 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 351 );
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 351 );
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 407 );
			AddComponent( ac, 0, 0, 15 );
			ac = new AddonComponent( 407 );
			AddComponent( ac, 1, 0, 15 );
			ac = new AddonComponent( 1981 );
			ac.Hue = 1108;
			ac.Name = "Hearth";
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 1981 );
			ac.Hue = 1108;
			ac.Name = "Hearth";
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 1981 );
			ac.Hue = 1108;
			ac.Name = "Hearth";
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 1981 );
			ac.Hue = 1108;
			ac.Name = "Hearth";
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 1981 );
			ac.Hue = 1108;
			ac.Name = "Hearth";
			AddComponent( ac, 2, 1, 0 );
			ac = new AddonComponent( 1981 );
			ac.Hue = 1108;
			ac.Name = "Hearth";
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 0, 0, 1 );
			ac = new AddonComponent( 1305 );
			AddComponent( ac, 1, 0, 1 );
			ac = new AddonComponent( 407 );
			AddComponent( ac, 2, 1, 0 );
			ac = new AddonComponent( 407 );
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 407 );
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 407 );
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 408 );
			AddComponent( ac, 2, 1, 0 );
			ac = new AddonComponent( 408 );
			AddComponent( ac, -2, 1, 0 );
			ac = new AddonComponent( 408 );
			AddComponent( ac, 3, 0, 0 );
			ac = new AddonComponent( 407 );
			AddComponent( ac, 3, 0, 0 );
			ac = new AddonComponent( 407 );
			AddComponent( ac, 3, -1, 3 );
			ac = new AddonComponent( 407 );
			AddComponent( ac, 3, -1, 0 );
			ac = new AddonComponent( 408 );
			AddComponent( ac, 3, 0, 2 );
			ac = new AddonComponent( 1251 );
			ac.Hue = 1108;
			AddComponent( ac, 3, 0, 3 );
			ac = new AddonComponent( 7138 );
			AddComponent( ac, 3, 0, 2 );
			ac = new AddonComponent( 7134 );
			AddComponent( ac, 0, 0, 1 );
			ac = new AddonComponent( 3561 );
			ac.Light = LightType.Circle225;
			AddComponent( ac, 0, 0, 4 );
			ac = new AddonComponent( 3561 );
			ac.Light = LightType.Circle225;
			AddComponent( ac, 1, 1, 13 );
			ac = new AddonComponent( 6572 );
			ac.Light = LightType.Circle225;
			AddComponent( ac, 0, 0, 6 );
			ac = new AddonComponent( 11632 );
			ac.Name = "tapestry";
			AddComponent( ac, 2, 1, 0 );
			ac = new AddonComponent( 11632 );
			ac.Name = "tapestry";
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 2564 );
			ac.Light = LightType.Circle225;
			AddComponent( ac, 2, 1, 14 );
			ac = new AddonComponent( 2564 );
			ac.Light = LightType.Circle225;
			AddComponent( ac, -1, 1, 14 );
			ac = new AddonComponent( 1181 );
			AddComponent( ac, -2, 2, 0 );
			ac = new AddonComponent( 1181 );
			AddComponent( ac, -1, 2, 0 );
			ac = new AddonComponent( 1181 );
			AddComponent( ac, 0, 2, 0 );
			ac = new AddonComponent( 1181 );
			AddComponent( ac, 1, 2, 0 );
			ac = new AddonComponent( 1181 );
			AddComponent( ac, 2, 2, 0 );
			ac = new AddonComponent( 1181 );
			AddComponent( ac, 3, 2, 0 );

		}

		public FireplaceNewSandstone1Addon( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class FireplaceNewSandstone1AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new FireplaceNewSandstone1Addon();
			}
		}

		[Constructable]
		public FireplaceNewSandstone1AddonDeed()
		{
			Name = "FireplaceNewSandstone1";
		}

		public FireplaceNewSandstone1AddonDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void	Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}