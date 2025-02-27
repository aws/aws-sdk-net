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
    /// ModifyIpamResourceCidr Request Marshaller
    /// </summary>       
    public class ModifyIpamResourceCidrRequestMarshaller : IMarshaller<IRequest, ModifyIpamResourceCidrRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyIpamResourceCidrRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ModifyIpamResourceCidrRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "ModifyIpamResourceCidr");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetCurrentIpamScopeId())
                {
                    request.Parameters.Add("CurrentIpamScopeId", StringUtils.FromString(publicRequest.CurrentIpamScopeId));
                }
                if(publicRequest.IsSetDestinationIpamScopeId())
                {
                    request.Parameters.Add("DestinationIpamScopeId", StringUtils.FromString(publicRequest.DestinationIpamScopeId));
                }
                if(publicRequest.IsSetDryRun())
                {
                    request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun));
                }
                if(publicRequest.IsSetMonitored())
                {
                    request.Parameters.Add("Monitored", StringUtils.FromBool(publicRequest.Monitored));
                }
                if(publicRequest.IsSetResourceCidr())
                {
                    request.Parameters.Add("ResourceCidr", StringUtils.FromString(publicRequest.ResourceCidr));
                }
                if(publicRequest.IsSetResourceId())
                {
                    request.Parameters.Add("ResourceId", StringUtils.FromString(publicRequest.ResourceId));
                }
                if(publicRequest.IsSetResourceRegion())
                {
                    request.Parameters.Add("ResourceRegion", StringUtils.FromString(publicRequest.ResourceRegion));
                }
            }
            return request;
        }
                    private static ModifyIpamResourceCidrRequestMarshaller _instance = new ModifyIpamResourceCidrRequestMarshaller();        

        internal static ModifyIpamResourceCidrRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifyIpamResourceCidrRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}