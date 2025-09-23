using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ServiceClientGenerator.Generators;
using ServiceClientGenerator.Generators.Examples;
using ServiceClientGenerator.Generators.Marshallers;
using ServiceClientGenerator.Generators.NuGet;
using ServiceClientGenerator.Generators.SourceFiles;
using ServiceClientGenerator.Generators.TestFiles;
using StructureGenerator = ServiceClientGenerator.Generators.SourceFiles.StructureGenerator;

using Json.LitJson;
using System.Collections.Concurrent;
using ServiceClientGenerator.Generators.Endpoints;
using ServiceClientGenerator.Endpoints.Partitions;
using EventStreamExceptionGenerator = ServiceClientGenerator.Generators.SourceFiles.Exceptions.EventStreamExceptions;
using ServiceClientGenerator.Generators.AuthResolvers;

namespace ServiceClientGenerator
{
    public class GeneratorDriver
    {
        /// <summary>
        /// Generation manifest for the entire SDK.
        /// </summary>
        public GenerationManifest GenerationManifest { get; private set; }

        /// <summary>
        /// The configuration for the service, as read from the service models 
        /// manifest file.
        /// </summary>
        public ServiceConfiguration Configuration { get; private set; }

        /// <summary>
        /// The configurations for each supported platform that we can compile the service
        /// against.
        /// </summary>
        public IEnumerable<ProjectFileConfiguration> ProjectFileConfigurations { get; private set; }

        /// <summary>
        /// Runtime options for the generation process, as supplied at the command line.
        /// </summary>
        public GeneratorOptions Options { get; private set; }

        /// <summary>
        /// The folder under which all of the source files for the service
        /// will exist.
        /// </summary>
        public string ServiceFilesRoot { get; private set; }

        /// <summary>
        /// The folder under which the code analysis project for the service will exist.
        /// </summary>
        public string CodeAnalysisRoot { get; private set; }

        /// <summary>
        /// The folder under which all of the test files exist.
        /// </summary>
        public string TestFilesRoot { get; private set; }

        /// <summary>
        /// The folder under which the generated source files for a service will
        /// be placed. Typically (ServiceFilesRoot)/Generated. All content in this
        /// folder hierarchy will be deleted prior to generation if the 'Clean'
        /// generation option is set.
        /// </summary>
        public string GeneratedFilesRoot { get; private set; }

        /// <summary>
        /// The folder where all the sample files are located
        /// </summary>
        public string SampleFilesRoot { get; private set; }

        /// <summary>
        /// The folder under which all of the unit files for the service
        /// will exist.
        /// </summary>
        public string ServiceUnitTestFilesRoot { get; private set; }

        private readonly HashSet<Shape> _structuresToProcess = new HashSet<Shape>();

        private readonly HashSet<string> _processedStructures = new HashSet<string>();
        private readonly HashSet<string> _processedUnmarshallers = new HashSet<string>();
        private readonly HashSet<string> _processedMarshallers = new HashSet<string>();

        private const string BclSubFolder = "_bcl";
        private const string NetStandardSubFolder = "_netstandard";
        private string PaginatorsSubFolder = string.Format("Model{0}_bcl+netstandard", Path.AltDirectorySeparatorChar);
        private string GeneratedTestsSubFolder = string.Format("UnitTests{0}Generated", Path.AltDirectorySeparatorChar);
        private string CustomizationTestsSubFolder = string.Format("UnitTests{0}Generated{0}Customizations", Path.AltDirectorySeparatorChar);
        private string PaginatorTestsSubFolder = string.Format("UnitTests{0}Generated{0}_bcl+netstandard{0}Paginators", Path.AltDirectorySeparatorChar);

        public const string SourceSubFoldername = "src";
        public const string TestsSubFoldername = "test";
        public const string CodeAnalysisFoldername = "code-analysis";
        public const string ServicesSubFoldername = "Services";
        public const string ServicesAnalysisSubFolderName = "ServiceAnalysis";
        public const string CoreSubFoldername = "Core";
        public const string GeneratedCodeFoldername = "Generated";
        public const string CommonTestSubFoldername = "Common";
        public const string UnitTestsSubFoldername = "UnitTests";
        public const string IntegrationTestsSubFolderName = "IntegrationTests";

        // Records any new project files we produce as part of generation. If this collection is
        // not empty when we've processed all source, we must update the solution files to add
        // the new projects.
        private static readonly Dictionary<string, ProjectFileCreator.ProjectConfigurationData> NewlyCreatedProjectFiles
            = new Dictionary<string, ProjectFileCreator.ProjectConfigurationData>();

        public HashSet<string> FilesWrittenToGeneratorFolder { get; private set; }

        private static ConcurrentBag<string> codeGeneratedServiceNames = new ConcurrentBag<string>();

        public GeneratorDriver(ServiceConfiguration config, GenerationManifest generationManifest, GeneratorOptions options)
        {
            FilesWrittenToGeneratorFolder = new HashSet<string>();
            GenerationManifest = generationManifest;
            Configuration = config;
            ProjectFileConfigurations = GenerationManifest.ProjectFileConfigurations;
            Options = options;

            ServiceFilesRoot = Utils.PathCombineAlt(Options.SdkRootFolder, SourceSubFoldername, ServicesSubFoldername, Configuration.ServiceFolderName);
            ServiceUnitTestFilesRoot = Utils.PathCombineAlt(Options.SdkRootFolder, TestsSubFoldername, ServicesSubFoldername, Configuration.ServiceFolderName);

            if (config.IsTestService)
            {
                ServiceFilesRoot = ServiceUnitTestFilesRoot;
            }

            GeneratedFilesRoot = Utils.PathCombineAlt(ServiceFilesRoot, GeneratedCodeFoldername);

            CodeAnalysisRoot = Utils.PathCombineAlt(Options.SdkRootFolder, CodeAnalysisFoldername, ServicesAnalysisSubFolderName, Configuration.ServiceFolderName);

            TestFilesRoot = Utils.PathCombineAlt(Options.SdkRootFolder, TestsSubFoldername);

            codeGeneratedServiceNames.Add(Configuration.ServiceFolderName);
        }

