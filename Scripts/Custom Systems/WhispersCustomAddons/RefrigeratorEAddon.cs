// Automatically generated by the
// AddonGenerator script by Arya
// Generator edited 10.Mar.07 by Papler
using System;
using Server;
using Server.Items;
namespace Server.Items
{
	public class RefrigeratorEAddon : BaseAddon {
		public override BaseAddonDeed Deed{get{return new RefrigeratorEAddonDeed();}}
		[ Constructable ]
		public RefrigeratorEAddon()
		{
			AddonComponent ac = null;
			ac = new AddonComponent( 1179 );
			ac.Hue = 1150;
			ac.Name = "Refrigerator";
			AddComponent( ac, 0, 0, 10 );

			ac = new AddonComponent( 7833 );
			ac.Hue = 962;
			ac.Name = "Refrigerator";
			AddComponent( ac, 1, 1, 11 );

			ac = new AddonComponent( 7833 );
			ac.Hue = 962;
			ac.Name = "Refrigerator";
			AddComponent( ac, 1, 1, 17 );

			ac = new AddonComponent( 1801 );
			ac.Hue = 1150;
			ac.Name = "Refrigerator";
			AddComponent( ac, 0, 0, 5 );

			ac = new AddonComponent( 1801 );
			ac.Hue = 1150;
			ac.Name = "Refrigerator";
			AddComponent( ac, 0, 0, 11 );

			ac = new AddonComponent( 1801 );
			ac.Hue = 1150;
			ac.Name = "Refrigerator";
			AddComponent( ac, 0, 0, 0 );


		}
		public RefrigeratorEAddon( Serial serial ) : base( serial ){}
		public override void Serialize( GenericWriter writer ){base.Serialize( writer );writer.Write( 0 );}
		public override void Deserialize( GenericReader reader ){base.Deserialize( reader );reader.ReadInt();}
	}

	public class RefrigeratorEAddonDeed : BaseAddonDeed {
		public override BaseAddon Addon{get{return new RefrigeratorEAddon();}}
		[Constructable]
		public RefrigeratorEAddonDeed(){Name = "RefrigeratorE";}
		public RefrigeratorEAddonDeed( Serial serial ) : base( serial ){}
		public override void Serialize( GenericWriter writer ){	base.Serialize( writer );writer.Write( 0 );}
		public override void	Deserialize( GenericReader reader )	{base.Deserialize( reader );reader.ReadInt();}
	}
}