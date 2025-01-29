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
 * Do not modify this file. This file is generated from the iotfleetwise-2021-06-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTFleetWise.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.IoTFleetWise.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StructuredMessageListDefinition Marshaller
    /// </summary>
    public class StructuredMessageListDefinitionMarshaller : IRequestMarshaller<StructuredMessageListDefinition, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(StructuredMessageListDefinition requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCapacity())
            {
                context.Writer.WritePropertyName("capacity");
                context.Writer.WriteNumberValue(requestObject.Capacity.Value);
            }

            if(requestObject.IsSetListType())
            {
                context.Writer.WritePropertyName("listType");
                context.Writer.WriteStringValue(requestObject.ListType);
            }

            if(requestObject.IsSetMemberType())
            {
                context.Writer.WritePropertyName("memberType");
                context.Writer.WriteStartObject();

                var marshaller = StructuredMessageMarshaller.Instance;
                marshaller.Marshall(requestObject.MemberType, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static StructuredMessageListDefinitionMarshaller Instance = new StructuredMessageListDefinitionMarshaller();

    }
}