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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CleanRooms.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CleanRooms.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AnalysisRuleCustom Marshaller
    /// </summary>
    public class AnalysisRuleCustomMarshaller : IRequestMarshaller<AnalysisRuleCustom, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AnalysisRuleCustom requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAllowedAnalyses())
            {
                context.Writer.WritePropertyName("allowedAnalyses");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAllowedAnalysesListValue in requestObject.AllowedAnalyses)
                {
                        context.Writer.Write(requestObjectAllowedAnalysesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetAllowedAnalysisProviders())
            {
                context.Writer.WritePropertyName("allowedAnalysisProviders");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAllowedAnalysisProvidersListValue in requestObject.AllowedAnalysisProviders)
                {
                        context.Writer.Write(requestObjectAllowedAnalysisProvidersListValue);
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AnalysisRuleCustomMarshaller Instance = new AnalysisRuleCustomMarshaller();

    }
}