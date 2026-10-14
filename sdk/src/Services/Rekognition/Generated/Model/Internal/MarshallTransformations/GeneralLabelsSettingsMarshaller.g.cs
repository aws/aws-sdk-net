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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.Rekognition.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.Rekognition.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GeneralLabelsSettings Marshaller
    /// </summary>
    public partial class GeneralLabelsSettingsMarshaller : IRequestMarshaller<GeneralLabelsSettings, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(GeneralLabelsSettings requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetLabelCategoryExclusionFilters())
            {
                context.Writer.WritePropertyName("LabelCategoryExclusionFilters");
                context.Writer.WriteStartArray();
                foreach (var requestObjectLabelCategoryExclusionFiltersListValue in requestObject.LabelCategoryExclusionFilters)
                {
                    context.Writer.WriteStringValue(requestObjectLabelCategoryExclusionFiltersListValue);
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetLabelCategoryInclusionFilters())
            {
                context.Writer.WritePropertyName("LabelCategoryInclusionFilters");
                context.Writer.WriteStartArray();
                foreach (var requestObjectLabelCategoryInclusionFiltersListValue in requestObject.LabelCategoryInclusionFilters)
                {
                    context.Writer.WriteStringValue(requestObjectLabelCategoryInclusionFiltersListValue);
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetLabelExclusionFilters())
            {
                context.Writer.WritePropertyName("LabelExclusionFilters");
                context.Writer.WriteStartArray();
                foreach (var requestObjectLabelExclusionFiltersListValue in requestObject.LabelExclusionFilters)
                {
                    context.Writer.WriteStringValue(requestObjectLabelExclusionFiltersListValue);
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetLabelInclusionFilters())
            {
                context.Writer.WritePropertyName("LabelInclusionFilters");
                context.Writer.WriteStartArray();
                foreach (var requestObjectLabelInclusionFiltersListValue in requestObject.LabelInclusionFilters)
                {
                    context.Writer.WriteStringValue(requestObjectLabelInclusionFiltersListValue);
                }
                context.Writer.WriteEndArray();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static GeneralLabelsSettingsMarshaller Instance = new GeneralLabelsSettingsMarshaller();
    }
}
