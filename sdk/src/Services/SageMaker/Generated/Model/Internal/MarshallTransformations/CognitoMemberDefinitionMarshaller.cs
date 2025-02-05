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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CognitoMemberDefinition Marshaller
    /// </summary>
    public class CognitoMemberDefinitionMarshaller : IRequestMarshaller<CognitoMemberDefinition, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CognitoMemberDefinition requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetClientId())
            {
                context.Writer.WritePropertyName("ClientId");
                context.Writer.WriteStringValue(requestObject.ClientId);
            }

            if(requestObject.IsSetUserGroup())
            {
                context.Writer.WritePropertyName("UserGroup");
                context.Writer.WriteStringValue(requestObject.UserGroup);
            }

            if(requestObject.IsSetUserPool())
            {
                context.Writer.WritePropertyName("UserPool");
                context.Writer.WriteStringValue(requestObject.UserPool);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CognitoMemberDefinitionMarshaller Instance = new CognitoMemberDefinitionMarshaller();

    }
}