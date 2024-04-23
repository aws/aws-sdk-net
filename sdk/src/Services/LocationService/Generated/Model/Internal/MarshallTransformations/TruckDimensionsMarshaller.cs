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
 * Do not modify this file. This file is generated from the location-2020-11-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LocationService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.LocationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TruckDimensions Marshaller
    /// </summary>
    public class TruckDimensionsMarshaller : IRequestMarshaller<TruckDimensions, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TruckDimensions requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetHeight())
            {
                context.Writer.WritePropertyName("Height");
                if(StringUtils.IsSpecialDoubleValue(requestObject.Height))
                {
                    context.Writer.Write(StringUtils.FromSpecialDoubleValue(requestObject.Height));
                }
                else
                {
                    context.Writer.Write(requestObject.Height);
                }
            }

            if(requestObject.IsSetLength())
            {
                context.Writer.WritePropertyName("Length");
                if(StringUtils.IsSpecialDoubleValue(requestObject.Length))
                {
                    context.Writer.Write(StringUtils.FromSpecialDoubleValue(requestObject.Length));
                }
                else
                {
                    context.Writer.Write(requestObject.Length);
                }
            }

            if(requestObject.IsSetUnit())
            {
                context.Writer.WritePropertyName("Unit");
                context.Writer.Write(requestObject.Unit);
            }

            if(requestObject.IsSetWidth())
            {
                context.Writer.WritePropertyName("Width");
                if(StringUtils.IsSpecialDoubleValue(requestObject.Width))
                {
                    context.Writer.Write(StringUtils.FromSpecialDoubleValue(requestObject.Width));
                }
                else
                {
                    context.Writer.Write(requestObject.Width);
                }
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TruckDimensionsMarshaller Instance = new TruckDimensionsMarshaller();

    }
}
#pragma warning restore CS0612,CS0618