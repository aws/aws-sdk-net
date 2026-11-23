using SmithyDotNet.Generator.Generation.Customizations;
using Xunit;

namespace SmithyDotNet.Generator.Tests.Generation.Customizations;

/// <summary>Covers <see cref="CustomizationsModel.Load"/>: hooks are read as JSON, unknown ones fail loudly, and files merge without overlap.</summary>
public class CustomizationsModelTests
{
    private static CustomizationsModel LoadFiles(params string[] contents)
    {
        var directory = Directory.CreateTempSubdirectory("customizations-");
        try
        {
            var paths = contents.Select((json, i) =>
            {
                var path = Path.Combine(directory.FullName, $"svc.customizations.{i}.json");
                File.WriteAllText(path, json);
                return path;
            }).ToList();

            return CustomizationsModel.Load(paths);
        }
        finally
        {
            directory.Delete(recursive: true);
        }
    }

    [Fact]
    public void Load_UnsupportedHook_Throws()
    {
        var ex = Assert.Throws<GeneratorException>(() => LoadFiles("""{ "unsupportedHook": {} }"""));
        Assert.Contains("unsupportedHook", ex.Message);
    }

    [Fact]
    public void Load_RuntimePipelineOverride_ReadsOverridesInOrder()
    {
        var model = LoadFiles("""
            { "runtimePipelineOverride": { "overrides": [
                { "operation": "addBefore", "targetType": "T", "newType": "First" },
                { "operation": "addAfter", "targetType": "T", "newType": "Second" },
                { "operation": "replace", "targetType": "T", "newType": "Third", "constructorInput": "this.Config", "condition": "true" }
            ] } }
            """);

        Assert.Equal(
        [
            new PipelineOverride { Operation = PipelineOverride.AddBefore, TargetType = "T", NewType = "First" },
            new PipelineOverride { Operation = PipelineOverride.AddAfter, TargetType = "T", NewType = "Second" },
            new PipelineOverride { Operation = PipelineOverride.Replace, TargetType = "T", NewType = "Third", ConstructorInput = "this.Config", Condition = "true" },
        ], model.RuntimePipelineOverride?.Overrides ?? []);
    }

    [Theory]
    [InlineData("""[{ "operation": "remove", "targetType": "T", "newType": "N" }]""", "overrides[0] needs")]
    [InlineData("""[{ "operation": "addbefore", "targetType": "T", "newType": "N" }]""", "overrides[0] needs")]
    [InlineData("""[{ "operation": "addBefore", "targetType": "", "newType": "N" }]""", "overrides[0] needs")]
    [InlineData("""[{ "operation": "addBefore", "targetType": "T", "newType": null }]""", "newType")]
    [InlineData("""[null]""", "overrides[0] needs")]
    [InlineData("""null""", "needs an 'overrides' list")]
    [InlineData("""[{ "operation": "addBefore", "targetType": "T" }]""", "newType")]
    public void Load_RuntimePipelineOverride_MalformedOrUnsupported_Throws(string overrides, string expectedInMessage)
    {
        var ex = Assert.Throws<GeneratorException>(() => LoadFiles($$"""{ "runtimePipelineOverride": { "overrides": {{overrides}} } }"""));
        Assert.Contains(expectedInMessage, ex.Message);
    }

    [Fact]
    public void Load_RuntimePipelineOverride_InTwoFiles_Throws()
    {
        var ex = Assert.Throws<GeneratorException>(() => LoadFiles(
            """{ "runtimePipelineOverride": { "overrides": [] } }""",
            """{ "runtimePipelineOverride": { "overrides": [] } }"""));
        Assert.Contains("runtimePipelineOverride appears in more than one customizations file", ex.Message);
    }

