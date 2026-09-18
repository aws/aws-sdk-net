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

using Amazon.MediaTailor.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Globalization;
using Amazon.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.MediaTailor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for PutPlaybackConfiguration operation.
    /// </summary>
    public partial class PutPlaybackConfigurationResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            var unmarshalledObject = new PutPlaybackConfigurationResponse();
            var reader = new StreamingUtf8JsonReader(context.Stream, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);

            context.Read(ref reader);
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("AdConditioningConfiguration", targetDepth, ref reader))
                {
                    var unmarshaller = AdConditioningConfigurationUnmarshaller.Instance;
                    unmarshalledObject.AdConditioningConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("AdDecisionServerConfiguration", targetDepth, ref reader))
                {
                    var unmarshaller = AdDecisionServerConfigurationUnmarshaller.Instance;
                    unmarshalledObject.AdDecisionServerConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("AdDecisionServerUrl", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AdDecisionServerUrl = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("AdsPersonalizationConcurrency", targetDepth, ref reader))
                {
                    var unmarshaller = AdsPersonalizationConcurrencyUnmarshaller.Instance;
                    unmarshalledObject.AdsPersonalizationConcurrency = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("AdsPersonalizationTimeouts", targetDepth, ref reader))
                {
                    var unmarshaller = AdsPersonalizationTimeoutsUnmarshaller.Instance;
                    unmarshalledObject.AdsPersonalizationTimeouts = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("AvailSuppression", targetDepth, ref reader))
                {
                    var unmarshaller = AvailSuppressionUnmarshaller.Instance;
                    unmarshalledObject.AvailSuppression = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("Bumper", targetDepth, ref reader))
                {
                    var unmarshaller = BumperUnmarshaller.Instance;
                    unmarshalledObject.Bumper = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("CdnConfiguration", targetDepth, ref reader))
                {
                    var unmarshaller = CdnConfigurationUnmarshaller.Instance;
                    unmarshalledObject.CdnConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ConfigurationAliases", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, Dictionary<string, string>, StringUnmarshaller, JsonDictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>>(StringUnmarshaller.Instance, new JsonDictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance));
                    unmarshalledObject.ConfigurationAliases = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("DashConfiguration", targetDepth, ref reader))
                {
                    var unmarshaller = DashConfigurationUnmarshaller.Instance;
                    unmarshalledObject.DashConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("DualStackPlaybackEndpointPrefix", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DualStackPlaybackEndpointPrefix = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("DualStackSessionInitializationEndpointPrefix", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DualStackSessionInitializationEndpointPrefix = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("FunctionMapping", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.FunctionMapping = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("HlsConfiguration", targetDepth, ref reader))
                {
                    var unmarshaller = HlsConfigurationUnmarshaller.Instance;
                    unmarshalledObject.HlsConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("InsertionMode", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InsertionMode = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("LivePreRollConfiguration", targetDepth, ref reader))
                {
                    var unmarshaller = LivePreRollConfigurationUnmarshaller.Instance;
                    unmarshalledObject.LivePreRollConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("LogConfiguration", targetDepth, ref reader))
                {
                    var unmarshaller = LogConfigurationUnmarshaller.Instance;
                    unmarshalledObject.LogConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ManifestProcessingRules", targetDepth, ref reader))
                {
                    var unmarshaller = ManifestProcessingRulesUnmarshaller.Instance;
                    unmarshalledObject.ManifestProcessingRules = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("Name", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("PersonalizationThresholdSeconds", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.PersonalizationThresholdSeconds = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("PlaybackConfigurationArn", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PlaybackConfigurationArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("PlaybackEndpointPrefix", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PlaybackEndpointPrefix = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("SessionInitializationEndpointPrefix", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SessionInitializationEndpointPrefix = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("SlateAdUrl", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SlateAdUrl = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("tags", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Tags = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("TranscodeProfileName", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TranscodeProfileName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("VideoContentSourceUrl", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VideoContentSourceUrl = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("YieldOptimizationConfiguration", targetDepth, ref reader))
                {
                    var unmarshaller = YieldOptimizationConfigurationUnmarshaller.Instance;
                    unmarshalledObject.YieldOptimizationConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }

            return unmarshalledObject;
        }

        /// <summary>
        /// Unmarshall error response to exception.
        /// </summary>
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            var reader = new StreamingUtf8JsonReader(context.Stream, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);
            var errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context, ref reader);

            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            {
                using (var contextCopy = new JsonUnmarshallerContext(streamCopy, false, context.ResponseData))
                {
                    var readerCopy = new StreamingUtf8JsonReader(streamCopy, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);
                }
            }
            return new AmazonMediaTailorException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static PutPlaybackConfigurationResponseUnmarshaller _instance = new PutPlaybackConfigurationResponseUnmarshaller();

        internal static PutPlaybackConfigurationResponseUnmarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static PutPlaybackConfigurationResponseUnmarshaller Instance => _instance;
    }
}
