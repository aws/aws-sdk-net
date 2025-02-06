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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LexModelsV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.LexModelsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// OpensearchConfiguration Marshaller
    /// </summary>
    public class OpensearchConfigurationMarshaller : IRequestMarshaller<OpensearchConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(OpensearchConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDomainEndpoint())
            {
                context.Writer.WritePropertyName("domainEndpoint");
                context.Writer.WriteStringValue(requestObject.DomainEndpoint);
            }

            if(requestObject.IsSetExactResponse())
            {
                context.Writer.WritePropertyName("exactResponse");
                context.Writer.WriteBooleanValue(requestObject.ExactResponse.Value);
            }

            if(requestObject.IsSetExactResponseFields())
            {
                context.Writer.WritePropertyName("exactResponseFields");
                context.Writer.WriteStartObject();

                var marshaller = ExactResponseFieldsMarshaller.Instance;
                marshaller.Marshall(requestObject.ExactResponseFields, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetIncludeFields())
            {
                context.Writer.WritePropertyName("includeFields");
                context.Writer.WriteStartArray();
                foreach(var requestObjectIncludeFieldsListValue in requestObject.IncludeFields)
                {
                        context.Writer.WriteStringValue(requestObjectIncludeFieldsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetIndexName())
            {
                context.Writer.WritePropertyName("indexName");
                context.Writer.WriteStringValue(requestObject.IndexName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static OpensearchConfigurationMarshaller Instance = new OpensearchConfigurationMarshaller();

    }
}