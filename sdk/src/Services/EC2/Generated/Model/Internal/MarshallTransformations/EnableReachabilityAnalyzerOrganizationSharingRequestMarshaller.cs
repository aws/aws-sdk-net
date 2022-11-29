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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EnableReachabilityAnalyzerOrganizationSharing Request Marshaller
    /// </summary>       
    public class EnableReachabilityAnalyzerOrganizationSharingRequestMarshaller : IMarshaller<IRequest, EnableReachabilityAnalyzerOrganizationSharingRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((EnableReachabilityAnalyzerOrganizationSharingRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(EnableReachabilityAnalyzerOrganizationSharingRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "EnableReachabilityAnalyzerOrganizationSharing");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
            }
            return request;
        }
                    private static EnableReachabilityAnalyzerOrganizationSharingRequestMarshaller _instance = new EnableReachabilityAnalyzerOrganizationSharingRequestMarshaller();        

        internal static EnableReachabilityAnalyzerOrganizationSharingRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static EnableReachabilityAnalyzerOrganizationSharingRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}