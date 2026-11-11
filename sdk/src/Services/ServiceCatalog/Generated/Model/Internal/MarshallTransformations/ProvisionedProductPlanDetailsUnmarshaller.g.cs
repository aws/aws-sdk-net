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
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.ServiceCatalog.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ProvisionedProductPlanDetails Object
    /// </summary>
    public partial class ProvisionedProductPlanDetailsUnmarshaller : ICborUnmarshaller<ProvisionedProductPlanDetails, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public ProvisionedProductPlanDetails Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new ProvisionedProductPlanDetails();
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
                    case "CreatedTime":
                        context.AddPathSegment("CreatedTime");
                        unmarshalledObject.CreatedTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "NotificationArns":
                        context.AddPathSegment("NotificationArns");
                        unmarshalledObject.NotificationArns = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "PathId":
                        context.AddPathSegment("PathId");
                        unmarshalledObject.PathId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "PlanId":
                        context.AddPathSegment("PlanId");
                        unmarshalledObject.PlanId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "PlanName":
                        context.AddPathSegment("PlanName");
                        unmarshalledObject.PlanName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "PlanType":
                        context.AddPathSegment("PlanType");
                        unmarshalledObject.PlanType = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ProductId":
                        context.AddPathSegment("ProductId");
                        unmarshalledObject.ProductId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ProvisionProductId":
                        context.AddPathSegment("ProvisionProductId");
                        unmarshalledObject.ProvisionProductId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ProvisionProductName":
                        context.AddPathSegment("ProvisionProductName");
                        unmarshalledObject.ProvisionProductName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ProvisioningArtifactId":
                        context.AddPathSegment("ProvisioningArtifactId");
                        unmarshalledObject.ProvisioningArtifactId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ProvisioningParameters":
                        context.AddPathSegment("ProvisioningParameters");
                        unmarshalledObject.ProvisioningParameters = new CborListUnmarshaller<UpdateProvisioningParameter, UpdateProvisioningParameterUnmarshaller>(UpdateProvisioningParameterUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Status":
                        context.AddPathSegment("Status");
                        unmarshalledObject.Status = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "StatusMessage":
                        context.AddPathSegment("StatusMessage");
                        unmarshalledObject.StatusMessage = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Tags":
                        context.AddPathSegment("Tags");
                        unmarshalledObject.Tags = new CborListUnmarshaller<Tag, TagUnmarshaller>(TagUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "UpdatedTime":
                        context.AddPathSegment("UpdatedTime");
                        unmarshalledObject.UpdatedTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
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

        private static ProvisionedProductPlanDetailsUnmarshaller _instance = new ProvisionedProductPlanDetailsUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ProvisionedProductPlanDetailsUnmarshaller Instance => _instance;
    }
}