        public void Execute()
        {
            ValidateServiceModel();

            this.FilesWrittenToGeneratorFolder.Clear();
            if (Options.Clean && !Configuration.IsChildConfig)
            {
                Console.WriteLine(@"-clean option set, deleting previously-generated code under .\Generated subfolders");

                Directory.Delete(GeneratedFilesRoot, true);
                Directory.CreateDirectory(GeneratedFilesRoot);
            }

            // .NET Framework version
            ExecuteGenerator(new ServiceClientsNetFramework(), "Amazon" + Configuration.ClassName + "Client.cs", BclSubFolder);
            ExecuteGenerator(new ServiceInterfaceNetFramework(), "IAmazon" + Configuration.ClassName + ".cs", BclSubFolder);

            // .NET Standard version
            ExecuteGenerator(new ServiceClientsNetStandard(), "Amazon" + Configuration.ClassName + "Client.cs", NetStandardSubFolder);
            ExecuteGenerator(new ServiceInterfaceNetStandard(), "IAmazon" + Configuration.ClassName + ".cs", NetStandardSubFolder);

            if (string.IsNullOrEmpty(Options.SelfServiceModel))
            {
                // Do not generate AssemblyInfo.cs and nuspec file for child model.
                // Use the one generated for the parent model.
                if (!this.Configuration.IsChildConfig && !Configuration.IsTestService)
                {
                    GenerateNuspec();

                    GenerateCodeAnalysisProject();
                }
            }

            if (!this.Configuration.IsChildConfig)
            {
                ExecuteGeneratorAssemblyInfo();
            }

            // Client config object
            ExecuteGenerator(new Generators.SourceFiles.DefaultConfiguration(), "Amazon" + Configuration.ClassName + "DefaultConfiguration.cs");
            ExecuteGenerator(new ServiceConfig(), "Amazon" + Configuration.ClassName + "Config.cs");
            ExecuteGenerator(new ServiceMetadata(), "Amazon" + Configuration.ClassName + "Metadata.cs", "Internal");

            if (Configuration.EndpointsRuleSet != null)
            {
                ExecuteGenerator(new EndpointParameters(), "Amazon" + Configuration.ClassName + "EndpointParameters.cs");
                ExecuteGenerator(new EndpointProvider(), "Amazon" + Configuration.ClassName + "EndpointProvider.cs", "Internal");
                ExecuteGenerator(new EndpointResolver(), "Amazon" + Configuration.ClassName + "EndpointResolver.cs", "Internal");
            }
            if (Configuration.EndpointTests != null)
            {
                ExecuteTestGenerator(new EndpointProviderTests(), Configuration.ClassName + "EndpointProviderTests.cs", "Endpoints");
            }

            ExecuteGenerator(new ModeledResolver(), "Amazon" + Configuration.ClassName + "AuthResolver.cs", "Internal");

            if (Configuration.Namespace == "Amazon.S3")
            {
                // The AmazonS3RetryPolicy simply populates the static list of requests to retry for a status code of 200 which returns an exception.
                ExecuteGenerator(new AmazonS3RetryPolicy(), "AmazonS3RetryPolicy.cs");
            }
            // The top level request that all operation requests are children of
            ExecuteGenerator(new BaseRequest(), "Amazon" + Configuration.ClassName + "Request.cs", "Model");

            var enumFileName = this.Configuration.IsChildConfig ?
                string.Format("ServiceEnumerations.{0}.cs", Configuration.ClassName) : "ServiceEnumerations.cs";

            // Any enumerations for the service
            // skip s3 until we're at the end of s3 client generation
            if (this.Configuration.ServiceId != "S3")
            {
                this.ExecuteGenerator(new ServiceEnumerations(), enumFileName);
            }

            // Any paginators for the service
            // skip paginators for s3 until we're at the end of s3 client generation
            if (Configuration.ServiceModel.HasPaginators && Configuration.ServiceId != "S3")
            {
                foreach (var operation in Configuration.ServiceModel.Operations)
                {
                    GeneratePaginator(operation);
                }
                ExecuteGenerator(new ServicePaginatorFactoryInterface(), $"I{Configuration.ServiceNameRoot}PaginatorFactory.cs", PaginatorsSubFolder);
                ExecuteGenerator(new ServicePaginatorFactory(), $"{Configuration.ServiceNameRoot}PaginatorFactory.cs", PaginatorsSubFolder);

                // Paginator tests only need to be generated against a single service,
                // so generate for the Test service
                if (Configuration.IsTestService)
                    GeneratePaginatorTests();
            }
      
            // Do not generate base exception if this is a child model.
            // We use the base exceptions generated for the parent model.
            if (!this.Configuration.IsChildConfig && this.Configuration.ServiceId != "S3")
            {
                this.ExecuteGenerator(new BaseServiceException(), "Amazon" + this.Configuration.ClassName + "Exception.cs");
            }

            var operations = Configuration.Namespace == "Amazon.S3" ? Configuration.ServiceModel.S3AllowListOperations : Configuration.ServiceModel.Operations;

            foreach (var operation in operations)
            {
                if (!this.Configuration.ServiceModel.Customizations.ExcludeShapes().Contains(operation.Name + "Request"))
                    GenerateRequest(operation);
                if (!this.Configuration.ServiceModel.Customizations.ExcludeShapes().Contains(operation.Name + "Response"))
                    GenerateResponse(operation);
                GenerateRequestMarshaller(operation);
                GenerateResponseUnmarshaller(operation);
                GenerateEndpointDiscoveryMarshaller(operation);
                GenerateExceptions(operation);
                GenerateStructures(operation);
                GenerateEventStreamPublisher(operation);
            }
                // Generates the Request, Response, Marshaller, Unmarshaller, and Exception objects for a given client operation


            if (Configuration.ServiceModel.Customizations.GenerateCustomUnmarshaller)
            {
                GenerateCustomUnmarshallers(Configuration.ServiceModel.Customizations.CustomUnmarshaller);
            }

            // Generate any missed structures that are not defined or referenced by a request, response, marshaller, unmarshaller, or exception of an operation
            GenerateStructures(null);

            //Generate endpoint discovery tests for classes that have an endpoint operation
            if (Configuration.ServiceModel.FindEndpointOperation() != null)
            {
                var fileName = string.Format("{0}EndpointDiscoveryMarshallingTests.cs", Configuration.ClassName);
                ExecuteTestGenerator(new EndpointDiscoveryMarshallingTests(), fileName, "Marshalling");
            }
            ExecuteProjectFileGenerators();
            // Test that simple customizations were generated correctly
            if (this.Configuration.ServiceId != "S3")
            {
                GenerateCustomizationTests();
                if (this.Configuration.ServiceModel.Customizations.HasExamples)
                {
                    var servicename = Configuration.Namespace.Split('.').Last();
                    ExecuteExampleGenerator(new ExampleCode(), servicename + ".GeneratedSamples.cs", servicename);
                    ExecuteExampleGenerator(new ExampleMetadata(), servicename + ".GeneratedSamples.extra.xml");
                }
            }

        }

        /// <summary>
        /// Generates the request class for the operation.
        /// </summary>
        /// <param name="operation">The operation object which contains info about what the request needs to contain for the operation</param>
        void GenerateRequest(Operation operation)
        {
            var baseClassString = this.Configuration.ServiceModel.Customizations.InheritAlternateBaseClass(operation.Name + "Request");
            var requestGenerator = new StructureGenerator
            {
                ClassName = operation.Name + "Request",
                BaseClass = baseClassString ?? (this.Configuration.ServiceId != "S3" ? string.Format("Amazon{0}Request", Configuration.ClassName) : "AmazonWebServiceRequest"),
                StructureType = StructureType.Request,
                Operation = operation
            };
            if (operation.RequestStructure != null)
            {
                requestGenerator.Structure = this.Configuration.ServiceModel.FindShape(operation.RequestStructure.Name);
            }

            this.ExecuteGenerator(requestGenerator, requestGenerator.ClassName + ".cs", "Model");

            if (operation.RequestStructure != null)
                this.DetermineStructuresToProcess(operation.RequestStructure, false);
        }

        void GenerateEventStreamPublisher(Operation operation)
        {
            var eventStreamStructure = operation.RequestEventStreamingMember?.Shape;
            if (eventStreamStructure == null)
                return;

            var publisherMarshaller = new EventStreamPublisherMarshaller
            {
                ClassName = eventStreamStructure.Name + "PublisherMarshaller",
                Structure = eventStreamStructure
            };

            this.ExecuteGenerator(publisherMarshaller, publisherMarshaller.ClassName + ".cs", "Model.Internal.MarshallTransformations");

            var evntTypes = new List<string>();
            foreach (var member in eventStreamStructure.Members)
            {
                if (member.Shape.IsEvent)
                {
                    evntTypes.Add(member.Shape.Name);
                    var addIntefaceImpementationGenerator = new EventCollectionAddImplementation
                    {
                        InterfaceName = "I" + eventStreamStructure.Name + "Event",
                        ClassName = member.Shape.Name
                    };
                    this.ExecuteGenerator(addIntefaceImpementationGenerator, member.Shape.Name + "." + addIntefaceImpementationGenerator.InterfaceName + ".cs", "Model");
                }
            }

            var eventCollectionInterface = new EventCollectionInterface()
            {
                InterfaceName = "I" + eventStreamStructure.Name + "Event",
                OperationName = operation.Name,
                EvntTypes = evntTypes
            };

            this.ExecuteGenerator(eventCollectionInterface, eventCollectionInterface.InterfaceName + ".cs", "Model");
        }

        private void ValidateServiceModel()
        {
            // Check to see if any of the GET operations have invalid request body members.
            foreach (var operation in Configuration.ServiceModel.Operations)
            {
                // These methods have already been released. The are broken and we need to work with the service teams to get them fixed.
                if (string.Equals(operation.HttpMethod, "GET", StringComparison.InvariantCultureIgnoreCase) && operation.RequestHasBodyMembers)
                {
                    if ((string.Equals("QuickSight", Configuration.ServiceId) && string.Equals("ListIAMPolicyAssignments", operation.Name)) ||
                       (string.Equals("OpenSearch", Configuration.ServiceId) && string.Equals("DescribeDomainAutoTunes", operation.Name)) ||
                       (string.Equals("ivs", Configuration.ServiceId) && string.Equals("ListTagsForResource", operation.Name)) ||
                       (string.Equals("EFS", Configuration.ServiceId) && string.Equals("DescribeAccountPreferences", operation.Name)) ||
                       (string.Equals("SESv2", Configuration.ServiceId) && string.Equals("ListContacts", operation.Name)) ||
                       (string.Equals("SESv2", Configuration.ServiceId) && string.Equals("ListImportJobs", operation.Name)) ||
                       (string.Equals("Elasticsearch Service", Configuration.ServiceId) && string.Equals("DescribeDomainAutoTunes", operation.Name))
                        )
                    {
                        continue;
                    }
                    throw new InvalidOperationException($"Failed to generate for service with Id {Configuration.ServiceId} because it contains a GET operation ({operation.Name}) with request body members.");
                }
            }
        }

        private void DetermineStructuresToProcess(Shape containingShape, bool includeContainingShape)
        {
            if (containingShape.IsStructure)
            {
                if (containingShape.IsDocument)
                    return;

                if (this._structuresToProcess.Contains(containingShape))
                    return;
                else if (includeContainingShape)
                    this._structuresToProcess.Add(containingShape);

                foreach (var member in containingShape.Members)
                {
                    if (member.IsStructure)
                    {
                        DetermineStructuresToProcess(member.Shape, true);
                    }
                    else if (member.IsList)
                    {
                        DetermineStructuresToProcess(member.Shape.ListShape, true);
                    }
                    else if (member.IsMap)
                    {
                        DetermineStructuresToProcess(member.Shape.ValueShape, true);
                    }
                }
            }
            else if (containingShape.IsList)
            {
                DetermineStructuresToProcess(containingShape.ListShape, true);
            }
            else if (containingShape.IsMap)
            {
                DetermineStructuresToProcess(containingShape.ValueShape, true);
            }
        }

