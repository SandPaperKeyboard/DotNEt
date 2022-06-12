using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    internal class Database
    {
        class Alpha
        {
            public static string[] DepSub1 = { ".Net", "OS", "Python" };
            public static string[] DepPrf1 = { "이만희", "최의인", "안기영" };
            public static string[] DepSub2 = { "이산수학", "공학수학", "C프로그래밍" };
            public static string[] PrfSub1 = { ".Net" };
            public static string[] DepPrf2 = { "윤영선", "박성우", "류성한" };
            public static string[] PrfSub2 = { "OS" };
            public static string[] PrfSub3 = { "Python" };
            public static string[] PrfSub4 = { "이산수학" };
            public static string[] PrfSub5 = { "공학수학" };
            public static string[] PrfSub6 = { "C프로그래밍" };

            public static string[] StdMon = { "장학금 $500,000" };
            public static string[] StdYear = { "2022" };
            public static string[] StdSeason = { "1" };
            public static string[] StdSubject = { "Algorithm" };
            public static string[] StdGrade = { "A" };
        }

        List<Option> person = new List<Option>()
        {
            new Staff("학과조교", "1", "1000000", "20220222", "0426297544", "hnu7544@hnu.kr", "윤유빈", "컴퓨터공학과"),
            new Professor("2", "0426297623", "manheelee@hnu.kr", "이만희", "컴퓨터공학과", "1000000", Alpha.PrfSub1, "학과장", "20120101"),
            new Professor("3", "0426297981", "eichoi@hnu.kr" , "최의인", "컴퓨터공학과", "1000000", Alpha.PrfSub2, "정교수", "20100101"),
            new Professor("4", "0426297497", "kyagrd@hnu.kr" , "안기영", "컴퓨터공학과", "1000000", Alpha.PrfSub3, "조교수", "20180301"),

            new Staff("학과조교","5","1000000","20220528","0426297567","ice@hnu.kr","류하은","정보통신공학과"),
            new Professor("6", "0426297569", "ysyun@hnu.kr", "윤영선", "정보통신공학과", "100000000", Alpha.PrfSub4, "학과장", "20010301"),
            new Professor("7", "0426297398", "swpark@hnu.kr", "박성우", "정보통신공학과", "100000000", Alpha.PrfSub5, "교수", "20010101"),
            new Professor("8", "0426298531", "ilikeit@hnu.kr", "류성한", "정보통신공학과", "100000000", Alpha.PrfSub6, "교수", "20010101"),
            new Student("20160651", "01050665397", "dongsu311@naver.com", "김동수", "컴퓨터공학과", Alpha.StdMon, Alpha.StdYear, Alpha.StdSeason, Alpha.StdSubject, Alpha.StdGrade),
            new Student("20161567", "01012345678", "teryop123@naver.com", "김철수", "컴퓨터공학과", Alpha.StdMon, Alpha.StdYear, Alpha.StdSeason, Alpha.StdSubject, Alpha.StdGrade),
            new Student("20184236", "01047691436", "teryop189@naver.com", "김하빈", "컴퓨터공학과", Alpha.StdMon, Alpha.StdYear, Alpha.StdSeason, Alpha.StdSubject, Alpha.StdGrade),
            new Student("20178964", "01078451236", "teryop485@naver.com", "여민수", "컴퓨터공학과", Alpha.StdMon, Alpha.StdYear, Alpha.StdSeason, Alpha.StdSubject, Alpha.StdGrade),
            new Student("20174265", "01045214697", "teryop326@naver.com", "송수철", "컴퓨터공학과", Alpha.StdMon, Alpha.StdYear, Alpha.StdSeason, Alpha.StdSubject, Alpha.StdGrade),
            new Student("20169578", "01002104683", "teryop952@naver.com", "윤진원", "컴퓨터공학과", Alpha.StdMon, Alpha.StdYear, Alpha.StdSeason, Alpha.StdSubject, Alpha.StdGrade),
            new Student("20204632", "01096341007", "teryop709@naver.com", "박하병", "컴퓨터공학과", Alpha.StdMon, Alpha.StdYear, Alpha.StdSeason, Alpha.StdSubject, Alpha.StdGrade),
            new Student("20215346", "01042658301", "teryop085@naver.com", "성승헌", "컴퓨터공학과", Alpha.StdMon, Alpha.StdYear, Alpha.StdSeason, Alpha.StdSubject, Alpha.StdGrade),
            new Student("20221004", "01057610234", "teryop731@naver.com", "하수연", "컴퓨터공학과", Alpha.StdMon, Alpha.StdYear, Alpha.StdSeason, Alpha.StdSubject, Alpha.StdGrade),
            new Student("20180912", "01063294187", "teryop145@naver.com", "제갈연", "컴퓨터공학과", Alpha.StdMon, Alpha.StdYear, Alpha.StdSeason, Alpha.StdSubject, Alpha.StdGrade),
            new Student("20216423", "01048261563", "teryop953@naver.com", "김동수2", "컴퓨터공학과", Alpha.StdMon, Alpha.StdYear, Alpha.StdSeason, Alpha.StdSubject, Alpha.StdGrade),
            new Student("20184700", "01073405190", "teryop463@naver.com", "김동수2", "컴퓨터공학과", Alpha.StdMon, Alpha.StdYear, Alpha.StdSeason, Alpha.StdSubject, Alpha.StdGrade),
            new Student("20190468", "01020614753", "teryop012@naver.com", "김동수2", "컴퓨터공학과", Alpha.StdMon, Alpha.StdYear, Alpha.StdSeason, Alpha.StdSubject, Alpha.StdGrade),
            new Student("20220214", "01001658439", "teryop001@naver.com", "김동수2", "컴퓨터공학과", Alpha.StdMon, Alpha.StdYear, Alpha.StdSeason, Alpha.StdSubject, Alpha.StdGrade),
        };

        List<Subject> subject = new List<Subject>()
        {

        };

        List<Department> department = new List<Department>()
        {

        };
    }
}
