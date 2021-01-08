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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Batch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Batch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ComputeResource Marshaller
    /// </summary>       
    public class ComputeResourceMarshaller : IRequestMarshaller<ComputeResource, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ComputeResource requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAllocationStrategy())
            {
                context.Writer.WritePropertyName("allocationStrategy");
                context.Writer.Write(requestObject.AllocationStrategy);
            }

            if(requestObject.IsSetBidPercentage())
            {
                context.Writer.WritePropertyName("bidPercentage");
                context.Writer.Write(requestObject.BidPercentage);
            }

            if(requestObject.IsSetDesiredvCpus())
            {
                context.Writer.WritePropertyName("desiredvCpus");
                context.Writer.Write(requestObject.DesiredvCpus);
            }

            if(requestObject.IsSetEc2Configuration())
            {
                context.Writer.WritePropertyName("ec2Configuration");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectEc2ConfigurationListValue in requestObject.Ec2Configuration)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = Ec2ConfigurationMarshaller.Instance;
                    marshaller.Marshall(requestObjectEc2ConfigurationListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEc2KeyPair())
            {
                context.Writer.WritePropertyName("ec2KeyPair");
                context.Writer.Write(requestObject.Ec2KeyPair);
            }

            if(requestObject.IsSetImageId())
            {
                context.Writer.WritePropertyName("imageId");
                context.Writer.Write(requestObject.ImageId);
            }

            if(requestObject.IsSetInstanceRole())
            {
                context.Writer.WritePropertyName("instanceRole");
                context.Writer.Write(requestObject.InstanceRole);
            }

            if(requestObject.IsSetInstanceTypes())
            {
                context.Writer.WritePropertyName("instanceTypes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectInstanceTypesListValue in requestObject.InstanceTypes)
                {
                        context.Writer.Write(requestObjectInstanceTypesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetLaunchTemplate())
            {
                context.Writer.WritePropertyName("launchTemplate");
                context.Writer.WriteObjectStart();

                var marshaller = LaunchTemplateSpecificationMarshaller.Instance;
                marshaller.Marshall(requestObject.LaunchTemplate, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetMaxvCpus())
            {
                context.Writer.WritePropertyName("maxvCpus");
                context.Writer.Write(requestObject.MaxvCpus);
            }

            if(requestObject.IsSetMinvCpus())
            {
                context.Writer.WritePropertyName("minvCpus");
                context.Writer.Write(requestObject.MinvCpus);
            }

            if(requestObject.IsSetPlacementGroup())
            {
                context.Writer.WritePropertyName("placementGroup");
                context.Writer.Write(requestObject.PlacementGroup);
            }

            if(requestObject.IsSetSecurityGroupIds())
            {
                context.Writer.WritePropertyName("securityGroupIds");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSecurityGroupIdsListValue in requestObject.SecurityGroupIds)
                {
                        context.Writer.Write(requestObjectSecurityGroupIdsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSpotIamFleetRole())
            {
                context.Writer.WritePropertyName("spotIamFleetRole");
                context.Writer.Write(requestObject.SpotIamFleetRole);
            }

            if(requestObject.IsSetSubnets())
            {
                context.Writer.WritePropertyName("subnets");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSubnetsListValue in requestObject.Subnets)
                {
                        context.Writer.Write(requestObjectSubnetsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectTagsKvp in requestObject.Tags)
                {
                    context.Writer.WritePropertyName(requestObjectTagsKvp.Key);
                    var requestObjectTagsValue = requestObjectTagsKvp.Value;

                        context.Writer.Write(requestObjectTagsValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("type");
                context.Writer.Write(requestObject.Type);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static ComputeResourceMarshaller Instance = new ComputeResourceMarshaller();

    }
}