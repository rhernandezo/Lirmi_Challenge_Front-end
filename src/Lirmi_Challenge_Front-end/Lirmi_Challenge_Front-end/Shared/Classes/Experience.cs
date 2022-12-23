using System;
namespace Lirmi_Challenge_Front_end.Shared
{
    public class Experience
    {
        public int Number { get; set; } = 1;

        public string Title { get; set; } = "";

        public string Description { get; set; } = "";

        public string Time { get; set; } = "";

        public State State { get; set; } = new State
        {
            Id = 1,
            Name = "",
            Style = ""
        };

        public int StateId { get; set; } = 1;

        public Boolean Active { get; set; } = false;
    }

    public class State
    {
        public int Id { get; set; } = 1;

        public string Name { get; set; } = "";

        public string Style { get; set; } = "";
    }
}

