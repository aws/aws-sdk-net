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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.GeoRoutes.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Circle Marshaller
    /// </summary>
    public class CircleMarshaller : IRequestMarshaller<Circle, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Circle requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCenter())
            {
                context.Writer.WritePropertyName("Center");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectCenterListValue in requestObject.Center)
                {
                        context.Writer.Write(requestObjectCenterListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetRadius())
            {
                context.Writer.WritePropertyName("Radius");
                if(StringUtils.IsSpecialDoubleValue(requestObject.Radius))
                {
                    context.Writer.Write(StringUtils.FromSpecialDoubleValue(requestObject.Radius));
                }
                else
                {
                    context.Writer.Write(requestObject.Radius);
                }
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CircleMarshaller Instance = new CircleMarshaller();

    }
}