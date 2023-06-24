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
    /// InAppMessageContent Marshaller
    /// </summary>
    public class InAppMessageContentMarshaller : IRequestMarshaller<InAppMessageContent, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(InAppMessageContent requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetBackgroundColor())
            {
                context.Writer.WritePropertyName("BackgroundColor");
                context.Writer.Write(requestObject.BackgroundColor);
            }

            if(requestObject.IsSetBodyConfig())
            {
                context.Writer.WritePropertyName("BodyConfig");
                context.Writer.WriteObjectStart();

                var marshaller = InAppMessageBodyConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.BodyConfig, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetHeaderConfig())
            {
                context.Writer.WritePropertyName("HeaderConfig");
                context.Writer.WriteObjectStart();

                var marshaller = InAppMessageHeaderConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.HeaderConfig, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetImageUrl())
            {
                context.Writer.WritePropertyName("ImageUrl");
                context.Writer.Write(requestObject.ImageUrl);
            }

            if(requestObject.IsSetPrimaryBtn())
            {
                context.Writer.WritePropertyName("PrimaryBtn");
                context.Writer.WriteObjectStart();

                var marshaller = InAppMessageButtonMarshaller.Instance;
                marshaller.Marshall(requestObject.PrimaryBtn, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSecondaryBtn())
            {
                context.Writer.WritePropertyName("SecondaryBtn");
                context.Writer.WriteObjectStart();

                var marshaller = InAppMessageButtonMarshaller.Instance;
                marshaller.Marshall(requestObject.SecondaryBtn, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static InAppMessageContentMarshaller Instance = new InAppMessageContentMarshaller();

    }
}