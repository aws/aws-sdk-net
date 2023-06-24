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
    /// AwsCloudFrontDistributionOriginCustomOriginConfig Marshaller
    /// </summary>
    public class AwsCloudFrontDistributionOriginCustomOriginConfigMarshaller : IRequestMarshaller<AwsCloudFrontDistributionOriginCustomOriginConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsCloudFrontDistributionOriginCustomOriginConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetHttpPort())
            {
                context.Writer.WritePropertyName("HttpPort");
                context.Writer.Write(requestObject.HttpPort);
            }

            if(requestObject.IsSetHttpsPort())
            {
                context.Writer.WritePropertyName("HttpsPort");
                context.Writer.Write(requestObject.HttpsPort);
            }

            if(requestObject.IsSetOriginKeepaliveTimeout())
            {
                context.Writer.WritePropertyName("OriginKeepaliveTimeout");
                context.Writer.Write(requestObject.OriginKeepaliveTimeout);
            }

            if(requestObject.IsSetOriginProtocolPolicy())
            {
                context.Writer.WritePropertyName("OriginProtocolPolicy");
                context.Writer.Write(requestObject.OriginProtocolPolicy);
            }

            if(requestObject.IsSetOriginReadTimeout())
            {
                context.Writer.WritePropertyName("OriginReadTimeout");
                context.Writer.Write(requestObject.OriginReadTimeout);
            }

            if(requestObject.IsSetOriginSslProtocols())
            {
                context.Writer.WritePropertyName("OriginSslProtocols");
                context.Writer.WriteObjectStart();

                var marshaller = AwsCloudFrontDistributionOriginSslProtocolsMarshaller.Instance;
                marshaller.Marshall(requestObject.OriginSslProtocols, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsCloudFrontDistributionOriginCustomOriginConfigMarshaller Instance = new AwsCloudFrontDistributionOriginCustomOriginConfigMarshaller();

    }
}