    [Fact]
    public void Load_Service_ReadsSection()
    {
        var model = LoadFiles("""
            {
                "service": {
                    "skipClientContextParams": ["UseArnRegion"],
                    "skipDocSamples": true,
                    "requestBaseClass": "AmazonWebServiceRequest",
                    "streamingResponseBaseClass": "StreamResponse",
                    "customErrorHandling": {
                        "responseUnmarshallerBaseClass": "S3ReponseUnmarshaller",
                        "errorResponseType": "S3ErrorResponse",
                        "exceptionFactory": "ConstructS3Exception"
                    },
                    "clientDisposeMethod": "DisposeS3ExpressCredentialProvider",
                    "retryPolicyRequestList": true,
                    "customPropertyValueRules": true,
                    "endpointResolverPartial": true,
                    "endpointResolvedLabel": "Bucket",
                    "keepGreedyLabelLeadingSlash": true
                }
            }
            """);
        Assert.Equal(["UseArnRegion"], model.Service?.SkipClientContextParams);
        Assert.True(model.Service?.SkipDocSamples);
        Assert.Equal("AmazonWebServiceRequest", model.Service?.RequestBaseClass);
        Assert.Equal("StreamResponse", model.Service?.StreamingResponseBaseClass);
        Assert.Equal(TestCustomizations.ErrorHandling().CustomErrorHandling, model.Service?.CustomErrorHandling);
        Assert.Equal("DisposeS3ExpressCredentialProvider", model.Service?.ClientDisposeMethod);
        Assert.True(model.Service?.RetryPolicyRequestList);
        Assert.True(model.Service?.CustomPropertyValueRules);
        Assert.True(model.Service?.EndpointResolverPartial);
        Assert.Equal("Bucket", model.Service?.EndpointResolvedLabel);
        Assert.True(model.Service?.KeepGreedyLabelLeadingSlash);
    }

    // Each part only works with the others, so a partial set fails at load, not in the generated code.
    [Theory]
    [InlineData("responseUnmarshallerBaseClass")]
    [InlineData("errorResponseType")]
    [InlineData("exceptionFactory")]
    public void Load_CustomErrorHandling_MissingPart_Throws(string missing)
    {
        var parts = new[] { "responseUnmarshallerBaseClass", "errorResponseType", "exceptionFactory" }
            .Where(part => part != missing)
            .Select(part => $""" "{part}": "X" """);
        var ex = Assert.Throws<GeneratorException>(() => LoadFiles($$"""{ "service": { "customErrorHandling": { {{string.Join(", ", parts)}} } } }"""));
        Assert.Contains($"missing required properties including: '{missing}'", ex.Message);
    }

    [Fact]
    public void Load_Service_InTwoFiles_Throws()
    {
        var ex = Assert.Throws<GeneratorException>(() => LoadFiles(
            """{ "service": { "skipDocSamples": true } }""",
            """{ "service": { "skipDocSamples": true } }"""));
        Assert.Contains("service appears in more than one customizations file", ex.Message);
    }

    [Fact]
    public void Load_UnsupportedNestedHook_Throws()
    {
        var ex = Assert.Throws<GeneratorException>(() => LoadFiles("""{ "shapeModifiers": { "Thing": { "modify": [{ "m": { "unsupportedHook": "x" } }] } } }"""));
        Assert.Contains("unsupportedHook", ex.Message);
    }

    [Fact]
    public void Load_ShapeSubstitutions_ReadsRenameShape()
    {
        var model = LoadFiles("""{ "shapeSubstitutions": { "VpcConfigResponse": { "renameShape": "VpcConfigDetail" } } }""");
        Assert.Equal("VpcConfigDetail", model.ShapeSubstitutions["VpcConfigResponse"].RenamedShapeName);
    }

    [Fact]
    public void Load_ExcludeAndWrappingResult_ReadsHooks()
    {
        var model = LoadFiles("""
            {
              "shapeModifiers": { "PutTargetsResponse": { "exclude": ["FailedEntryCount"] } },
              "operationModifiers": {
                "InvokeAsync": { "exclude": true },
                "CreateBucket": { "name": "PutBucket" },
                "SelectObjectContent": { "clientMethodOnly": true },
                "DescribeDomain": { "useWrappingResult": true, "wrappedResultShape": "DomainDetail", "wrappedResultMember": "DomainDetail" }
              }
            }
            """);

        Assert.Equal(["FailedEntryCount"], model.ShapeModifiers["PutTargetsResponse"].Exclude);
        Assert.True(model.OperationModifiers["InvokeAsync"].Exclude);
        Assert.Equal("PutBucket", model.OperationName("CreateBucket"));
        Assert.True(model.IsClientMethodOnly("SelectObjectContent"));
        var wrap = model.OperationModifiers["DescribeDomain"];
        Assert.Equal((true, "DomainDetail", "DomainDetail"), (wrap.UseWrappingResult, wrap.WrappedResultShape, wrap.WrappedResultMember));
    }

