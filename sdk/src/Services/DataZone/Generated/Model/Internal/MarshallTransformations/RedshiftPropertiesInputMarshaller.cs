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
    /// RedshiftPropertiesInput Marshaller
    /// </summary>
    public class RedshiftPropertiesInputMarshaller : IRequestMarshaller<RedshiftPropertiesInput, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RedshiftPropertiesInput requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCredentials())
            {
                context.Writer.WritePropertyName("credentials");
                context.Writer.WriteStartObject();

                var marshaller = RedshiftCredentialsMarshaller.Instance;
                marshaller.Marshall(requestObject.Credentials, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDatabaseName())
            {
                context.Writer.WritePropertyName("databaseName");
                context.Writer.WriteStringValue(requestObject.DatabaseName);
            }

            if(requestObject.IsSetHost())
            {
                context.Writer.WritePropertyName("host");
                context.Writer.WriteStringValue(requestObject.Host);
            }

            if(requestObject.IsSetLineageSync())
            {
                context.Writer.WritePropertyName("lineageSync");
                context.Writer.WriteStartObject();

                var marshaller = RedshiftLineageSyncConfigurationInputMarshaller.Instance;
                marshaller.Marshall(requestObject.LineageSync, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPort())
            {
                context.Writer.WritePropertyName("port");
                context.Writer.WriteNumberValue(requestObject.Port.Value);
            }

            if(requestObject.IsSetStorage())
            {
                context.Writer.WritePropertyName("storage");
                context.Writer.WriteStartObject();

                var marshaller = RedshiftStoragePropertiesMarshaller.Instance;
                marshaller.Marshall(requestObject.Storage, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RedshiftPropertiesInputMarshaller Instance = new RedshiftPropertiesInputMarshaller();

    }
}