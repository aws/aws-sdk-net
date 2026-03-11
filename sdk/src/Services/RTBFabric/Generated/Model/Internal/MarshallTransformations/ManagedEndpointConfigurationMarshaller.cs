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
 * Do not modify this file. This file is generated from the rtbfabric-2023-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.RTBFabric.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.RTBFabric.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ManagedEndpointConfiguration Marshaller
    /// </summary>
    public class ManagedEndpointConfigurationMarshaller : IRequestMarshaller<ManagedEndpointConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ManagedEndpointConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAutoScalingGroups())
            {
                context.Writer.WritePropertyName("autoScalingGroups");
                context.Writer.WriteStartObject();

                var marshaller = AutoScalingGroupsConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.AutoScalingGroups, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEksEndpoints())
            {
                context.Writer.WritePropertyName("eksEndpoints");
                context.Writer.WriteStartObject();

                var marshaller = EksEndpointsConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.EksEndpoints, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ManagedEndpointConfigurationMarshaller Instance = new ManagedEndpointConfigurationMarshaller();

    }
}