    [Fact]
    public void Load_Ec2Hooks_ReadsHooks()
    {
        var model = LoadFiles("""
            {
              "shapeSubstitutions": { "AttributeValue": { "emitAsShape": "String", "emitFromMember": "Value", "listMemberSuffixExclusions": ["CreateDhcpOptions"] } },
              "shapeModifiers": {
                "Reservation": {
                  "modify": [{ "Url": { "locationName": "Location", "customMarshall": true, "accessModifier": "internal" } }],
                  "inject": [{ "GroupNames": { "shape": "GroupNameStringList", "documentation": "Doc", "locationName": "groupName", "customMarshall": true } }]
                }
              },
              "operationModifiers": { "CreateDhcpOptions": { "marshallNameOverrides": [{ "DhcpConfiguration": { "Values": { "marshallName": "Value" } } }] } },
              "suppressResultGeneration": ["DeleteThing"]
            }
            """,
            """{ "suppressResultGeneration": ["RejectThing"] }""");

        var substitution = model.ShapeSubstitutions["AttributeValue"];
        Assert.Equal(("String", "Value"), (substitution.EmitAsShape, substitution.EmitFromMember));
        Assert.Equal(["CreateDhcpOptions"], substitution.ListMemberSuffixExclusions);
        var property = model.ShapeModifiers["Reservation"].Modify[0]["Url"];
        Assert.Equal(("Location", true, "internal"), (property.LocationName, property.CustomMarshall, property.AccessModifier));
        var injector = model.ShapeModifiers["Reservation"].Inject[0]["GroupNames"];
        Assert.Equal(("GroupNameStringList", "Doc", "groupName", true), (injector.Shape, injector.Documentation, injector.LocationName, injector.CustomMarshall));
        Assert.Equal("Value", model.MarshallNameOverride("CreateDhcpOptions", "DhcpConfiguration", "Values"));
        Assert.Equal(["DeleteThing", "RejectThing"], model.SuppressResultGeneration);
    }

    [Fact]
    public void Load_EmitIsSetProperties_MergesAcrossFiles()
    {
        var model = LoadFiles(
            """{ "emitIsSetProperties": { "AttributeValue": ["BOOL", "M"] } }""",
            """{ "emitIsSetProperties": { "QueryInput": ["Limit"] } }""");

        Assert.Equal(["BOOL", "M"], model.EmitIsSetProperties["AttributeValue"]);
        Assert.Equal(["Limit"], model.EmitIsSetProperties["QueryInput"]);
        Assert.Equal(2, model.EmitIsSetProperties.Count);
    }

    [Fact]
    public void Load_EmitIsSetProperties_SameShapeInTwoFiles_Throws()
    {
        var ex = Assert.Throws<GeneratorException>(() => LoadFiles(
            """{ "emitIsSetProperties": { "QueryInput": ["Limit"] } }""",
            """{ "emitIsSetProperties": { "QueryInput": ["Select"] } }"""));
        Assert.Contains("emitIsSetProperties['QueryInput']", ex.Message);
    }

    // S3 splits excludeShapes between s3.customizations.json and s3.customizations.enums.json.
    [Fact]
    public void Load_ExcludeShapesAndMembers_MergeAcrossFiles()
    {
        var model = LoadFiles(
            """{ "excludeShapes": ["NotificationConfiguration"], "excludeMembers": { "PartDetail": ["ETag"] } }""",
            """{ "excludeShapes": ["Protocol"], "excludeMembers": { "S3ObjectVersion": ["Key"] } }""");

        Assert.Equal(["NotificationConfiguration", "Protocol"], model.ExcludeShapes);
        Assert.True(model.IsExcludedMember("PartDetail", "ETag"));
        Assert.True(model.IsExcludedMember("S3ObjectVersion", "Key"));
    }

