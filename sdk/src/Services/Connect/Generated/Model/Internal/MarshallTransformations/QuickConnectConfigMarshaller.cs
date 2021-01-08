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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Connect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Connect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// QuickConnectConfig Marshaller
    /// </summary>       
    public class QuickConnectConfigMarshaller : IRequestMarshaller<QuickConnectConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(QuickConnectConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetPhoneConfig())
            {
                context.Writer.WritePropertyName("PhoneConfig");
                context.Writer.WriteObjectStart();

                var marshaller = PhoneNumberQuickConnectConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.PhoneConfig, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetQueueConfig())
            {
                context.Writer.WritePropertyName("QueueConfig");
                context.Writer.WriteObjectStart();

                var marshaller = QueueQuickConnectConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.QueueConfig, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetQuickConnectType())
            {
                context.Writer.WritePropertyName("QuickConnectType");
                context.Writer.Write(requestObject.QuickConnectType);
            }

            if(requestObject.IsSetUserConfig())
            {
                context.Writer.WritePropertyName("UserConfig");
                context.Writer.WriteObjectStart();

                var marshaller = UserQuickConnectConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.UserConfig, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static QuickConnectConfigMarshaller Instance = new QuickConnectConfigMarshaller();

    }
}