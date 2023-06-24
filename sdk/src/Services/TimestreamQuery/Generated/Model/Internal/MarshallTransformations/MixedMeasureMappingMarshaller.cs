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
 * Do not modify this file. This file is generated from the timestream-query-2018-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.TimestreamQuery.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.TimestreamQuery.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// MixedMeasureMapping Marshaller
    /// </summary>
    public class MixedMeasureMappingMarshaller : IRequestMarshaller<MixedMeasureMapping, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(MixedMeasureMapping requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetMeasureName())
            {
                context.Writer.WritePropertyName("MeasureName");
                context.Writer.Write(requestObject.MeasureName);
            }

            if(requestObject.IsSetMeasureValueType())
            {
                context.Writer.WritePropertyName("MeasureValueType");
                context.Writer.Write(requestObject.MeasureValueType);
            }

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

            if(requestObject.IsSetSourceColumn())
            {
                context.Writer.WritePropertyName("SourceColumn");
                context.Writer.Write(requestObject.SourceColumn);
            }

            if(requestObject.IsSetTargetMeasureName())
            {
                context.Writer.WritePropertyName("TargetMeasureName");
                context.Writer.Write(requestObject.TargetMeasureName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static MixedMeasureMappingMarshaller Instance = new MixedMeasureMappingMarshaller();

    }
}