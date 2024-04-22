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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Imagebuilder.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Imagebuilder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// LifecyclePolicyDetailExclusionRulesAmis Marshaller
    /// </summary>
    public class LifecyclePolicyDetailExclusionRulesAmisMarshaller : IRequestMarshaller<LifecyclePolicyDetailExclusionRulesAmis, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(LifecyclePolicyDetailExclusionRulesAmis requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetIsPublic())
            {
                context.Writer.WritePropertyName("isPublic");
                context.Writer.Write(requestObject.IsPublic);
            }

            if(requestObject.IsSetLastLaunched())
            {
                context.Writer.WritePropertyName("lastLaunched");
                context.Writer.WriteObjectStart();

                var marshaller = LifecyclePolicyDetailExclusionRulesAmisLastLaunchedMarshaller.Instance;
                marshaller.Marshall(requestObject.LastLaunched, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRegions())
            {
                context.Writer.WritePropertyName("regions");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectRegionsListValue in requestObject.Regions)
                {
                        context.Writer.Write(requestObjectRegionsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSharedAccounts())
            {
                context.Writer.WritePropertyName("sharedAccounts");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSharedAccountsListValue in requestObject.SharedAccounts)
                {
                        context.Writer.Write(requestObjectSharedAccountsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetTagMap())
            {
                context.Writer.WritePropertyName("tagMap");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectTagMapKvp in requestObject.TagMap)
                {
                    context.Writer.WritePropertyName(requestObjectTagMapKvp.Key);
                    var requestObjectTagMapValue = requestObjectTagMapKvp.Value;

                        context.Writer.Write(requestObjectTagMapValue);
                }
                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static LifecyclePolicyDetailExclusionRulesAmisMarshaller Instance = new LifecyclePolicyDetailExclusionRulesAmisMarshaller();

    }
}
#pragma warning restore CS0612,CS0618