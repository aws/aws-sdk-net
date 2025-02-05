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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Imagebuilder.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Imagebuilder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// InstanceConfiguration Marshaller
    /// </summary>
    public class InstanceConfigurationMarshaller : IRequestMarshaller<InstanceConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(InstanceConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBlockDeviceMappings())
            {
                context.Writer.WritePropertyName("blockDeviceMappings");
                context.Writer.WriteStartArray();
                foreach(var requestObjectBlockDeviceMappingsListValue in requestObject.BlockDeviceMappings)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = InstanceBlockDeviceMappingMarshaller.Instance;
                    marshaller.Marshall(requestObjectBlockDeviceMappingsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetImage())
            {
                context.Writer.WritePropertyName("image");
                context.Writer.WriteStringValue(requestObject.Image);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static InstanceConfigurationMarshaller Instance = new InstanceConfigurationMarshaller();

    }
}