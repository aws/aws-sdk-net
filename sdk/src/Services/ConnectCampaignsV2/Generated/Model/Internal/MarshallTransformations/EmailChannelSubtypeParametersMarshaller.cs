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
 * Do not modify this file. This file is generated from the connectcampaignsv2-2024-04-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ConnectCampaignsV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ConnectCampaignsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EmailChannelSubtypeParameters Marshaller
    /// </summary>
    public class EmailChannelSubtypeParametersMarshaller : IRequestMarshaller<EmailChannelSubtypeParameters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(EmailChannelSubtypeParameters requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetConnectSourceEmailAddress())
            {
                context.Writer.WritePropertyName("connectSourceEmailAddress");
                context.Writer.Write(requestObject.ConnectSourceEmailAddress);
            }

            if(requestObject.IsSetDestinationEmailAddress())
            {
                context.Writer.WritePropertyName("destinationEmailAddress");
                context.Writer.Write(requestObject.DestinationEmailAddress);
            }

            if(requestObject.IsSetTemplateArn())
            {
                context.Writer.WritePropertyName("templateArn");
                context.Writer.Write(requestObject.TemplateArn);
            }

            if(requestObject.IsSetTemplateParameters())
            {
                context.Writer.WritePropertyName("templateParameters");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectTemplateParametersKvp in requestObject.TemplateParameters)
                {
                    context.Writer.WritePropertyName(requestObjectTemplateParametersKvp.Key);
                    var requestObjectTemplateParametersValue = requestObjectTemplateParametersKvp.Value;

                        context.Writer.Write(requestObjectTemplateParametersValue);
                }
                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static EmailChannelSubtypeParametersMarshaller Instance = new EmailChannelSubtypeParametersMarshaller();

    }
}