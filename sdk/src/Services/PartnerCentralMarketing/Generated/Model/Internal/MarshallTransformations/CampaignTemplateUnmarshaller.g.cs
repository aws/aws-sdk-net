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
    /// Response Unmarshaller for CampaignTemplate Object
    /// </summary>
    public partial class CampaignTemplateUnmarshaller : ICborUnmarshaller<CampaignTemplate, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public CampaignTemplate Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new CampaignTemplate();
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
                    case "AssetTemplates":
                        context.AddPathSegment("AssetTemplates");
                        unmarshalledObject.AssetTemplates = new CborListUnmarshaller<CampaignAssetTemplate, CampaignAssetTemplateUnmarshaller>(CampaignAssetTemplateUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "AwsServices":
                        context.AddPathSegment("AwsServices");
                        unmarshalledObject.AwsServices = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Collection":
                        context.AddPathSegment("Collection");
                        unmarshalledObject.Collection = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "CreatedAt":
                        context.AddPathSegment("CreatedAt");
                        unmarshalledObject.CreatedAt = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "CustomerSegments":
                        context.AddPathSegment("CustomerSegments");
                        unmarshalledObject.CustomerSegments = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Description":
                        context.AddPathSegment("Description");
                        unmarshalledObject.Description = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "EffectiveDateBegin":
                        context.AddPathSegment("EffectiveDateBegin");
                        unmarshalledObject.EffectiveDateBegin = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Id":
                        context.AddPathSegment("Id");
                        unmarshalledObject.Id = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Industry":
                        context.AddPathSegment("Industry");
                        unmarshalledObject.Industry = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "LanguageCode":
                        context.AddPathSegment("LanguageCode");
                        unmarshalledObject.LanguageCode = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Name":
                        context.AddPathSegment("Name");
                        unmarshalledObject.Name = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ReferenceMaterials":
                        context.AddPathSegment("ReferenceMaterials");
                        unmarshalledObject.ReferenceMaterials = new CborListUnmarshaller<ReferenceMaterial, ReferenceMaterialUnmarshaller>(ReferenceMaterialUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SetupDuration":
                        context.AddPathSegment("SetupDuration");
                        unmarshalledObject.SetupDuration = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Themes":
                        context.AddPathSegment("Themes");
                        unmarshalledObject.Themes = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ThumbnailUrl":
                        context.AddPathSegment("ThumbnailUrl");
                        unmarshalledObject.ThumbnailUrl = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "UpdatedAt":
                        context.AddPathSegment("UpdatedAt");
                        unmarshalledObject.UpdatedAt = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "UseCase":
                        context.AddPathSegment("UseCase");
                        unmarshalledObject.UseCase = CborStringUnmarshaller.Instance.Unmarshall(context);
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

        private static CampaignTemplateUnmarshaller _instance = new CampaignTemplateUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CampaignTemplateUnmarshaller Instance => _instance;
    }
}
