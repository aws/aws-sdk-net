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
 * Do not modify this file. This file is generated from the lookoutvision-2020-11-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LookoutforVision.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.LookoutforVision.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GreengrassConfiguration Marshaller
    /// </summary>
    public class GreengrassConfigurationMarshaller : IRequestMarshaller<GreengrassConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(GreengrassConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCompilerOptions())
            {
                context.Writer.WritePropertyName("CompilerOptions");
                context.Writer.Write(requestObject.CompilerOptions);
            }

            if(requestObject.IsSetComponentDescription())
            {
                context.Writer.WritePropertyName("ComponentDescription");
                context.Writer.Write(requestObject.ComponentDescription);
            }

            if(requestObject.IsSetComponentName())
            {
                context.Writer.WritePropertyName("ComponentName");
                context.Writer.Write(requestObject.ComponentName);
            }

            if(requestObject.IsSetComponentVersion())
            {
                context.Writer.WritePropertyName("ComponentVersion");
                context.Writer.Write(requestObject.ComponentVersion);
            }

            if(requestObject.IsSetS3OutputLocation())
            {
                context.Writer.WritePropertyName("S3OutputLocation");
                context.Writer.WriteObjectStart();

                var marshaller = S3LocationMarshaller.Instance;
                marshaller.Marshall(requestObject.S3OutputLocation, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectTagsListValue in requestObject.Tags)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(requestObjectTagsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetTargetDevice())
            {
                context.Writer.WritePropertyName("TargetDevice");
                context.Writer.Write(requestObject.TargetDevice);
            }

            if(requestObject.IsSetTargetPlatform())
            {
                context.Writer.WritePropertyName("TargetPlatform");
                context.Writer.WriteObjectStart();

                var marshaller = TargetPlatformMarshaller.Instance;
                marshaller.Marshall(requestObject.TargetPlatform, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static GreengrassConfigurationMarshaller Instance = new GreengrassConfigurationMarshaller();

    }
}