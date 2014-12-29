using Json.LitJson;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ServiceClientGenerator.ResourcesApi
{
    public class ResourceModel
    {
        ModelReader.ResourceModel _resourceModel;
        ServiceModel _serviceModel;

        public ResourceModel(StreamReader reader,
            ServiceModel serviceModel)
        {
            _resourceModel = JsonMapper.ToObject<ModelReader.ResourceModel>(reader, true); ;
            _serviceModel = serviceModel;

            this.Resources = new Dictionary<string, Resource>();
            foreach (var item in _resourceModel.Resources)
            {
                this.Resources.Add(item.Key, new Resource(item.Key, item.Value, serviceModel));
            }
            PopulateSubResources();
            CollectTopLevelResources();

            this.Service = new Service(_resourceModel.Service, _serviceModel);
        }

        public Service Service { get; set; }
        public Dictionary<string, Resource> Resources { get; set; }
        public Dictionary<string, Resource> TopLevelResources { get; set; }


        private void PopulateSubResources()
        {
            foreach (var item in _resourceModel.Resources)
            {
                var resource = this.Resources[item.Key];
                resource.SubResources = new List<Resource>();
                if (item.Value.SubResources != null)
                {
                    foreach (var subResource in item.Value.SubResources.Resources)
                    {
                        resource.SubResources.Add(this.Resources[subResource]);
                    }
                }
            }
        }

        /// <summary>
        /// Determine what the top-level resources are by collecting the list of all subresources
        /// and exluding those resources that appear as subresources.
        /// </summary>
        private void CollectTopLevelResources()
        {
            HashSet<Resource> allSubResources = new HashSet<Resource>();

            foreach (var res in Resources)
            {
                if (res.Value.SubResources != null)
                    foreach (var sub in res.Value.SubResources)
                    {
                        allSubResources.Add(sub);
                    }
            }

            TopLevelResources = new Dictionary<string, Resource>();
            foreach (var res in Resources.Where(r => !allSubResources.Contains(r.Value)))
            {
                TopLevelResources.Add(res.Key, res.Value);
            }
        }
    }

    public class Service
    {
        public Dictionary<string, Action> Actions { get; set; }
        public Dictionary<string, EnumerableAction> HasMany { get; set; }

        public Service(ModelReader.Service service,
            ServiceModel serviceModel)
        {            
            this.Actions = new Dictionary<string, Action>();
            foreach (var item in service.Actions)
            {
                this.Actions.Add(item.Key,
                    new Action(item.Key, item.Value, serviceModel));
            }

            this.HasMany = new Dictionary<string, EnumerableAction>();
            foreach (var item in service.HasMany)
            {
                this.HasMany.Add(item.Key,
                    new EnumerableAction(item.Key, item.Value, serviceModel));
            }
        }
    }

    public class Resource
    {
        ServiceModel _serviceModel;
        ModelReader.Resource _resource;

        private Dictionary<string, ResourceMapping> BelongsTo { get; set; }

        public string Name { get; set; }
        public string ClassName { get; set; }
        public string InterfaceName { get; set; }
        public Dictionary<string, Action> Actions { get; set; }

        public Action LoadAction { get; set; }
        public IList<Resource> SubResources { get; set; }
        public IList<IdentifierMapping> SubResourceIdentifiers { get; set; }


        public Dictionary<string, EnumerableAction> HasMany { get; set; }

        

        /// <summary>
        /// List of key attributes for the resource.
        /// </summary>
        public List<Identifier> Identifiers { get; set; }

        /// <summary>
        /// List of non key attributes for the resource.
        /// </summary>
        public List<Attribute> Attributes { get; set; }

        public Shape Shape { get; set; }

        /// <summary>
        /// Identifiers that do not appear in the shape that this 
        /// resource corresponds to. This information is used to
        /// generate additional constructors to construct a resource
        /// a model and additional identifiers.
        /// E.g. Cloudformation StackResourceSummary.
        /// </summary>
        public List<Identifier> UnmappedIdentifiers { get; private set; } 
 
        public bool CanBeConstructedFromModel
        {
            get
            {
                if (this.Shape != null)
                {
                    foreach (var identifier in this.Identifiers)
                    {
                        if (this.Shape.Members.SingleOrDefault(
                            m=>m.PropertyName.Equals(identifier.MemberName, StringComparison.InvariantCultureIgnoreCase)) == null)
                        {
                            return false;
                        }
                    }
                    return true;
                }
                return false;
            }
        }

        public Resource(string name, ModelReader.Resource resource,
            ServiceModel serviceModel)
        {
            _resource = resource;
            _serviceModel = serviceModel;

            this.Name = name;
            this.ClassName = name;
            this.InterfaceName = "I" + name;

            if (resource.Shape!=null)
            {
                this.Shape = serviceModel.FindShape(resource.Shape);    
            }

            this.Identifiers = new List<Identifier>();            
            foreach (var item in resource.Identifiers)
            {
                this.Identifiers.Add(new Identifier(item));
            }

            this.UnmappedIdentifiers = new List<Identifier>();
            if (this.Shape != null)
            {
                foreach (var identifier in this.Identifiers)
                {
                    if (this.Shape.Members.SingleOrDefault(
                        m => m.PropertyName.Equals(identifier.MemberName)) == null)
                    {
                        this.UnmappedIdentifiers.Add(identifier);
                    }
                }
            }

            this.Actions = new Dictionary<string, Action>();
            if (resource.Actions != null)
            {
                foreach (var item in resource.Actions)
                {
                    this.Actions.Add(item.Key,
                        new Action(item.Key, item.Value, serviceModel));
                }
            }

            

            if (resource.Load != null)
                this.LoadAction = new Action("Load", resource.Load, serviceModel);

            this.HasMany = new Dictionary<string, EnumerableAction>();
            if (resource.HasMany != null)
            {
                foreach (var item in resource.HasMany)
                {
                    this.HasMany.Add(item.Key,
                        new EnumerableAction(item.Key, item.Value, serviceModel));
                }
            }

            this.SubResourceIdentifiers = new List<IdentifierMapping>();
            if (resource.SubResources != null)
            {
                foreach (var item in resource.SubResources.Identifiers)
                {
                    this.SubResourceIdentifiers.Add(new IdentifierMapping
                    (
                        source : item.Key,
                        sourceType : SourceType.Identifier,
                        target : item.Value,
                        serviceModel : serviceModel
                    ));
                }
            }

            StringBuilder parameters = new StringBuilder();
            StringBuilder parameterNames = new StringBuilder();
            foreach (var item in this.Identifiers)
            {
                parameters.AppendFormat("{0} {1}, ", "string", item.Name.ToCamelCase());
                parameterNames.AppendFormat("{0}, ", item.Name.ToCamelCase());
            }

            this.BelongsTo = new Dictionary<string, ResourceMapping>();
            if (resource.BelongsTo != null)
            {
                foreach (var item in resource.BelongsTo)
                {
                    this.BelongsTo.Add(item.Key,
                        new ResourceMapping(item.Value.Resource, serviceModel));
                }
            }


            this.Attributes = new List<Attribute>();
            if (this.Shape!=null)
            {
                foreach (var member in this.Shape.Members)
                {
                    if (this.Identifiers.SingleOrDefault( i=>i.Name == member.PropertyName
                        || i.MemberName == member.PropertyName) == null)
                        
                    {
                        ResourceMapping resourceMapping = null;
                        this.BelongsTo.TryGetValue(member.PropertyName, out resourceMapping);
                        
                        this.Attributes.Add(new Attribute(member,
                            resourceMapping == null ? null : resourceMapping.Type,
                            serviceModel));
                    }
                }
            }
            
        }

        public string IdentifiersAsConstructorParameterNames(IList<IdentifierMapping> identifierMappings = null)
        {
            identifierMappings = identifierMappings ?? new List<IdentifierMapping>();

            var parameterNames = new StringBuilder();
            foreach (var item in this.Identifiers)
            {
                var idMapping = identifierMappings.SingleOrDefault(
                    i => i.Target.Equals(item.Name, StringComparison.InvariantCulture));
                if (idMapping != null)
                {
                    parameterNames.AppendFormat("{0} : {1}, ", item.Name.ToCamelCase(), idMapping.Source.GetIdentifierExpression());
                }
                else
                {
                    parameterNames.AppendFormat("{0} : {1}, ", item.Name.ToCamelCase(), item.Name.ToCamelCase());
                }
            }

            return parameterNames.ToString();
        }

        public string IdentifiersAsConstructorParametersTrimmed(IList<IdentifierMapping> identifierMappings = null)
        {
            return IdentifiersAsConstructorParameters(identifierMappings).TrimEnd(new char[] { ' ', ',' });
        }

        public string IdentifiersAsConstructorParameters(IList<IdentifierMapping> identifierMappings = null)
        {
            identifierMappings = identifierMappings ?? new List<IdentifierMapping>();
            var parameters = new StringBuilder();
            foreach (var item in this.Identifiers)
            {
                if (identifierMappings.SingleOrDefault(
                    i => i.Target.Equals(item.Name, StringComparison.InvariantCulture)) != null)
                    continue;

                parameters.AppendFormat("{0} {1}, ", "string", item.Name.ToCamelCase());
                
            }

            return parameters.ToString();
        }

        public List<string> IdentifiersAsParameters(IList<IdentifierMapping> identifierMappings = null)
        {
            identifierMappings = identifierMappings ?? new List<IdentifierMapping>();
            var parameters = new List<string>();

            foreach (var item in this.Identifiers)
            {
                if (identifierMappings.SingleOrDefault(
                    i => i.Target.Equals(item.Name, StringComparison.InvariantCulture)) != null)
                    continue;

                parameters.Add(item.Name.ToCamelCase());
            }

            return parameters;
        }

        /// <summary>
        /// Gets the post fix for the method generated for top level resources and
        /// for sub resources. E.g. "GetRoleByName" "GetAccessKeyById"
        /// </summary>
        /// <returns></returns>
        public string GetResourceMethodPostFix(IList<IdentifierMapping> identifierMappings = null)
        {
            var postFix = "ById";
            var identifiers = new List<Identifier>(this.Identifiers);

            if (identifierMappings != null)
            {
                foreach (var item in identifierMappings)
                {
                    var id = identifiers.SingleOrDefault(
                        i => i.Name.Equals(item.Target, StringComparison.InvariantCulture));

                    if (id != null)
                        identifiers.Remove(id);
                }
            }

            if (identifiers.Count == 0)
                postFix = "";
            else if (identifiers.Count == 1)            
                postFix = String.Format("By{0}", identifiers.First().Name);            

            return postFix;
        }
    }

    public class Attribute
    {
        ServiceModel _serviceModel;
        string _resourceType;

        public Member Member { get; private set; }

        public Shape Shape { get { return this.Member.Shape; } }

        /// <summary>
        /// Checks if the given shape is defined as 
        /// a resource in the resource model.
        /// </summary>        
        public Resource Resource
        {
            get
            {
                return _serviceModel.ResourceModel.Resources[_resourceType];
            }
        }

        public bool IsResource
        {
            get
            {
                return !string.IsNullOrWhiteSpace(_resourceType);
            }
        }

        public string Type
        {
            get
            {
                if (!this.IsResource)
                {
                    return this.Member.DetermineType() +
                         (this.Member.UseNullable ? "?" : "");                   
                }
                else
                {
                    if (this.Member.IsList)
                        return "List<" + this.Resource.InterfaceName + ">";
                    else
                        return this.Resource.InterfaceName;
                }
            }
        }

        public Attribute(Member member, string resourceType, ServiceModel serviceModel)
        {
            _serviceModel = serviceModel;
            _resourceType = resourceType;
            this.Member = member;
        }
    }

    public enum Cardinality
    {
        ZeroOrOne,
        One,
        Many
    }

    public class Action
    {
        ModelReader.Action _action;
        ServiceModel _serviceModel;

        protected Operation Operation { get; private set; }

        protected virtual Cardinality Cardinality
        {
            get
            {
                return Cardinality.One;
            }
        }

        /// <summary>
        /// The action name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The name of the method generated for this action
        /// </summary>
        public string MethodName { get; set; }

        /// <summary>
        /// The resource interface type returned by the action.
        /// </summary>
        public string ReturnTypeInterface { get; set; }

        /// <summary>
        /// The resource concrete type returned by the action.
        /// </summary>
        public string ReturnTypeResource { get; set; }

        /// <summary>
        /// If the return type is an array, gives the return type
        /// as an IEnumerable otherwise the plain return type is
        /// handed back.
        /// </summary>
        public string ReturnTypeExpression
        {
            get
            {
                if (IsCollectionReturnType)
                    return string.Format("IEnumerable<{0}>", ReturnTypeInterface);

                return ReturnTypeInterface;
            }
        }

        public bool IsCollectionReturnType
        {
            get { return Resource != null && Resource.Path != null && Resource.Path.IsArrayExpression; }
        }

        public bool IsVoidReturnType
        {
            get { return ReturnTypeInterface.Equals("void"); }    
        }

        public string ReturnTypeComment
        {
            get
            {
                if (IsCollectionReturnType)
                    return string.Format("/// <returns>A collection of {0} resources.</returns>", ReturnTypeResource);

                return string.Format("/// <returns>An instance of {0} resource.</returns>", ReturnTypeResource);
            }
        }

        /// <summary>
        /// The resource concrete type returned by the action.
        /// </summary>
        public string ReturnType { get; set; }

        /// <summary>
        /// The name of the SDK API (which may be the paginating method) Method for this action.
        /// </summary>
        public string RequestOperationName { get; set; }

        /// <summary>
        /// The name of the Service API for this action
        /// </summary>
        public string BaseOperationName { get; set; }

        /// <summary>
        /// The request type for the low level API.
        /// </summary>
        public string RequestType { get; set; }

        /// <summary>
        /// The name of the request (input) shape.
        /// </summary>
        public string RequestShape { get; set; }

        /// <summary>
        /// The name of the response (output) shape.
        /// </summary>
        public string ResponseShape { get; set; }

        /// <summary>
        /// Indicates if the low level API for this action returns
        /// data for all attributes of the resource.
        /// </summary>
        public bool ReturnsResource
        {
            get { return _action.Resource.Path != null; }
        }

        /// <summary>
        /// If the service model has custom method forms defined in the customization JSON
        /// build up the information that we'll need for resource actions and has-many.
        /// </summary>
        public IList<CustomActionForm> CustomForms
        {
            get
            {
                var simple = this.ServiceModel.Customizations.SimpleMethodsModel;

                if (simple.CreateSimpleMethods(this.BaseOperationName))
                {
                    return (from form in simple.SimpleMethods[this.BaseOperationName].Forms
                            select new CustomActionForm(this, form))
                            .ToList();
                }
                return new List<CustomActionForm>();
            }
        }

        public JmesPath Path { get; set; }

        //List<IdentifierMapping> _requestParameterMappings = new List<IdentifierMapping>();
        /// <summary>
        /// Mapping of parameters for invoking the low level API.
        /// </summary>
        public List<IdentifierMapping> RequestParameterMappings
        {
            get
            {
                var parameters = new List<IdentifierMapping>();
                if (_action.Request.Params != null)
                {
                    foreach (var item in _action.Request.Params)
                    {
                        parameters.Add(new IdentifierMapping(item, _serviceModel.FindOperation(this.BaseOperationName).RequestStructure, _serviceModel));
                    }
                }
                return parameters;
            }
        }

        public bool HasRequestParameterMappings
        {
            get
            {
                return this.RequestParameterMappings.Count > 0;
            }
        }

        /// <summary>
        /// Mapping of identifiers required to construct the resource
        /// returned by this action.
        /// </summary>
        public string ResourceIdentifiersAsConstructorParameters
        {
            get
            {
                var parameters = new StringBuilder();
                if (this.ReturnsResource)
                {
                    if (this.Cardinality == ResourcesApi.Cardinality.One)
                    {
                        parameters.AppendFormat("model : {0}, ", this.Resource.Path.GetIdentifierExpression());

                        
                    }
                    else if (this.Cardinality == ResourcesApi.Cardinality.Many)
                    {
                        parameters.Append("model : item, ");
                    }

                    var resource = _serviceModel.ResourceModel.Resources[this.Resource.Type];
                    if (resource.UnmappedIdentifiers.Count() > 0)
                    {
                        foreach (var item in this.Resource.Identifiers)
                        {
                            if (resource.UnmappedIdentifiers.Exists(i => i.Name.Equals(item.Target)))
                            {
                                parameters.AppendFormat("{0} : {1}, ",
                                item.Target.ToCamelCase(),
                                item.Source.GetIdentifierExpression());
                            }
                        }
                    }
                }
                else
                {
                    foreach (var item in this.Resource.Identifiers)
                    {
                        parameters.AppendFormat("{0} : {1}, ",
                            item.Target.ToCamelCase(),
                            item.Source.GetIdentifierExpression());
                    }
                }
                parameters.Append("client : this.Client");
                return parameters.ToString();
            }
        }

        /// <summary>
        /// Returns the C# expression to construct the 
        /// resource returned by this action.
        /// </summary>
        public string ResourceConstructionExpression
        {
            get
            {
                return string.Format("new {0}({1})",
                    this.ReturnType, this.ResourceIdentifiersAsConstructorParameters);
            }
        }

        public ResourceMapping Resource { get; set; }

        public ServiceModel ServiceModel  { 
            get { return this._serviceModel; }
        }

        

        public Action(string name, ModelReader.Action action,
            ServiceModel serviceModel)
        {
            _action = action;
            _serviceModel = serviceModel;
            this.Name = name;
            this.MethodName = name;
            this.Operation = serviceModel.FindOperation(action.Request.Operation);
            this.RequestOperationName = this.Operation.Name;
            this.BaseOperationName = this.Operation.Name;
            this.RequestType = this.Operation.Name + "Request";
            this.RequestShape = this.Operation.RequestStructure == null ? string.Empty : this.Operation.RequestStructure.Name;
            this.ResponseShape = this.Operation.ResponseStructure == null ? string.Empty : this.Operation.ResponseStructure.Name;

            if (!string.IsNullOrEmpty(_action.Path))
               this.Path = new JmesPath(_action.Path, SourceType.ResponsePath, _serviceModel);

            if (action.Resource != null)
            {
                this.ReturnTypeResource = action.Resource.Type;
                this.ReturnType = "Internal." + action.Resource.Type;
                this.ReturnTypeInterface = "I" + action.Resource.Type;
            }
            else
            {
                Shape responseShape = null;
                if (!String.IsNullOrEmpty(this.ResponseShape)
                    && (responseShape = _serviceModel.FindShape(this.ResponseShape)) != null
                    && responseShape.Members.Count() > 0)
                {
                    this.ReturnType = this.Operation.Name + "Response";
                    this.ReturnTypeInterface = this.ReturnType;
                }
                else
                {
                    this.ReturnType = "void";
                    this.ReturnTypeInterface = this.ReturnType;
                }
            }

            if (action.Resource != null)
                this.Resource = new ResourceMapping(action.Resource, serviceModel);
        }
    }

    /// <summary>
    /// An action which returns one or more resources of the same type.
    /// </summary>
    public class EnumerableAction : Action
    {
        private ModelReader.Action _action;

        protected override Cardinality Cardinality
        {
            get
            {
                return Cardinality.Many;
            }
        }

        /// <summary>
        /// Returns the property of the response which contains the 
        /// list of result values.
        /// </summary>
        public string ResultKey
        {
            get
            {
                return "." + this.Resource.Identifiers.First(
                    p => p.SourceType == SourceType.ResponsePath &&
                    p.Source.IsArrayExpression).Source.GetEnumerableMember();
            }
        }

        /// <summary>
        /// Indicates if the low level API for this action
        /// supports paging.
        /// </summary>
        public bool IsPageable
        {
            get { return this.Operation.IsResponsePageable; }
        }

        

        public EnumerableAction(string name, ModelReader.Action action,
            ServiceModel serviceModel) : base (name, action, serviceModel)
        {
            _action = action;
            this.RequestOperationName = Operation.IsResponsePageable ?
                Operation.Name + "Enumerator" :
                Operation.Name;
        }
    }

    public class CustomActionForm
    {
        private Action _action;

        /// <summary>
        /// The string representing the parameters for a custom method
        /// </summary>
        public string Parameters { get; set; }

        /// <summary>
        /// The members of the custom method
        /// </summary>
        public IList<Member> Members { get; set; }
        
        /// <summary>
        /// The param docs for a custom method
        /// </summary>
        public IDictionary<string, string> ParameterDocs { get; set; }
        

        /// <summary>
        /// Model a custom method for resource actions
        /// </summary>
        /// <param name="action">The action</param>
        /// <param name="form">the parameters of the custom method form</param>
        public CustomActionForm(Action action, List<string> form)
        {
            this._action = action;
            Shape shape = null;
            if (!string.IsNullOrEmpty(action.RequestShape))
                shape = action.ServiceModel.FindShape(action.RequestShape);

            if (shape != null)
            {
                Members = (from m in shape.Members
                           where form.Contains(m.PropertyName)
                           select m)
                           .ToList();
            }
            else
            {
                Members = new List<Member>();
            }

            var docMembers = action.ServiceModel.Customizations.SimpleMethodsModel.GetFormMembers(form, Members);
            Parameters = action.ServiceModel.Customizations.SimpleMethodsModel.GetSimpleParameters(form, Members);

            ParameterDocs = new Dictionary<string, string>();

            foreach(var member in docMembers)
            {
                ParameterDocs[member.ArgumentName] = String.Format("/// <param name=\"{0}\">{1}</param>",
                    member.ArgumentName,
                    member.GetParamDocumentationForOperation(action.BaseOperationName));
            }
        }

        /// <summary>
        /// Copy this form, removing the specified identifiers
        /// </summary>
        /// <param name="identifiers">Identifiers to remove</param>
        /// <returns>Copy of the form without the identifiers</returns>
        public CustomActionForm WithoutIdentifiers(IList<string> identifiers)
        {
            var newMembers = from m in this.Members
                             where !identifiers.Contains(m.PropertyName, StringComparer.InvariantCultureIgnoreCase)
                             select m.PropertyName;

            return new CustomActionForm(this._action, newMembers.ToList());
        }

        /// <summary>
        /// Copy this form, removing the resource's request parameters.
        /// </summary>
        /// <returns>Copy of this form without the request parameters.</returns>
        public CustomActionForm WithoutIdentifiers()
        {
            var ids = this._action.RequestParameterMappings;
            var targets = from i in ids 
                          select i.Target;

            return WithoutIdentifiers(targets.ToList());
        }
    }

    public class ResourceMapping
    {
        public string Type { get; set; }
        public List<IdentifierMapping> Identifiers { get; set; }

        public JmesPath Path { get; set; }

        public ResourceMapping(ModelReader.ResourceMapping resourceMapping,
            ServiceModel serviceModel)
        {
            this.Type = resourceMapping.Type;

            if (!string.IsNullOrEmpty(resourceMapping.Path))
                this.Path = new JmesPath(resourceMapping.Path, SourceType.ResponsePath, serviceModel);

            this.Identifiers = new List<IdentifierMapping>();
            foreach (var item in resourceMapping.Identifiers)
            {
                this.Identifiers.Add(new IdentifierMapping(item, serviceModel));
            }
        }
    }

    /// <summary>
    /// Mapping of a single identifier.
    /// </summary>
    public class IdentifierMapping
    {
        public SourceType SourceType { get; private set; }
        public JmesPath Source { get; private set; }
        public Shape TargetShape { get; private set; }

        public string Target { get; private set; }

        public bool IsTargetArrayType
        {
            get { return Target.EndsWith("[]"); }
        }

        public string NonArrayedTarget
        {
            get
            {
                if (IsTargetArrayType)
                    return Target.TrimEnd('[', ']');

                return Target;
            }
        }

        public IdentifierMapping(string source, SourceType sourceType, string target,
            ServiceModel serviceModel) : this(source, sourceType, target, null, serviceModel) { }

        public IdentifierMapping(string source, SourceType sourceType, string target,
            Shape targetShape, ServiceModel serviceModel)
        {
            this.SourceType = sourceType;
            this.Source = new JmesPath(source,
                sourceType, targetShape, serviceModel);
            this.Target = target;
            this.TargetShape = targetShape;
        }

        public IdentifierMapping(ModelReader.IdentifierMapping identifierMapping,
             ServiceModel serviceModel)
            : this(identifierMapping, null, serviceModel) { }

        public IdentifierMapping(ModelReader.IdentifierMapping identifierMapping,
            Shape targetShape, ServiceModel serviceModel)
        {
            this.SourceType = identifierMapping.SourceType;
            this.Target = identifierMapping.Target;
            this.TargetShape = targetShape;
            this.Source = new JmesPath(identifierMapping, targetShape, serviceModel);
        }
    }

    public class JmesPath
    {        
        ServiceModel _serviceModel;
        string _path;
        string _leadingArrayExpression =  string.Empty;
        string _memberExpression = string.Empty;
        Shape _targetShape;
        Member _targetMember;

        public bool IsArrayExpression
        {
            get { return _path.Contains("[]"); }
        }

        public SourceType SourceType { get; private set; }

        public JmesPath(string path, SourceType type, ServiceModel serviceModel)
        {
            _serviceModel = serviceModel;
            _path = path;
            this.SourceType = type;
            ParsePath();
        }

        public JmesPath(string path, SourceType type, Shape targetShape, ServiceModel serviceModel)
        {
            _serviceModel = serviceModel;
            _targetShape = targetShape;
            _path = path;
            this.SourceType = type;
            ParsePath();
        }

        public JmesPath(ModelReader.IdentifierMapping identifierMapping, Shape targetShape, ServiceModel serviceModel)
        {
            _serviceModel = serviceModel;
            _path = identifierMapping.Source;
            _targetShape = targetShape;
            this.SourceType = identifierMapping.SourceType;
            if (_targetShape != null)
            {
                _targetMember = targetShape.Members
                    .Where(m => m.PropertyName.Equals(identifierMapping.Target,
                        StringComparison.InvariantCultureIgnoreCase))
                    .SingleOrDefault();
            }
            ParsePath();
        }

        public string GetIdentifierExpression(bool isExpressionForLoop = false)
        {
            if (this.SourceType == ResourcesApi.SourceType.ResponsePath)
            {
                if (_path.Equals("$") || _path.Equals("@"))
                {
                    return "response";
                }
                else if (this.IsArrayExpression)
                {
                    if (isExpressionForLoop)
                        return "response." + _path.TrimEnd('[',']');
                                                       
                    return string.IsNullOrWhiteSpace(_memberExpression) ?
                        "item" : "item." + _memberExpression;
                }
                else
                    return "response." + _memberExpression.ToPascalCase();             
            }
            else if (this.SourceType == ResourcesApi.SourceType.Identifier ||
                this.SourceType == ResourcesApi.SourceType.DataMember)
            {
                return "this." + _memberExpression.ToPascalCase();
            }
            else if (this.SourceType == ResourcesApi.SourceType.RequestParameter)
            {
                return "request." + _memberExpression.ToPascalCase();
            }
            else if (this.SourceType == ResourcesApi.SourceType.String)
            {
                return ConvertConstantExpression();
            }
            throw new NotImplementedException();
        }

        public string ConvertConstantExpression()
        {
            if (_targetMember != null)
            {
                var typeOverride = _targetMember.OverrideDataType;

                if ((typeOverride != null && typeOverride.DataType.Equals("bool")) 
                    || _targetMember.Shape.IsBoolean)
                {
                    var val = Convert.ToBoolean(_path);
                    return _path;
                }

                if ((typeOverride != null && typeOverride.DataType.Equals("int")) 
                    || _targetMember.Shape.IsInt)
                {
                    var val = Convert.ToInt32(_path);
                    return _path;
                }

                if ((typeOverride != null && typeOverride.DataType.Equals("long")) 
                    || _targetMember.Shape.IsLong)
                {
                    var val = Convert.ToInt64(_path);
                    return _path;
                }
            }
            
            return String.Format("\"{0}\"", _path);
        }

        public string GetMemberExpression()
        {
            // Works only for simplest expressions
            var leading = _path.Split('.').First();
            leading.Split(new string[]{""},StringSplitOptions.RemoveEmptyEntries).First();

            return leading;
        }

        public string GetEnumerableMember()
        {
            // Works only for simplest expressions
            var leading = _path.Split('.').First();
            leading= leading.Split(new string[] { "[]" },
                StringSplitOptions.RemoveEmptyEntries).First();

            return leading;
        }

        void ParsePath(IEnumerable<string> segments, Shape currentShape)
        {
            if (null == segments || segments.Count() < 1)
                return;

            _targetShape = currentShape;
            var segment = segments.ElementAt(0);

            if (segment.Contains("[]"))
            {
                _leadingArrayExpression = segment;
            }
            else
            {
                if ((this.SourceType == SourceType.RequestParameter || this.SourceType == SourceType.ResponsePath) && currentShape != null)
                {
                    var name = segment.Contains("[]") ? segment.Substring(0, segment.IndexOf('[')) : segment;
                    var targetMember = currentShape.Members.SingleOrDefault(m => m.PropertyName.Equals(name, StringComparison.InvariantCultureIgnoreCase));
                    if (targetMember != null)
                        _memberExpression = _memberExpression + "." + targetMember.PropertyName;
                    else
                        _memberExpression = _memberExpression + "." + segment;
                }
                else
                    _memberExpression = _memberExpression + "." + segment;
            }

            ParsePath(segments.Skip(1), ShapeForMember(currentShape, segment));
        }

        void ParsePath()
        {
            ParsePath(_path.Split('.'), _targetShape);
            _memberExpression = _memberExpression.TrimStart('.');
        }

        Shape ShapeForMember(Shape shape, string memberName)
        {
            if (null != shape)
            {
                var name = memberName.Contains("[]") ? memberName.Substring(0, memberName.IndexOf('[')) : memberName;
               var member = shape.Members.SingleOrDefault(m => m.MarshallName == name);
                if (member != null)
                    return member.Shape;
            }
            return null;
        }

    //    void ParsePath()
    //    {
    //        var segments = _path.Split('.');

    //        if (segments.Count() == 1)
    //        {
    //            if (segments[0].Contains("[]"))
    //            {
    //                _leadingArrayExpression = segments[0];
    //                return;
    //            }
    //            else
    //            {
    //                _memberExpression = segments[0];
    //                Member targetMember = null;
    //                if (_targetShape != null)
        //                    targetMember = _targetShape.Members.SingleOrDefault(m => m.MarshallName == _memberExpression);
    //                if (targetMember != null)
    //                    _memberExpression = targetMember.PropertyName;
    //                return;
    //            }
    //        }
            
    //        var lastArraySegment = segments.LastOrDefault(s => s.Contains("[]"));

    //        bool memberExpressionReached = lastArraySegment == null;
    //        var currentShape = _targetShape;
    //        foreach (var segment in segments)
    //        {
    //            if (!memberExpressionReached)
    //            {
    //                if (segment == lastArraySegment)
    //                    memberExpressionReached = true;

    //                continue;
    //            }

    //            Member targetMember = null;;
    //            if (currentShape != null)
    //                targetMember = currentShape.Members.Where(m => m.MarshallName == segment.Substring(0, segment.IndexOf('['))).SingleOrDefault();
    //            if (targetMember != null)
    //                _memberExpression = _memberExpression + "." + targetMember.PropertyName;
    //            else
    //                _memberExpression = _memberExpression + "." + segment;
    //        }
    //        // Remove leading "." from member expression
    //        _memberExpression = _memberExpression.TrimStart('.');

    //    }
    }

    public enum SourceType
    {
        DataMember,
        RequestParameter,
        ResponsePath,
        Identifier,
        String
    }


    public class Identifier
    {
        public string Name { get; private set; }

        string _memberName;
        public string MemberName
        {
            get { return _memberName ?? this.Name; }
        }

        public Identifier(ModelReader.Identifier identifier)
        {
            this.Name = identifier.Name;
            _memberName = identifier.MemberName;
        }

    }    
}

