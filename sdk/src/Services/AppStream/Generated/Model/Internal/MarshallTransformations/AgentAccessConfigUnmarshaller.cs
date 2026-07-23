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
    /// Response Unmarshaller for AgentAccessConfig Object
    /// </summary>  
    public class AgentAccessConfigUnmarshaller : ICborUnmarshaller<AgentAccessConfig, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public AgentAccessConfig Unmarshall(CborUnmarshallerContext context)
        {
            AgentAccessConfig unmarshalledObject = new AgentAccessConfig();
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
                    case "S3BucketArn":
                        {
                            context.AddPathSegment("S3BucketArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.S3BucketArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ScreenImageFormat":
                        {
                            context.AddPathSegment("ScreenImageFormat");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ScreenImageFormat = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ScreenResolution":
                        {
                            context.AddPathSegment("ScreenResolution");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ScreenResolution = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ScreenshotsUploadEnabled":
                        {
                            context.AddPathSegment("ScreenshotsUploadEnabled");
                            var unmarshaller = CborNullableBoolUnmarshaller.Instance;
                            unmarshalledObject.ScreenshotsUploadEnabled = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Settings":
                        {
                            context.AddPathSegment("Settings");
                            var unmarshaller = new CborListUnmarshaller<AgentAccessSetting, AgentAccessSettingUnmarshaller>(AgentAccessSettingUnmarshaller.Instance);
                            unmarshalledObject.Settings = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "UserControlMode":
                        {
                            context.AddPathSegment("UserControlMode");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.UserControlMode = unmarshaller.Unmarshall(context);
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


        private static AgentAccessConfigUnmarshaller _instance = new AgentAccessConfigUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AgentAccessConfigUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}