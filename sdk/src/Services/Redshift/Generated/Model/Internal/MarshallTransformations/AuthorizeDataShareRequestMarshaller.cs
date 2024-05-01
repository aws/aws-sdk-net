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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Redshift.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Redshift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AuthorizeDataShare Request Marshaller
    /// </summary>       
    public class AuthorizeDataShareRequestMarshaller : IMarshaller<IRequest, AuthorizeDataShareRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((AuthorizeDataShareRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(AuthorizeDataShareRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Redshift");
            request.Parameters.Add("Action", "AuthorizeDataShare");
            request.Parameters.Add("Version", "2012-12-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAllowWrites())
                {
                    request.Parameters.Add("AllowWrites", StringUtils.FromBool(publicRequest.AllowWrites));
                }
                if(publicRequest.IsSetConsumerIdentifier())
                {
                    request.Parameters.Add("ConsumerIdentifier", StringUtils.FromString(publicRequest.ConsumerIdentifier));
                }
                if(publicRequest.IsSetDataShareArn())
                {
                    request.Parameters.Add("DataShareArn", StringUtils.FromString(publicRequest.DataShareArn));
                }
            }
            return request;
        }
                    private static AuthorizeDataShareRequestMarshaller _instance = new AuthorizeDataShareRequestMarshaller();        

        internal static AuthorizeDataShareRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AuthorizeDataShareRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}