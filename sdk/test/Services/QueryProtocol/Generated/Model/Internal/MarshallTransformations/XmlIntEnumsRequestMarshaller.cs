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
 * Do not modify this file. This file is generated from the query-protocol-2020-01-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QueryProtocol.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.QueryProtocol.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// XmlIntEnums Request Marshaller
    /// </summary>       
    public class XmlIntEnumsRequestMarshaller : IMarshaller<IRequest, XmlIntEnumsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((XmlIntEnumsRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(XmlIntEnumsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.QueryProtocol");
            request.Parameters.Add("Action", "XmlIntEnums");
            request.Parameters.Add("Version", "2020-01-08");

            if(publicRequest != null)
            {
            }
            return request;
        }
                    private static XmlIntEnumsRequestMarshaller _instance = new XmlIntEnumsRequestMarshaller();        

        internal static XmlIntEnumsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static XmlIntEnumsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}