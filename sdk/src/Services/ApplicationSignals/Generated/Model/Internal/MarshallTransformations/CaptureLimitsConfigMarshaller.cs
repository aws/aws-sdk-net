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
 * Do not modify this file. This file is generated from the application-signals-2024-04-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ApplicationSignals.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ApplicationSignals.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CaptureLimitsConfig Marshaller
    /// </summary>
    public class CaptureLimitsConfigMarshaller : IRequestMarshaller<CaptureLimitsConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CaptureLimitsConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetMaxCollectionDepth())
            {
                context.Writer.WritePropertyName("MaxCollectionDepth");
                context.Writer.WriteNumberValue(requestObject.MaxCollectionDepth.Value);
            }

            if(requestObject.IsSetMaxCollectionWidth())
            {
                context.Writer.WritePropertyName("MaxCollectionWidth");
                context.Writer.WriteNumberValue(requestObject.MaxCollectionWidth.Value);
            }

            if(requestObject.IsSetMaxFieldsPerObject())
            {
                context.Writer.WritePropertyName("MaxFieldsPerObject");
                context.Writer.WriteNumberValue(requestObject.MaxFieldsPerObject.Value);
            }

            if(requestObject.IsSetMaxHits())
            {
                context.Writer.WritePropertyName("MaxHits");
                context.Writer.WriteNumberValue(requestObject.MaxHits.Value);
            }

            if(requestObject.IsSetMaxObjectDepth())
            {
                context.Writer.WritePropertyName("MaxObjectDepth");
                context.Writer.WriteNumberValue(requestObject.MaxObjectDepth.Value);
            }

            if(requestObject.IsSetMaxStackFrames())
            {
                context.Writer.WritePropertyName("MaxStackFrames");
                context.Writer.WriteNumberValue(requestObject.MaxStackFrames.Value);
            }

            if(requestObject.IsSetMaxStackTraceSize())
            {
                context.Writer.WritePropertyName("MaxStackTraceSize");
                context.Writer.WriteNumberValue(requestObject.MaxStackTraceSize.Value);
            }

            if(requestObject.IsSetMaxStringLength())
            {
                context.Writer.WritePropertyName("MaxStringLength");
                context.Writer.WriteNumberValue(requestObject.MaxStringLength.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CaptureLimitsConfigMarshaller Instance = new CaptureLimitsConfigMarshaller();

    }
}