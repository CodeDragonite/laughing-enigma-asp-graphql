using Courses.GraphQL.Data.Models;
using Courses.GraphQL.Data.Repositories;
using Courses.GraphQL.GraphQL.Types;
using GraphQL;
using GraphQL.Types;

namespace Courses.GraphQL.GraphQL.Queries
{
    public class CourseQuery : ObjectGraphType
    {
        private CoursesRepository _repository;
        [System.Obsolete]
        public CourseQuery(CoursesRepository repository)
        {
            //Field<ListGraphType<CourseType>>("Courses")
            //    .Resolve(context => repository.GetAllCourses());

            Field<ListGraphType<CourseType>>(
            "Courses",
            "List of Courses",
            resolve: context => repository.GetAllCourses()
            );

            Field<CourseType>("course",
                "one course",
                new QueryArguments(new QueryArgument<NonNullGraphType<IntGraphType>>
                {
                    Name = "id"
                }), resolve: context => 
                repository.GetCourseById(context.GetArgument("id", int.MinValue)));
        }

        //[GraphQLMetadata("course")]
        //public Course GetCourse(int id)
        //{
        //    return _repository.GetCourseById(id);
        //}
    }
}
