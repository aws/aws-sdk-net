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
    /// AwsIamInstanceProfileRole Marshaller
    /// </summary>       
    public class AwsIamInstanceProfileRoleMarshaller : IRequestMarshaller<AwsIamInstanceProfileRole, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsIamInstanceProfileRole requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetArn())
            {
                context.Writer.WritePropertyName("Arn");
                context.Writer.Write(requestObject.Arn);
            }

            if(requestObject.IsSetAssumeRolePolicyDocument())
            {
                context.Writer.WritePropertyName("AssumeRolePolicyDocument");
                context.Writer.Write(requestObject.AssumeRolePolicyDocument);
            }

            if(requestObject.IsSetCreateDate())
            {
                context.Writer.WritePropertyName("CreateDate");
                context.Writer.Write(requestObject.CreateDate);
            }

            if(requestObject.IsSetPath())
            {
                context.Writer.WritePropertyName("Path");
                context.Writer.Write(requestObject.Path);
            }

            if(requestObject.IsSetRoleId())
            {
                context.Writer.WritePropertyName("RoleId");
                context.Writer.Write(requestObject.RoleId);
            }

            if(requestObject.IsSetRoleName())
            {
                context.Writer.WritePropertyName("RoleName");
                context.Writer.Write(requestObject.RoleName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static AwsIamInstanceProfileRoleMarshaller Instance = new AwsIamInstanceProfileRoleMarshaller();

    }
}