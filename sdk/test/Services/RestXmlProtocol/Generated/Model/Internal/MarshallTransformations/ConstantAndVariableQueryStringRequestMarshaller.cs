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
    /// ConstantAndVariableQueryString Request Marshaller
    /// </summary>       
    public class ConstantAndVariableQueryStringRequestMarshaller : IMarshaller<IRequest, ConstantAndVariableQueryStringRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ConstantAndVariableQueryStringRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ConstantAndVariableQueryStringRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.RestXmlProtocol");
            request.HttpMethod = "GET";
            request.AddSubResource("foo", "bar");
            
            if (publicRequest.IsSetBaz())
                request.Parameters.Add("baz", StringUtils.FromString(publicRequest.Baz));
            
            if (publicRequest.IsSetMaybeSet())
                request.Parameters.Add("maybeSet", StringUtils.FromString(publicRequest.MaybeSet));
            request.ResourcePath = "/ConstantAndVariableQueryString";


            request.UseQueryString = true;
            return request;
        }
        private static ConstantAndVariableQueryStringRequestMarshaller _instance = new ConstantAndVariableQueryStringRequestMarshaller();        

        internal static ConstantAndVariableQueryStringRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ConstantAndVariableQueryStringRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }    
}