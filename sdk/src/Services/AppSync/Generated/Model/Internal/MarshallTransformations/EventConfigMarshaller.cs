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
 * Do not modify this file. This file is generated from the appsync-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppSync.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.AppSync.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EventConfig Marshaller
    /// </summary>
    public class EventConfigMarshaller : IRequestMarshaller<EventConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(EventConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAuthProviders())
            {
                context.Writer.WritePropertyName("authProviders");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAuthProvidersListValue in requestObject.AuthProviders)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AuthProviderMarshaller.Instance;
                    marshaller.Marshall(requestObjectAuthProvidersListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetConnectionAuthModes())
            {
                context.Writer.WritePropertyName("connectionAuthModes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectConnectionAuthModesListValue in requestObject.ConnectionAuthModes)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AuthModeMarshaller.Instance;
                    marshaller.Marshall(requestObjectConnectionAuthModesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetDefaultPublishAuthModes())
            {
                context.Writer.WritePropertyName("defaultPublishAuthModes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectDefaultPublishAuthModesListValue in requestObject.DefaultPublishAuthModes)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AuthModeMarshaller.Instance;
                    marshaller.Marshall(requestObjectDefaultPublishAuthModesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetDefaultSubscribeAuthModes())
            {
                context.Writer.WritePropertyName("defaultSubscribeAuthModes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectDefaultSubscribeAuthModesListValue in requestObject.DefaultSubscribeAuthModes)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AuthModeMarshaller.Instance;
                    marshaller.Marshall(requestObjectDefaultSubscribeAuthModesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetLogConfig())
            {
                context.Writer.WritePropertyName("logConfig");
                context.Writer.WriteObjectStart();

                var marshaller = EventLogConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.LogConfig, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static EventConfigMarshaller Instance = new EventConfigMarshaller();

    }
}