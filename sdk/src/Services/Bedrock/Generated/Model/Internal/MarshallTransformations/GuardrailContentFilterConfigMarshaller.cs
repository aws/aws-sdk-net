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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Bedrock.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Bedrock.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GuardrailContentFilterConfig Marshaller
    /// </summary>
    public class GuardrailContentFilterConfigMarshaller : IRequestMarshaller<GuardrailContentFilterConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(GuardrailContentFilterConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetInputModalities())
            {
                context.Writer.WritePropertyName("inputModalities");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectInputModalitiesListValue in requestObject.InputModalities)
                {
                        context.Writer.Write(requestObjectInputModalitiesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetInputStrength())
            {
                context.Writer.WritePropertyName("inputStrength");
                context.Writer.Write(requestObject.InputStrength);
            }

            if(requestObject.IsSetOutputModalities())
            {
                context.Writer.WritePropertyName("outputModalities");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectOutputModalitiesListValue in requestObject.OutputModalities)
                {
                        context.Writer.Write(requestObjectOutputModalitiesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetOutputStrength())
            {
                context.Writer.WritePropertyName("outputStrength");
                context.Writer.Write(requestObject.OutputStrength);
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("type");
                context.Writer.Write(requestObject.Type);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static GuardrailContentFilterConfigMarshaller Instance = new GuardrailContentFilterConfigMarshaller();

    }
}