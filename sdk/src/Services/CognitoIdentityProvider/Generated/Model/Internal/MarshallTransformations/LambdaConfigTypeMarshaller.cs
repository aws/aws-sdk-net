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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CognitoIdentityProvider.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// LambdaConfigType Marshaller
    /// </summary>       
    public class LambdaConfigTypeMarshaller : IRequestMarshaller<LambdaConfigType, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(LambdaConfigType requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCreateAuthChallenge())
            {
                context.Writer.WritePropertyName("CreateAuthChallenge");
                context.Writer.Write(requestObject.CreateAuthChallenge);
            }

            if(requestObject.IsSetCustomMessage())
            {
                context.Writer.WritePropertyName("CustomMessage");
                context.Writer.Write(requestObject.CustomMessage);
            }

            if(requestObject.IsSetDefineAuthChallenge())
            {
                context.Writer.WritePropertyName("DefineAuthChallenge");
                context.Writer.Write(requestObject.DefineAuthChallenge);
            }

            if(requestObject.IsSetPostAuthentication())
            {
                context.Writer.WritePropertyName("PostAuthentication");
                context.Writer.Write(requestObject.PostAuthentication);
            }

            if(requestObject.IsSetPostConfirmation())
            {
                context.Writer.WritePropertyName("PostConfirmation");
                context.Writer.Write(requestObject.PostConfirmation);
            }

            if(requestObject.IsSetPreAuthentication())
            {
                context.Writer.WritePropertyName("PreAuthentication");
                context.Writer.Write(requestObject.PreAuthentication);
            }

            if(requestObject.IsSetPreSignUp())
            {
                context.Writer.WritePropertyName("PreSignUp");
                context.Writer.Write(requestObject.PreSignUp);
            }

            if(requestObject.IsSetPreTokenGeneration())
            {
                context.Writer.WritePropertyName("PreTokenGeneration");
                context.Writer.Write(requestObject.PreTokenGeneration);
            }

            if(requestObject.IsSetUserMigration())
            {
                context.Writer.WritePropertyName("UserMigration");
                context.Writer.Write(requestObject.UserMigration);
            }

            if(requestObject.IsSetVerifyAuthChallengeResponse())
            {
                context.Writer.WritePropertyName("VerifyAuthChallengeResponse");
                context.Writer.Write(requestObject.VerifyAuthChallengeResponse);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static LambdaConfigTypeMarshaller Instance = new LambdaConfigTypeMarshaller();

    }
}