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
#pragma warning disable CS0612,CS0618
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
            if(requestObject == null)
                return;
            if(requestObject.IsSetAllocationStrategy())
            {
                context.Writer.WritePropertyName("allocationStrategy");
                context.Writer.WriteStringValue(requestObject.AllocationStrategy);
            }

            if(requestObject.IsSetBidPercentage())
            {
                context.Writer.WritePropertyName("bidPercentage");
                context.Writer.WriteNumberValue(requestObject.BidPercentage.Value);
            }

            if(requestObject.IsSetDesiredvCpus())
            {
                context.Writer.WritePropertyName("desiredvCpus");
                context.Writer.WriteNumberValue(requestObject.DesiredvCpus.Value);
            }

            if(requestObject.IsSetEc2Configuration())
            {
                context.Writer.WritePropertyName("ec2Configuration");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEc2ConfigurationListValue in requestObject.Ec2Configuration)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = Ec2ConfigurationMarshaller.Instance;
                    marshaller.Marshall(requestObjectEc2ConfigurationListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEc2KeyPair())
            {
                context.Writer.WritePropertyName("ec2KeyPair");
                context.Writer.WriteStringValue(requestObject.Ec2KeyPair);
            }

            if(requestObject.IsSetImageId())
            {
                context.Writer.WritePropertyName("imageId");
                context.Writer.WriteStringValue(requestObject.ImageId);
            }

            if(requestObject.IsSetInstanceRole())
            {
                context.Writer.WritePropertyName("instanceRole");
                context.Writer.WriteStringValue(requestObject.InstanceRole);
            }

            if(requestObject.IsSetInstanceTypes())
            {
                context.Writer.WritePropertyName("instanceTypes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectInstanceTypesListValue in requestObject.InstanceTypes)
                {
                        context.Writer.WriteStringValue(requestObjectInstanceTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetLaunchTemplate())
            {
                context.Writer.WritePropertyName("launchTemplate");
                context.Writer.WriteStartObject();

                var marshaller = LaunchTemplateSpecificationMarshaller.Instance;
                marshaller.Marshall(requestObject.LaunchTemplate, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMaxvCpus())
            {
                context.Writer.WritePropertyName("maxvCpus");
                context.Writer.WriteNumberValue(requestObject.MaxvCpus.Value);
            }

            if(requestObject.IsSetMinvCpus())
            {
                context.Writer.WritePropertyName("minvCpus");
                context.Writer.WriteNumberValue(requestObject.MinvCpus.Value);
            }

            if(requestObject.IsSetPlacementGroup())
            {
                context.Writer.WritePropertyName("placementGroup");
                context.Writer.WriteStringValue(requestObject.PlacementGroup);
            }

            if(requestObject.IsSetSecurityGroupIds())
            {
                context.Writer.WritePropertyName("securityGroupIds");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSecurityGroupIdsListValue in requestObject.SecurityGroupIds)
                {
                        context.Writer.WriteStringValue(requestObjectSecurityGroupIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSpotIamFleetRole())
            {
                context.Writer.WritePropertyName("spotIamFleetRole");
                context.Writer.WriteStringValue(requestObject.SpotIamFleetRole);
            }

            if(requestObject.IsSetSubnets())
            {
                context.Writer.WritePropertyName("subnets");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSubnetsListValue in requestObject.Subnets)
                {
                        context.Writer.WriteStringValue(requestObjectSubnetsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
                context.Writer.WriteStartObject();
                foreach (var requestObjectTagsKvp in requestObject.Tags)
                {
                    context.Writer.WritePropertyName(requestObjectTagsKvp.Key);
                    var requestObjectTagsValue = requestObjectTagsKvp.Value;

                        context.Writer.WriteStringValue(requestObjectTagsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("type");
                context.Writer.WriteStringValue(requestObject.Type);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ComputeResourceMarshaller Instance = new ComputeResourceMarshaller();

    }
}