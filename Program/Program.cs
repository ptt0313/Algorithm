﻿namespace Program
{
    public class Graph
    {
        List<int>[] graph;
        Queue<int> queue;
        int[] degree;
        int size;
        public Graph()
        {
            size = 8;
            degree = new int[size];
            queue = new Queue<int>();
            graph = new List<int>[size];
            for (int i = 0; i < size; i++)
            {
                graph[i] = new List<int>();
            }
        }
        public void Insert(int vertex,int edge)
        {
            graph[vertex].Add(edge);

            degree[edge]++;
        }
        public void Show()
        {
            for (int i = 0; i < graph.Length; i++)
            {
                for (int j = 0; j < graph[i].Count; j++)
                {
                    Console.Write(graph[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        public void Search()
        {
            for (int i = 0; i < graph.Length;i++)
            {
                for (int j = 1; j < size; j++)
                {
                    if (degree[j] == 0)
                    {
                        queue.Enqueue(j);
                    }

                }
                int x = queue.Dequeue();
                Console.Write( x + ' ');
                graph[x].Clear();
            }
            
            
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region 위상 정렬
            // 방향 그래프에 존재하는 각 정점들의 선행 순서를 지키며,
            // 모든 정점을 차례대로 진행하는 알고리즘입니다.

            // 사이클이 발생하는 경우 위상 정렬을 수행할 수 없습니다.

            // DAG(Directed Acyclic Graph) : 사이클이 존재하지 않는 그래프
            // 시간 복잡도 : O(V + E)

            // 위상 정렬하는 방법
            
            // 1. 진입 차수가 0인 정점을 Queue에 삽입합니다.

            // 2. Queue에서 원소를 꺼내 연결된 모든 간선을 제거합니다.

            // 3. 간선 제거 이후에 진입 차수가 0이 된 정점을 Queue에 삽입합니다.

            // 4. Queue가 비어있을 때까지 2번에서 ~ 3번을 반복 수행합니다.

            Graph graph = new Graph();
            
            graph.Insert(1, 2);
            graph.Insert(1, 5);

            graph.Insert(2, 3);
            graph.Insert(3, 4);

            graph.Insert(4, 7);

            graph.Insert(5, 6);
            graph.Insert(6, 4);


            // graph.Show();

            graph.Search();
            #endregion
        }
    }
}
