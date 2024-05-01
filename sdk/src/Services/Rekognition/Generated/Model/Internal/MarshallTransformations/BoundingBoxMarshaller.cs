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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Rekognition.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Rekognition.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BoundingBox Marshaller
    /// </summary>
    public class BoundingBoxMarshaller : IRequestMarshaller<BoundingBox, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(BoundingBox requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetHeight())
            {
                context.Writer.WritePropertyName("Height");
<<<<<<< HEAD
                context.Writer.Write(requestObject.Height.Value);
=======
                if(StringUtils.IsSpecialFloatValue(requestObject.Height))
                {
                    context.Writer.Write(StringUtils.FromSpecialFloatValue(requestObject.Height));
                }
                else
                {
                    context.Writer.Write(requestObject.Height);
                }
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3
            }

            if(requestObject.IsSetLeft())
            {
                context.Writer.WritePropertyName("Left");
<<<<<<< HEAD
                context.Writer.Write(requestObject.Left.Value);
=======
                if(StringUtils.IsSpecialFloatValue(requestObject.Left))
                {
                    context.Writer.Write(StringUtils.FromSpecialFloatValue(requestObject.Left));
                }
                else
                {
                    context.Writer.Write(requestObject.Left);
                }
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3
            }

            if(requestObject.IsSetTop())
            {
                context.Writer.WritePropertyName("Top");
<<<<<<< HEAD
                context.Writer.Write(requestObject.Top.Value);
=======
                if(StringUtils.IsSpecialFloatValue(requestObject.Top))
                {
                    context.Writer.Write(StringUtils.FromSpecialFloatValue(requestObject.Top));
                }
                else
                {
                    context.Writer.Write(requestObject.Top);
                }
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3
            }

            if(requestObject.IsSetWidth())
            {
                context.Writer.WritePropertyName("Width");
<<<<<<< HEAD
                context.Writer.Write(requestObject.Width.Value);
=======
                if(StringUtils.IsSpecialFloatValue(requestObject.Width))
                {
                    context.Writer.Write(StringUtils.FromSpecialFloatValue(requestObject.Width));
                }
                else
                {
                    context.Writer.Write(requestObject.Width);
                }
>>>>>>> 875eb2d705bb0cdd8b8b602780494e7b8e0f13d3
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static BoundingBoxMarshaller Instance = new BoundingBoxMarshaller();

    }
}