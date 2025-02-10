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
 * Do not modify this file. This file is generated from the supplychain-2024-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SupplyChain.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SupplyChain.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DataIntegrationFlowSource Marshaller
    /// </summary>
    public class DataIntegrationFlowSourceMarshaller : IRequestMarshaller<DataIntegrationFlowSource, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DataIntegrationFlowSource requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDatasetSource())
            {
                context.Writer.WritePropertyName("datasetSource");
                context.Writer.WriteStartObject();

                var marshaller = DataIntegrationFlowDatasetSourceConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.DatasetSource, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetS3Source())
            {
                context.Writer.WritePropertyName("s3Source");
                context.Writer.WriteStartObject();

                var marshaller = DataIntegrationFlowS3SourceConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.S3Source, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSourceName())
            {
                context.Writer.WritePropertyName("sourceName");
                context.Writer.WriteStringValue(requestObject.SourceName);
            }

            if(requestObject.IsSetSourceType())
            {
                context.Writer.WritePropertyName("sourceType");
                context.Writer.WriteStringValue(requestObject.SourceType);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DataIntegrationFlowSourceMarshaller Instance = new DataIntegrationFlowSourceMarshaller();

    }
}