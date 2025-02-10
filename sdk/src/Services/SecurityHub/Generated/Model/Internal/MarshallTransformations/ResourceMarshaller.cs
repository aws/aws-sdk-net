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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Resource Marshaller
    /// </summary>
    public class ResourceMarshaller : IRequestMarshaller<Resource, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Resource requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetApplicationArn())
            {
                context.Writer.WritePropertyName("ApplicationArn");
                context.Writer.WriteStringValue(requestObject.ApplicationArn);
            }

            if(requestObject.IsSetApplicationName())
            {
                context.Writer.WritePropertyName("ApplicationName");
                context.Writer.WriteStringValue(requestObject.ApplicationName);
            }

            if(requestObject.IsSetDataClassification())
            {
                context.Writer.WritePropertyName("DataClassification");
                context.Writer.WriteStartObject();

                var marshaller = DataClassificationDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.DataClassification, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDetails())
            {
                context.Writer.WritePropertyName("Details");
                context.Writer.WriteStartObject();

                var marshaller = ResourceDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.Details, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetId())
            {
                context.Writer.WritePropertyName("Id");
                context.Writer.WriteStringValue(requestObject.Id);
            }

            if(requestObject.IsSetPartition())
            {
                context.Writer.WritePropertyName("Partition");
                context.Writer.WriteStringValue(requestObject.Partition);
            }

            if(requestObject.IsSetRegion())
            {
                context.Writer.WritePropertyName("Region");
                context.Writer.WriteStringValue(requestObject.Region);
            }

            if(requestObject.IsSetResourceRole())
            {
                context.Writer.WritePropertyName("ResourceRole");
                context.Writer.WriteStringValue(requestObject.ResourceRole);
            }

            if(requestObject.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
                context.Writer.WriteStartObject();
                foreach (var requestObjectTagsKvp in requestObject.Tags)
                {
                    context.Writer.WritePropertyName(requestObjectTagsKvp.Key);
                    var requestObjectTagsValue = requestObjectTagsKvp.Value;

                        context.Writer.WriteStringValue(requestObjectTagsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("Type");
                context.Writer.WriteStringValue(requestObject.Type);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ResourceMarshaller Instance = new ResourceMarshaller();

    }
}