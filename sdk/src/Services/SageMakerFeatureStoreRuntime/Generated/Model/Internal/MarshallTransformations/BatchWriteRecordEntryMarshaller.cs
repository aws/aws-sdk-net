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
 * Do not modify this file. This file is generated from the sagemaker-featurestore-runtime-2020-07-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMakerFeatureStoreRuntime.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SageMakerFeatureStoreRuntime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BatchWriteRecordEntry Marshaller
    /// </summary>
    public class BatchWriteRecordEntryMarshaller : IRequestMarshaller<BatchWriteRecordEntry, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(BatchWriteRecordEntry requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetFeatureGroupName())
            {
                context.Writer.WritePropertyName("FeatureGroupName");
                context.Writer.WriteStringValue(requestObject.FeatureGroupName);
            }

            if(requestObject.IsSetRecord())
            {
                context.Writer.WritePropertyName("Record");
                context.Writer.WriteStartArray();
                foreach(var requestObjectRecordListValue in requestObject.Record)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = FeatureValueMarshaller.Instance;
                    marshaller.Marshall(requestObjectRecordListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetTargetStores())
            {
                context.Writer.WritePropertyName("TargetStores");
                context.Writer.WriteStartArray();
                foreach(var requestObjectTargetStoresListValue in requestObject.TargetStores)
                {
                        context.Writer.WriteStringValue(requestObjectTargetStoresListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetTtlDuration())
            {
                context.Writer.WritePropertyName("TtlDuration");
                context.Writer.WriteStartObject();

                var marshaller = TtlDurationMarshaller.Instance;
                marshaller.Marshall(requestObject.TtlDuration, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static BatchWriteRecordEntryMarshaller Instance = new BatchWriteRecordEntryMarshaller();

    }
}