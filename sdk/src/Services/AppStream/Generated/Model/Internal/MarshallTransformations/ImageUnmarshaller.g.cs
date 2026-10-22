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

using Amazon.AppStream.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.AppStream.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Image Object
    /// </summary>
    public partial class ImageUnmarshaller : ICborUnmarshaller<Image, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public Image Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new Image();
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
                    case "Applications":
                        context.AddPathSegment("Applications");
                        unmarshalledObject.Applications = new CborListUnmarshaller<Application, ApplicationUnmarshaller>(ApplicationUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "AppstreamAgentVersion":
                        context.AddPathSegment("AppstreamAgentVersion");
                        unmarshalledObject.AppstreamAgentVersion = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Arn":
                        context.AddPathSegment("Arn");
                        unmarshalledObject.Arn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "BaseImageArn":
                        context.AddPathSegment("BaseImageArn");
                        unmarshalledObject.BaseImageArn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "CreatedTime":
                        context.AddPathSegment("CreatedTime");
                        unmarshalledObject.CreatedTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Description":
                        context.AddPathSegment("Description");
                        unmarshalledObject.Description = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "DisplayName":
                        context.AddPathSegment("DisplayName");
                        unmarshalledObject.DisplayName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "DynamicAppProvidersEnabled":
                        context.AddPathSegment("DynamicAppProvidersEnabled");
                        unmarshalledObject.DynamicAppProvidersEnabled = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ImageBuilderName":
                        context.AddPathSegment("ImageBuilderName");
                        unmarshalledObject.ImageBuilderName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ImageBuilderSupported":
                        context.AddPathSegment("ImageBuilderSupported");
                        unmarshalledObject.ImageBuilderSupported = CborNullableBoolUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ImageErrors":
                        context.AddPathSegment("ImageErrors");
                        unmarshalledObject.ImageErrors = new CborListUnmarshaller<ResourceError, ResourceErrorUnmarshaller>(ResourceErrorUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ImagePermissions":
                        context.AddPathSegment("ImagePermissions");
                        unmarshalledObject.ImagePermissions = ImagePermissionsUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ImageSharedWithOthers":
                        context.AddPathSegment("ImageSharedWithOthers");
                        unmarshalledObject.ImageSharedWithOthers = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ImageSoftwareMetadata":
                        context.AddPathSegment("ImageSoftwareMetadata");
                        unmarshalledObject.ImageSoftwareMetadata = ImageSoftwareMetadataUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ImageType":
                        context.AddPathSegment("ImageType");
                        unmarshalledObject.ImageType = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "LatestAppstreamAgentVersion":
                        context.AddPathSegment("LatestAppstreamAgentVersion");
                        unmarshalledObject.LatestAppstreamAgentVersion = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ManagedSoftwareIncluded":
                        context.AddPathSegment("ManagedSoftwareIncluded");
                        unmarshalledObject.ManagedSoftwareIncluded = CborNullableBoolUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Name":
                        context.AddPathSegment("Name");
                        unmarshalledObject.Name = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Platform":
                        context.AddPathSegment("Platform");
                        unmarshalledObject.Platform = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "PublicBaseImageReleasedDate":
                        context.AddPathSegment("PublicBaseImageReleasedDate");
                        unmarshalledObject.PublicBaseImageReleasedDate = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "State":
                        context.AddPathSegment("State");
                        unmarshalledObject.State = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "StateChangeReason":
                        context.AddPathSegment("StateChangeReason");
                        unmarshalledObject.StateChangeReason = ImageStateChangeReasonUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SupportedInstanceFamilies":
                        context.AddPathSegment("SupportedInstanceFamilies");
                        unmarshalledObject.SupportedInstanceFamilies = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Visibility":
                        context.AddPathSegment("Visibility");
                        unmarshalledObject.Visibility = CborStringUnmarshaller.Instance.Unmarshall(context);
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

        private static ImageUnmarshaller _instance = new ImageUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ImageUnmarshaller Instance => _instance;
    }
}
