/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaLive.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MediaLive.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// HlsAkamaiSettings Marshaller
    /// </summary>       
    public class HlsAkamaiSettingsMarshaller : IRequestMarshaller<HlsAkamaiSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(HlsAkamaiSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetConnectionRetryInterval())
            {
                context.Writer.WritePropertyName("connectionRetryInterval");
                context.Writer.Write(requestObject.ConnectionRetryInterval);
            }

            if(requestObject.IsSetFilecacheDuration())
            {
                context.Writer.WritePropertyName("filecacheDuration");
                context.Writer.Write(requestObject.FilecacheDuration);
            }

            if(requestObject.IsSetHttpTransferMode())
            {
                context.Writer.WritePropertyName("httpTransferMode");
                context.Writer.Write(requestObject.HttpTransferMode);
            }

            if(requestObject.IsSetNumRetries())
            {
                context.Writer.WritePropertyName("numRetries");
                context.Writer.Write(requestObject.NumRetries);
            }

            if(requestObject.IsSetRestartDelay())
            {
                context.Writer.WritePropertyName("restartDelay");
                context.Writer.Write(requestObject.RestartDelay);
            }

            if(requestObject.IsSetSalt())
            {
                context.Writer.WritePropertyName("salt");
                context.Writer.Write(requestObject.Salt);
            }

            if(requestObject.IsSetToken())
            {
                context.Writer.WritePropertyName("token");
                context.Writer.Write(requestObject.Token);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static HlsAkamaiSettingsMarshaller Instance = new HlsAkamaiSettingsMarshaller();

    }
}