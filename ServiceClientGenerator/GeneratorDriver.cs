using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

using Json.LitJson;

using ServiceClientGenerator.Generators;
using ServiceClientGenerator.Generators.Resources;

namespace ServiceClientGenerator
{
    public class GeneratorDriver
    {
        GeneratorConfig config;
        string outputDirectory;
        string outputDirectory45;
        string outputDirectoryRT, outputDirPortable;
        string testDirectory;
        HashSet<string> processedStructures = new HashSet<string>();
        HashSet<string> processedUnmarshallers = new HashSet<string>();
        HashSet<string> processedMarshallers = new HashSet<string>();

        public GeneratorDriver(GeneratorConfig config, string outputDir, string outputDir45, string outputDirRT, string outputDirPortable, string testDirectory)
        {
            this.config = config;
            this.outputDirectory = outputDir;
            this.outputDirectory45 = outputDir45;
            this.outputDirectoryRT = outputDirRT;
            this.outputDirPortable = outputDirPortable;
            this.testDirectory = testDirectory;
        }

        public void Execute()
        {
            // .NET Framework 3.5 version
            this.ExecuteGenerator(new ServiceClients(), "Amazon" + config.BaseName + "Client.cs");
            this.ExecuteGenerator(new ServiceInterface(), "IAmazon" + config.BaseName + ".cs");

            // .NET Framework 4.5 version
            this.ExecuteGenerator45(new ServiceClients45(), "Amazon" + config.BaseName + "Client.cs");
            this.ExecuteGenerator45(new ServiceInterface45(), "IAmazon" + config.BaseName + ".cs");

            if (this.config.SupportedInWinRT)
            {
                // WinRT version
                this.ExecuteGeneratorRT(new ServiceClientsRT(), "Amazon" + config.BaseName + "Client.cs");
                this.ExecuteGeneratorRT(new ServiceInterfaceRT(), "IAmazon" + config.BaseName + ".cs");
            }

            if (this.config.SupportedInPCL)
            {
                // Portable version
                this.ExecuteGeneratorPortable(new ServiceClientsRT(), "Amazon" + config.BaseName + "Client.cs");
                this.ExecuteGeneratorPortable(new ServiceInterfaceRT(), "IAmazon" + config.BaseName + ".cs");
            }

            if (this.config.Namespace == "Amazon.S3")
                return;

            // Client config object
            this.ExecuteGenerator(new ServiceConfig(), "Amazon" + config.BaseName + "Config.cs");

            // The top level request that all operation requests are children of
            this.ExecuteGenerator(new BaseRequest(), "Amazon" + config.BaseName + "Request.cs", "Model");

            // Any enumerations for the service
            this.ExecuteGenerator(new ServiceEnumerations(), "ServiceEnumerations.cs");

            // Paginators
            if (config.ServiceModel.Paginators.Count > 0)
            {
                this.ExecuteGenerator(new ServicePaginators(), "Amazon" + config.BaseName + "Client.paginators.cs");
                //if (config.ServiceModel.HasResources)
                    this.ExecutePaginatorTestGenerator(new ServicePaginatorTests(), config.BaseName + "PaginatorTests.cs");
            }

            // Generates the Request, Responce, Marshaller, Unmarshaller, and Exception objects for a given client operation
            foreach (var operation in this.config.ServiceModel.Operations)
            {
                this.GenerateRequest(operation);
                this.GenerateResponse(operation);
                this.GenerateRequestMarshaller(operation);
                this.GenerateResponseUnmarshaller(operation);
                this.GenerateExceptions(operation);
            }

            if (config.ServiceModel.HasResources)
            {
                this.ExecuteGenerator(new ResourceInterfaces(), "Resources.cs", "Resources");
                this.ExecuteGenerator(new ResourceImplementations(), "ResourceImplementations.cs", "Resources");
                this.ExecuteGenerator(new ResourceRoot(), config.BaseName+".cs", "Resources");
            }

            // Generate any missed structures that are not defined or referenced by a request, response, marshaller, unmarshaller, or exception of an operation
            GenerateStructures();

            string fileName = this.config.LockedAPIVersion != null ? string.Format("{0}_{1}_MarshallingTests.cs", this.config.BaseName, this.config.LockedAPIVersion) :
                string.Format("{0}MarshallingTests.cs", this.config.BaseName);

            // Generate tests based on the type of request it is
            if(config.ServiceModel.Type == ServiceType.Json)
                this.ExecuteTestGenerator(new JsonMarshallingTests(), fileName, "Marshalling");
            else if (config.ServiceModel.Type == ServiceType.Query)
            {
                if (config.ServiceModel.IsEC2Protocol)
                    this.ExecuteTestGenerator(new AWSQueryEC2MarshallingTests(), fileName, "Marshalling");
                else
                    this.ExecuteTestGenerator(new AWSQueryMarshallingTests(), fileName, "Marshalling");
            }
            else if (config.ServiceModel.Type == ServiceType.Rest_Xml || config.ServiceModel.Type == ServiceType.Rest_Json)
                this.ExecuteTestGenerator(new RestMarshallingTests(), fileName, "Marshalling");

            // Test that simple customizations were generated correctly
            GenerateCustomizationTests();
        }

