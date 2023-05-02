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
 * Do not modify this file. This file is generated from the network-firewall-2020-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.NetworkFirewall.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.NetworkFirewall.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TLSInspectionConfiguration Marshaller
    /// </summary>
    public class TLSInspectionConfigurationMarshaller : IRequestMarshaller<TLSInspectionConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TLSInspectionConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetServerCertificateConfigurations())
            {
                context.Writer.WritePropertyName("ServerCertificateConfigurations");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectServerCertificateConfigurationsListValue in requestObject.ServerCertificateConfigurations)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ServerCertificateConfigurationMarshaller.Instance;
                    marshaller.Marshall(requestObjectServerCertificateConfigurationsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TLSInspectionConfigurationMarshaller Instance = new TLSInspectionConfigurationMarshaller();

    }
}