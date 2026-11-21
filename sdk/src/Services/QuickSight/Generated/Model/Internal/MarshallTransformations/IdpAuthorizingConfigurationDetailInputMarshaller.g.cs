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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.QuickSight.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// IdpAuthorizingConfigurationDetailInput Marshaller
    /// </summary>
    public partial class IdpAuthorizingConfigurationDetailInputMarshaller : IRequestMarshaller<IdpAuthorizingConfigurationDetailInput, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(IdpAuthorizingConfigurationDetailInput requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetExternalIdpConfidentialAuthCode())
            {
                context.Writer.WritePropertyName("ExternalIdpConfidentialAuthCode");
                context.Writer.WriteStartObject();

                var marshaller = ExternalIdpConfidentialAuthCodeAuthorizingConfigInputMarshaller.Instance;
                marshaller.Marshall(requestObject.ExternalIdpConfidentialAuthCode, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetExternalIdpPublicAuthCode())
            {
                context.Writer.WritePropertyName("ExternalIdpPublicAuthCode");
                context.Writer.WriteStartObject();

                var marshaller = ExternalIdpPublicAuthCodeAuthorizingConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.ExternalIdpPublicAuthCode, context);

                context.Writer.WriteEndObject();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static IdpAuthorizingConfigurationDetailInputMarshaller Instance = new IdpAuthorizingConfigurationDetailInputMarshaller();
    }
}
