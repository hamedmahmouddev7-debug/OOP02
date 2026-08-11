using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment02
{
    public class DeliveryCenter
    {
        //private Shipment[] shipments;

        //public string CenterName { get; set; }

        //public DeliveryCenter(string centerName)
        //{
        //    CenterName = centerName;
        //    shipments = new Shipment[20];
        //}

      
        //public Shipment this[int index]
        //{
        //    get
        //    {
        //        if (index >= 0 && index < shipments.Length)
        //        {
        //            return shipments[index];
        //        }

        //        return null;
        //    }

        //    set
        //    {
        //        if (index >= 0 && index < shipments.Length)
        //        {
        //            shipments[index] = value;
        //        }
        //    }
        //}

        
        //public Shipment this[string trackingCode]
        //{
        //    get
        //    {
        //        for (int i = 0; i < shipments.Length; i++)
        //        {
        //            if (shipments[i] != null &&
        //                shipments[i].TrackingCode == trackingCode)
        //            {
        //                return shipments[i];
        //            }
        //        }

        //        return null;
        //    }
        //}

  
        //public bool AddShipment(Shipment shipment)
        //{
        //    for (int i = 0; i < shipments.Length; i++)
        //    {
        //        if (shipments[i] == null)
        //        {
        //            shipments[i] = shipment;
        //            return true;
        //        }
        //    }

        //    return false;
        //}

      
        //public bool RemoveShipment(string trackingCode)
        //{
        //    for (int i = 0; i < shipments.Length; i++)
        //    {
        //        if (shipments[i] != null &&
        //            shipments[i].TrackingCode == trackingCode)
        //        {
        //            shipments[i] = null;
        //            return true;
        //        }
        //    }

        //    return false;
        //}

      
        //public void PrintAllShipments()
        //{
        //    Console.WriteLine($"===== {CenterName} =====");

        //    for (int i = 0; i < shipments.Length; i++)
        //    {
        //        if (shipments[i] != null)
        //        {
        //            Console.WriteLine();
        //            shipments[i].PrintShipment();
        //        }
        //    }
        //}
    }
}
