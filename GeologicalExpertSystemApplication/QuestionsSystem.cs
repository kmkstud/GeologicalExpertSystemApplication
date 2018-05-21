using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeologicalExpertSystemApplication
{
	class QuestionsSystem
	{
		MainForm form;
		GeologicalGraph graph;

		double[] pass = new double[] {0.0, 0.0 };// хранит путь и значение коэффициента вероятности
		readonly Dictionary<Answers, double> probabilityMap;
		int vertex = 0;	//вершина графа
		

		public QuestionsSystem(MainForm form)
		{
			this.form = form;
			this.graph = new GeologicalGraph();
			probabilityMap = new Dictionary<Answers, double>
			{
				{ Answers.Yes, 1.0 },
				{ Answers.RatherYes, 0.7},
				{ Answers.RatherNo, 0.3 },
				{ Answers.No, 0.0 }
			};
		}

		public void Start()
		{
			form.SetNewQuestion(graph.questionMap[vertex]);
		}

		public void HandleAnswer(Answers ans)
		{
			
			if(vertex < 100) // проверяем конечняя ли вершина графа
			{
				pass[0]++;//сохраняем число ребер которые мы прошли
				pass[1] += probabilityMap[ans];// сохраняем значение вероятности
				if (probabilityMap[ans] > 0.5)
					vertex = graph.binaryTree[vertex][1];
				else
					vertex = graph.binaryTree[vertex][0];
				if (vertex >= 0 && vertex < graph.questionMap.Count)
					form.SetNewQuestion(graph.questionMap[vertex]);
			}
			if(vertex>=100)
			{
				string s;
				double p = pass[1] / pass[0];
				if (p >= 0.0 && p <= 0.3)
					s = graph.answerMap[vertex][0];
				else if (p > 0.3 && p <= 0.7)
					s = graph.answerMap[vertex][1];
				else if (p > 0.7 && p <= 1.0)
					s = graph.answerMap[vertex][2];
				else
					s = graph.answerMap[vertex][3];
				form.SetResponse(s);
			}
			
		}
	}
}
