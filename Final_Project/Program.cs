using System;

namespace Final_Project
{
    class Program
    {
        // 수강 완료된 과목
        struct SubjectEnd
        {
            // 해당 연도
            public string year;
            // 해당 학기
            public string season;
            // 해당 과목
            public string sub;
            // 성적
            public string grade;

            public SubjectEnd(string year, string season, string sub, string grade)
            {
                this.year = year;
                this.season = season;
                this.sub = sub;
                this.grade = grade;
            }
        }

        static void Main(string[] args)
        {

            menu();

            void menu()
            {
                Console.WriteLine("\n ======================== 대학관리 시스템 ========================\n");
                Console.WriteLine(" 1. 환자 추가\n");
                Console.WriteLine(" 2. 환자 이름 순 출력\n");
                Console.WriteLine(" 3. 환자 나이 순 출력\n");
                Console.WriteLine(" 4. COVID-19 확진 환자 출력\n");
                Console.WriteLine(" 5. 대전광역시 소재 선별진료소 출력\n");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("# 환자 추가 메뉴\n");
                        // Database.PatientAdd()을 사용하여 환자목록에 추가하도록 작성
                        try
                        {
                            Console.WriteLine("이름: ");
                            string name = Console.ReadLine();

                            Console.WriteLine("나이:");
                            int age = int.Parse(Console.ReadLine());

                            Console.WriteLine("주소: ");
                            string address = Console.ReadLine();

                            Console.WriteLine("코로나 검사결과(양성 or 음성 입력): ");
                            string check = Console.ReadLine();

                            Console.WriteLine("최근 방문일시: ");
                            int date = int.Parse(Console.ReadLine());

                            Console.WriteLine("체온 측정결과: ");
                            double temper = double.Parse(Console.ReadLine());

                            Database.PatientAdd(new Patient(name, age, address, check, date, temper));

                        }
                        catch (Exception exception)
                        {
                            Console.WriteLine(exception.Message);
                            menu();
                        }

                        Console.WriteLine(" 환자가 정상 추가되었습니다!\n");
                        menu();
                        break;

                    case "2":
                        Console.WriteLine("# 환자 이름 순 출력\n");
                        Database.NameSort();
                        Database.PersonPrint();
                        menu();
                        break;

                    case "3":
                        Console.WriteLine("# 환자 나이 순 출력\n");
                        Database.AgeSort();
                        Database.PersonPrint();
                        menu();
                        break;

                    case "4":
                        Console.WriteLine("# COVID-19 확진 환자 출력\n");

                        // Database.Search()를 사용하여 양성 환자의 이름, 나이, 주소를 출력하도록 설정

                        Database.Search((Patient) =>
                        {
                            if (Patient.covid_result)
                            {
                                Console.WriteLine("이름: {0}, 나이: {1}, 주소: {2} / {3}\n", Patient.name, Patient.age, Patient.address, Patient.lastchart);
                            }
                        }
                        );

                        menu();
                        break;

                    case "5":
                        Console.WriteLine("# 대전광역시 선별 진료소 출력\n");
                        Database.CenterPrint();
                        menu();
                        break;

                    default:
                        Console.WriteLine("올바른 숫자를 입력하여 주세요");
                        menu();
                        break;
                }
            }
        }
    }
}
