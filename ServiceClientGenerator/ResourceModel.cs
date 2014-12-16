//using Json.LitJson;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ServiceClientGenerator
//{
//    public class ResourceModel
//    {

//        public const string
//            ServiceKey = "service",
//            ActionsKey = "actions",
//            HasManyKey = "hasMany",
//            ResourcesKey = "resources",
//            ResourceKey = "resource",
//            TypeKey = "type",
//            PathKey = "path",
//            ShapeKey = "shape",
//            RequestKey = "request",
//            OperationKey = "operation";


//        public ResourceModel(ServiceModel model, JsonData data)
//        {
            

//            ServiceModel = model;
//            Data = data;
//        }

//        public ServiceModel ServiceModel { get; private set; }
        
//        public JsonData Data { get; private set; }

//        public IList<Resource> Resources
//        {
//            get
//            {
//                IList<Resource> list = new List<Resource>();
                
//                if (null == Data)
//                    return list;

//                var resources = Data[ResourcesKey];

//                if (resources != null && resources.IsObject)
//                {
//                    list = resources.PropertyNames
//                        .Select(r =>
//                            new Resource(
//                                r,
//                                resources[r],
//                                this)).ToList();
//                }
//                return list;
//            }
//        }

//        public Resource FindResource(string resourceName)
//        {
//            if (null == Data)
//                return null;

//            var resources = Data[ResourcesKey];

//            if (resources != null && resources.IsObject)
//            {
//                return resources.PropertyNames
//                    .Where(p => p.Equals(resourceName))
//                    .Select(r => new Resource(r, resources[r], this)).FirstOrDefault();
//            }

//            return null;
//        }

//        /// <summary>
//        /// Return the actions for the resource root
//        /// </summary>
//        public IList<ResourceAction> Actions
//        {
//            get
//            {
//                var list = new List<ResourceAction>();

//                var actions = Extract(Data, ServiceKey, ActionsKey);

//                if (actions != null && actions.IsObject)
//                {
//                    list = actions.PropertyNames
//                        .Select(a => new ResourceAction(a, actions[a], this)).ToList();
//                }

//                return list;
//            }
//        }

//        public IList<ResourceAction> HasMany
//        {
//            get
//            {
//                var list = new List<ResourceAction>();

//                var actions = Extract(Data, ServiceKey, HasManyKey);

//                if (actions != null && actions.IsObject)
//                {
//                    list = actions.PropertyNames
//                        .Select(a => new ResourceAction(a, actions[a], this)).ToList();
//                }

//                return list;
//            }
//        }

//        /// <summary>
//        /// Get the JsonData at the path relative to the data passed in
//        /// </summary>
//        /// <param name="data">A JsonData object.</param>
//        /// <param name="path">The elements of the path to the desired object.</param>
//        /// <returns>The JsonData found at the specified path or null if the path isn't found.</returns>
//        public static JsonData Extract(JsonData data, params string[] path)
//        {
//            if (null == data || !data.IsObject)
//                return null;

//            if (path.Length == 1)
//                return data[path[0]];

//            return Extract(data[path[0]], path.Skip(1).ToArray());
//        }

//        /// <summary>
//        /// Extract the string at a given path in a JsonData object.
//        /// </summary>
//        /// <param name="data">The JsonData object to search.</param>
//        /// <param name="defaultValue">The value to return if the path is not found</param>
//        /// <param name="path">The elements of the path to retrieve</param>
//        /// <returns>he string found at that path in the JSON, or the default value.</returns>
//        public static string ExtractString(JsonData data, string defaultValue, params string[] path)
//        {
//            var item = Extract(data, path);
//            if (null == item || !item.IsString)
//                return defaultValue;
//            return item.ToString();
//        }

//    }

//    public class Resource
//    {
//        ResourceModel _resourceModel;
//        ServiceModel _serviceModel;
//        JsonData _data;

//        public Resource(string name, JsonData data, ResourceModel resourceModel)
//        {
//            Name = name;
//            _resourceModel = resourceModel;
//            _serviceModel = resourceModel.ServiceModel;
//            _data = data;

