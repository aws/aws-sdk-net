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
    /// S3CatalogDeltaSource Marshaller
    /// </summary>
    public class S3CatalogDeltaSourceMarshaller : IRequestMarshaller<S3CatalogDeltaSource, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(S3CatalogDeltaSource requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAdditionalDeltaOptions())
            {
                context.Writer.WritePropertyName("AdditionalDeltaOptions");
                context.Writer.WriteStartObject();
                foreach (var requestObjectAdditionalDeltaOptionsKvp in requestObject.AdditionalDeltaOptions)
                {
                    context.Writer.WritePropertyName(requestObjectAdditionalDeltaOptionsKvp.Key);
                    var requestObjectAdditionalDeltaOptionsValue = requestObjectAdditionalDeltaOptionsKvp.Value;

                        context.Writer.WriteStringValue(requestObjectAdditionalDeltaOptionsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDatabase())
            {
                context.Writer.WritePropertyName("Database");
                context.Writer.WriteStringValue(requestObject.Database);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetOutputSchemas())
            {
                context.Writer.WritePropertyName("OutputSchemas");
                context.Writer.WriteStartArray();
                foreach(var requestObjectOutputSchemasListValue in requestObject.OutputSchemas)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = GlueSchemaMarshaller.Instance;
                    marshaller.Marshall(requestObjectOutputSchemasListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetTable())
            {
                context.Writer.WritePropertyName("Table");
                context.Writer.WriteStringValue(requestObject.Table);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static S3CatalogDeltaSourceMarshaller Instance = new S3CatalogDeltaSourceMarshaller();

    }
}