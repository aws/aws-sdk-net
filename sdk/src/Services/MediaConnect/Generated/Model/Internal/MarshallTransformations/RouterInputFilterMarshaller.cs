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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaConnect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.MediaConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RouterInputFilter Marshaller
    /// </summary>
    public class RouterInputFilterMarshaller : IRequestMarshaller<RouterInputFilter, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RouterInputFilter requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetInputTypes())
            {
                context.Writer.WritePropertyName("inputTypes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectInputTypesListValue in requestObject.InputTypes)
                {
                        context.Writer.WriteStringValue(requestObjectInputTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetNameContains())
            {
                context.Writer.WritePropertyName("nameContains");
                context.Writer.WriteStartArray();
                foreach(var requestObjectNameContainsListValue in requestObject.NameContains)
                {
                        context.Writer.WriteStringValue(requestObjectNameContainsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetNetworkInterfaceArns())
            {
                context.Writer.WritePropertyName("networkInterfaceArns");
                context.Writer.WriteStartArray();
                foreach(var requestObjectNetworkInterfaceArnsListValue in requestObject.NetworkInterfaceArns)
                {
                        context.Writer.WriteStringValue(requestObjectNetworkInterfaceArnsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetRegionNames())
            {
                context.Writer.WritePropertyName("regionNames");
                context.Writer.WriteStartArray();
                foreach(var requestObjectRegionNamesListValue in requestObject.RegionNames)
                {
                        context.Writer.WriteStringValue(requestObjectRegionNamesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetRoutingScopes())
            {
                context.Writer.WritePropertyName("routingScopes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectRoutingScopesListValue in requestObject.RoutingScopes)
                {
                        context.Writer.WriteStringValue(requestObjectRoutingScopesListValue);
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RouterInputFilterMarshaller Instance = new RouterInputFilterMarshaller();

    }
}