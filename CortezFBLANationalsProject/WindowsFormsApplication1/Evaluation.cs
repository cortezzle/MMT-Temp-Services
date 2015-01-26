using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CortezFBLA
{
   public class Evaluation
    {
        //This class makes an object from evaluation data to represent an evaluation.
       public string employee, employer, selectedEmployeeID, selectedEmployeeName, selectedEmployerID, selectedEmployerName,
           evalID, recommend, workQualComments, workHabComments, jobKnowComments, behaviorComments, overallProgressComments,
           currentEvalDate, nextEvalDate, workQualScore, workHabScore, jobKnowScore, behaviorScore, overallProgScore, avgScore;

       public Evaluation(string evalDate, string evalIdent, string employeeID, string employeeName, string employerID, string employerName, 
                         string nextEval, string workQualityScore, string workQualityComments, string workHabitScore, string workHabitComments, 
                         string jobKnowledgeScore, string jobKnowledgeComments, string behavior_Score, string behavior_Comments, string averageScore, 
                         string overallProgressScore, string overallProgComments, string recommended)
       {
           employee = employeeID + " " + employeeName;
           employer = employerID + " " + employerName;
           currentEvalDate = evalDate;
           evalID = evalIdent;
           nextEvalDate = nextEval;
           workQualScore = workQualityScore;
           workQualComments = workQualityComments;
           workHabScore = workHabitScore;
           workHabComments = workHabitComments;
           jobKnowScore = jobKnowledgeScore;
           jobKnowComments = jobKnowledgeComments;
           behaviorScore = behavior_Score;
           behaviorComments = behavior_Comments;
           avgScore = averageScore;
           overallProgScore = overallProgressScore;
           overallProgressComments = overallProgComments;
           recommend = recommended;

       }
    }
}
