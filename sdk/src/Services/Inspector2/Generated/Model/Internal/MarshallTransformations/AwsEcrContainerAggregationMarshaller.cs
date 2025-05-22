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
    /// AwsEcrContainerAggregation Marshaller
    /// </summary>
    public class AwsEcrContainerAggregationMarshaller : IRequestMarshaller<AwsEcrContainerAggregation, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsEcrContainerAggregation requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetArchitectures())
            {
                context.Writer.WritePropertyName("architectures");
                context.Writer.WriteStartArray();
                foreach(var requestObjectArchitecturesListValue in requestObject.Architectures)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectArchitecturesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetImageShas())
            {
                context.Writer.WritePropertyName("imageShas");
                context.Writer.WriteStartArray();
                foreach(var requestObjectImageShasListValue in requestObject.ImageShas)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectImageShasListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetImageTags())
            {
                context.Writer.WritePropertyName("imageTags");
                context.Writer.WriteStartArray();
                foreach(var requestObjectImageTagsListValue in requestObject.ImageTags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectImageTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetInUseCount())
            {
                context.Writer.WritePropertyName("inUseCount");
                context.Writer.WriteStartArray();
                foreach(var requestObjectInUseCountListValue in requestObject.InUseCount)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = NumberFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectInUseCountListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetLastInUseAt())
            {
                context.Writer.WritePropertyName("lastInUseAt");
                context.Writer.WriteStartArray();
                foreach(var requestObjectLastInUseAtListValue in requestObject.LastInUseAt)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DateFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectLastInUseAtListValue, context);

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
        public readonly static AwsEcrContainerAggregationMarshaller Instance = new AwsEcrContainerAggregationMarshaller();

    }
}