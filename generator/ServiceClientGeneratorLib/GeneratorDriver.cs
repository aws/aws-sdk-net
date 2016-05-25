using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ServiceClientGenerator.Generators;
using ServiceClientGenerator.Generators.Examples;
using ServiceClientGenerator.Generators.Marshallers;
using ServiceClientGenerator.Generators.NuGet;
using ServiceClientGenerator.Generators.SourceFiles;
using ServiceClientGenerator.Generators.CodeAnalysis;
using ServiceClientGenerator.Generators.TestFiles;
using StructureGenerator = ServiceClientGenerator.Generators.SourceFiles.StructureGenerator;
using ServiceClientGenerator.Generators.Component;

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
        /// The folder where all the xamarin componenets would be present
        /// </summary>
        public string ComponentsFilesRoot { get; private set; }

        /// <summary>
        /// The folder where all the sample files are located
        /// </summary>
        public string SampleFilesRoot { get; private set; }

        private readonly HashSet<Shape> _structuresToProcess = new HashSet<Shape>();

        private readonly HashSet<string> _processedStructures = new HashSet<string>();
        private readonly HashSet<string> _processedUnmarshallers = new HashSet<string>();
        private readonly HashSet<string> _processedMarshallers = new HashSet<string>();

        private const string Bcl35SubFolder = "_bcl35";
        private const string Bcl45SubFolder = "_bcl45";
        private const string MobileSubFolder = "_mobile";
        private const string UnitySubFolder = "_unity";
        private string MarshallingTestsSubFolder = string.Format("UnitTests{0}Generated{0}Marshalling", Path.DirectorySeparatorChar);
        private string CustomizationTestsSubFolder = string.Format("UnitTests{0}Generated{0}Customizations", Path.DirectorySeparatorChar);

        public const string SourceSubFoldername = "src";
        public const string TestsSubFoldername = "test";
        public const string CodeAnalysisFoldername = "code-analysis";
        public const string ServicesSubFoldername = "Services";
        public const string CoreSubFoldername = "Core";
        public const string GeneratedCodeFoldername = "Generated";
        public const string UnitTestsSubFoldername = "UnitTests";
        public const string IntegrationTestsSubFolderName = "IntegrationTests";
        public const string XamarinComponentsSubFolderName = "xamarin-components";


        public const string NuGetPreviewFlag = "-preview";

        // Records any new project files we produce as part of generation. If this collection is
        // not empty when we've processed all source, we must update the solution files to add
        // the new projects.
        private static readonly Dictionary<string, ProjectFileCreator.ProjectConfigurationData> NewlyCreatedProjectFiles
            = new Dictionary<string, ProjectFileCreator.ProjectConfigurationData>();

        public HashSet<string> FilesWrittenToGeneratorFolder {get; private set;}


        public GeneratorDriver(ServiceConfiguration config, GenerationManifest generationManifest, GeneratorOptions options)
        {
            FilesWrittenToGeneratorFolder = new HashSet<string>();
            GenerationManifest = generationManifest;
            Configuration = config;
            ProjectFileConfigurations = GenerationManifest.ProjectFileConfigurations;
            Options = options;

            // Base name in the manifest is not a reliable source of info, as if append-service
            // is set 'Service' gets appended and in the case of IAM then sends us to the wrong folder.
            // Instead we'll use the namespace and rip off any Amazon. prefix. This also helps us
            // handle versioned namespaces too.
            var serviceNameRoot = Configuration.Namespace.StartsWith("Amazon.", StringComparison.Ordinal)
                ? Configuration.Namespace.Substring(7)
                : Configuration.Namespace;

            ServiceFilesRoot = Path.Combine(Options.SdkRootFolder, SourceSubFoldername, ServicesSubFoldername, serviceNameRoot);
            GeneratedFilesRoot = Path.Combine(ServiceFilesRoot, GeneratedCodeFoldername);

            CodeAnalysisRoot = Path.Combine(Options.SdkRootFolder, CodeAnalysisFoldername, "ServiceAnalysis", serviceNameRoot);

            TestFilesRoot = Path.Combine(Options.SdkRootFolder, TestsSubFoldername);

            ComponentsFilesRoot = Path.Combine(Options.SdkRootFolder, XamarinComponentsSubFolderName, serviceNameRoot);

            SampleFilesRoot = options.SamplesRootFolder;
        }

        public void Execute()
        {
            this.FilesWrittenToGeneratorFolder.Clear();
            if (Options.Clean && !Configuration.IsChildConfig)
            {
                Console.WriteLine(@"-clean option set, deleting previously-generated code under .\Generated subfolders");

                Directory.Delete(GeneratedFilesRoot, true);
                Directory.CreateDirectory(GeneratedFilesRoot);
            }

            // .NET Framework 3.5 version
            ExecuteGenerator(new ServiceClients(), "Amazon" + Configuration.BaseName + "Client.cs", Bcl35SubFolder);
            ExecuteGenerator(new ServiceInterface(), "IAmazon" + Configuration.BaseName + ".cs", Bcl35SubFolder);

            // .NET Framework 4.5 version
            ExecuteGenerator(new ServiceClients45(), "Amazon" + Configuration.BaseName + "Client.cs", Bcl45SubFolder);
            ExecuteGenerator(new ServiceInterface45(), "IAmazon" + Configuration.BaseName + ".cs", Bcl45SubFolder);

            // Phone/Rt/Portable version
            ExecuteGenerator(new ServiceClientsMobile(), "Amazon" + Configuration.BaseName + "Client.cs", MobileSubFolder);
            ExecuteGenerator(new ServiceInterfaceMobile(), "IAmazon" + Configuration.BaseName + ".cs", MobileSubFolder);

            if (string.IsNullOrEmpty(Options.SelfServiceModel))
            {
                //unity version
                if (Configuration.SupportedInUnity)
                {
                    ExecuteGenerator(new ServiceInterfaceUnity(), "IAmazon" + Configuration.BaseName + ".cs", UnitySubFolder);
                    ExecuteGenerator(new ServiceClientUnity(), "Amazon" + Configuration.BaseName + "Client.cs", UnitySubFolder);
                }
                // Do not generate AssemblyInfo.cs and nuspec file for child model.
                // Use the one generated for the parent model.
                if (!this.Configuration.IsChildConfig)
                {
                    ExecuteNugetFileGenerators();

                    if (this.Configuration.EnableXamarinComponent)
                        GenerateXamarinComponents();

                    GenerateCodeAnalysisProject();
                }
            }

            if (!this.Configuration.IsChildConfig)
            {
                ExecuteGeneratorAssemblyInfo();
            }

            // Client config object
            ExecuteGenerator(new ServiceConfig(), "Amazon" + Configuration.BaseName + "Config.cs");

            if (Configuration.Namespace == "Amazon.S3")
            {
                ExecuteProjectFileGenerators();
                return;
            }


            // The top level request that all operation requests are children of
            ExecuteGenerator(new BaseRequest(), "Amazon" + Configuration.BaseName + "Request.cs", "Model");

            var enumFileName = this.Configuration.IsChildConfig ?
                string.Format("ServiceEnumerations.{0}.cs", Configuration.BaseName) : "ServiceEnumerations.cs";

            // Any enumerations for the service
            this.ExecuteGenerator(new ServiceEnumerations(), enumFileName);

            // Do not generate base exception if this is a child model.
            // We use the base exceptions generated for the parent model.
            if (!this.Configuration.IsChildConfig)
            {
                this.ExecuteGenerator(new BaseServiceException(), "Amazon" + this.Configuration.BaseName + "Exception.cs");
            }

            // Generates the Request, Responce, Marshaller, Unmarshaller, and Exception objects for a given client operation
            foreach (var operation in Configuration.ServiceModel.Operations)
            {
                GenerateRequest(operation);
                GenerateResponse(operation);
                GenerateRequestMarshaller(operation);
                GenerateResponseUnmarshaller(operation);
                GenerateExceptions(operation);
            }

            if (Configuration.ServiceModel.Customizations.GenerateCustomUnmarshaller)
            {
                GenerateUnmarshaller(Configuration.ServiceModel.Customizations.CustomUnmarshaller);
            }

            // Generate any missed structures that are not defined or referenced by a request, response, marshaller, unmarshaller, or exception of an operation
            GenerateStructures();

            var fileName = Configuration.LockedApiVersion != null
                ? string.Format("{0}_{1}_MarshallingTests.cs", Configuration.BaseName, Configuration.LockedApiVersion)
                : string.Format("{0}MarshallingTests.cs", Configuration.BaseName);

            // Generate tests based on the type of request it is
            if (Configuration.ServiceModel.Type == ServiceType.Json)
                ExecuteTestGenerator(new JsonMarshallingTests(), fileName);
            else if (Configuration.ServiceModel.Type == ServiceType.Query)
            {
                if (Configuration.ServiceModel.IsEC2Protocol)
                    ExecuteTestGenerator(new AWSQueryEC2MarshallingTests(), fileName);
                else
                    ExecuteTestGenerator(new AWSQueryMarshallingTests(), fileName);
            }
            else if (Configuration.ServiceModel.Type == ServiceType.Rest_Xml || Configuration.ServiceModel.Type == ServiceType.Rest_Json)
                ExecuteTestGenerator(new RestMarshallingTests(), fileName);

            // Test that simple customizations were generated correctly
            GenerateCustomizationTests();
            ExecuteProjectFileGenerators();
            if (this.Configuration.ServiceModel.Customizations.HasExamples)
            {
                var servicename = Configuration.Namespace.Split('.').Last();
                ExecuteExampleGenerator(new ExampleCode(), servicename + ".GeneratedSamples.cs", servicename);
                ExecuteExampleGenerator(new ExampleMetadata(), servicename + ".GeneratedSamples.extra.xml");
            }
        }

        /// <summary>
        /// Generates the request class for the operation.
        /// </summary>
        /// <param name="operation">The operation object which contains info about what the request needs to contain for the operation</param>
        void GenerateRequest(Operation operation)
        {
            var requestGenerator = new StructureGenerator
            {
                ClassName = operation.Name + "Request",
                BaseClass = string.Format("Amazon{0}Request", Configuration.BaseName),
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

        private void DetermineStructuresToProcess(Shape containingShape, bool includeContainingShape)
        {
            if (containingShape.IsStructure)
            {
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
                    var resultGenerator = new StructureGenerator
                    {
                        ClassName = operation.Name + "Response",
                        BaseClass = "AmazonWebServiceResponse",
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
        /// Generates exception classes in the model namespaces for exceptions declared in the service model. 
        /// </summary>
        /// <param name="operation">The operation to generate exceptions for</param>
        void GenerateExceptions(Operation operation)
        {
            foreach (var exception in operation.Exceptions)
            {
                // Skip exceptions that have already been generated for the parent model
                if (IsExceptionPresentInParentModel(this.Configuration, exception.Name))
                    continue;

                // Check to see if the exceptions has already been generated for a previous operation.
                if (!this._processedStructures.Contains(exception.Name))
                {
                    

                    var generator = new ExceptionClass()
                    {
                        Exception = exception,
                        GenerateComplexException = this.Configuration.ServiceModel.Customizations.GenerateComplexException,
                        BaseException = this.Configuration.BaseException
                    };
                    this.ExecuteGenerator(generator, exception.Name + ".cs", "Model");
                    this._processedStructures.Add(exception.Name);
                }
            }
        }

        /// <summary>
        /// Generates the request marshaller.
        /// </summary>
        /// <param name="operation">The operation to generate request marshallers for</param>
        void GenerateRequestMarshaller(Operation operation)
        {
            bool hasRequest = operation.RequestStructure != null;
            bool normalizeMarshallers;

            BaseRequestMarshaller generator;
            GetRequestMarshaller(out generator, out normalizeMarshallers);
            generator.Operation = operation;

            this.ExecuteGenerator(generator, operation.Name + "RequestMarshaller.cs", "Model.Internal.MarshallTransformations");
            if (hasRequest)
                this._processedMarshallers.Add(operation.RequestStructure.Name);

            if (normalizeMarshallers && hasRequest)
            {
                var lookup = new NestedStructureLookup();
                lookup.SearchForNestedStructures(operation.RequestStructure);

                foreach (var nestedStructure in lookup.NestedStructures)
                {
                    // Skip structure marshallers that have already been generated for the parent model
                    if (IsShapePresentInParentModel(this.Configuration, nestedStructure.Name))
                        continue;

                    if (!this._processedMarshallers.Contains(nestedStructure.Name))
                    {
                        var structureGenerator = GetStructureMarshaller();
                        structureGenerator.Structure = nestedStructure;

                        this.ExecuteGenerator(structureGenerator, nestedStructure.Name + "Marshaller.cs", "Model.Internal.MarshallTransformations");
                        //this.processedUnmarshallers.Add(nestedStructure.Name);
                    }
                }
            }
        }

        /// <summary>
        /// Generates the response unmarshaller along with any dependent structure unmarshallers that are called by this response unmarshaller.
        /// </summary>
        /// <param name="operation">The operation to generate the unmarshaller for</param>
        void GenerateResponseUnmarshaller(Operation operation)
        {
            {
                var baseException = string.Format("Amazon{0}Exception",
                        this.Configuration.IsChildConfig ?
                        this.Configuration.ParentConfig.BaseName : this.Configuration.BaseName);

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
                    // Skip structure unmarshallers that have already been generated for the parent model
                    if (IsShapePresentInParentModel(this.Configuration, nestedStructure.Name))
                        continue;

                    if (this.Configuration.ServiceModel.Customizations.IsSubstitutedShape(nestedStructure.Name))
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

        void GenerateUnmarshaller(List<string> structures)
        {
            foreach (var structure in structures)
            {
                var shape = this.Configuration.ServiceModel.FindShape(structure);
                var lookup = new NestedStructureLookup();
                lookup.SearchForNestedStructures(shape);
                foreach (var nestedStructure in lookup.NestedStructures)
                {
                    // Skip structure unmarshallers that have already been generated for the parent model
                    if (IsShapePresentInParentModel(this.Configuration, nestedStructure.Name))
                        continue;

                    if (this.Configuration.ServiceModel.Customizations.IsSubstitutedShape(nestedStructure.Name))
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
        }

        public static void GenerateCoreProjects(GenerationManifest generationManifest,
            GeneratorOptions options)
        {
            Console.WriteLine("Updating Core project files.");
            string coreFilesRoot = Path.Combine(options.SdkRootFolder, "src", "core");
            var creator = new ProjectFileCreator(options);
            creator.ExecuteCore(coreFilesRoot, generationManifest.ProjectFileConfigurations);
            foreach (var newProjectKey in creator.CreatedProjectFiles.Keys)
            {
                NewlyCreatedProjectFiles.Add(newProjectKey, creator.CreatedProjectFiles[newProjectKey]);
            }
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

        public static void UpdateCodeAnalysisSoltion(GenerationManifest manifest, GeneratorOptions options)
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
            foreach (var service in manifest.ServiceConfigurations.OrderBy(x => x.BaseName))
            {
                // Service like DynamoDB streams are included in a parent service.
                if (service.ParentConfig != null)
                    continue;

                if (string.IsNullOrEmpty(service.Synopsis))
                    throw new Exception(string.Format("{0} is missing a synopsis in the manifest.", service.BaseName));
                var assemblyName = service.Namespace.Replace("Amazon.", "AWSSDK.");
                nugetPackages[assemblyName] = service.Synopsis;
            }

            NuGetPackageReadmeSection generator = new NuGetPackageReadmeSection();
            var session = new Dictionary<string, object> { { "NugetPackages", nugetPackages } };
            generator.Session = session;
            var nugetPackagesText = generator.TransformText();

            var readmePath = Path.Combine(options.SdkRootFolder, "..", "README.md");
            var originalContent = File.ReadAllText(readmePath);

            int startPos = originalContent.IndexOf('\n', originalContent.IndexOf("### NuGet Packages")) + 1;
            int endPos = originalContent.IndexOf("### Code Generator");

            var newContent = originalContent.Substring(0, startPos);
            newContent += nugetPackagesText + "\r\n";
            newContent += originalContent.Substring(endPos);

            File.WriteAllText(readmePath, newContent);
        }

        /// <summary>
        /// Provides a way to generate the neccesary attributes and marshallers/unmarshallers for nested structures to work
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
        void GenerateStructures()
        {
            var excludedOperations = Configuration.ServiceModel.ExcludedOperations;

            foreach (var definition in this._structuresToProcess)
            {
                // Skip structures that have already been generated for the parent model
                if (IsShapePresentInParentModel(this.Configuration, definition.Name))
                    continue;

                if (!this._processedStructures.Contains(definition.Name) && !definition.IsException)
                {
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
                        Structure = definition
                    };
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

        void ExecuteNugetFileGenerators()
        {
            GeneratePackagesConfig();
            GenerateNuspec();
        }

        void GeneratePackagesConfig()
        {
            var assemblyName = Configuration.Namespace.Replace("Amazon.", "AWSSDK.");
            var session = new Dictionary<string, object>
            {
                { "AssemblyName", assemblyName },
            };
            var pcGenerator = new PackagesConfig() { Session = session };
            var text = pcGenerator.TransformText();
            WriteFile(ServiceFilesRoot, string.Empty, "packages.config", text);
        }

        void GenerateXamarinComponents()
        {
            var coreVersion = GenerationManifest.CoreVersion;

            // we're generating services only, so can automatically add the core runtime
            // as a dependency
            var awsDependencies = new Dictionary<string, string>(StringComparer.Ordinal);

            if (Configuration.ServiceDependencies != null)
            {
                var dependencies = Configuration.ServiceDependencies;
                foreach (var kvp in dependencies)
                {
                    var service = kvp.Key;
                    var version = kvp.Value;
                    var dependentService = GenerationManifest.ServiceConfigurations.FirstOrDefault(x => string.Equals(x.Namespace, "Amazon." + service, StringComparison.InvariantCultureIgnoreCase));

                    string previewFlag;
                    if (dependentService != null && dependentService.InPreview)
                    {
                        previewFlag = GeneratorDriver.NuGetPreviewFlag;
                    }
                    else if (string.Equals(service, "Core", StringComparison.InvariantCultureIgnoreCase) && GenerationManifest.DefaultToPreview)
                    {
                        previewFlag = GeneratorDriver.NuGetPreviewFlag;
                    }
                    else
                    {
                        previewFlag = string.Empty;
                    }

                    var verTokens = version.Split('.');
                    var versionRange = string.Format("[{0}{3}, {1}.{2}{3})", version, verTokens[0], int.Parse(verTokens[1]) + 1, previewFlag);

                    awsDependencies.Add(string.Format("AWSSDK.{0}", service), string.Format("{0}{1}", version, previewFlag));
                }
            }

            var assemblyVersion = Configuration.ServiceFileVersion;
            var assemblyName = Configuration.Namespace.Replace("Amazon.", "AWSSDK.");
            var assemblyTitle = "AWSSDK - " + Configuration.ServiceModel.ServiceFullName;
            var componentTitle = assemblyTitle;
            bool componentUsesAlternateLicense = !string.IsNullOrEmpty(Configuration.LicenseUrl) && Configuration.LicenseUrl != GenerationManifest.ApacheLicenseURL;
            if (!string.IsNullOrEmpty(Configuration.NugetPackageTitleSuffix))
                componentTitle += " " + Configuration.NugetPackageTitleSuffix;

            if (string.IsNullOrEmpty(Configuration.ServiceModel.Customizations.XamarinSolutionSamplePath))
                throw new Exception("Xamarin component flag enabled but samples are missing");

            var session = new Dictionary<string, object>
            {
                { "AssemblyName", assemblyName },
                { "AssemblyTitle",  assemblyTitle },
                { "ComponentTitle",  componentTitle },
                { "AssemblyDescription", Configuration.AssemblyDescription },
                { "AssemblyVersion", assemblyVersion },
                { "AWSDependencies", awsDependencies },
                { "BaseName", this.Configuration.BaseName },
                { "ProjectFileConfigurations", this.ProjectFileConfigurations},
                { "Documentation",string.IsNullOrEmpty(Configuration.ServiceModel.Documentation)?Configuration.Synopsis:Configuration.ServiceModel.Documentation },
                { "SolutionFilePath", string.IsNullOrEmpty(Configuration.ServiceModel.Customizations.XamarinSolutionSamplePath)?"":Path.Combine(SampleFilesRoot,Configuration.ServiceModel.Customizations.XamarinSolutionSamplePath) },
                { "UsesAlternateLicense", componentUsesAlternateLicense },
                { "Synopsis", Configuration.Synopsis},
                { "ExtraTags", Configuration.Tags.Count == 0 ? string.Empty : " " + string.Join(" ", Configuration.Tags) }
            };

            session["NuGetPreviewFlag"] = Configuration.InPreview ? GeneratorDriver.NuGetPreviewFlag : "";

            var componentGenerator = new Component { Session = session };
            var text = componentGenerator.TransformText();
            var yamlFilename = "component.yaml";
            WriteFile(ComponentsFilesRoot, string.Empty, yamlFilename, text);

            var detailsMarkdownGenerator = new Details { Session = session };
            text = ConvertHtmlToMarkDown(detailsMarkdownGenerator.TransformText());

            // sanitize the line endings from the markup generation, as we can get
            // odd combinations of line endings
            var lines = text.Split(new[] { "\r\n", "\n", "\r" }, StringSplitOptions.None);
            var normalizedText = string.Join(Environment.NewLine, lines);

            var detailsFileName = "Details.md";
            WriteFile(ComponentsFilesRoot, string.Empty, detailsFileName, normalizedText);

            var gettingStartedMarkdownGenerator = new GettingStarted { Session = session };
            text = ConvertHtmlToMarkDown(gettingStartedMarkdownGenerator.TransformText());
            var gettingStartedFileName = "GettingStarted.md";
            WriteFile(ComponentsFilesRoot, string.Empty, gettingStartedFileName, text);
        }

        string ConvertHtmlToMarkDown(string text)
        {
            var htmlText = text.Replace("<fullname>", "<h1>").Replace("</fullname>", "</h1>");
            htmlText = htmlText.Replace("<note>", "<i>").Replace("</note>", "</i>");
            var converter = new ReverseMarkdown.Converter(new ReverseMarkdown.Config(unknownTagsConverter: "raise", githubFlavored: true));
            try
            {
                var markdownText = converter.Convert(htmlText);
                return markdownText;
            }
            catch (Exception e)
            {
                Console.WriteLine("exception while parsing markdown for the service {0}", Configuration.ServiceModel.ServiceFullName);
                Console.WriteLine("html text = {0}", text);
                throw e;
            }
        }

        void GenerateNuspec()
        {
            var coreVersion = GenerationManifest.CoreVersion;

            // we're generating services only, so can automatically add the core runtime
            // as a dependency
            var awsDependencies = new Dictionary<string, string>(StringComparer.Ordinal);

            if (Configuration.ServiceDependencies != null)
            {
                var dependencies = Configuration.ServiceDependencies;
                foreach (var kvp in dependencies)
                {
                    var service = kvp.Key;
                    var version = kvp.Value;
                    var dependentService = GenerationManifest.ServiceConfigurations.FirstOrDefault(x => string.Equals(x.Namespace, "Amazon." + service, StringComparison.InvariantCultureIgnoreCase));

                    string previewFlag;
                    if (dependentService != null && dependentService.InPreview)
                    {
                        previewFlag = GeneratorDriver.NuGetPreviewFlag;
                    }
                    else if (string.Equals(service, "Core", StringComparison.InvariantCultureIgnoreCase) && GenerationManifest.DefaultToPreview)
                    {
                        previewFlag = GeneratorDriver.NuGetPreviewFlag;
                    }
                    else
                    {
                        previewFlag = string.Empty;
                    }

                    var verTokens = version.Split('.');
                    var versionRange = string.Format("[{0}{3}, {1}.{2}{3})", version, verTokens[0], int.Parse(verTokens[1]) + 1, previewFlag);

                    awsDependencies.Add(string.Format("AWSSDK.{0}", service), versionRange);
                }
            }

            var assemblyVersion = Configuration.ServiceFileVersion;
            var assemblyName = Configuration.Namespace.Replace("Amazon.", "AWSSDK.");
            var assemblyTitle = "AWSSDK - " + Configuration.ServiceModel.ServiceFullName;
            var nugetTitle = assemblyTitle;
            if (!string.IsNullOrEmpty(Configuration.NugetPackageTitleSuffix))
                nugetTitle += " " + Configuration.NugetPackageTitleSuffix;
            bool iOSPclVariant = false;
            bool androidPclVariant = false;
            if (Configuration.PclVariants != null)
            {
                iOSPclVariant = Configuration.PclVariants.Contains("iOS");
                androidPclVariant = Configuration.PclVariants.Contains("Android");
            }

            var session = new Dictionary<string, object>
            {
                { "AssemblyName", assemblyName },
                { "AssemblyTitle",  assemblyTitle },
                { "NuGetTitle",  nugetTitle },
                { "AssemblyDescription", Configuration.AssemblyDescription },
                { "AssemblyVersion", assemblyVersion },
                { "AWSDependencies", awsDependencies },
                { "BaseName", this.Configuration.BaseName },
                { "CodeAnalysisServiceFolder", this.Configuration.Namespace.Replace("Amazon.", "") },
                { "ProjectFileConfigurations", this.ProjectFileConfigurations},
                { "ExtraTags", Configuration.Tags == null || Configuration.Tags.Count == 0 ? string.Empty : " " + string.Join(" ", Configuration.Tags) },
                { "licenseUrl", Configuration.LicenseUrl },
                { "requireLicenseAcceptance",Configuration.RequireLicenseAcceptance?"true":"false" },
                {"DisablePCLSupport", this.Options.DisablePCLSupport}
        };

            if (Configuration.NugetDependencies != null)
                session.Add("NugetDependencies", Configuration.NugetDependencies);

            session["NuGetPreviewFlag"] = Configuration.InPreview ? GeneratorDriver.NuGetPreviewFlag : "";

            var nuspecGenerator = new Nuspec { Session = session };
            var text = nuspecGenerator.TransformText();
            var nuspecFilename = assemblyName + ".nuspec";
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

                ExecuteCustomizationTestGenerator(constructorTests, this.Configuration.BaseName + "ConstructorTests.cs", "Constructors");
            }

            if (this.Configuration.ServiceModel.Customizations.SimpleMethodsModel.SimpleMethods.Count > 0)
            {
                var methodTests = new SimpleMethodTests()
                {
                    Config = this.Configuration
                };

                ExecuteCustomizationTestGenerator(methodTests, this.Configuration.BaseName + "MethodTests.cs", "SimpleMethods");
            }
        }

        /// <summary>
        /// Update project references in unit test projects to include any new services.
        /// </summary>
        public static void UpdateUnitTestProjectReferences(GeneratorOptions options)
        {
            var servicesRoot = Path.Combine(options.SdkRootFolder, "src", "Services");
            var testRoot = Path.Combine(options.SdkRootFolder, "test", "UnitTests");

            var command = new UnitTestProjectReferenceChecker()
            {
                ServiceRoot = servicesRoot,
                ProjectFilePath = Path.Combine(testRoot, "AWSSDK.UnitTests.Net35.csproj")
            };
            command.Execute();

            command.ProjectFilePath = Path.Combine(testRoot, "AWSSDK.UnitTests.Net45.csproj");
            command.Execute();
        }

        /// <summary>
        /// Runs the generator and saves the content into _bcl35 directory under the generated files root.
        /// </summary>
        /// <param name="generator">The generator to use for outputting the text of the cs file</param>
        /// <param name="fileName">The name of the cs file</param>
        /// <param name="subNamespace">Adds an additional directory for the namespace</param>
        void ExecuteGenerator(BaseGenerator generator, string fileName, string subNamespace = null)
        {
            generator.Config = this.Configuration;
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
            var outputSubFolder = subNamespace == null ? MarshallingTestsSubFolder : Path.Combine(MarshallingTestsSubFolder, subNamespace);
            WriteFile(TestFilesRoot, outputSubFolder, fileName, text);
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
            var outputSubFolder = @"docgenerator\AWSSDKDocSamples";
            if (subNamespace != null)
                outputSubFolder = Path.Combine(outputSubFolder, subNamespace);
            WriteFile(Path.GetFullPath(TestFilesRoot + @"\..\..\"), outputSubFolder, fileName, text);
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
            var outputSubFolder = subNamespace == null ? CustomizationTestsSubFolder : Path.Combine(CustomizationTestsSubFolder, subNamespace);
            WriteFile(TestFilesRoot, outputSubFolder, fileName, text);
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
                ? Path.Combine(baseOutputDir, subNamespace.Replace('.', Path.DirectorySeparatorChar))
                : baseOutputDir;

            if (!Directory.Exists(outputDir))
                Directory.CreateDirectory(outputDir);

            var cleanContent = trimWhitespace ? content.Trim() : content;
            if (replaceTabs)
                cleanContent = cleanContent.Replace("\t", "    ");

            outputFilePath = Path.GetFullPath(Path.Combine(outputDir, filename));
            if (File.Exists(outputFilePath))
            {
                var existingContent = File.ReadAllText(outputFilePath);
                if (string.Equals(existingContent, cleanContent))
                    return false;
            }

            File.WriteAllText(outputFilePath, cleanContent);
            Console.WriteLine("...created/updated {0}", filename);
            return true;
        }

        /// <summary>
        /// Sets the marshaller of the generator based on the service type
        /// </summary>
        /// <param name="marshaller">The marshaller to be set</param>
        /// <param name="normalizeMarshallers">If the service type is a type of json then normalizeMarshallers is set to true, false otherwise</param>
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
                default:
                    throw new Exception("No structure unmarshaller for service type: " + this.Configuration.ServiceModel.Type);
            }
        }

        void GenerateCodeAnalysisProject()
        {
            var command = new CodeAnalysisProjectCreator();
            command.Execute(CodeAnalysisRoot, this.Configuration);
        }

        public static void RemoveOrphanedShapes(HashSet<string> generatedFiles, string rootFolder)
        {
            // Remove orphaned shapes. Most likely due to taking in a model that was still under development.
            foreach (var file in Directory.GetFiles(rootFolder, "*.cs", SearchOption.AllDirectories))
            {
                var fullPath = Path.GetFullPath(file);
                if (fullPath.IndexOf(string.Format(@"\{0}\", GeneratedCodeFoldername), StringComparison.OrdinalIgnoreCase) < 0)
                    continue;

                if (!generatedFiles.Contains(fullPath))
                {
                    Console.Error.WriteLine("**** Warning: Removing orphaned generated code " + Path.GetFileName(file));
                    File.Delete(file);
                }
            }
        }
    }
}
