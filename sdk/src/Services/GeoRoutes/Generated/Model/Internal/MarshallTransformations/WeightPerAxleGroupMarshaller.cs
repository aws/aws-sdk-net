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
 * Do not modify this file. This file is generated from the geo-routes-2020-11-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.GeoRoutes.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.GeoRoutes.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// WeightPerAxleGroup Marshaller
    /// </summary>
    public class WeightPerAxleGroupMarshaller : IRequestMarshaller<WeightPerAxleGroup, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(WeightPerAxleGroup requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetQuad())
            {
                context.Writer.WritePropertyName("Quad");
                context.Writer.WriteNumberValue(requestObject.Quad.Value);
            }

            if(requestObject.IsSetQuint())
            {
                context.Writer.WritePropertyName("Quint");
                context.Writer.WriteNumberValue(requestObject.Quint.Value);
            }

            if(requestObject.IsSetSingle())
            {
                context.Writer.WritePropertyName("Single");
                context.Writer.WriteNumberValue(requestObject.Single.Value);
            }

            if(requestObject.IsSetTandem())
            {
                context.Writer.WritePropertyName("Tandem");
                context.Writer.WriteNumberValue(requestObject.Tandem.Value);
            }

            if(requestObject.IsSetTriple())
            {
                context.Writer.WritePropertyName("Triple");
                context.Writer.WriteNumberValue(requestObject.Triple.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static WeightPerAxleGroupMarshaller Instance = new WeightPerAxleGroupMarshaller();

    }
}