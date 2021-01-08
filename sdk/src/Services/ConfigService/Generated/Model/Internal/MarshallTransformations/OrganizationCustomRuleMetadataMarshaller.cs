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
using ThirdParty.Json.LitJson;

namespace Amazon.ConfigService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// OrganizationCustomRuleMetadata Marshaller
    /// </summary>       
    public class OrganizationCustomRuleMetadataMarshaller : IRequestMarshaller<OrganizationCustomRuleMetadata, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(OrganizationCustomRuleMetadata requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.Write(requestObject.Description);
            }

            if(requestObject.IsSetInputParameters())
            {
                context.Writer.WritePropertyName("InputParameters");
                context.Writer.Write(requestObject.InputParameters);
            }

            if(requestObject.IsSetLambdaFunctionArn())
            {
                context.Writer.WritePropertyName("LambdaFunctionArn");
                context.Writer.Write(requestObject.LambdaFunctionArn);
            }

            if(requestObject.IsSetMaximumExecutionFrequency())
            {
                context.Writer.WritePropertyName("MaximumExecutionFrequency");
                context.Writer.Write(requestObject.MaximumExecutionFrequency);
            }

            if(requestObject.IsSetOrganizationConfigRuleTriggerTypes())
            {
                context.Writer.WritePropertyName("OrganizationConfigRuleTriggerTypes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectOrganizationConfigRuleTriggerTypesListValue in requestObject.OrganizationConfigRuleTriggerTypes)
                {
                        context.Writer.Write(requestObjectOrganizationConfigRuleTriggerTypesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetResourceIdScope())
            {
                context.Writer.WritePropertyName("ResourceIdScope");
                context.Writer.Write(requestObject.ResourceIdScope);
            }

            if(requestObject.IsSetResourceTypesScope())
            {
                context.Writer.WritePropertyName("ResourceTypesScope");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectResourceTypesScopeListValue in requestObject.ResourceTypesScope)
                {
                        context.Writer.Write(requestObjectResourceTypesScopeListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetTagKeyScope())
            {
                context.Writer.WritePropertyName("TagKeyScope");
                context.Writer.Write(requestObject.TagKeyScope);
            }

            if(requestObject.IsSetTagValueScope())
            {
                context.Writer.WritePropertyName("TagValueScope");
                context.Writer.Write(requestObject.TagValueScope);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static OrganizationCustomRuleMetadataMarshaller Instance = new OrganizationCustomRuleMetadataMarshaller();

    }
}