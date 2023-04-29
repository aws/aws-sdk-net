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
    /// MultiMeasureAttributeMapping Marshaller
    /// </summary>
    public class MultiMeasureAttributeMappingMarshaller : IRequestMarshaller<MultiMeasureAttributeMapping, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(MultiMeasureAttributeMapping requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetMeasureValueType())
            {
                context.Writer.WritePropertyName("MeasureValueType");
                context.Writer.Write(requestObject.MeasureValueType);
            }

            if(requestObject.IsSetSourceColumn())
            {
                context.Writer.WritePropertyName("SourceColumn");
                context.Writer.Write(requestObject.SourceColumn);
            }

            if(requestObject.IsSetTargetMultiMeasureAttributeName())
            {
                context.Writer.WritePropertyName("TargetMultiMeasureAttributeName");
                context.Writer.Write(requestObject.TargetMultiMeasureAttributeName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static MultiMeasureAttributeMappingMarshaller Instance = new MultiMeasureAttributeMappingMarshaller();

    }
}