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
    /// AwsIamInstanceProfile Marshaller
    /// </summary>
    public class AwsIamInstanceProfileMarshaller : IRequestMarshaller<AwsIamInstanceProfile, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsIamInstanceProfile requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetArn())
            {
                context.Writer.WritePropertyName("Arn");
                context.Writer.WriteStringValue(requestObject.Arn);
            }

            if(requestObject.IsSetCreateDate())
            {
                context.Writer.WritePropertyName("CreateDate");
                context.Writer.WriteStringValue(requestObject.CreateDate);
            }

            if(requestObject.IsSetInstanceProfileId())
            {
                context.Writer.WritePropertyName("InstanceProfileId");
                context.Writer.WriteStringValue(requestObject.InstanceProfileId);
            }

            if(requestObject.IsSetInstanceProfileName())
            {
                context.Writer.WritePropertyName("InstanceProfileName");
                context.Writer.WriteStringValue(requestObject.InstanceProfileName);
            }

            if(requestObject.IsSetPath())
            {
                context.Writer.WritePropertyName("Path");
                context.Writer.WriteStringValue(requestObject.Path);
            }

            if(requestObject.IsSetRoles())
            {
                context.Writer.WritePropertyName("Roles");
                context.Writer.WriteStartArray();
                foreach(var requestObjectRolesListValue in requestObject.Roles)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsIamInstanceProfileRoleMarshaller.Instance;
                    marshaller.Marshall(requestObjectRolesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsIamInstanceProfileMarshaller Instance = new AwsIamInstanceProfileMarshaller();

    }
}