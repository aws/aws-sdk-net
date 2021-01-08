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
using ThirdParty.Json.LitJson;

namespace Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// InstanceGroupModifyConfig Marshaller
    /// </summary>       
    public class InstanceGroupModifyConfigMarshaller : IRequestMarshaller<InstanceGroupModifyConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(InstanceGroupModifyConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetConfigurations())
            {
                context.Writer.WritePropertyName("Configurations");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectConfigurationsListValue in requestObject.Configurations)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ConfigurationMarshaller.Instance;
                    marshaller.Marshall(requestObjectConfigurationsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEC2InstanceIdsToTerminate())
            {
                context.Writer.WritePropertyName("EC2InstanceIdsToTerminate");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectEC2InstanceIdsToTerminateListValue in requestObject.EC2InstanceIdsToTerminate)
                {
                        context.Writer.Write(requestObjectEC2InstanceIdsToTerminateListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetInstanceCount())
            {
                context.Writer.WritePropertyName("InstanceCount");
                context.Writer.Write(requestObject.InstanceCount);
            }

            if(requestObject.IsSetInstanceGroupId())
            {
                context.Writer.WritePropertyName("InstanceGroupId");
                context.Writer.Write(requestObject.InstanceGroupId);
            }

            if(requestObject.IsSetShrinkPolicy())
            {
                context.Writer.WritePropertyName("ShrinkPolicy");
                context.Writer.WriteObjectStart();

                var marshaller = ShrinkPolicyMarshaller.Instance;
                marshaller.Marshall(requestObject.ShrinkPolicy, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static InstanceGroupModifyConfigMarshaller Instance = new InstanceGroupModifyConfigMarshaller();

    }
}