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
 * Do not modify this file. This file is generated from the appmesh-2019-01-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppMesh.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.AppMesh.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsCloudMapServiceDiscovery Marshaller
    /// </summary>
    public class AwsCloudMapServiceDiscoveryMarshaller : IRequestMarshaller<AwsCloudMapServiceDiscovery, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsCloudMapServiceDiscovery requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAttributes())
            {
                context.Writer.WritePropertyName("attributes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAttributesListValue in requestObject.Attributes)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsCloudMapInstanceAttributeMarshaller.Instance;
                    marshaller.Marshall(requestObjectAttributesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetIpPreference())
            {
                context.Writer.WritePropertyName("ipPreference");
                context.Writer.WriteStringValue(requestObject.IpPreference);
            }

            if(requestObject.IsSetNamespaceName())
            {
                context.Writer.WritePropertyName("namespaceName");
                context.Writer.WriteStringValue(requestObject.NamespaceName);
            }

            if(requestObject.IsSetServiceName())
            {
                context.Writer.WritePropertyName("serviceName");
                context.Writer.WriteStringValue(requestObject.ServiceName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsCloudMapServiceDiscoveryMarshaller Instance = new AwsCloudMapServiceDiscoveryMarshaller();

    }
}