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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaTailor.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using Amazon.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.MediaTailor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for PutPlaybackConfiguration operation
    /// </summary>  
    public class PutPlaybackConfigurationResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            PutPlaybackConfigurationResponse response = new PutPlaybackConfigurationResponse();
            StreamingUtf8JsonReader reader = new StreamingUtf8JsonReader(context.Stream);
            context.Read(ref reader);
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("AdConditioningConfiguration", targetDepth))
                {
                    var unmarshaller = AdConditioningConfigurationUnmarshaller.Instance;
                    response.AdConditioningConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AdDecisionServerUrl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AdDecisionServerUrl = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AvailSuppression", targetDepth))
                {
                    var unmarshaller = AvailSuppressionUnmarshaller.Instance;
                    response.AvailSuppression = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Bumper", targetDepth))
                {
                    var unmarshaller = BumperUnmarshaller.Instance;
                    response.Bumper = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CdnConfiguration", targetDepth))
                {
                    var unmarshaller = CdnConfigurationUnmarshaller.Instance;
                    response.CdnConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ConfigurationAliases", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, Dictionary<string, string>, StringUnmarshaller, JsonDictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>>(StringUnmarshaller.Instance, new JsonDictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance));
                    response.ConfigurationAliases = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DashConfiguration", targetDepth))
                {
                    var unmarshaller = DashConfigurationUnmarshaller.Instance;
                    response.DashConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("HlsConfiguration", targetDepth))
                {
                    var unmarshaller = HlsConfigurationUnmarshaller.Instance;
                    response.HlsConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("InsertionMode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.InsertionMode = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("LivePreRollConfiguration", targetDepth))
                {
                    var unmarshaller = LivePreRollConfigurationUnmarshaller.Instance;
                    response.LivePreRollConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("LogConfiguration", targetDepth))
                {
                    var unmarshaller = LogConfigurationUnmarshaller.Instance;
                    response.LogConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ManifestProcessingRules", targetDepth))
                {
                    var unmarshaller = ManifestProcessingRulesUnmarshaller.Instance;
                    response.ManifestProcessingRules = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Name = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PersonalizationThresholdSeconds", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    response.PersonalizationThresholdSeconds = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PlaybackConfigurationArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.PlaybackConfigurationArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PlaybackEndpointPrefix", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.PlaybackEndpointPrefix = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SessionInitializationEndpointPrefix", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.SessionInitializationEndpointPrefix = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SlateAdUrl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.SlateAdUrl = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("tags", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    response.Tags = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TranscodeProfileName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.TranscodeProfileName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("VideoContentSourceUrl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.VideoContentSourceUrl = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }

            return response;
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="innerException"></param>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            StreamingUtf8JsonReader reader = new StreamingUtf8JsonReader(context.Stream);
            var errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context, ref reader);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            using (var contextCopy = new JsonUnmarshallerContext(streamCopy, false, context.ResponseData))
            {
                StreamingUtf8JsonReader readerCopy = new StreamingUtf8JsonReader(streamCopy);
            }
            return new AmazonMediaTailorException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static PutPlaybackConfigurationResponseUnmarshaller _instance = new PutPlaybackConfigurationResponseUnmarshaller();        

        internal static PutPlaybackConfigurationResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutPlaybackConfigurationResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}