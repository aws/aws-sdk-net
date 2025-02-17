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
 * Do not modify this file. This file is generated from the iot-jobs-data-2017-09-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTJobsDataPlane.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.IoTJobsDataPlane.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CommandParameterValue Marshaller
    /// </summary>
    public class CommandParameterValueMarshaller : IRequestMarshaller<CommandParameterValue, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CommandParameterValue requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetB())
            {
                context.Writer.WritePropertyName("B");
                context.Writer.Write(requestObject.B);
            }

            if(requestObject.IsSetBIN())
            {
                context.Writer.WritePropertyName("BIN");
                context.Writer.Write(StringUtils.FromMemoryStream(requestObject.BIN));
            }

            if(requestObject.IsSetD())
            {
                context.Writer.WritePropertyName("D");
                if(StringUtils.IsSpecialDoubleValue(requestObject.D))
                {
                    context.Writer.Write(StringUtils.FromSpecialDoubleValue(requestObject.D));
                }
                else
                {
                    context.Writer.Write(requestObject.D);
                }
            }

            if(requestObject.IsSetI())
            {
                context.Writer.WritePropertyName("I");
                context.Writer.Write(requestObject.I);
            }

            if(requestObject.IsSetL())
            {
                context.Writer.WritePropertyName("L");
                context.Writer.Write(requestObject.L);
            }

            if(requestObject.IsSetS())
            {
                context.Writer.WritePropertyName("S");
                context.Writer.Write(requestObject.S);
            }

            if(requestObject.IsSetUL())
            {
                context.Writer.WritePropertyName("UL");
                context.Writer.Write(requestObject.UL);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CommandParameterValueMarshaller Instance = new CommandParameterValueMarshaller();

    }
}