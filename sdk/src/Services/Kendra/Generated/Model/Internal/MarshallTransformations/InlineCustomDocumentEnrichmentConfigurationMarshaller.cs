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
    /// InlineCustomDocumentEnrichmentConfiguration Marshaller
    /// </summary>
    public class InlineCustomDocumentEnrichmentConfigurationMarshaller : IRequestMarshaller<InlineCustomDocumentEnrichmentConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(InlineCustomDocumentEnrichmentConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCondition())
            {
                context.Writer.WritePropertyName("Condition");
                context.Writer.WriteStartObject();

                var marshaller = DocumentAttributeConditionMarshaller.Instance;
                marshaller.Marshall(requestObject.Condition, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDocumentContentDeletion())
            {
                context.Writer.WritePropertyName("DocumentContentDeletion");
                context.Writer.WriteBooleanValue(requestObject.DocumentContentDeletion.Value);
            }

            if(requestObject.IsSetTarget())
            {
                context.Writer.WritePropertyName("Target");
                context.Writer.WriteStartObject();

                var marshaller = DocumentAttributeTargetMarshaller.Instance;
                marshaller.Marshall(requestObject.Target, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static InlineCustomDocumentEnrichmentConfigurationMarshaller Instance = new InlineCustomDocumentEnrichmentConfigurationMarshaller();

    }
}