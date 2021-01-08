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
using ThirdParty.Json.LitJson;

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsIamPolicyDetails Marshaller
    /// </summary>       
    public class AwsIamPolicyDetailsMarshaller : IRequestMarshaller<AwsIamPolicyDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsIamPolicyDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAttachmentCount())
            {
                context.Writer.WritePropertyName("AttachmentCount");
                context.Writer.Write(requestObject.AttachmentCount);
            }

            if(requestObject.IsSetCreateDate())
            {
                context.Writer.WritePropertyName("CreateDate");
                context.Writer.Write(requestObject.CreateDate);
            }

            if(requestObject.IsSetDefaultVersionId())
            {
                context.Writer.WritePropertyName("DefaultVersionId");
                context.Writer.Write(requestObject.DefaultVersionId);
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.Write(requestObject.Description);
            }

            if(requestObject.IsSetIsAttachable())
            {
                context.Writer.WritePropertyName("IsAttachable");
                context.Writer.Write(requestObject.IsAttachable);
            }

            if(requestObject.IsSetPath())
            {
                context.Writer.WritePropertyName("Path");
                context.Writer.Write(requestObject.Path);
            }

            if(requestObject.IsSetPermissionsBoundaryUsageCount())
            {
                context.Writer.WritePropertyName("PermissionsBoundaryUsageCount");
                context.Writer.Write(requestObject.PermissionsBoundaryUsageCount);
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

            if(requestObject.IsSetPolicyVersionList())
            {
                context.Writer.WritePropertyName("PolicyVersionList");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectPolicyVersionListListValue in requestObject.PolicyVersionList)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsIamPolicyVersionMarshaller.Instance;
                    marshaller.Marshall(requestObjectPolicyVersionListListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetUpdateDate())
            {
                context.Writer.WritePropertyName("UpdateDate");
                context.Writer.Write(requestObject.UpdateDate);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static AwsIamPolicyDetailsMarshaller Instance = new AwsIamPolicyDetailsMarshaller();

    }
}