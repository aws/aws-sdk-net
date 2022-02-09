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
    /// InAppMessageButton Marshaller
    /// </summary>
    public class InAppMessageButtonMarshaller : IRequestMarshaller<InAppMessageButton, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(InAppMessageButton requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAndroid())
            {
                context.Writer.WritePropertyName("Android");
                context.Writer.WriteObjectStart();

                var marshaller = OverrideButtonConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.Android, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDefaultConfig())
            {
                context.Writer.WritePropertyName("DefaultConfig");
                context.Writer.WriteObjectStart();

                var marshaller = DefaultButtonConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.DefaultConfig, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetIOS())
            {
                context.Writer.WritePropertyName("IOS");
                context.Writer.WriteObjectStart();

                var marshaller = OverrideButtonConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.IOS, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetWeb())
            {
                context.Writer.WritePropertyName("Web");
                context.Writer.WriteObjectStart();

                var marshaller = OverrideButtonConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.Web, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static InAppMessageButtonMarshaller Instance = new InAppMessageButtonMarshaller();

    }
}