        /// <summary>
        /// Generate the response class for the operation.
        /// </summary>
        /// <param name="operation">The operation object which contains info about what the response needs to contain for the operation</param>
        private void GenerateResponse(Operation operation)
        {
            var suppressResultGeneration = false;
            if (operation.UseWrappingResult)
            {
                // response members will be demoted to a structure contained by a
                // result container class (that is not in the service model)
                var className = operation.Name + "Response";
                string propertyName = null;
                var propertyModifier
                    = this.Configuration.ServiceModel.Customizations.GetPropertyModifier(className, operation.ResponseStructure.Name);
                if (propertyModifier != null && propertyModifier.EmitName != null)
                    propertyName = propertyModifier.EmitName;
                else
                    propertyName = operation.ResponseStructure.Name;

                var resultGenerator = new WrappingResultGenerator
                {
                    Operation = operation,
                    ClassName = className,
                    BaseClass = "AmazonWebServiceResponse",
                    Structure = this.Configuration.ServiceModel.FindShape(operation.ResponseStructure.Name),
                    PropertyName = propertyName
                };

                // emit the wrapping result but do not mark the shape as processed as a consequence
                this.ExecuteGenerator(resultGenerator, resultGenerator.ClassName + ".cs", "Model");
                DetermineStructuresToProcess(resultGenerator.Structure, true);
            }
            else
            {
                // if the operation has a suppressed result modification, use the structure generator to emit
                // an empty xxxxResponse class, derived from AmazonWebServiceResponse
                suppressResultGeneration =
                    operation.ResponseStructure == null ||
                    this.Configuration.ServiceModel.Customizations.ResultGenerationSuppressions.Contains(operation.Name);

                if (suppressResultGeneration)
                {
                    var responseGenerator = new StructureGenerator
                    {
                        ClassName = operation.Name + "Response",
                        BaseClass = "AmazonWebServiceResponse",
                        Operation = operation,
                        StructureType = StructureType.Response
                    };
                    this.ExecuteGenerator(responseGenerator, responseGenerator.ClassName + ".cs", "Model");
                }
                else
                {
                    var baseClassString = this.Configuration.ServiceModel.Customizations.InheritAlternateBaseClass(operation.Name + "Response");
                    var resultGenerator = new StructureGenerator
                    {
                        ClassName = operation.Name + "Response",
                        BaseClass = baseClassString ?? "AmazonWebServiceResponse",
                        IsWrapped = operation.IsResponseWrapped,
                        Operation = operation,
                        StructureType = StructureType.Response
                    };
                    if (operation.ResponseStructure != null)
                    {
                        if (operation.IsResponseWrapped)
                        {
                            // If IsResponseWrapped is true, the operation.ResponseStructure will point to a 
                            // the shape with same name as ResponseWrapper.
                            var resultShape = this.Configuration.ServiceModel.FindShape(operation.ResponseStructure.Name);
                            var innerShape = resultShape.Members[0].Shape;
                            resultGenerator.Structure = innerShape;
                        }
                        else
                        {
                            resultGenerator.Structure =
                                this.Configuration.ServiceModel.FindShape(operation.ResponseStructure.Name);
                        }
                    }

                    this.ExecuteGenerator(resultGenerator, resultGenerator.ClassName + ".cs", "Model");
                }

                if (operation.ResponseStructure != null)
                {
                    this.DetermineStructuresToProcess(operation.ResponseStructure, false);
                }
            }

            //if (!suppressResultGeneration)
            //{
            //    if (operation.ResponseStructure != null)
            //    {
            //        // Mark the shape as processed if it's being referred only as operation's
            //        // output shape and not being referred directly by any other shape or via an
            //        // operation modifier generating an artifical structure not in the service model.
            //        if (!IsShapeReferred(operation.ResponseStructure.Name, this.Configuration.ServiceModel)
            //            && !operation.WrapsResultShape(operation.ResponseStructure.Name))
            //            this._processedStructures.Add(operation.ResponseStructure.Name);
            //    }

            //    // This generates the legacy response class which just extends from the result class.
            //    var responseGenerator = new LegacyResponseClass()
            //    {
            //        OperationName = operation.Name
            //    };

            //    this.ExecuteGenerator(responseGenerator, operation.Name + "Response.cs", "Model");
            //}
        }

        /// <summary>
        /// Checks if the shape is referred directly by another shape
        /// </summary>
        /// <param name="shapeName">Name of the shape to look for references of</param>
        /// <param name="serviceModel">The ServiceModel containing information about the shapes of the service</param>
        /// <returns>If the shape is a member of a structure or is a list or map</returns>
        private static bool IsShapeReferred(string shapeName, ServiceModel serviceModel)
        {
            foreach (var shape in serviceModel.Shapes)
            {
                if (shape.IsStructure)
                {
                    foreach (var member in shape.Members)
                    {
                        if (member.Shape.Name == shapeName)
                        {
                            return true;
                        }
                    }
                }
                else if (shape.IsList && shape.ListShape.Name == shapeName)
                {
                    return true;
                }
                else if (shape.IsMap &&
                    (shape.ValueShape.Name == shapeName || shape.KeyShape.Name == shapeName))
                {
                    return true;
                }

            }

            return false;
        }

        /// <summary>
        /// Generates the request marshaller.
        /// </summary>
        /// <param name="operation">The operation to generate request marshallers for</param>
        void GenerateRequestMarshaller(Operation operation)
        {
            bool hasRequest = operation.RequestStructure != null;
            bool normalizeMarshallers;

            if (this.Configuration.ServiceModel.Customizations.ExcludeShapes().Contains(operation.Name + "Request"))
                return;

            BaseRequestMarshaller generator;
            GetRequestMarshaller(out generator, out normalizeMarshallers);
            generator.Operation = operation;

            this.ExecuteGenerator(generator, operation.Name + "RequestMarshaller.cs", "Model.Internal.MarshallTransformations");
            // Mark the shape as processed if it's being referred only as operation's
            // input shape and not being referred directly by any other shape or via an
            // operation modifier generating an artifical structure not in the service model.
            if (hasRequest && !IsShapeReferred(operation.RequestStructure.Name, this.Configuration.ServiceModel)
                && !operation.WrapsResultShape(operation.RequestStructure.Name))
            {
                this._processedMarshallers.Add(operation.RequestStructure.Name);
            }

            if (normalizeMarshallers && hasRequest)
            {
                var lookup = new NestedStructureLookup();
                lookup.SearchForNestedStructures(operation.RequestStructure);

                foreach (var nestedStructure in lookup.NestedStructures)
                {
                    S3NeedsCustomUpdate(nestedStructure);
                    // Skip structure marshallers that have already been generated for the parent model
                    if (IsShapePresentInParentModel(this.Configuration, nestedStructure.Name))
                        continue;

                    // Documents don't use a custom marshaller, always use DocumentMarshaller 
                    if (nestedStructure.IsDocument)
                        continue;

                    if (!this._processedMarshallers.Contains(nestedStructure.Name) && !nestedStructure.IsEventStream)
                    {
                        var structureGenerator = GetStructureMarshaller();
                        structureGenerator.Structure = nestedStructure;

                        this.ExecuteGenerator(structureGenerator, nestedStructure.Name + "Marshaller.cs", "Model.Internal.MarshallTransformations");
                        //this.processedUnmarshallers.Add(nestedStructure.Name);
                    }
                }
            }
        }

        void GeneratePaginator(Operation operation)
        {
            if (operation.Paginators != null && !operation.UnsupportedPaginatorConfig)
            {
                // Generate operation paginator
                BasePaginator paginatorGenerator = new BasePaginator();
                paginatorGenerator.Operation = operation;
                this.ExecuteGenerator(paginatorGenerator, $"{operation.Name}Paginator.cs", PaginatorsSubFolder);


                // Generate operation paginator interface
                BasePaginatorInterface paginatorInterfaceGenerator = new BasePaginatorInterface();
                paginatorInterfaceGenerator.Operation = operation;
                this.ExecuteGenerator(paginatorInterfaceGenerator, $"I{operation.Name}Paginator.cs", PaginatorsSubFolder);

            }
        }