    // The lists hold emitted names; the lookups take the modeled one.
    [Fact]
    public void Load_RestXmlMarshallingHooks()
    {
        var model = LoadFiles(
            """
            {
              "shapeModifiers": {
                "PutObjectRequest": {
                  "modify": [
                    { "Tagging": { "emitPropertyName": "TagSet" } },
                    { "ContentType": { "skipXmlIsSet": true } },
                    { "Range": { "injectMarshallCode": ["RangeMarshall(request, publicRequest);"] } },
                    { "ETag": { "injectUnmarshallCode": ["ETagUnmarshall(context, unmarshalledObject);"], "injectPrivateMemberAssignment": ["private string _eTag = string.Empty;"] } }
                  ],
                  "injectMarshallCodeInPayload": ["Sort(publicRequest);"],
                  "injectUnmarshallResultCode": ["Prepare(unmarshalledObject);"],
                  "skipXmlTestExpression": ["Configuration"],
                  "excludeFromMarshalling": ["TagSet"],
                  "excludeFromUnmarshalling": ["Expiration"]
                }
              }
            }
            """);

        Assert.True(model.IsExcludedFromMarshalling("PutObjectRequest", "Tagging"));
        Assert.True(model.IsExcludedFromUnmarshalling("PutObjectRequest", "Expiration"));
        Assert.True(model.SkipsXmlIsSet("PutObjectRequest", "ContentType"));
        Assert.Equal(["RangeMarshall(request, publicRequest);"], model.InjectedMarshallCode("PutObjectRequest", "Range"));
        Assert.Equal(["Sort(publicRequest);"], model.ShapeModifiers["PutObjectRequest"].InjectMarshallCodeInPayload);
        Assert.Equal(["ETagUnmarshall(context, unmarshalledObject);"], model.InjectedUnmarshallCode("PutObjectRequest", "ETag"));
        Assert.Equal(["private string _eTag = string.Empty;"], model.CustomFieldDeclaration("PutObjectRequest", "ETag"));
        Assert.Equal(["Prepare(unmarshalledObject);"], model.InjectedUnmarshallResultCode("PutObjectRequest"));
        Assert.True(model.SkipsXmlTestExpression("PutObjectRequest", "Configuration"));
    }

    // Keyed by the modeled name, unlike C2J, which reads these by a renamed member's new name.
    [Fact]
    public void Load_AccessorAndDocumentationHooks()
    {
        var model = LoadFiles(
            """
            {
              "shapeModifiers": {
                "Grantee": {
                  "modify": [
                    { "ID": { "emitPropertyName": "CanonicalUser", "injectIsSet": ["return this._canonicalUser != null;"] } },
                    { "Type": { "skipSetter": true, "skipPrivateMember": true, "additionalDocumentation": ["<para>Derived.</para>"] } }
                  ],
                  "shapeDocumentation": ["A grantee."]
                }
              },
              "operationModifiers": {
                "GetBucketReplication": { "documentation": "Retrieves the replication configuration." }
              }
            }
            """);

        Assert.Equal(["return this._canonicalUser != null;"], model.CustomIsSet("Grantee", "ID"));
        Assert.Null(model.CustomIsSet("Grantee", "CanonicalUser"));
        Assert.True(model.SkipsSetter("Grantee", "Type"));
        Assert.True(model.SkipsPrivateMember("Grantee", "Type"));
        Assert.Equal(["<para>Derived.</para>"], model.AdditionalDocumentation("Grantee", "Type"));
        Assert.Equal(["A grantee."], model.ShapeModifiers["Grantee"].ShapeDocumentation);
        Assert.Equal("Retrieves the replication configuration.", model.OperationModifiers["GetBucketReplication"].Documentation);
    }

