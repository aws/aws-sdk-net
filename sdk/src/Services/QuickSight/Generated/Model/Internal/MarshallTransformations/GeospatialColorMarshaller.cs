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
    /// GeospatialColor Marshaller
    /// </summary>
    public class GeospatialColorMarshaller : IRequestMarshaller<GeospatialColor, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(GeospatialColor requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCategorical())
            {
                context.Writer.WritePropertyName("Categorical");
                context.Writer.WriteObjectStart();

                var marshaller = GeospatialCategoricalColorMarshaller.Instance;
                marshaller.Marshall(requestObject.Categorical, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetGradient())
            {
                context.Writer.WritePropertyName("Gradient");
                context.Writer.WriteObjectStart();

                var marshaller = GeospatialGradientColorMarshaller.Instance;
                marshaller.Marshall(requestObject.Gradient, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSolid())
            {
                context.Writer.WritePropertyName("Solid");
                context.Writer.WriteObjectStart();

                var marshaller = GeospatialSolidColorMarshaller.Instance;
                marshaller.Marshall(requestObject.Solid, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static GeospatialColorMarshaller Instance = new GeospatialColorMarshaller();

    }
}