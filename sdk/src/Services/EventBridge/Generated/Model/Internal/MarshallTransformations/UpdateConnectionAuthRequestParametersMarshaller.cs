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
 * Do not modify this file. This file is generated from the eventbridge-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EventBridge.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.EventBridge.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateConnectionAuthRequestParameters Marshaller
    /// </summary>
    public class UpdateConnectionAuthRequestParametersMarshaller : IRequestMarshaller<UpdateConnectionAuthRequestParameters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(UpdateConnectionAuthRequestParameters requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetApiKeyAuthParameters())
            {
                context.Writer.WritePropertyName("ApiKeyAuthParameters");
                context.Writer.WriteObjectStart();

                var marshaller = UpdateConnectionApiKeyAuthRequestParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.ApiKeyAuthParameters, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetBasicAuthParameters())
            {
                context.Writer.WritePropertyName("BasicAuthParameters");
                context.Writer.WriteObjectStart();

                var marshaller = UpdateConnectionBasicAuthRequestParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.BasicAuthParameters, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetInvocationHttpParameters())
            {
                context.Writer.WritePropertyName("InvocationHttpParameters");
                context.Writer.WriteObjectStart();

                var marshaller = ConnectionHttpParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.InvocationHttpParameters, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetOAuthParameters())
            {
                context.Writer.WritePropertyName("OAuthParameters");
                context.Writer.WriteObjectStart();

                var marshaller = UpdateConnectionOAuthRequestParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.OAuthParameters, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static UpdateConnectionAuthRequestParametersMarshaller Instance = new UpdateConnectionAuthRequestParametersMarshaller();

    }
}