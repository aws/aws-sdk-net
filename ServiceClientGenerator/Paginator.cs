using Json.LitJson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceClientGenerator
{
    public class Paginator
    {
        public const string
            PaginationKey  = "pagination",
            InputTokenKey  = "input_token",
            OutputTokenKey = "output_token",
            MoreResultsKey = "more_results",
            LimitKeyKey    = "limit_key",
            ResultKeyKey   = "result_key";

        ServiceModel _model;
        ///// <summary>
        ///// Create a new instance of a Paginator configuration for an operation given the JsonData
        ///// </summary>
        ///// <param name="operationName">The name of the operation to paginate</param>
        ///// <param name="data">the JSON paginator configuration</param>
        //public Paginator (Operation operation, JsonData data)
        //{
        //    this.Operation = operation;
        //    ParseConfig(data);
        //}

        public Paginator(string operationName, JsonData data, ServiceModel model)
        {
            _model = model;

            var modifiers = model.Customizations.GetOperationModifiers(operationName);
            var modifiedName = operationName;
            if (modifiers != null && !string.IsNullOrEmpty(modifiers.Name))
                modifiedName = modifiers.Name;

            this.Operation = model.FindOperation(modifiedName);
            ParseConfig(data);
        }

        /// <summary>
        /// Read all the Paginators from the paginators JSON
        /// </summary>
        /// <param name="data">The complete paginators config for a service</param>
        /// <returns></returns>
        public static IList<Paginator> ReadPaginators(JsonData data, ServiceModel model)
        {
            var list = new List<Paginator>();

            if (null == data)
                return list;

            var pagination = data[PaginationKey];

            if (pagination != null && pagination.IsObject)
            {
                list = pagination.PropertyNames
                    .Select( k => new Paginator(k, pagination[k], model) )
                    .Where( p => !p.IsExcluded )
                    .OrderBy( p => p.OperationName )
                    .ToList();
            }

            return list;
        }

        static string CustomizedOperationName(string name, ServiceModel model)
        {
            var modifiers = model.Customizations.GetOperationModifiers(name);
            if (modifiers != null && !string.IsNullOrEmpty(modifiers.Name))
                return modifiers.Name;

            return name;
        }

        public Operation Operation { get; set; }

        /// <summary>
        /// The name of the service operation this paginator is for
        /// </summary>
        public string OperationName
        {
            get
            {
                return Operation.Name;
            }
        }

        /// <summary>
        /// The page marker(s) on the request for the next page 
        /// </summary>
        public List<string> InputToken { get; set; }

        /// <summary>
        /// The page marker(s) on the response for the next page
        /// </summary>
        public List<string> OutputToken { get; set; }

        /// <summary>
        /// True if the output token list describes multiple locations for a single marker.
        /// </summary>
        /// <remarks>
        /// Output token can either be a list of markers all of which need to be set,
        /// (such as KeyMarker and VersionIdMarker) or a list of possible places 
        /// (seprated by "||" in the JSON configuration) to look for a single token.
        /// </remarks>
        public bool IsOutputTokenExclusive { get; set; }

        /// <summary>
        /// The response property which says if there are more results
        /// </summary>
        public string MoreResults { get; set; }

        /// <summary>
        /// The property on requests to set the page size
        /// </summary>
        public string LimitKey { get; set; }

        /// <summary>
        /// The Property on the response that contains the page data
        /// </summary>
        public string ResultKey { get; set; }

        /// <summary>
        /// Whether the corresponding operation is excluded by customizations, 
        /// or otherwise should not be included in the paginators.
        /// </summary>
        /// <remarks>
        /// Some pagination models include items for the CLI which don't actually describe paginators.
        /// </remarks>
        /// <returns>True if a paginator should be NOT emitted for this operation</returns>
        public bool IsExcluded
        {
            get
            {
                return null == InputToken || null == OutputToken || Operation.IsExcluded;
            }
        }

        public string EnumerableMemberType
        {
            get
            {
                return _model.FindOperation(OperationName).ResponseStructure.Members
                    .Where(x => x.PropertyName == ResultKey)
                    .Select(x => x.DetermineListMemberType()).First();
            }
        }

        public string FormatMoreResultsTest()
        {
            if (this.MoreResults != null)
            {
                return String.Format("return this.{0};", this.MoreResults);
            }
            else if (this.OutputToken != null && this.OutputToken.Count == 1)
            {
                return String.Format("return !String.IsNullOrEmpty(this.{0});", this.OutputToken.First());
            }
            return "return false;";
        }

        string FindRequestPropertyName(string token)
        {
            var emit = this.Operation.RequestStructure.Members.Where(m => m.MarshallName.Equals(token)).FirstOrDefault();
            return emit != null ? emit.PropertyName : token;
        }

        void ParseConfig(JsonData data)
        {
            if (data[InputTokenKey] != null)
            {
                if (data[InputTokenKey].IsArray)
                {
                    var tokens = new List<string>();
                    for (var i = 0; i < data[InputTokenKey].Count; i++)
                    {
                        tokens.Add(FindRequestPropertyName(data[InputTokenKey][i].ToString()));
                    }
                    this.InputToken = tokens;
                }
                else
                {
                    this.InputToken = new List<string> { FindRequestPropertyName(data[InputTokenKey].ToString()) };
                }
            }

            if (data[OutputTokenKey] != null)
            {
                if (data[OutputTokenKey].IsArray)
                {
                    var tokens = new List<string>();
                    for (var i = 0; i < data[OutputTokenKey].Count; i++)
                    {
                        tokens.Add(data[OutputTokenKey][i].ToString());
                    }
                    this.OutputToken = tokens;
                }
                else
                {
                    var token = data[OutputTokenKey].ToString();
                    if (token.Contains("||"))
                    {
                        this.OutputToken = token.Split(new string[] { "||" }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(x => x.Trim()).ToList();
                        this.IsOutputTokenExclusive = true;
                    }
                    else
                        this.OutputToken = new List<string> { token };
                }
            }
            
            this.MoreResults = data[MoreResultsKey] == null ? null : data[MoreResultsKey].ToString();
            this.LimitKey = data[LimitKeyKey] == null ? null : data[LimitKeyKey].ToString();
            this.ResultKey = data[ResultKeyKey] == null ? null : data[ResultKeyKey].ToString();
        }
    }
}
