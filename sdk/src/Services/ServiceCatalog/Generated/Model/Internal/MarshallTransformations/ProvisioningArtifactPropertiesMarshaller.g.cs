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

using Amazon.ServiceCatalog.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.ServiceCatalog.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ProvisioningArtifactProperties Marshaller
    /// </summary>
    public partial class ProvisioningArtifactPropertiesMarshaller : IRequestMarshaller<ProvisioningArtifactProperties, CborMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(ProvisioningArtifactProperties requestObject, CborMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetDescription())
            {
                context.Writer.WriteTextString("Description");
                context.Writer.WriteTextString(requestObject.Description);
            }

            if (requestObject.IsSetDisableTemplateValidation())
            {
                context.Writer.WriteTextString("DisableTemplateValidation");
                context.Writer.WriteBoolean(requestObject.DisableTemplateValidation.Value);
            }

            if (requestObject.IsSetInfo())
            {
                context.Writer.WriteTextString("Info");
                context.Writer.WriteStartMap(null);
                foreach (var requestObjectInfoKvp in requestObject.Info)
                {
                    context.Writer.WriteTextString(requestObjectInfoKvp.Key);
                    var requestObjectInfoValue = requestObjectInfoKvp.Value;
                    context.Writer.WriteTextString(requestObjectInfoValue);
                }
                context.Writer.WriteEndMap();
            }

            if (requestObject.IsSetName())
            {
                context.Writer.WriteTextString("Name");
                context.Writer.WriteTextString(requestObject.Name);
            }

            if (requestObject.IsSetType())
            {
                context.Writer.WriteTextString("Type");
                context.Writer.WriteTextString(requestObject.Type);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static ProvisioningArtifactPropertiesMarshaller Instance = new ProvisioningArtifactPropertiesMarshaller();
    }
}
