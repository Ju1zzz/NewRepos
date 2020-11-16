using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 
namespace WindowsFormsApp4
{
    public class Watchable
    {
        public double Timing = 0;
        public virtual String GetInfo()
        {
            var str = String.Format("\nПродолжительность: {0} мин.", this.Timing);
            return str;

        }

        public static Random rnd = new Random();
    }

    public enum MovieType { художественный, ужасы, мелодрамма, мюзикл, комедия, драма, боевик, вестерн, исторический_фильм, триллер, фантастика, фэнтези };
    public class Movie : Watchable
    {
        public int QuantityOfAwards = 0; 
        public MovieType Type = MovieType.художественный;
        public override String GetInfo()
        {
            var str = "Кинофильм";
            str += base.GetInfo();
            str += String.Format("\nКоличество наград: {0}", this.QuantityOfAwards);
            str += String.Format("\nЖанр фильма: {0}", this.Type);
            return str;
        }
        public static Movie Generate()
        {
            return new Movie
            {
                Timing = rnd.Next(70, 190), 
                QuantityOfAwards = rnd.Next(0, 14), 
                Type = (MovieType)rnd.Next(12)
            };
        }
    }
   
    public class TVshow : Watchable
    {
        public int AmountOfEpisodes = 0;
        public int AmountOfSeasons = 0;
        public override String GetInfo()
        {
            var str = "Cериал";
            str += base.GetInfo();
            str += String.Format("\nКоличество эпизодов в сезоне: {0}", this.AmountOfEpisodes);
            str += String.Format("\nКоличество сезонов: {0}", this.AmountOfSeasons);
            return str;
        }
        public static TVshow Generate()
        {
            return new TVshow
            {
                Timing = rnd.Next(18, 57),
                AmountOfEpisodes = rnd.Next(6, 32),
                AmountOfSeasons = rnd.Next(1, 16)
            };
        }
    }
    public enum TelecastType { еженедельно, раз_в_2_недели, ежемесячно, по_особому_расписанию };
    public enum BroadcastingTime1Type { час, два, три, четыре, пять, шесть, семь, восемь, девять, десять, одиннадцать, двенадцать};
    public enum BroadcastingTime2Type {ноль_пять, десять,пятнадцать, двадцать, двадцать_пять, тридцать, тридцать_пять, сорок, сорок_пять, пятьдесят,пятьдесят_пять, ровно };
    public enum BroadcastingTime3Type { пополуночи, пополудни};
    public enum BroadcastingDayType { понедельник, вторник, среда, четверг, пятница, суббота, воскресенье };
    public class Telecast : Watchable
    {
        public BroadcastingTime1Type time1 = BroadcastingTime1Type.восемь;
        public BroadcastingTime2Type time2 = BroadcastingTime2Type.двадцать;
        public BroadcastingTime3Type time3 = BroadcastingTime3Type.пополудни;
        public BroadcastingDayType day = BroadcastingDayType.пятница;
        public TelecastType type = TelecastType.ежемесячно;
        public override String GetInfo()
        {
            var str = "Телепередача";
            str += base.GetInfo();
            str += String.Format("\nВремя начала и день эфира: {0} {1} {2} {3}", this.time1, this.time2, this.time3, this.day);
            str += String.Format("\nЧастота выхода в эфир: {0}", this.type);
            return str;
        }
        public static Telecast Generate()
        {
            return new Telecast
            {
                Timing = rnd.Next(18, 57),
                time1 = (BroadcastingTime1Type)rnd.Next(12),
                time2 = (BroadcastingTime2Type)rnd.Next(12),
                time3 = (BroadcastingTime3Type)rnd.Next(2),
                day = (BroadcastingDayType)rnd.Next(7),
                type = (TelecastType)rnd.Next(4)
            };
        }
    }
    

}