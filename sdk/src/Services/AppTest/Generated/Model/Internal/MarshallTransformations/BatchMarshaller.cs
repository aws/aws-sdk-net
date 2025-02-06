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
 * Do not modify this file. This file is generated from the apptest-2022-12-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppTest.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.AppTest.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Batch Marshaller
    /// </summary>
    public class BatchMarshaller : IRequestMarshaller<Batch, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Batch requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBatchJobName())
            {
                context.Writer.WritePropertyName("batchJobName");
                context.Writer.WriteStringValue(requestObject.BatchJobName);
            }

            if(requestObject.IsSetBatchJobParameters())
            {
                context.Writer.WritePropertyName("batchJobParameters");
                context.Writer.WriteStartObject();
                foreach (var requestObjectBatchJobParametersKvp in requestObject.BatchJobParameters)
                {
                    context.Writer.WritePropertyName(requestObjectBatchJobParametersKvp.Key);
                    var requestObjectBatchJobParametersValue = requestObjectBatchJobParametersKvp.Value;

                        context.Writer.WriteStringValue(requestObjectBatchJobParametersValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetExportDataSetNames())
            {
                context.Writer.WritePropertyName("exportDataSetNames");
                context.Writer.WriteStartArray();
                foreach(var requestObjectExportDataSetNamesListValue in requestObject.ExportDataSetNames)
                {
                        context.Writer.WriteStringValue(requestObjectExportDataSetNamesListValue);
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static BatchMarshaller Instance = new BatchMarshaller();

    }
}