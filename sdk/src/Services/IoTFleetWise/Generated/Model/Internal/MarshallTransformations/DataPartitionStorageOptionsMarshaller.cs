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
 * Do not modify this file. This file is generated from the iotfleetwise-2021-06-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTFleetWise.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.IoTFleetWise.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DataPartitionStorageOptions Marshaller
    /// </summary>
    public class DataPartitionStorageOptionsMarshaller : IRequestMarshaller<DataPartitionStorageOptions, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DataPartitionStorageOptions requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetMaximumSize())
            {
                context.Writer.WritePropertyName("maximumSize");
                context.Writer.WriteStartObject();

                var marshaller = StorageMaximumSizeMarshaller.Instance;
                marshaller.Marshall(requestObject.MaximumSize, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMinimumTimeToLive())
            {
                context.Writer.WritePropertyName("minimumTimeToLive");
                context.Writer.WriteStartObject();

                var marshaller = StorageMinimumTimeToLiveMarshaller.Instance;
                marshaller.Marshall(requestObject.MinimumTimeToLive, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetStorageLocation())
            {
                context.Writer.WritePropertyName("storageLocation");
                context.Writer.WriteStringValue(requestObject.StorageLocation);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DataPartitionStorageOptionsMarshaller Instance = new DataPartitionStorageOptionsMarshaller();

    }
}