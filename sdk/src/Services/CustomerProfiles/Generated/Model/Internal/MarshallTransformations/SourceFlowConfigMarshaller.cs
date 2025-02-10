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
    /// SourceFlowConfig Marshaller
    /// </summary>
    public class SourceFlowConfigMarshaller : IRequestMarshaller<SourceFlowConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SourceFlowConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetConnectorProfileName())
            {
                context.Writer.WritePropertyName("ConnectorProfileName");
                context.Writer.WriteStringValue(requestObject.ConnectorProfileName);
            }

            if(requestObject.IsSetConnectorType())
            {
                context.Writer.WritePropertyName("ConnectorType");
                context.Writer.WriteStringValue(requestObject.ConnectorType);
            }

            if(requestObject.IsSetIncrementalPullConfig())
            {
                context.Writer.WritePropertyName("IncrementalPullConfig");
                context.Writer.WriteStartObject();

                var marshaller = IncrementalPullConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.IncrementalPullConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSourceConnectorProperties())
            {
                context.Writer.WritePropertyName("SourceConnectorProperties");
                context.Writer.WriteStartObject();

                var marshaller = SourceConnectorPropertiesMarshaller.Instance;
                marshaller.Marshall(requestObject.SourceConnectorProperties, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SourceFlowConfigMarshaller Instance = new SourceFlowConfigMarshaller();

    }
}