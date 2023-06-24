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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Kendra.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Kendra.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SlackConfiguration Marshaller
    /// </summary>
    public class SlackConfigurationMarshaller : IRequestMarshaller<SlackConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SlackConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCrawlBotMessage())
            {
                context.Writer.WritePropertyName("CrawlBotMessage");
                context.Writer.Write(requestObject.CrawlBotMessage);
            }

            if(requestObject.IsSetExcludeArchived())
            {
                context.Writer.WritePropertyName("ExcludeArchived");
                context.Writer.Write(requestObject.ExcludeArchived);
            }

            if(requestObject.IsSetExclusionPatterns())
            {
                context.Writer.WritePropertyName("ExclusionPatterns");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectExclusionPatternsListValue in requestObject.ExclusionPatterns)
                {
                        context.Writer.Write(requestObjectExclusionPatternsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetFieldMappings())
            {
                context.Writer.WritePropertyName("FieldMappings");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectFieldMappingsListValue in requestObject.FieldMappings)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = DataSourceToIndexFieldMappingMarshaller.Instance;
                    marshaller.Marshall(requestObjectFieldMappingsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetInclusionPatterns())
            {
                context.Writer.WritePropertyName("InclusionPatterns");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectInclusionPatternsListValue in requestObject.InclusionPatterns)
                {
                        context.Writer.Write(requestObjectInclusionPatternsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetLookBackPeriod())
            {
                context.Writer.WritePropertyName("LookBackPeriod");
                context.Writer.Write(requestObject.LookBackPeriod);
            }

            if(requestObject.IsSetPrivateChannelFilter())
            {
                context.Writer.WritePropertyName("PrivateChannelFilter");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectPrivateChannelFilterListValue in requestObject.PrivateChannelFilter)
                {
                        context.Writer.Write(requestObjectPrivateChannelFilterListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetPublicChannelFilter())
            {
                context.Writer.WritePropertyName("PublicChannelFilter");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectPublicChannelFilterListValue in requestObject.PublicChannelFilter)
                {
                        context.Writer.Write(requestObjectPublicChannelFilterListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSecretArn())
            {
                context.Writer.WritePropertyName("SecretArn");
                context.Writer.Write(requestObject.SecretArn);
            }

            if(requestObject.IsSetSinceCrawlDate())
            {
                context.Writer.WritePropertyName("SinceCrawlDate");
                context.Writer.Write(requestObject.SinceCrawlDate);
            }

            if(requestObject.IsSetSlackEntityList())
            {
                context.Writer.WritePropertyName("SlackEntityList");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSlackEntityListListValue in requestObject.SlackEntityList)
                {
                        context.Writer.Write(requestObjectSlackEntityListListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetTeamId())
            {
                context.Writer.WritePropertyName("TeamId");
                context.Writer.Write(requestObject.TeamId);
            }

            if(requestObject.IsSetUseChangeLog())
            {
                context.Writer.WritePropertyName("UseChangeLog");
                context.Writer.Write(requestObject.UseChangeLog);
            }

            if(requestObject.IsSetVpcConfiguration())
            {
                context.Writer.WritePropertyName("VpcConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = DataSourceVpcConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.VpcConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SlackConfigurationMarshaller Instance = new SlackConfigurationMarshaller();

    }
}