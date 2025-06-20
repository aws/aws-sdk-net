﻿// ------------------------------------------------------------------------------
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
    
    #line 1 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public partial class JsonRPCRequestMarshaller : JsonRPCStructureMarshaller
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 6 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"

	AddLicenseHeader();

	AddCommonUsingStatements();

            
            #line default
            #line hidden
            this.Write("using System.Text.Json;\r\nusing System.Buffers;\r\n#if !NETFRAMEWORK\r\nusing ThirdPar" +
                    "ty.RuntimeBackports;\r\n#endif\r\n#pragma warning disable CS0612,CS0618\r\nnamespace ");
            
            #line 17 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write(".Model.Internal.MarshallTransformations\r\n{\r\n\t/// <summary>\r\n\t/// ");
            
            #line 20 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Operation.Name));
            
            #line default
            #line hidden
            this.Write(" Request Marshaller\r\n\t/// </summary>       \r\n\tpublic class ");
            
            #line 22 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Operation.Name));
            
            #line default
            #line hidden
            this.Write("RequestMarshaller : IMarshaller<IRequest, ");
            
            #line 22 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Operation.Name));
            
            #line default
            #line hidden
            this.Write(@"Request> , IMarshaller<IRequest,AmazonWebServiceRequest>
	{
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name=""input""></param>
        /// <returns></returns>
		public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((");
            
            #line 31 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Operation.Name));
            
            #line default
            #line hidden
            this.Write("Request)input);\r\n        }\r\n\r\n        /// <summary>\r\n        /// Marshaller the r" +
                    "equest object to the HTTP request.\r\n        /// </summary>  \r\n        /// <param" +
                    " name=\"publicRequest\"></param>\r\n        /// <returns></returns>\r\n\t\tpublic IReque" +
                    "st Marshall(");
            
            #line 39 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Operation.Name));
            
            #line default
            #line hidden
            this.Write("Request publicRequest)\r\n\t\t{\r\n\t\t\tIRequest request = new DefaultRequest(publicReque" +
                    "st, \"");
            
            #line 41 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write("\");\r\n");
            
            #line 42 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"

	if ((this.Config.ServiceModel.H2Support == H2SupportDegree.Optional && this.Operation.IsEventStreamBidi) || (this.Config.ServiceModel.H2Support == H2SupportDegree.EventStream && this.Operation.IsEventStreamOutput) || this.Config.ServiceModel.H2Support == H2SupportDegree.Required)
	{

            
            #line default
            #line hidden
            this.Write("#if NET8_0_OR_GREATER\r\n            request.HttpProtocolVersion = System.Net.HttpV" +
                    "ersion.Version20;\r\n#endif\r\n");
            
            #line 49 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"

	}
	if (this.Operation.IsEventStreamInput)
	{
		var eventStreamMember = this.Operation.RequestEventStreamingMember;

            
            #line default
            #line hidden
            this.Write("            request.Headers[\"Content-Type\"] = \"application/vnd.amazon.eventstream" +
                    "\";\r\n            request.EventStreamPublisher = new ");
            
            #line 56 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(eventStreamMember.Shape.Name));
            
            #line default
            #line hidden
            this.Write("PublisherMarshaller(publicRequest.");
            
            #line 56 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(eventStreamMember.PropertyName));
            
            #line default
            #line hidden
            this.Write(");\r\n\r\n");
            
            #line 58 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"

	}

   SetCompressionAlgorithmEncoding(this.Operation);

   if (!string.IsNullOrEmpty(this.Config.ServiceModel.TargetPrefix))
	{

            
            #line default
            #line hidden
            this.Write("\t\t\tstring target = \"");
            
            #line 66 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ServiceModel.TargetPrefix));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 66 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Operation.Name));
            
            #line default
            #line hidden
            this.Write("\";\r\n\t\t\trequest.Headers[\"X-Amz-Target\"] = target;\r\n");
            
            #line 68 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"

	}

	var payload = this.Operation.RequestPayloadMember;
	if (this.Operation.HttpMethod != "GET" && this.Operation.HttpMethod != "DELETE")
	{

		if (this.Config.ServiceModel.Customizations.OverrideContentType != null)
		{

            
            #line default
            #line hidden
            this.Write("\t\t\trequest.Headers[\"Content-Type\"] = \"");
            
            #line 78 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ServiceModel.Customizations.OverrideContentType));
            
            #line default
            #line hidden
            this.Write("\";\r\n");
            
            #line 79 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"

		}
		else if (this.Config.ServiceModel.Type != ServiceType.Rest_Json)
		{

            
            #line default
            #line hidden
            this.Write("\t\t\trequest.Headers[\"Content-Type\"] = \"application/x-amz-json-");
            
            #line 84 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ServiceModel.JsonVersion));
            
            #line default
            #line hidden
            this.Write("\";\r\n");
            
            #line 85 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"

		}
		else if (payload?.Shape.IsString == true)
		{

            
            #line default
            #line hidden
            this.Write("\t\t\trequest.Headers[\"Content-Type\"] = \"text/plain\";\r\n");
            
            #line 91 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"

		}
		else if (this.Operation.RequestHasBodyMembers || this.Operation.RequestPayloadMember != null)
		{

            
            #line default
            #line hidden
            this.Write("\t\t\trequest.Headers[\"Content-Type\"] = \"application/json\";\r\n");
            
            #line 97 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"

		}
	}

            
            #line default
            #line hidden
            this.Write("            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = \"");
            
            #line 101 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ServiceModel.APIVersion));
            
            #line default
            #line hidden
            this.Write("\";\r\n            request.HttpMethod = \"");
            
            #line 102 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Operation.HttpMethod));
            
            #line default
            #line hidden
            this.Write("\";\r\n\r\n");
            
            #line 104 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"

	if (this.Config.ServiceModel.IsAwsQueryCompatible)
	{

            
            #line default
            #line hidden
            this.Write("\t\t\trequest.Headers[Amazon.Util.HeaderKeys.XAmzQueryMode] = \"true\";\r\n");
            
            #line 109 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"

	}
	var requestStructure = this.Operation.RequestStructure;
	
    // Generates code to add members of the request to the request being created by the marshaller
	ProcessRequestUri(this.Operation);

	if (this.Config.ServiceModel.Type == ServiceType.Rest_Json)
	{
		ProcessUriMembers("publicRequest", this.Operation);
		ProcessQueryStringMembers("publicRequest", this.Operation);
	}

            
            #line default
            #line hidden
            this.Write("\t\t\trequest.ResourcePath = \"");
            
            #line 122 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Operation.RequestUri));
            
            #line default
            #line hidden
            this.Write("\";\r\n");
            
            #line 123 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"
  

    var shouldMarshallPayload = (payload != null && !payload.IsMemoryStream && !payload.Shape.IsString && !payload.Shape.IsEventStream);
	// Process any members which are marshalled as part of the request body
	if (this.Operation.RequestHasBodyMembers || shouldMarshallPayload)
	{

            
            #line default
            #line hidden
            this.Write(@"#if !NETFRAMEWORK
			using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
			using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
			using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
");
            
            #line 137 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"
		
		if (shouldMarshallPayload)
		{

            
            #line default
            #line hidden
            this.Write("\t\t\tvar context = new JsonMarshallerContext(request, writer);\r\n");
            
            #line 142 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"
		
			ProcessStructure(0, "publicRequest." + payload.PropertyName, payload.Shape);

            
            #line default
            #line hidden
            this.Write("\t\t\twriter.Flush();\r\n");
            
            #line 146 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"

		}
		else
		{

            
            #line default
            #line hidden
            this.Write("\t\t\twriter.WriteStartObject();\r\n\t\t\tvar context = new JsonMarshallerContext(request" +
                    ", writer);\r\n");
            
            #line 153 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"
		
			ProcessMembers(0, "publicRequest", this.Operation.RequestBodyMembers);

            
            #line default
            #line hidden
            this.Write("\t\t\twriter.WriteEndObject();\r\n\t\t\twriter.Flush();\r\n");
            
            #line 158 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"

		}

            
            #line default
            #line hidden
            this.Write("\t\t\t// ToArray() must be called here because aspects of sigv4 signing require a by" +
                    "te array\r\n#if !NETFRAMEWORK\r\n\t\t\trequest.Content = arrayPoolBufferWriter.WrittenM" +
                    "emory.ToArray();\r\n#else\r\n\t\t\trequest.Content = memoryStream.ToArray();\r\n#endif\r\n");
            
            #line 167 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"

			GenerateRequestChecksumHandling(this.Operation, "snippet");

            
            #line default
            #line hidden
            this.Write("\t\t\t\r\n\r\n");
            
            #line 171 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"

	}
	else if (payload?.Shape.IsString == true)
	{

            
            #line default
            #line hidden
            this.Write("\t\t\trequest.Content = System.Text.Encoding.UTF8.GetBytes(publicRequest.");
            
            #line 176 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(payload.PropertyName));
            
            #line default
            #line hidden
            this.Write(");\r\n");
            
            #line 177 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"

	}
    else if (payload?.IsMemoryStream == true)
    {

            
            #line default
            #line hidden
            this.Write("\t\t\trequest.ContentStream =  publicRequest.");
            
            #line 182 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(payload.PropertyName));
            
            #line default
            #line hidden
            this.Write(" ?? new MemoryStream();\r\n");
            
            #line 183 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"
		
		var requiresLength = payload.RequiresLength;
		if (!requiresLength && payload.Shape.IsStreaming && this.Operation.AuthType == OperationAuthType.V4UnsignedBody)
		{

            
            #line default
            #line hidden
            this.Write(@"			if (request.ContentStream.CanSeek)
			{
				request.ContentStream.Seek(0, SeekOrigin.Begin);
				request.Headers[Amazon.Util.HeaderKeys.ContentLengthHeader] =  
					request.ContentStream.Length.ToString(CultureInfo.InvariantCulture);
			}
			else
			{
				request.Headers[Amazon.Util.HeaderKeys.TransferEncodingHeader] = ""chunked"";
			}
");
            
            #line 198 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"

		}
		else
		{
			if (payload.Shape.IsStreaming && requiresLength)
			{

            
            #line default
            #line hidden
            this.Write("\t\t\tif (!request.ContentStream.CanSeek)\r\n\t\t\t{\r\n\t\t\t\tthrow new System.InvalidOperati" +
                    "onException(\"Cannot determine stream length for the payload when content-length " +
                    "is required.\");\r\n\t\t\t}\r\n");
            
            #line 209 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"

			}

            
            #line default
            #line hidden
            this.Write("\t\t\tif(request.ContentStream.CanSeek)\r\n\t\t\t{\r\n\t\t\t\trequest.ContentStream.Seek(0, See" +
                    "kOrigin.Begin);\r\n\t\t\t}\r\n\t\t\trequest.Headers[Amazon.Util.HeaderKeys.ContentLengthHe" +
                    "ader] =\r\n\t\t\t\trequest.ContentStream.Length.ToString(CultureInfo.InvariantCulture)" +
                    ";\r\n");
            
            #line 218 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"

		}

            
            #line default
            #line hidden
            this.Write("\t\t\trequest.Headers[Amazon.Util.HeaderKeys.ContentTypeHeader] = \"application/octet" +
                    "-stream\";\r\n");
            
            #line 222 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"

    }
	else if (payload?.Shape.IsPrimitiveType == true)
	{
		// At this point, all valid configurations have been handled.  Valid use of payload is defined:
		// https://awslabs.github.io/smithy/1.0/spec/core/http-traits.html#httppayload-trait
		throw new Exception(
			$"{payload.PropertyName} can not be a Payload as Type {payload.Shape.Type} is not a valid target for the httpPayload trait.  " +
			"The httpPayload trait can be applied to structure members that target a string, blob, structure, union, document, set, map, or list.");
	}
	else if (this.Config.ServiceModel.Type == ServiceType.Json)
	{

            
            #line default
            #line hidden
            this.Write("\t\t\tvar content = \"{}\";\r\n            request.Content = System.Text.Encoding.UTF8.G" +
                    "etBytes(content);\r\n");
            
            #line 237 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"

				GenerateRequestChecksumHandling(this.Operation, "content");

            
            #line default
            #line hidden
            
            #line 240 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"

	}

	if (this.Config.ServiceModel.Type == ServiceType.Rest_Json)
	{
		ProcessHeaderMembers("publicRequest", this.Operation.RequestHeaderMembers);		
	}
	
	if (this.Operation.UnsignedPayload)
	{

            
            #line default
            #line hidden
            this.Write("\t\t\trequest.DisablePayloadSigning = true;\r\n");
            
            #line 252 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"
	}

	// If there aren't any members that are marshalled as part of the body or streamed	
	if (this.Operation.UseQueryString)
	{

            
            #line default
            #line hidden
            this.Write("\t\t\trequest.UseQueryString = true;\r\n");
            
            #line 259 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"
	}

	// We skip endpoint host prefix handling for S3 and S3 Control as it's implemented by endpoint rules.
	if (!string.IsNullOrEmpty(this.Operation.EndpointHostPrefix) && this.Config.ServiceId != "S3" && this.Config.ServiceId != "S3 Control")
	{
		ProcessEndpointHostPrefixMembers(3, "publicRequest", this.Operation);
	}

            
            #line default
            #line hidden
            this.Write("\r\n\t\t\treturn request;\r\n\t\t}\r\n");
            
            #line 270 "C:\Dev\Repos\aws-sdk-net-staging\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCRequestMarshaller.tt"
				
		this.AddRequestSingletonMethod();

            
            #line default
            #line hidden
            this.Write("\t}\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
