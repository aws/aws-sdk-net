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
 * Do not modify this file. This file is generated from the transcribe-streaming-2017-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.TranscribeStreaming.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;
#pragma warning disable CS0612,CS0618
namespace Amazon.TranscribeStreaming.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for MedicalScribeStreamDetails Object
    /// </summary>  
    public class MedicalScribeStreamDetailsUnmarshaller : ICborUnmarshaller<MedicalScribeStreamDetails, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public MedicalScribeStreamDetails Unmarshall(CborUnmarshallerContext context)
        {
            MedicalScribeStreamDetails unmarshalledObject = new MedicalScribeStreamDetails();
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
                    case "ChannelDefinitions":
                        {
                            context.AddPathSegment("ChannelDefinitions");
                            var unmarshaller = new CborListUnmarshaller<MedicalScribeChannelDefinition, MedicalScribeChannelDefinitionUnmarshaller>(MedicalScribeChannelDefinitionUnmarshaller.Instance);
                            unmarshalledObject.ChannelDefinitions = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "EncryptionSettings":
                        {
                            context.AddPathSegment("EncryptionSettings");
                            var unmarshaller = MedicalScribeEncryptionSettingsUnmarshaller.Instance;
                            unmarshalledObject.EncryptionSettings = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "LanguageCode":
                        {
                            context.AddPathSegment("LanguageCode");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.LanguageCode = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "MediaEncoding":
                        {
                            context.AddPathSegment("MediaEncoding");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.MediaEncoding = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "MediaSampleRateHertz":
                        {
                            context.AddPathSegment("MediaSampleRateHertz");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            unmarshalledObject.MediaSampleRateHertz = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "MedicalScribeContextProvided":
                        {
                            context.AddPathSegment("MedicalScribeContextProvided");
                            var unmarshaller = CborNullableBoolUnmarshaller.Instance;
                            unmarshalledObject.MedicalScribeContextProvided = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "PostStreamAnalyticsResult":
                        {
                            context.AddPathSegment("PostStreamAnalyticsResult");
                            var unmarshaller = MedicalScribePostStreamAnalyticsResultUnmarshaller.Instance;
                            unmarshalledObject.PostStreamAnalyticsResult = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "PostStreamAnalyticsSettings":
                        {
                            context.AddPathSegment("PostStreamAnalyticsSettings");
                            var unmarshaller = MedicalScribePostStreamAnalyticsSettingsUnmarshaller.Instance;
                            unmarshalledObject.PostStreamAnalyticsSettings = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ResourceAccessRoleArn":
                        {
                            context.AddPathSegment("ResourceAccessRoleArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ResourceAccessRoleArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "SessionId":
                        {
                            context.AddPathSegment("SessionId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.SessionId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "StreamCreatedAt":
                        {
                            context.AddPathSegment("StreamCreatedAt");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.StreamCreatedAt = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "StreamEndedAt":
                        {
                            context.AddPathSegment("StreamEndedAt");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.StreamEndedAt = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "StreamStatus":
                        {
                            context.AddPathSegment("StreamStatus");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.StreamStatus = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "VocabularyFilterMethod":
                        {
                            context.AddPathSegment("VocabularyFilterMethod");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.VocabularyFilterMethod = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "VocabularyFilterName":
                        {
                            context.AddPathSegment("VocabularyFilterName");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.VocabularyFilterName = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "VocabularyName":
                        {
                            context.AddPathSegment("VocabularyName");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.VocabularyName = unmarshaller.Unmarshall(context);
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


        private static MedicalScribeStreamDetailsUnmarshaller _instance = new MedicalScribeStreamDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static MedicalScribeStreamDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}