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
using ThirdParty.Json.LitJson;

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
            if(requestObject.IsSetArchitectures())
            {
                context.Writer.WritePropertyName("architectures");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectArchitecturesListValue in requestObject.Architectures)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectArchitecturesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetImageShas())
            {
                context.Writer.WritePropertyName("imageShas");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectImageShasListValue in requestObject.ImageShas)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectImageShasListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetImageTags())
            {
                context.Writer.WritePropertyName("imageTags");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectImageTagsListValue in requestObject.ImageTags)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectImageTagsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetRepositories())
            {
                context.Writer.WritePropertyName("repositories");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectRepositoriesListValue in requestObject.Repositories)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectRepositoriesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetResourceIds())
            {
                context.Writer.WritePropertyName("resourceIds");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectResourceIdsListValue in requestObject.ResourceIds)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceIdsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSortBy())
            {
                context.Writer.WritePropertyName("sortBy");
                context.Writer.Write(requestObject.SortBy);
            }

            if(requestObject.IsSetSortOrder())
            {
                context.Writer.WritePropertyName("sortOrder");
                context.Writer.Write(requestObject.SortOrder);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsEcrContainerAggregationMarshaller Instance = new AwsEcrContainerAggregationMarshaller();

    }
}