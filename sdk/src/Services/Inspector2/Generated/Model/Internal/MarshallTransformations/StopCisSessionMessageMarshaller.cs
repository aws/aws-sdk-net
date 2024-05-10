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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Inspector2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Inspector2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StopCisSessionMessage Marshaller
    /// </summary>
    public class StopCisSessionMessageMarshaller : IRequestMarshaller<StopCisSessionMessage, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(StopCisSessionMessage requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBenchmarkProfile())
            {
                context.Writer.WritePropertyName("benchmarkProfile");
                context.Writer.Write(requestObject.BenchmarkProfile);
            }

            if(requestObject.IsSetBenchmarkVersion())
            {
                context.Writer.WritePropertyName("benchmarkVersion");
                context.Writer.Write(requestObject.BenchmarkVersion);
            }

            if(requestObject.IsSetComputePlatform())
            {
                context.Writer.WritePropertyName("computePlatform");
                context.Writer.WriteObjectStart();

                var marshaller = ComputePlatformMarshaller.Instance;
                marshaller.Marshall(requestObject.ComputePlatform, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetProgress())
            {
                context.Writer.WritePropertyName("progress");
                context.Writer.WriteObjectStart();

                var marshaller = StopCisMessageProgressMarshaller.Instance;
                marshaller.Marshall(requestObject.Progress, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetReason())
            {
                context.Writer.WritePropertyName("reason");
                context.Writer.Write(requestObject.Reason);
            }

            if(requestObject.IsSetStatus())
            {
                context.Writer.WritePropertyName("status");
                context.Writer.Write(requestObject.Status);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static StopCisSessionMessageMarshaller Instance = new StopCisSessionMessageMarshaller();

    }
}