    [Theory]
    [InlineData("""{ "excludeShapes": ["Protocol"] }""", "excludeShapes lists 'Protocol' more than once")]
    [InlineData("""{ "excludeMembers": { "PartDetail": ["Size"] } }""", "excludeMembers['PartDetail'] appears in more than one customizations file")]
    public void Load_ExcludeShapesAndMembers_RepeatedAcrossFiles_Throws(string second, string expectedInMessage)
    {
        var ex = Assert.Throws<GeneratorException>(() => LoadFiles(
            """{ "excludeShapes": ["Protocol"], "excludeMembers": { "PartDetail": ["ETag"] } }""",
            second));
        Assert.Contains(expectedInMessage, ex.Message);
    }

    [Fact]
    public void Load_FlattenShapes_MergesAcrossFiles()
    {
        var model = LoadFiles(
            """{ "flattenShapes": { "DeleteObjectsRequest": ["Delete"] } }""",
            """{ "flattenShapes": { "CopyObjectOutput": ["CopyObjectResult"] } }""");

        Assert.Equal(["Delete"], model.FlattenShapes["DeleteObjectsRequest"]);
        Assert.Equal(["CopyObjectResult"], model.FlattenShapes["CopyObjectOutput"]);
    }

    [Fact]
    public void Load_FlattenShapes_SameShapeInTwoFiles_Throws()
    {
        var ex = Assert.Throws<GeneratorException>(() => LoadFiles(
            """{ "flattenShapes": { "DeleteObjectsRequest": ["Delete"] } }""",
            """{ "flattenShapes": { "DeleteObjectsRequest": ["Other"] } }"""));
        Assert.Contains("flattenShapes['DeleteObjectsRequest'] appears in more than one customizations file", ex.Message);
    }

    // S3 keeps mergedEnums in its enums file and the other two in its main file.
    [Fact]
    public void Load_BaseClassAndEnumHooks_MergeAcrossFiles()
    {
        var model = LoadFiles(
            """{ "inheritAlternateBaseClass": { "PutObjectRequest": "PutWithACLRequest" }, "overrideTreatEnumsAsString": { "ObjectAttributesList": false } }""",
            """{ "mergedEnums": { "MFADelete": "VersionStatus" } }""");

        Assert.Equal("PutWithACLRequest", model.AlternateBaseClassFor("PutObjectRequest"));
        Assert.Null(model.AlternateBaseClassFor("GetObjectRequest"));
        Assert.Equal("VersionStatus", model.MergedEnums["MFADelete"]);
        Assert.False(model.TreatsEnumsAsString("ObjectAttributesList"));
        Assert.True(model.TreatsEnumsAsString("OtherList"));
    }

    [Theory]
    [InlineData("""{ "inheritAlternateBaseClass": { "A": "B" } }""", "inheritAlternateBaseClass['A'] appears in more than one customizations file")]
    [InlineData("""{ "mergedEnums": { "A": "B" } }""", "mergedEnums['A'] appears in more than one customizations file")]
    [InlineData("""{ "overrideTreatEnumsAsString": { "A": false } }""", "overrideTreatEnumsAsString['A'] appears in more than one customizations file")]
    public void Load_BaseClassAndEnumHooks_SameShapeInTwoFiles_Throws(string file, string expectedInMessage)
    {
        var ex = Assert.Throws<GeneratorException>(() => LoadFiles(file, file));
        Assert.Contains(expectedInMessage, ex.Message);
    }

    [Fact]
    public void Load_CombinesShapeModifiersAcrossFiles()
    {
        var merged = LoadFiles(
            """{ "shapeModifiers": { "Thing": { "modify": [] } } }""",
            """{ "shapeModifiers": { "Other": { "modify": [] } } }""");

        Assert.Equal(["Other", "Thing"], merged.ShapeModifiers.Keys.Order());
    }

    // A later entry's rename would otherwise be lost: EmittedName reads only the first.
    [Fact]
    public void Load_MemberModifiedTwice_Throws()
    {
        var ex = Assert.Throws<GeneratorException>(() => LoadFiles(
            """{ "shapeModifiers": { "Thing": { "modify": [{ "m": { "deprecatedMessage": "x" } }, { "m": { "emitPropertyName": "M2" } }] } } }"""));
        Assert.Contains("shapeModifiers['Thing'] modifies 'm' more than once", ex.Message);
    }

