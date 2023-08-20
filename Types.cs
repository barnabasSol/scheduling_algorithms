namespace scheduling_algorithm
{
    public class Process
    {
        public int id { get; set; }
        public int arrival_time { get; set; }
        public int burst_time { get; set; }
        public int priority { get; set; }
    }

    public class Solution : Process
    {
        public int completion_time { get; set; }
        public int turn_around_time { get; set; }
        public int waiting_time { get; set; }
        public int response_time { get; set; }
        public virtual List<Process>? gant_list { get; set; }
    }
}