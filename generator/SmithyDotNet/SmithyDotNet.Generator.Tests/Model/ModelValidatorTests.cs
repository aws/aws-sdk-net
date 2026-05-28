using SmithyDotNet.Generator.Model;
using SmithyDotNet.Generator.Model.Shapes;
using System.Text.Json;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Model;

public class ModelValidatorTests
{
    [Fact]
    public void Validate_ValidModel_DoesNotThrow()
    {
        var model = new SmithyModel
        {
            Version = "2.0",
            Shapes = new Dictionary<string, Shape?>
            {
                ["com.example#MyService"] = new ServiceShape { ApiVersion = "2023-01-01" },
            },
        };

        ModelValidator.Validate(model);
    }

    [Fact]
    public void Validate_WrongVersion_Throws()
    {
        var model = new SmithyModel
        {
            Version = "1.0",
            Shapes = new Dictionary<string, Shape?>
            {
                ["com.example#MyService"] = new ServiceShape { ApiVersion = "2023-01-01" },
            },
        };

        var ex = Assert.Throws<GeneratorException>(() => ModelValidator.Validate(model));
        Assert.Contains("Unsupported Smithy version", ex.Message);
    }

    [Fact]
    public void Validate_NoServiceShape_Throws()
    {
        var model = new SmithyModel
        {
            Version = "2.0",
            Shapes = new Dictionary<string, Shape?>
            {
                ["com.example#Foo"] = new StructureShape(),
            },
        };

        var ex = Assert.Throws<GeneratorException>(() => ModelValidator.Validate(model));
        Assert.Contains("exactly one service shape", ex.Message);
    }

    [Fact]
    public void Validate_MultipleServiceShapes_Throws()
    {
        var model = new SmithyModel
        {
            Version = "2.0",
            Shapes = new Dictionary<string, Shape?>
            {
                ["com.example#ServiceA"] = new ServiceShape { ApiVersion = "2023-01-01" },
                ["com.example#ServiceB"] = new ServiceShape { ApiVersion = "2023-01-01" },
            },
        };

        var ex = Assert.Throws<GeneratorException>(() => ModelValidator.Validate(model));
        Assert.Contains("exactly one service shape", ex.Message);
    }

    [Fact]
    public void Validate_MixinShape_Throws()
    {
        var model = new SmithyModel
        {
            Version = "2.0",
            Shapes = new Dictionary<string, Shape?>
            {
                ["com.example#MyService"] = new ServiceShape { ApiVersion = "2023-01-01" },
                ["com.example#MyMixin"] = new StructureShape
                {
                    Traits = new Dictionary<string, JsonElement>
                    {
                        ["smithy.api#mixin"] = JsonDocument.Parse("{}").RootElement,
                    },
                },
            },
        };

        var ex = Assert.Throws<GeneratorException>(() => ModelValidator.Validate(model));
        Assert.Contains("mixin", ex.Message);
    }
}
