using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment02
{
    public class Shipment
    {
        //private string trackingCode;
        //private string description;
        //private decimal weight;
        //private decimal deliveryFee;

        //public string TrackingCode
        //{
        //    get { return trackingCode; }
        //}

        //public string Description
        //{
        //    get { return description; }
        //    set
        //    {
        //        if (!string.IsNullOrWhiteSpace(value))
        //        {
        //            description = value;
        //        }
        //    }
        //}

        //public decimal Weight
        //{
        //    get { return weight; }
        //    set
        //    {
        //        if (value > 0)
        //        {
        //            weight = value;
        //        }
        //    }
        //}

        //public decimal DeliveryFee
        //{
        //    get { return deliveryFee; }
        //    private set
        //    {
        //        if (value > 0)
        //        {
        //            deliveryFee = value;
        //        }
        //    }
        //}

        //public DeliveryAddress Destination { get; set; }

        //public virtual decimal EstimatedCost
        //{
        //    get
        //    {
        //        return DeliveryFee + (Weight * 5);
        //    }
        //}

        //public Shipment(string trackingCode)
        //{
        //    this.trackingCode = trackingCode;
        //    Description = "Unknown";
        //    Weight = 1;
        //    DeliveryFee = 50;
        //    Destination = new DeliveryAddress("Unknown", "Unknown", 0);
        //}

        //public Shipment(
        //    string trackingCode,
        //    string description,
        //    decimal weight,
        //    decimal deliveryFee,
        //    DeliveryAddress destination)
        //{
        //    this.trackingCode = trackingCode;
        //    Description = description;
        //    Weight = weight;
        //    DeliveryFee = deliveryFee;
        //    Destination = destination;
        //}

        //public void UpdateDeliveryFee(decimal newFee)
        //{
        //    if (newFee > 0)
        //    {
        //        DeliveryFee = newFee;
        //    }
        //}

        //public virtual void PrintShipment()
        //{
        //    Console.WriteLine($"Tracking Code: {TrackingCode}");
        //    Console.WriteLine($"Description: {Description}");
        //    Console.WriteLine($"Weight: {Weight} KG");
        //    Console.WriteLine($"Delivery Fee: {DeliveryFee} EGP");
        //    Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
        //    Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }
    }
}
