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
#pragma warning disable CS0612,CS0618
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ModifyVpcEndpointConnectionNotification Request Marshaller
    /// </summary>       
    public class ModifyVpcEndpointConnectionNotificationRequestMarshaller : IMarshaller<IRequest, ModifyVpcEndpointConnectionNotificationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyVpcEndpointConnectionNotificationRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ModifyVpcEndpointConnectionNotificationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "ModifyVpcEndpointConnectionNotification");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetConnectionEvents())
                {
                    if (publicRequest.ConnectionEvents.Count == 0)
                        request.Parameters.Add("ConnectionEvents", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.ConnectionEvents)
                         {
                             request.Parameters.Add("ConnectionEvents" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetConnectionNotificationArn())
                {
                    request.Parameters.Add("ConnectionNotificationArn", StringUtils.FromString(publicRequest.ConnectionNotificationArn));
                }
                if(publicRequest.IsSetConnectionNotificationId())
                {
                    request.Parameters.Add("ConnectionNotificationId", StringUtils.FromString(publicRequest.ConnectionNotificationId));
                }
                if(publicRequest.IsSetDryRun())
                {
                    request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun));
                }
            }
            return request;
        }
                    private static ModifyVpcEndpointConnectionNotificationRequestMarshaller _instance = new ModifyVpcEndpointConnectionNotificationRequestMarshaller();        

        internal static ModifyVpcEndpointConnectionNotificationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifyVpcEndpointConnectionNotificationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}