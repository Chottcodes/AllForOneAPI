using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllForOneAPI.Models;

namespace AllForOneAPI.Services
{
    public class ResturantPickerServices
    {
        public List<FoodModel> MexicanRes = [
            new FoodModel{ Category="Mexican", Name="Chipotle"},
            new FoodModel{ Category="Mexican", Name="FUEGO Taqueria"},
            new FoodModel{ Category="Mexican", Name="Don Luis Mexican Restaurant"},
            new FoodModel{ Category="Mexican", Name="Nena's Mexican Cuisine"},
            new FoodModel{ Category="Mexican", Name="Xochimilco cafe"},
            new FoodModel{ Category="Mexican", Name="Tu Puebilito Taqueria"},
            new FoodModel{ Category="Mexican", Name="El Chilango Chido"},
            new FoodModel{ Category="Mexican", Name="Las Palmas"},
            new FoodModel{ Category="Mexican", Name="Lonchera Hidalgo"},
            new FoodModel{ Category="Mexican", Name="Las Delicias Del Barrio Mexican Food"},
        ];
        public List<FoodModel> IndianFood =[
            new FoodModel{ Category="Indian", Name="Maharaja Indian Cuisine"},
            new FoodModel{ Category="Indian", Name="Mangi da Dhada"},
            new FoodModel{ Category="Indian", Name="Mother india cuisine"},
            new FoodModel{ Category="Indian", Name="Indian cafe restaurant"},
            new FoodModel{ Category="Indian", Name="Royal India Cuisin & Bar"},
            new FoodModel{ Category="Indian", Name="Maharaja Indian Cuisine"},
            new FoodModel{ Category="Indian", Name="Swagat Indian Cuisine"},
            new FoodModel{ Category="Indian", Name="Taste of India"},
            new FoodModel{ Category="Indian", Name="Tandoori Nites Restaurant"},
            new FoodModel{ Category="Indian", Name="Curry on wheels"},
        ];
        public List<FoodModel> ItalianFood = [
            new FoodModel{ Category="Italian", Name="De Vega Brother"},
            new FoodModel{ Category="Italian", Name="Angelina's Spaghetti House"},
            new FoodModel{ Category="Italian", Name="De Parsia's Restaurant & Catering"},
            new FoodModel{ Category="Italian", Name="Pietro's Trattoria"},
            new FoodModel{ Category="Italian", Name="Gian's Delicatessen"},
            new FoodModel{ Category="Italian", Name="Mezzo Restaurant"},
            new FoodModel{ Category="Italian", Name="Papapavlo's Bistro & Bar"},
            new FoodModel{ Category="Italian", Name="The Kitchen @ Stonebrier"},
            new FoodModel{ Category="Italian", Name="De Vinci's Delicatessen"},
            new FoodModel{ Category="Italian", Name="Genova Bakery"},
        ];
         public string FoodPick(string ChooseFoodCategory)
        {
            Random random = new Random();
            if (ChooseFoodCategory.ToLower() != "mexican" && ChooseFoodCategory.ToLower() != "indian" && ChooseFoodCategory.ToLower() != "italian" )
            {
                return "Please Enter catagories mexican,indian,italian";
            }
            switch (ChooseFoodCategory.ToLower())
            {
                case "mexican":
                    int randomfoodIndexMexican = random.Next(0, MexicanRes.Count);
                    string randomResturant = MexicanRes[randomfoodIndexMexican].Name;
                    return randomResturant;
                case "indian":
                    int randomFoodIndexIndian = random.Next(0, IndianFood.Count);
                    string randomIndianResturant = IndianFood[randomFoodIndexIndian].Name;
                    return randomIndianResturant;
                case "italian":
                    int randomFoodIndexItalian = random.Next(0, ItalianFood.Count);
                    string randomItalianResturant = ItalianFood[randomFoodIndexItalian].Name;
                    return randomItalianResturant;
                    default:
                    return "Invalid Category.Please Choose Between mexican,indian,and italian";

            }



        }
    }
}