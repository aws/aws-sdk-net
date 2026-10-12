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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.PinpointSMSVoiceV2.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.PinpointSMSVoiceV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RcsOpenUrlAction Marshaller
    /// </summary>
    public partial class RcsOpenUrlActionMarshaller : IRequestMarshaller<RcsOpenUrlAction, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(RcsOpenUrlAction requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetApplication())
            {
                context.Writer.WritePropertyName("Application");
                context.Writer.WriteStringValue(requestObject.Application);
            }

            if (requestObject.IsSetPostbackData())
            {
                context.Writer.WritePropertyName("PostbackData");
                context.Writer.WriteStringValue(requestObject.PostbackData);
            }

            if (requestObject.IsSetText())
            {
                context.Writer.WritePropertyName("Text");
                context.Writer.WriteStringValue(requestObject.Text);
            }

            if (requestObject.IsSetUrl())
            {
                context.Writer.WritePropertyName("Url");
                context.Writer.WriteStringValue(requestObject.Url);
            }

            if (requestObject.IsSetWebviewViewMode())
            {
                context.Writer.WritePropertyName("WebviewViewMode");
                context.Writer.WriteStringValue(requestObject.WebviewViewMode);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static RcsOpenUrlActionMarshaller Instance = new RcsOpenUrlActionMarshaller();
    }
}
