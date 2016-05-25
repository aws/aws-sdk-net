using Json.LitJson;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceClientGenerator
{
    #region Simplifications

    #region SimpleConstructorsModel

    /// <summary>
    /// A model that represents the simple constructors of a structure. These constructors are specified in customizations
    /// Simple constructors are constructors that are added to request objects that take parameters to set members of the object.
    /// This allows for easier creation of these request objects.
    /// </summary>
    public class SimpleConstructorsModel
    {
        public const string ConstructorsKey = "constructors";

        JsonData _documentRoot;
        readonly bool _emptyData = false;

        /// <summary>
        /// Creates a model for simple constructors for the structure. Used to customize the generation of the structure
        /// </summary>
        /// <param name="root">The json data that contains information about the customization</param>
        public SimpleConstructorsModel(JsonData root)
        {
            if (root.PropertyNames.Contains("simpleConstructors", StringComparer.OrdinalIgnoreCase))
            {
                _documentRoot = root["simpleConstructors"];
            }
            else
            {
                _documentRoot = new JsonData();
                _emptyData = true;
            }
        }

        /// <summary>
        /// Sets the document root from a json text
        /// </summary>
        /// <param name="reader">The reader to get the json text from</param>
        void Initialize(TextReader reader)
        {
            this._documentRoot = JsonMapper.ToObject(reader);
        }

        /// <summary>
        /// A dictionary that maps structure names to the form of the constructor
        /// </summary>
        public Dictionary<string, ConstructorForms> SimpleConstructors
        {
            get
            {
                var constructors = new Dictionary<string, ConstructorForms>(StringComparer.OrdinalIgnoreCase);

                var data = _documentRoot[ConstructorsKey];
                if (data == null) return constructors;

                foreach (KeyValuePair<string, JsonData> kvp in data)
                {

                    constructors[kvp.Key] = new ConstructorForms(kvp.Key, kvp.Value);
                }

                return constructors;
            }
        }

        /// <summary>
        /// Determines if custom constructors need to be generated for the structure
        /// </summary>
        /// <param name="className">The name of the structure to check for</param>
        /// <returns>True if there are custom simple constructors</returns>
        public bool CreateSimpleConstructors(string className)
        {
            if (_emptyData)
                return false;
            return SimpleConstructors.ContainsKey(className);
        }

        /// <summary>
        /// A list of members for the structure that are used in the constructor form
        /// </summary>
        /// <param name="form">A list of the member names used by the constructor form</param>
        /// <param name="operationMembers">All of the members for the structure</param>
        /// <returns>The members for the form</returns>
        public List<Member> GetFormMembers(List<string> form, IList<Member> operationMembers)
        {

            var docMembers = new List<Member>();
            foreach (var mem in form)
            {
                foreach (var opmem in operationMembers)
                {
                    if (opmem.PropertyName.Equals(mem, StringComparison.OrdinalIgnoreCase))
                    {
                        docMembers.Add(opmem);
                        break;
                    }
                }
            }

            return docMembers;
        }

        /// <summary>
        /// Used to generate a string used to define the params for the constructor
        /// </summary>
        /// <param name="form">List of member names for the constructor form</param>
        /// <param name="operationMembers">All of the members of the structure</param>
        /// <returns>A string that represents the required params for the constructor form</returns>
        public string GetSimpleParameters(List<string> form, IList<Member> operationMembers)
        {
            string currentParams = "";

            foreach (var mem in form)
            {
                Member member = null;
                foreach (var opmem in operationMembers)
                {
                    if (opmem.PropertyName.Equals(mem, StringComparison.OrdinalIgnoreCase))
                    {
                        member = opmem;
                        break;
                    }
                }

                if (member == null)
                    throw new ArgumentOutOfRangeException("Unable to find matching member");

                if (currentParams == "")
                    currentParams = member.DetermineType() + " " + GeneratorHelpers.CamelCaseParam(member.PropertyName);
                else
                    currentParams = currentParams + ", " + member.DetermineType() + " " + GeneratorHelpers.CamelCaseParam(member.PropertyName);
            }

            return currentParams;
        }
    }

    #endregion

    #region ConstructorForms

    /// <summary>
    /// Represents forms of the constructor
    /// The constructor forms are the different parameter options of a constructor
    /// </summary>
    public class ConstructorForms
    {
        public const string ConstructorFormsKey = "constructorForms";

        readonly JsonData _constructorRoot;
        readonly string _name;

        public string Name { get { return _name; } }

        /// <summary>
        /// Creates a representation for a constructor in the structure consisting of a list of a list of member names
        /// </summary>
        /// <param name="name">The name of the constructor</param>
        /// <param name="json">The json customization for the constructor forms</param>
        public ConstructorForms(string name, JsonData json)
        {
            this._name = name;
            this._constructorRoot = json;
        }

        /// <summary>
        /// A list of forms for the constructor consisting of the names of members in each form
        /// </summary>
        public List<List<string>> Forms
        {
            get
            {
                var forms = new List<List<string>>();

                var data = _constructorRoot[ConstructorFormsKey];
                if (data == null || !data.IsArray) return forms;

                foreach (var formData in data)
                {
                    var form = new List<string>();
                    foreach (var item in (formData as JsonData))
                    {
                        form.Add(item.ToString());
                    }
                    forms.Add(form);
                }

                return forms;
            }
        }
    }

    #endregion

    #region SimpleMethodFormsModel

    /// <summary>
    /// Represents custom simple methods for the client being generated from the service model
    /// Simple methods are methods added to the client that take members of the request as parameters and then creates a request with those
    /// members internally and then calls the operation
    /// </summary>
    public class SimpleMethodFormsModel
    {
        public const string SimpleMethodsKey = "simpleMethods";

        readonly JsonData _documentRoot;
        readonly bool _emptyData = false;

        /// <summary>
        /// Creates a representation of the simple method customizations for the service client
        /// </summary>
        /// <param name="root">The json data that specifies forms of the simple methods</param>
        public SimpleMethodFormsModel(JsonData root)
        {
            if (root.PropertyNames.Contains(SimpleMethodsKey, StringComparer.OrdinalIgnoreCase))
            {
                _documentRoot = root[SimpleMethodsKey];
            }
            else
            {
                _documentRoot = new JsonData();
                _emptyData = true;
            }
        }

        /// <summary>
        /// A mapping of method names to the forms for that simple method
        /// </summary>
        public Dictionary<string, MethodForms> SimpleMethods
        {
            get
            {
                var methods = new Dictionary<string, MethodForms>(StringComparer.OrdinalIgnoreCase);

                var data = _documentRoot[ServiceModel.OperationsKey];
                if (data == null) return methods;

                foreach (KeyValuePair<string, JsonData> kvp in data)
                {
                    methods[kvp.Key] = new MethodForms(kvp.Key, kvp.Value);
                }

                return methods;
            }
        }

        /// <summary>
        /// Determines if the operation in the client has a custom simple method specified
        /// </summary>
        /// <param name="operationName">The name of the operation</param>
        /// <returns>If the operation is specified in the customizations</returns>
        public bool CreateSimpleMethods(string operationName)
        {
            if (_emptyData)
                return false;
            return SimpleMethods.ContainsKey(operationName);
        }

        /// <summary>
        /// Finds the members from the request that need to be used in the method
        /// </summary>
        /// <param name="form">List of member names for the given form of an operation</param>
        /// <param name="operationMembers">All of the members for the given operation</param>
        /// <returns></returns>
        public List<Member> GetFormMembers(List<string> form, IList<Member> operationMembers)
        {
            var docMembers = new List<Member>();
            foreach (var mem in form)
            {
                foreach (var opmem in operationMembers)
                {
                    if (opmem.PropertyName.Equals(mem, StringComparison.OrdinalIgnoreCase))
                    {
                        docMembers.Add(opmem);
                        break;
                    }
                }
            }

            return docMembers;
        }

        /// <summary>
        /// Generates the code for parameters of the method
        /// </summary>
        /// <param name="form">The form of the method contains names of all the members used</param>
        /// <param name="operationMembers">All of the members of an operation</param>
        /// <returns>A proper syntax for params of the simple method form</returns>
        public string GetSimpleParameters(List<string> form, IList<Member> operationMembers)
        {
            string currentParams = "";

            foreach (var mem in form)
            {
                Member member = null;
                foreach (var opmem in operationMembers)
                {
                    if (opmem.PropertyName.Equals(mem, StringComparison.OrdinalIgnoreCase))
                    {
                        member = opmem;
                        break;
                    }
                }

                if (member == null)
                    throw new ArgumentOutOfRangeException("Unable to find matching member");

                string type = member.DetermineType();
                if (type == "Stream")
                    type = "System.IO.Stream";

                if (currentParams == "")
                    currentParams = type + " " + GeneratorHelpers.CamelCaseParam(member.PropertyName);
                else
                    currentParams = currentParams + ", " + type + " " + GeneratorHelpers.CamelCaseParam(member.PropertyName);
            }

            return currentParams;
        }
    }

    #endregion

    #region MethodForms

    /// <summary>
    /// Represents the forms of a custom simple method
    /// Forms of a simple method are the variety of parameters the method will have
    /// </summary>
    public class MethodForms
    {
        public const string MethodFormsKey = "methodForms";

        readonly JsonData _methodRoot;
        readonly string _name;

        public string Name { get { return _name; } }

        /// <summary>
        /// Creates a representation of the forms for a custom simple method
        /// </summary>
        /// <param name="name">The name of the method</param>
        /// <param name="json">The json model for the customization consisting of a list of forms</param>
        public MethodForms(string name, JsonData json)
        {
            this._name = name;
            this._methodRoot = json;
        }

        /// <summary>
        /// The forms of a method which is a list of a list of member names for that form
        /// </summary>
        public List<List<string>> Forms
        {
            get
            {
                var forms = new List<List<string>>();

                var data = _methodRoot[MethodFormsKey];
                if (data == null || !data.IsArray) return forms;

                foreach (var formData in data)
                {
                    var form = new List<string>();
                    foreach (var item in (formData as JsonData))
                    {
                        form.Add(item.ToString());
                    }
                    forms.Add(form);
                }

                return forms;
            }
        }
    }

    #endregion

    #endregion

    #region CustomizationsModel

    /// <summary>
    /// A model used to represent different types of customizations for generating a service
    /// </summary>
    public class CustomizationsModel
    {
        public const string RetainOriginalMemberOrderingKey = "retainOriginalMemberOrdering";
        public const string RuntimePipelineOverrideKey = "runtimePipelineOverride";
        public const string UnityOverridesKey = "unityOverrides";
        public const string UnityGenerateSyncClientKey = "generateSyncClient";
        public const string UnityExclusionApiKey = "exclusionApi";
        public const string OverridesKey = "overrides";
        public const string OperationKey = "operation";
        public const string TargetTypeKey = "targetType";
        public const string NewTypeKey = "newType";
        public const string ConstructorInputKey = "constructorInput";
        public const string NoArgOverloadsKey = "noArgOverloads";
        public const string SuppressResultGenerationKey = "suppressResultGeneration";
        public const string UseNullableTypeKey = "useNullableType";
        public const string EmitIsSetPropertiesKey = "emitIsSetProperties";
        public const string GlobalShapeKey = "*";
        public const string ShapeSubstitutionsKey = "shapeSubstitutions";
        public const string EmitAsShapeKey = "emitAsShape";
        public const string RenameShapeKey = "renameShape";
        public const string EmitFromMemberKey = "emitFromMember";
        public const string ListMemberSuffixExclusionsKey = "listMemberSuffixExclusions";
        public const string DataTypeSwapKey = "dataTypeSwap";
        public const string TypeKey = "Type";
        public const string MarshallerKey = "Marshaller";
        public const string UnmarshallerKey = "Unmarshaller";
        public const string GenerateComplexExceptionKey = "generateComplexException";
        public const string SuppressSimpleMethodExceptionDocsKey = "suppressSimpleMethodExceptionDocs";
        public const string XHttpMethodOverrideKey = "xHttpMethodOverride";
        public const string XamarinSampleSolutionFileKey = "xamarinSamples";
        public const string DeprecatedOverridesKey = "deprecatedOverrides";
        public const string DeprecationMessageKey = "message";
        public const string ExamplesKey = "examples";
        public const string GenerateUnmarshallerKey = "generateUnmarshaller";
        public const string SkipUriPropertyValidationKey = "skipUriPropertyValidation";
        JsonData _documentRoot;

        SimpleMethodFormsModel _simpleMethodsModel;
        SimpleConstructorsModel _simpleConstructorsModel;

        /// <summary>
        /// A model that represents any custom methods to be generated by the client generator
        /// </summary>
        public SimpleMethodFormsModel SimpleMethodsModel
        {
            get { return _simpleMethodsModel ?? (_simpleMethodsModel = new SimpleMethodFormsModel(_documentRoot)); }
        }

        /// <summary>
        /// A model that represents any simple constructors to be included while generating structures for the service
        /// </summary>
        public SimpleConstructorsModel SimpleConstructorsModel
        {
            get
            {
                return _simpleConstructorsModel ??
                       (_simpleConstructorsModel = new SimpleConstructorsModel(_documentRoot));
            }
        }

        /// <summary>
        /// Creates a customization model used to get customizations for a service
        /// </summary>
        /// <param name="reader">Reader to get the json text from</param>
        public CustomizationsModel(TextReader reader)
        {
            if (reader == null)
                this._documentRoot = new JsonData();
            else
                Initialize(reader);
        }

        /// <summary>
        /// Creates a customization model used to get customizations for a service
        /// </summary>
        /// <param name="modelPath">Path to the file to read the customizations from</param>
        public CustomizationsModel(string modelPath)
        {
            if (string.IsNullOrEmpty(modelPath))
                _documentRoot = new JsonData();
            else
                using (var reader = new StreamReader(modelPath))
                    Initialize(reader);
        }

        /// <summary>
        /// Sets the document root by parsing the json text
        /// </summary>
        /// <param name="reader">The reader to get json text from</param>
        void Initialize(TextReader reader)
        {
            this._documentRoot = JsonMapper.ToObject(reader);
        }

        RuntimePipelineOverride _runtimePipelineOverride;

        /// <summary>
        /// Allows customizing pipeline overrides to be added to the client
        /// </summary>
        public RuntimePipelineOverride PipelineOverride
        {
            get
            {
                if (_runtimePipelineOverride != null)
                {
                    return _runtimePipelineOverride;
                }
                var data = _documentRoot[RuntimePipelineOverrideKey];
                if (data != null)
                {
                    _runtimePipelineOverride = new RuntimePipelineOverride();

                    foreach (var item in data[OverridesKey])
                    {
                        var jsonData = (JsonData)item;
                        _runtimePipelineOverride.Overrides.Add(
                            new RuntimePipelineOverride.Override()
                            {
                                OverrideMethod = jsonData[OperationKey] != null ? jsonData[OperationKey].ToString() : null,
                                TargetType = jsonData[TargetTypeKey] != null ? jsonData[TargetTypeKey].ToString() : null,
                                NewType = jsonData[NewTypeKey] != null ? jsonData[NewTypeKey].ToString() : null,
                                ConstructorInput = jsonData[ConstructorInputKey] != null ? jsonData[ConstructorInputKey].ToString() : ""
                            });
                    }
                }
                return _runtimePipelineOverride;
            }
        }

        RuntimePipelineOverride _unityRuntimePipelineOverride;

        /// <summary>
        /// Allows customizing pipeline overrides to be added to the client specific to unity
        /// </summary>
        public RuntimePipelineOverride UnityPipelineOverride
        {
            get
            {
                if (_unityRuntimePipelineOverride != null)
                {
                    return _unityRuntimePipelineOverride;
                }
                var data = _documentRoot[UnityOverridesKey];
                if (data == null)
                    return null;

                data = data[RuntimePipelineOverrideKey];

                if (data != null)
                {
                    _unityRuntimePipelineOverride = new RuntimePipelineOverride();

                    foreach (var item in data[OverridesKey])
                    {
                        var jsonData = (JsonData)item;
                        _unityRuntimePipelineOverride.Overrides.Add(
                            new RuntimePipelineOverride.Override()
                            {
                                OverrideMethod = jsonData[OperationKey] != null ? jsonData[OperationKey].ToString() : null,
                                TargetType = jsonData[TargetTypeKey] != null ? jsonData[TargetTypeKey].ToString() : null,
                                NewType = jsonData[NewTypeKey] != null ? jsonData[NewTypeKey].ToString() : null,
                                ConstructorInput = jsonData[ConstructorInputKey] != null ? jsonData[ConstructorInputKey].ToString() : ""
                            });
                    }
                }
                return _unityRuntimePipelineOverride;
            }
        }

        public bool GenerateSyncClientForUnity
        {
            get
            {
                var data = _documentRoot[UnityOverridesKey];
                if (data == null)
                    return false;

                var flag = data[UnityGenerateSyncClientKey];
                if (flag != null && flag.IsBoolean)
                {
                    return (bool)flag;
                }
                else if (flag != null && flag.IsString)
                {
                    return bool.Parse((string)flag);
                }
                return false;
            }
        }

        public List<string> UnityExclusionApi
        {
            get
            {
                var data = _documentRoot[UnityOverridesKey];
                if (data == null)
                    return new List<string>();

                data = data[UnityExclusionApiKey];

                if (data != null)
                {
                    return (from object pcf in data select pcf.ToString()).ToList();
                }
                return new List<string>();
            }
        }

        public bool AllowHttpMethodOverride
        {
            get
            {
                var data = _documentRoot[UnityOverridesKey];
                if (data == null)
                    return false;

                if (!data.PropertyNames.Contains(XHttpMethodOverrideKey))
                    return false;

                if(data[XHttpMethodOverrideKey].IsBoolean)
                {
                    return (bool)data[XHttpMethodOverrideKey];
                }
                else
                {
                    return false;
                }
            }
        }

        public bool GenerateComplexException
        {
            get
            {
                var flag = _documentRoot[GenerateComplexExceptionKey];
                if (flag != null && flag.IsBoolean)
                {
                    return (bool)flag;
                }
                else if (flag != null && flag.IsString)
                {
                    return bool.Parse((string)flag);
                }
                return false;
            }
        }

        public bool SuppressSimpleMethodExceptionDocs
        {
            get
            {
                var flag = _documentRoot[SuppressSimpleMethodExceptionDocsKey];
                if (flag != null && flag.IsBoolean)
                {
                    return (bool)flag;
                }
                else if (flag != null && flag.IsString)
                {
                    return bool.Parse((string)flag);
                }
                return false;
            }
        }


        public bool RetainOriginalMemberOrdering
        {
            get
            {
                var flag = _documentRoot[RetainOriginalMemberOrderingKey];
                if (flag != null && flag.IsBoolean)
                {
                    return (bool)flag;
                }
                else if (flag != null && flag.IsString)
                {
                    return bool.Parse((string)flag);
                }
                return false;
            }
        }

        /// <summary>
        /// A list of uri properties for the service where we should not do validation for presence.
        /// </summary>
        public List<string> SkipUriPropertyValidations
        {
            get
            {
                var validations = new List<string>();

                var data = _documentRoot[SkipUriPropertyValidationKey];
                if (data == null || !data.IsArray) return validations;

                foreach (var item in data)
                    validations.Add(item.ToString());

                return validations;
            }
        }

        /// <summary>
        /// A list of methods that will be customized to have no arguments as one form of the operation
        /// </summary>
        public List<string> NoArgOverloads
        {
            get
            {
                var overloads = new List<string>();

                var data = _documentRoot[NoArgOverloadsKey];
                if (data == null || !data.IsArray) return overloads;

                foreach (var item in data)
                    overloads.Add(item.ToString());

                overloads.Sort();

                return overloads;
            }
        }

        private HashSet<string> _resultGenerationSuppressions = null;

        /// <summary>
        /// A list of methods that will be customized to not have a derived
        /// Result class due to an empty response.
        /// </summary>
        public HashSet<string> ResultGenerationSuppressions
        {
            get
            {
                if (_resultGenerationSuppressions == null)
                {
                    _resultGenerationSuppressions = new HashSet<string>();

                    var data = _documentRoot[SuppressResultGenerationKey];
                    if (data != null && data.IsArray)
                    {
                        foreach (var item in data)
                            _resultGenerationSuppressions.Add(item.ToString());
                    }
                }

                return _resultGenerationSuppressions;
            }
        }

        public string GetDeprecationMessage(string operationName)
        {
            try
            {
                var data = _documentRoot[DeprecatedOverridesKey];
                var operations = data[OperationKey];
                var operation = operations[operationName];
                return (string)operation[DeprecationMessageKey];
            }
            catch (NullReferenceException) { }

            throw new Exception(string.Format(@"deprecatedOverrides entry not set for deprecated operation {0}", operationName));
        }

        public bool GenerateCustomUnmarshaller
        {
            get
            {
                var data = _documentRoot[GenerateUnmarshallerKey];
                if (data == null)
                    return false;
                return true;
            }
        }

        public List<string> CustomUnmarshaller
        {
            get
            {
                var data = _documentRoot[GenerateUnmarshallerKey];
                if (data == null)
                    return null;

                return (from JsonData s in data select s.ToString()).ToList();
            }
        }

        /// <summary>
        /// Determines if the operation has a customization for creating a no argument method
        /// </summary>
        /// <param name="operationName">The name of the operation to check for</param>
        /// <returns>True if the operation is in the list of noarg customizations</returns>
        public bool CreateNoArgOverload(string operationName)
        {
            return NoArgOverloads.Contains(operationName, StringComparer.OrdinalIgnoreCase);
        }

        /// <summary>
        /// Gets the property modifier for a property in a shape (can be global) if so customized.
        /// </summary>
        /// <param name="shapeName">The name of the shape containing the property</param>
        /// <param name="propertyName">The property name to look for</param>
        /// <returns>The property modifier, null if not found</returns>
        public PropertyModifier GetPropertyModifier(string shapeName, string propertyName)
        {
            // for renames, check for a shape-specific rename first, then look to
            // see if the property is globally renamed
            if (ShapeModifiers.ContainsKey(shapeName))
            {
                var shapeModifiers = ShapeModifiers[shapeName];
                if (shapeModifiers.IsModified(propertyName))
                    return shapeModifiers.PropertyModifier(propertyName);
            }

            if (ShapeModifiers.ContainsKey(GlobalShapeKey))
            {
                var globalShapeModifiers = ShapeModifiers[GlobalShapeKey];
                if (globalShapeModifiers.IsModified(propertyName))
                    return globalShapeModifiers.PropertyModifier(propertyName);
            }

            return null;
        }

        /// <summary>
        /// Determines if the property has a customization to be set to nullable
        /// </summary>
        /// <param name="shapeName">The name of the shape the property is in</param>
        /// <param name="propertyName">The name of the property</param>
        /// <returns>If the property is to be nullable</returns>
        public bool UseNullable(string shapeName, string propertyName)
        {
            var data = _documentRoot[UseNullableTypeKey];
            if (data == null)
                return false;

            var shape = data[shapeName] as JsonData;
            if (shape == null || !shape.IsArray)
                return false;

            foreach (var name in shape)
            {
                if (string.Equals(name.ToString(), propertyName))
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Determines if the collection property can be empty when being
        /// sent to the service.
        /// </summary>
        /// <param name="shapeName">The name of the shape the property is in</param>
        /// <param name="propertyName">The name of the property</param>
        /// <returns>If the collection property can be empty</returns>
        public bool EmitIsSetProperties(string shapeName, string propertyName)
        {
            var data = _documentRoot[EmitIsSetPropertiesKey];
            if (data == null)
                return false;

            var shape = data[shapeName] as JsonData;
            if (shape == null || !shape.IsArray)
                return false;

            foreach (var name in shape)
            {
                if (string.Equals(name.ToString(), propertyName))
                    return true;
            }

            return false;
        }

        public string GetOverrideShapeName(string originalShapeName)
        {
            return GetRemappedShapeName(originalShapeName, RenameShapeKey);
        }

        /// <summary>
        /// Returns the name of the shape that should be used instead of the supplied shape
        /// </summary>
        /// <param name="originalShapeName">The shape to have its name changed</param>
        /// <returns>The new name, or null if not found</returns>
        public string GetSubstituteShapeName(string originalShapeName)
        {
            return GetRemappedShapeName(originalShapeName, EmitAsShapeKey);
        }

        private string GetRemappedShapeName(string originalShapeName, string key)
        {
            var substitutionsData = _documentRoot[ShapeSubstitutionsKey];
            if (substitutionsData == null)
                return null;

            var shapeRemapData = substitutionsData[originalShapeName] as JsonData;
            if (null == shapeRemapData || null == shapeRemapData[key])
                return null;

            return (string)shapeRemapData[key];
        }

        /// <summary>
        /// Returns the substitution entry for a shape
        /// </summary>
        /// <param name="originalShapeName"></param>
        /// <returns></returns>
        public JsonData GetSubstituteShapeData(string originalShapeName)
        {
            var substitutionsData = _documentRoot[ShapeSubstitutionsKey];
            if (substitutionsData == null)
                return null;

            return substitutionsData[originalShapeName];
        }

        /// <summary>
        /// Determines if the shape should be substituted with another
        /// </summary>
        /// <param name="originalShapeName">The original shape</param>
        /// <returns>If the shape is in the rename shapes</returns>
        public bool IsSubstitutedShape(string originalShapeName)
        {
            var substitutionsData = _documentRoot[ShapeSubstitutionsKey];
            if (substitutionsData == null)
                return false;

            var remapShape = substitutionsData[originalShapeName] as JsonData;
            return remapShape != null;
        }

        /// <summary>
        /// Gets any customizations for a new data type to be used on a property
        /// </summary>
        /// <param name="shapeName">The name of the shape the property is defined within</param>
        /// <param name="propertyName">The name of the property to check</param>
        /// <returns>The override datatype object, null if not found</returns>
        public DataTypeOverride OverrideDataType(string shapeName, string propertyName)
        {
            var data = _documentRoot[DataTypeSwapKey];
            if (data == null)
                return null;

            var shape = data[shapeName] as JsonData;
            if (shape == null)
                return null;

            var jsonData = shape[propertyName];
            if (jsonData == null)
                return null;

            var dataType = (string)jsonData[TypeKey];
            string marshaller = null;
            if (jsonData[MarshallerKey] != null && jsonData[MarshallerKey].IsString)
                marshaller = (string)jsonData[MarshallerKey];

            string unmarshaller = null;
            if (jsonData[UnmarshallerKey] != null && jsonData[UnmarshallerKey].IsString)
                unmarshaller = (string)jsonData[UnmarshallerKey];

            return new DataTypeOverride(dataType, marshaller, unmarshaller);
        }

        #region ShapeModifier

        /// <summary>
        /// The ShapeModifier allows shapes pulled from the model to be customized by excluding
        /// properties, modifying them (rename etc) and injecting properties not in the original
        /// model.
        /// </summary>
        public class ShapeModifier
        {
            public const string ShapeModifiersKey = "shapeModifiers";
            public const string ExcludeKey = "exclude";
            public const string ModifyKey = "modify";
            public const string InjectKey = "inject";
            public const string CustomMarshallKey = "customMarshall";

            private readonly HashSet<string> _excludedProperties = new HashSet<string>();
            private readonly Dictionary<string, JsonData> _modifiedProperties = new Dictionary<string, JsonData>();
            private readonly Dictionary<string, JsonData> _injectedProperties = new Dictionary<string, JsonData>();

            #region Property Exclusion

            public void AddExclusion(string propertyName)
            {
                _excludedProperties.Add(propertyName);
            }

            public bool IsExcludedProperty(string propertyName)
            {
                return _excludedProperties.Contains(propertyName);
            }

            #endregion

            #region Property Modifiers

            public void AddModifier(string propertyName, JsonData modifierData)
            {
                _modifiedProperties.Add(propertyName, modifierData);
            }

            public bool IsModified(string propertyName)
            {
                return _modifiedProperties.ContainsKey(propertyName);
            }

            public PropertyModifier PropertyModifier(string propertyName)
            {
                if (IsModified(propertyName))
                    return new PropertyModifier(propertyName, _modifiedProperties[propertyName]);

                return null;
            }

            #endregion

            #region Property Injection

            public void AddInjection(string propertyName, JsonData shapeData)
            {
                _injectedProperties.Add(propertyName, shapeData);
            }

            public bool HasInjectedProperties
            {
                get { return _injectedProperties.Any(); }
            }

            public IEnumerable<string> InjectedPropertyNames
            {
                get
                {
                    var names = new List<string>();
                    if (HasInjectedProperties)
                    {
                        names.AddRange(_injectedProperties.Keys);
                    }
                    return names;
                }
            }

            public PropertyInjector InjectedPropertyData(string propertyName)
            {
                if (!_injectedProperties.ContainsKey(propertyName))
                    throw new ArgumentException();

                return new PropertyInjector(_injectedProperties[propertyName]);
            }

            #endregion
        }

        /// <summary>
        /// Injects a new property into a model shape
        /// </summary>
        public class PropertyInjector
        {
            private readonly JsonData _injectionData;

            internal PropertyInjector(JsonData injectionData)
            {
                this._injectionData = injectionData;
            }

            public JsonData Data { get { return _injectionData; } }

            public bool IsSetUseCustomMarshall
            {
                get { return _injectionData[ShapeModifier.CustomMarshallKey] != null; }
            }

            // If set, the generated request marshaller will skip the member in
            // favor of custom marshall logic in the pipeline
            public bool UseCustomMarshall
            {
                get
                {
                    if (IsSetUseCustomMarshall)
                        return (bool)_injectionData[ShapeModifier.CustomMarshallKey];

                    return false;
                }
            }
        }

        /// <summary>
        /// Property modifiers allow properties to be renamed within a shape
        /// as well as apply custom marshal names (for re-used shapes that
        /// marshal differently)
        /// </summary>
        public class PropertyModifier
        {
            public const string EmitPropertyNameKey = "emitPropertyName";
            public const string LocationNameKey = "locationName";
            public const string AccessModifierKey = "accessModifier";

            private readonly string _modelPropertyName; // for debug inspection assist
            private readonly JsonData _modifierData;

            internal PropertyModifier(string modelPropertyName, JsonData modifierData)
            {
                this._modelPropertyName = modelPropertyName;
                this._modifierData = modifierData;
            }

            // The access modifier for the property. Defaults to public if not set in the customization.
            public string AccessModifier
            {
                get
                {
                    if (_modifierData[AccessModifierKey] == null)
                        return "public";

                    return (string)_modifierData[AccessModifierKey];
                }
            }

            // The user-visible name that should be output for the property
            public string EmitName
            {
                get
                {
                    if (_modifierData[EmitPropertyNameKey] == null)
                        return null;

                    return (string)_modifierData[EmitPropertyNameKey];
                }
            }

            // The custom marshal name for the property. If not set, the model
            // marshal name should be used.
            public string LocationName
            {
                get
                {
                    if (_modifierData[LocationNameKey] == null)
                        return null;

                    return (string)_modifierData[LocationNameKey];
                }
            }

            // For properties that are collections, the submember name that
            // should be used to extract the value when marshalling into the
            // operation.
            public string EmitFromMemberName
            {
                get
                {
                    if (_modifierData[EmitFromMemberKey] == null)
                        return null;

                    return (string)_modifierData[EmitFromMemberKey];
                }
            }

            public bool IsSetUseCustomMarshall
            {
                get { return _modifierData[ShapeModifier.CustomMarshallKey] != null; }
            }

            // If set, the generated request marshaller will skip the member in
            // favor of custom marshall logic in the pipeline
            public bool UseCustomMarshall
            {
                get
                {
                    if (IsSetUseCustomMarshall)
                        return (bool)_modifierData[ShapeModifier.CustomMarshallKey];

                    return false;
                }
            }

        }

        #endregion

        private Dictionary<string, ShapeModifier> _shapeModifiers = null;

        // Exclusion modifier is a simple array of property names.
        //  "exclude": [ "propName1", "propName2" ]
        private static void ParseExclusions(ShapeModifier shapeModifier, JsonData data)
        {
            if (data == null)
                return;

            foreach (var exclusion in data)
            {
                shapeModifier.AddExclusion(exclusion.ToString());
            }
        }

        // A modifier is an array of objects, each object being the original
        // property name (key) and an object containing replacement name (value)
        // along with any custom marshal naming to apply.
        // "modify": [
        //        { 
        //           "modelPropertyName": { 
        //               "emitPropertyName": "userVisibleName", 
        //               "locationName": "customRequestMarshalName",
        //               "emitFromMember": "subMember"
        //           } 
        //        }
        // ]
        private static void ParseModifiers(ShapeModifier shapeModifier, JsonData data)
        {
            if (data == null)
                return;

            foreach (var modifier in data)
            {
                var m = modifier as JsonData;
                var key = m.PropertyNames.First();
                shapeModifier.AddModifier(key, m[key]);
            }
        }

        // Injection modifier is an array of objects, each object being the
        // name of the member to add plus any needed shape/marshalling data.
        //   "inject": [ 
        //      { "propertyName": 
        //          { "type": "list",
        //             "member": { "shape": "String", "locationName": "item" }
        //          }
        //      }
        //  ]
        // Since we don't have access to the model at this point, we simply store
        // the json data for the shape type to be used and 'hydrate' it when needed
        // externally
        private static void ParseInjections(ShapeModifier shapeModifier, JsonData data)
        {
            if (data == null)
                return;

            foreach (var injection in data)
            {
                var i = injection as JsonData;

                var propertyName = i.PropertyNames.First();
                shapeModifier.AddInjection(propertyName, i[propertyName]);
            }
        }

        /// <summary>
        /// A dictionary containing modifiers for each shape that is customized
        /// </summary>
        public Dictionary<string, ShapeModifier> ShapeModifiers
        {
            get
            {
                if (_shapeModifiers == null)
                {
                    _shapeModifiers = new Dictionary<string, ShapeModifier>();

                    var data = _documentRoot[ShapeModifier.ShapeModifiersKey];
                    if (data != null)
                    {
                        foreach (var shapeName in data.PropertyNames)
                        {
                            var shapeModifier = new ShapeModifier();
                            var modifierData = data[shapeName];

                            ParseExclusions(shapeModifier, modifierData[ShapeModifier.ExcludeKey]);
                            ParseModifiers(shapeModifier, modifierData[ShapeModifier.ModifyKey]);
                            // Process additions after rename to allow for models where we
                            // add a 'convenience' member (for backwards compatibility) using
                            // the same name as an original (and now renamed) member.
                            ParseInjections(shapeModifier, modifierData[ShapeModifier.InjectKey]);

                            _shapeModifiers.Add(shapeName, shapeModifier);
                        }
                    }
                }

                return _shapeModifiers;
            }
        }

        public ShapeModifier GetShapeModifier(string shapeName)
        {
            var shapeModifiers = ShapeModifiers;
            return shapeModifiers.ContainsKey(shapeName) ? shapeModifiers[shapeName] : null;
        }

        /// <summary>
        /// Returns true if the specified property name is excluded at global or
        /// per-shape scope.
        /// </summary>
        /// <param name="propertyName"></param>
        /// <param name="shapeName"></param>
        /// <returns></returns>
        public bool IsExcludedProperty(string propertyName, string shapeName = null)
        {
            var globalShapeModifier = GetShapeModifier("*");
            if (globalShapeModifier != null)
            {
                if (globalShapeModifier.IsExcludedProperty(propertyName))
                    return true;
            }

            if (shapeName != null)
            {
                var shapeModifier = GetShapeModifier(shapeName);
                if (shapeModifier != null)
                    return shapeModifier.IsExcludedProperty(propertyName);
            }

            return false;
        }

        public OperationModifiers GetOperationModifiers(string operationName)
        {
            var data = _documentRoot[OperationModifiers.OperationModifiersKey];
            if (data == null)
                return null;

            var operation = data[operationName] as JsonData;
            if (operation == null)
                return null;

            var modifiers = new OperationModifiers();
            if (operation[OperationModifiers.NameKey] != null && operation[OperationModifiers.NameKey].IsString)
                modifiers.Name = (string)operation[OperationModifiers.NameKey];
            if (operation[OperationModifiers.ExcludeKey] != null && operation[OperationModifiers.ExcludeKey].IsBoolean)
                modifiers.IsExcluded = (bool)operation[OperationModifiers.ExcludeKey];
            if (operation[OperationModifiers.InternalKey] != null && operation[OperationModifiers.InternalKey].IsBoolean)
                modifiers.IsInternal = (bool)operation[OperationModifiers.InternalKey];
            if (operation[OperationModifiers.DeprecatedKey] != null && operation[OperationModifiers.DeprecatedKey].IsBoolean)
                modifiers.IsDeprecated = (bool)operation[OperationModifiers.DeprecatedKey];
            if (operation[OperationModifiers.UseWrappingResultKey] != null && operation[OperationModifiers.UseWrappingResultKey].IsBoolean)
                modifiers.UseWrappingResult = (bool)operation[OperationModifiers.UseWrappingResultKey];
            if (operation[OperationModifiers.WrappedResultShapeKey] != null && operation[OperationModifiers.WrappedResultShapeKey].IsString)
                modifiers.WrappedResultShape = (string)operation[OperationModifiers.WrappedResultShapeKey];
            if (operation[OperationModifiers.WrappedResultMemberKey] != null && operation[OperationModifiers.WrappedResultMemberKey].IsString)
                modifiers.WrappedResultMember = (string)operation[OperationModifiers.WrappedResultMemberKey];
            if (operation[OperationModifiers.DocumentationKey] != null && operation[OperationModifiers.DocumentationKey].IsString)
                modifiers.Documentation = (string)operation[OperationModifiers.DocumentationKey];

            if (operation[OperationModifiers.MarshallNameOverrides] != null &&
                operation[OperationModifiers.MarshallNameOverrides].IsArray)
            {
                foreach (JsonData marshalOverride in operation[OperationModifiers.MarshallNameOverrides])
                {
                    var shapeName = marshalOverride.PropertyNames.First();
                    var marshalData = marshalOverride[shapeName];
                    modifiers.AddMarshallNameOverride(shapeName, marshalData);
                }
            }

            return modifiers;
        }

        public JsonData GetExamples(string operationName)
        {

            if (_documentRoot.PropertyNames.Contains(ExamplesKey) &&
                _documentRoot[ExamplesKey].IsObject &&
                _documentRoot[ExamplesKey].PropertyNames.Contains(operationName) &&
                _documentRoot[ExamplesKey][operationName].IsArray)
                return _documentRoot[ExamplesKey][operationName];
            
            var empty = new JsonData();
            empty.SetJsonType(JsonType.Array);
            return empty;
            
        }

        public bool HasExamples
        {
            get
            {
                return _documentRoot.PropertyNames.Contains(ExamplesKey) &&
                       _documentRoot[ExamplesKey].IsObject &&
                       _documentRoot[ExamplesKey].PropertyNames.Any();
            }
        }

        //review directory separator
        public string XamarinSolutionSamplePath
        {
            get
            {
                var xamarinSamples = _documentRoot[XamarinSampleSolutionFileKey];
                if (xamarinSamples == null)
                    return null;

                var solutionPath = xamarinSamples[SampleInfo.SolutionPathKey];
                if (solutionPath == null || !solutionPath.IsString)
                    return null;

                return solutionPath.ToString().Replace("/", "\\");
            }
        }

        #region Samples Key
        public class SampleInfo
        {
            public const string SolutionPathKey = "solutionPath";
        }
        #endregion

        #region OperationModifiers

        /// <summary>
        /// A class used to specify modifiers of a client method
        /// </summary>
        public class OperationModifiers
        {
            public const string OperationModifiersKey = "operationModifiers";
            public const string NameKey = "name";
            public const string ExcludeKey = "exclude";
            public const string InternalKey = "internal";
            public const string UseWrappingResultKey = "useWrappingResult";
            public const string WrappedResultShapeKey = "wrappedResultShape";
            public const string WrappedResultMemberKey = "wrappedResultMember";
            public const string MarshallNameOverrides = "marshallNameOverrides";
            public const string DeprecatedKey = "deprecated";
            public const string DocumentationKey = "documentation";

            // within a marshal override for a shape; one or both may be present
            public const string MarshallLocationName = "marshallLocationName";
            public const string MarshallName = "marshallName";

            private Dictionary<string, JsonData> _marshallNameOverrides = null;

            /// <summary>
            /// The name of the operation modified
            /// </summary>
            public string Name
            {
                get;
                set;
            }

            /// <summary>
            /// Indicates if the operation should be excluded
            /// </summary>
            public bool IsExcluded
            {
                get;
                set;
            }

            /// <summary>
            /// Indicates if the operation should be marked internal in the client
            /// </summary>
            public bool IsInternal
            {
                get;
                set;
            }

            /// <summary>
            /// Indicates if the operation should be marked deprecated in the client
            /// </summary>
            public bool IsDeprecated
            {
                get;
                set;
            }

            public bool UseWrappingResult
            {
                get;
                set;
            }

            public string WrappedResultShape
            {
                get;
                set;
            }

            public string WrappedResultMember
            {
                get;
                set;
            }

            public string Documentation
            {
                get;
                set;
            }

            public void AddMarshallNameOverride(string shapeName, JsonData overrides)
            {
                if (_marshallNameOverrides == null)
                    _marshallNameOverrides = new Dictionary<string, JsonData>();

                _marshallNameOverrides.Add(shapeName, overrides);
            }

            public MarshallNameOverrides GetMarshallNameOverrides(string shapeName, string propertyName)
            {
                if (_marshallNameOverrides == null || !_marshallNameOverrides.ContainsKey(shapeName))
                    return null;

                var shapeOverrides = _marshallNameOverrides[shapeName][propertyName];
                if (shapeOverrides == null)
                    return null;

                var overrideData = new MarshallNameOverrides();
                if (shapeOverrides[MarshallLocationName] != null)
                    overrideData.MarshallLocationName = (string)shapeOverrides[MarshallLocationName];
                if (shapeOverrides[MarshallName] != null)
                    overrideData.MarshallName = (string)shapeOverrides[MarshallName];

                return overrideData;
            }
        }

        /// <summary>
        /// Contains the naming overrides for a property in a member for marshal
        /// purposes. This allows shapes that are reused to employ different wire
        /// names between operations if necessary.
        /// </summary>
        public class MarshallNameOverrides
        {
            public string MarshallName { get; set; }
            public string MarshallLocationName { get; set; }
        }

        #endregion

        #region DataTypeOverride

        /// <summary>
        /// A class that represents type overrides for a member
        /// </summary>
        public class DataTypeOverride
        {
            /// <summary>
            /// Creates an override class that specifies overrides for a member
            /// </summary>
            /// <param name="dataType">The new custom type for a member</param>
            /// <param name="marshaller">The custom marshaller for a member</param>
            /// <param name="unmarshaller">The custom unmarshaller for a member</param>
            public DataTypeOverride(string dataType, string marshaller, string unmarshaller)
            {
                this.DataType = dataType;
                this.Marshaller = marshaller;
                this.Unmarshaller = unmarshaller;
            }

            /// <summary>
            /// The new datatype for the property
            /// </summary>
            public string DataType
            {
                get;
                private set;
            }

            /// <summary>
            /// The new marshaller for the property
            /// </summary>
            public string Marshaller
            {
                get;
                private set;
            }

            /// <summary>
            /// The new unmarshaller for the property
            /// </summary>
            public string Unmarshaller
            {
                get;
                private set;
            }
        }

        #endregion

        #region RuntimePipelineOverride

        /// <summary>
        /// A class used to specify overidden runtime details
        /// </summary>
        public class RuntimePipelineOverride
        {
            public List<Override> Overrides { get; set; }

            /// <summary>
            /// Creates a runtime pipeline override that specifies new details about the pipeline
            /// </summary>
            public RuntimePipelineOverride()
            {
                this.Overrides = new List<Override>();
            }

            /// <summary>
            /// A class that contains specific override details
            /// </summary>
            public class Override
            {
                public Override()
                {
                }

                /// <summary>
                /// Allows overriding a method in the pipeline
                /// </summary>
                public string OverrideMethod { get; set; }

                /// <summary>
                /// Overrides the type in the pipeline
                /// </summary>
                public string NewType { get; set; }

                /// <summary>
                /// Overrides the targettype in the pipeline
                /// </summary>
                public string TargetType { get; set; }

                /// <summary>
                /// Overrides the constructor input in the pipeline
                /// </summary>
                public string ConstructorInput { get; set; }

                /// <summary>
                /// Proceses the override method and provides what type of override should be generated based on the string
                /// </summary>
                public string FormattedOverrideMethod
                {
                    get
                    {
                        switch (OverrideMethod)
                        {
                            case "add": return "AddHandler";
                            case "addAfter": return string.Format(CultureInfo.InvariantCulture,
                                "AddHandlerAfter<{0}>", this.TargetType);
                            case "addBefore": return string.Format(CultureInfo.InvariantCulture,
                                "AddHandlerBefore<{0}>", this.TargetType);
                            case "remove": return string.Format(CultureInfo.InvariantCulture,
                                "RemoveHandler<{0}>", this.TargetType);
                            case "replace": return string.Format(CultureInfo.InvariantCulture,
                                "ReplaceHandler<{0}>", this.TargetType);
                            default:
                                throw new ArgumentException("Invalid override method" + OverrideMethod,
                                    "overrideMethod");
                        }
                    }
                }
            }
        }

        #endregion

    }

    #endregion
}
