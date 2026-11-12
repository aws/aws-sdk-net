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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.SSOAdmin.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.SSOAdmin.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// NetworkConfigurationInfo Marshaller
    /// </summary>
    public partial class NetworkConfigurationInfoMarshaller : IRequestMarshaller<NetworkConfigurationInfo, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(NetworkConfigurationInfo requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetAllowSourceIps())
            {
                context.Writer.WritePropertyName("AllowSourceIps");
                context.Writer.WriteStartArray();
                foreach (var requestObjectAllowSourceIpsListValue in requestObject.AllowSourceIps)
                {
                    context.Writer.WriteStringValue(requestObjectAllowSourceIpsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetExcludeApplicationArns())
            {
                context.Writer.WritePropertyName("ExcludeApplicationArns");
                context.Writer.WriteStartArray();
                foreach (var requestObjectExcludeApplicationArnsListValue in requestObject.ExcludeApplicationArns)
                {
                    context.Writer.WriteStringValue(requestObjectExcludeApplicationArnsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetRestrictSourceVpcs())
            {
                context.Writer.WritePropertyName("RestrictSourceVpcs");
                context.Writer.WriteStartArray();
                foreach (var requestObjectRestrictSourceVpcsListValue in requestObject.RestrictSourceVpcs)
                {
                    context.Writer.WriteStringValue(requestObjectRestrictSourceVpcsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetVpceAccessRequired())
            {
                context.Writer.WritePropertyName("VpceAccessRequired");
                context.Writer.WriteBooleanValue(requestObject.VpceAccessRequired.Value);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static NetworkConfigurationInfoMarshaller Instance = new NetworkConfigurationInfoMarshaller();
    }
}
