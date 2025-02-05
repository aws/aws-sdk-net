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
 * Do not modify this file. This file is generated from the ivs-2020-07-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IVS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.IVS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ThumbnailConfiguration Marshaller
    /// </summary>
    public class ThumbnailConfigurationMarshaller : IRequestMarshaller<ThumbnailConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ThumbnailConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetRecordingMode())
            {
                context.Writer.WritePropertyName("recordingMode");
                context.Writer.WriteStringValue(requestObject.RecordingMode);
            }

            if(requestObject.IsSetResolution())
            {
                context.Writer.WritePropertyName("resolution");
                context.Writer.WriteStringValue(requestObject.Resolution);
            }

            if(requestObject.IsSetStorage())
            {
                context.Writer.WritePropertyName("storage");
                context.Writer.WriteStartArray();
                foreach(var requestObjectStorageListValue in requestObject.Storage)
                {
                        context.Writer.WriteStringValue(requestObjectStorageListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetTargetIntervalSeconds())
            {
                context.Writer.WritePropertyName("targetIntervalSeconds");
                context.Writer.WriteNumberValue(requestObject.TargetIntervalSeconds.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ThumbnailConfigurationMarshaller Instance = new ThumbnailConfigurationMarshaller();

    }
}