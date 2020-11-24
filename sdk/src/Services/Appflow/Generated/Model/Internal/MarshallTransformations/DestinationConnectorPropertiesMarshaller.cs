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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Appflow.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Appflow.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DestinationConnectorProperties Marshaller
    /// </summary>       
    public class DestinationConnectorPropertiesMarshaller : IRequestMarshaller<DestinationConnectorProperties, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DestinationConnectorProperties requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetEventBridge())
            {
                context.Writer.WritePropertyName("EventBridge");
                context.Writer.WriteObjectStart();

                var marshaller = EventBridgeDestinationPropertiesMarshaller.Instance;
                marshaller.Marshall(requestObject.EventBridge, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRedshift())
            {
                context.Writer.WritePropertyName("Redshift");
                context.Writer.WriteObjectStart();

                var marshaller = RedshiftDestinationPropertiesMarshaller.Instance;
                marshaller.Marshall(requestObject.Redshift, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetS3())
            {
                context.Writer.WritePropertyName("S3");
                context.Writer.WriteObjectStart();

                var marshaller = S3DestinationPropertiesMarshaller.Instance;
                marshaller.Marshall(requestObject.S3, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSalesforce())
            {
                context.Writer.WritePropertyName("Salesforce");
                context.Writer.WriteObjectStart();

                var marshaller = SalesforceDestinationPropertiesMarshaller.Instance;
                marshaller.Marshall(requestObject.Salesforce, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSnowflake())
            {
                context.Writer.WritePropertyName("Snowflake");
                context.Writer.WriteObjectStart();

                var marshaller = SnowflakeDestinationPropertiesMarshaller.Instance;
                marshaller.Marshall(requestObject.Snowflake, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetUpsolver())
            {
                context.Writer.WritePropertyName("Upsolver");
                context.Writer.WriteObjectStart();

                var marshaller = UpsolverDestinationPropertiesMarshaller.Instance;
                marshaller.Marshall(requestObject.Upsolver, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static DestinationConnectorPropertiesMarshaller Instance = new DestinationConnectorPropertiesMarshaller();

    }
}