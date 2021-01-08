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
 * Do not modify this file. This file is generated from the kinesis-2013-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Kinesis.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutRecordsRequestEntry Marshaller
    /// </summary>       
    public class PutRecordsRequestEntryMarshaller : IRequestMarshaller<PutRecordsRequestEntry, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(PutRecordsRequestEntry requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetData())
            {
                context.Writer.WritePropertyName("Data");
                context.Writer.Write(StringUtils.FromMemoryStream(requestObject.Data));
            }

            if(requestObject.IsSetExplicitHashKey())
            {
                context.Writer.WritePropertyName("ExplicitHashKey");
                context.Writer.Write(requestObject.ExplicitHashKey);
            }

            if(requestObject.IsSetPartitionKey())
            {
                context.Writer.WritePropertyName("PartitionKey");
                context.Writer.Write(requestObject.PartitionKey);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static PutRecordsRequestEntryMarshaller Instance = new PutRecordsRequestEntryMarshaller();

    }
}