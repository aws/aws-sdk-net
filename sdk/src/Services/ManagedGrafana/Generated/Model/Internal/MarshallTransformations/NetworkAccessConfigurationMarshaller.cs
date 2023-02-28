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
 * Do not modify this file. This file is generated from the grafana-2020-08-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ManagedGrafana.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ManagedGrafana.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// NetworkAccessConfiguration Marshaller
    /// </summary>
    public class NetworkAccessConfigurationMarshaller : IRequestMarshaller<NetworkAccessConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(NetworkAccessConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetPrefixListIds())
            {
                context.Writer.WritePropertyName("prefixListIds");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectPrefixListIdsListValue in requestObject.PrefixListIds)
                {
                        context.Writer.Write(requestObjectPrefixListIdsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetVpceIds())
            {
                context.Writer.WritePropertyName("vpceIds");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectVpceIdsListValue in requestObject.VpceIds)
                {
                        context.Writer.Write(requestObjectVpceIdsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static NetworkAccessConfigurationMarshaller Instance = new NetworkAccessConfigurationMarshaller();

    }
}