/////////////////////////////////////////////////
//
// Automatically generated by the
// AddonGenerator script by Arya
//
/////////////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class OrnatecouchEAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new OrnatecouchEAddonDeed();
			}
		}

		[ Constructable ]
		public OrnatecouchEAddon()
		{
			AddonComponent ac = null;
			ac = new AddonComponent( 1114 );
			ac.Hue = 46;
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 1114 );
			ac.Hue = 46;
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 1114 );
			ac.Hue = 46;
			AddComponent( ac, 1, 2, 0 );
			ac = new AddonComponent( 11727 );
			ac.Hue = 46;
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 11727 );
			ac.Hue = 46;
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 11727 );
			ac.Hue = 46;
			AddComponent( ac, 0, 2, 0 );
			ac = new AddonComponent( 11728 );
			ac.Hue = 46;
			AddComponent( ac, 1, 2, 1 );
			ac = new AddonComponent( 11728 );
			ac.Hue = 46;
			AddComponent( ac, 1, -1, 1 );
			ac = new AddonComponent( 11503 );
			ac.Hue = 46;
			AddComponent( ac, 0, 2, 5 );
			ac = new AddonComponent( 11503 );
			ac.Hue = 46;
			AddComponent( ac, 0, 0, 5 );
			ac = new AddonComponent( 11503 );
			ac.Hue = 46;
			AddComponent( ac, 0, 1, 5 );
			ac = new AddonComponent( 11210 );
			ac.Hue = 46;
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 5035 );
			ac.Hue = 46;
			AddComponent( ac, 1, 2, 4 );

		}

		public OrnatecouchEAddon( Serial serial ) : base( serial )
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

	public class OrnatecouchEAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new OrnatecouchEAddon();
			}
		}

		[Constructable]
		public OrnatecouchEAddonDeed()
		{
			Name = "OrnatecouchE";
		}

		public OrnatecouchEAddonDeed( Serial serial ) : base( serial )
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