        /// <summary>
        /// Generates the response unmarshaller along with any dependent structure unmarshallers that are called by this response unmarshaller.
        /// </summary>
        /// <param name="operation">The operation to generate the unmarshaller for</param>
        void GenerateResponseUnmarshaller(Operation operation)
        {
            {
                if (this.Configuration.ServiceModel.Customizations.ExcludeShapes().Contains(operation.Name + "Response"))
                    return;
                var baseException = string.Format("Amazon{0}Exception",
                        this.Configuration.IsChildConfig ?
                        this.Configuration.ParentConfig.ClassName : this.Configuration.ClassName);

                var generator = GetResponseUnmarshaller();
                generator.Operation = operation;
                generator.IsWrapped = operation.IsResponseWrapped;
                generator.HasSuppressedResult = this.Configuration.ServiceModel.Customizations.ResultGenerationSuppressions.Contains(operation.Name);
                generator.BaseException = baseException;

                var modifier = operation.model.Customizations.GetOperationModifiers(operation.Name);
                if (modifier != null)
                {
                    // can use wrapped member to effect a rename, even though we don't push response
                    // members down into a wrapped class
                    generator.WrappedResultMember = modifier.WrappedResultMember;
                    generator.IsWrapped = modifier.UseWrappingResult;
                }

                this.ExecuteGenerator(generator, operation.Name + "ResponseUnmarshaller.cs", "Model.Internal.MarshallTransformations");

                // Add to the list of processed unmarshallers so we don't attempt to generate a generic structure unmarshaller.
                if (operation.ResponseStructure != null)
                {
                    // Mark the shape as processed if it's being referred only as operation's
                    // output shape and not being referred directly by any other shape or via an
                    // operation modifier generating an artifical structure not in the service model.
                    if (!IsShapeReferred(operation.ResponseStructure.Name, this.Configuration.ServiceModel)
                                && !operation.WrapsResultShape(operation.ResponseStructure.Name))
                        this._processedUnmarshallers.Add(operation.ResponseStructure.Name);
                }
            }

            if (operation.ResponseStructure != null)
            {
                var lookup = new NestedStructureLookup();
                lookup.SearchForNestedStructures(operation.ResponseStructure);

                foreach (var nestedStructure in lookup.NestedStructures)
                {
                    S3NeedsCustomUpdate(nestedStructure);
                    if (this.Configuration.ServiceModel.Customizations.ExcludeShapes().Contains(nestedStructure.Name))
                        continue;
                    // Skip structure unmarshallers that have already been generated for the parent model
                    if (IsShapePresentInParentModel(this.Configuration, nestedStructure.Name))
                        continue;

                    if (this.Configuration.ServiceModel.Customizations.IsSubstitutedShape(nestedStructure.Name))
                        continue;

                    // Document structure don't need a custom marshaller, they use 
                    // the 'simple' DocumentMarshaller in AWSSDK.
                    if (nestedStructure.IsDocument)
                        continue;
                    // We don't generate an umarshaller for a member that is an event stream.
                    // instead we generated a layer over the structure. That layer is EventStreamGenerator.tt.
                    if (nestedStructure.IsEventStream)
                        continue;
                    if (this.Configuration.ServiceId == "S3" && nestedStructure.IsEvent || nestedStructure.IsEventStream)
                        continue;
                    // Skip already processed unmarshallers. This handles the case of structures being returned in mulitiple requests.
                    if (!this._processedUnmarshallers.Contains(nestedStructure.Name))
                    {
                        var generator = GetStructureUnmarshaller();
                        generator.Structure = nestedStructure;

                        this.ExecuteGenerator(generator, nestedStructure.Name + "Unmarshaller.cs", "Model.Internal.MarshallTransformations");
                        this._processedUnmarshallers.Add(nestedStructure.Name);
                    }
                    else
                    {
                        //throw new Exception();
                    }
                }
            }
        }

        private void GenerateUnmarshaller(Shape shape)
        {
            var lookup = new NestedStructureLookup();
            lookup.SearchForNestedStructures(shape);
            foreach (var nestedStructure in lookup.NestedStructures)
            {
                S3NeedsCustomUpdate(nestedStructure);
                if (this.Configuration.ServiceModel.Customizations.ExcludeShapes().Contains(nestedStructure.Name))
                    continue;
                // Skip structure unmarshallers that have already been generated for the parent model
                if (IsShapePresentInParentModel(this.Configuration, nestedStructure.Name))
                    continue;

                if (this.Configuration.ServiceModel.Customizations.IsSubstitutedShape(nestedStructure.Name))
                    continue;
                if (this.Configuration.ServiceId == "S3")
                {
                    if (shape.IsEvent || shape.IsEventStream)
                    {
                        continue;
                    }
                }
                // Document structure don't need a custom unmarshaller, they use 
                // the 'simple' DocumentMarshaller in AWSSDK.
                if (nestedStructure.IsDocument)
                    continue;
                    
                // Skip already processed unmarshallers. This handles the case of structures being returned in mulitiple requests.
                if (!this._processedUnmarshallers.Contains(nestedStructure.Name))
                {
                    var generator = GetStructureUnmarshaller();
                    generator.Structure = nestedStructure;

                    this.ExecuteGenerator(generator, nestedStructure.Name + "Unmarshaller.cs", "Model.Internal.MarshallTransformations");
                    this._processedUnmarshallers.Add(nestedStructure.Name);
                }
            }
        }

        private void GenerateCustomUnmarshallers(List<string> structures)
        {
            foreach (var structure in structures)
            {
                if (this.Configuration.ServiceModel.Customizations.ExcludeShapes().Contains(structure))
                    continue;
                var shape = this.Configuration.ServiceModel.FindShape(structure);
                GenerateUnmarshaller(shape);
            }
        }

        /// <summary>
        /// Invokes T4: <see cref="DefaultConfigurationModeGenerator"/>
        /// </summary>
        public static void GenerateDefaultConfigurationModeEnum(GenerationManifest generationManifest, GeneratorOptions options)
        {
            Console.WriteLine("Generating DefaultConfigurationMode Enum...");

            var defaultConfigurationModeFilesRoot = Utils.PathCombineAlt(options.SdkRootFolder, "src", "Core", "Amazon.Runtime");
            const string fileName = "DefaultConfigurationMode.generated.cs";

            var generator = new DefaultConfigurationModeGenerator
            {
                DefaultConfigurationModel = generationManifest.DefaultConfiguration
            };

            var text = generator.TransformText();
            WriteFile(defaultConfigurationModeFilesRoot, null, fileName, text);
        }

        /// <summary>
        /// Generates the endpoint discovery marshaller for the specified operation.
        /// </summary>
        /// <param name="operation">The operation to generate endpoint discovery marshaller for</param>
        void GenerateEndpointDiscoveryMarshaller(Operation operation)
        {
            if(operation.IsEndpointOperation || !operation.EndpointDiscoveryEnabled)
            {
                return;
            }

            var generator = new EndpointDiscoveryMarshaller
            {
                Operation = operation
            };

            this.ExecuteGenerator(generator, operation.Name + "EndpointDiscoveryMarshaller.cs", "Model.Internal.MarshallTransformations");
        }

        private void GenerateExceptions(Operation operation)
        {
            //Generate a special EventStreamException class that extends EventStreamException
            //We need a parameterless constructor to use it in EnumerableEventOutputStream. Only once per service
            if (operation.IsEventStreamOutput && !Configuration.GeneratedEventStreamException)
            {
                var eventStreamExceptionGenerator = new EventStreamExceptionGenerator();
                this.ExecuteGenerator(eventStreamExceptionGenerator, this.Configuration.ClassName + "EventStreamException.cs","Model");
                Configuration.GeneratedEventStreamException = true;
            }

            foreach (var exceptionShape in operation.Exceptions)
            {
                // Skip exceptions that have already been generated for the parent model
                if (IsExceptionPresentInParentModel(this.Configuration, exceptionShape.Name) || this._processedStructures.Contains(exceptionShape.Name))
                    continue;
                var generator = new StructureGenerator()
                {
                    ClassName = exceptionShape.Name,
                    Structure = exceptionShape,
                    BaseClass = this.Configuration.BaseException
                };
                this.ExecuteGenerator(generator, exceptionShape.Name + ".cs", "Model");
                this._processedStructures.Add(exceptionShape.Name);

                var unmarshallerGenerator = GetExceptionUnmarshaller();
                unmarshallerGenerator.Structure = exceptionShape;

                this.ExecuteGenerator(unmarshallerGenerator, exceptionShape.Name + "Unmarshaller.cs", "Model.Internal.MarshallTransformations");
                this._processedUnmarshallers.Add(exceptionShape.Name);

                DetermineStructuresToProcess(exceptionShape, false);
                GenerateUnmarshaller(exceptionShape);
            }

        }

        public static void GenerateCoreProjects(GenerationManifest generationManifest,
            GeneratorOptions options)
        {
            Console.WriteLine("Updating Core project files.");
            string coreFilesRoot = Utils.PathCombineAlt(options.SdkRootFolder, "src", "Core");
            var creator = new ProjectFileCreator(options);
            creator.ExecuteCore(coreFilesRoot, generationManifest.ProjectFileConfigurations);
            foreach (var newProjectKey in creator.CreatedProjectFiles.Keys)
            {
                NewlyCreatedProjectFiles.Add(newProjectKey, creator.CreatedProjectFiles[newProjectKey]);
            }
        }

        /// <summary>
        /// Generates partial Partition class used to retrieve partition-specific data.
        /// </summary>
        public static void GeneratePartitions(GeneratorOptions options)
        {
            Console.WriteLine("Generate Partition class.");
            var coreFilesRoot = Utils.PathCombineAlt(options.SdkRootFolder, "src", "Core");
            var writeToFolder = Utils.PathCombineAlt(coreFilesRoot, "Amazon.Runtime", "Internal", "Endpoints", "StandardLibrary");
            var partitionsFile = Utils.PathCombineAlt(coreFilesRoot, "partitions.json");

            var json = File.ReadAllText(partitionsFile);
            var partitions = JsonMapper.ToObject<Partitions>(json);

            var generator = new PartitionsTemplate
            {
                Partitions = partitions
            };

            var text = generator.TransformText();
            WriteFile(writeToFolder, null, "Partition.generated.cs", text);
        }

