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
 * Do not modify this file. This file is generated from the kafka-2018-11-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Kafka.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Kafka.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// KafkaClusterSaslOAuthBearerAuthentication Marshaller
    /// </summary>
    public class KafkaClusterSaslOAuthBearerAuthenticationMarshaller : IRequestMarshaller<KafkaClusterSaslOAuthBearerAuthentication, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(KafkaClusterSaslOAuthBearerAuthentication requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetClientCredentials())
            {
                context.Writer.WritePropertyName("clientCredentials");
                context.Writer.WriteStartObject();

                var marshaller = KafkaClusterOAuthClientCredentialsMarshaller.Instance;
                marshaller.Marshall(requestObject.ClientCredentials, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetClientCredentialsAssertion())
            {
                context.Writer.WritePropertyName("clientCredentialsAssertion");
                context.Writer.WriteStartObject();

                var marshaller = KafkaClusterOAuthClientCredentialsAssertionMarshaller.Instance;
                marshaller.Marshall(requestObject.ClientCredentialsAssertion, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetIamJwtBearer())
            {
                context.Writer.WritePropertyName("iamJwtBearer");
                context.Writer.WriteStartObject();

                var marshaller = KafkaClusterOAuthIamJwtBearerMarshaller.Instance;
                marshaller.Marshall(requestObject.IamJwtBearer, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetScope())
            {
                context.Writer.WritePropertyName("scope");
                context.Writer.WriteStringValue(requestObject.Scope);
            }

            if(requestObject.IsSetTokenEndpointAuthenticationMethod())
            {
                context.Writer.WritePropertyName("tokenEndpointAuthenticationMethod");
                context.Writer.WriteStringValue(requestObject.TokenEndpointAuthenticationMethod);
            }

            if(requestObject.IsSetTokenEndpointTlsCertificateArn())
            {
                context.Writer.WritePropertyName("tokenEndpointTlsCertificateArn");
                context.Writer.WriteStringValue(requestObject.TokenEndpointTlsCertificateArn);
            }

            if(requestObject.IsSetTokenEndpointUrl())
            {
                context.Writer.WritePropertyName("tokenEndpointUrl");
                context.Writer.WriteStringValue(requestObject.TokenEndpointUrl);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static KafkaClusterSaslOAuthBearerAuthenticationMarshaller Instance = new KafkaClusterSaslOAuthBearerAuthenticationMarshaller();

    }
}