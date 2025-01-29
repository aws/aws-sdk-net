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
#pragma warning disable CS0612,CS0618
namespace Amazon.Kendra.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SalesforceKnowledgeArticleConfiguration Marshaller
    /// </summary>
    public class SalesforceKnowledgeArticleConfigurationMarshaller : IRequestMarshaller<SalesforceKnowledgeArticleConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SalesforceKnowledgeArticleConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCustomKnowledgeArticleTypeConfigurations())
            {
                context.Writer.WritePropertyName("CustomKnowledgeArticleTypeConfigurations");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCustomKnowledgeArticleTypeConfigurationsListValue in requestObject.CustomKnowledgeArticleTypeConfigurations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = SalesforceCustomKnowledgeArticleTypeConfigurationMarshaller.Instance;
                    marshaller.Marshall(requestObjectCustomKnowledgeArticleTypeConfigurationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetIncludedStates())
            {
                context.Writer.WritePropertyName("IncludedStates");
                context.Writer.WriteStartArray();
                foreach(var requestObjectIncludedStatesListValue in requestObject.IncludedStates)
                {
                        context.Writer.WriteStringValue(requestObjectIncludedStatesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetStandardKnowledgeArticleTypeConfiguration())
            {
                context.Writer.WritePropertyName("StandardKnowledgeArticleTypeConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = SalesforceStandardKnowledgeArticleTypeConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.StandardKnowledgeArticleTypeConfiguration, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SalesforceKnowledgeArticleConfigurationMarshaller Instance = new SalesforceKnowledgeArticleConfigurationMarshaller();

    }
}