        /// <summary>
        /// Method to create/update legacy unit test projects
        /// </summary>
        public static void UpdateUnitTestProjects(GenerationManifest generationManifest, GeneratorOptions options)
        {
            string unitTestRoot = Utils.PathCombineAlt(options.SdkRootFolder, "test", "UnitTests");
            var creator = new UnitTestProjectFileCreator(options, generationManifest.UnitTestProjectFileConfigurations);
            UpdateUnitTestProjects(generationManifest.ServiceConfigurations, options, unitTestRoot, creator);
        }

        /// <summary>
        /// Adding Method to create/update service specific unit test projects
        /// </summary>
        public static List<string> UpdateUnitTestProjects(GenerationManifest generationManifest, GeneratorOptions options, string serviceTestFilesRoot, ServiceConfiguration serviceConfiguration)
        {
            string unitTestRoot = Utils.PathCombineAlt(serviceTestFilesRoot, "UnitTests");
            var creator = new UnitTestProjectFileCreator(options, generationManifest.UnitTestProjectFileConfigurations, serviceConfiguration.ServiceFolderName);
            
            UpdateUnitTestProjects(new[] { serviceConfiguration }, options, unitTestRoot, creator);

            List<string> generatedTestFiles = new List<string>();
            foreach (var file in Directory.GetFiles(unitTestRoot, "*.cs", SearchOption.AllDirectories).OrderBy(f => f))
            {
                var fullPath = Utils.ConvertPathAlt(Path.GetFullPath(file));
                if (fullPath.IndexOf($"/{GeneratedCodeFoldername}/", StringComparison.OrdinalIgnoreCase) < 0)
                    continue;
                generatedTestFiles.Add(fullPath);
            }

            return generatedTestFiles;
        }

        private static void UpdateUnitTestProjects(IEnumerable<ServiceConfiguration> serviceConfigurations, GeneratorOptions options, string unitTestRoot, UnitTestProjectFileCreator creator)
        {
            Console.WriteLine("Updating unit test project files.");
            creator.Execute(unitTestRoot, serviceConfigurations, false);
        }

        public static void UpdateSolutionFiles(GenerationManifest manifest, GeneratorOptions options)
        {
            Console.WriteLine("Updating solution files.");
            var solutionFileCreator = new SolutionFileCreator
            {
                Options = options,
                ProjectFileConfigurations = manifest.ProjectFileConfigurations
            };

            solutionFileCreator.Execute(NewlyCreatedProjectFiles);
        }

        public static void UpdateCodeAnalysisSolution(GenerationManifest manifest, GeneratorOptions options)
        {
            Console.WriteLine("Updating code analysis solution file.");
            var creator = new CodeAnalysisSolutionCreator
            {
                Options = options
            };
            creator.Execute();
        }

        public static void UpdateAssemblyVersionInfo(GenerationManifest manifest, GeneratorOptions options)
        {
            var updater = new CoreAssemblyInfoUpdater(options, manifest);
            updater.Execute();
        }

        public static void UpdateNuGetPackagesInReadme(GenerationManifest manifest, GeneratorOptions options)
        {
            var nugetPackages = new Dictionary<string, string>();
            foreach (var service in manifest.ServiceConfigurations.OrderBy(x => x.ClassName))
            {
                if (service.ParentConfig != null || service.IsTestService)
                    continue;

                if (string.IsNullOrEmpty(service.Synopsis))
                    throw new Exception(string.Format("{0} is missing a synopsis in the manifest.", service.ClassName));
                var assemblyName = service.Namespace.Replace("Amazon.", "AWSSDK.");
                nugetPackages[assemblyName] = service.Synopsis;
            }

            NuGetPackageReadmeSection generator = new NuGetPackageReadmeSection();
            var session = new Dictionary<string, object> { { "NugetPackages", nugetPackages } };
            generator.Session = session;
            var nugetPackagesText = generator.TransformText();

            var readmePath = Utils.PathCombineAlt(options.SdkRootFolder, "..", "README.md");
            var originalContent = File.ReadAllText(readmePath);

            int startPos = originalContent.IndexOf('\n', originalContent.IndexOf("### NuGet Packages")) + 1;
            int endPos = originalContent.IndexOf("### Code Generator");

            var newContent = originalContent.Substring(0, startPos);
            newContent += nugetPackagesText + "\r\n";
            newContent += originalContent.Substring(endPos);

            File.WriteAllText(readmePath, newContent);
        }

        /// <summary>
        /// Provides a way to generate the necessary attributes and marshallers/unmarshallers for nested structures to work
        /// </summary>
        class NestedStructureLookup
        {
            public List<Shape> NestedStructures { get; private set; }

            public NestedStructureLookup()
            {
                NestedStructures = new List<Shape>();
            }

            /// <summary>
            /// Function that recursively searches for structures of a given shape
            /// </summary>
            /// <param name="structure">The shape to look for recursive structures in</param>
            public void SearchForNestedStructures(Shape structure)
            {
                if (NestedStructures.Contains(structure))
                    return;

                if (structure.IsStructure)
                    NestedStructures.Add(structure);

                if (structure.IsList)
                {
                    if (structure.ListShape.IsStructure || structure.ListShape.IsList || structure.ListShape.IsMap)
                    {
                        SearchForNestedStructures(structure.ListShape);
                    }
                }
                else if (structure.IsMap)
                {
                    if (structure.ValueShape.IsStructure || structure.ValueShape.IsList || structure.ValueShape.IsMap)
                    {
                        SearchForNestedStructures(structure.ValueShape);
                    }
                }
                else if (structure.IsStructure)
                {
                    foreach (var member in structure.Members)
                    {
                        SearchForNestedStructures(member.Shape);
                    }
                }

            }
        }

        /// <summary>
        /// Generates all the POCOs that go in the Model namespace for the structures defined in the service model.
        /// </summary>
        void GenerateStructures(Operation operation)
        {
            var excludedOperations = Configuration.ServiceModel.ExcludedOperations;

            foreach (var definition in this._structuresToProcess)
            {
                S3NeedsCustomUpdate(definition);
                if (this.Configuration.ServiceModel.Customizations.ExcludeShapes().Contains(definition.Name))
                    continue;

                // Skip structures that have already been generated for the parent model
                if (IsShapePresentInParentModel(this.Configuration, definition.Name))
                    continue;

                // Skip structures that are only used as input event streams. Those structures are handled separately as part of the GenerateEventStreamPublisher method.
                if (definition.IsEventStream && !Configuration.ServiceModel.Operations.Any(x => string.Equals(x.ResponseEventStreamingMember?.Shape.Name, definition.Name)))
                    continue;

                if (this.Configuration.ServiceId == "S3")
                {
                    if (definition.IsEvent || definition.IsEventStream)
                    {
                        continue;
                    }
                }
                if (!this._processedStructures.Contains(definition.Name))
                {
                    var baseClassString = this.Configuration.ServiceModel.Customizations.InheritAlternateBaseClass(definition.Name);
                    // if the shape had a substitution, we can skip generation
                    if (this.Configuration.ServiceModel.Customizations.IsSubstitutedShape(definition.Name))
                        continue;

                    // if the shape is a request or response type and the parent operation
                    // was excluded, then skip generation
                    var opName = definition.RelatedOperationName;
                    if (!string.IsNullOrEmpty(opName) && excludedOperations.Contains(opName))
                        continue;

                    var generator = new StructureGenerator()
                    {
                        ClassName = definition.Name,
                        Structure = definition,
                        Config = this.Configuration,
                        Operation = operation,
                        BaseClass = baseClassString ?? ""
                    };
                    //since eventstream operations can attach exceptions to the request or response objects instead of the "error"
                    //list on the operation, we must account for the case where an exception is included as a member of the response
                    //but not on the operation's error list. In that case we make sure the structure inherits the base exception
                    if (definition.IsException)
                    {
                        generator.BaseClass = this.Configuration.BaseException;
                        var unmarshallerGenerator = GetExceptionUnmarshaller();
                        unmarshallerGenerator.Structure = definition;

                        this.ExecuteGenerator(unmarshallerGenerator, definition.Name + "Unmarshaller.cs", "Model.Internal.MarshallTransformations");
                        this._processedUnmarshallers.Add(definition.Name);

                        DetermineStructuresToProcess(definition, false);
                        GenerateUnmarshaller(definition);
                    }

                    this.ExecuteGenerator(generator, definition.Name + ".cs", "Model");
                    this._processedStructures.Add(definition.Name);
                }
            }
        }