        /// <summary>
        /// Generates the request class for the operation.
        /// </summary>
        /// <param name="operation">The operation object which contains info about what the request needs to contain for the operation</param>
        void GenerateRequest(Operation operation)
        {
            var requestGenerator = new StructureGenerator()
            {
                ClassName = operation.Name + "Request",
                BaseClass = string.Format("Amazon{0}Request", this.config.BaseName),
                StructureType = StructureType.Request,
                Operation = operation
            };
            if (operation.RequestStructure != null)
            {
                requestGenerator.Structure = this.config.ServiceModel.FindShape(operation.RequestStructure.Name);
            }

            this.ExecuteGenerator(requestGenerator, requestGenerator.ClassName + ".cs", "Model");

            if (operation.RequestStructure != null)
                this.processedStructures.Add(operation.RequestStructure.Name);
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
                var className = operation.Name + "Result";
                string propertyName = null;
                var propertyModifier 
                    = this.config.ServiceModel.Customizations.GetPropertyModifier(className, operation.ResponseStructure.Name);
                if (propertyModifier != null && propertyModifier.EmitName != null)
                    propertyName = propertyModifier.EmitName;
                else
                    propertyName = operation.ResponseStructure.Name;

                var resultGenerator = new WrappingResultGenerator
                {
                    Operation = operation,
                    ClassName = className,
                    BaseClass = "AmazonWebServiceResponse",
                    Structure = this.config.ServiceModel.FindShape(operation.ResponseStructure.Name),
                    PropertyName = propertyName
                };

                // emit the wrapping result but do not mark the shape as processed as a consequence
                this.ExecuteGenerator(resultGenerator, resultGenerator.ClassName + ".cs", "Model");
            }
            else
            {
                // if the operation has a suppressed result modification, use the structure generator to emit
                // an empty xxxxResponse class, derived from AmazonWebServiceResponse
                suppressResultGeneration =
                    operation.ResponseStructure == null ||
                    this.config.ServiceModel.Customizations.ResultGenerationSuppressions.Contains(operation.Name);

                if (suppressResultGeneration)
                {
                    var responseGenerator = new StructureGenerator
                    {
                        ClassName = operation.Name + "Response",
                        BaseClass = "AmazonWebServiceResponse",
                        Operation = operation
                    };
                    this.ExecuteGenerator(responseGenerator, responseGenerator.ClassName + ".cs", "Model");
                    if (operation.ResponseStructure != null)
                        this.processedStructures.Add(operation.ResponseStructure.Name);
                }
                else
                {
                    var resultGenerator = new StructureGenerator
                    {
                        ClassName = operation.Name + "Result",
                        BaseClass = "AmazonWebServiceResponse",
                        IsWrapped = operation.IsResponseWrapped
                    };
                    if (operation.ResponseStructure != null)
                    {
                        if (operation.IsResponseWrapped)
                        {
                            // If IsResponseWrapped is true, the operation.ResponseStructure will point to a 
                            // the shape with same name as ResponseWrapper.
                            var resultShape = this.config.ServiceModel.FindShape(operation.ResponseStructure.Name);
                            var innerShape = resultShape.Members[0].Shape;
                            resultGenerator.Structure = innerShape;
                        }
                        else
                        {
                            resultGenerator.Structure =
                                this.config.ServiceModel.FindShape(operation.ResponseStructure.Name);
                        }
                    }

                    this.ExecuteGenerator(resultGenerator, resultGenerator.ClassName + ".cs", "Model");
                }
            }

