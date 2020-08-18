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
    /// AwsKmsKeyDetails Marshaller
    /// </summary>       
    public class AwsKmsKeyDetailsMarshaller : IRequestMarshaller<AwsKmsKeyDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsKmsKeyDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAWSAccountId())
            {
                context.Writer.WritePropertyName("AWSAccountId");
                context.Writer.Write(requestObject.AWSAccountId);
            }

            if(requestObject.IsSetCreationDate())
            {
                context.Writer.WritePropertyName("CreationDate");
                context.Writer.Write(requestObject.CreationDate);
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.Write(requestObject.Description);
            }

            if(requestObject.IsSetKeyId())
            {
                context.Writer.WritePropertyName("KeyId");
                context.Writer.Write(requestObject.KeyId);
            }

            if(requestObject.IsSetKeyManager())
            {
                context.Writer.WritePropertyName("KeyManager");
                context.Writer.Write(requestObject.KeyManager);
            }

            if(requestObject.IsSetKeyState())
            {
                context.Writer.WritePropertyName("KeyState");
                context.Writer.Write(requestObject.KeyState);
            }

            if(requestObject.IsSetOrigin())
            {
                context.Writer.WritePropertyName("Origin");
                context.Writer.Write(requestObject.Origin);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static AwsKmsKeyDetailsMarshaller Instance = new AwsKmsKeyDetailsMarshaller();

    }
}