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
#pragma warning disable CS0612,CS0618
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
            if(requestObject == null)
                return;
            if(requestObject.IsSetDeleteUnusedFMManagedResources())
            {
                context.Writer.WritePropertyName("DeleteUnusedFMManagedResources");
                context.Writer.WriteBooleanValue(requestObject.DeleteUnusedFMManagedResources.Value);
            }

            if(requestObject.IsSetExcludeMap())
            {
                context.Writer.WritePropertyName("ExcludeMap");
                context.Writer.WriteStartObject();
                foreach (var requestObjectExcludeMapKvp in requestObject.ExcludeMap)
                {
                    context.Writer.WritePropertyName(requestObjectExcludeMapKvp.Key);
                    var requestObjectExcludeMapValue = requestObjectExcludeMapKvp.Value;

                    context.Writer.WriteStartArray();
                    foreach(var requestObjectExcludeMapValueListValue in requestObjectExcludeMapValue)
                    {
                            context.Writer.WriteStringValue(requestObjectExcludeMapValueListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetExcludeResourceTags())
            {
                context.Writer.WritePropertyName("ExcludeResourceTags");
                context.Writer.WriteBooleanValue(requestObject.ExcludeResourceTags.Value);
            }

            if(requestObject.IsSetIncludeMap())
            {
                context.Writer.WritePropertyName("IncludeMap");
                context.Writer.WriteStartObject();
                foreach (var requestObjectIncludeMapKvp in requestObject.IncludeMap)
                {
                    context.Writer.WritePropertyName(requestObjectIncludeMapKvp.Key);
                    var requestObjectIncludeMapValue = requestObjectIncludeMapKvp.Value;

                    context.Writer.WriteStartArray();
                    foreach(var requestObjectIncludeMapValueListValue in requestObjectIncludeMapValue)
                    {
                            context.Writer.WriteStringValue(requestObjectIncludeMapValueListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPolicyDescription())
            {
                context.Writer.WritePropertyName("PolicyDescription");
                context.Writer.WriteStringValue(requestObject.PolicyDescription);
            }

            if(requestObject.IsSetPolicyId())
            {
                context.Writer.WritePropertyName("PolicyId");
                context.Writer.WriteStringValue(requestObject.PolicyId);
            }

            if(requestObject.IsSetPolicyName())
            {
                context.Writer.WritePropertyName("PolicyName");
                context.Writer.WriteStringValue(requestObject.PolicyName);
            }

            if(requestObject.IsSetPolicyStatus())
            {
                context.Writer.WritePropertyName("PolicyStatus");
                context.Writer.WriteStringValue(requestObject.PolicyStatus);
            }

            if(requestObject.IsSetPolicyUpdateToken())
            {
                context.Writer.WritePropertyName("PolicyUpdateToken");
                context.Writer.WriteStringValue(requestObject.PolicyUpdateToken);
            }

            if(requestObject.IsSetRemediationEnabled())
            {
                context.Writer.WritePropertyName("RemediationEnabled");
                context.Writer.WriteBooleanValue(requestObject.RemediationEnabled.Value);
            }

            if(requestObject.IsSetResourceSetIds())
            {
                context.Writer.WritePropertyName("ResourceSetIds");
                context.Writer.WriteStartArray();
                foreach(var requestObjectResourceSetIdsListValue in requestObject.ResourceSetIds)
                {
                        context.Writer.WriteStringValue(requestObjectResourceSetIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetResourceTagLogicalOperator())
            {
                context.Writer.WritePropertyName("ResourceTagLogicalOperator");
                context.Writer.WriteStringValue(requestObject.ResourceTagLogicalOperator);
            }

            if(requestObject.IsSetResourceTags())
            {
                context.Writer.WritePropertyName("ResourceTags");
                context.Writer.WriteStartArray();
                foreach(var requestObjectResourceTagsListValue in requestObject.ResourceTags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ResourceTagMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetResourceType())
            {
                context.Writer.WritePropertyName("ResourceType");
                context.Writer.WriteStringValue(requestObject.ResourceType);
            }

            if(requestObject.IsSetResourceTypeList())
            {
                context.Writer.WritePropertyName("ResourceTypeList");
                context.Writer.WriteStartArray();
                foreach(var requestObjectResourceTypeListListValue in requestObject.ResourceTypeList)
                {
                        context.Writer.WriteStringValue(requestObjectResourceTypeListListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSecurityServicePolicyData())
            {
                context.Writer.WritePropertyName("SecurityServicePolicyData");
                context.Writer.WriteStartObject();

                var marshaller = SecurityServicePolicyDataMarshaller.Instance;
                marshaller.Marshall(requestObject.SecurityServicePolicyData, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PolicyMarshaller Instance = new PolicyMarshaller();

    }
}