//            var shapeName = ResourceModel.ExtractString(data, null, ResourceModel.ShapeKey);
//            if (shapeName != null)
//            {
//                this.Shape = _serviceModel.FindShape(shapeName);
//            }
//        }

//        public Dictionary<string,string> Identifiers
//        {
//            get
//            {
//                var identifiers = new Dictionary<string,string>();
//                var ids = _data["identifiers"];
//                ParseIdentifiers(identifiers, ids);
//                return identifiers;
//            }
//        }

//        private void ParseIdentifiers(Dictionary<string, string> identifiers, JsonData ids)
//        {
//            foreach (var item in ids)
//            {
//                var identifierName = ResourceModel.ExtractString(item as JsonData, null, "name");
//                if (this.Shape != null)
//                {
//                    var member = this.Shape.Members.SingleOrDefault(m => m.PropertyName == identifierName);
//                    if (member != null)
//                    {
//                        identifiers.Add(identifierName, member.DetermineType());
//                        continue;
//                    }
//                }

//                identifiers.Add(identifierName, "string");
//            }
//        }

//        public string IdentifiersAsParameters
//        {
//            get
//            {
//                StringBuilder parameters = new StringBuilder();
//                foreach (var item in this.Identifiers)
//                {
//                    parameters.AppendFormat("{0} {1}, ", item.Value, item.Key.ToCamelCase());                   
//                }
//                return parameters.ToString();
//            }
//        }

//        public string Name { get; private set; }

//        public Shape Shape { get; private set; }
//    }

//    public class ResourceAction
//    {
//        JsonData _data;
//        ResourceModel _resourceModel;
//        ServiceModel _serviceModel;

//        public ResourceAction(string name, JsonData data, ResourceModel model)
//        {
//            Name = name;
//            _data = data;
//            _resourceModel = model;
//            _serviceModel = model.ServiceModel;

//            this.Operation = 
//                _serviceModel.FindOperation(this.RequestOperation);

//        }
        
//        public string Name { get; set; }

//        public string ReturnType
//        {
//            get
//            {
//                var type = ResourceModel.Extract(_data, ResourceModel.ResourceKey, ResourceModel.TypeKey);
//                if (type != null && type.IsString)
//                    return type.ToString();

//                var path = ResourceModel.ExtractString(_data, null, ResourceModel.PathKey);
                
//                // TODO: This assumes a single element path for now. Simplest JMESPath evar.
//                if (!string.IsNullOrEmpty(path))
//                {
//                    var operation = _resourceModel.ServiceModel.FindOperation(RequestOperation);
//                    if (operation != null)
//                    {
//                        var member = operation.ResponseStructure.Members.Where(m => m.PropertyName.Equals(path)).FirstOrDefault();
//                        if (member != null)
//                        {
//                            return member.DetermineType();
//                        }
//                    }
//                }

//                return "void";
//            }
//        }

//        // If the return type of the action on a service is a resource, return the interface for the resource.
//        public string ReturnTypeInterface
//        {
//            get
//            {
//                if (_resourceModel.FindResource(ReturnType) != null)
//                    return "I" + ReturnType;
//                return ReturnType;
//            }
//        }

//        public string RequestOperation 
//        {
//            get
//            {
//                return ResourceModel.ExtractString(_data, "", ResourceModel.RequestKey, ResourceModel.OperationKey);
//            }
//        }
//        public string Path
//        {
//            get
//            {
//                return ResourceModel.ExtractString(_data, null, ResourceModel.PathKey);
//            }
//        }

//        public bool DoesResponseMapToResource
//        {
//            get { return this.Path != null; }
//        }


//        public Operation Operation { get; private set; }
//    }

//    public static class StringExtensions
//    {
//        public static string ToCamelCase(this string s)
//        {
//            var txt = s[0].ToString().ToLower();
//            if (s.Length > 1)
//                txt += s.Substring(1);
//            return txt;
//        }
//    }

    
//}
