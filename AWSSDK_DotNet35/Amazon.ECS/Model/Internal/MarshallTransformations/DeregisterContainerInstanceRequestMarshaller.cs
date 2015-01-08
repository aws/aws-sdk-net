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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ECS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.ECS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeregisterContainerInstance Request Marshaller
    /// </summary>       
    public class DeregisterContainerInstanceRequestMarshaller : IMarshaller<IRequest, DeregisterContainerInstanceRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeregisterContainerInstanceRequest)input);
        }
    
        public IRequest Marshall(DeregisterContainerInstanceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ECS");
            request.Parameters.Add("Action", "DeregisterContainerInstance");
            request.Parameters.Add("Version", "2014-11-13");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetCluster())
                {
                    request.Parameters.Add("cluster", StringUtils.FromString(publicRequest.Cluster));
                }
                if(publicRequest.IsSetContainerInstance())
                {
                    request.Parameters.Add("containerInstance", StringUtils.FromString(publicRequest.ContainerInstance));
                }
                if(publicRequest.IsSetForce())
                {
                    request.Parameters.Add("force", StringUtils.FromBool(publicRequest.Force));
                }
            }
            return request;
        }
    }
}