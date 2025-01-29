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
 * Do not modify this file. This file is generated from the iotanalytics-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTAnalytics.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.IoTAnalytics.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DatastorePartition Marshaller
    /// </summary>
    public class DatastorePartitionMarshaller : IRequestMarshaller<DatastorePartition, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DatastorePartition requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAttributePartition())
            {
                context.Writer.WritePropertyName("attributePartition");
                context.Writer.WriteStartObject();

                var marshaller = PartitionMarshaller.Instance;
                marshaller.Marshall(requestObject.AttributePartition, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTimestampPartition())
            {
                context.Writer.WritePropertyName("timestampPartition");
                context.Writer.WriteStartObject();

                var marshaller = TimestampPartitionMarshaller.Instance;
                marshaller.Marshall(requestObject.TimestampPartition, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DatastorePartitionMarshaller Instance = new DatastorePartitionMarshaller();

    }
}