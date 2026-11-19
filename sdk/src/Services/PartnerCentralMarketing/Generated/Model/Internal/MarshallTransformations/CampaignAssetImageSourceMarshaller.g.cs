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
    /// CampaignAssetImageSource Marshaller
    /// </summary>
    public partial class CampaignAssetImageSourceMarshaller : IRequestMarshaller<CampaignAssetImageSource, CborMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(CampaignAssetImageSource requestObject, CborMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetCampaignAssetIdentifier())
            {
                context.Writer.WriteTextString("CampaignAssetIdentifier");
                context.Writer.WriteTextString(requestObject.CampaignAssetIdentifier);
            }

            if (requestObject.IsSetCampaignIdentifier())
            {
                context.Writer.WriteTextString("CampaignIdentifier");
                context.Writer.WriteTextString(requestObject.CampaignIdentifier);
            }

            if (requestObject.IsSetFieldId())
            {
                context.Writer.WriteTextString("FieldId");
                context.Writer.WriteTextString(requestObject.FieldId);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static CampaignAssetImageSourceMarshaller Instance = new CampaignAssetImageSourceMarshaller();
    }
}
