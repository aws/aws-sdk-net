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
 * Do not modify this file. This file is generated from the amplifyuibuilder-2021-08-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AmplifyUIBuilder.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.AmplifyUIBuilder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartCodegenJobData Marshaller
    /// </summary>
    public class StartCodegenJobDataMarshaller : IRequestMarshaller<StartCodegenJobData, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(StartCodegenJobData requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAutoGenerateForms())
            {
                context.Writer.WritePropertyName("autoGenerateForms");
                context.Writer.WriteBooleanValue(requestObject.AutoGenerateForms.Value);
            }

            if(requestObject.IsSetFeatures())
            {
                context.Writer.WritePropertyName("features");
                context.Writer.WriteStartObject();

                var marshaller = CodegenFeatureFlagsMarshaller.Instance;
                marshaller.Marshall(requestObject.Features, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetGenericDataSchema())
            {
                context.Writer.WritePropertyName("genericDataSchema");
                context.Writer.WriteStartObject();

                var marshaller = CodegenJobGenericDataSchemaMarshaller.Instance;
                marshaller.Marshall(requestObject.GenericDataSchema, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRenderConfig())
            {
                context.Writer.WritePropertyName("renderConfig");
                context.Writer.WriteStartObject();

                var marshaller = CodegenJobRenderConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.RenderConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
                context.Writer.WriteStartObject();
                foreach (var requestObjectTagsKvp in requestObject.Tags)
                {
                    context.Writer.WritePropertyName(requestObjectTagsKvp.Key);
                    var requestObjectTagsValue = requestObjectTagsKvp.Value;

                        context.Writer.WriteStringValue(requestObjectTagsValue);
                }
                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static StartCodegenJobDataMarshaller Instance = new StartCodegenJobDataMarshaller();

    }
}