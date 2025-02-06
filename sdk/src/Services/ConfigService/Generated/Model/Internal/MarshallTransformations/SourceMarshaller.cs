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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ConfigService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ConfigService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Source Marshaller
    /// </summary>
    public class SourceMarshaller : IRequestMarshaller<Source, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Source requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCustomPolicyDetails())
            {
                context.Writer.WritePropertyName("CustomPolicyDetails");
                context.Writer.WriteStartObject();

                var marshaller = CustomPolicyDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.CustomPolicyDetails, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetOwner())
            {
                context.Writer.WritePropertyName("Owner");
                context.Writer.WriteStringValue(requestObject.Owner);
            }

            if(requestObject.IsSetSourceDetails())
            {
                context.Writer.WritePropertyName("SourceDetails");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSourceDetailsListValue in requestObject.SourceDetails)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = SourceDetailMarshaller.Instance;
                    marshaller.Marshall(requestObjectSourceDetailsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSourceIdentifier())
            {
                context.Writer.WritePropertyName("SourceIdentifier");
                context.Writer.WriteStringValue(requestObject.SourceIdentifier);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SourceMarshaller Instance = new SourceMarshaller();

    }
}