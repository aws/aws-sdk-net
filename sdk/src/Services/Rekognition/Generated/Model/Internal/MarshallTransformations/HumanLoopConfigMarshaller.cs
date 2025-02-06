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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Rekognition.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Rekognition.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// HumanLoopConfig Marshaller
    /// </summary>
    public class HumanLoopConfigMarshaller : IRequestMarshaller<HumanLoopConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(HumanLoopConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDataAttributes())
            {
                context.Writer.WritePropertyName("DataAttributes");
                context.Writer.WriteStartObject();

                var marshaller = HumanLoopDataAttributesMarshaller.Instance;
                marshaller.Marshall(requestObject.DataAttributes, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFlowDefinitionArn())
            {
                context.Writer.WritePropertyName("FlowDefinitionArn");
                context.Writer.WriteStringValue(requestObject.FlowDefinitionArn);
            }

            if(requestObject.IsSetHumanLoopName())
            {
                context.Writer.WritePropertyName("HumanLoopName");
                context.Writer.WriteStringValue(requestObject.HumanLoopName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static HumanLoopConfigMarshaller Instance = new HumanLoopConfigMarshaller();

    }
}