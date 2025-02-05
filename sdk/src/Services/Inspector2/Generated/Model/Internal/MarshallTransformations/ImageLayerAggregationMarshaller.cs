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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Inspector2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Inspector2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ImageLayerAggregation Marshaller
    /// </summary>
    public class ImageLayerAggregationMarshaller : IRequestMarshaller<ImageLayerAggregation, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ImageLayerAggregation requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetLayerHashes())
            {
                context.Writer.WritePropertyName("layerHashes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectLayerHashesListValue in requestObject.LayerHashes)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectLayerHashesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetRepositories())
            {
                context.Writer.WritePropertyName("repositories");
                context.Writer.WriteStartArray();
                foreach(var requestObjectRepositoriesListValue in requestObject.Repositories)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectRepositoriesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetResourceIds())
            {
                context.Writer.WritePropertyName("resourceIds");
                context.Writer.WriteStartArray();
                foreach(var requestObjectResourceIdsListValue in requestObject.ResourceIds)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceIdsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSortBy())
            {
                context.Writer.WritePropertyName("sortBy");
                context.Writer.WriteStringValue(requestObject.SortBy);
            }

            if(requestObject.IsSetSortOrder())
            {
                context.Writer.WritePropertyName("sortOrder");
                context.Writer.WriteStringValue(requestObject.SortOrder);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ImageLayerAggregationMarshaller Instance = new ImageLayerAggregationMarshaller();

    }
}