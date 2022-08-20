using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;

using Abstr;
using Constr;
using Cond;
using AccessModifier;
using StructEnum;
using Collection_Geneneric;
using Typesafe_Calling;
using ParallelConstr;
using System.Linq;
using System.Data;

class Program
{
    //Single-line comment. - I. Writing to Console

    /*
        Multiline comment.
        ... additional information, etc.
        a. WriteLine()
        b. Write()
    */
    static void Main(string[] args)
    {

		//I. C# WriteLine() & Write()
		Console.OutputEncoding = System.Text.Encoding.UTF8;
		Console.WriteLine("I. C# WriteLine() & Write() : 操作台的运作\n");
		Console.WriteLine("编程语言“输出”测试 ... 这程序需要用 -> Console.OutputEncoding = System.Text.Encoding.UTF8\n");
		Console.WriteLine("Right-Click Console 'Titlebar' and select ‘Properties - Font’; to include font with Chinese characters (e.g. SimHei)");
		Console.WriteLine("右键单击“title bar”：标题栏的操作台和选择“Properties - Font”：特性-字体；包括字体与汉字 (e.g. SimHei) ... 如果体验在 -[?]\n");
		Console.WriteLine("String (Example) using Console.WriteLine():\n例子的字符串用在*Console.WriteLine():\n");
		Console.WriteLine("Console.WriteLine() - creates newline per entry ...\nConsole.WriteLine()创造新命令行为了每输入系统。\n");
		Console.Write("String (Example) using Console.Write(): ");
		Console.WriteLine(" creates inline per entry ... Remember to use 'whitespace'");
		Console.Write("例子的字符串用在Console.Write(): ");
		Console.WriteLine(" 创造新句子内一样换行，记得用‘white-space’...");

		//@End of lesson(s)
		Console.WriteLine("\nPress 'ENTER' to Continue:");
		Console.WriteLine("点击‘ENTER’为了继续");
		Console.ReadKey();

		//II. C# Data Types
		Console.WriteLine("-----\nII. C# Data Types: 数据类型\n");
		Console.WriteLine("IMPORTANT!: Below are examples of data *values*;\n" + "strings are considered a *reference* (i.e. separate values included in an object)  ... to array of characters\n" + "\n重要！：下面在示例的数据 *values -“价值”*；\n换行权衡了一个 *reference -“参照”*（i.e. 这些一个价值在包括内其他对象）...向数组的一个字符\n");
		int numberInt = 1;
		double numberDouble = 0.01D;
		float numberFloat = 0.0001F;
		long numberLong = 10000000000L;
		char letterChar = 'A';
		bool booleanFalse = false;
		bool booleanTrue = true;

		
		string text = "\nSample text ... 示例代码";

		Console.WriteLine("int: " + numberInt);
		Console.WriteLine("double: " + numberDouble);
		Console.WriteLine("float: " + numberFloat);
		Console.WriteLine("long: " + numberLong);
		Console.WriteLine("char: " + letterChar);
		Console.WriteLine("boolean(F): " + booleanFalse);
		Console.WriteLine("boolean(T): " + booleanTrue + "\n");

		Console.WriteLine("*reference* type -> char[] text = {'S','a','m','p','l','e'} -> same as: string text = 'Sample'");
		Console.WriteLine("*reference* 类型 -> char[] text = {'S','a','m','p','l','e'} -> 这事情一样: string text = 'Sample'");
		Console.WriteLine("(BELOW): " + text + "\n");

		float sci_Float = 1e3F;
		double sci_Double = 1E5D;

		Console.WriteLine("sciNotation (1e^3) using Float: " + sci_Float);
		Console.WriteLine("sciNotation (1E^4) using Double: " + sci_Double);

		//@End of lesson(s)
		Console.WriteLine("\nPress 'ENTER' to Continue:");
		Console.WriteLine("点击‘ENTER’为了继续");
		Console.ReadKey();

		//III. C# Type Casting
		Console.WriteLine("-----\nIII. Type Casting：“数据”类型投放");
		//a. Implicit*
		Console.WriteLine("a. Implicit: 暗含");
		int impl_Int = 10;
		double impl_Double = impl_Int;

		Console.WriteLine("Implicit Casting: " + impl_Double);
		//b. Explicit*
		Console.WriteLine("b. Explicit: 明确");
		double expl_Double = 9.78;
		int expl_Int = (int)expl_Double;
		Console.WriteLine("Explicit Casting: " + expl_Int + "\n*Also referred to as type-casting (int)expl_double = {9.78};\n" +
			"because of type-cast (int) the result in at Runtime = 9");
		Console.WriteLine("\n* 也提到作为 * type - casting - 类型投放 * (int)expl_double = { 9.78}: \n" +
"因为类型投放(int)所以这一个结果在运行时 = 九（9）");

		int conv_Long = 100000;
		double conv_Double = 9.78;

		Console.WriteLine("Convert 'True' ToString: " + Convert.ToString(booleanTrue));
		Console.WriteLine("Convert 'Double' to Int32: " + Convert.ToInt32(conv_Double));
		Console.WriteLine("Convert 'Long' to Int64: " + Convert.ToInt64(conv_Long));

		//@End of lesson(s)
		Console.WriteLine("\nPress 'ENTER' to Continue:");
		Console.WriteLine("点击‘ENTER’为了继续");
		Console.ReadKey();

		//IV.C# Strings & User Input
		Console.WriteLine("-----\nIV. C# Strings & User Input: 字符串和使用者的录入");
		
		//Enter username and press 'Enter'
		Console.Write("\n(英语) Enter username: ");

		Console.InputEncoding = System.Text.Encoding.UTF8;
		string userName = Console.ReadLine(); //... add exception handling*

		//Print value of userName - to Console
		Console.WriteLine("Welcome，欢迎光临： " + userName);

		Console.Write("Enter #: ");
		int num = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Num #: " + num);

		//@End of lesson(s)
		Console.WriteLine("\nPress 'ENTER' to Continue:");
		Console.WriteLine("点击‘ENTER’为了继续");
		Console.ReadKey();

		//V. C# Logical Operators:
		Console.WriteLine("-----\nV. C# Logical Operators: [translate]");
		Console.WriteLine("Operators:\n = (equals) :: += (sum) :: -= (difference) :: *= (multiplication) :: /= (division) :: %= (modulus.Remainder);\n");
		Console.WriteLine("...Search ?: &= :: |= :: ^= :: >>= :: <<=\n");
		Console.WriteLine("Comparison Operators:\n == (Equals to) :: != (NOT Equal)\n > (Greater than) :: < (Less than)\n => (Greater than or Equal) :: <= (Less than or Equal to)\n");
		Console.WriteLine("Logical Operators:\n && -'Logical (and)' returns true is both statements are 'True',\n || - 'Logical (or)' returns true if one statement is 'True',\n ! - 'logical (NOT)' returns false if result is 'True',\n");

		Console.WriteLine("\nPress 'ENTER' to Continue:");
		Console.WriteLine("点击‘ENTER’为了继续");
		Console.ReadKey();

		/* An exception is necessary to prevent incorrect inputs - covered later in review.
		 * Age is over-ridden (i.e. "Convert.ToInt32()") to ensure an integer can be processed; 

		V. C# Logical Operators:

		Operators:\n
		= (equals) :: += (sum) :: -= (difference) :: *= (multiplication) :: /= (division) :: %= (modulus.Remainder);\n  
		...Search?: &= :: |= :: ^= :: >>= :: <<=\n

		Comparison Operators:\n
		== (Equals to):: != (NOT Equal)\n 
		> [...] :: < (Greater/Less than)\n
		=> [...] :: <= (Greater/Less than or Equal to)\n

		Logical Operators:\n
		&& - "Logical (and)" returns true is both statements are 'True',\n
		|| - "Logical (or)" returns true if one statement is 'True',\n
		! - "logical (NOT)" returns false if result is 'True',\n
		 */

		//VI. C# Math:
		Console.WriteLine("-----\nVI. C# Math: 数学\n");

		Console.WriteLine("Maxium using 'Math.Max(0, 9)' = " + Math.Max(0, 9));
		Console.WriteLine("Minimum using 'Math.Min(0, 9)' = " + Math.Min(0, 9));
		Console.WriteLine("Sq.Root using 'Math.Sqrt(64)' = " + Math.Sqrt(64));
		Console.WriteLine("Abs.Value using 'Math.Abs(-1)' = " + Math.Abs(-1));
		Console.WriteLine("Round(up) using 'Math.Round(0.5)' = " + Math.Round(0.5) + "\n");

		//@End of lesson(s)
		Console.WriteLine("Press 'ENTER' to Continue:");
		Console.WriteLine("点击‘ENTER’为了继续");
		Console.ReadKey();

		//VII. C# Strings:
		Console.WriteLine("\nVII. C# String Methods: 字符串办法\n");
		string abcMod = "Aa - Bb - Cc";
		string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
		Console.WriteLine("Normal: \n" + abcMod + "\n");
		Console.WriteLine("Upper_case: \n" + abcMod.ToUpper() + "\n");
		Console.WriteLine("Lower_case: \n" + abcMod.ToLower() + "\n");
		Console.WriteLine("Alphabet(EN) Length: " + alphabet.Length);

		//a. Example(s) - Concatenation:
		Console.WriteLine("a. Example(s) - Concatenation: 楷模的链接");
		string firstName = "Alpha";
		string lastName = "Bravo";
		string concat_Name = firstName + " " + lastName; //using "whitespace"
		string function_concatName = string.Concat(firstName, lastName);
		Console.WriteLine("Basic Concat: \n" + concat_Name);
		Console.WriteLine("function Concat: \n" + function_concatName + "\n");
		//b. Example(s) - Interpolation:
		Console.WriteLine("b. Example(s) - Interpolation: 楷模的插值");
		string interpol_Greeting = $"Welcome user， {firstName} {lastName}";
		Console.WriteLine(interpol_Greeting);
		string initials = $"Initials: {firstName[0]}{lastName[0]}";
		Console.WriteLine("...using interpolation & Access String(s)\n这楷模在用字符串存取和插值：\n" + "firstName?: Alpha -- lastName?: Bravo\n" +
			initials);

		//c. Example(s) - IndexOf & Substring:
		Console.WriteLine("c. Example(s) - IndexOf & Substring: 指标..更递字符串");
		int charPos_A = concat_Name.IndexOf('A');
		string substr_lastName = concat_Name.Substring(charPos_A);
		Console.WriteLine(substr_lastName + "\n");

		//d. Array & ArrayList
		Console.WriteLine("d. Example(s) - Array & ArrayList - 数组和数组列表");
		//int[] id = new int[9]; ** form of instantiation
		int[] id = { 0001, 0005, 0002, 0004, 0007, 0008, 0006, 0009, 0003, 0010 };
		Array.Sort(id);
		for (int list=0; list < id.Length; list++){
			Console.Write(id[list] + ", ");
        }

		string[] phonetic = { "alpha", "bravo", "charlie" }; //{"alpha", 1, "bravo", 2} produces ERROR!* 
		foreach (string letter in phonetic)
		{
			Console.Write(letter + ", ");
		}
		Console.WriteLine("\n");

		Console.WriteLine("IMPORTANT!: Arrays have a fixed length and *strongly* typed; ArrayList has variable length and *loosely* typed");
		Console.WriteLine("重要!: 数组有既定长度和总是*强*类型(只一个数据类型可以用了)；数组列表没有既定长度和*松*类型（不止一个数据类型可以用了）\n");
		

		ArrayList phone_num = new ArrayList(); //usable with ANY datatype
		phone_num.Add("(555)-###-0000");//string data-type*
		phone_num.Add(5550035076); //int data-type* 
		phone_num.Add("(555)-###-0001");
		phone_num.Add(5550016456);
		phone_num.Add("(555)-###-0001");


		foreach (var contact in phone_num)
        {
			Console.WriteLine(contact);
        }

		//@End of lesson(s)
		Console.WriteLine("\nPress 'ENTER' to Continue:");
		Console.WriteLine("点击‘ENTER’为了继续");
		Console.ReadKey();

		/* Escape Characters in C#:
		 * 
		 \n :: 'New Line'
		 \t :: 'Tab'
		 \b :: 'Backspace'
		 \\ :: 'Forward-Slash'
		*
		*/

		//VIII. Conditionals "if, else if, & else":
		int iter = 0;
		If_Else sample_Cond = new If_Else(iter);
		Console.WriteLine(sample_Cond);

		//a. C# Switch
		SwitchCase sample_Switch = new SwitchCase();
		Console.WriteLine(sample_Switch);

		//b. C# While Loop
		int i = 0;
		Conditional_Loop sample_While = new Conditional_Loop();
		sample_While.WhileLoop(i);

		//c. C# Do/While Loop
		
		Conditional_Loop sample_DoWhile = new Conditional_Loop();
		sample_DoWhile.Do_While(i);

		//@End of lesson(s)
		Console.WriteLine("\nPress 'ENTER' to Continue:");
		Console.WriteLine("点击‘ENTER’为了继续");
		Console.ReadKey();

		//IX. Methods & Constructors
		var numAdd = MathConstr_static.Sum(1, 3);
		MathConstr_static.Insert(numAdd);
			
		var str = MathConstr_static.Static;
		Console.WriteLine(str);

		Constr_public ex_Pub = new Constr_public();
		Console.WriteLine(ex_Pub.str);

		Constr_wParameter ex_Para = new Constr_wParameter("\nConstructor using 'public object' w/ parameter(s).\n");
		Console.WriteLine(ex_Para.mod);

		//X. Access Modifiers & Inheritance - see: Interface
		//a. "public" access modifier
		AccessMod sample_Public = new AccessMod();
		Console.WriteLine(sample_Public.publicStr);
		//b. "private" access modifier w/ inferface RetreiveData()
		AccessMod sample_Private = new AccessMod();
		sample_Private.RetreiveData();
		//c. "protected" access modifier w/ inheritance
		AccessMod_Protected sample_Protected = new AccessMod_Protected();
		sample_Protected.RetreiveData();

		//XI. Abstraction
		int p = 0;
		string output = "Example of inherited abstract method.\n";
		Non_Abstract sample_Abstr = new Non_Abstract();
			
		sample_Abstr.non_abstrMethod();
		sample_Abstr.abstrMethod(output, p);
		Console.WriteLine("See: Abstr.cs -- for object class details");

		//@End of lesson(s)
		Console.WriteLine("\nPress 'ENTER' to Continue:");
		Console.WriteLine("点击‘ENTER’为了继续");
		Console.ReadKey();

		//XII. Recursion & ... "value", "ref", "out" datatypes
		Recursion sample_Recur = new Recursion();
		sample_Recur.enumRecursion = 1; //using "out type" ... 

		int process = 15; /* Use enumRecursion to instead of 'int process'...
		//value '15' is shown here to demonstrate the concept of 'out' datatype - "enumRecursion" in memory. 参考枚举代替'in process'。..//数值展示了'out'类型-"enumRecursion"在内存中的概念 参考枚举 …… */

		int result = sample_Recur.Sum(0, 0, out process);
		Console.WriteLine("Result of sample_Recur.Sum = " + result + " [...]\n 'out process' is NOT used to enumerate RecurSum ::"); //insert ref String ...
		void RecurSum()
        {
			sample_Recur.RecurSum(10, 10);	
        }

		RecurSum();
		void Statement(ref string ref_Sample) //Overriding ref_Statement
		{
			ref_Sample = "\n...Reference(Override)";
			Console.WriteLine(ref_Sample);
		}
		string ref_Sample = "...";
		Statement(ref ref_Sample);

		//XIII. Structures & Enumerations
		Struct_Data sample_Data = new Struct_Data();
        Struct_Data.StructEnum_Data sample_EnumData= new Struct_Data.StructEnum_Data();
		//a. ValueTuple:
		sample_EnumData.return_StrFY(ref sample_Data);
		Console.WriteLine("\n");
		//b. Tuple:
		sample_EnumData.return_IntFY(ref sample_Data);
		Console.WriteLine("\n");
		//c. Custom:
		sample_EnumData.customFY_Obj(ref sample_Data);
		
		//<--DELETE
		 
        //XIV. Collections
        List<int> int_List = new List<int>();
		int_List.Add(1);
		int_List.Add(2);
		int_List.Add(3);

		int lambda = int_List.Where(n => n == 1).FirstOrDefault();
		Console.WriteLine("Examine: int_List[" + lambda + "]");

		SortedList str_Sort = new SortedList();

		Queue<int> int_Queue = new Queue<int>();
		int_Queue.Enqueue(1);
		int_Queue.Enqueue(2);
		int_Queue.Enqueue(3);

		string[] verbose = {"One", "Two", "Three"};
		Queue<string> str_Queue = new Queue<string>(verbose);
		
		Dictionary<int, string> item_Dictionary = new Dictionary<int, string>();
		KeyValuePair<int, string> item_Key = new KeyValuePair<int, string>();

		item_Dictionary.Add(0, "--");
		item_Dictionary.Add(1, "Item(1)");
		item_Dictionary.Add(2, "Item(2)");

		item_Key = item_Dictionary.Where(r => r.Key == 1).FirstOrDefault();
		foreach (KeyValuePair<int, string> n in item_Dictionary)
		{
			Console.WriteLine( n + " -> " + n.Value);
		}

		GenericSum genSum = new GenericSum();
		GenericSum.Addition<int> genObject_sample = new GenericSum.Addition<int>();
		genObject_sample.Add(1, 2);

		//XV. C# Files & Directories
		DirectoryInfo info = new DirectoryInfo(@"C:\C#_FileDirectory");
        if (info.Exists)
        {
            info.Create();
        }

		String Direct_FilePath = "C:\\C#_FileDirectory\\sample.txt";
        FileInfo info_File = new FileInfo(Direct_FilePath);
		FileStream file_Stream = info_File.Create();
		file_Stream.Close();
        
		//FileStream: StreamWiter & StreamReader
        FileStream file_StreamToWrite = new FileStream(Direct_FilePath, FileMode.OpenOrCreate);
		StreamWriter file_SW = new StreamWriter (file_StreamToWrite);
		file_SW.WriteLine("Addition to content on file ...");
		file_SW.Close();
		file_StreamToWrite.Close();

		FileStream file_StreamToRead = new FileStream(Direct_FilePath, FileMode.OpenOrCreate);
		StreamReader file_SR = new StreamReader(file_StreamToRead);
		Console.WriteLine(file_SR.ReadToEnd());
		file_SR.Close();
		file_StreamToRead.Close();

		//TextWriter & TextReader
		TextWriter file_TxtToWrite = File.CreateText(Direct_FilePath);
		file_TxtToWrite.WriteLine("- END");
		file_TxtToWrite.Close();

		TextReader file_R = File.OpenText(Direct_FilePath);
		Console.WriteLine(file_R.ReadToEnd());
		file_R.Close();

		//

		//XVI. Multitasking & Multi-Treading:

		Console.WriteLine("Exe.Main [START]");
		Thread thd = Thread.CurrentThread;
		thd.Name = "ThreadMain";
		Console.WriteLine("id: " + thd.ManagedThreadId);
		Console.WriteLine(thd.Name + ":");
		PrintStnd_1();
		PrintStnd_2();
		Console.WriteLine("Exe.Main [END]");

		Console.ReadKey();
		Console.WriteLine("Exe.ChildThread [START]");

		//a. (Standard) Thread Contruction
		Thread thd_1 = new Thread(PrintStnd_1) { Name = "ChildThread_1" };
		Thread thd_2 = new Thread(PrintStnd_2) { Name = "ChildThread_2" };

		thd_1.Start();
		thd_2.Start();
		//Thread.Sleep(3000);
		Console.WriteLine("Exe.Main - [RUNNING]");

		//b. ParameterizedThread Construction & ThreadStart
		ThreadStart thd_Start = new ThreadStart(PrintStnd_1);
		Thread thd_3 = new Thread(thd_Start);
		thd_3.Start();

#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
        ParameterizedThreadStart thd_Param = new ParameterizedThreadStart(PrintSafe_0);
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
        Thread thd_4 = new Thread(thd_Param);
		thd_4.Start(30);

        //c. (Typesafe) Thread Construction

        Typesafe_Call thd_Safe = new Typesafe_Call(20);
		ThreadStart thdSafe_Start = new ThreadStart(thd_Safe.PrintNew);
		Thread thdStnd_Start = new Thread(thdSafe_Start);
		thdStnd_Start.Start();

		Thread sampleObj_1 = new Thread(PrintStnd_1);
		Thread sampleObj_2 = new Thread(PrintStnd_2);
#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
		ParameterizedThreadStart thd_Param_0 = new ParameterizedThreadStart(PrintSafe_0);
		Thread sampleObj_3 = new Thread(thd_Param_0);
		sampleObj_1.Start();
		sampleObj_1.Join();
		
		sampleObj_2.Start();
		sampleObj_2.Join(1000);

		sampleObj_3.Start(86);
		sampleObj_3.Join(1000);


		sampleObj_3.Join(3000);
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).


