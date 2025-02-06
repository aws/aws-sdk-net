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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ConfigService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ConfigService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Scope Marshaller
    /// </summary>
    public class ScopeMarshaller : IRequestMarshaller<Scope, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Scope requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetComplianceResourceId())
            {
                context.Writer.WritePropertyName("ComplianceResourceId");
                context.Writer.WriteStringValue(requestObject.ComplianceResourceId);
            }

            if(requestObject.IsSetComplianceResourceTypes())
            {
                context.Writer.WritePropertyName("ComplianceResourceTypes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectComplianceResourceTypesListValue in requestObject.ComplianceResourceTypes)
                {
                        context.Writer.WriteStringValue(requestObjectComplianceResourceTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetTagKey())
            {
                context.Writer.WritePropertyName("TagKey");
                context.Writer.WriteStringValue(requestObject.TagKey);
            }

            if(requestObject.IsSetTagValue())
            {
                context.Writer.WritePropertyName("TagValue");
                context.Writer.WriteStringValue(requestObject.TagValue);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ScopeMarshaller Instance = new ScopeMarshaller();

    }
}