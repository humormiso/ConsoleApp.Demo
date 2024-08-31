// 변수선언
string name = string .Empty; //초기화 해주려고 쓴거 <-- ""이거 대신에 쓴거임
int age = 0;
int retirementAge = 65;

// 유저프롬프트
Console.WriteLine("이름을 입력하세요");
name = Console.ReadLine();

Console.WriteLine("나이를 입력하세요");
age = Convert.ToInt32(Console.ReadLine());

// Process the data
int workingYearsRemaining = retirementAge - age;

// output
Console.WriteLine($"이름: {name}");
Console.WriteLine($"나이: {age}");
Console.WriteLine($"퇴사까지 남은시간: {workingYearsRemaining}");

Console.ReadKey();