        static bool IsShapePresentInParentModel(ServiceConfiguration config, string shapeName)
        {
            if (config.IsChildConfig)
            {
                // Check to see if the structure is present in a parent model
                if (config.ParentConfig.ServiceModel.Shapes.SingleOrDefault(
                    e => e.Name.Equals(shapeName)) != null)
                {
                    return true;
                }
            }

            return false;
        }

        static bool IsExceptionPresentInParentModel(ServiceConfiguration config, string exceptionName)
        {
            if (config.IsChildConfig)
            {
                // Check to see if the exception is present in a parent model
                if (config.ParentConfig.ServiceModel.Exceptions.SingleOrDefault(
                        e => e.Name.Equals(exceptionName)) != null)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Generates any missing project files for a service
        /// </summary>
        void ExecuteProjectFileGenerators()
        {
            var creator = new ProjectFileCreator(Options);
            creator.Execute(ServiceFilesRoot, this.Configuration, this.ProjectFileConfigurations);
            foreach (var newProjectKey in creator.CreatedProjectFiles.Keys)
            {
                NewlyCreatedProjectFiles.Add(newProjectKey, creator.CreatedProjectFiles[newProjectKey]);
            }
        }

        void GenerateNuspec()
        {
            var coreVersion = GenerationManifest.CoreVersion;

            // we're generating services only, so can automatically add the core runtime
            // as a dependency
            var awsDependencies = new Dictionary<string, string>(StringComparer.Ordinal);

            if (Configuration.SdkDependencies != null)
            {
                var dependencies = Configuration.SdkDependencies;
                foreach (var kvp in dependencies)
                {
                    var sdkDependency = kvp.Key;
                    var version = kvp.Value;
                    var dependentService = GenerationManifest.ServiceConfigurations.FirstOrDefault(x => string.Equals(x.Namespace, "Amazon." + sdkDependency, StringComparison.InvariantCultureIgnoreCase));
                    var dependentExtension = GenerationManifest.ExtensionConfigurations.FirstOrDefault(x => string.Equals(x.Name, sdkDependency, StringComparison.InvariantCultureIgnoreCase));

                    string previewFlag;
                    if ((dependentService != null && dependentService.InPreview) 
                        || (dependentExtension != null && dependentExtension.InPreview))
                    {
                        previewFlag = GenerationManifest.PreviewLabel;
                    }
                    else if (string.Equals(sdkDependency, "Core", StringComparison.InvariantCultureIgnoreCase) && GenerationManifest.DefaultToPreview)
                    {
                        previewFlag = GenerationManifest.PreviewLabel;
                    }
                    else
                    {
                        previewFlag = string.Empty;
                    }

                    var verTokens = version.Split('.');
                    var versionRange = string.Format("[{0}{2}, {1}.0{2})", version, int.Parse(verTokens[0]) + 1, previewFlag);

                    awsDependencies.Add(string.Format("AWSSDK.{0}", sdkDependency), versionRange);
                }
            }

            var nugetAssemblyName = Configuration.AssemblyTitle;
            var nugetAssemblyTitle = Configuration.AssemblyTitle.Replace("AWSSDK.", "AWSSDK - ");

            var nugetTitle = nugetAssemblyTitle;
            if (!string.IsNullOrEmpty(Configuration.NugetPackageTitleSuffix))
                nugetTitle += " " + Configuration.NugetPackageTitleSuffix;

            var session = new Dictionary<string, object>
            {
                { "AssemblyName", nugetAssemblyName },
                { "AssemblyTitle",  nugetAssemblyTitle },
                { "NetStandardSupport",  Configuration.NetStandardSupport },
                { "NetStandardCoreAssemblyName",  Configuration.ServiceFolderName },
                { "NuGetTitle",  nugetTitle },
                { "AssemblyDescription", Configuration.AssemblyDescription(includePreamble: false, includeBody: false) },
                { "AssemblyVersion", Configuration.ServiceFileVersion },
                { "AWSDependencies", awsDependencies },
                { "BaseName", Configuration.ClassName },
                { "CodeAnalysisServiceFolder", Configuration.Namespace.Replace("Amazon.", "") },
                { "ProjectFileConfigurations", ProjectFileConfigurations},
                { "ExtraTags", Configuration.Tags == null || Configuration.Tags.Count == 0 ? string.Empty : " " + string.Join(" ", Configuration.Tags) },
                { "licenseUrl", Configuration.LicenseUrl },
                { "requireLicenseAcceptance",Configuration.RequireLicenseAcceptance?"true":"false" }
            };

            if (Configuration.NugetDependencies != null)
                session.Add("NugetDependencies", Configuration.NugetDependencies);

            session["NuGetPreviewFlag"] = Configuration.InPreview ? this.GenerationManifest.PreviewLabel : "";

            var nuspecGenerator = new Nuspec { Session = session };
            var text = nuspecGenerator.TransformText();
            var nuspecFilename = nugetAssemblyName + ".nuspec";
            WriteFile(ServiceFilesRoot, string.Empty, nuspecFilename, text);
        }

        Version GetMinVersion(Version version)
        {
            var minVersion = new Version(version.Major, version.Minor);
            return minVersion;
        }
        Version GetMinVersion(string versionText)
        {
            var version = new Version(versionText);
            return GetMinVersion(version);
        }

        /// <summary>
        /// Generates tests for the customizations of the service
        /// </summary>
        void GenerateCustomizationTests()
        {
            if (this.Configuration.ServiceModel.Customizations.SimpleConstructorsModel.SimpleConstructors.Count > 0)
            {
                var constructorTests = new SimpleConstructorTests()
                {
                    Config = this.Configuration
                };

                ExecuteCustomizationTestGenerator(constructorTests, this.Configuration.ClassName + "ConstructorTests.cs", "Constructors");
            }

            if (this.Configuration.ServiceModel.Customizations.SimpleMethodsModel.SimpleMethods.Count > 0)
            {
                var methodTests = new SimpleMethodTests()
                {
                    Config = this.Configuration
                };

                ExecuteCustomizationTestGenerator(methodTests, this.Configuration.ClassName + "MethodTests.cs", "SimpleMethods");
            }
        }

        /// <summary>
        /// Runs the generator and saves the content into the generated files root.
        /// </summary>
        /// <param name="generator">The generator to use for outputting the text of the cs file</param>
        /// <param name="fileName">The name of the cs file</param>
        /// <param name="subNamespace">Adds an additional directory for the namespace</param>
        void ExecuteGenerator(BaseGenerator generator, string fileName, string subNamespace = null)
        {
            generator.Config = this.Configuration;
            generator.DefaultConfigurationModel = this.GenerationManifest.DefaultConfiguration;

            var text = generator.TransformText();

            string outputFile;
            WriteFile(GeneratedFilesRoot, subNamespace, fileName, text, true, true, out outputFile);
            FilesWrittenToGeneratorFolder.Add(outputFile);
        }

        /// <summary>
        /// Runs the generator and saves the content in the test directory.
        /// </summary>
        /// <param name="generator">The generator to use for outputting the text of the cs file</param>
        /// <param name="fileName">The name of the cs file</param>
        /// <param name="subNamespace">Adds an additional directory for the namespace</param>
        void ExecuteTestGenerator(BaseGenerator generator, string fileName, string subNamespace = null)
        {
            generator.Config = this.Configuration;
            var text = generator.TransformText();
            var outputSubFolder = subNamespace == null ? GeneratedTestsSubFolder : Utils.PathCombineAlt(GeneratedTestsSubFolder, subNamespace);
            WriteFile(ServiceUnitTestFilesRoot, outputSubFolder, fileName, text);
        }

        void ExecuteGeneratorAssemblyInfo()
        {
            var generator = new AssemblyInfo { Config = this.Configuration };
            var text = generator.TransformText();
            WriteFile(ServiceFilesRoot, "Properties", "AssemblyInfo.cs", text);
        }

        void ExecuteExampleGenerator(BaseGenerator generator, string fileName, string subNamespace = null)
        {
            generator.Config = this.Configuration;
            var text = generator.TransformText();
            var outputSubFolder = Utils.PathCombineAlt("docgenerator", "AWSSDKDocSamples");
            if (subNamespace != null)
                outputSubFolder = Utils.PathCombineAlt(outputSubFolder, subNamespace);

            var baseOutputDir = Utils.ConvertPathAlt(Path.GetFullPath(TestFilesRoot + string.Format("{0}..{0}..{0}",
                Path.AltDirectorySeparatorChar)));
            WriteFile(baseOutputDir, outputSubFolder, fileName, text);
        }

        /// <summary>
        /// Runs the generator and saves the content in the test directory.
        /// </summary>
        /// <param name="generator">The generator to use for outputting the text of the cs file</param>
        /// <param name="fileName">The name of the cs file</param>
        /// <param name="subNamespace">Adds an additional directory for the namespace</param>
        void ExecuteCustomizationTestGenerator(BaseGenerator generator, string fileName, string subNamespace = null)
        {
            generator.Config = this.Configuration;
            var text = generator.TransformText();
            var outputSubFolder = subNamespace == null ? CustomizationTestsSubFolder : Utils.PathCombineAlt(CustomizationTestsSubFolder, subNamespace);
            WriteFile(ServiceUnitTestFilesRoot, outputSubFolder, fileName, text);
        }

        /// <summary>
        /// Generates unit tests for all of the service's paginators
        /// </summary>
        void GeneratePaginatorTests()
        {
            if (this.Configuration.ServiceModel.HasPaginators && this.Configuration.GenerateConstructors)
            {
                var paginatorTests = new PaginatorTests
                {
                    Config = this.Configuration
                };

                var text = paginatorTests.TransformText();
                var outputSubFolder = PaginatorTestsSubFolder;
                WriteFile(ServiceUnitTestFilesRoot, outputSubFolder, this.Configuration.ClassName + "PaginatorTests.cs", text);
            }
        }

        internal static bool WriteFile(string baseOutputDir,
                                       string subNamespace,
                                       string filename,
                                       string content,
                                       bool trimWhitespace = true,
                                       bool replaceTabs = true)
        {
            string outputFilePath;
            return WriteFile(baseOutputDir, subNamespace, filename, content, trimWhitespace, replaceTabs, out outputFilePath);
        }

        /// <summary>
        /// Writes the contents to disk. The content will by default be trimmed of all white space and 
        /// all tabs are replaced with spaces to make the output consistent.
        /// </summary>
        /// <param name="baseOutputDir">The root folder for the owning service's generated files</param>
        /// <param name="subNamespace">An optional sub namespace under the service. (e.g. Model or Model.Internal.MarshallTransformations)</param>
        /// <param name="filename">Filename to right to</param>
        /// <param name="content">The contents to write to the file</param>
        /// <param name="trimWhitespace"></param>
        /// <param name="replaceTabs"></param>
        /// <returns>Returns false if the file already exists and has the same content.</returns>
        internal static bool WriteFile(string baseOutputDir,
                                       string subNamespace,
                                       string filename,
                                       string content,
                                       bool trimWhitespace,
                                       bool replaceTabs,
                                       out string outputFilePath)
        {
            var outputDir = !string.IsNullOrEmpty(subNamespace)
                ? Utils.PathCombineAlt(baseOutputDir, subNamespace.Replace('.', Path.AltDirectorySeparatorChar))
                : baseOutputDir;

            if (!Directory.Exists(outputDir))
                Directory.CreateDirectory(outputDir);

            var cleanContent = trimWhitespace ? content.Trim() : content;
            if (replaceTabs)
                cleanContent = cleanContent.Replace("\t", "    ");

            outputFilePath = Utils.ConvertPathAlt(Path.GetFullPath(Utils.PathCombineAlt(outputDir, filename)));
            if (File.Exists(outputFilePath))
            {
                var existingContent = File.ReadAllText(outputFilePath);
                if (string.Equals(existingContent, cleanContent))
                    return false;

                var outputFilePathFi = new FileInfo(outputFilePath);
                // Handle Windows being case insensitive when a service makes a case change for shape name.
                // Get a FileInfo that represents the casing of the file on disk
                var fi = Directory.GetFiles(outputFilePathFi.DirectoryName)
                                .Select(x => new FileInfo(x))
                                .FirstOrDefault(x => string.Equals(x.Name, outputFilePathFi.Name, StringComparison.OrdinalIgnoreCase));

                // Compare the casing on disk versus the computed value.
                if(fi.FullName != new FileInfo(outputFilePath).FullName)
                {
                    // Casing is different so delete the on disk file so we can create a new file with the correct casing.
                    File.Delete(outputFilePath);
                    Console.WriteLine("...deleting existing file that is different by case from new file: {0}", filename);
                }
            }

            File.WriteAllText(outputFilePath, cleanContent);
            Console.WriteLine("...created/updated {0}", filename);
            return true;
        }

        /// <summary>
        /// Sets the marshaller of the generator based on the service type
        /// </summary>
        /// <param name="marshaller">The marshaller to be set</param>
        /// <param name="normalizeMarshallers">If the service type is using structure marshallers then normalizeMarshallers is set to true, false otherwise</param>
        void GetRequestMarshaller(out BaseRequestMarshaller marshaller, out bool normalizeMarshallers)
        {
            normalizeMarshallers = false;
            switch (this.Configuration.ServiceModel.Type)
            {
                case ServiceType.Rest_Json:
                case ServiceType.Json:
                    marshaller = new JsonRPCRequestMarshaller();
                    normalizeMarshallers = true;
                    break;
                case ServiceType.Cbor:
                    marshaller = new CborRequestMarshaller();
                    normalizeMarshallers = true;
                    break;
                case ServiceType.Query:
                    marshaller = new AWSQueryRequestMarshaller();
                    break;
                case ServiceType.Rest_Xml:
                    marshaller = new RestXmlRequestMarshaller();
                    break;
                default:
                    throw new Exception("No request marshaller for service type: " + this.Configuration.ServiceModel.Type);
            }
        }

        /// <summary>
        /// Determines the type of marshaller that needs to be generated based on the service model type
        /// </summary>
        /// <returns>JSONRPCStructureMarshaller for Rest_Json and Json, error otherwise</returns>
        BaseRequestMarshaller GetStructureMarshaller()
        {
            switch (this.Configuration.ServiceModel.Type)
            {
                case ServiceType.Rest_Json:
                case ServiceType.Json:
                    return new JsonRPCStructureMarshaller();
                case ServiceType.Cbor:
                    return new CborStructureMarshaller();
                default:
                    throw new Exception("No structure marshaller for service type: " + this.Configuration.ServiceModel.Type);
            }
        }
        /// <summary>
        /// Determines the type of response unmarshaller to be used based on the service model type
        /// </summary>
        /// <returns>Either a JsonRPCResponseUnmarshaller, a AWSQueryResponseUnmarshaller, or a RestXmlResponseUnmarshaller. Error otherwise</returns>
        BaseResponseUnmarshaller GetResponseUnmarshaller()
        {
            switch (this.Configuration.ServiceModel.Type)
            {
                case ServiceType.Rest_Json:
                case ServiceType.Json:
                    return new JsonRPCResponseUnmarshaller();
                case ServiceType.Query:
                    if (this.Configuration.ServiceModel.IsEC2Protocol)
                        return new AWSQueryEC2ResponseUnmarshaller();
                    return new AWSQueryResponseUnmarshaller();
                case ServiceType.Rest_Xml:
                    return new RestXmlResponseUnmarshaller();
                case ServiceType.Cbor:
                    return new CborResponseUnmarshaller();
                default:
                    throw new Exception("No response unmarshaller for service type: " + this.Configuration.ServiceModel.Type);
            }
        }

        /// <summary>
        /// Determines the Unmarshaller for structures based on the service model type
        /// </summary>
        /// <returns>Either JsonRPCStructureUnmarshaller, AWSQueryStructureUnmarshaller, or RestXmlStructureUnmarshaller. Error otherwise</returns>
        BaseResponseUnmarshaller GetStructureUnmarshaller()
        {
            switch (this.Configuration.ServiceModel.Type)
            {
                case ServiceType.Rest_Json:
                case ServiceType.Json:
                    return new JsonRPCStructureUnmarshaller();
                case ServiceType.Query:
                    return new AWSQueryStructureUnmarshaller();
                case ServiceType.Rest_Xml:
                    return new RestXmlStructureUnmarshaller();
                case ServiceType.Cbor:
                    return new CborStructureUnmarshaller();
                default:
                    throw new Exception("No structure unmarshaller for service type: " + this.Configuration.ServiceModel.Type);
            }
        }
        /// <summary>
        /// Determines the Unmarshaller for structures based on the service model type
        /// </summary>
        /// <returns>Either JsonRPCStructureUnmarshaller, AWSQueryStructureUnmarshaller, or RestXmlStructureUnmarshaller. Error otherwise</returns>
        BaseResponseUnmarshaller GetExceptionUnmarshaller()
        {
            switch (this.Configuration.ServiceModel.Type)
            {
                case ServiceType.Rest_Json:
                case ServiceType.Json:
                    return new JsonRPCExceptionUnmarshaller();
                case ServiceType.Query:
                    return new AWSQueryExceptionUnmarshaller();
                case ServiceType.Rest_Xml:
                    return new RestXmlExceptionUnmarshaller();
                case ServiceType.Cbor:
                    return new CborExceptionUnmarshaller();
                default:
                    throw new Exception("No structure unmarshaller for service type: " + this.Configuration.ServiceModel.Type);
            }
        }
        void GenerateCodeAnalysisProject()
        {
            var command = new CodeAnalysisProjectCreator();
            command.Execute(CodeAnalysisRoot, this.Configuration);
        }

        public static void RemoveOrphanedShapesAndServices(HashSet<string> generatedFiles, HashSet<string> generatedTestFiles, string sdkRootFolder)
        {
            var codeGeneratedServiceList = codeGeneratedServiceNames.Distinct();

            // Cleanup services within the main sdk/services folder
            var srcFolder = Utils.PathCombineAlt(sdkRootFolder, SourceSubFoldername, ServicesSubFoldername);
            RemoveOrphanedShapes(generatedFiles, srcFolder);

            // Cleanup services within the sdk/test/services folder where it is a generated test service
            var testSrcFolder = Utils.PathCombineAlt(sdkRootFolder, TestsSubFoldername, ServicesSubFoldername);
            RemoveOrphanedShapes(generatedFiles, generatedTestFiles, testSrcFolder);
                        
            // Cleanup orphaned Service src artifacts. This is encountered when the service identifier is modified.
            RemoveOrphanedServices(srcFolder, codeGeneratedServiceList);
            // Cleanup orphaned Service test artifacts. This is encountered when the service identifier is modified.
            RemoveOrphanedServices(testSrcFolder, codeGeneratedServiceList);
            // Cleanup orphaned Service code analysis artifacts. This is encountered when the service identifier is modified.
            RemoveOrphanedServices(Utils.PathCombineAlt(sdkRootFolder, CodeAnalysisFoldername, ServicesAnalysisSubFolderName), codeGeneratedServiceList);
        }

        /// <summary>
        /// Removes orphaned */generated/* files from specified srcFolder. This can be encountered when a model 
        /// removes an operation or shape and the sub shapes are no longer needed. The file will be deleted if
        /// the file contains */generated/* as part of the path and is not a file from a current run generated 
        /// service (generatedFiles).
        /// </summary>
        /// <param name="generatedFiles">Lookup of all files that have been generated.</param>
        /// <param name="srcFolder">The path to the sdk/services folder containing generated services and manual source code.</param>
        public static void RemoveOrphanedShapes(HashSet<string> generatedFiles, string srcFolder)
        {
            foreach (var file in Directory.GetFiles(srcFolder, "*.cs", SearchOption.AllDirectories).OrderBy(f => f))
            {
                var fullPath = Utils.ConvertPathAlt(Path.GetFullPath(file));
                if (fullPath.IndexOf($"/{GeneratedCodeFoldername}/", StringComparison.OrdinalIgnoreCase) < 0)
                    continue;

                if (!generatedFiles.Contains(fullPath))
                {
                    Console.Error.WriteLine("**** Warning: Removing orphaned generated code " + Path.GetFileName(file));
                    File.Delete(file);
                }
            }
        }

        /// <summary>
        /// Removes orphaned */generated/* files from specified srcFolder. This can be encountered when a test service model 
        /// removes an operation or shape and the sub shapes are no longer needed. Special care must be taken within the 
        /// sdk/test/services folder because there is a mix of generated tests and test services. The file will be deleted if
        /// the file contains */generated/* as part of the path, is not a file from a current run generated test service (generatedFiles),
        /// and is not a file from a current run generated test (generatedTestFiles).
        /// </summary>
        /// <param name="generatedFiles">Lookup of all files that have been generated.</param>
        /// <param name="generatedTestFiles">Lookup of all the generated test files.</param>
        /// <param name="srcFolder">The path to the sdk/test/services folder containing generated tests and test services.</param>
        public static void RemoveOrphanedShapes(HashSet<string> generatedFiles, HashSet<string> generatedTestFiles, string srcFolder)
        {
            foreach (var file in Directory.GetFiles(srcFolder, "*.cs", SearchOption.AllDirectories).OrderBy(f => f))
            {
                var fullPath = Utils.ConvertPathAlt(Path.GetFullPath(file));
                if (fullPath.IndexOf($"/{GeneratedCodeFoldername}/", StringComparison.OrdinalIgnoreCase) < 0)
                    continue;

                if (!generatedFiles.Contains(fullPath) && !generatedTestFiles.Contains(fullPath))
                {
                    Console.Error.WriteLine("**** Warning: Removing orphaned generated test code " + Path.GetFileName(file));
                    File.Delete(file);
                }
            }
        }

        private static void RemoveOrphanedServices(string path, IEnumerable<string> codeGeneratedServiceList)
        {
            foreach (var directoryName in Directory.GetDirectories(path).OrderBy(d => d))
            {
                if (!codeGeneratedServiceList.Contains(new DirectoryInfo(directoryName).Name))
                {
                    Directory.Delete(directoryName, true);
                }
            }
        }

        /// <summary>
        /// Constructs endpoint constant name from a region code
        /// e.g. us-east-1 -> USEast1
        /// </summary>
        public static string ConstructEndpointName(string regionCode)
        {
            var parts = regionCode.Split('-');
            var name = parts[0].ToUpper();

            for (int i = 1; i < parts.Length; i++)
            {
                // for backward compatibility, only "northwest" is transformed into upper camel case 
                var part = parts[i] == "northwest" ? "NorthWest" : parts[i].ToUpperFirstCharacter();
                // special case for "Gov" regions, we add "Cloud" to it
                part = part == "Gov" ? part + "Cloud" : part;
                name += part;
            }

            return name;
        }

        public static List<EndpointConstant> ExtractEndpoints(GeneratorOptions options, Func<string, string> nameConverter, Func<string, string> codeConverter = null)
        {
            var coreFilesRoot = Utils.PathCombineAlt(options.SdkRootFolder, "src", "Core");
            var partitionsJsonFile = Utils.PathCombineAlt(coreFilesRoot, "partitions.json");

            var partitionsJson = JsonMapper.ToObject(File.ReadAllText(partitionsJsonFile));
            var endpoints = new List<EndpointConstant>();

            foreach (JsonData partition in partitionsJson["partitions"])
            {
                var partitionName = partition["id"].ToString();
                var partitionDnsSuffix = partition["outputs"]["dnsSuffix"].ToString();
                var hostnameTemplate = "{service}.{region}.{dnsSuffix}";
                var partitionRegionRegex = partition["regionRegex"].ToString();
                JsonData regions = partition["regions"];
                foreach (var regionCode in regions.PropertyNames)
                {
                    if (regionCode.EndsWith("-global", StringComparison.OrdinalIgnoreCase))
                    {
                        continue;
                    }

                    var regionName = regions[regionCode]["description"].ToString();
                    endpoints.Add(new EndpointConstant
                    {
                        Name = nameConverter(regionCode),
                        RegionCode = regionCode,
                        ConvertedRegionCode = codeConverter == null ? regionCode : codeConverter(regionCode),
                        RegionName = regionName,
                        PartitionName = partitionName,
                        PartitionDnsSuffix = partitionDnsSuffix,
                        PartitionRegionRegex = partitionRegionRegex,
                        HostnameTemplate = hostnameTemplate,
                    });
                }
            }

            return endpoints;
        }

        public static void GenerateEndpoints(GeneratorOptions options)
        {
            Console.WriteLine("Generating endpoints constants...");

            var coreFilesRoot = Utils.PathCombineAlt(options.SdkRootFolder, "src", "Core");
            var endpointsFilesRoot = Utils.PathCombineAlt(coreFilesRoot, "RegionEndpoint");
            const string fileName = "RegionEndpoint.generated.cs";

            var endpoints = ExtractEndpoints(options, ConstructEndpointName);
            var generator = new EndpointsGenerator
            {
                Endpoints = endpoints
            };

            var text = generator.TransformText();
            WriteFile(endpointsFilesRoot, null, fileName, text);
        }
        /// <summary>
        /// Converts region code to maintain backward compatibility with S3
        /// </summary>
        public static string ConvertS3RegionCode(string regionCode)
        {
            switch (regionCode)
            {
                case "us-east-1":
                    return "";
                case "eu-west-1":
                    return "EU";
                default:
                    return regionCode;
            }
        }

        public static void GenerateS3Enumerations(GeneratorOptions options)
        {
            Console.WriteLine("Generating S3 enumerations constants...");

            var srcFilesRoot = Utils.PathCombineAlt(options.SdkRootFolder, "src");
            var coreFilesRoot = Utils.PathCombineAlt(srcFilesRoot, "Core");
            var generatedFileRoot = Utils.PathCombineAlt(srcFilesRoot, "Services", "S3", "Generated");
            const string fileName = "S3Enumerations.cs";

            var endpoints = ExtractEndpoints(options, ConstructEndpointName, ConvertS3RegionCode);
            var generator = new S3EnumerationsGenerator()
            {
                Endpoints = endpoints
            };
            var text = generator.TransformText();
            WriteFile(generatedFileRoot, null, fileName, text);
        }

        // in some cases we have deviated too far from the S3 model. For example for "Filter" shapes where we implement
        // the visitor pattern for the different predicate types. This method will check to see if additional members
        // are being added to these shapes so that we know to make the appropriate customization
        private void S3NeedsCustomUpdate(Shape shape)
        {
            // a dictionary of shape name to number of members that shape has
            var customUpdateShapes = new Dictionary<string, int>
            {
                {"LifecycleFilter", 5 }
            };
            if (customUpdateShapes.TryGetValue(shape.Name, out int membersCount))
            {
                if (membersCount != shape.Members.Count)
                {
                    throw new InvalidOperationException(String.Format("A member was added to {0} that the .NET SDK has a custom unmarshaller or marshaller for. Please check and make sure" +
                        "to add the member to the custom unmarshaller and all related code.", shape.Name));
                }
            }
        }

    }
}
