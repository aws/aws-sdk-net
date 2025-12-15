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
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaTailor.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.MediaTailor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutPlaybackConfiguration Request Marshaller
    /// </summary>       
    public class PutPlaybackConfigurationRequestMarshaller : IMarshaller<IRequest, PutPlaybackConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutPlaybackConfigurationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutPlaybackConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MediaTailor");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-04-23";
            request.HttpMethod = "PUT";

            request.ResourcePath = "/playbackConfiguration";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAdConditioningConfiguration())
                {
                    context.Writer.WritePropertyName("AdConditioningConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = AdConditioningConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AdConditioningConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetAdDecisionServerConfiguration())
                {
                    context.Writer.WritePropertyName("AdDecisionServerConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = AdDecisionServerConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AdDecisionServerConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetAdDecisionServerUrl())
                {
                    context.Writer.WritePropertyName("AdDecisionServerUrl");
                    context.Writer.Write(publicRequest.AdDecisionServerUrl);
                }

                if(publicRequest.IsSetAvailSuppression())
                {
                    context.Writer.WritePropertyName("AvailSuppression");
                    context.Writer.WriteObjectStart();

                    var marshaller = AvailSuppressionMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AvailSuppression, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetBumper())
                {
                    context.Writer.WritePropertyName("Bumper");
                    context.Writer.WriteObjectStart();

                    var marshaller = BumperMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Bumper, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetCdnConfiguration())
                {
                    context.Writer.WritePropertyName("CdnConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = CdnConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.CdnConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetConfigurationAliases())
                {
                    context.Writer.WritePropertyName("ConfigurationAliases");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestConfigurationAliasesKvp in publicRequest.ConfigurationAliases)
                    {
                        context.Writer.WritePropertyName(publicRequestConfigurationAliasesKvp.Key);
                        var publicRequestConfigurationAliasesValue = publicRequestConfigurationAliasesKvp.Value;

                        context.Writer.WriteObjectStart();
                        foreach (var publicRequestConfigurationAliasesValueKvp in publicRequestConfigurationAliasesValue)
                        {
                            context.Writer.WritePropertyName(publicRequestConfigurationAliasesValueKvp.Key);
                            var publicRequestConfigurationAliasesValueValue = publicRequestConfigurationAliasesValueKvp.Value;

                                context.Writer.Write(publicRequestConfigurationAliasesValueValue);
                        }
                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDashConfiguration())
                {
                    context.Writer.WritePropertyName("DashConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = DashConfigurationForPutMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DashConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetInsertionMode())
                {
                    context.Writer.WritePropertyName("InsertionMode");
                    context.Writer.Write(publicRequest.InsertionMode);
                }

                if(publicRequest.IsSetLivePreRollConfiguration())
                {
                    context.Writer.WritePropertyName("LivePreRollConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = LivePreRollConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.LivePreRollConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetManifestProcessingRules())
                {
                    context.Writer.WritePropertyName("ManifestProcessingRules");
                    context.Writer.WriteObjectStart();

                    var marshaller = ManifestProcessingRulesMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ManifestProcessingRules, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetPersonalizationThresholdSeconds())
                {
                    context.Writer.WritePropertyName("PersonalizationThresholdSeconds");
                    context.Writer.Write(publicRequest.PersonalizationThresholdSeconds);
                }

                if(publicRequest.IsSetSlateAdUrl())
                {
                    context.Writer.WritePropertyName("SlateAdUrl");
                    context.Writer.Write(publicRequest.SlateAdUrl);
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("tags");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestTagsKvp in publicRequest.Tags)
                    {
                        context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                        var publicRequestTagsValue = publicRequestTagsKvp.Value;

                            context.Writer.Write(publicRequestTagsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTranscodeProfileName())
                {
                    context.Writer.WritePropertyName("TranscodeProfileName");
                    context.Writer.Write(publicRequest.TranscodeProfileName);
                }

                if(publicRequest.IsSetVideoContentSourceUrl())
                {
                    context.Writer.WritePropertyName("VideoContentSourceUrl");
                    context.Writer.Write(publicRequest.VideoContentSourceUrl);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static PutPlaybackConfigurationRequestMarshaller _instance = new PutPlaybackConfigurationRequestMarshaller();        

        internal static PutPlaybackConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutPlaybackConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}