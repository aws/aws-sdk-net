using System.Text.Json;
using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Generation.Customizations;
using SmithyDotNet.Generator.Generation.Operations;
using SmithyDotNet.Generator.Generation.Paginators;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Model.Traits;
using SmithyDotNet.Generator.Writers.Paginators;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Generation.Paginators;

public class PaginationResolverTests
{
    [Fact]
    public void Resolves_WithItems()
    {
        // ListThings declares every trait field itself with member names that differ from the
        // service-level defaults, so this also proves operation values win over the defaults.
        var op = Resolve("ListThings");

        Assert.Equal(["NextToken"], op.InputTokenProperties);
        Assert.Equal(["NextToken"], op.OutputTokenProperties);
        Assert.Equal("MaxResults", op.PageSizeProperty);
        Assert.Equal([new PaginatedResultKey("Things", "Things", "Thing")], op.ResultKeys);
    }

    [Fact]
    public void Resolves_WithoutItems()
    {
        var op = Resolve("ListWidgets");

        Assert.Equal(["NextToken"], op.InputTokenProperties);
        Assert.Equal(["NextToken"], op.OutputTokenProperties);
        Assert.Equal("MaxItems", op.PageSizeProperty);
        Assert.Empty(op.ResultKeys);
    }

    [Fact]
    public void Resolves_DottedOutputTokenAndItems()
    {
        var op = Resolve("ListSummaries");

        Assert.Equal(["Marker"], op.InputTokenProperties);
        Assert.Equal(["SummaryList.NextMarker"], op.OutputTokenProperties);
        Assert.Equal([new PaginatedResultKey("Items", "SummaryList.Items", "Summary")], op.ResultKeys);
    }

    [Fact]
    public void Resolves_MapItems_WithoutItemsEnumerable()
    {
        var op = Resolve("GetUsage");

        Assert.Equal(["Position"], op.InputTokenProperties);
        Assert.Equal(["Position"], op.OutputTokenProperties);
        Assert.Empty(op.ResultKeys);
    }

    [Fact]
    public void Resolves_ServiceLevelDefaults()
    {
        // ListFunctions declares only "items"; the tokens and page size come from the
        // service shape's @paginated trait.
        var op = Resolve("ListFunctions");

        Assert.Equal(["Marker"], op.InputTokenProperties);
        Assert.Equal(["NextMarker"], op.OutputTokenProperties);
        Assert.Equal("MaxItems", op.PageSizeProperty);
        Assert.Equal([new PaginatedResultKey("Functions", "Functions", "Function")], op.ResultKeys);
    }

    [Fact]
    public void Resolves_UnionItemsElement()
    {
        var (index, _) = LoadPaginatedModel();
        var op = MakeOperation("""{ "inputToken": "nextToken", "outputToken": "nextToken", "items": "choices" }""");

        var result = PaginationResolver.Resolve([op], index, new CustomizationsModel()).Single();

        Assert.Equal([new PaginatedResultKey("Choices", "Choices", "TestUnion")], result.ResultKeys);
    }

    [Fact]
    public void Resolves_UnmappableItemsElement_WithoutItemsEnumerable()
    {
        var (index, _) = LoadPaginatedModel();

        // "matrix" is a list of lists, which has no flattened enumerable
        var op = MakeOperation("""{ "inputToken": "nextToken", "outputToken": "nextToken", "items": "matrix" }""");

        var result = PaginationResolver.Resolve([op], index, new CustomizationsModel()).Single();

        Assert.Empty(result.ResultKeys);
    }

    [Fact]
    public void Resolves_EnumItemsElement_AsString()
    {
        // The items element type has to agree with the response property, which is List<string> for a
        // list<enum>. Falling through to MapPrimitive for an enum would yield no .NET mapping at all,
        // silently dropping the flattened enumerable that C2J emits
        // (OperationPaginatorConfigOption.ListItemType strips the T out of the member's own List<string>).
        var (index, _) = LoadPaginatedModel();
        var op = MakeOperation("""{ "inputToken": "nextToken", "outputToken": "nextToken", "items": "statuses" }""");

        var result = PaginationResolver.Resolve([op], index, new CustomizationsModel()).Single();

        Assert.Equal([new PaginatedResultKey("Statuses", "Statuses", "string")], result.ResultKeys);
    }