		Thread thd_Locked = new Thread(PrintText);
		thd_Locked.Start();
		

        static void PrintStnd_1()
		{
			Console.WriteLine("PrintStnd_1 (Standard) - [RUNNING]");
			try
			{
				for (int i = 0; i <= 32; i++)
				{
					Console.WriteLine(i.ToString());
				}
				
				Console.WriteLine("[1] End of Output ...");
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}

			Thread.Sleep(10000);
		}

		static void PrintStnd_2()
		{
			Console.WriteLine("PrintStnd_2 (Standard) - [RUNNING]");
			try
			{
				for (int i = 33; i <= 64; i++)
				{
					Console.WriteLine(i.ToString());
				}
				
				Console.WriteLine("[2] End of Output ... PRESS 'Enter' to Esc");
			}

			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}

			Thread.Sleep(10000);
		}

		static void PrintSafe_0(object obj)
        {

			Console.WriteLine("PrintSafe_0 (Object) - [RUNNING]");
			try
            {
				int obj_value = Convert.ToInt32(obj);
				for(int i = 65; i<= obj_value; i++)
                {
					Console.WriteLine(i.ToString());
                }
				//Thread.Sleep(3000);
				Console.WriteLine("[0] End of Output ...");
			}
			catch(Exception ex)
            {
				Console.WriteLine(ex);
            }
        }

		//private static object _lock = new object(); 
		
		static void PrintText()	
        {

			DelegateUsage item = new DelegateUsage();
			var _lock = new Object();

			
            
			try
			{
				lock (_lock)
				{
					item.Lock_PrintText(_lock);
				}
			}
			catch
            {

            }
        }

		//XV. C# Asynchronous Programing
		//a. Constructor 
		Task prnt_1 = new Task(PrintStnd_1);
		//b. Factory.StartNew
		Task prnt_2 = Task.Factory.StartNew(PrintStnd_2);
		//c. Lambda
		Task prnt_3 = Task.Run(()=>
		{
			Console.WriteLine("Using: Task.Run (Lambda)");
			PrintStnd_1();
		});
		//prnt_3.Wait();

		Task<int> prnt_4 = Task.Run(() => 
		{
            return PrintValue();
		});

		Console.WriteLine(prnt_4.Result);
		Task prnt_3Cont = Task.Run(() =>
		{
			PrintStnd_1();
		}).ContinueWith((antecedent) => { PrintStnd_1(); });

		Console.ReadKey();

		static int PrintValue()
		{

			DelegateUsage item = new DelegateUsage();
			var _lock = new Object();

			int i = 10;
            lock (_lock)
            {
				for(i = 0; i < 30; i++)
                {
					item.Lock_PrintValue(_lock);
					Console.WriteLine(Thread.CurrentThread.ManagedThreadId + "_Task" + i);
                }
            }

			return i;
		}

		//List<ParallelConstr.UserData> dataList = new List<ParallelConstr.UserData>();
		UserData id_0 = new UserData("FI.LastName01", "*******", 30, 85, new List<string> {"Topic_1", "Topic_6" }, 1);
		UserData id_1 = new UserData("FI.LastName02", "*****", 20, 5, new List<string> { "Topic_3", "Topic_2" }, 1);
		UserData id_2 = new UserData("FI.LastName03", "********", 10, 6, new List<string> { "Topic_1", "Topic_4" }, 1);
		UserData id_3 = new UserData("FI.LastName04", "******", 0, 0, new List<string> { "Topic_2", "Topic_3" }, 2);
		UserData id_4 = new UserData("FI.LastName05", "**********", 2, 8, new List<string> { "Topic_4", "Topic_5" }, 2);
		UserData id_5 = new UserData("FI.LastName06", "*******", 16, 46, new List<string> { "Topic_1", "Topic_6" }, 2);
		UserData id_6 = new UserData("FI.LastName07", "******", 1, 35, new List<string> { "Topic_5", "Topic_6" }, 2);
		UserData id_7 = new UserData("FI.LastName08", "******", 3, 12, new List<string>{ "Topic_5", "Topic_6" }, 3);
		UserData id_8 = new UserData("FI.LastName09", "******", 18, 9, new List<string> { "Topic_3", "Topic_6" }, 3);
		UserData id_9 = new UserData("FI.LastName10", "******", 13, 7, new List<string> { "Topic_1", "Topic_2" }, 5);

        UserData.UserCollection userData_Compile = new UserData.UserCollection();
		userData_Compile.Add(id_0);
		userData_Compile.Add(id_1);
		userData_Compile.Add(id_2);
		userData_Compile.Add(id_3);
		userData_Compile.Add(id_4);
		userData_Compile.Add(id_5);
		userData_Compile.Add(id_6);
		userData_Compile.Add(id_7);
		userData_Compile.Add(id_8);
		userData_Compile.Add(id_9);

		UserData id_10 = new UserData("FI.LastName10", "*******", 14,57, new List<string> { "Topic_1", "Topic_6" }, 5);
		UserData id_11 = new UserData("FI.LastName12", "**********", 21, 49, new List<string> { "Topic_3", "Topic_2" }, 4);
		UserData id_12 = new UserData("FI.LastName13", "********", 10, 0, new List<string> { "Topic_1", "Topic_4" }, 4);

		UserData.UserCollection transferData_Compile = new UserData.UserCollection();
		transferData_Compile.Add(id_10);
		transferData_Compile.Add(id_11);
		transferData_Compile.Add(id_12);

		PlatformData channel_1 = new PlatformData("m.getpostshare.com", 6.7, true, 1);
		PlatformData channel_2 = new PlatformData("getpostshare.com", 13.1, false, 2);
		PlatformData channel_3 = new PlatformData("m.multimedia.biz", 27.3, true, 3);
		PlatformData channel_4 = new PlatformData("multimedia.biz", 10.3, false, 4);
		PlatformData channel_5 = new PlatformData("facelecturn.io", 67.2, true, 5);
		PlatformData channel_6 = new PlatformData("instantmedia.video", 13.4, false, 6);

		
		PlatformData.SvcCollection platformData_Compile = new PlatformData.SvcCollection();
		platformData_Compile.Add(channel_1);
		platformData_Compile.Add(channel_2);
		platformData_Compile.Add(channel_3);
		platformData_Compile.Add(channel_4);
		platformData_Compile.Add(channel_5);
		platformData_Compile.Add(channel_6);

		//a. C# GroupBy:
		var compare_UserData = userData_Compile.GroupBy(items => items.SvcProviderID);
		var compare_SvcData = userData_Compile.GroupBy(items => items.SvcProviderID).OrderBy(output =>
			output.Key).Select(output => new
			{
				Website = output.Key,
				Users = output
			});

		foreach(var group in compare_SvcData)
        {
			Console.WriteLine(group.Website);

			foreach(var grouplist in group.Users)
            {
				Console.WriteLine(grouplist.Username);
            }
        }

		//b. C# JOINS using LINQ:
		var inner_SvcData = userData_Compile.Join(platformData_Compile, acct => acct.SvcProviderID,
			pltf => pltf.SvcProviderID, (acct, pltf) => new
			{
				Username = acct.Username, //override ...
				SvcProviderName = pltf.SvcProviderName,
				SvcType = pltf.SvcTypeIsMobile
			});

		var group_SvcData = userData_Compile.GroupJoin(platformData_Compile, acct => acct.SvcProviderID,
			pltf => pltf.SvcProviderID, (acct, pltf) => new { acct.Username, pltf });

		foreach(var join in inner_SvcData)
        {
			
			Console.WriteLine(join.Username + ":: " + join.SvcProviderName);
			Console.WriteLine(join.SvcProviderName + " - IsMobile?: " + join.SvcType);
        }

		foreach (var group in group_SvcData)
		{
			Console.WriteLine(group.Username + ":: " + group); //prints "platformData_Compile" object parameters
		}

		var query_SvcData = from acct in userData_Compile
							join pltf in platformData_Compile
							on acct.SvcProviderID equals pltf.SvcProviderID
							select new
							{
								Username = acct.Username,
								Views = acct.Views,
								Website = pltf.SvcProviderName,
								Mobile = pltf.SvcTypeIsMobile
							};
        
		var query_SvcDataL = from acct in userData_Compile
							 join pltf in platformData_Compile
							 on acct.SvcProviderID equals pltf.SvcProviderID
							 into leftJoin_Compile
							 from acctProfile in leftJoin_Compile.DefaultIfEmpty()
							 select new
							 {
								 Username = acct.Username,
								 Website = (acctProfile == null ? "ERROR 404 - Not found." : acctProfile.SvcProviderName),
								 Mobile = (acctProfile == null ? "ERROR" : acctProfile.SvcTypeIsMobile.ToString())
							 };
		
		foreach(var group in query_SvcDataL)
        {
			
			Console.WriteLine(group.Username + "::" + group.Website + " - IsMobile?: " + group.Mobile);
        }

		var query_SvcDataR = from pltf in platformData_Compile
							 join acct in userData_Compile
							 on pltf.SvcProviderID equals acct.SvcProviderID
							 into rightJoin_Compile
							 from acctProfile in rightJoin_Compile.DefaultIfEmpty()
							 select new
							 {
								 Website = pltf.SvcProviderName,
								 TotalUsers = pltf.TotalUsers,
								 Username = (acctProfile == null ? "ERROR." : acctProfile.Username),
								 //Topics = (acctProfile == null ? "ERROR" : acctProfile.Topics) ... 
							 };

		foreach (var group in query_SvcDataR)
		{
			Console.WriteLine(group.Username + "::" + group.Website + " - TotalUsers?: " + group.TotalUsers + "M");
		}

		var cross_SvcData = from acct in userData_Compile
							from pltf in platformData_Compile
							select new
							{
								Username = acct.Username,
								Views = acct.Views,
								Comments = acct.Comments,
								Website = pltf.SvcProviderName,
								Mobile = pltf.SvcTypeIsMobile.ToString(),
								TotalUsers = pltf.TotalUsers

							};
		
		
		foreach (var group in cross_SvcData)
        {
			
			Console.WriteLine(group.Username + ":: " + group.Website + "|--Views: " + group.Views + "|--Comments: " + group.Comments 
				+ "\n TotalUsers: " + group.TotalUsers + "M|--TypeIsMobile?: " + group.Mobile);
			
        }
		IEnumerable<object> take_TotalUsers = cross_SvcData.Select(enbl => IntegerExtension.Top_Platform(enbl.TotalUsers));
		Console.WriteLine(take_TotalUsers.First());
		Console.WriteLine("1st_Default: " + platformData_Compile.Select(n => n.TotalUsers).FirstOrDefault());

		Console.WriteLine(take_TotalUsers.ElementAt(3));
		Console.WriteLine("Element_Default: " + platformData_Compile.Select(n => n.TotalUsers).ElementAtOrDefault(10));

		Console.WriteLine(take_TotalUsers.Last());
		Console.WriteLine("Last_Default: " + platformData_Compile.Select(n => n.TotalUsers).LastOrDefault());

		List<string> website = cross_SvcData.Select(e => e.Website).ToList();
		List<string> logo = new List<string>() { "getPostShare.com" };

		try
        {
			string web_Data_1 = website.ElementAt(0).ToString();
			Console.WriteLine(web_Data_1);
			string web_Data_2 = website.ElementAt(1).ToString();
			Console.WriteLine(web_Data_2);

			string logo_Data = logo.ElementAt(0);
			Console.WriteLine(logo_Data);

			bool compare_Website = web_Data_2.SequenceEqual(web_Data_1);
			//bool compare_Logo = logo_Data.SequenceEqual(web_Data_2, StringComparer.OrdinalIgnoreCase);
			Console.WriteLine("String(Website) are Equal?: " + compare_Website);

		}
		catch (Exception ex)
        {
			Console.WriteLine(ex.Message);
        }

		//.Where(item => item.Comments > 10)

		List<int> RaN = Enumerable.Range(1, 20).ToList();
		
		
		List<int> compile_RaN1 = RaN.TakeWhile(e => e <= 2).ToList();
		foreach (int page in compile_RaN1)
		{
			Console.Write("[" + page + "]");
		}
		Console.WriteLine("\n");

		List<int> compile_RaN2 = RaN.SkipWhile(e => e <= 2).Where(e => e <= 4).ToList();
		foreach (int page in compile_RaN2)
		{
			Console.Write("[" + page + "]");
		}
		Console.WriteLine("\n");

		Page_Assm(4, 6, 8); //	No output ...
							//	Complete by adjusting range While(e <= ... Where(e <= ...
							//	public static class Numbers

		static void Page_Assm(int start, int end, int target)
		{
			List<int> RaN_list = Enumerable.Range(1, 20).ToList();
			List<int> acc_Take = RaN_list.TakeWhile(x => x > start).ToList();
			List<int> acc_Taker = RaN_list.TakeWhile(x => x <= start).ToList();

			List<int> acc_Take_filtered = acc_Taker.Where(x => x <= end).ToList();

			List<int> acc_Skip = RaN_list.TakeWhile(x => x > end).ToList();

			List<int> acc_Skip_filtered = acc_Skip.Where(x => x <= target).ToList();

			foreach (int page in acc_Take)
			{
				Console.Write("[" + page + "]");

			}

			Console.WriteLine("\n");

			foreach (int page in acc_Skip_filtered)
			{
				Console.Write("[" + page + "]");
			}

			Console.WriteLine("\n");
		}
		//}



		/*
		Numbers RaN1 = new Numbers();
		RaN1.Page_Assm(RaN, 4, 6, 8);
		*/

		//Numbers.Page_Assm(RaN, 8, 10, 12);
		//Numbers.Page_Assm(RaN, 12, 14, 16);
		//Numbers.Page_Assm(RaN, 16, 18, 20);


		try
        {
			int single_RaN = RaN.Single(e => e == 21);

		}
        catch (Exception ex)
        {
			Console.WriteLine(ex.Message);
			int single_RaN = RaN.SingleOrDefault(e => e == 21);
			Console.WriteLine(single_RaN);
			List<int> default_RaN = RaN.DefaultIfEmpty(21).ToList();
		}
		

		//foreach (var e in take_TotalUsers.ToList())


		IEnumerable<int> pwData = userData_Compile.Select(n => IntegerExtension.PW_StrLength(n.Password));
		foreach (int n in pwData.ToList())
		{
			Console.WriteLine("Password(Length): " + n);
		}

		IEnumerable<double> avgData = userData_Compile.Select(n => IntegerExtension.AVG_Interaction(n.Views, n.Comments));


		//.SkipWhile(enbl => enbl.TotalUsers < 15.0).ToList();

		//RANGE:

		//
		 List<int> element_Op = new List<int>(){10, 14, 9, 15, 20, 0};
		 
		 /*foreach (var group in element_Op)
         {
            if (group != null)
            {

                string student_name = string.Empty;
                string branch_name = string.Empty;
                if (group.s != null)
                {
                    student_name = group.s.Student_Name;
                }
                if (group.br != null)
                {
                    branch_name = group.br.Branch_Name;
                }
                Console.WriteLine(student_name + " -   " + branch_name);

            }
        }*/

		Parallel.For(0,  userData_Compile.Count, (iter, condBreak) =>
		{
			
            if (iter > 5)
            {
				Console.WriteLine("...");
				Console.WriteLine(Thread.CurrentThread.ManagedThreadId + "-" + iter);
				iter++;
				condBreak.Break();
            }
		});
		//<tbody>
		DataTable UserStats = new DataTable("User Statistics");
		//<td>Username
		DataColumn userColumn = new DataColumn("Username");
		userColumn.DataType = typeof(string);
		//<td>Password
		DataColumn privateColumn = new DataColumn("Password");
		privateColumn.DataType = typeof(string);
		//<td>Views
		DataColumn viewColumn = new DataColumn("Views");
		viewColumn.DataType = typeof(System.Int32);
		//<td>Comments
		DataColumn cmntColumn = new DataColumn("Comments");
		cmntColumn.DataType = typeof(System.Int32);
		
		ParallelOptions options = new ParallelOptions();

		UserStats.Columns.Add(userColumn);
		UserStats.Columns.Add(privateColumn);
		UserStats.Columns.Add(viewColumn);
		UserStats.Columns.Add(cmntColumn);

		options.MaxDegreeOfParallelism = 3;
		//int i = 0;
		
		Parallel.ForEach(userData_Compile, options, iter =>
		{
			
			string UserProfile = ("Username: " + iter.Username + " | Password: " + iter.Password + "\nViews: " + iter.Views + "; Comments: " + iter.Comments);
			Console.WriteLine(UserProfile);

			DataRow insertData = UserStats.NewRow();
			insertData["Username"] = iter.Username;
			insertData["Password"] = iter.Password;
			insertData["Views"] = iter.Views;
			insertData["Comments"] = iter.Comments;
			
		});

		DataSet dataSet = new DataSet();
		dataSet.Tables.Add(UserStats);


		IEnumerable<int> pwData_0 = userData_Compile.Select(n => IntegerExtension.PW_StrLength(n.Password));
		foreach (int n in pwData.ToList())
		{
			Console.WriteLine("Password(Length): " + n);
		}

		IEnumerable<double> avgData_0 = userData_Compile.Select(n => IntegerExtension.AVG_Interaction(n.Views, n.Comments));

		var userData_Custom = userData_Compile.Select(n => new
		{
			User = n.Username,
			Password = n.Password,
			Length = IntegerExtension.PW_StrLength(n.Password),
			Average = IntegerExtension.AVG_Interaction(n.Views, n.Comments)
	
		}).ToList();
		foreach(var output_0 in userData_Custom.ToList())
        {
			Console.WriteLine("Username: " + output_0.User + " | Password: " + output_0.Password + "\nPassword(Length): " 
				+ output_0.Length + " | Avg. Interaction: " + output_0.Average);
        }

		var topicData_Custom = userData_Compile.SelectMany(n => n.Topics, (user, genre) => new { Profile = user.Username, Genre = genre }).AsEnumerable();
        foreach (var n in topicData_Custom.ToList())
        {
			Console.WriteLine(n.Profile + ": " + n.Genre);
        }

		IQueryable<string> user_Query = userData_Compile.Select(n => n.Username).AsQueryable().Take(2);

		var mostViews = (from n in userData_Compile select n.Views).Max();
		Console.WriteLine("[Most] Views: " + mostViews); //  -  IEnumerable ... Username + mostViews

		List<UserData> filterComment = userData_Compile.Select(item => item).Where(item => item.Comments > 10).ToList();
        foreach (var item in filterComment)
        {
			Console.WriteLine("Username: " + item.Username + " | Comments (Total): " + item.Comments);
        }

		//List<UserData> orderedData_acsend = userData_Compile.OrderBy(item => item.Views).ToList();
		//foreach(var item in orderData_ascend)
        //{
		//	Console.WriteLine(item.Username + " |Views (Total): " + item.Views);
        //}

		//a. Order Operators - SYNTAX(below): OrderedBy, OrderByDescending, ThenBy, ThenByDecending, Reverse [...]
		List<UserData> orderedData_desc = userData_Compile.OrderByDescending(n => n.Views).ToList();
		foreach(var item in orderedData_desc)
        {
			Console.WriteLine(item.Username + " |Views (Total): " + item.Views);
        }

		List<UserData> transferData = userData_Compile.Union(transferData_Compile).ToList();
        foreach (var iter_0 in transferData)
        {
			string UserProfile = ("Username: " + iter_0.Username + " | Password: " + iter_0.Password + "\nViews: " + iter_0.Views + "; Comments: " + iter_0.Comments);
			Console.WriteLine(UserProfile);
		}
		
		List<UserData> transferData_Intersect = transferData.Select(item => item).Where(item => item.Comments > 10).Intersect(transferData_Compile).ToList();
		foreach(var item in transferData_Intersect)
		{
			Console.WriteLine("Username: " + item.Username + " | Comments (Total): " + item.Comments);
		}

		List<UserData> transferData_OrderThenBy = transferData.OrderBy(item => item.Comments).ThenBy(item => item.Views).ToList();
		foreach(UserData item in transferData_OrderThenBy)
        {
			Console.WriteLine("Username: " + item.Username + " | Views(Total): " + item.Views + " | Comments(Total): " + item.Comments);
        }

		List<int> statData_TypeOf = userData_Compile.OfType<int>().ToList();
		foreach(int item in statData_TypeOf)
        {
			Console.WriteLine(item);
		}//Review ... *Not printing to console;

		IEnumerable<int> statComment_Reverse = userData_Compile.Select(item => item.Comments).Reverse();
		foreach(int item in statComment_Reverse)
        {
			Console.WriteLine("[Reverse] Comments?" + item);
        }


		//XVI. Aggregate Operators(Sum, Max, Min, Average, Count, *custom
		int SumValue = transferData.Select(item => item.Views).Sum();
		Console.WriteLine("(Total)Views: " + SumValue);
		int MaxValue = transferData.Select(item => item.Views).Max();
		int MinValue = transferData.Select(item => item.Views).Min();
		double AvgValue = transferData.Select(item => item.Views).Average();
		Console.WriteLine("(Max)Views: " + MaxValue);
		Console.WriteLine("(Min)Views: " + MinValue);
		Console.WriteLine("(Avg)Views: " + AvgValue);

		int countUsers = transferData.Select(item => item).Count();
		Console.WriteLine("(Total)_#Users: " + countUsers);

		List<UserData> interAgr = transferData.Select(item => item).ToList();
		foreach(var item in interAgr)
        {
			int iViews = item.Views;
			int iComments = item.Comments;
			List<int> sumInteraction = new List<int>();
			sumInteraction.Add(iViews);
			sumInteraction.Add(iComments);
			int total = sumInteraction.Aggregate((a, b) => a + b);

			Console.WriteLine("Unsername: " + item.Username + " (Total)Interaction: " + total);
		}//
	}
}
