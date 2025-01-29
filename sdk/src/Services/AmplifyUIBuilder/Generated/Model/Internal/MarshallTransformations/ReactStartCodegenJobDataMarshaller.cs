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
    /// ReactStartCodegenJobData Marshaller
    /// </summary>
    public class ReactStartCodegenJobDataMarshaller : IRequestMarshaller<ReactStartCodegenJobData, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ReactStartCodegenJobData requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetApiConfiguration())
            {
                context.Writer.WritePropertyName("apiConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ApiConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ApiConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDependencies())
            {
                context.Writer.WritePropertyName("dependencies");
                context.Writer.WriteStartObject();
                foreach (var requestObjectDependenciesKvp in requestObject.Dependencies)
                {
                    context.Writer.WritePropertyName(requestObjectDependenciesKvp.Key);
                    var requestObjectDependenciesValue = requestObjectDependenciesKvp.Value;

                        context.Writer.WriteStringValue(requestObjectDependenciesValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetInlineSourceMap())
            {
                context.Writer.WritePropertyName("inlineSourceMap");
                context.Writer.WriteBooleanValue(requestObject.InlineSourceMap.Value);
            }

            if(requestObject.IsSetModule())
            {
                context.Writer.WritePropertyName("module");
                context.Writer.WriteStringValue(requestObject.Module);
            }

            if(requestObject.IsSetRenderTypeDeclarations())
            {
                context.Writer.WritePropertyName("renderTypeDeclarations");
                context.Writer.WriteBooleanValue(requestObject.RenderTypeDeclarations.Value);
            }

            if(requestObject.IsSetScript())
            {
                context.Writer.WritePropertyName("script");
                context.Writer.WriteStringValue(requestObject.Script);
            }

            if(requestObject.IsSetTarget())
            {
                context.Writer.WritePropertyName("target");
                context.Writer.WriteStringValue(requestObject.Target);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ReactStartCodegenJobDataMarshaller Instance = new ReactStartCodegenJobDataMarshaller();

    }
}