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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IdentityManagement.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.IdentityManagement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListServiceSpecificCredentials Request Marshaller
    /// </summary>       
    public class ListServiceSpecificCredentialsRequestMarshaller : IMarshaller<IRequest, ListServiceSpecificCredentialsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListServiceSpecificCredentialsRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListServiceSpecificCredentialsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IdentityManagement");
            request.Parameters.Add("Action", "ListServiceSpecificCredentials");
            request.Parameters.Add("Version", "2010-05-08");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAllUsers())
                {
                    request.Parameters.Add("AllUsers", StringUtils.FromBool(publicRequest.AllUsers));
                }
                if(publicRequest.IsSetMarker())
                {
                    request.Parameters.Add("Marker", StringUtils.FromString(publicRequest.Marker));
                }
                if(publicRequest.IsSetMaxItems())
                {
                    request.Parameters.Add("MaxItems", StringUtils.FromInt(publicRequest.MaxItems));
                }
                if(publicRequest.IsSetServiceName())
                {
                    request.Parameters.Add("ServiceName", StringUtils.FromString(publicRequest.ServiceName));
                }
                if(publicRequest.IsSetUserName())
                {
                    request.Parameters.Add("UserName", StringUtils.FromString(publicRequest.UserName));
                }
            }
            return request;
        }
                    private static ListServiceSpecificCredentialsRequestMarshaller _instance = new ListServiceSpecificCredentialsRequestMarshaller();        

        internal static ListServiceSpecificCredentialsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListServiceSpecificCredentialsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}