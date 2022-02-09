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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaConvert.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MediaConvert.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// KantarWatermarkSettings Marshaller
    /// </summary>
    public class KantarWatermarkSettingsMarshaller : IRequestMarshaller<KantarWatermarkSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(KantarWatermarkSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetChannelName())
            {
                context.Writer.WritePropertyName("channelName");
                context.Writer.Write(requestObject.ChannelName);
            }

            if(requestObject.IsSetContentReference())
            {
                context.Writer.WritePropertyName("contentReference");
                context.Writer.Write(requestObject.ContentReference);
            }

            if(requestObject.IsSetCredentialsSecretName())
            {
                context.Writer.WritePropertyName("credentialsSecretName");
                context.Writer.Write(requestObject.CredentialsSecretName);
            }

            if(requestObject.IsSetFileOffset())
            {
                context.Writer.WritePropertyName("fileOffset");
                context.Writer.Write(requestObject.FileOffset);
            }

            if(requestObject.IsSetKantarLicenseId())
            {
                context.Writer.WritePropertyName("kantarLicenseId");
                context.Writer.Write(requestObject.KantarLicenseId);
            }

            if(requestObject.IsSetKantarServerUrl())
            {
                context.Writer.WritePropertyName("kantarServerUrl");
                context.Writer.Write(requestObject.KantarServerUrl);
            }

            if(requestObject.IsSetLogDestination())
            {
                context.Writer.WritePropertyName("logDestination");
                context.Writer.Write(requestObject.LogDestination);
            }

            if(requestObject.IsSetMetadata3())
            {
                context.Writer.WritePropertyName("metadata3");
                context.Writer.Write(requestObject.Metadata3);
            }

            if(requestObject.IsSetMetadata4())
            {
                context.Writer.WritePropertyName("metadata4");
                context.Writer.Write(requestObject.Metadata4);
            }

            if(requestObject.IsSetMetadata5())
            {
                context.Writer.WritePropertyName("metadata5");
                context.Writer.Write(requestObject.Metadata5);
            }

            if(requestObject.IsSetMetadata6())
            {
                context.Writer.WritePropertyName("metadata6");
                context.Writer.Write(requestObject.Metadata6);
            }

            if(requestObject.IsSetMetadata7())
            {
                context.Writer.WritePropertyName("metadata7");
                context.Writer.Write(requestObject.Metadata7);
            }

            if(requestObject.IsSetMetadata8())
            {
                context.Writer.WritePropertyName("metadata8");
                context.Writer.Write(requestObject.Metadata8);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static KantarWatermarkSettingsMarshaller Instance = new KantarWatermarkSettingsMarshaller();

    }
}