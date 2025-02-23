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
    /// AssociateInstanceEventWindow Request Marshaller
    /// </summary>       
    public class AssociateInstanceEventWindowRequestMarshaller : IMarshaller<IRequest, AssociateInstanceEventWindowRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((AssociateInstanceEventWindowRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(AssociateInstanceEventWindowRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "AssociateInstanceEventWindow");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAssociationTarget())
                {
                    if(publicRequest.AssociationTarget.IsSetDedicatedHostIds())
                    {
                        if (publicRequest.AssociationTarget.DedicatedHostIds.Count == 0)
                            request.Parameters.Add("AssociationTarget" + "." + "DedicatedHostId", "");
                        else
                        {
                             int publicRequestAssociationTargetlistValueIndex = 1;
                             foreach(var publicRequestAssociationTargetlistValue in publicRequest.AssociationTarget.DedicatedHostIds)
                             {
                                 request.Parameters.Add("AssociationTarget" + "." + "DedicatedHostId" + "." + publicRequestAssociationTargetlistValueIndex, StringUtils.FromString(publicRequestAssociationTargetlistValue));
                                 publicRequestAssociationTargetlistValueIndex++;
                             }
                        }
                    }
                    if(publicRequest.AssociationTarget.IsSetInstanceIds())
                    {
                        if (publicRequest.AssociationTarget.InstanceIds.Count == 0)
                            request.Parameters.Add("AssociationTarget" + "." + "InstanceId", "");
                        else
                        {
                             int publicRequestAssociationTargetlistValueIndex = 1;
                             foreach(var publicRequestAssociationTargetlistValue in publicRequest.AssociationTarget.InstanceIds)
                             {
                                 request.Parameters.Add("AssociationTarget" + "." + "InstanceId" + "." + publicRequestAssociationTargetlistValueIndex, StringUtils.FromString(publicRequestAssociationTargetlistValue));
                                 publicRequestAssociationTargetlistValueIndex++;
                             }
                        }
                    }
                    if(publicRequest.AssociationTarget.IsSetInstanceTags())
                    {
                        if (publicRequest.AssociationTarget.InstanceTags.Count == 0)
                            request.Parameters.Add("AssociationTarget" + "." + "InstanceTag", "");
                        else
                        {
                             int publicRequestAssociationTargetlistValueIndex = 1;
                             foreach(var publicRequestAssociationTargetlistValue in publicRequest.AssociationTarget.InstanceTags)
                             {
                                if(publicRequestAssociationTargetlistValue.IsSetKey())
                                {
                                    request.Parameters.Add("AssociationTarget" + "." + "InstanceTag" + "." + publicRequestAssociationTargetlistValueIndex + "." + "Key", StringUtils.FromString(publicRequestAssociationTargetlistValue.Key));
                                }
                                if(publicRequestAssociationTargetlistValue.IsSetValue())
                                {
                                    request.Parameters.Add("AssociationTarget" + "." + "InstanceTag" + "." + publicRequestAssociationTargetlistValueIndex + "." + "Value", StringUtils.FromString(publicRequestAssociationTargetlistValue.Value));
                                }
                                 publicRequestAssociationTargetlistValueIndex++;
                             }
                        }
                    }
                }
                if(publicRequest.IsSetDryRun())
                {
                    request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun));
                }
                if(publicRequest.IsSetInstanceEventWindowId())
                {
                    request.Parameters.Add("InstanceEventWindowId", StringUtils.FromString(publicRequest.InstanceEventWindowId));
                }
            }
            return request;
        }
                    private static AssociateInstanceEventWindowRequestMarshaller _instance = new AssociateInstanceEventWindowRequestMarshaller();        

        internal static AssociateInstanceEventWindowRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AssociateInstanceEventWindowRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}