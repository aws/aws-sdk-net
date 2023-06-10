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
 * Do not modify this file. This file is generated from the timestream-write-2018-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.TimestreamWrite.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.TimestreamWrite.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// MultiMeasureMappings Marshaller
    /// </summary>
    public class MultiMeasureMappingsMarshaller : IRequestMarshaller<MultiMeasureMappings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(MultiMeasureMappings requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetMultiMeasureAttributeMappings())
            {
                context.Writer.WritePropertyName("MultiMeasureAttributeMappings");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectMultiMeasureAttributeMappingsListValue in requestObject.MultiMeasureAttributeMappings)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = MultiMeasureAttributeMappingMarshaller.Instance;
                    marshaller.Marshall(requestObjectMultiMeasureAttributeMappingsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetTargetMultiMeasureName())
            {
                context.Writer.WritePropertyName("TargetMultiMeasureName");
                context.Writer.Write(requestObject.TargetMultiMeasureName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static MultiMeasureMappingsMarshaller Instance = new MultiMeasureMappingsMarshaller();

    }
}