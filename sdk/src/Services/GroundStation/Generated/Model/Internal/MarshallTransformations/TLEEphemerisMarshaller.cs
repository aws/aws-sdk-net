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
 * Do not modify this file. This file is generated from the groundstation-2019-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.GroundStation.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.GroundStation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TLEEphemeris Marshaller
    /// </summary>
    public class TLEEphemerisMarshaller : IRequestMarshaller<TLEEphemeris, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TLEEphemeris requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetS3Object())
            {
                context.Writer.WritePropertyName("s3Object");
                context.Writer.WriteStartObject();

                var marshaller = S3ObjectMarshaller.Instance;
                marshaller.Marshall(requestObject.S3Object, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTleData())
            {
                context.Writer.WritePropertyName("tleData");
                context.Writer.WriteStartArray();
                foreach(var requestObjectTleDataListValue in requestObject.TleData)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TLEDataMarshaller.Instance;
                    marshaller.Marshall(requestObjectTleDataListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TLEEphemerisMarshaller Instance = new TLEEphemerisMarshaller();

    }
}