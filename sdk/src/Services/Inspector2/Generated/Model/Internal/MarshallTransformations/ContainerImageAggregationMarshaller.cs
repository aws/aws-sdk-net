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
    /// ContainerImageAggregation Marshaller
    /// </summary>
    public class ContainerImageAggregationMarshaller : IRequestMarshaller<ContainerImageAggregation, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ContainerImageAggregation requestObject, JsonMarshallerContext context)
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

            if(requestObject.IsSetCloudAccountIds())
            {
                context.Writer.WritePropertyName("cloudAccountIds");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCloudAccountIdsListValue in requestObject.CloudAccountIds)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectCloudAccountIdsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCloudOrgIds())
            {
                context.Writer.WritePropertyName("cloudOrgIds");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCloudOrgIdsListValue in requestObject.CloudOrgIds)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectCloudOrgIdsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCloudPartitions())
            {
                context.Writer.WritePropertyName("cloudPartitions");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCloudPartitionsListValue in requestObject.CloudPartitions)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectCloudPartitionsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCloudProviders())
            {
                context.Writer.WritePropertyName("cloudProviders");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCloudProvidersListValue in requestObject.CloudProviders)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectCloudProvidersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCloudRegions())
            {
                context.Writer.WritePropertyName("cloudRegions");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCloudRegionsListValue in requestObject.CloudRegions)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectCloudRegionsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetImageDigests())
            {
                context.Writer.WritePropertyName("imageDigests");
                context.Writer.WriteStartArray();
                foreach(var requestObjectImageDigestsListValue in requestObject.ImageDigests)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectImageDigestsListValue, context);

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

            if(requestObject.IsSetRegistries())
            {
                context.Writer.WritePropertyName("registries");
                context.Writer.WriteStartArray();
                foreach(var requestObjectRegistriesListValue in requestObject.Registries)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectRegistriesListValue, context);

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
        public readonly static ContainerImageAggregationMarshaller Instance = new ContainerImageAggregationMarshaller();

    }
}