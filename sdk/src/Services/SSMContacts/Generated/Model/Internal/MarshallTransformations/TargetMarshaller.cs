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
 * Do not modify this file. This file is generated from the ssm-contacts-2021-05-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SSMContacts.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SSMContacts.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Target Marshaller
    /// </summary>
    public class TargetMarshaller : IRequestMarshaller<Target, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Target requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetChannelTargetInfo())
            {
                context.Writer.WritePropertyName("ChannelTargetInfo");
                context.Writer.WriteObjectStart();

                var marshaller = ChannelTargetInfoMarshaller.Instance;
                marshaller.Marshall(requestObject.ChannelTargetInfo, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetContactTargetInfo())
            {
                context.Writer.WritePropertyName("ContactTargetInfo");
                context.Writer.WriteObjectStart();

                var marshaller = ContactTargetInfoMarshaller.Instance;
                marshaller.Marshall(requestObject.ContactTargetInfo, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TargetMarshaller Instance = new TargetMarshaller();

    }
}