            if (!suppressResultGeneration)
            {
                if (operation.ResponseStructure != null)
                {
                    // Mark the shape as processed if it's being referred only as operation's
                    // output shape and not being referred directly by any other shape or via an
                    // operation modifier generating an artifical structure not in the service model.
                    if (!IsShapeReferred(operation.ResponseStructure.Name, this.config.ServiceModel)
                        && !operation.WrapsResultShape(operation.ResponseStructure.Name))
                        this.processedStructures.Add(operation.ResponseStructure.Name);
                }

                // This generates the legacy response class which just extends from the result class.
                var responseGenerator = new LegacyResponseClass()
                {
                    OperationName = operation.Name,
                    IsPageable = operation.IsResponsePageable
                };

                if (responseGenerator.IsPageable)
                {
                    responseGenerator.Paginator = operation.ResponsePaginator;
                }

                this.ExecuteGenerator(responseGenerator, operation.Name + "Response.cs", "Model");
            }
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
            this.ExecuteGenerator(new BaseServiceException(), "Amazon" + this.config.BaseName + "Exception.cs");

            foreach (var exception in operation.Exceptions)
            {
                // Check to see if the exceptions has already been generated for a previous operation.
                if (!this.processedStructures.Contains(exception.Name))
                {
                    var generator = new ExceptionClass()
                    {
                        Exception = exception,    
                        GenerateComplexException = this.config.ServiceModel.Customizations.GenerateComplexException
                    };
                    this.ExecuteGenerator(generator, exception.Name + ".cs", "Model");
                    this.processedStructures.Add(exception.Name);
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
                this.processedMarshallers.Add(operation.RequestStructure.Name);

            if (normalizeMarshallers && hasRequest)
            {
                var lookup = new NestedStructureLookup();
                lookup.SearchForNestedStructures(operation.RequestStructure);

                foreach (var nestedStructure in lookup.NestedStructures)
                {
                    if (!this.processedMarshallers.Contains(nestedStructure.Name))
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
                var generator = GetResponseUnmarshaller();
                generator.Operation = operation;
                generator.IsWrapped = operation.IsResponseWrapped;
                generator.HasSuppressedResult = this.config.ServiceModel.Customizations.ResultGenerationSuppressions.Contains(operation.Name);

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
                    if (!IsShapeReferred(operation.ResponseStructure.Name, this.config.ServiceModel)
                                && !operation.WrapsResultShape(operation.ResponseStructure.Name))
                        this.processedUnmarshallers.Add(operation.ResponseStructure.Name);
                }
            }

            if (operation.ResponseStructure != null)
            {
                var lookup = new NestedStructureLookup();
                lookup.SearchForNestedStructures(operation.ResponseStructure);

                foreach (var nestedStructure in lookup.NestedStructures)
                {
                    if (this.config.ServiceModel.Customizations.IsSubstitutedShape(nestedStructure.Name))
                        continue;

                    // Skip already processed unmarshallers. This handles the case of structures being returned in mulitiple requests.
                    if (!this.processedUnmarshallers.Contains(nestedStructure.Name))
                    {
                        var generator = GetStructureUnmarshaller();
                        generator.Structure = nestedStructure;

                        this.ExecuteGenerator(generator, nestedStructure.Name + "Unmarshaller.cs", "Model.Internal.MarshallTransformations");
                        this.processedUnmarshallers.Add(nestedStructure.Name);
                    }
                    else
                    {
                        //throw new Exception();
                    }
                }
            }
        }

        /// <summary>
        /// Provides a way to generate the neccesary attributes and marshallers/unmarshallers for nested structures to work
        /// </summary>
        class NestedStructureLookup
        {
            public List<Shape> NestedStructures { get; private set;}

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

                if(structure.IsStructure)
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
            foreach (var definition in this.config.ServiceModel.Structures)
            {
                if (!this.processedStructures.Contains(definition.Name) && !definition.IsException)
                {
                    // if the shape had a substitution, we can skip generation
                    if (this.config.ServiceModel.Customizations.IsSubstitutedShape(definition.Name))
                        continue;

                    var generator = new StructureGenerator()
                    {
                        ClassName = definition.Name,
                        Structure = definition
                    };
                    this.ExecuteGenerator(generator, definition.Name + ".cs", "Model");
                    this.processedStructures.Add(definition.Name);
                }
            }
        }

        /// <summary>
        /// Generates tests for the customizations of the service
        /// </summary>
        void GenerateCustomizationTests()
        {
            if (this.config.ServiceModel.Customizations.SimpleConstructorsModel.SimpleConstructors.Count > 0)
            {
                var constructorTests = new SimpleConstructorTests()
                {
                    Config = this.config                    
                };
                
                ExecuteCustomizationTestGenerator(constructorTests, this.config.BaseName + "ConstructorTests.cs", "Constructors");
            }

            if (this.config.ServiceModel.Customizations.SimpleMethodsModel.SimpleMethods.Count > 0)
            {
                var methodTests = new SimpleMethodTests()
                {
                    Config = this.config
                };

                ExecuteCustomizationTestGenerator(methodTests, this.config.BaseName + "MethodTests.cs", "SimpleMethods");
            }
        }

        /// <summary>
        /// Runs the generator and saves the content.
        /// </summary>
        /// <param name="generator">The generator to use for outputting the text of the cs file</param>
        /// <param name="fileName">The name of the cs file</param>
        /// <param name="subNamespace">Adds an additional directory for the namespace</param>
        void ExecuteGenerator(BaseGenerator generator, string fileName, string subNamespace = null)
        {
            generator.Config = this.config;
            var text = generator.TransformText();
            WriteFile(config.Namespace, subNamespace, fileName, text, this.outputDirectory);
        }

        /// <summary>
        /// Runs the generator and saves the content into SDK 45 directory.
        /// </summary>
        /// <param name="generator">The generator to use for outputting the text of the cs file</param>
        /// <param name="fileName">The name of the cs file</param>
        /// <param name="subNamespace">Adds an additional directory for the namespace</param>
        void ExecuteGenerator45(BaseGenerator generator, string fileName, string subNamespace = null)
        {
            generator.Config = this.config;
            var text = generator.TransformText();
            WriteFile(config.Namespace, subNamespace, fileName, text, this.outputDirectory45);
        }

        /// <summary>
        /// Runs the generator and saves the content into WINRT directory.
        /// </summary>
        /// <param name="generator">The generator to use for outputting the text of the cs file</param>
        /// <param name="fileName">The name of the cs file</param>
        /// <param name="subNamespace">Adds an additional directory for the namespace</param>
        void ExecuteGeneratorRT(BaseGenerator generator, string fileName, string subNamespace = null)
        {
            generator.Config = this.config;
            var text = generator.TransformText();
            WriteFile(config.Namespace, subNamespace, fileName, text, this.outputDirectoryRT);
        }

        /// <summary>
        /// Runs the generator and saves the content into Portable directory.
        /// </summary>
        /// <param name="generator">The generator to use for outputting the text of the cs file</param>
        /// <param name="fileName">The name of the cs file</param>
        /// <param name="subNamespace">Adds an additional directory for the namespace</param>
        void ExecuteGeneratorPortable(BaseGenerator generator, string fileName, string subNamespace = null)
        {
            generator.Config = this.config;
            var text = generator.TransformText();
            WriteFile(config.Namespace, subNamespace, fileName, text, this.outputDirPortable);
        }

        /// <summary>
        /// Runs the generator and saves the content in the test directory.
        /// </summary>
        /// <param name="generator">The generator to use for outputting the text of the cs file</param>
        /// <param name="fileName">The name of the cs file</param>
        /// <param name="subNamespace">Adds an additional directory for the namespace</param>
        void ExecuteTestGenerator(BaseGenerator generator, string fileName, string subNamespace = null)
        {
            generator.Config = this.config;
            var text = generator.TransformText();
            WriteFile("Marshalling", null, fileName, text, this.testDirectory);
        }

        /// <summary>
        /// Runs the generator and saves the content in the test directory.
        /// </summary>
        /// <param name="generator">The generator to use for outputting the text of the cs file</param>
        /// <param name="fileName">The name of the cs file</param>
        /// <param name="subNamespace">Adds an additional directory for the namespace</param>
        void ExecuteCustomizationTestGenerator(BaseGenerator generator, string fileName, string subNamespace = null)
        {
            generator.Config = this.config;
            var text = generator.TransformText();
            WriteFile("Customizations", subNamespace, fileName, text, this.testDirectory);
        }

        /// <summary>
        /// Runs the generator and saves the content in the test directory.
        /// </summary>
        /// <param name="generator">The generator to use for outputting the text of the cs file</param>
        /// <param name="fileName">The name of the cs file</param>
        /// <param name="subNamespace">Adds an additional directory for the namespace</param>
        void ExecutePaginatorTestGenerator(BaseGenerator generator, string fileName, string subNamespace = null)
        {
            generator.Config = this.config;
            var text = generator.TransformText();
            WriteFile("Paginators", subNamespace, fileName, text, this.testDirectory);
        }

        /// <summary>
        /// Writes the contents to disk. The content will be trimmed of all white space and all tabs are replaced with spaces to make the output consistent.
        /// </summary>
        /// <param name="ns">The service namespace</param>
        /// <param name="subNamespace">An optional sub namespace under the service. (e.g. Model or Model.Internal.MarshallTransformations)</param>
        /// <param name="filename">Filename to right to</param>
        /// <param name="content">The contents to write to the file</param>
        /// <returns>Returns false if the file already exists and has the same content.</returns>
        bool WriteFile(string ns, string subNamespace, string filename, string content, string baseOutputDir)
        {
            var dir = Path.Combine(baseOutputDir, ns);
            if (!string.IsNullOrEmpty(subNamespace))
                dir = Path.Combine(dir, subNamespace.Replace('.', '\\'));

            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            // Replace tabs with spaces and remove any starting and trailing white spaces
            var cleanContent = content.Replace("\t", "    ").Trim();

            var filePath = Path.Combine(dir, filename);
            if (File.Exists(filePath))
            {
                var existingContent = File.ReadAllText(filePath);
                if (string.Equals(existingContent, cleanContent))
                    return false;
            }

            File.WriteAllText(filePath, cleanContent);
            Console.WriteLine("\tUpdated {0}", filename);
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
            switch (this.config.ServiceModel.Type)
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
                    throw new Exception("No request marshaller for service type: " + this.config.ServiceModel.Type);
            }
        }

