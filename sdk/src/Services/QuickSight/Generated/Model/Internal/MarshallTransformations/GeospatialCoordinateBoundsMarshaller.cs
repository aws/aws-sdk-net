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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QuickSight.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GeospatialCoordinateBounds Marshaller
    /// </summary>
    public class GeospatialCoordinateBoundsMarshaller : IRequestMarshaller<GeospatialCoordinateBounds, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(GeospatialCoordinateBounds requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetEast())
            {
                context.Writer.WritePropertyName("East");
<<<<<<< HEAD
                context.Writer.Write(requestObject.East.Value);
=======
                if(StringUtils.IsSpecialDoubleValue(requestObject.East))
                {
                    context.Writer.Write(StringUtils.FromSpecialDoubleValue(requestObject.East));
                }
                else
                {
                    context.Writer.Write(requestObject.East);
                }
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3
            }

            if(requestObject.IsSetNorth())
            {
                context.Writer.WritePropertyName("North");
<<<<<<< HEAD
                context.Writer.Write(requestObject.North.Value);
=======
                if(StringUtils.IsSpecialDoubleValue(requestObject.North))
                {
                    context.Writer.Write(StringUtils.FromSpecialDoubleValue(requestObject.North));
                }
                else
                {
                    context.Writer.Write(requestObject.North);
                }
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3
            }

            if(requestObject.IsSetSouth())
            {
                context.Writer.WritePropertyName("South");
<<<<<<< HEAD
                context.Writer.Write(requestObject.South.Value);
=======
                if(StringUtils.IsSpecialDoubleValue(requestObject.South))
                {
                    context.Writer.Write(StringUtils.FromSpecialDoubleValue(requestObject.South));
                }
                else
                {
                    context.Writer.Write(requestObject.South);
                }
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3
            }

            if(requestObject.IsSetWest())
            {
                context.Writer.WritePropertyName("West");
<<<<<<< HEAD
                context.Writer.Write(requestObject.West.Value);
=======
                if(StringUtils.IsSpecialDoubleValue(requestObject.West))
                {
                    context.Writer.Write(StringUtils.FromSpecialDoubleValue(requestObject.West));
                }
                else
                {
                    context.Writer.Write(requestObject.West);
                }
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static GeospatialCoordinateBoundsMarshaller Instance = new GeospatialCoordinateBoundsMarshaller();

    }
}