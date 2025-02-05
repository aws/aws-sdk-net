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
 * Do not modify this file. This file is generated from the amplifybackend-2020-08-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AmplifyBackend.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.AmplifyBackend.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BackendAPIResourceConfig Marshaller
    /// </summary>
    public class BackendAPIResourceConfigMarshaller : IRequestMarshaller<BackendAPIResourceConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(BackendAPIResourceConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAdditionalAuthTypes())
            {
                context.Writer.WritePropertyName("additionalAuthTypes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAdditionalAuthTypesListValue in requestObject.AdditionalAuthTypes)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = BackendAPIAuthTypeMarshaller.Instance;
                    marshaller.Marshall(requestObjectAdditionalAuthTypesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetApiName())
            {
                context.Writer.WritePropertyName("apiName");
                context.Writer.WriteStringValue(requestObject.ApiName);
            }

            if(requestObject.IsSetConflictResolution())
            {
                context.Writer.WritePropertyName("conflictResolution");
                context.Writer.WriteStartObject();

                var marshaller = BackendAPIConflictResolutionMarshaller.Instance;
                marshaller.Marshall(requestObject.ConflictResolution, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDefaultAuthType())
            {
                context.Writer.WritePropertyName("defaultAuthType");
                context.Writer.WriteStartObject();

                var marshaller = BackendAPIAuthTypeMarshaller.Instance;
                marshaller.Marshall(requestObject.DefaultAuthType, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetService())
            {
                context.Writer.WritePropertyName("service");
                context.Writer.WriteStringValue(requestObject.Service);
            }

            if(requestObject.IsSetTransformSchema())
            {
                context.Writer.WritePropertyName("transformSchema");
                context.Writer.WriteStringValue(requestObject.TransformSchema);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static BackendAPIResourceConfigMarshaller Instance = new BackendAPIResourceConfigMarshaller();

    }
}