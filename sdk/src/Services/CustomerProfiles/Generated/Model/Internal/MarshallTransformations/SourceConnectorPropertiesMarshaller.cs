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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CustomerProfiles.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CustomerProfiles.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SourceConnectorProperties Marshaller
    /// </summary>
    public class SourceConnectorPropertiesMarshaller : IRequestMarshaller<SourceConnectorProperties, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SourceConnectorProperties requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetMarketo())
            {
                context.Writer.WritePropertyName("Marketo");
                context.Writer.WriteStartObject();

                var marshaller = MarketoSourcePropertiesMarshaller.Instance;
                marshaller.Marshall(requestObject.Marketo, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetS3())
            {
                context.Writer.WritePropertyName("S3");
                context.Writer.WriteStartObject();

                var marshaller = S3SourcePropertiesMarshaller.Instance;
                marshaller.Marshall(requestObject.S3, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSalesforce())
            {
                context.Writer.WritePropertyName("Salesforce");
                context.Writer.WriteStartObject();

                var marshaller = SalesforceSourcePropertiesMarshaller.Instance;
                marshaller.Marshall(requestObject.Salesforce, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetServiceNow())
            {
                context.Writer.WritePropertyName("ServiceNow");
                context.Writer.WriteStartObject();

                var marshaller = ServiceNowSourcePropertiesMarshaller.Instance;
                marshaller.Marshall(requestObject.ServiceNow, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetZendesk())
            {
                context.Writer.WritePropertyName("Zendesk");
                context.Writer.WriteStartObject();

                var marshaller = ZendeskSourcePropertiesMarshaller.Instance;
                marshaller.Marshall(requestObject.Zendesk, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SourceConnectorPropertiesMarshaller Instance = new SourceConnectorPropertiesMarshaller();

    }
}