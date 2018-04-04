/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.FMS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.FMS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Policy Marshaller
    /// </summary>       
    public class PolicyMarshaller : IRequestMarshaller<Policy, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Policy requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetExcludeResourceTags())
            {
                context.Writer.WritePropertyName("ExcludeResourceTags");
                context.Writer.Write(requestObject.ExcludeResourceTags);
            }

            if(requestObject.IsSetPolicyId())
            {
                context.Writer.WritePropertyName("PolicyId");
                context.Writer.Write(requestObject.PolicyId);
            }

            if(requestObject.IsSetPolicyName())
            {
                context.Writer.WritePropertyName("PolicyName");
                context.Writer.Write(requestObject.PolicyName);
            }

            if(requestObject.IsSetPolicyUpdateToken())
            {
                context.Writer.WritePropertyName("PolicyUpdateToken");
                context.Writer.Write(requestObject.PolicyUpdateToken);
            }

            if(requestObject.IsSetRemediationEnabled())
            {
                context.Writer.WritePropertyName("RemediationEnabled");
                context.Writer.Write(requestObject.RemediationEnabled);
            }

            if(requestObject.IsSetResourceTags())
            {
                context.Writer.WritePropertyName("ResourceTags");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectResourceTagsListValue in requestObject.ResourceTags)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ResourceTagMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceTagsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetResourceType())
            {
                context.Writer.WritePropertyName("ResourceType");
                context.Writer.Write(requestObject.ResourceType);
            }

            if(requestObject.IsSetSecurityServicePolicyData())
            {
                context.Writer.WritePropertyName("SecurityServicePolicyData");
                context.Writer.WriteObjectStart();

                var marshaller = SecurityServicePolicyDataMarshaller.Instance;
                marshaller.Marshall(requestObject.SecurityServicePolicyData, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static PolicyMarshaller Instance = new PolicyMarshaller();

    }
}