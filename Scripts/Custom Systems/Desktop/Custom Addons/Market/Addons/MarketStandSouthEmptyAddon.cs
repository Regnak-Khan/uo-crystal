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
	public class AG_MarketStandSouthEmptyAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new AG_MarketStandSouthEmptyAddonDeed();
			}
		}

		[ Constructable ]
		public AG_MarketStandSouthEmptyAddon()
		{
			AddComponent( new AddonComponent( 2938 ), 0, 0, 1 );
			AddComponent( new AddonComponent( 6787 ), 0, -1, 0 );
			AddComponent( new AddonComponent( 2938 ), 0, -1, 1 );
			AddComponent( new AddonComponent( 6786 ), 0, 2, 0 );
			AddComponent( new AddonComponent( 6787 ), 0, 1, 0 );
			AddComponent( new AddonComponent( 2938 ), 0, 1, 1 );
			AddonComponent ac;
			ac = new AddonComponent( 6787 );
			ac.Name = "marketstand";
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 6787 );
			ac.Name = "marketstand";
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 2938 );
			ac.Name = "marketstand";
			AddComponent( ac, 0, 1, 1 );
			ac = new AddonComponent( 2938 );
			ac.Name = "marketstand";
			AddComponent( ac, 0, 0, 1 );
			ac = new AddonComponent( 2938 );
			ac.Name = "marketstand";
			AddComponent( ac, 0, -1, 1 );
			ac = new AddonComponent( 6786 );
			AddComponent( ac, 0, 2, 0 );

		}

		public AG_MarketStandSouthEmptyAddon( Serial serial ) : base( serial )
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

	public class AG_MarketStandSouthEmptyAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new AG_MarketStandSouthEmptyAddon();
			}
		}

		[Constructable]
		public AG_MarketStandSouthEmptyAddonDeed()
		{
			Name = "AG_MarketStandSouthEmpty";
		}

		public AG_MarketStandSouthEmptyAddonDeed( Serial serial ) : base( serial )
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