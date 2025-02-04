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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticMapReduce.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// JobFlowInstancesConfig Marshaller
    /// </summary>
    public class JobFlowInstancesConfigMarshaller : IRequestMarshaller<JobFlowInstancesConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(JobFlowInstancesConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAdditionalMasterSecurityGroups())
            {
                context.Writer.WritePropertyName("AdditionalMasterSecurityGroups");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAdditionalMasterSecurityGroupsListValue in requestObject.AdditionalMasterSecurityGroups)
                {
                        context.Writer.WriteStringValue(requestObjectAdditionalMasterSecurityGroupsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetAdditionalSlaveSecurityGroups())
            {
                context.Writer.WritePropertyName("AdditionalSlaveSecurityGroups");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAdditionalSlaveSecurityGroupsListValue in requestObject.AdditionalSlaveSecurityGroups)
                {
                        context.Writer.WriteStringValue(requestObjectAdditionalSlaveSecurityGroupsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEc2KeyName())
            {
                context.Writer.WritePropertyName("Ec2KeyName");
                context.Writer.WriteStringValue(requestObject.Ec2KeyName);
            }

            if(requestObject.IsSetEc2SubnetId())
            {
                context.Writer.WritePropertyName("Ec2SubnetId");
                context.Writer.WriteStringValue(requestObject.Ec2SubnetId);
            }

            if(requestObject.IsSetEc2SubnetIds())
            {
                context.Writer.WritePropertyName("Ec2SubnetIds");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEc2SubnetIdsListValue in requestObject.Ec2SubnetIds)
                {
                        context.Writer.WriteStringValue(requestObjectEc2SubnetIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEmrManagedMasterSecurityGroup())
            {
                context.Writer.WritePropertyName("EmrManagedMasterSecurityGroup");
                context.Writer.WriteStringValue(requestObject.EmrManagedMasterSecurityGroup);
            }

            if(requestObject.IsSetEmrManagedSlaveSecurityGroup())
            {
                context.Writer.WritePropertyName("EmrManagedSlaveSecurityGroup");
                context.Writer.WriteStringValue(requestObject.EmrManagedSlaveSecurityGroup);
            }

            if(requestObject.IsSetHadoopVersion())
            {
                context.Writer.WritePropertyName("HadoopVersion");
                context.Writer.WriteStringValue(requestObject.HadoopVersion);
            }

            if(requestObject.IsSetInstanceCount())
            {
                context.Writer.WritePropertyName("InstanceCount");
                context.Writer.WriteNumberValue(requestObject.InstanceCount.Value);
            }

            if(requestObject.IsSetInstanceFleets())
            {
                context.Writer.WritePropertyName("InstanceFleets");
                context.Writer.WriteStartArray();
                foreach(var requestObjectInstanceFleetsListValue in requestObject.InstanceFleets)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = InstanceFleetConfigMarshaller.Instance;
                    marshaller.Marshall(requestObjectInstanceFleetsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetInstanceGroups())
            {
                context.Writer.WritePropertyName("InstanceGroups");
                context.Writer.WriteStartArray();
                foreach(var requestObjectInstanceGroupsListValue in requestObject.InstanceGroups)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = InstanceGroupConfigMarshaller.Instance;
                    marshaller.Marshall(requestObjectInstanceGroupsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetKeepJobFlowAliveWhenNoSteps())
            {
                context.Writer.WritePropertyName("KeepJobFlowAliveWhenNoSteps");
                context.Writer.WriteBooleanValue(requestObject.KeepJobFlowAliveWhenNoSteps.Value);
            }

            if(requestObject.IsSetMasterInstanceType())
            {
                context.Writer.WritePropertyName("MasterInstanceType");
                context.Writer.WriteStringValue(requestObject.MasterInstanceType);
            }

            if(requestObject.IsSetPlacement())
            {
                context.Writer.WritePropertyName("Placement");
                context.Writer.WriteStartObject();

                var marshaller = PlacementTypeMarshaller.Instance;
                marshaller.Marshall(requestObject.Placement, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetServiceAccessSecurityGroup())
            {
                context.Writer.WritePropertyName("ServiceAccessSecurityGroup");
                context.Writer.WriteStringValue(requestObject.ServiceAccessSecurityGroup);
            }

            if(requestObject.IsSetSlaveInstanceType())
            {
                context.Writer.WritePropertyName("SlaveInstanceType");
                context.Writer.WriteStringValue(requestObject.SlaveInstanceType);
            }

            if(requestObject.IsSetTerminationProtected())
            {
                context.Writer.WritePropertyName("TerminationProtected");
                context.Writer.WriteBooleanValue(requestObject.TerminationProtected.Value);
            }

            if(requestObject.IsSetUnhealthyNodeReplacement())
            {
                context.Writer.WritePropertyName("UnhealthyNodeReplacement");
                context.Writer.WriteBooleanValue(requestObject.UnhealthyNodeReplacement.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static JobFlowInstancesConfigMarshaller Instance = new JobFlowInstancesConfigMarshaller();

    }
}