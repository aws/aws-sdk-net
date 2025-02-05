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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeDeploy.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CodeDeploy.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TargetInstances Marshaller
    /// </summary>
    public class TargetInstancesMarshaller : IRequestMarshaller<TargetInstances, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TargetInstances requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAutoScalingGroups())
            {
                context.Writer.WritePropertyName("autoScalingGroups");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAutoScalingGroupsListValue in requestObject.AutoScalingGroups)
                {
                        context.Writer.WriteStringValue(requestObjectAutoScalingGroupsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEc2TagSet())
            {
                context.Writer.WritePropertyName("ec2TagSet");
                context.Writer.WriteStartObject();

                var marshaller = EC2TagSetMarshaller.Instance;
                marshaller.Marshall(requestObject.Ec2TagSet, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTagFilters())
            {
                context.Writer.WritePropertyName("tagFilters");
                context.Writer.WriteStartArray();
                foreach(var requestObjectTagFiltersListValue in requestObject.TagFilters)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = EC2TagFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectTagFiltersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TargetInstancesMarshaller Instance = new TargetInstancesMarshaller();

    }
}