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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Pinpoint.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Pinpoint.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CustomMessageActivity Marshaller
    /// </summary>       
    public class CustomMessageActivityMarshaller : IRequestMarshaller<CustomMessageActivity, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CustomMessageActivity requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDeliveryUri())
            {
                context.Writer.WritePropertyName("DeliveryUri");
                context.Writer.Write(requestObject.DeliveryUri);
            }

            if(requestObject.IsSetEndpointTypes())
            {
                context.Writer.WritePropertyName("EndpointTypes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectEndpointTypesListValue in requestObject.EndpointTypes)
                {
                        context.Writer.Write(requestObjectEndpointTypesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetMessageConfig())
            {
                context.Writer.WritePropertyName("MessageConfig");
                context.Writer.WriteObjectStart();

                var marshaller = JourneyCustomMessageMarshaller.Instance;
                marshaller.Marshall(requestObject.MessageConfig, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetNextActivity())
            {
                context.Writer.WritePropertyName("NextActivity");
                context.Writer.Write(requestObject.NextActivity);
            }

            if(requestObject.IsSetTemplateName())
            {
                context.Writer.WritePropertyName("TemplateName");
                context.Writer.Write(requestObject.TemplateName);
            }

            if(requestObject.IsSetTemplateVersion())
            {
                context.Writer.WritePropertyName("TemplateVersion");
                context.Writer.Write(requestObject.TemplateVersion);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static CustomMessageActivityMarshaller Instance = new CustomMessageActivityMarshaller();

    }
}