// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 17.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ServiceClientGenerator.Generators.Marshallers
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public partial class JsonRPCResponseUnmarshaller : BaseResponseUnmarshaller
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 6 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"

    AddLicenseHeader();

    AddCommonUsingStatements();

            
            #line default
            #line hidden
            this.Write("using ThirdParty.Json.LitJson;\r\n\r\n#pragma warning disable CS0612,CS0618\r\nnamespac" +
                    "e ");
            
            #line 14 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write(".Model.Internal.MarshallTransformations\r\n{\r\n    /// <summary>\r\n    /// Response U" +
                    "nmarshaller for ");
            
            #line 17 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.UnmarshallerBaseName));
            
            #line default
            #line hidden
            this.Write(" operation\r\n    /// </summary>  \r\n    public class ");
            
            #line 19 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.UnmarshallerBaseName));
            
            #line default
            #line hidden
            this.Write(@"ResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name=""context""></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            ");
            
            #line 28 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.UnmarshallerBaseName));
            
            #line default
            #line hidden
            this.Write("Response response = new ");
            
            #line 28 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Operation.Name));
            
            #line default
            #line hidden
            this.Write("Response();\r\n\r\n");
            
            #line 30 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"

    var payload = this.Operation.ResponsePayloadMember;
    var unmarshallPayload = payload != null && payload.IsStructure;
    var payloadIsStream = payload != null && !unmarshallPayload;
    bool isEventStreamOutput = this.Operation.IsEventStreamOutput;
    if (this.Operation.ResponseHasBodyMembers || payload != null)
    {
        if (this.Operation.AllowEmptyResult)
        {
            throw new NotImplementedException("AllowEmptyResult is not implemented for JSON unmarshallers");
        }
        if (isEventStreamOutput)
        {            
            if(payload == null)
            {
               payload = this.Structure.Members.Where(m => m.ModelShape.IsEventStream).FirstOrDefault();
               //if payload is still null after we search for a member that is of eventStream then the operation is not modeled correctly

               if(payload == null)
                    throw new InvalidOperationException("An eventstream operation's response must have at least one member that is marked with the eventStream trait");
            }

            
            #line default
            #line hidden
            this.Write("            response.");
            
            #line 52 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(payload.PropertyName));
            
            #line default
            #line hidden
            this.Write(" = new ");
            
            #line 52 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(payload.Shape.Name));
            
            #line default
            #line hidden
            this.Write("(context.Stream);\r\n");
            
            #line 53 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"

        }
        else if (payloadIsStream)
        {
            if (payload.Shape.IsStreaming)
            {

            
            #line default
            #line hidden
            this.Write("            response.");
            
            #line 60 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(payload.PropertyName));
            
            #line default
            #line hidden
            this.Write(" = context.Stream;\r\n");
            
            #line 61 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"

            }
            else if (payload.ModelShape.IsString)
            {

            
            #line default
            #line hidden
            this.Write("            using (var sr = new StreamReader(context.Stream))\r\n            {\r\n   " +
                    "             response.");
            
            #line 68 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(payload.PropertyName));
            
            #line default
            #line hidden
            this.Write(" = sr.ReadToEnd();\r\n            }\r\n");
            
            #line 70 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"

            }
            else if (payload.ModelShape.IsMemoryStream)
            {

            
            #line default
            #line hidden
            this.Write("            var ms = new MemoryStream();\r\n            Amazon.Util.AWSSDKUtils.Cop" +
                    "yStream(context.Stream, ms);\r\n            ms.Seek(0, SeekOrigin.Begin);\r\n       " +
                    "     response.");
            
            #line 78 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(payload.PropertyName));
            
            #line default
            #line hidden
            this.Write(" = ms;\r\n");
            
            #line 79 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"

            }
            else
            {
                // At this point, all valid configurations have been handled.  Valid use of payload is defined:
                // https://awslabs.github.io/smithy/1.0/spec/core/http-traits.html#httppayload-trait
                throw new Exception(
                    $"{payload.PropertyName} can not be a Payload as Type {payload.Shape.Type} is not a valid target for the httpPayload trait.  " +
                    "The httpPayload trait can be applied to structure members that target a string, blob, structure, union, document, set, map, or list.");
            }
        }
        else if (unmarshallPayload)
        {

            
            #line default
            #line hidden
            this.Write("            var unmarshaller = ");
            
            #line 93 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(payload.DetermineTypeUnmarshallerInstantiate()));
            
            #line default
            #line hidden
            this.Write(";\r\n            response.");
            
            #line 94 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(payload.PropertyName));
            
            #line default
            #line hidden
            this.Write(" = unmarshaller.Unmarshall(context);\r\n");
            
            #line 95 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"

        }
		else if (this.IsWrapped)
		{

            
            #line default
            #line hidden
            this.Write("\t\t\tresponse.");
            
            #line 100 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.WrappedResultMember));
            
            #line default
            #line hidden
            this.Write(" = ");
            
            #line 100 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Structure.Name));
            
            #line default
            #line hidden
            this.Write("Unmarshaller.Instance.Unmarshall(context);\r\n");
            
            #line 101 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"

		}
        else
        {

            
            #line default
            #line hidden
            this.Write("            context.Read();\r\n            int targetDepth = context.CurrentDepth;\r" +
                    "\n            while (context.ReadAtDepth(targetDepth))\r\n            {\r\n");
            
            #line 110 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"

        
            foreach (var member in this.Operation.ResponseBodyMembers)
            {

            
            #line default
            #line hidden
            this.Write("                if (context.TestExpression(\"");
            
            #line 115 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.MarshallName));
            
            #line default
            #line hidden
            this.Write("\", targetDepth))\r\n                {\r\n                    var unmarshaller = ");
            
            #line 117 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.DetermineTypeUnmarshallerInstantiate()));
            
            #line default
            #line hidden
            this.Write(";\r\n                    response.");
            
            #line 118 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));
            
            #line default
            #line hidden
            this.Write(" = unmarshaller.Unmarshall(context);\r\n                    continue;\r\n            " +
                    "    }\r\n");
            
            #line 121 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"

            }

            
            #line default
            #line hidden
            this.Write("            }\r\n");
            
            #line 125 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"

        }
    }
	UnmarshallHeaders();
	ProcessStatusCode();

            
            #line default
            #line hidden
            this.Write(@"
            return response;
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name=""context""></param>
        /// <param name=""innerException""></param>
        /// <param name=""statusCode""></param>
        /// <returns></returns>
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            var errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
");
            
            #line 151 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"

            if  (this.Config.ServiceModel.IsAwsQueryCompatible)
            {

            
            #line default
            #line hidden
            
            #line 155 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"
 // Create a copy of context with headers in the response 
            
            #line default
            #line hidden
            this.Write("\r\n            using (var contextCopy = new JsonUnmarshallerContext(streamCopy, tr" +
                    "ue, context.ResponseData))\r\n");
            
            #line 158 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"

            }
            else
            {

            
            #line default
            #line hidden
            this.Write("            using (var contextCopy = new JsonUnmarshallerContext(streamCopy, fals" +
                    "e, null))\r\n");
            
            #line 164 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"

            }

            
            #line default
            #line hidden
            this.Write("            {\r\n");
            
            #line 168 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"

    foreach (var exception in this.Operation.Exceptions)
    {

            
            #line default
            #line hidden
            this.Write("                if (errorResponse.Code != null && errorResponse.Code.Equals(\"");
            
            #line 172 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(exception.Code));
            
            #line default
            #line hidden
            this.Write("\"))\r\n                {\r\n                    return ");
            
            #line 174 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(exception.Name));
            
            #line default
            #line hidden
            this.Write("Unmarshaller.Instance.Unmarshall(contextCopy, errorResponse);\r\n                }\r" +
                    "\n");
            
            #line 176 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"

    }

            
            #line default
            #line hidden
            this.Write("            }\r\n");
            
            #line 180 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"

            if  (this.Config.ServiceModel.IsAwsQueryCompatible)
            {
                GenerateAWSQueryCompatibleBlock();

            
            #line default
            #line hidden
            this.Write("            return new ");
            
            #line 185 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.BaseException));
            
            #line default
            #line hidden
            this.Write("(errorResponse.Message, errorResponse.InnerException, errorType, errorCode, error" +
                    "Response.RequestId, errorResponse.StatusCode);\r\n");
            
            #line 186 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"

            }
            else
            {

            
            #line default
            #line hidden
            this.Write("            return new ");
            
            #line 191 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.BaseException));
            
            #line default
            #line hidden
            this.Write("(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorRe" +
                    "sponse.Code, errorResponse.RequestId, errorResponse.StatusCode);\r\n");
            
            #line 192 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"

            }

            
            #line default
            #line hidden
            this.Write("        }\r\n\r\n");
            
            #line 197 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"

    if (payload != null && payload.Shape.IsStreaming)
    {

            
            #line default
            #line hidden
            this.Write(@"        /// <summary>
        /// Overriden to return true indicating the response contains streaming data.
        /// </summary>
        public override bool HasStreamingProperty
        {
            get
            {
                return true;
            }
        }

");
            
            #line 212 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"

	}
    this.AddResponseSingletonMethod();

            
            #line default
            #line hidden
            
            #line 216 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"

    if(isEventStreamOutput)
    {

            
            #line default
            #line hidden
            this.Write(@"        /// <summary>
        /// Return false for reading the entire response
        /// </summary>
        /// <param name=""response""></param>
        /// <param name=""readEntireResponse""></param>
        /// <returns></returns>
        protected override bool ShouldReadEntireResponse(IWebResponseData response, bool readEntireResponse)
        {
            return false;
        }
        /// <summary>
        /// Specifies that the response should be streamed
        /// </summary>
        public override bool HasStreamingProperty => true;
");
            
            #line 234 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCResponseUnmarshaller.tt"

    }

            
            #line default
            #line hidden
            this.Write("    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
