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
 * Do not modify this file. This file is generated from the bedrock-data-automation-2023-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockDataAutomation.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockDataAutomation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ModalityRoutingConfiguration Marshaller
    /// </summary>
    public class ModalityRoutingConfigurationMarshaller : IRequestMarshaller<ModalityRoutingConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ModalityRoutingConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetJpeg())
            {
                context.Writer.WritePropertyName("jpeg");
                context.Writer.WriteStringValue(requestObject.Jpeg);
            }

            if(requestObject.IsSetMov())
            {
                context.Writer.WritePropertyName("mov");
                context.Writer.WriteStringValue(requestObject.Mov);
            }

            if(requestObject.IsSetMp4())
            {
                context.Writer.WritePropertyName("mp4");
                context.Writer.WriteStringValue(requestObject.Mp4);
            }

            if(requestObject.IsSetPng())
            {
                context.Writer.WritePropertyName("png");
                context.Writer.WriteStringValue(requestObject.Png);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ModalityRoutingConfigurationMarshaller Instance = new ModalityRoutingConfigurationMarshaller();

    }
}