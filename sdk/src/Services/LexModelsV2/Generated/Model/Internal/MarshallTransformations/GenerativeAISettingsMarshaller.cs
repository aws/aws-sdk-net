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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LexModelsV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.LexModelsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GenerativeAISettings Marshaller
    /// </summary>
    public class GenerativeAISettingsMarshaller : IRequestMarshaller<GenerativeAISettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(GenerativeAISettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBuildtimeSettings())
            {
                context.Writer.WritePropertyName("buildtimeSettings");
                context.Writer.WriteStartObject();

                var marshaller = BuildtimeSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.BuildtimeSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRuntimeSettings())
            {
                context.Writer.WritePropertyName("runtimeSettings");
                context.Writer.WriteStartObject();

                var marshaller = RuntimeSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.RuntimeSettings, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static GenerativeAISettingsMarshaller Instance = new GenerativeAISettingsMarshaller();

    }
}