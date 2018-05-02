/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodePipeline.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CodePipeline.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// WebhookDefinition Marshaller
    /// </summary>       
    public class WebhookDefinitionMarshaller : IRequestMarshaller<WebhookDefinition, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(WebhookDefinition requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAuthentication())
            {
                context.Writer.WritePropertyName("authentication");
                context.Writer.Write(requestObject.Authentication);
            }

            if(requestObject.IsSetAuthenticationConfiguration())
            {
                context.Writer.WritePropertyName("authenticationConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = WebhookAuthConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.AuthenticationConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetFilters())
            {
                context.Writer.WritePropertyName("filters");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectFiltersListValue in requestObject.Filters)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = WebhookFilterRuleMarshaller.Instance;
                    marshaller.Marshall(requestObjectFiltersListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.Write(requestObject.Name);
            }

            if(requestObject.IsSetTargetAction())
            {
                context.Writer.WritePropertyName("targetAction");
                context.Writer.Write(requestObject.TargetAction);
            }

            if(requestObject.IsSetTargetPipeline())
            {
                context.Writer.WritePropertyName("targetPipeline");
                context.Writer.Write(requestObject.TargetPipeline);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static WebhookDefinitionMarshaller Instance = new WebhookDefinitionMarshaller();

    }
}