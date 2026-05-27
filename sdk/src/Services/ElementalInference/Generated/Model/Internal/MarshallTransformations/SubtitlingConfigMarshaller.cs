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
 * Do not modify this file. This file is generated from the elementalinference-2018-11-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElementalInference.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ElementalInference.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SubtitlingConfig Marshaller
    /// </summary>
    public class SubtitlingConfigMarshaller : IRequestMarshaller<SubtitlingConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SubtitlingConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAspectRatio())
            {
                context.Writer.WritePropertyName("aspectRatio");
                context.Writer.WriteStartObject();

                var marshaller = AspectRatioMarshaller.Instance;
                marshaller.Marshall(requestObject.AspectRatio, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDictionary())
            {
                context.Writer.WritePropertyName("dictionary");
                context.Writer.WriteStringValue(requestObject.Dictionary);
            }

            if(requestObject.IsSetLanguage())
            {
                context.Writer.WritePropertyName("language");
                context.Writer.WriteStringValue(requestObject.Language);
            }

            if(requestObject.IsSetProfanityFilter())
            {
                context.Writer.WritePropertyName("profanityFilter");
                context.Writer.WriteStringValue(requestObject.ProfanityFilter);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SubtitlingConfigMarshaller Instance = new SubtitlingConfigMarshaller();

    }
}