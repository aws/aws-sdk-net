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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsIamRoleDetails Marshaller
    /// </summary>
    public class AwsIamRoleDetailsMarshaller : IRequestMarshaller<AwsIamRoleDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsIamRoleDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAssumeRolePolicyDocument())
            {
                context.Writer.WritePropertyName("AssumeRolePolicyDocument");
                context.Writer.WriteStringValue(requestObject.AssumeRolePolicyDocument);
            }

            if(requestObject.IsSetAttachedManagedPolicies())
            {
                context.Writer.WritePropertyName("AttachedManagedPolicies");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAttachedManagedPoliciesListValue in requestObject.AttachedManagedPolicies)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsIamAttachedManagedPolicyMarshaller.Instance;
                    marshaller.Marshall(requestObjectAttachedManagedPoliciesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCreateDate())
            {
                context.Writer.WritePropertyName("CreateDate");
                context.Writer.WriteStringValue(requestObject.CreateDate);
            }

            if(requestObject.IsSetInstanceProfileList())
            {
                context.Writer.WritePropertyName("InstanceProfileList");
                context.Writer.WriteStartArray();
                foreach(var requestObjectInstanceProfileListListValue in requestObject.InstanceProfileList)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsIamInstanceProfileMarshaller.Instance;
                    marshaller.Marshall(requestObjectInstanceProfileListListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetMaxSessionDuration())
            {
                context.Writer.WritePropertyName("MaxSessionDuration");
                context.Writer.WriteNumberValue(requestObject.MaxSessionDuration.Value);
            }

            if(requestObject.IsSetPath())
            {
                context.Writer.WritePropertyName("Path");
                context.Writer.WriteStringValue(requestObject.Path);
            }

            if(requestObject.IsSetPermissionsBoundary())
            {
                context.Writer.WritePropertyName("PermissionsBoundary");
                context.Writer.WriteStartObject();

                var marshaller = AwsIamPermissionsBoundaryMarshaller.Instance;
                marshaller.Marshall(requestObject.PermissionsBoundary, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRoleId())
            {
                context.Writer.WritePropertyName("RoleId");
                context.Writer.WriteStringValue(requestObject.RoleId);
            }

            if(requestObject.IsSetRoleName())
            {
                context.Writer.WritePropertyName("RoleName");
                context.Writer.WriteStringValue(requestObject.RoleName);
            }

            if(requestObject.IsSetRolePolicyList())
            {
                context.Writer.WritePropertyName("RolePolicyList");
                context.Writer.WriteStartArray();
                foreach(var requestObjectRolePolicyListListValue in requestObject.RolePolicyList)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsIamRolePolicyMarshaller.Instance;
                    marshaller.Marshall(requestObjectRolePolicyListListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsIamRoleDetailsMarshaller Instance = new AwsIamRoleDetailsMarshaller();

    }
}