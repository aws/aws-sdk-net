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
 * Do not modify this file. This file is generated from the workspaces-web-2020-07-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WorkSpacesWeb.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.WorkSpacesWeb.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CustomPattern Marshaller
    /// </summary>
    public class CustomPatternMarshaller : IRequestMarshaller<CustomPattern, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CustomPattern requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetKeywordRegex())
            {
                context.Writer.WritePropertyName("keywordRegex");
                context.Writer.WriteStringValue(requestObject.KeywordRegex);
            }

            if(requestObject.IsSetPatternDescription())
            {
                context.Writer.WritePropertyName("patternDescription");
                context.Writer.WriteStringValue(requestObject.PatternDescription);
            }

            if(requestObject.IsSetPatternName())
            {
                context.Writer.WritePropertyName("patternName");
                context.Writer.WriteStringValue(requestObject.PatternName);
            }

            if(requestObject.IsSetPatternRegex())
            {
                context.Writer.WritePropertyName("patternRegex");
                context.Writer.WriteStringValue(requestObject.PatternRegex);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CustomPatternMarshaller Instance = new CustomPatternMarshaller();

    }
}