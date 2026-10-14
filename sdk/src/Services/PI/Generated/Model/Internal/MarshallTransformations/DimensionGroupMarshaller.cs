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
 * Do not modify this file. This file is generated from the pi-2018-02-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.PI.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.PI.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DimensionGroup Marshaller
    /// </summary>
    public class DimensionGroupMarshaller : IRequestMarshaller<DimensionGroup, CborMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DimensionGroup requestObject, CborMarshallerContext context)
        {
            if (requestObject == null)
                return;

            if (requestObject.IsSetDimensions())
            {
                context.Writer.WriteTextString("Dimensions");
                context.Writer.WriteStartArray(requestObject.Dimensions.Count);
                foreach(var requestObjectDimensionsListValue in requestObject.Dimensions)
                {
                        context.Writer.WriteTextString(requestObjectDimensionsListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetGroup())
            {
                context.Writer.WriteTextString("Group");
                context.Writer.WriteTextString(requestObject.Group);
            }
            if (requestObject.IsSetLimit())
            {
                context.Writer.WriteTextString("Limit");
                context.Writer.WriteInt32(requestObject.Limit.Value);
            }
        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DimensionGroupMarshaller Instance = new DimensionGroupMarshaller();

    }
}