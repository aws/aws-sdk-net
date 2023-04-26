using Json.LitJson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceClientGenerator
{
    public class OperationPaginatorConfig
    {
        private readonly JsonData data;
        private readonly Operation operation;

        /// <summary>
        /// The name of the operation
        /// </summary>
        public string Name { get; }

        private IList<OperationPaginatorConfigOption> _resultKeys;

        /// <summary>
        /// Result keys are the values in the response which
        /// can be enumerated on
        /// </summary>
        public IList<OperationPaginatorConfigOption> ResultKeys
        {
            get
            {
                if (this._resultKeys == null)
                {
                    this._resultKeys = CreatePaginatorConfigOptionList(data[ServiceModel.ResultKeyKey], false, 'o');
                }
                return this._resultKeys;
            }
        }

        private IList<OperationPaginatorConfigOption> _inputTokens;

        /// <summary>
        /// The token in the request specifying where to start
        /// receiving data
        /// </summary>
        public IList<OperationPaginatorConfigOption> InputTokens { 
            get
            {
                if (this._inputTokens == null)
                {
                    this._inputTokens = InitializeInputTokens();
                }
                return this._inputTokens;
            }
        }

        private IList<OperationPaginatorConfigOption> _outputTokens;

        /// <summary>
        /// The token in the response to use in the subsequent request
        /// to specify where to start receiving data
        /// </summary>
        public IList<OperationPaginatorConfigOption> OutputTokens { 
            get
            {
                if (this._outputTokens == null)
                {
                    this._outputTokens = InitializeOutputTokens();
                }
                return this._outputTokens;
            }
        }

        private OperationPaginatorConfigOption _moreResults;

        /// <summary>
        /// Whether or not the response is truncated
        /// </summary>
        public OperationPaginatorConfigOption MoreResults
        {
            get
            {
                if (this._moreResults == null)
                {
                    this._moreResults = GetOperationPaginatorConfigOption(data[ServiceModel.MoreResultsKey], false);
                }
                return this._moreResults;
            }
        }

        private OperationPaginatorConfigOption _limitKey;

        /// <summary>
        /// The key specifying the number of results per
        /// request
        /// </summary>
        public OperationPaginatorConfigOption LimitKey
        {
            get
            {
                if (this._limitKey == null)
                {
                    this._limitKey = GetOperationPaginatorConfigOption(data[ServiceModel.LimitKeyKey]);
                }
                return this._limitKey;
            }
        }

        /// <summary>
        /// Return an OperationPaginatorConfigOption object for the paginator option.
        /// This contains the Member associated with the option. Also, it adjusts the 
        /// name if it is a jmespath expression.
        /// </summary>
        /// <param name="node"> The JsonData node provided in the paginator config </param>
        /// <param name="checkRequest"> Check the request object for a member matching the node </param>
        /// <param name="checkResponse"> Check the response object for a member matching the node </param>
        /// <param name="checkQuery"> Check the query object for a member matching the node </param>
        /// <returns></returns>
        internal OperationPaginatorConfigOption GetOperationPaginatorConfigOption(JsonData node,
            bool checkRequest = true, bool checkResponse = true)
        {
            Member configOption = null;
            var foundOptionInResponse = false;
            if (node == null)
            {
                return null;
            }
            if (IsJmesPath(node, out var jmesPathChar))
            {
                return HandleJmesPath(node, (char) jmesPathChar, operation);

            }
            if (checkRequest)
            {
                configOption = CheckRequestForNode(m => m.ModeledName.Equals(node.ToString()));
            }
            if (checkResponse && configOption == null)
            {
                configOption = CheckResponseForNode(m => m.ModeledName.Equals(node.ToString()) || m.MarshallName.Equals(node.ToString()));
                // foundOptionInResponse is used for wrapped result members which need to be
                // handled differently for the SWF service.
                foundOptionInResponse = configOption != null;
            }
            if (configOption == null)
            {
                return null;
            }
            if (this.operation.UseWrappingResult && foundOptionInResponse)
            {
                return new OperationPaginatorConfigOption(false, 
                    this.operation.OperationModifiers.WrappedResultMember, configOption);
            }
            return new OperationPaginatorConfigOption(false, configOption);
        }

        /// <summary>
        /// Check all parts of request for node to find the corresponding
        /// member
        /// </summary>
        /// <param name="checkFunction">Function to search all members for node</param>
        /// <returns></returns>
        internal Member CheckRequestForNode(Func<Member, bool> checkFunction)
        {
            Member configOption = null;
            if (operation.RequestHasBodyMembers)
            {
                configOption = operation.RequestBodyMembers.SingleOrDefault(checkFunction);
            }
            if (operation.RequestHasUriMembers && configOption == null)
            {
                configOption = operation.RequestUriMembers.SingleOrDefault(checkFunction);
            }
            if (operation.RequestHasQueryStringMembers && configOption == null)
            {
                configOption = operation.RequestQueryStringMembers.SingleOrDefault(checkFunction);
            }
            if (operation.RequestHasHeaderMembers && configOption == null)
            {
                configOption = operation.RequestHeaderMembers.SingleOrDefault(checkFunction);
            }
            return configOption;
        }

        /// <summary>
        /// Check all parts of response for node to find the corresponding
        /// member
        /// </summary>
        /// <param name="checkFunction">Function to search all members for node</param>
        /// <returns></returns>
        internal Member CheckResponseForNode(Func<Member, bool> checkFunction)
        {
            Member configOption = null;
            if (operation.ResponseHasBodyMembers && configOption == null)
            {
                configOption = operation.ResponseBodyMembers.SingleOrDefault(checkFunction);
            }
            if (operation.ResponseHasHeaderMembers && configOption == null)
            {
                configOption = operation.ResponseHeaderMembers.SingleOrDefault(checkFunction);
            }
            return configOption;
        }

        /// <summary>
        /// Check if a paginator option is a jmespath expression.
        /// Currently support only '.'
        /// </summary>
        /// <param name="node"> The JsonData node provided in the paginator config </param>
        /// <param name="jmesPathChar"> The character which is contained in the jmespath expression 
        /// (currently only supports '.') </param>
        /// <returns></returns>
        internal static bool IsJmesPath(JsonData node, out char? jmesPathChar)
        {
            var stringNode = node.ToString();
            string jPattern = "^[a-zA-Z0-9]+\\.[a-zA-Z0-9]+(\\.[a-zA-Z0-9]+)*$";
            if (System.Text.RegularExpressions.Regex.IsMatch(stringNode, jPattern))
            {
                jmesPathChar = '.';
                return true;
            }
            jmesPathChar = null;
            return false;
        }

        /// <summary>
        /// Handle a jmespath expression for a paginator option. Currently
        /// only supporting '.'
        /// </summary>
        /// <param name="node"> The JsonData node provided in the paginator config </param>
        /// <param name="jmesPathChar"> The character which is contained in the jmespath expression 
        /// (currently only supports '.') </param>
        /// <returns></returns>
        internal static OperationPaginatorConfigOption HandleJmesPath(JsonData node, char jmesPathChar, Operation operation)
        {
            if (jmesPathChar == '.')
            {
                var nestedMembers = node.ToString().Split('.');
                var currentShape = operation.ResponseStructure;
                Member currentMember = null;
                var codePath = new StringBuilder();
                for(int i = 0; i < nestedMembers.Length; i++)
                {
                    currentMember = currentShape.Members.FirstOrDefault(x => string.Equals(x.ModeledName, nestedMembers[i]));
                    if (currentMember == null)
                    {
                        return null;
                    }

                    if(codePath.Length > 0)
                    {
                        codePath.Append('.');
                    }
                    codePath.Append(currentMember.PropertyName);

                    currentShape = currentMember.Shape;
                    if (currentShape == null)
                    {
                        return null;
                    }
                }

                return new OperationPaginatorConfigOption(true, currentMember, $"{codePath}");
            }
            return null;
        }

        /// <summary>
        /// Only initialize the input token and the output token
        /// because they are mandatory. If they are not configured 
        /// properly, set operation.UnsupportedPaginatorConfig to true
        /// </summary>
        internal void InitializeOperationPaginatorConfig()
        {
            this._inputTokens = InitializeInputTokens();
            this._outputTokens = InitializeOutputTokens();
            if (this.InputTokens.Count != this.OutputTokens.Count)
            {
                this.operation.UnsupportedPaginatorConfig = true;
            }
        }

        /// <summary>
        /// Return a list of all input tokens as OperationPaginatorConfigOptions
        /// </summary>
        /// <returns></returns>
        internal IList<OperationPaginatorConfigOption> InitializeInputTokens()
        {
            return CreatePaginatorConfigOptionList(data[ServiceModel.InputTokenKey], true, 'i');
        }

        /// <summary>
        /// Return a list of all output tokens as OperationPaginatorConfigOptions
        /// </summary>
        /// <returns></returns>
        internal IList<OperationPaginatorConfigOption> InitializeOutputTokens()
        {
            return CreatePaginatorConfigOptionList(data[ServiceModel.OutputTokenKey], true, 'o');
        }

        /// <summary>
        /// Create a list of OperationPaginatorConfigOptions based on the data provided
        /// </summary>
        /// <param name="node"> The JsonData node provided in the paginator config </param>
        /// <param name="setUnsupported"> Should the operation's paginator config be valid if there is an 
        /// issue finding a matching member </param>
        /// <param name="mode"> Whether this is input or output token or neither</param>
        /// <returns></returns>
        internal IList<OperationPaginatorConfigOption> CreatePaginatorConfigOptionList(JsonData node, bool setUnsupported = true, 
            char mode = 'n')
        {
            var checkRequest = mode == 'i' || mode == 'n';
            var checkResponse = mode == 'o' || mode == 'n';
            IList<OperationPaginatorConfigOption> optionList = new List<OperationPaginatorConfigOption>();
            if (node == null)
            {
                if (setUnsupported)
                {
                    this.operation.UnsupportedPaginatorConfig = true;
                }
                return optionList;
            }
            else if (node.IsArray)
            {
                for (var i = 0; i < node.Count; i++)
                {
                    var option = GetOperationPaginatorConfigOption(node[i], checkRequest, checkResponse);
                    if (option != null)
                    {
                        optionList.Add(option);
                    }
                    else if (setUnsupported)
                    {
                        this.operation.UnsupportedPaginatorConfig = true;
                    }
                }
            }
            else
            {
                var option = GetOperationPaginatorConfigOption(node, checkRequest, checkResponse);
                if (option != null)
                {
                    optionList.Add(option);
                }
                else if (setUnsupported)
                {
                    this.operation.UnsupportedPaginatorConfig = true;
                }
            }
            return optionList;
        }

        /// <summary>
        /// Create a new OperationPaginatorConfig
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="name"></param>
        /// <param name="data"></param>
        public OperationPaginatorConfig(Operation operation, string name, JsonData data)
        {
            this.operation = operation;
            Name = name;
            this.data = data;
            this.operation.UnsupportedPaginatorConfig = false;
            InitializeOperationPaginatorConfig();
        }
    }
}
