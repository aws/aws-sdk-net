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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudFormation.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CloudFormation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListStackInstanceResourceDrifts Request Marshaller
    /// </summary>       
    public class ListStackInstanceResourceDriftsRequestMarshaller : IMarshaller<IRequest, ListStackInstanceResourceDriftsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListStackInstanceResourceDriftsRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListStackInstanceResourceDriftsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudFormation");
            request.Parameters.Add("Action", "ListStackInstanceResourceDrifts");
            request.Parameters.Add("Version", "2010-05-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetCallAs())
                {
                    request.Parameters.Add("CallAs", StringUtils.FromString(publicRequest.CallAs));
                }
                if(publicRequest.IsSetMaxResults())
                {
                    request.Parameters.Add("MaxResults", StringUtils.FromInt(publicRequest.MaxResults));
                }
                if(publicRequest.IsSetNextToken())
                {
                    request.Parameters.Add("NextToken", StringUtils.FromString(publicRequest.NextToken));
                }
                if(publicRequest.IsSetOperationId())
                {
                    request.Parameters.Add("OperationId", StringUtils.FromString(publicRequest.OperationId));
                }
                if(publicRequest.IsSetStackInstanceAccount())
                {
                    request.Parameters.Add("StackInstanceAccount", StringUtils.FromString(publicRequest.StackInstanceAccount));
                }
                if(publicRequest.IsSetStackInstanceRegion())
                {
                    request.Parameters.Add("StackInstanceRegion", StringUtils.FromString(publicRequest.StackInstanceRegion));
                }
                if(publicRequest.IsSetStackInstanceResourceDriftStatuses())
                {
                    if (publicRequest.StackInstanceResourceDriftStatuses.Count == 0)
                        request.Parameters.Add("StackInstanceResourceDriftStatuses", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.StackInstanceResourceDriftStatuses)
                         {
                             request.Parameters.Add("StackInstanceResourceDriftStatuses" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetStackSetName())
                {
                    request.Parameters.Add("StackSetName", StringUtils.FromString(publicRequest.StackSetName));
                }
            }
            return request;
        }
                    private static ListStackInstanceResourceDriftsRequestMarshaller _instance = new ListStackInstanceResourceDriftsRequestMarshaller();        

        internal static ListStackInstanceResourceDriftsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListStackInstanceResourceDriftsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}