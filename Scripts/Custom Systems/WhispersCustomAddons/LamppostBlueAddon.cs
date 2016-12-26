
////////////////////////////////////////
//                                    //
//   Generated by CEO's YAAAG - V1.2  //
// (Yet Another Arya Addon Generator) //
//                                    //
////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class LamppostBlueAddon : BaseAddon
	{
         
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new LamppostBlueAddonDeed();
			}
		}

		[ Constructable ]
		public LamppostBlueAddon()
		{



			AddComplexComponent( (BaseAddon) this, 3976, 0, 0, 1, 0, -1, "vines", 1);// 1
			AddComplexComponent( (BaseAddon) this, 3976, 0, 0, 15, 0, -1, "vines", 1);// 2
			AddComplexComponent( (BaseAddon) this, 3976, 0, 0, 9, 0, -1, "vines", 1);// 3
			AddComplexComponent( (BaseAddon) this, 4180, 0, 0, 15, 188, -1, "morning glories", 1);// 4
			AddComplexComponent( (BaseAddon) this, 4179, 0, 0, 4, 188, -1, "morning glories", 2);// 5
			AddComplexComponent( (BaseAddon) this, 4176, 0, 0, 12, 188, -1, "morning glory", 1);// 6
			AddComplexComponent( (BaseAddon) this, 2848, 0, 0, 0, 0, 1, "", 1);// 7
			AddComplexComponent( (BaseAddon) this, 4175, 0, 0, 5, 188, -1, "morning glory", 1);// 8

		}

		public LamppostBlueAddon( Serial serial ) : base( serial )
		{
		}

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource)
        {
            AddComplexComponent(addon, item, xoffset, yoffset, zoffset, hue, lightsource, null, 1);
        }

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource, string name, int amount)
        {
            AddonComponent ac;
            ac = new AddonComponent(item);
            if (name != null && name.Length > 0)
                ac.Name = name;
            if (hue != 0)
                ac.Hue = hue;
            if (amount > 1)
            {
                ac.Stackable = true;
                ac.Amount = amount;
            }
            if (lightsource != -1)
                ac.Light = (LightType) lightsource;
            addon.AddComponent(ac, xoffset, yoffset, zoffset);
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

	public class LamppostBlueAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new LamppostBlueAddon();
			}
		}

		[Constructable]
		public LamppostBlueAddonDeed()
		{
			Name = "LamppostBlue";
		}

		public LamppostBlueAddonDeed( Serial serial ) : base( serial )
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