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
 * Do not modify this file. This file is generated from the lakeformation-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LakeFormation.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.LakeFormation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// QuerySessionContext Marshaller
    /// </summary>
    public class QuerySessionContextMarshaller : IRequestMarshaller<QuerySessionContext, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(QuerySessionContext requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAdditionalContext())
            {
                context.Writer.WritePropertyName("AdditionalContext");
                context.Writer.WriteStartObject();
                foreach (var requestObjectAdditionalContextKvp in requestObject.AdditionalContext)
                {
                    context.Writer.WritePropertyName(requestObjectAdditionalContextKvp.Key);
                    var requestObjectAdditionalContextValue = requestObjectAdditionalContextKvp.Value;

                        context.Writer.WriteStringValue(requestObjectAdditionalContextValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetClusterId())
            {
                context.Writer.WritePropertyName("ClusterId");
                context.Writer.WriteStringValue(requestObject.ClusterId);
            }

            if(requestObject.IsSetQueryAuthorizationId())
            {
                context.Writer.WritePropertyName("QueryAuthorizationId");
                context.Writer.WriteStringValue(requestObject.QueryAuthorizationId);
            }

            if(requestObject.IsSetQueryId())
            {
                context.Writer.WritePropertyName("QueryId");
                context.Writer.WriteStringValue(requestObject.QueryId);
            }

            if(requestObject.IsSetQueryStartTime())
            {
                context.Writer.WritePropertyName("QueryStartTime");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(requestObject.QueryStartTime.Value)));
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static QuerySessionContextMarshaller Instance = new QuerySessionContextMarshaller();

    }
}