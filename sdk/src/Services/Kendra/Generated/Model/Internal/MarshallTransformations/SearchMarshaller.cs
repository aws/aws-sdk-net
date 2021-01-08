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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Kendra.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Kendra.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Search Marshaller
    /// </summary>       
    public class SearchMarshaller : IRequestMarshaller<Search, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Search requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDisplayable())
            {
                context.Writer.WritePropertyName("Displayable");
                context.Writer.Write(requestObject.Displayable);
            }

            if(requestObject.IsSetFacetable())
            {
                context.Writer.WritePropertyName("Facetable");
                context.Writer.Write(requestObject.Facetable);
            }

            if(requestObject.IsSetSearchable())
            {
                context.Writer.WritePropertyName("Searchable");
                context.Writer.Write(requestObject.Searchable);
            }

            if(requestObject.IsSetSortable())
            {
                context.Writer.WritePropertyName("Sortable");
                context.Writer.Write(requestObject.Sortable);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static SearchMarshaller Instance = new SearchMarshaller();

    }
}