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

using Amazon.CognitoIdentityProvider.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DcrConfigurationType Marshaller
    /// </summary>
    public partial class DcrConfigurationTypeMarshaller : IRequestMarshaller<DcrConfigurationType, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(DcrConfigurationType requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetAllowedScopes())
            {
                context.Writer.WritePropertyName("AllowedScopes");
                context.Writer.WriteStartArray();
                foreach (var requestObjectAllowedScopesListValue in requestObject.AllowedScopes)
                {
                    context.Writer.WriteStringValue(requestObjectAllowedScopesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetAuthenticatedGrantTypes())
            {
                context.Writer.WritePropertyName("AuthenticatedGrantTypes");
                context.Writer.WriteStartArray();
                foreach (var requestObjectAuthenticatedGrantTypesListValue in requestObject.AuthenticatedGrantTypes)
                {
                    context.Writer.WriteStringValue(requestObjectAuthenticatedGrantTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetEnableStatus())
            {
                context.Writer.WritePropertyName("EnableStatus");
                context.Writer.WriteStringValue(requestObject.EnableStatus);
            }

            if (requestObject.IsSetOpenDcrEnabled())
            {
                context.Writer.WritePropertyName("OpenDcrEnabled");
                context.Writer.WriteBooleanValue(requestObject.OpenDcrEnabled.Value);
            }

            if (requestObject.IsSetOpenDcrGrantTypes())
            {
                context.Writer.WritePropertyName("OpenDcrGrantTypes");
                context.Writer.WriteStartArray();
                foreach (var requestObjectOpenDcrGrantTypesListValue in requestObject.OpenDcrGrantTypes)
                {
                    context.Writer.WriteStringValue(requestObjectOpenDcrGrantTypesListValue);
                }
                context.Writer.WriteEndArray();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static DcrConfigurationTypeMarshaller Instance = new DcrConfigurationTypeMarshaller();
    }
}
