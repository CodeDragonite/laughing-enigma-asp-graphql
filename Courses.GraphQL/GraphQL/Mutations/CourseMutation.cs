using Courses.GraphQL.Data.Models;
using Courses.GraphQL.Data.Repositories;
using Courses.GraphQL.GraphQL.Types;
using GraphQL;
using GraphQL.Types;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace Courses.GraphQL.GraphQL.Mutations
{
    public class CourseMutation : ObjectGraphType
    {
        public CourseMutation(CoursesRepository repository)
        {
            Field<CourseType>(
                "AddCourse",
                "USed to add course",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<CourseInputType>> { Name = "course" }),
                resolve: context =>
                {
                    var course = context.GetArgument<Course>("course");
                    return repository.AddCourse(course);
                }
            );

            Field<CourseType>(
    "UpdateCourse",
    "USed to up course",
    arguments: new QueryArguments(
        new QueryArgument<NonNullGraphType<IdGraphType>> { Name = "id" },
        new QueryArgument<NonNullGraphType<CourseInputType>> { Name = "course" }),
    resolve: context =>
    {

        var courseId = context.GetArgument<int>("id");
        var course = context.GetArgument<Course>("course");
        return repository.UpdateCourse(courseId, course);
    }
);
        }
    }
}
