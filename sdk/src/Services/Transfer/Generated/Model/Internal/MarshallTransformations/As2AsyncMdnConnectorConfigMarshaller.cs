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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Transfer.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Transfer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// As2AsyncMdnConnectorConfig Marshaller
    /// </summary>
    public class As2AsyncMdnConnectorConfigMarshaller : IRequestMarshaller<As2AsyncMdnConnectorConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(As2AsyncMdnConnectorConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetServerIds())
            {
                context.Writer.WritePropertyName("ServerIds");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectServerIdsListValue in requestObject.ServerIds)
                {
                        context.Writer.Write(requestObjectServerIdsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetUrl())
            {
                context.Writer.WritePropertyName("Url");
                context.Writer.Write(requestObject.Url);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static As2AsyncMdnConnectorConfigMarshaller Instance = new As2AsyncMdnConnectorConfigMarshaller();

    }
}