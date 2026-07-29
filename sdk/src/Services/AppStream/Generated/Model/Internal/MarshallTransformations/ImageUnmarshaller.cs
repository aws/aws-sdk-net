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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppStream.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
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
    public class ImageUnmarshaller : ICborUnmarshaller<Image, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Image Unmarshall(CborUnmarshallerContext context)
        {
            Image unmarshalledObject = new Image();
            if (context.IsEmptyResponse)
                return null;
            var reader = context.Reader;
            if (reader.PeekState() == CborReaderState.Null)
            {
                reader.ReadNull();
                return null;
            }

            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                string propertyName = reader.ReadTextString();
                switch (propertyName)
                {
                    case "Applications":
                        {
                            context.AddPathSegment("Applications");
                            var unmarshaller = new CborListUnmarshaller<Application, ApplicationUnmarshaller>(ApplicationUnmarshaller.Instance);
                            unmarshalledObject.Applications = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "AppstreamAgentVersion":
                        {
                            context.AddPathSegment("AppstreamAgentVersion");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.AppstreamAgentVersion = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Arn":
                        {
                            context.AddPathSegment("Arn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Arn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "BaseImageArn":
                        {
                            context.AddPathSegment("BaseImageArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.BaseImageArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "CreatedTime":
                        {
                            context.AddPathSegment("CreatedTime");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.CreatedTime = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Description":
                        {
                            context.AddPathSegment("Description");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "DisplayName":
                        {
                            context.AddPathSegment("DisplayName");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.DisplayName = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "DynamicAppProvidersEnabled":
                        {
                            context.AddPathSegment("DynamicAppProvidersEnabled");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.DynamicAppProvidersEnabled = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ImageBuilderName":
                        {
                            context.AddPathSegment("ImageBuilderName");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ImageBuilderName = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ImageBuilderSupported":
                        {
                            context.AddPathSegment("ImageBuilderSupported");
                            var unmarshaller = CborNullableBoolUnmarshaller.Instance;
                            unmarshalledObject.ImageBuilderSupported = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ImageErrors":
                        {
                            context.AddPathSegment("ImageErrors");
                            var unmarshaller = new CborListUnmarshaller<ResourceError, ResourceErrorUnmarshaller>(ResourceErrorUnmarshaller.Instance);
                            unmarshalledObject.ImageErrors = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ImagePermissions":
                        {
                            context.AddPathSegment("ImagePermissions");
                            var unmarshaller = ImagePermissionsUnmarshaller.Instance;
                            unmarshalledObject.ImagePermissions = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ImageSharedWithOthers":
                        {
                            context.AddPathSegment("ImageSharedWithOthers");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ImageSharedWithOthers = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ImageType":
                        {
                            context.AddPathSegment("ImageType");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ImageType = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "LatestAppstreamAgentVersion":
                        {
                            context.AddPathSegment("LatestAppstreamAgentVersion");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.LatestAppstreamAgentVersion = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ManagedSoftwareIncluded":
                        {
                            context.AddPathSegment("ManagedSoftwareIncluded");
                            var unmarshaller = CborNullableBoolUnmarshaller.Instance;
                            unmarshalledObject.ManagedSoftwareIncluded = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Name":
                        {
                            context.AddPathSegment("Name");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Platform":
                        {
                            context.AddPathSegment("Platform");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Platform = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "PublicBaseImageReleasedDate":
                        {
                            context.AddPathSegment("PublicBaseImageReleasedDate");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.PublicBaseImageReleasedDate = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "State":
                        {
                            context.AddPathSegment("State");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.State = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "StateChangeReason":
                        {
                            context.AddPathSegment("StateChangeReason");
                            var unmarshaller = ImageStateChangeReasonUnmarshaller.Instance;
                            unmarshalledObject.StateChangeReason = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "SupportedInstanceFamilies":
                        {
                            context.AddPathSegment("SupportedInstanceFamilies");
                            var unmarshaller = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance);
                            unmarshalledObject.SupportedInstanceFamilies = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Visibility":
                        {
                            context.AddPathSegment("Visibility");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Visibility = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
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
        public static ImageUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}