using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace OM.Models
{
    public class Vertex
    {
        public string Name { get; set; }
        public int Weight { get; set; }


        //!To avoid loops and nested properties
        [JsonIgnore]
        public ICollection<Vertex> NeighbouringVertices { get; set; }
        //!To avoid loops and nested properties
        [JsonIgnore]
        public ICollection<Edge> ConnectedEdges { get; set; }

    }
}