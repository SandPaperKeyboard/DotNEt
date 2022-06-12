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
            new Professor("3", "0426297981", "eichoi@hnu.kr" , "최의인", "컴퓨터공학과", "1000000", Alpha.PrfSub2, "정교수", "20100102"),
            new Professor("4", "0426297497", "kyagrd@hnu.kr" , "안기영", "컴퓨터공학과", "1000000", Alpha.PrfSub3, "조교수", "20180101"),

            new Staff("학과조교","5","1000000","20220528","0426297567","ice@hnu.kr","류하은","정보통신공학과"),
            new Professor("6", "0426297569", "ysyun@hnu.kr", "윤영선", "정보통신공학과", "100000000", Alpha.PrfSub4, "학과장", "20010301"),
            new Professor("7", "0426297398", "swpark@hnu.kr", "박성우", "정보통신공학과", "100000000", Alpha.PrfSub5, "교수", "20010204"),
            new Professor("8", "0426298531", "ilikeit@hnu.kr", "류성한", "정보통신공학과", "100000000", Alpha.PrfSub6, "교수", "20010305"),
            new Student("20160651", "01050665397", "dongsu311@naver.com", "김동수", "컴퓨터공학과", Alpha.StdMon, Alpha.StdYear, Alpha.StdSeason, Alpha.StdSubject, Alpha.StdGrade),
            new Student("20161567", "01012345678", "avbesd123@naver.com", "김철수", "컴퓨터공학과", Alpha.StdMon, Alpha.StdYear, Alpha.StdSeason, Alpha.StdSubject, Alpha.StdGrade),
            new Student("20184236", "01047691436", "tyddjr189@naver.com", "김하빈", "컴퓨터공학과", Alpha.StdMon, Alpha.StdYear, Alpha.StdSeason, Alpha.StdSubject, Alpha.StdGrade),
            new Student("20178964", "01078451236", "quqvee485@naver.com", "여민수", "컴퓨터공학과", Alpha.StdMon, Alpha.StdYear, Alpha.StdSeason, Alpha.StdSubject, Alpha.StdGrade),
            new Student("20174265", "01045214697", "zxxvde326@naver.com", "송수철", "컴퓨터공학과", Alpha.StdMon, Alpha.StdYear, Alpha.StdSeason, Alpha.StdSubject, Alpha.StdGrade),
            new Student("20169578", "01002104683", "hvvmyr952@naver.com", "윤진원", "컴퓨터공학과", Alpha.StdMon, Alpha.StdYear, Alpha.StdSeason, Alpha.StdSubject, Alpha.StdGrade),
            new Student("20204632", "01096341007", "pzoide709@naver.com", "박하병", "컴퓨터공학과", Alpha.StdMon, Alpha.StdYear, Alpha.StdSeason, Alpha.StdSubject, Alpha.StdGrade),
            new Student("20215346", "01042658301", "bergse085@naver.com", "성승헌", "컴퓨터공학과", Alpha.StdMon, Alpha.StdYear, Alpha.StdSeason, Alpha.StdSubject, Alpha.StdGrade),
            new Student("20221004", "01057610234", "qtxbfr731@naver.com", "하수연", "컴퓨터공학과", Alpha.StdMon, Alpha.StdYear, Alpha.StdSeason, Alpha.StdSubject, Alpha.StdGrade),
            new Student("20180912", "01063294187", "qbbrew145@naver.com", "제갈연", "컴퓨터공학과", Alpha.StdMon, Alpha.StdYear, Alpha.StdSeason, Alpha.StdSubject, Alpha.StdGrade),
            new Student("20216423", "01048261563", "zxcver953@naver.com", "권민혁", "컴퓨터공학과", Alpha.StdMon, Alpha.StdYear, Alpha.StdSeason, Alpha.StdSubject, Alpha.StdGrade),
            new Student("20184700", "01073405190", "omuyre463@naver.com", "복나길", "컴퓨터공학과", Alpha.StdMon, Alpha.StdYear, Alpha.StdSeason, Alpha.StdSubject, Alpha.StdGrade),
            new Student("20190468", "01020614753", "pcfwdq012@naver.com", "양아롱", "컴퓨터공학과", Alpha.StdMon, Alpha.StdYear, Alpha.StdSeason, Alpha.StdSubject, Alpha.StdGrade),
            new Student("20220214", "01001658439", "cxocid001@naver.com", "봉단비", "컴퓨터공학과", Alpha.StdMon, Alpha.StdYear, Alpha.StdSeason, Alpha.StdSubject, Alpha.StdGrade),
        };

        List<Subject> subject = new List<Subject>()
        {
            new Subject("시스템프로그래밍", "이만희"),
            new Subject("OS", "최의인"),
            new Subject("객체지향언어론", "안기영"),
            new Subject("웹스크립트", "윤영선"),
            new Subject("고급프로그래밍", "윤영선"),
            new Subject("웹프로그래밍", "류성한"),
            new Subject("프로젝트관리", "윤영선"),
            new Subject("데이터통신", "류성한"),
            new Subject("데이터구조", "최의인"),
            new Subject("닷넷", "이만희"),
            new Subject("프로그래밍언어론", "안기영"),
            new Subject("컴퓨터그래픽스", "안기영"),
        };

        List<Department> department = new List<Department>()
        {
            new Department("컴퓨터공학과", "공과대학", "042-029-4393", "윤유빈", "이만희", "hnu7544@hnu.kr", "ce.hannam.ac.kr", Alpha.DepSub1, Alpha.DepPrf1),
            new Department("컴퓨터공학과", "공과대학", "042-029-4393", "류하은", "윤영선", "ice@hnu.kr","ice.hannam.ac.kr", Alpha.DepSub2, Alpha.DepPrf2),
        };
    }
}
