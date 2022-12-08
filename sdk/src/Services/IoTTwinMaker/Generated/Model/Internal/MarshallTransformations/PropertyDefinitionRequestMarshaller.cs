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
 * Do not modify this file. This file is generated from the iottwinmaker-2021-11-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTTwinMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoTTwinMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PropertyDefinitionRequest Marshaller
    /// </summary>
    public class PropertyDefinitionRequestMarshaller : IRequestMarshaller<PropertyDefinitionRequest, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(PropertyDefinitionRequest requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetConfiguration())
            {
                context.Writer.WritePropertyName("configuration");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectConfigurationKvp in requestObject.Configuration)
                {
                    context.Writer.WritePropertyName(requestObjectConfigurationKvp.Key);
                    var requestObjectConfigurationValue = requestObjectConfigurationKvp.Value;

                        context.Writer.Write(requestObjectConfigurationValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDataType())
            {
                context.Writer.WritePropertyName("dataType");
                context.Writer.WriteObjectStart();

                var marshaller = DataTypeMarshaller.Instance;
                marshaller.Marshall(requestObject.DataType, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDefaultValue())
            {
                context.Writer.WritePropertyName("defaultValue");
                context.Writer.WriteObjectStart();

                var marshaller = DataValueMarshaller.Instance;
                marshaller.Marshall(requestObject.DefaultValue, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDisplayName())
            {
                context.Writer.WritePropertyName("displayName");
                context.Writer.Write(requestObject.DisplayName);
            }

            if(requestObject.IsSetIsExternalId())
            {
                context.Writer.WritePropertyName("isExternalId");
                context.Writer.Write(requestObject.IsExternalId);
            }

            if(requestObject.IsSetIsRequiredInEntity())
            {
                context.Writer.WritePropertyName("isRequiredInEntity");
                context.Writer.Write(requestObject.IsRequiredInEntity);
            }

            if(requestObject.IsSetIsStoredExternally())
            {
                context.Writer.WritePropertyName("isStoredExternally");
                context.Writer.Write(requestObject.IsStoredExternally);
            }

            if(requestObject.IsSetIsTimeSeries())
            {
                context.Writer.WritePropertyName("isTimeSeries");
                context.Writer.Write(requestObject.IsTimeSeries);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PropertyDefinitionRequestMarshaller Instance = new PropertyDefinitionRequestMarshaller();

    }
}