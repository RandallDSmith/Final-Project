namespace Final_Project.Models
{
    public class CardInfo
    {
        public class AverageOneDay
        {
            public string? currencyCode { get; set; }
            public int? amountInMinorUnits { get; set; }
        }

        public class AverageSellPrice
        {
            public string? currencyCode { get; set; }
            public int? amountInMinorUnits { get; set; }
        }

        public class AverageSevenDay
        {
            public string? currencyCode { get; set; }
            public int? amountInMinorUnits { get; set; }
        }

        public class AverageThirtyDay
        {
            public string? currencyCode { get; set; }
            public int? amountInMinorUnits { get; set; }
        }

        public class CardMarket
        {
            public string? currencyCode { get; set; }
            public string? currencyCodeUsed { get; set; }
            public DateTime? lastUpdatedAt { get; set; }
            public LowPrice? lowPrice { get; set; }
            public AverageSellPrice? averageSellPrice { get; set; }
            public TrendPrice? trendPrice { get; set; }
            public AverageOneDay? averageOneDay { get; set; }
            public AverageSevenDay? averageSevenDay { get; set; }
            public AverageThirtyDay? averageThirtyDay { get; set; }
        }

        public class DirectLow
        {
            public string? currencyCode { get; set; }
            public int? amountInMinorUnits { get; set; }
        }

        public class Ebay
        {
            public string? currencyCode { get; set; }
            public string? priceType { get; set; }
            public List<string>? currenciesUsed { get; set; }
            public DateTime? lastUpdatedAt { get; set; }
            public int? periodSizeDays { get; set; }
            public int? volume { get; set; }
            public StdDev? stdDev { get; set; }
            public MinPrice? minPrice { get; set; }
            public FirstQuartile? firstQuartile { get; set; }
            public Median? median { get; set; }
            public Mean? mean { get; set; }
            public ThirdQuartile? thirdQuartile { get; set; }
            public MaxPrice? maxPrice { get; set; }
        }

        public class FirstQuartile
        {
            public int? amountInMinorUnits { get; set; }
            public string? currencyCode { get; set; }
        }

        public class High
        {
            public string? currencyCode { get; set; }
            public int? amountInMinorUnits { get; set; }
        }

        public class HighListingPrice
        {
            public int? amountInMinorUnits { get; set; }
            public string? currencyCode { get; set; }
        }

        public class HighSoldPrice
        {
            public int? amountInMinorUnits { get; set; }
            public string? currencyCode { get; set; }
        }

        public class ListingPrice
        {
            public int? amountInMinorUnits { get; set; }
            public string? currencyCode { get; set; }
        }

        public class Low
        {
            public string? currencyCode { get; set; }
            public int? amountInMinorUnits { get; set; }
        }

        public class LowListingPrice
        {
            public int? amountInMinorUnits { get; set; }
            public string? currencyCode { get; set; }
        }

        public class LowPrice
        {
            public string? currencyCode { get; set; }
            public int? amountInMinorUnits { get; set; }
        }

        public class LowSoldPrice
        {
            public int? amountInMinorUnits { get; set; }
            public string? currencyCode { get; set; }
        }

        public class Market
        {
            public string? currencyCode { get; set; }
            public int? amountInMinorUnits { get; set; }
        }

        public class MaxListingPrice
        {
            public int? amountInMinorUnits { get; set; }
            public string? currencyCode { get; set; }
        }

        public class MaxPrice
        {
            public int? amountInMinorUnits { get; set; }
            public string? currencyCode { get; set; }
        }

        public class MaxSoldPrice
        {
            public int? amountInMinorUnits { get; set; }
            public string? currencyCode { get; set; }
        }

        public class Mean
        {
            public int? amountInMinorUnits { get; set; }
            public string? currencyCode { get; set; }
        }

        public class Median
        {
            public int? amountInMinorUnits { get; set; }
            public string? currencyCode { get; set; }
        }

        public class Mid
        {
            public string? currencyCode { get; set; }
            public int? amountInMinorUnits { get; set; }
        }

        public class MinListingPrice
        {
            public int? amountInMinorUnits { get; set; }
            public string? currencyCode { get; set; }
        }

        public class MinPrice
        {
            public int? amountInMinorUnits { get; set; }
            public string? currencyCode { get; set; }
        }

        public class MinSoldPrice
        {
            public int? amountInMinorUnits { get; set; }
            public string? currencyCode { get; set; }
        }

        public class Paging
        {
            public int? pageIndex { get; set; }
            public int? pageSize { get; set; }
            public int? count { get; set; }
        }

        public class Prices
        {
            public List<Ebay>? ebay { get; set; }
            public List<CardMarket>? cardMarket { get; set; }
            public List<TcgPlayer>? tcgPlayer { get; set; }
        }

        public class Result
        {
            public string? cardId { get; set; }
            public string? name { get; set; }
            public string? cardNumber { get; set; }
            public string? setNumber { get; set; }
            public string? setId { get; set; }
            public string? set { get; set; }
            public string? series { get; set; }
            public string? variant { get; set; }
            public string? superType { get; set; }
            public List<string>? types { get; set; }
            public List<string>? subTypes { get; set; }
            public string? rarity { get; set; }
            public List<string>? pokemon { get; set; }
            public string? artist { get; set; }
            public MinSoldPrice? minSoldPrice { get; set; }
            public LowSoldPrice? lowSoldPrice { get; set; }
            public SoldPrice? soldPrice { get; set; }
            public HighSoldPrice? highSoldPrice { get; set; }
            public MaxSoldPrice? maxSoldPrice { get; set; }
            public int? soldVolume { get; set; }
            public DateTime? soldLastUpdatedAt { get; set; }
            public MinListingPrice? minListingPrice { get; set; }
            public LowListingPrice? lowListingPrice { get; set; }
            public ListingPrice? listingPrice { get; set; }
            public HighListingPrice? highListingPrice { get; set; }
            public MaxListingPrice? maxListingPrice { get; set; }
            public int? listingVolume { get; set; }
            public DateTime? listingLastUpdatedAt { get; set; }
            public Prices? prices { get; set; }
        }



        public class SoldPrice
        {
            public int? amountInMinorUnits { get; set; }
            public string? currencyCode { get; set; }
        }

        public class StdDev
        {
            public int? amountInMinorUnits { get; set; }
            public string? currencyCode { get; set; }
        }

        public class TcgPlayer
        {
            public string? currencyCode { get; set; }
            public string? currencyCodeUsed { get; set; }
            public DateTime? lastUpdatedAt { get; set; }
            public Low? low { get; set; }
            public Mid? mid { get; set; }
            public High? high { get; set; }
            public DirectLow? directLow { get; set; }
            public Market? market { get; set; }
        }


        public class ThirdQuartile
        {
            public int? amountInMinorUnits { get; set; }
            public string? currencyCode { get; set; }
        }

        public class TrendPrice
        {
            public string? currencyCode { get; set; }
            public int? amountInMinorUnits { get; set; }
        }
    }
}

