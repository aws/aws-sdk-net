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
 * Do not modify this file. This file is generated from the workdocs-2016-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WorkDocs.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.WorkDocs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Filters Marshaller
    /// </summary>
    public class FiltersMarshaller : IRequestMarshaller<Filters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Filters requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAncestorIds())
            {
                context.Writer.WritePropertyName("AncestorIds");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAncestorIdsListValue in requestObject.AncestorIds)
                {
                        context.Writer.WriteStringValue(requestObjectAncestorIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetContentCategories())
            {
                context.Writer.WritePropertyName("ContentCategories");
                context.Writer.WriteStartArray();
                foreach(var requestObjectContentCategoriesListValue in requestObject.ContentCategories)
                {
                        context.Writer.WriteStringValue(requestObjectContentCategoriesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCreatedRange())
            {
                context.Writer.WritePropertyName("CreatedRange");
                context.Writer.WriteStartObject();

                var marshaller = DateRangeTypeMarshaller.Instance;
                marshaller.Marshall(requestObject.CreatedRange, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLabels())
            {
                context.Writer.WritePropertyName("Labels");
                context.Writer.WriteStartArray();
                foreach(var requestObjectLabelsListValue in requestObject.Labels)
                {
                        context.Writer.WriteStringValue(requestObjectLabelsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetModifiedRange())
            {
                context.Writer.WritePropertyName("ModifiedRange");
                context.Writer.WriteStartObject();

                var marshaller = DateRangeTypeMarshaller.Instance;
                marshaller.Marshall(requestObject.ModifiedRange, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPrincipals())
            {
                context.Writer.WritePropertyName("Principals");
                context.Writer.WriteStartArray();
                foreach(var requestObjectPrincipalsListValue in requestObject.Principals)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = SearchPrincipalTypeMarshaller.Instance;
                    marshaller.Marshall(requestObjectPrincipalsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetResourceTypes())
            {
                context.Writer.WritePropertyName("ResourceTypes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectResourceTypesListValue in requestObject.ResourceTypes)
                {
                        context.Writer.WriteStringValue(requestObjectResourceTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSearchCollectionTypes())
            {
                context.Writer.WritePropertyName("SearchCollectionTypes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSearchCollectionTypesListValue in requestObject.SearchCollectionTypes)
                {
                        context.Writer.WriteStringValue(requestObjectSearchCollectionTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSizeRange())
            {
                context.Writer.WritePropertyName("SizeRange");
                context.Writer.WriteStartObject();

                var marshaller = LongRangeTypeMarshaller.Instance;
                marshaller.Marshall(requestObject.SizeRange, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTextLocales())
            {
                context.Writer.WritePropertyName("TextLocales");
                context.Writer.WriteStartArray();
                foreach(var requestObjectTextLocalesListValue in requestObject.TextLocales)
                {
                        context.Writer.WriteStringValue(requestObjectTextLocalesListValue);
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static FiltersMarshaller Instance = new FiltersMarshaller();

    }
}