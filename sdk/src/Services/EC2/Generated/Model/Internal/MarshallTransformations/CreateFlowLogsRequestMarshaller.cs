/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// CreateFlowLogs Request Marshaller
    /// </summary>       
    public class CreateFlowLogsRequestMarshaller : IMarshaller<IRequest, CreateFlowLogsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateFlowLogsRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateFlowLogsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "CreateFlowLogs");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetClientToken())
                {
                    request.Parameters.Add("ClientToken", StringUtils.FromString(publicRequest.ClientToken));
                }
                if(publicRequest.IsSetDeliverLogsPermissionArn())
                {
                    request.Parameters.Add("DeliverLogsPermissionArn", StringUtils.FromString(publicRequest.DeliverLogsPermissionArn));
                }
                if(publicRequest.IsSetLogGroupName())
                {
                    request.Parameters.Add("LogGroupName", StringUtils.FromString(publicRequest.LogGroupName));
                }
                if(publicRequest.IsSetResourceIds())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.ResourceIds)
                    {
                        request.Parameters.Add("ResourceId" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetResourceType())
                {
                    request.Parameters.Add("ResourceType", StringUtils.FromString(publicRequest.ResourceType));
                }
                if(publicRequest.IsSetTrafficType())
                {
                    request.Parameters.Add("TrafficType", StringUtils.FromString(publicRequest.TrafficType));
                }
            }
            return request;
        }
                    private static CreateFlowLogsRequestMarshaller _instance = new CreateFlowLogsRequestMarshaller();        

        internal static CreateFlowLogsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateFlowLogsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}