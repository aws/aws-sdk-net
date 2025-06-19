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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Lambda.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Lambda.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// KafkaSchemaRegistryConfig Marshaller
    /// </summary>
    public class KafkaSchemaRegistryConfigMarshaller : IRequestMarshaller<KafkaSchemaRegistryConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(KafkaSchemaRegistryConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAccessConfigs())
            {
                context.Writer.WritePropertyName("AccessConfigs");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAccessConfigsListValue in requestObject.AccessConfigs)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = KafkaSchemaRegistryAccessConfigMarshaller.Instance;
                    marshaller.Marshall(requestObjectAccessConfigsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEventRecordFormat())
            {
                context.Writer.WritePropertyName("EventRecordFormat");
                context.Writer.Write(requestObject.EventRecordFormat);
            }

            if(requestObject.IsSetSchemaRegistryURI())
            {
                context.Writer.WritePropertyName("SchemaRegistryURI");
                context.Writer.Write(requestObject.SchemaRegistryURI);
            }

            if(requestObject.IsSetSchemaValidationConfigs())
            {
                context.Writer.WritePropertyName("SchemaValidationConfigs");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSchemaValidationConfigsListValue in requestObject.SchemaValidationConfigs)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = KafkaSchemaValidationConfigMarshaller.Instance;
                    marshaller.Marshall(requestObjectSchemaValidationConfigsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static KafkaSchemaRegistryConfigMarshaller Instance = new KafkaSchemaRegistryConfigMarshaller();

    }
}