    [Fact]
    public void Resolves_ScalarItemsElement_AsNonNullable()
    {
        // The items element type has to agree with the response property, which is List<int> (non-nullable)
        // for a list<Integer>. Naming it int? (MapPrimitive's standalone mapping) would emit
        // `?? new List<int?>()` and IPaginatedEnumerable<int?> over a List<int> property — a compile break.
        var (index, _) = LoadPaginatedModel();
        var op = MakeOperation("""{ "inputToken": "nextToken", "outputToken": "nextToken", "items": "counts" }""");

        var result = PaginationResolver.Resolve([op], index, new CustomizationsModel()).Single();
        Assert.Equal([new PaginatedResultKey("Counts", "Counts", "int")], result.ResultKeys);
    }

    [Theory]
    [InlineData("""{ "inputToken": "missing", "outputToken": "nextToken" }""", "inputToken member 'missing' not found")]
    [InlineData("""{ "inputToken": "nextToken", "outputToken": "missing" }""", "outputToken member 'missing' not found")]
    [InlineData("""{ "inputToken": "nextToken", "outputToken": "nextToken", "items": "missing" }""", "items member 'missing' not found")]
    [InlineData("""{ "inputToken": "maxItems", "outputToken": "nextToken" }""", "both be strings or both be maps")]
    [InlineData("""{ "inputToken": "nextToken", "outputToken": "things" }""", "both be strings or both be maps")]
    [InlineData("""{ "inputToken": "nextToken", "outputToken": "nextToken", "items": "nextToken" }""", "expected list or map")]
    [InlineData("""{ "inputToken": "nextToken", "outputToken": "nextToken.deeper" }""", "outputToken member 'deeper' not found")]
    public void Throws_OnInvalidPaginatedTrait(string traitJson, string expectedError)
    {
        var (index, _) = LoadPaginatedModel();
        var op = MakeOperation(traitJson);

        var ex = Assert.Throws<GeneratorException>(() => PaginationResolver.Resolve([op], index, new CustomizationsModel()));
        Assert.Contains(expectedError, ex.Message);
    }

    [Fact]
    public void Throws_OnHttp2OnlyPaginatedOperation()
    {
        var (index, _) = LoadPaginatedModel();
        var op = MakeOperation("""{ "inputToken": "nextToken", "outputToken": "nextToken" }""") with { RequiresHttp2 = true };

        var ex = Assert.Throws<GeneratorException>(() => PaginationResolver.Resolve([op], index, new CustomizationsModel()));
        Assert.Contains("'TestOp' requires HTTP/2", ex.Message);
    }

    // Paginator traits name modeled members; imagebuilder and inspector2 rename their items member "responses".
    [Fact]
    public void Resolves_RenamedItemsMember_ToNewProperty()
    {
        var context = TestModels.Context(TestModels.Load("Model/paginated-model.json"), TestCustomizations.Rename("ListThingsResponse", "things", "aggregations"));

        var paginated = context.PaginatedOperations.Single(p => p.Operation.Name == "ListThings");
        Assert.Equal([new PaginatedResultKey("Aggregations", "Aggregations", "Thing")], paginated.ResultKeys);
    }

    [Fact]
    public void GetPaginated_ReturnsNull_WhenAbsent()
    {
        Assert.Null(new OperationShape().GetPaginated());
    }

    [Fact]
    public void GetPaginated_DeserializesAllFields()
    {
        var element = JsonDocument.Parse("""{ "inputToken": "a", "outputToken": "b", "items": "c", "pageSize": "d" }""").RootElement;
        var shape = new OperationShape { Traits = new Dictionary<string, JsonElement> { ["smithy.api#paginated"] = element } };
        var trait = shape.GetPaginated();

        Assert.NotNull(trait);
        Assert.Equal("a", trait.InputToken);
        Assert.Equal("b", trait.OutputToken);
        Assert.Equal("c", trait.Items);
        Assert.Equal("d", trait.PageSize);
    }

