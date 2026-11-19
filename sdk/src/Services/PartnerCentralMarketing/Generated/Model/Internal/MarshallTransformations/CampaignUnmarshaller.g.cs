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
    /// Response Unmarshaller for Campaign Object
    /// </summary>
    public partial class CampaignUnmarshaller : ICborUnmarshaller<Campaign, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public Campaign Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new Campaign();
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

                    case "Arn":
                        context.AddPathSegment("Arn");
                        unmarshalledObject.Arn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "CampaignId":
                        context.AddPathSegment("CampaignId");
                        unmarshalledObject.CampaignId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "CampaignTemplateId":
                        context.AddPathSegment("CampaignTemplateId");
                        unmarshalledObject.CampaignTemplateId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "CreatedAt":
                        context.AddPathSegment("CreatedAt");
                        unmarshalledObject.CreatedAt = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "EmailTarget":
                        context.AddPathSegment("EmailTarget");
                        unmarshalledObject.EmailTarget = EmailTargetDetailUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "EmailTargetEngagementGroupIds":
                        context.AddPathSegment("EmailTargetEngagementGroupIds");
                        unmarshalledObject.EmailTargetEngagementGroupIds = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "EndOn":
                        context.AddPathSegment("EndOn");
                        unmarshalledObject.EndOn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "EstimatedBudget":
                        context.AddPathSegment("EstimatedBudget");
                        unmarshalledObject.EstimatedBudget = MonetaryValueUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Language":
                        context.AddPathSegment("Language");
                        unmarshalledObject.Language = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Name":
                        context.AddPathSegment("Name");
                        unmarshalledObject.Name = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "PartnerAddress":
                        context.AddPathSegment("PartnerAddress");
                        unmarshalledObject.PartnerAddress = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "PartnerBadge":
                        context.AddPathSegment("PartnerBadge");
                        unmarshalledObject.PartnerBadge = PartnerBadgeDetailUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "PartnerProfile":
                        context.AddPathSegment("PartnerProfile");
                        unmarshalledObject.PartnerProfile = PartnerProfileBrandingUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "PrivacyPolicyUrl":
                        context.AddPathSegment("PrivacyPolicyUrl");
                        unmarshalledObject.PrivacyPolicyUrl = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SenderEmail":
                        context.AddPathSegment("SenderEmail");
                        unmarshalledObject.SenderEmail = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SocialConnections":
                        context.AddPathSegment("SocialConnections");
                        unmarshalledObject.SocialConnections = new CborDictionaryUnmarshaller<string, List<string>, CborStringUnmarshaller, CborListUnmarshaller<string, CborStringUnmarshaller>>(CborStringUnmarshaller.Instance, new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance)).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "StartOn":
                        context.AddPathSegment("StartOn");
                        unmarshalledObject.StartOn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "State":
                        context.AddPathSegment("State");
                        unmarshalledObject.State = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "TargetAudience":
                        context.AddPathSegment("TargetAudience");
                        unmarshalledObject.TargetAudience = TargetAudienceUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "TotalBudget":
                        context.AddPathSegment("TotalBudget");
                        unmarshalledObject.TotalBudget = MonetaryValueUnmarshaller.Instance.Unmarshall(context);
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

        private static CampaignUnmarshaller _instance = new CampaignUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CampaignUnmarshaller Instance => _instance;
    }
}
