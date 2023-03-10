using MoodAnalyzer;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyzerFactory
    {
        public static object CreateMoodAnalyse(string className, string constructorName, string message = "")
        {
            if (message.Length == 0)
            {
                string pattern = @"." + constructorName + "";
                Match result = Regex.Match(className, pattern);
                try
                {
                    if (result.Success)
                    {
                        Assembly executing = Assembly.GetExecutingAssembly();
                        Type moodAnalyseType = executing.GetType(className);
                        if (!moodAnalyseType.Name.Equals(constructorName))
                        {
                            throw new CustomException(CustomException.ExceptionType.NO_SUCH_CONSTRUCTOR, "Constructor not found");
                        }
                        return Activator.CreateInstance(moodAnalyseType);
                    }
                    else
                    {
                        throw new CustomException(CustomException.ExceptionType.NO_SUCH_CLASS, "Class not found");
                    }
                }
                catch (CustomException e)
                {
                    return e.Message;
                }
            }
            else
            {
                Type type = Type.GetType(className);
                try
                {
                    if (type.FullName.Equals(className) || type.Name.Equals(className))
                    {
                        if (type.Name.Equals(constructorName))
                        {
                            ConstructorInfo info = type.GetConstructor(new[] { typeof(string) });
                            object instance = info.Invoke(new object[] { message });
                            return instance;
                        }
                        else
                        {
                            throw new CustomException(CustomException.ExceptionType.NO_SUCH_CONSTRUCTOR, "Constructor not found");
                        }
                    }
                    else
                    {
                        throw new CustomException(CustomException.ExceptionType.NO_SUCH_CLASS, "Class not found");
                    }
                }
                catch (Exception e)
                {
                    return e;
                }
            }

        }
    }
}