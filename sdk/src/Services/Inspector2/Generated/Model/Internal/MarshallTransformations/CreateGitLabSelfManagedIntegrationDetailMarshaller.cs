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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Inspector2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Inspector2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateGitLabSelfManagedIntegrationDetail Marshaller
    /// </summary>
    public class CreateGitLabSelfManagedIntegrationDetailMarshaller : IRequestMarshaller<CreateGitLabSelfManagedIntegrationDetail, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CreateGitLabSelfManagedIntegrationDetail requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAccessToken())
            {
                context.Writer.WritePropertyName("accessToken");
                context.Writer.WriteStringValue(requestObject.AccessToken);
            }

            if(requestObject.IsSetInstanceUrl())
            {
                context.Writer.WritePropertyName("instanceUrl");
                context.Writer.WriteStringValue(requestObject.InstanceUrl);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CreateGitLabSelfManagedIntegrationDetailMarshaller Instance = new CreateGitLabSelfManagedIntegrationDetailMarshaller();

    }
}