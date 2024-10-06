namespace Pratik_Survivor.Entities
{
    public class CategoryEntity:BaseEntity
    {
        public string Name { get; set; }

        //relational Prop

        public List<CompetitorsEntity> Competitors { get; set; }
    }
}
