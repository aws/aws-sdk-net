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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Macie2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Macie2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TagScopeTerm Marshaller
    /// </summary>
    public class TagScopeTermMarshaller : IRequestMarshaller<TagScopeTerm, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TagScopeTerm requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetComparator())
            {
                context.Writer.WritePropertyName("comparator");
                context.Writer.WriteStringValue(requestObject.Comparator);
            }

            if(requestObject.IsSetKey())
            {
                context.Writer.WritePropertyName("key");
                context.Writer.WriteStringValue(requestObject.Key);
            }

            if(requestObject.IsSetTagValues())
            {
                context.Writer.WritePropertyName("tagValues");
                context.Writer.WriteStartArray();
                foreach(var requestObjectTagValuesListValue in requestObject.TagValues)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagValuePairMarshaller.Instance;
                    marshaller.Marshall(requestObjectTagValuesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetTarget())
            {
                context.Writer.WritePropertyName("target");
                context.Writer.WriteStringValue(requestObject.Target);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TagScopeTermMarshaller Instance = new TagScopeTermMarshaller();

    }
}