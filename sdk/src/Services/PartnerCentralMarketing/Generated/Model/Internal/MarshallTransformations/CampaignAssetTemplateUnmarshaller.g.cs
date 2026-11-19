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
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.PartnerCentralMarketing.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CampaignAssetTemplate Object
    /// </summary>
    public partial class CampaignAssetTemplateUnmarshaller : ICborUnmarshaller<CampaignAssetTemplate, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public CampaignAssetTemplate Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new CampaignAssetTemplate();
            if (context.IsEmptyResponse) return null;

            var reader = context.Reader;
            if (reader.PeekState() == CborReaderState.Null)
            {
                reader.ReadNull();
                return null;
            }

            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                var propertyName = reader.ReadTextString();
                switch (propertyName)
                {
                    case "DisplayOrder":
                        context.AddPathSegment("DisplayOrder");
                        unmarshalledObject.DisplayOrder = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Fields":
                        context.AddPathSegment("Fields");
                        unmarshalledObject.Fields = new CborListUnmarshaller<CampaignAssetTemplateField, CampaignAssetTemplateFieldUnmarshaller>(CampaignAssetTemplateFieldUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Id":
                        context.AddPathSegment("Id");
                        unmarshalledObject.Id = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Label":
                        context.AddPathSegment("Label");
                        unmarshalledObject.Label = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "LayoutPreviews":
                        context.AddPathSegment("LayoutPreviews");
                        unmarshalledObject.LayoutPreviews = new CborListUnmarshaller<LayoutPreview, LayoutPreviewUnmarshaller>(LayoutPreviewUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "PrerequisiteAssetTemplateIds":
                        context.AddPathSegment("PrerequisiteAssetTemplateIds");
                        unmarshalledObject.PrerequisiteAssetTemplateIds = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SocialPlatform":
                        context.AddPathSegment("SocialPlatform");
                        unmarshalledObject.SocialPlatform = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Type":
                        context.AddPathSegment("Type");
                        unmarshalledObject.Type = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    default:
                        reader.SkipValue();
                        break;
                }
            }
            reader.ReadEndMap();
            return unmarshalledObject;
        }

        private static CampaignAssetTemplateUnmarshaller _instance = new CampaignAssetTemplateUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CampaignAssetTemplateUnmarshaller Instance => _instance;
    }
}
