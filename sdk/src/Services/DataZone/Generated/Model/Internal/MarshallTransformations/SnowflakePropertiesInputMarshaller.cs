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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DataZone.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.DataZone.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SnowflakePropertiesInput Marshaller
    /// </summary>
    public class SnowflakePropertiesInputMarshaller : IRequestMarshaller<SnowflakePropertiesInput, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SnowflakePropertiesInput requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetConnectivityProperties())
            {
                context.Writer.WritePropertyName("connectivityProperties");
                context.Writer.WriteStartObject();

                var marshaller = ConnectivityPropertiesMarshaller.Instance;
                marshaller.Marshall(requestObject.ConnectivityProperties, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetIdentityMapping())
            {
                context.Writer.WritePropertyName("identityMapping");
                context.Writer.WriteStartObject();

                var marshaller = IdentityMappingMarshaller.Instance;
                marshaller.Marshall(requestObject.IdentityMapping, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLineageSync())
            {
                context.Writer.WritePropertyName("lineageSync");
                context.Writer.WriteStartObject();

                var marshaller = LineageSyncInputMarshaller.Instance;
                marshaller.Marshall(requestObject.LineageSync, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSnowflakeRole())
            {
                context.Writer.WritePropertyName("snowflakeRole");
                context.Writer.WriteStringValue(requestObject.SnowflakeRole);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SnowflakePropertiesInputMarshaller Instance = new SnowflakePropertiesInputMarshaller();

    }
}