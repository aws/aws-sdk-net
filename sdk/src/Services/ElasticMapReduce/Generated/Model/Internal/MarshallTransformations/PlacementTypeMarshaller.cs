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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticMapReduce.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PlacementType Marshaller
    /// </summary>       
    public class PlacementTypeMarshaller : IRequestMarshaller<PlacementType, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(PlacementType requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAvailabilityZone())
            {
                context.Writer.WritePropertyName("AvailabilityZone");
                context.Writer.Write(requestObject.AvailabilityZone);
            }

            if(requestObject.IsSetAvailabilityZones())
            {
                context.Writer.WritePropertyName("AvailabilityZones");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAvailabilityZonesListValue in requestObject.AvailabilityZones)
                {
                        context.Writer.Write(requestObjectAvailabilityZonesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static PlacementTypeMarshaller Instance = new PlacementTypeMarshaller();

    }
}