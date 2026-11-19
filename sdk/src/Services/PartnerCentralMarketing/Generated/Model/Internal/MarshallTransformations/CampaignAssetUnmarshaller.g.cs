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
    /// Response Unmarshaller for CampaignAsset Object
    /// </summary>
    public partial class CampaignAssetUnmarshaller : ICborUnmarshaller<CampaignAsset, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public CampaignAsset Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new CampaignAsset();
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
                    case "ActivationIssues":
                        context.AddPathSegment("ActivationIssues");
                        unmarshalledObject.ActivationIssues = new CborListUnmarshaller<ActivationIssue, ActivationIssueUnmarshaller>(ActivationIssueUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "CampaignId":
                        context.AddPathSegment("CampaignId");
                        unmarshalledObject.CampaignId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Category":
                        context.AddPathSegment("Category");
                        unmarshalledObject.Category = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "CreatedAt":
                        context.AddPathSegment("CreatedAt");
                        unmarshalledObject.CreatedAt = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "DeliveryStatus":
                        context.AddPathSegment("DeliveryStatus");
                        unmarshalledObject.DeliveryStatus = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "DeliveryStatusReason":
                        context.AddPathSegment("DeliveryStatusReason");
                        unmarshalledObject.DeliveryStatusReason = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "FieldValues":
                        context.AddPathSegment("FieldValues");
                        unmarshalledObject.FieldValues = new CborListUnmarshaller<CampaignAssetFieldValue, CampaignAssetFieldValueUnmarshaller>(CampaignAssetFieldValueUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "FileFormat":
                        context.AddPathSegment("FileFormat");
                        unmarshalledObject.FileFormat = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Id":
                        context.AddPathSegment("Id");
                        unmarshalledObject.Id = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "LastActivationStatus":
                        context.AddPathSegment("LastActivationStatus");
                        unmarshalledObject.LastActivationStatus = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Layout":
                        context.AddPathSegment("Layout");
                        unmarshalledObject.Layout = CampaignAssetLayoutUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "LayoutPreviews":
                        context.AddPathSegment("LayoutPreviews");
                        unmarshalledObject.LayoutPreviews = new CborListUnmarshaller<LayoutPreview, LayoutPreviewUnmarshaller>(LayoutPreviewUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "LinkLabel":
                        context.AddPathSegment("LinkLabel");
                        unmarshalledObject.LinkLabel = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Name":
                        context.AddPathSegment("Name");
                        unmarshalledObject.Name = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "PublicUrl":
                        context.AddPathSegment("PublicUrl");
                        unmarshalledObject.PublicUrl = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ScheduledSendAt":
                        context.AddPathSegment("ScheduledSendAt");
                        unmarshalledObject.ScheduledSendAt = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SendMode":
                        context.AddPathSegment("SendMode");
                        unmarshalledObject.SendMode = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SocialPlatform":
                        context.AddPathSegment("SocialPlatform");
                        unmarshalledObject.SocialPlatform = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SourceAssetTemplateId":
                        context.AddPathSegment("SourceAssetTemplateId");
                        unmarshalledObject.SourceAssetTemplateId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "State":
                        context.AddPathSegment("State");
                        unmarshalledObject.State = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "UpdatedAt":
                        context.AddPathSegment("UpdatedAt");
                        unmarshalledObject.UpdatedAt = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
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

        private static CampaignAssetUnmarshaller _instance = new CampaignAssetUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CampaignAssetUnmarshaller Instance => _instance;
    }
}