    [Fact]
    public void Customization_AddsResultKeysAfterModeledItems()
    {
        var (index, _) = LoadPaginatedModel();
        var op = MakeOperation("""{ "inputToken": "nextToken", "outputToken": "nextToken", "items": "things" }""");
        var customizations = new CustomizationsModel { Paginators = { ["TestOp"] = new() { Items = ["counts"] } } };

        var result = PaginationResolver.Resolve([op], index, customizations).Single();

        Assert.Equal([new PaginatedResultKey("Things", "Things", "Thing"), new PaginatedResultKey("Counts", "Counts", "int")], result.ResultKeys);
    }

    [Fact]
    public void Throws_WhenTokenCountsDiffer()
    {
        var (index, ops) = LoadPaginatedModel();
        var customizations = new CustomizationsModel { Paginators = { ["ListRecords"] = new() { InputToken = ["startName"], OutputToken = ["nextName", "nextType"] } } };

        var ex = Assert.Throws<GeneratorException>(() => PaginationResolver.Resolve(ops, index, customizations));
        Assert.Contains("same number of entries", ex.Message);
    }

    [Fact]
    public void Throws_WhenCustomizationRepeatsModeledField()
    {
        var (index, _) = LoadPaginatedModel();
        var op = MakeOperation("""{ "inputToken": "nextToken", "outputToken": "nextToken", "pageSize": "maxItems" }""");
        var customizations = new CustomizationsModel { Paginators = { ["TestOp"] = new() { PageSize = "maxItems" } } };

        var ex = Assert.Throws<GeneratorException>(() => PaginationResolver.Resolve([op], index, customizations));
        Assert.Contains("@paginated now models", ex.Message);
    }

    // ModelFileName only feeds the license-header comment.
    private const string ModelFileName = "paginated.json";
    private static readonly GenerationContext PaginatorContext = TestModels.Context("Model/paginated-model.json");

    [Fact]
    public void PaginatorInterfaceAndClass_EmitTokenLoopAndResultKey()
    {
        var token = TestContext.Current.CancellationToken;
        var op = PaginatorContext.PaginatedOperations.Single(p => p.Operation.Name == "ListThings");
        var interfaceCode = new PaginatorInterfaceWriter(PaginatorContext, ModelFileName).Write(op, token);
        var classCode = new PaginatorClassWriter(PaginatorContext, ModelFileName).Write(op, token);

        Assert.Contains("public interface IListThingsPaginator", interfaceCode);
        Assert.Contains("IPaginatedEnumerable<Thing> Things { get; }", interfaceCode);
        Assert.Contains("internal sealed partial class ListThingsPaginator : IPaginator<ListThingsResponse>, IListThingsPaginator", classCode);
        Assert.Contains("var nextToken = _request.NextToken;", classCode);
        Assert.Contains("nextToken = response.NextToken;", classCode);
        Assert.Contains("new PaginatedResultKeyResponse<ListThingsResponse, Thing>(this, (i) => i.Things ?? new List<Thing>());", classCode);
    }

    [Fact]
    public void PaginatorFactory_EmitsAnnotatedMethodAndConstruction()
    {
        var token = TestContext.Current.CancellationToken;
        var interfaceCode = new PaginatorFactoryInterfaceWriter(PaginatorContext, ModelFileName).Write(token);
        var classCode = new PaginatorFactoryClassWriter(PaginatorContext, ModelFileName).Write(token);

        Assert.Contains("""[AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]""", interfaceCode);
        Assert.Contains("IListThingsPaginator ListThings(ListThingsRequest request);", interfaceCode);
        Assert.Contains("return new ListThingsPaginator(this.client, request);", classCode);
    }

