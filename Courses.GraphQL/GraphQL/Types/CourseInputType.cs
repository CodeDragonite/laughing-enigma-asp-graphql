using GraphQL.Types;

namespace Courses.GraphQL.GraphQL.Types
{
    public class CourseInputType : InputObjectGraphType
    {
        public CourseInputType()
        {
            Name = "CourseInputType";

            Field<StringGraphType>("Description");
            Field<StringGraphType>("Name");
            Field<IntGraphType>("Review");
            Field<DateGraphType>("DateAdded");
            Field<DateGraphType>("DateUpdated");

            Field<ListGraphType<ReviewInputType>>("Reviews");
        }
    }
}
