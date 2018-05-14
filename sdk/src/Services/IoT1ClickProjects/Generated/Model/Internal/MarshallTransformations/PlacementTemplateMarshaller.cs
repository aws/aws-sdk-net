/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the iot1click-projects-2018-05-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoT1ClickProjects.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoT1ClickProjects.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PlacementTemplate Marshaller
    /// </summary>       
    public class PlacementTemplateMarshaller : IRequestMarshaller<PlacementTemplate, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(PlacementTemplate requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDefaultAttributes())
            {
                context.Writer.WritePropertyName("defaultAttributes");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectDefaultAttributesKvp in requestObject.DefaultAttributes)
                {
                    context.Writer.WritePropertyName(requestObjectDefaultAttributesKvp.Key);
                    var requestObjectDefaultAttributesValue = requestObjectDefaultAttributesKvp.Value;

                        context.Writer.Write(requestObjectDefaultAttributesValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDeviceTemplates())
            {
                context.Writer.WritePropertyName("deviceTemplates");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectDeviceTemplatesKvp in requestObject.DeviceTemplates)
                {
                    context.Writer.WritePropertyName(requestObjectDeviceTemplatesKvp.Key);
                    var requestObjectDeviceTemplatesValue = requestObjectDeviceTemplatesKvp.Value;

                    context.Writer.WriteObjectStart();

                    var marshaller = DeviceTemplateMarshaller.Instance;
                    marshaller.Marshall(requestObjectDeviceTemplatesValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static PlacementTemplateMarshaller Instance = new PlacementTemplateMarshaller();

    }
}