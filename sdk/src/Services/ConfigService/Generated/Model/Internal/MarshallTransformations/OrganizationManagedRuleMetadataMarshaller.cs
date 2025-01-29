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
    /// OrganizationManagedRuleMetadata Marshaller
    /// </summary>
    public class OrganizationManagedRuleMetadataMarshaller : IRequestMarshaller<OrganizationManagedRuleMetadata, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(OrganizationManagedRuleMetadata requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(requestObject.Description);
            }

            if(requestObject.IsSetInputParameters())
            {
                context.Writer.WritePropertyName("InputParameters");
                context.Writer.WriteStringValue(requestObject.InputParameters);
            }

            if(requestObject.IsSetMaximumExecutionFrequency())
            {
                context.Writer.WritePropertyName("MaximumExecutionFrequency");
                context.Writer.WriteStringValue(requestObject.MaximumExecutionFrequency);
            }

            if(requestObject.IsSetResourceIdScope())
            {
                context.Writer.WritePropertyName("ResourceIdScope");
                context.Writer.WriteStringValue(requestObject.ResourceIdScope);
            }

            if(requestObject.IsSetResourceTypesScope())
            {
                context.Writer.WritePropertyName("ResourceTypesScope");
                context.Writer.WriteStartArray();
                foreach(var requestObjectResourceTypesScopeListValue in requestObject.ResourceTypesScope)
                {
                        context.Writer.WriteStringValue(requestObjectResourceTypesScopeListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetRuleIdentifier())
            {
                context.Writer.WritePropertyName("RuleIdentifier");
                context.Writer.WriteStringValue(requestObject.RuleIdentifier);
            }

            if(requestObject.IsSetTagKeyScope())
            {
                context.Writer.WritePropertyName("TagKeyScope");
                context.Writer.WriteStringValue(requestObject.TagKeyScope);
            }

            if(requestObject.IsSetTagValueScope())
            {
                context.Writer.WritePropertyName("TagValueScope");
                context.Writer.WriteStringValue(requestObject.TagValueScope);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static OrganizationManagedRuleMetadataMarshaller Instance = new OrganizationManagedRuleMetadataMarshaller();

    }
}