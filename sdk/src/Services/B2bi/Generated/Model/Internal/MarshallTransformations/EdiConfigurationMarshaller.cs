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
 * Do not modify this file. This file is generated from the b2bi-2022-06-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.B2bi.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.B2bi.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EdiConfiguration Marshaller
    /// </summary>
    public class EdiConfigurationMarshaller : IRequestMarshaller<EdiConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(EdiConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCapabilityDirection())
            {
                context.Writer.WritePropertyName("capabilityDirection");
                context.Writer.WriteStringValue(requestObject.CapabilityDirection);
            }

            if(requestObject.IsSetInputLocation())
            {
                context.Writer.WritePropertyName("inputLocation");
                context.Writer.WriteStartObject();

                var marshaller = S3LocationMarshaller.Instance;
                marshaller.Marshall(requestObject.InputLocation, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetOutputLocation())
            {
                context.Writer.WritePropertyName("outputLocation");
                context.Writer.WriteStartObject();

                var marshaller = S3LocationMarshaller.Instance;
                marshaller.Marshall(requestObject.OutputLocation, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTransformerId())
            {
                context.Writer.WritePropertyName("transformerId");
                context.Writer.WriteStringValue(requestObject.TransformerId);
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("type");
                context.Writer.WriteStartObject();

                var marshaller = EdiTypeMarshaller.Instance;
                marshaller.Marshall(requestObject.Type, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static EdiConfigurationMarshaller Instance = new EdiConfigurationMarshaller();

    }
}