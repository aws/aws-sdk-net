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
 * Do not modify this file. This file is generated from the omics-2022-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Omics.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Omics.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// InlineSetting Marshaller
    /// </summary>
    public class InlineSettingMarshaller : IRequestMarshaller<InlineSetting, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(InlineSetting requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.Write(requestObject.Name);
            }

            if(requestObject.IsSetOutputBucketOwnerId())
            {
                context.Writer.WritePropertyName("outputBucketOwnerId");
                context.Writer.Write(requestObject.OutputBucketOwnerId);
            }

            if(requestObject.IsSetOutputUri())
            {
                context.Writer.WritePropertyName("outputUri");
                context.Writer.Write(requestObject.OutputUri);
            }

            if(requestObject.IsSetParameters())
            {
                context.Writer.WritePropertyName("parameters");
                Amazon.Runtime.Documents.Internal.Transform.DocumentMarshaller.Instance.Write(context.Writer, requestObject.Parameters);
            }

            if(requestObject.IsSetPriority())
            {
                context.Writer.WritePropertyName("priority");
                context.Writer.Write(requestObject.Priority);
            }

            if(requestObject.IsSetRunSettingId())
            {
                context.Writer.WritePropertyName("runSettingId");
                context.Writer.Write(requestObject.RunSettingId);
            }

            if(requestObject.IsSetRunTags())
            {
                context.Writer.WritePropertyName("runTags");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectRunTagsKvp in requestObject.RunTags)
                {
                    context.Writer.WritePropertyName(requestObjectRunTagsKvp.Key);
                    var requestObjectRunTagsValue = requestObjectRunTagsKvp.Value;

                        context.Writer.Write(requestObjectRunTagsValue);
                }
                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static InlineSettingMarshaller Instance = new InlineSettingMarshaller();

    }
}