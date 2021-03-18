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
    /// AwsS3AccountPublicAccessBlockDetails Marshaller
    /// </summary>       
    public class AwsS3AccountPublicAccessBlockDetailsMarshaller : IRequestMarshaller<AwsS3AccountPublicAccessBlockDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsS3AccountPublicAccessBlockDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetBlockPublicAcls())
            {
                context.Writer.WritePropertyName("BlockPublicAcls");
                context.Writer.Write(requestObject.BlockPublicAcls);
            }

            if(requestObject.IsSetBlockPublicPolicy())
            {
                context.Writer.WritePropertyName("BlockPublicPolicy");
                context.Writer.Write(requestObject.BlockPublicPolicy);
            }

            if(requestObject.IsSetIgnorePublicAcls())
            {
                context.Writer.WritePropertyName("IgnorePublicAcls");
                context.Writer.Write(requestObject.IgnorePublicAcls);
            }

            if(requestObject.IsSetRestrictPublicBuckets())
            {
                context.Writer.WritePropertyName("RestrictPublicBuckets");
                context.Writer.Write(requestObject.RestrictPublicBuckets);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static AwsS3AccountPublicAccessBlockDetailsMarshaller Instance = new AwsS3AccountPublicAccessBlockDetailsMarshaller();

    }
}