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
using ThirdParty.Json.LitJson;

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
            if(requestObject.IsSetAdditionalMasterSecurityGroups())
            {
                context.Writer.WritePropertyName("AdditionalMasterSecurityGroups");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAdditionalMasterSecurityGroupsListValue in requestObject.AdditionalMasterSecurityGroups)
                {
                        context.Writer.Write(requestObjectAdditionalMasterSecurityGroupsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetAdditionalSlaveSecurityGroups())
            {
                context.Writer.WritePropertyName("AdditionalSlaveSecurityGroups");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAdditionalSlaveSecurityGroupsListValue in requestObject.AdditionalSlaveSecurityGroups)
                {
                        context.Writer.Write(requestObjectAdditionalSlaveSecurityGroupsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEc2KeyName())
            {
                context.Writer.WritePropertyName("Ec2KeyName");
                context.Writer.Write(requestObject.Ec2KeyName);
            }

            if(requestObject.IsSetEc2SubnetId())
            {
                context.Writer.WritePropertyName("Ec2SubnetId");
                context.Writer.Write(requestObject.Ec2SubnetId);
            }

            if(requestObject.IsSetEc2SubnetIds())
            {
                context.Writer.WritePropertyName("Ec2SubnetIds");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectEc2SubnetIdsListValue in requestObject.Ec2SubnetIds)
                {
                        context.Writer.Write(requestObjectEc2SubnetIdsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEmrManagedMasterSecurityGroup())
            {
                context.Writer.WritePropertyName("EmrManagedMasterSecurityGroup");
                context.Writer.Write(requestObject.EmrManagedMasterSecurityGroup);
            }

            if(requestObject.IsSetEmrManagedSlaveSecurityGroup())
            {
                context.Writer.WritePropertyName("EmrManagedSlaveSecurityGroup");
                context.Writer.Write(requestObject.EmrManagedSlaveSecurityGroup);
            }

            if(requestObject.IsSetHadoopVersion())
            {
                context.Writer.WritePropertyName("HadoopVersion");
                context.Writer.Write(requestObject.HadoopVersion);
            }

            if(requestObject.IsSetInstanceCount())
            {
                context.Writer.WritePropertyName("InstanceCount");
                context.Writer.Write(requestObject.InstanceCount);
            }

            if(requestObject.IsSetInstanceFleets())
            {
                context.Writer.WritePropertyName("InstanceFleets");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectInstanceFleetsListValue in requestObject.InstanceFleets)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = InstanceFleetConfigMarshaller.Instance;
                    marshaller.Marshall(requestObjectInstanceFleetsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetInstanceGroups())
            {
                context.Writer.WritePropertyName("InstanceGroups");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectInstanceGroupsListValue in requestObject.InstanceGroups)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = InstanceGroupConfigMarshaller.Instance;
                    marshaller.Marshall(requestObjectInstanceGroupsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetKeepJobFlowAliveWhenNoSteps())
            {
                context.Writer.WritePropertyName("KeepJobFlowAliveWhenNoSteps");
                context.Writer.Write(requestObject.KeepJobFlowAliveWhenNoSteps);
            }

            if(requestObject.IsSetMasterInstanceType())
            {
                context.Writer.WritePropertyName("MasterInstanceType");
                context.Writer.Write(requestObject.MasterInstanceType);
            }

            if(requestObject.IsSetPlacement())
            {
                context.Writer.WritePropertyName("Placement");
                context.Writer.WriteObjectStart();

                var marshaller = PlacementTypeMarshaller.Instance;
                marshaller.Marshall(requestObject.Placement, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetServiceAccessSecurityGroup())
            {
                context.Writer.WritePropertyName("ServiceAccessSecurityGroup");
                context.Writer.Write(requestObject.ServiceAccessSecurityGroup);
            }

            if(requestObject.IsSetSlaveInstanceType())
            {
                context.Writer.WritePropertyName("SlaveInstanceType");
                context.Writer.Write(requestObject.SlaveInstanceType);
            }

            if(requestObject.IsSetTerminationProtected())
            {
                context.Writer.WritePropertyName("TerminationProtected");
                context.Writer.Write(requestObject.TerminationProtected);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static JobFlowInstancesConfigMarshaller Instance = new JobFlowInstancesConfigMarshaller();

    }
}