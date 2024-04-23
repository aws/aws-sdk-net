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
 * Do not modify this file. This file is generated from the emr-serverless-2021-07-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EMRServerless.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.EMRServerless.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CloudWatchLoggingConfiguration Marshaller
    /// </summary>
    public class CloudWatchLoggingConfigurationMarshaller : IRequestMarshaller<CloudWatchLoggingConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CloudWatchLoggingConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetEnabled())
            {
                context.Writer.WritePropertyName("enabled");
                context.Writer.Write(requestObject.Enabled);
            }

            if(requestObject.IsSetEncryptionKeyArn())
            {
                context.Writer.WritePropertyName("encryptionKeyArn");
                context.Writer.Write(requestObject.EncryptionKeyArn);
            }

            if(requestObject.IsSetLogGroupName())
            {
                context.Writer.WritePropertyName("logGroupName");
                context.Writer.Write(requestObject.LogGroupName);
            }

            if(requestObject.IsSetLogStreamNamePrefix())
            {
                context.Writer.WritePropertyName("logStreamNamePrefix");
                context.Writer.Write(requestObject.LogStreamNamePrefix);
            }

            if(requestObject.IsSetLogTypes())
            {
                context.Writer.WritePropertyName("logTypes");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectLogTypesKvp in requestObject.LogTypes)
                {
                    context.Writer.WritePropertyName(requestObjectLogTypesKvp.Key);
                    var requestObjectLogTypesValue = requestObjectLogTypesKvp.Value;

                    context.Writer.WriteArrayStart();
                    foreach(var requestObjectLogTypesValueListValue in requestObjectLogTypesValue)
                    {
                            context.Writer.Write(requestObjectLogTypesValueListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }
                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CloudWatchLoggingConfigurationMarshaller Instance = new CloudWatchLoggingConfigurationMarshaller();

    }
}
#pragma warning restore CS0612,CS0618