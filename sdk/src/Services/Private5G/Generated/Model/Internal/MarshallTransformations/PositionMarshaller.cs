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
 * Do not modify this file. This file is generated from the privatenetworks-2021-12-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Private5G.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Private5G.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Position Marshaller
    /// </summary>
    public class PositionMarshaller : IRequestMarshaller<Position, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Position requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetElevation())
            {
                context.Writer.WritePropertyName("elevation");
                if(StringUtils.IsSpecialDoubleValue(requestObject.Elevation.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.Elevation.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.Elevation.Value);
                }
            }

            if(requestObject.IsSetElevationReference())
            {
                context.Writer.WritePropertyName("elevationReference");
                context.Writer.WriteStringValue(requestObject.ElevationReference);
            }

            if(requestObject.IsSetElevationUnit())
            {
                context.Writer.WritePropertyName("elevationUnit");
                context.Writer.WriteStringValue(requestObject.ElevationUnit);
            }

            if(requestObject.IsSetLatitude())
            {
                context.Writer.WritePropertyName("latitude");
                if(StringUtils.IsSpecialDoubleValue(requestObject.Latitude.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.Latitude.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.Latitude.Value);
                }
            }

            if(requestObject.IsSetLongitude())
            {
                context.Writer.WritePropertyName("longitude");
                if(StringUtils.IsSpecialDoubleValue(requestObject.Longitude.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.Longitude.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.Longitude.Value);
                }
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PositionMarshaller Instance = new PositionMarshaller();

    }
}