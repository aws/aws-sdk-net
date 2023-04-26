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
using ThirdParty.Json.LitJson;

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
            if(requestObject.IsSetAncestorIds())
            {
                context.Writer.WritePropertyName("AncestorIds");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAncestorIdsListValue in requestObject.AncestorIds)
                {
                        context.Writer.Write(requestObjectAncestorIdsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetContentCategories())
            {
                context.Writer.WritePropertyName("ContentCategories");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectContentCategoriesListValue in requestObject.ContentCategories)
                {
                        context.Writer.Write(requestObjectContentCategoriesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetCreatedRange())
            {
                context.Writer.WritePropertyName("CreatedRange");
                context.Writer.WriteObjectStart();

                var marshaller = DateRangeTypeMarshaller.Instance;
                marshaller.Marshall(requestObject.CreatedRange, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetLabels())
            {
                context.Writer.WritePropertyName("Labels");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectLabelsListValue in requestObject.Labels)
                {
                        context.Writer.Write(requestObjectLabelsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetModifiedRange())
            {
                context.Writer.WritePropertyName("ModifiedRange");
                context.Writer.WriteObjectStart();

                var marshaller = DateRangeTypeMarshaller.Instance;
                marshaller.Marshall(requestObject.ModifiedRange, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetPrincipals())
            {
                context.Writer.WritePropertyName("Principals");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectPrincipalsListValue in requestObject.Principals)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = SearchPrincipalTypeMarshaller.Instance;
                    marshaller.Marshall(requestObjectPrincipalsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetResourceTypes())
            {
                context.Writer.WritePropertyName("ResourceTypes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectResourceTypesListValue in requestObject.ResourceTypes)
                {
                        context.Writer.Write(requestObjectResourceTypesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSearchCollectionTypes())
            {
                context.Writer.WritePropertyName("SearchCollectionTypes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSearchCollectionTypesListValue in requestObject.SearchCollectionTypes)
                {
                        context.Writer.Write(requestObjectSearchCollectionTypesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSizeRange())
            {
                context.Writer.WritePropertyName("SizeRange");
                context.Writer.WriteObjectStart();

                var marshaller = LongRangeTypeMarshaller.Instance;
                marshaller.Marshall(requestObject.SizeRange, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTextLocales())
            {
                context.Writer.WritePropertyName("TextLocales");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectTextLocalesListValue in requestObject.TextLocales)
                {
                        context.Writer.Write(requestObjectTextLocalesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static FiltersMarshaller Instance = new FiltersMarshaller();

    }
}