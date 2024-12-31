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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.RDS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.RDS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateBlueGreenDeployment Request Marshaller
    /// </summary>       
    public class CreateBlueGreenDeploymentRequestMarshaller : IMarshaller<IRequest, CreateBlueGreenDeploymentRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateBlueGreenDeploymentRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateBlueGreenDeploymentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RDS");
            request.Parameters.Add("Action", "CreateBlueGreenDeployment");
            request.Parameters.Add("Version", "2014-10-31");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetBlueGreenDeploymentName())
                {
                    request.Parameters.Add("BlueGreenDeploymentName", StringUtils.FromString(publicRequest.BlueGreenDeploymentName));
                }
                if(publicRequest.IsSetSource())
                {
                    request.Parameters.Add("Source", StringUtils.FromString(publicRequest.Source));
                }
                if(publicRequest.IsSetTags())
                {
                    if (publicRequest.Tags.Count == 0)
                        request.Parameters.Add("Tags", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.Tags)
                         {
                            if(publicRequestlistValue.IsSetKey())
                            {
                                request.Parameters.Add("Tags" + "." + "Tag" + "." + publicRequestlistValueIndex + "." + "Key", StringUtils.FromString(publicRequestlistValue.Key));
                            }
                            if(publicRequestlistValue.IsSetValue())
                            {
                                request.Parameters.Add("Tags" + "." + "Tag" + "." + publicRequestlistValueIndex + "." + "Value", StringUtils.FromString(publicRequestlistValue.Value));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetTargetAllocatedStorage())
                {
                    request.Parameters.Add("TargetAllocatedStorage", StringUtils.FromInt(publicRequest.TargetAllocatedStorage));
                }
                if(publicRequest.IsSetTargetDBClusterParameterGroupName())
                {
                    request.Parameters.Add("TargetDBClusterParameterGroupName", StringUtils.FromString(publicRequest.TargetDBClusterParameterGroupName));
                }
                if(publicRequest.IsSetTargetDBInstanceClass())
                {
                    request.Parameters.Add("TargetDBInstanceClass", StringUtils.FromString(publicRequest.TargetDBInstanceClass));
                }
                if(publicRequest.IsSetTargetDBParameterGroupName())
                {
                    request.Parameters.Add("TargetDBParameterGroupName", StringUtils.FromString(publicRequest.TargetDBParameterGroupName));
                }
                if(publicRequest.IsSetTargetEngineVersion())
                {
                    request.Parameters.Add("TargetEngineVersion", StringUtils.FromString(publicRequest.TargetEngineVersion));
                }
                if(publicRequest.IsSetTargetIops())
                {
                    request.Parameters.Add("TargetIops", StringUtils.FromInt(publicRequest.TargetIops));
                }
                if(publicRequest.IsSetTargetStorageThroughput())
                {
                    request.Parameters.Add("TargetStorageThroughput", StringUtils.FromInt(publicRequest.TargetStorageThroughput));
                }
                if(publicRequest.IsSetTargetStorageType())
                {
                    request.Parameters.Add("TargetStorageType", StringUtils.FromString(publicRequest.TargetStorageType));
                }
                if(publicRequest.IsSetUpgradeTargetStorageConfig())
                {
                    request.Parameters.Add("UpgradeTargetStorageConfig", StringUtils.FromBool(publicRequest.UpgradeTargetStorageConfig));
                }
            }
            return request;
        }
                    private static CreateBlueGreenDeploymentRequestMarshaller _instance = new CreateBlueGreenDeploymentRequestMarshaller();        

        internal static CreateBlueGreenDeploymentRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateBlueGreenDeploymentRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}