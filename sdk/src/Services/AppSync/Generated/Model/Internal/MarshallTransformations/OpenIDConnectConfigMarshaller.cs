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

namespace Amazon.AppSync.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// OpenIDConnectConfig Marshaller
    /// </summary>       
    public class OpenIDConnectConfigMarshaller : IRequestMarshaller<OpenIDConnectConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(OpenIDConnectConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAuthTTL())
            {
                context.Writer.WritePropertyName("authTTL");
                context.Writer.Write(requestObject.AuthTTL);
            }

            if(requestObject.IsSetClientId())
            {
                context.Writer.WritePropertyName("clientId");
                context.Writer.Write(requestObject.ClientId);
            }

            if(requestObject.IsSetIatTTL())
            {
                context.Writer.WritePropertyName("iatTTL");
                context.Writer.Write(requestObject.IatTTL);
            }

            if(requestObject.IsSetIssuer())
            {
                context.Writer.WritePropertyName("issuer");
                context.Writer.Write(requestObject.Issuer);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static OpenIDConnectConfigMarshaller Instance = new OpenIDConnectConfigMarshaller();

    }
}