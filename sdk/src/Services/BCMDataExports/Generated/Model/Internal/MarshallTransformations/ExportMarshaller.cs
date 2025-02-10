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
 * Do not modify this file. This file is generated from the bcm-data-exports-2023-11-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BCMDataExports.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.BCMDataExports.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Export Marshaller
    /// </summary>
    public class ExportMarshaller : IRequestMarshaller<Export, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Export requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDataQuery())
            {
                context.Writer.WritePropertyName("DataQuery");
                context.Writer.WriteStartObject();

                var marshaller = DataQueryMarshaller.Instance;
                marshaller.Marshall(requestObject.DataQuery, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(requestObject.Description);
            }

            if(requestObject.IsSetDestinationConfigurations())
            {
                context.Writer.WritePropertyName("DestinationConfigurations");
                context.Writer.WriteStartObject();

                var marshaller = DestinationConfigurationsMarshaller.Instance;
                marshaller.Marshall(requestObject.DestinationConfigurations, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetExportArn())
            {
                context.Writer.WritePropertyName("ExportArn");
                context.Writer.WriteStringValue(requestObject.ExportArn);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetRefreshCadence())
            {
                context.Writer.WritePropertyName("RefreshCadence");
                context.Writer.WriteStartObject();

                var marshaller = RefreshCadenceMarshaller.Instance;
                marshaller.Marshall(requestObject.RefreshCadence, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ExportMarshaller Instance = new ExportMarshaller();

    }
}