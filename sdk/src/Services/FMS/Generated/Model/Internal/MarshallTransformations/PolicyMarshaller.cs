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
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.FMS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Policy Marshaller
    /// </summary>
    public class PolicyMarshaller : IRequestMarshaller<Policy, CborMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Policy requestObject, CborMarshallerContext context)
        {
            if (requestObject == null)
                return;

            if (requestObject.IsSetDeleteUnusedFMManagedResources())
            {
                context.Writer.WriteTextString("DeleteUnusedFMManagedResources");
                context.Writer.WriteBoolean(requestObject.DeleteUnusedFMManagedResources.Value);
            }
            if (requestObject.IsSetExcludeMap())
            {
                context.Writer.WriteTextString("ExcludeMap");
                context.Writer.WriteStartMap(null);
                foreach (var requestObjectExcludeMapKvp in requestObject.ExcludeMap)
                {
                    context.Writer.WriteTextString(requestObjectExcludeMapKvp.Key);
                    var requestObjectExcludeMapValue = requestObjectExcludeMapKvp.Value;

                    context.Writer.WriteStartArray(requestObjectExcludeMapValue.Count);
                    foreach(var requestObjectExcludeMapValueListValue in requestObjectExcludeMapValue)
                    {
                            context.Writer.WriteTextString(requestObjectExcludeMapValueListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetExcludeResourceTags())
            {
                context.Writer.WriteTextString("ExcludeResourceTags");
                context.Writer.WriteBoolean(requestObject.ExcludeResourceTags.Value);
            }
            if (requestObject.IsSetIncludeMap())
            {
                context.Writer.WriteTextString("IncludeMap");
                context.Writer.WriteStartMap(null);
                foreach (var requestObjectIncludeMapKvp in requestObject.IncludeMap)
                {
                    context.Writer.WriteTextString(requestObjectIncludeMapKvp.Key);
                    var requestObjectIncludeMapValue = requestObjectIncludeMapKvp.Value;

                    context.Writer.WriteStartArray(requestObjectIncludeMapValue.Count);
                    foreach(var requestObjectIncludeMapValueListValue in requestObjectIncludeMapValue)
                    {
                            context.Writer.WriteTextString(requestObjectIncludeMapValueListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetPolicyDescription())
            {
                context.Writer.WriteTextString("PolicyDescription");
                context.Writer.WriteTextString(requestObject.PolicyDescription);
            }
            if (requestObject.IsSetPolicyId())
            {
                context.Writer.WriteTextString("PolicyId");
                context.Writer.WriteTextString(requestObject.PolicyId);
            }
            if (requestObject.IsSetPolicyName())
            {
                context.Writer.WriteTextString("PolicyName");
                context.Writer.WriteTextString(requestObject.PolicyName);
            }
            if (requestObject.IsSetPolicyStatus())
            {
                context.Writer.WriteTextString("PolicyStatus");
                context.Writer.WriteTextString(requestObject.PolicyStatus);
            }
            if (requestObject.IsSetPolicyUpdateToken())
            {
                context.Writer.WriteTextString("PolicyUpdateToken");
                context.Writer.WriteTextString(requestObject.PolicyUpdateToken);
            }
            if (requestObject.IsSetRemediationEnabled())
            {
                context.Writer.WriteTextString("RemediationEnabled");
                context.Writer.WriteBoolean(requestObject.RemediationEnabled.Value);
            }
            if (requestObject.IsSetResourceSetIds())
            {
                context.Writer.WriteTextString("ResourceSetIds");
                context.Writer.WriteStartArray(requestObject.ResourceSetIds.Count);
                foreach(var requestObjectResourceSetIdsListValue in requestObject.ResourceSetIds)
                {
                        context.Writer.WriteTextString(requestObjectResourceSetIdsListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetResourceTagLogicalOperator())
            {
                context.Writer.WriteTextString("ResourceTagLogicalOperator");
                context.Writer.WriteTextString(requestObject.ResourceTagLogicalOperator);
            }
            if (requestObject.IsSetResourceTags())
            {
                context.Writer.WriteTextString("ResourceTags");
                context.Writer.WriteStartArray(requestObject.ResourceTags.Count);
                foreach(var requestObjectResourceTagsListValue in requestObject.ResourceTags)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = ResourceTagMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourceTagsListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetResourceType())
            {
                context.Writer.WriteTextString("ResourceType");
                context.Writer.WriteTextString(requestObject.ResourceType);
            }
            if (requestObject.IsSetResourceTypeList())
            {
                context.Writer.WriteTextString("ResourceTypeList");
                context.Writer.WriteStartArray(requestObject.ResourceTypeList.Count);
                foreach(var requestObjectResourceTypeListListValue in requestObject.ResourceTypeList)
                {
                        context.Writer.WriteTextString(requestObjectResourceTypeListListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetSecurityServicePolicyData())
            {
                context.Writer.WriteTextString("SecurityServicePolicyData");
                context.Writer.WriteStartMap(null);

                var marshaller = SecurityServicePolicyDataMarshaller.Instance;
                marshaller.Marshall(requestObject.SecurityServicePolicyData, context);

                context.Writer.WriteEndMap();
            }
        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PolicyMarshaller Instance = new PolicyMarshaller();

    }
}