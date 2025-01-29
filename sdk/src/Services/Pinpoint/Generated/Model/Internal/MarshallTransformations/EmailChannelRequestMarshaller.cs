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
#pragma warning disable CS0612,CS0618
namespace Amazon.Pinpoint.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EmailChannelRequest Marshaller
    /// </summary>
    public class EmailChannelRequestMarshaller : IRequestMarshaller<EmailChannelRequest, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(EmailChannelRequest requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetConfigurationSet())
            {
                context.Writer.WritePropertyName("ConfigurationSet");
                context.Writer.WriteStringValue(requestObject.ConfigurationSet);
            }

            if(requestObject.IsSetEnabled())
            {
                context.Writer.WritePropertyName("Enabled");
                context.Writer.WriteBooleanValue(requestObject.Enabled.Value);
            }

            if(requestObject.IsSetFromAddress())
            {
                context.Writer.WritePropertyName("FromAddress");
                context.Writer.WriteStringValue(requestObject.FromAddress);
            }

            if(requestObject.IsSetIdentity())
            {
                context.Writer.WritePropertyName("Identity");
                context.Writer.WriteStringValue(requestObject.Identity);
            }

            if(requestObject.IsSetOrchestrationSendingRoleArn())
            {
                context.Writer.WritePropertyName("OrchestrationSendingRoleArn");
                context.Writer.WriteStringValue(requestObject.OrchestrationSendingRoleArn);
            }

            if(requestObject.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("RoleArn");
                context.Writer.WriteStringValue(requestObject.RoleArn);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static EmailChannelRequestMarshaller Instance = new EmailChannelRequestMarshaller();

    }
}