    [Fact]
    public void Codegen_Customizations()
    {
        var token = TestContext.Current.CancellationToken;
        var customizations = new CustomizationsModel
        {
            Paginators =
            {
                ["ListWidgets"] = new() { Items = ["widgets", "statuses"] },
                ["BatchGetWidgets"] = new() { InputToken = ["requestItems"], OutputToken = ["unprocessedKeys"], PageSize = "limit" },
                ["ListRecords"] = new() { InputToken = ["startName", "startType"], OutputToken = ["nextName", "nextType"] },
            },
            OperationModifiers = { ["ListWidgets"] = new() { StopPaginationOnSameToken = true } },
        };

        var context = new GenerationContext(new ServiceIndex(TestModels.Load("Model/paginated-model.json")), TestManifests.Example(), customizations: customizations);
        var listWidgets = context.PaginatedOperations.Single(p => p.Operation.Name == "ListWidgets");
        var batchGetWidgets = context.PaginatedOperations.Single(p => p.Operation.Name == "BatchGetWidgets");
        var listRecords = context.PaginatedOperations.Single(p => p.Operation.Name == "ListRecords");

        var factoryCode = new PaginatorFactoryInterfaceWriter(context, ModelFileName).Write(token);
        var interfaceCode = new PaginatorInterfaceWriter(context, ModelFileName).Write(listWidgets, token);
        var sameTokenClass = new PaginatorClassWriter(context, ModelFileName).Write(listWidgets, token);
        var mapTokenClass = new PaginatorClassWriter(context, ModelFileName).Write(batchGetWidgets, token);
        var multiTokenClass = new PaginatorClassWriter(context, ModelFileName).Write(listRecords, token);

        Assert.Contains("IPaginatedEnumerable<Widget> Widgets { get; }", interfaceCode);
        Assert.Contains("IPaginatedEnumerable<string> Statuses { get; }", interfaceCode);
        Assert.Contains("while (nextToken != _request.NextToken);", sameTokenClass);
        Assert.Contains("""[AWSPaginator(InputToken = ["RequestItems"], LimitKey = "Limit", OutputToken = ["UnprocessedKeys"])]""", factoryCode);
        Assert.Contains("while (nextToken?.Count > 0);", mapTokenClass);
        Assert.Contains("""[AWSPaginator(InputToken = ["StartName", "StartType"], OutputToken = ["NextName", "NextType"])]""", factoryCode);
        Assert.Contains("_request.StartType = startType;", multiTokenClass);
        Assert.Contains("startType = response.NextType;", multiTokenClass);
        Assert.Contains("while (!string.IsNullOrEmpty(startName));", multiTokenClass);
    }

    private static PaginatedOperation Resolve(string operationName)
    {
        var (index, ops) = LoadPaginatedModel();
        return PaginationResolver.Resolve(ops, index, new CustomizationsModel()).Single(p => p.Operation.Name == operationName);
    }

    private static (ServiceIndex Index, List<Operation> Operations) LoadPaginatedModel()
    {
        var index = new ServiceIndex(TestModels.Load("Model/paginated-model.json"));
        var ops = new List<Operation>();
        foreach (var opShape in index.Operations)
        {
            var input = index.Shapes[opShape.Input] as StructureShape ?? new StructureShape();
            var output = index.Shapes[opShape.Output] as StructureShape ?? new StructureShape();
            ops.Add(new Operation(opShape.Id.Name, opShape, input, output, [], RequiresHttp2: false));
        }
        return (index, ops);
    }

    // An invalid trait can't live in the model itself: Resolve processes every operation, so one
    // bad trait there would break all the happy-path tests. These ops exist only for the trait;
    // request and response share one shape with members of assorted types to point the trait at.
    private static Operation MakeOperation(string paginatedTraitJson)
    {
        var members = new Dictionary<string, MemberShape>
        {
            ["nextToken"] = new() { Target = new ShapeId("smithy.api", "String") },
            ["maxItems"] = new() { Target = new ShapeId("smithy.api", "Integer") },
            ["things"] = new() { Target = new ShapeId("com.amazonaws.testpaginated", "ThingList") },
            ["choices"] = new() { Target = new ShapeId("com.amazonaws.testpaginated", "ChoiceList") },
            ["matrix"] = new() { Target = new ShapeId("com.amazonaws.testpaginated", "ThingMatrix") },
            ["statuses"] = new() { Target = new ShapeId("com.amazonaws.testpaginated", "StatusList") },
            ["counts"] = new() { Target = new ShapeId("com.amazonaws.testpaginated", "CountList") },
        };
        var structure = new StructureShape { Id = new ShapeId("com.amazonaws.testpaginated", "TestOpIO"), Members = members };

        var opShape = new OperationShape
        {
            Traits = new Dictionary<string, JsonElement>
            {
                ["smithy.api#paginated"] = JsonDocument.Parse(paginatedTraitJson).RootElement,
            },
        };

        return new Operation("TestOp", opShape, structure, structure, [], RequiresHttp2: false);
    }
}
