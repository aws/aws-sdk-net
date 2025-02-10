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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TargetTableConfig Marshaller
    /// </summary>
    public class TargetTableConfigMarshaller : IRequestMarshaller<TargetTableConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TargetTableConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetPartitionSpec())
            {
                context.Writer.WritePropertyName("PartitionSpec");
                context.Writer.WriteStartArray();
                foreach(var requestObjectPartitionSpecListValue in requestObject.PartitionSpec)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = IntegrationPartitionMarshaller.Instance;
                    marshaller.Marshall(requestObjectPartitionSpecListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetTargetTableName())
            {
                context.Writer.WritePropertyName("TargetTableName");
                context.Writer.WriteStringValue(requestObject.TargetTableName);
            }

            if(requestObject.IsSetUnnestSpec())
            {
                context.Writer.WritePropertyName("UnnestSpec");
                context.Writer.WriteStringValue(requestObject.UnnestSpec);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TargetTableConfigMarshaller Instance = new TargetTableConfigMarshaller();

    }
}