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
    /// RouterNetworkInterfaceFilter Marshaller
    /// </summary>
    public class RouterNetworkInterfaceFilterMarshaller : IRequestMarshaller<RouterNetworkInterfaceFilter, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RouterNetworkInterfaceFilter requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
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

            if(requestObject.IsSetNetworkInterfaceTypes())
            {
                context.Writer.WritePropertyName("networkInterfaceTypes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectNetworkInterfaceTypesListValue in requestObject.NetworkInterfaceTypes)
                {
                        context.Writer.Write(requestObjectNetworkInterfaceTypesListValue);
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

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RouterNetworkInterfaceFilterMarshaller Instance = new RouterNetworkInterfaceFilterMarshaller();

    }
}