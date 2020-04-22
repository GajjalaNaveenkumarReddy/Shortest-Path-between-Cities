using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;

namespace ShortPathbetweenCities
{
    class Program
    {
        static void Main(string[] args)
        {
            var myGraph = new Graph();
            myGraph.AddLink(new Link("a", "b", 10));
            myGraph.AddLink(new Link("a", "c", 20));
            myGraph.AddLink(new Link("a", "d", 10));
            myGraph.AddLink(new Link("b", "d", 1));
            myGraph.AddLink(new Link("b", "c", 2));
        }
    }


    public class Link
    {
        public Link(string source, string target, int cost)
        {
            Source = source;
            Target = target;
            Cost = cost;
        }

        public string Source { get; set; }

        public string Target { get; set; }

        public int Cost { get; set; }

    }

    public class Graph
    {
        public List<Link> Links { get; private set; }

        public Graph()
        {
            Links = new List<Link>();
        }

        public void AddLink(Link link)
        {
            Links.Add(link);
        }

    }

}
