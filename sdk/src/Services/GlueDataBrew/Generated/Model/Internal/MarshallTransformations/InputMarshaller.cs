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
 * Do not modify this file. This file is generated from the databrew-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.GlueDataBrew.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.GlueDataBrew.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Input Marshaller
    /// </summary>
    public class InputMarshaller : IRequestMarshaller<Input, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Input requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDatabaseInputDefinition())
            {
                context.Writer.WritePropertyName("DatabaseInputDefinition");
                context.Writer.WriteStartObject();

                var marshaller = DatabaseInputDefinitionMarshaller.Instance;
                marshaller.Marshall(requestObject.DatabaseInputDefinition, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDataCatalogInputDefinition())
            {
                context.Writer.WritePropertyName("DataCatalogInputDefinition");
                context.Writer.WriteStartObject();

                var marshaller = DataCatalogInputDefinitionMarshaller.Instance;
                marshaller.Marshall(requestObject.DataCatalogInputDefinition, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMetadata())
            {
                context.Writer.WritePropertyName("Metadata");
                context.Writer.WriteStartObject();

                var marshaller = MetadataMarshaller.Instance;
                marshaller.Marshall(requestObject.Metadata, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetS3InputDefinition())
            {
                context.Writer.WritePropertyName("S3InputDefinition");
                context.Writer.WriteStartObject();

                var marshaller = S3LocationMarshaller.Instance;
                marshaller.Marshall(requestObject.S3InputDefinition, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static InputMarshaller Instance = new InputMarshaller();

    }
}