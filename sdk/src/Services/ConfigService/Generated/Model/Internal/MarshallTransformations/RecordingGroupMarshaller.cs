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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ConfigService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ConfigService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RecordingGroup Marshaller
    /// </summary>
    public class RecordingGroupMarshaller : IRequestMarshaller<RecordingGroup, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RecordingGroup requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAllSupported())
            {
                context.Writer.WritePropertyName("allSupported");
                context.Writer.WriteBooleanValue(requestObject.AllSupported.Value);
            }

            if(requestObject.IsSetExclusionByResourceTypes())
            {
                context.Writer.WritePropertyName("exclusionByResourceTypes");
                context.Writer.WriteStartObject();

                var marshaller = ExclusionByResourceTypesMarshaller.Instance;
                marshaller.Marshall(requestObject.ExclusionByResourceTypes, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetIncludeGlobalResourceTypes())
            {
                context.Writer.WritePropertyName("includeGlobalResourceTypes");
                context.Writer.WriteBooleanValue(requestObject.IncludeGlobalResourceTypes.Value);
            }

            if(requestObject.IsSetRecordingStrategy())
            {
                context.Writer.WritePropertyName("recordingStrategy");
                context.Writer.WriteStartObject();

                var marshaller = RecordingStrategyMarshaller.Instance;
                marshaller.Marshall(requestObject.RecordingStrategy, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetResourceTypes())
            {
                context.Writer.WritePropertyName("resourceTypes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectResourceTypesListValue in requestObject.ResourceTypes)
                {
                        context.Writer.WriteStringValue(requestObjectResourceTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RecordingGroupMarshaller Instance = new RecordingGroupMarshaller();

    }
}