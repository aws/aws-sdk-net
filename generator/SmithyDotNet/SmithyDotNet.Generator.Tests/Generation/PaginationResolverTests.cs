using System.Text.Json;
using SmithyDotNet.Generator.Generation;
using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Converters;
using SmithyDotNet.Generator.Model.Shapes;
using SmithyDotNet.Generator.Model.Traits;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Generation;

public class PaginationResolverTests
{
    private static readonly JsonSerializerOptions Options = new() { Converters = { new ShapeConverter() } };

    [Fact]
    public void Resolves_WithItems()
    {
        // ListThings declares every trait field itself with member names that differ from the
        // service-level defaults, so this also proves operation values win over the defaults.
        var op = Resolve("ListThings");

        Assert.Equal("NextToken", op.InputTokenProperty);
        Assert.Equal("NextToken", op.OutputTokenProperty);
        Assert.Equal("MaxResults", op.PageSizeProperty);
        Assert.Equal("Things", op.ItemsProperty);
        Assert.Equal("Things", op.ItemsPath);
        Assert.Equal("Thing", op.ItemsElementType);
    }

    [Fact]
    public void Resolves_WithoutItems()
    {
        var op = Resolve("ListWidgets");

        Assert.Equal("NextToken", op.InputTokenProperty);
        Assert.Equal("NextToken", op.OutputTokenProperty);
        Assert.Equal("MaxItems", op.PageSizeProperty);
        Assert.Null(op.ItemsProperty);
        Assert.Null(op.ItemsElementType);
    }

    [Fact]
    public void Resolves_DottedOutputTokenAndItems()
    {
        var op = Resolve("ListSummaries");

        Assert.Equal("Marker", op.InputTokenProperty);
        Assert.Equal("SummaryList.NextMarker", op.OutputTokenProperty);
        Assert.Equal("Items", op.ItemsProperty);
        Assert.Equal("SummaryList.Items", op.ItemsPath);
        Assert.Equal("Summary", op.ItemsElementType);
    }

    [Fact]
    public void Resolves_MapItems_WithoutItemsEnumerable()
    {
        var op = Resolve("GetUsage");

        Assert.Equal("Position", op.InputTokenProperty);
        Assert.Equal("Position", op.OutputTokenProperty);
        Assert.Null(op.ItemsProperty);
        Assert.Null(op.ItemsElementType);
    }

    [Fact]
    public void Resolves_ServiceLevelDefaults()
    {
        // ListFunctions declares only "items"; the tokens and page size come from the
        // service shape's @paginated trait.
        var op = Resolve("ListFunctions");

        Assert.Equal("Marker", op.InputTokenProperty);
        Assert.Equal("NextMarker", op.OutputTokenProperty);
        Assert.Equal("MaxItems", op.PageSizeProperty);
        Assert.Equal("Functions", op.ItemsProperty);
        Assert.Equal("Function", op.ItemsElementType);
    }

    [Fact]
    public void Resolves_UnionItemsElement()
    {
        var (index, _) = LoadPaginatedModel();
        var op = MakeOperation("""{ "inputToken": "nextToken", "outputToken": "nextToken", "items": "choices" }""");

        var result = PaginationResolver.Resolve([op], index).Single();

        Assert.Equal("Choices", result.ItemsProperty);
        Assert.Equal("TestUnion", result.ItemsElementType);
    }

    [Fact]
    public void Resolves_UnmappableItemsElement_WithoutItemsEnumerable()
    {
        var (index, _) = LoadPaginatedModel();

        // "matrix" is a list of lists, which has no flattened enumerable
        var op = MakeOperation("""{ "inputToken": "nextToken", "outputToken": "nextToken", "items": "matrix" }""");

        var result = PaginationResolver.Resolve([op], index).Single();

        Assert.Null(result.ItemsProperty);
        Assert.Null(result.ItemsElementType);
    }

    [Theory]
    [InlineData("""{ "inputToken": "missing", "outputToken": "nextToken" }""", "inputToken member 'missing' not found")]
    [InlineData("""{ "inputToken": "nextToken", "outputToken": "missing" }""", "outputToken member 'missing' not found")]
    [InlineData("""{ "inputToken": "nextToken", "outputToken": "nextToken", "items": "missing" }""", "items member 'missing' not found")]
    [InlineData("""{ "inputToken": "maxItems", "outputToken": "nextToken" }""", "inputToken 'maxItems' targets")]
    [InlineData("""{ "inputToken": "nextToken", "outputToken": "things" }""", "outputToken 'things' targets")]
    [InlineData("""{ "inputToken": "nextToken", "outputToken": "nextToken", "items": "nextToken" }""", "expected list or map")]
    [InlineData("""{ "inputToken": "nextToken", "outputToken": "nextToken.deeper" }""", "outputToken member 'deeper' not found")]
    public void Throws_OnInvalidPaginatedTrait(string traitJson, string expectedError)
    {
        var (index, _) = LoadPaginatedModel();
        var op = MakeOperation(traitJson);

        var ex = Assert.Throws<GeneratorException>(() => PaginationResolver.Resolve([op], index));
        Assert.Contains(expectedError, ex.Message);
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

    private static PaginatedOperation Resolve(string operationName)
    {
        var (index, ops) = LoadPaginatedModel();
        return PaginationResolver.Resolve(ops, index).Single(p => p.Operation.Name == operationName);
    }

    private static (ServiceIndex Index, List<Operation> Operations) LoadPaginatedModel()
    {
        TargetPlatforms.Initialize("TestData");
        var model = JsonSerializer.Deserialize<SmithyModel>(File.ReadAllBytes("TestData/paginated-model.json"), Options) ?? throw new InvalidOperationException();
        var index = new ServiceIndex(model);
        var ops = new List<Operation>();
        foreach (var (opId, opShape) in index.Operations)
        {
            var input = index.Shapes[opShape.Input] as StructureShape ?? new StructureShape();
            var output = index.Shapes[opShape.Output] as StructureShape ?? new StructureShape();
            ops.Add(new Operation(opId.Name, opShape, input, output, []));
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
        };
        var structure = new StructureShape { Members = members };

        var opShape = new OperationShape
        {
            Traits = new Dictionary<string, JsonElement>
            {
                ["smithy.api#paginated"] = JsonDocument.Parse(paginatedTraitJson).RootElement,
            },
        };

        return new Operation("TestOp", opShape, structure, structure, []);
    }
}
