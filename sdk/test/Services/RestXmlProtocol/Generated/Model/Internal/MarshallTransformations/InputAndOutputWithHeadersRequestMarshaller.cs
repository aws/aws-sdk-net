/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the rest-xml-protocol-2019-12-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.RestXmlProtocol.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Xml;

#pragma warning disable CS0612,CS0618
namespace Amazon.RestXmlProtocol.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// InputAndOutputWithHeaders Request Marshaller
    /// </summary>       
    public partial class InputAndOutputWithHeadersRequestMarshaller : IMarshaller<IRequest, InputAndOutputWithHeadersRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((InputAndOutputWithHeadersRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(InputAndOutputWithHeadersRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.RestXmlProtocol");
            request.HttpMethod = "POST";
        
            if (publicRequest.IsSetHeaderBooleanList()) 
            {
                        request.Headers["X-BooleanList"] = StringUtils.FromValueTypeList(publicRequest.HeaderBooleanList);
            }
        
            if (publicRequest.IsSetHeaderByte()) 
            {
                request.Headers["X-Byte"] = StringUtils.FromInt(publicRequest.HeaderByte);
            }
        
            if (publicRequest.IsSetHeaderDouble()) 
            {
                request.Headers["X-Double"] = StringUtils.FromDouble(publicRequest.HeaderDouble);
            }
        
            if (publicRequest.IsSetHeaderEnum()) 
            {
                request.Headers["X-Enum"] = publicRequest.HeaderEnum;
            }
        
            if (publicRequest.IsSetHeaderEnumList()) 
            {
                        request.Headers["X-EnumList"] = StringUtils.FromList(publicRequest.HeaderEnumList);
            }
        
            if (publicRequest.IsSetHeaderFalseBool()) 
            {
                request.Headers["X-Boolean2"] = StringUtils.FromBool(publicRequest.HeaderFalseBool);
            }
        
            if (publicRequest.IsSetHeaderFloat()) 
            {
                request.Headers["X-Float"] = StringUtils.FromFloat(publicRequest.HeaderFloat);
            }
        
            if (publicRequest.IsSetHeaderInteger()) 
            {
                request.Headers["X-Integer"] = StringUtils.FromInt(publicRequest.HeaderInteger);
            }
        
            if (publicRequest.IsSetHeaderIntegerList()) 
            {
                        request.Headers["X-IntegerList"] = StringUtils.FromValueTypeList(publicRequest.HeaderIntegerList);
            }
        
            if (publicRequest.IsSetHeaderLong()) 
            {
                request.Headers["X-Long"] = StringUtils.FromLong(publicRequest.HeaderLong);
            }
        
            if (publicRequest.IsSetHeaderShort()) 
            {
                request.Headers["X-Short"] = StringUtils.FromInt(publicRequest.HeaderShort);
            }
        
            if (publicRequest.IsSetHeaderString()) 
            {
                request.Headers["X-String"] = publicRequest.HeaderString;
            }
        
            if (publicRequest.IsSetHeaderStringList()) 
            {
                        request.Headers["X-StringList"] = StringUtils.FromList(publicRequest.HeaderStringList);
            }
        
            if (publicRequest.IsSetHeaderStringSet()) 
            {
                        request.Headers["X-StringSet"] = StringUtils.FromList(publicRequest.HeaderStringSet);
            }
        
            if (publicRequest.IsSetHeaderTimestampList()) 
            {
                        request.Headers["X-TimestampList"] = StringUtils.FromValueTypeList(publicRequest.HeaderTimestampList);
            }
        
            if (publicRequest.IsSetHeaderTrueBool()) 
            {
                request.Headers["X-Boolean1"] = StringUtils.FromBool(publicRequest.HeaderTrueBool);
            }
            request.ResourcePath = "/InputAndOutputWithHeaders";


            PostMarshallCustomization(request, publicRequest);
            return request;
        }
        private static InputAndOutputWithHeadersRequestMarshaller _instance = new InputAndOutputWithHeadersRequestMarshaller();        

        internal static InputAndOutputWithHeadersRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InputAndOutputWithHeadersRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, InputAndOutputWithHeadersRequest publicRequest);
    }    
}