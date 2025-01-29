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
 * Do not modify this file. This file is generated from the dlm-2018-01-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DLM.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.DLM.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Exclusions Marshaller
    /// </summary>
    public class ExclusionsMarshaller : IRequestMarshaller<Exclusions, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Exclusions requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetExcludeBootVolumes())
            {
                context.Writer.WritePropertyName("ExcludeBootVolumes");
                context.Writer.WriteBooleanValue(requestObject.ExcludeBootVolumes.Value);
            }

            if(requestObject.IsSetExcludeTags())
            {
                context.Writer.WritePropertyName("ExcludeTags");
                context.Writer.WriteStartArray();
                foreach(var requestObjectExcludeTagsListValue in requestObject.ExcludeTags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(requestObjectExcludeTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetExcludeVolumeTypes())
            {
                context.Writer.WritePropertyName("ExcludeVolumeTypes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectExcludeVolumeTypesListValue in requestObject.ExcludeVolumeTypes)
                {
                        context.Writer.WriteStringValue(requestObjectExcludeVolumeTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ExclusionsMarshaller Instance = new ExclusionsMarshaller();

    }
}