        /// <summary>
        /// Determines the type of marshaller that needs to be generated based on the service model type
        /// </summary>
        /// <returns>JSONRPCStructureMarshaller for Rest_Json and Json, error otherwise</returns>
        BaseRequestMarshaller GetStructureMarshaller()
        {
            switch (this.config.ServiceModel.Type)
            {
                case ServiceType.Rest_Json:
                case ServiceType.Json:
                    return new JsonRPCStructureMarshaller();
                default:
                    throw new Exception("No structure marshaller for service type: " + this.config.ServiceModel.Type);
            }
        }

        /// <summary>
        /// Determines the type of response unmarshaller to be used based on the service model type
        /// </summary>
        /// <returns>Either a JsonRPCResponseUnmarshaller, a AWSQueryResponseUnmarshaller, or a RestXmlResponseUnmarshaller. Error otherwise</returns>
        BaseResponseUnmarshaller GetResponseUnmarshaller()
        {
            switch (this.config.ServiceModel.Type)
            {
                case ServiceType.Rest_Json:    
                case ServiceType.Json:
                    return new JsonRPCResponseUnmarshaller();
                case ServiceType.Query:
                    if (this.config.ServiceModel.IsEC2Protocol)
                        return new AWSQueryEC2ResponseUnmarshaller();
                    return new AWSQueryResponseUnmarshaller();
                case ServiceType.Rest_Xml:
                    return new RestXmlResponseUnmarshaller();                    
                default:
                    throw new Exception("No response unmarshaller for service type: " + this.config.ServiceModel.Type);
            }
        }

        /// <summary>
        /// Determines the Unmarshaller for structures based on the service model type
        /// </summary>
        /// <returns>Either JsonRPCStructureUnmarshaller, AWSQueryStructureUnmarshaller, or RestXmlStructureUnmarshaller. Error otherwise</returns>
        BaseResponseUnmarshaller GetStructureUnmarshaller()
        {
            switch (this.config.ServiceModel.Type)
            {
                case ServiceType.Rest_Json:   
                case ServiceType.Json:
                    return new JsonRPCStructureUnmarshaller();
                case ServiceType.Query:
                    return new AWSQueryStructureUnmarshaller();
                case ServiceType.Rest_Xml:
                    return new RestXmlStructureUnmarshaller();
                default:
                    throw new Exception("No structure unmarshaller for service type: " + this.config.ServiceModel.Type);
            }
        }
    }
}
