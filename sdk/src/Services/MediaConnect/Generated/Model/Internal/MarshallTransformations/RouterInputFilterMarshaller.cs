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
using ThirdParty.Json.LitJson;

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
                context.Writer.WriteArrayStart();
                foreach(var requestObjectInputTypesListValue in requestObject.InputTypes)
                {
                        context.Writer.Write(requestObjectInputTypesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetNameContains())
            {
                context.Writer.WritePropertyName("nameContains");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectNameContainsListValue in requestObject.NameContains)
                {
                        context.Writer.Write(requestObjectNameContainsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetNetworkInterfaceArns())
            {
                context.Writer.WritePropertyName("networkInterfaceArns");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectNetworkInterfaceArnsListValue in requestObject.NetworkInterfaceArns)
                {
                        context.Writer.Write(requestObjectNetworkInterfaceArnsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetRegionNames())
            {
                context.Writer.WritePropertyName("regionNames");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectRegionNamesListValue in requestObject.RegionNames)
                {
                        context.Writer.Write(requestObjectRegionNamesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetRoutingScopes())
            {
                context.Writer.WritePropertyName("routingScopes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectRoutingScopesListValue in requestObject.RoutingScopes)
                {
                        context.Writer.Write(requestObjectRoutingScopesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RouterInputFilterMarshaller Instance = new RouterInputFilterMarshaller();

    }
}