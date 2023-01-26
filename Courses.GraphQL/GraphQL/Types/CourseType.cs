using Courses.GraphQL.Data.Models;
using GraphQL;
using GraphQL.Types;

namespace Courses.GraphQL.GraphQL.Types
{
    public class CourseType : ObjectGraphType<Course>
    {
        public CourseType()
        {
            Field(x => x.Id, type: typeof(IdGraphType)).Description("ID");
            Field(x => x.Description, type: typeof(StringGraphType)).Description("Description");
            Field(x => x.Name, type: typeof(StringGraphType));
            //Field(x => x.Review, type: typeof(IntGraphType));
            Field(x => x.DateAdded, type: typeof(DateGraphType));
            Field(x => x.DateUpdated, type: typeof(DateGraphType));


            Field(x => x.Reviews, type: typeof(ListGraphType<ReviewType>));
        }

    }
}
