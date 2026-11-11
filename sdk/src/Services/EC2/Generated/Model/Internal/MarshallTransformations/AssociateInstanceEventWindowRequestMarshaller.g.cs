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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

using Amazon.EC2.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AssociateInstanceEventWindow Request Marshaller
    /// </summary>
    public partial class AssociateInstanceEventWindowRequestMarshaller : IMarshaller<IRequest, AssociateInstanceEventWindowRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((AssociateInstanceEventWindowRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AssociateInstanceEventWindowRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "AssociateInstanceEventWindow");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetAssociationTarget())
            {
                if (publicRequest.AssociationTarget.IsSetDedicatedHostIds())
                {
                    if (publicRequest.AssociationTarget.DedicatedHostIds.Count == 0)
                    {
                        request.Parameters.Add("AssociationTarget" + ".DedicatedHostId", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.AssociationTarget.DedicatedHostIds)
                        {
                            request.Parameters.Add("AssociationTarget" + ".DedicatedHostId" + "." + index1, StringUtils.FromString(item1));
                            index1++;
                        }
                    }
                }
                if (publicRequest.AssociationTarget.IsSetInstanceIds())
                {
                    if (publicRequest.AssociationTarget.InstanceIds.Count == 0)
                    {
                        request.Parameters.Add("AssociationTarget" + ".InstanceId", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.AssociationTarget.InstanceIds)
                        {
                            request.Parameters.Add("AssociationTarget" + ".InstanceId" + "." + index1, StringUtils.FromString(item1));
                            index1++;
                        }
                    }
                }
                if (publicRequest.AssociationTarget.IsSetInstanceTags())
                {
                    if (publicRequest.AssociationTarget.InstanceTags.Count == 0)
                    {
                        request.Parameters.Add("AssociationTarget" + ".InstanceTag", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.AssociationTarget.InstanceTags)
                        {
                            if (item1.IsSetKey())
                            {
                                request.Parameters.Add("AssociationTarget" + ".InstanceTag" + "." + index1 + ".Key", StringUtils.FromString(item1.Key));
                            }
                            if (item1.IsSetValue())
                            {
                                request.Parameters.Add("AssociationTarget" + ".InstanceTag" + "." + index1 + ".Value", StringUtils.FromString(item1.Value));
                            }
                            index1++;
                        }
                    }
                }
            }
            if (publicRequest.IsSetDryRun())
            {
                request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun.Value));
            }
            if (publicRequest.IsSetInstanceEventWindowId())
            {
                request.Parameters.Add("InstanceEventWindowId", StringUtils.FromString(publicRequest.InstanceEventWindowId));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly AssociateInstanceEventWindowRequestMarshaller _instance = new();

        internal static AssociateInstanceEventWindowRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static AssociateInstanceEventWindowRequestMarshaller Instance => _instance;
    }
}
