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
	public class MarketStandRoofEastAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new MarketStandRoofEastAddonDeed();
			}
		}

		[ Constructable ]
		public MarketStandRoofEastAddon()
		{
            AddonComponent ac;
            ac = new AddonComponent(6792);
            AddComponent(ac, -1, 0, 0);
            ac.Name = "market stand";
            ac = new AddonComponent(2958);
            AddComponent(ac, -1, 0, 1);
            ac.Name = "market stand";
            ac = new AddonComponent(6792);
            AddComponent(ac, 1, 0, 0);
            ac.Name = "market stand";
            ac = new AddonComponent(2958);
            AddComponent(ac, 1, 0, 1);
            ac.Name = "market stand";
            ac = new AddonComponent(2958);
            AddComponent(ac, 0, 0, 1);
            ac.Name = "market stand";
            ac = new AddonComponent(6791);
            AddComponent(ac, 2, 0, 0);
            ac.Name = "market stand";
            ac = new AddonComponent(1448);
            AddComponent(ac, 1, 0, 5);
            ac.Name = "market stand";
            ac = new AddonComponent(1448);
            AddComponent(ac, -1, 0, 5);
            ac.Name = "market stand";
            ac = new AddonComponent(1448);
            AddComponent(ac, 0, 0, 5);
            ac.Name = "market stand";
		}

        public MarketStandRoofEastAddon(Serial serial)
            : base(serial)
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

	public class MarketStandRoofEastAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new MarketStandRoofEastAddon();
			}
		}

		[Constructable]
		public MarketStandRoofEastAddonDeed()
		{
			Name = "roofed marketstand facing east deed";
		}

        public MarketStandRoofEastAddonDeed(Serial serial)
            : base(serial)
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