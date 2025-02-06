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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockAgent.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockAgent.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// QueryGenerationContext Marshaller
    /// </summary>
    public class QueryGenerationContextMarshaller : IRequestMarshaller<QueryGenerationContext, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(QueryGenerationContext requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCuratedQueries())
            {
                context.Writer.WritePropertyName("curatedQueries");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCuratedQueriesListValue in requestObject.CuratedQueries)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CuratedQueryMarshaller.Instance;
                    marshaller.Marshall(requestObjectCuratedQueriesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetTables())
            {
                context.Writer.WritePropertyName("tables");
                context.Writer.WriteStartArray();
                foreach(var requestObjectTablesListValue in requestObject.Tables)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = QueryGenerationTableMarshaller.Instance;
                    marshaller.Marshall(requestObjectTablesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static QueryGenerationContextMarshaller Instance = new QueryGenerationContextMarshaller();

    }
}