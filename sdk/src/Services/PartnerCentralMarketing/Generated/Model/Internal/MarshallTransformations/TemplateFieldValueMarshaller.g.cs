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

using Amazon.PartnerCentralMarketing.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.PartnerCentralMarketing.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TemplateFieldValue Marshaller
    /// </summary>
    public partial class TemplateFieldValueMarshaller : IRequestMarshaller<TemplateFieldValue, CborMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(TemplateFieldValue requestObject, CborMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetCampaignAssetImage())
            {
                context.Writer.WriteTextString("CampaignAssetImage");
                context.Writer.WriteStartMap(null);

                var marshaller = CampaignAssetImageSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.CampaignAssetImage, context);

                context.Writer.WriteEndMap();
            }

            if (requestObject.IsSetImageReference())
            {
                context.Writer.WriteTextString("ImageReference");
                context.Writer.WriteTextString(requestObject.ImageReference);
            }

            if (requestObject.IsSetLinkedAssetId())
            {
                context.Writer.WriteTextString("LinkedAssetId");
                context.Writer.WriteTextString(requestObject.LinkedAssetId);
            }

            if (requestObject.IsSetText())
            {
                context.Writer.WriteTextString("Text");
                context.Writer.WriteTextString(requestObject.Text);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static TemplateFieldValueMarshaller Instance = new TemplateFieldValueMarshaller();
    }
}