    [Fact]
    public void Load_SameShapeInTwoFiles_Throws()
    {
        var ex = Assert.Throws<GeneratorException>(() => LoadFiles(
            """{ "shapeModifiers": { "Thing": { "modify": [] } } }""",
            """{ "shapeModifiers": { "Thing": { "modify": [] } } }"""));
        Assert.Contains("more than one customizations file", ex.Message);
    }

    [Fact]
    public void Load_OverrideContentType_ReadsValue()
    {
        var model = LoadFiles(
            """{ "shapeModifiers": { } }""",
            """{ "overrideContentType": "application/x-amz-json-1.1" }""");
        Assert.Equal("application/x-amz-json-1.1", model.OverrideContentType);
    }

    [Fact]
    public void Load_OverrideContentType_InTwoFiles_Throws()
    {
        var ex = Assert.Throws<GeneratorException>(() => LoadFiles(
            """{ "overrideContentType": "application/x-amz-json-1.1" }""",
            """{ "overrideContentType": "application/json" }"""));
        Assert.Contains("overrideContentType appears in more than one customizations file", ex.Message);
    }

    [Fact]
    public void Load_SkipUriPropertyValidationAndGenerateUnmarshaller_CombineAcrossFiles()
    {
        var model = LoadFiles(
            """{ "skipUriPropertyValidation": ["AccountId"], "generateUnmarshaller": ["Event"] }""",
            """{ "generateUnmarshaller": ["Session"] }""");

        Assert.Equal(["AccountId"], model.SkipUriPropertyValidation);
        Assert.Equal(["Event", "Session"], model.GenerateUnmarshaller);
    }

    // The entry fields (Type, Marshaller, Unmarshaller) are capitalized, unlike every other hook's; Unmarshaller may be omitted.
    [Fact]
    public void Load_DataTypeSwap_ParsesEntry()
    {
        var customizations = LoadFiles("""{ "dataTypeSwap": { "Spend": { "Amount": { "Type": "decimal?", "Marshaller": "M" } } } }""");

        Assert.Equal(new DataTypeSwap { Type = "decimal?", Marshaller = "M" }, customizations.DataTypeSwaps["Spend"]["Amount"]);
    }

    // acm splits simpleMethods and simpleConstructors into their own sibling files alongside noArgOverloads.
    [Fact]
    public void Load_ConvenienceHooks_ReadAndMergeAcrossFiles()
    {
        var customizations = LoadFiles(
            """{ "noArgOverloads": [ "ListKeys" ] }""",
            """{ "simpleMethods": { "operations": { "DeleteCertificate": { "methodForms": [ [ "CertificateArn" ] ] } } } }""",
            """{ "simpleConstructors": { "constructors": { "DeleteCertificateRequest": { "constructorForms": [ [ "CertificateArn" ] ] } } } }""");

        Assert.True(customizations.CreateNoArgOverload("listkeys"));
        Assert.Equal([["CertificateArn"]], customizations.MethodFormsFor("DeleteCertificate"));
        Assert.Equal([["CertificateArn"]], customizations.ConstructorFormsFor("DeleteCertificateRequest"));
        Assert.Null(customizations.MethodFormsFor("Missing"));
        Assert.Null(customizations.ConstructorFormsFor("Missing"));
    }

    [Fact]
    public void Load_SimpleMethods_SameOperationInTwoFiles_Throws()
    {
        var ex = Assert.Throws<GeneratorException>(() => LoadFiles(
            """{ "simpleMethods": { "operations": { "DoThing": { "methodForms": [ [ "A" ] ] } } } }""",
            """{ "simpleMethods": { "operations": { "DoThing": { "methodForms": [ [ "B" ] ] } } } }"""));
        Assert.Contains("simpleMethods['DoThing'] appears in more than one customizations file", ex.Message);
    }
}
