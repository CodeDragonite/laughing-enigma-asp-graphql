using Courses.GraphQL.Data.Models;
using GraphQL;
using GraphQL.Types;

namespace Courses.GraphQL.GraphQL.Types
{
    public class ReviewType : ObjectGraphType<Review>
    {
        public ReviewType()
        {
            Field(x => x.Id, type: typeof(IdGraphType)).Description("ID");
            Field(x => x.Rate, type: typeof(IntGraphType));
            Field(x => x.Comment, type: typeof(StringGraphType)).Description("Comment");
        }

    }
}
