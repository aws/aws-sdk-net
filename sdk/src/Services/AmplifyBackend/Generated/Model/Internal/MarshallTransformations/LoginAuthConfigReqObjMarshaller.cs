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
 * Do not modify this file. This file is generated from the amplifybackend-2020-08-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AmplifyBackend.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.AmplifyBackend.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// LoginAuthConfigReqObj Marshaller
    /// </summary>
    public class LoginAuthConfigReqObjMarshaller : IRequestMarshaller<LoginAuthConfigReqObj, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(LoginAuthConfigReqObj requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAwsCognitoIdentityPoolId())
            {
                context.Writer.WritePropertyName("aws_cognito_identity_pool_id");
                context.Writer.WriteStringValue(requestObject.AwsCognitoIdentityPoolId);
            }

            if(requestObject.IsSetAwsCognitoRegion())
            {
                context.Writer.WritePropertyName("aws_cognito_region");
                context.Writer.WriteStringValue(requestObject.AwsCognitoRegion);
            }

            if(requestObject.IsSetAwsUserPoolsId())
            {
                context.Writer.WritePropertyName("aws_user_pools_id");
                context.Writer.WriteStringValue(requestObject.AwsUserPoolsId);
            }

            if(requestObject.IsSetAwsUserPoolsWebClientId())
            {
                context.Writer.WritePropertyName("aws_user_pools_web_client_id");
                context.Writer.WriteStringValue(requestObject.AwsUserPoolsWebClientId);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static LoginAuthConfigReqObjMarshaller Instance = new LoginAuthConfigReqObjMarshaller();

    }
}