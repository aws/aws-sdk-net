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
    /// WebContentFilteringPolicy Marshaller
    /// </summary>
    public class WebContentFilteringPolicyMarshaller : IRequestMarshaller<WebContentFilteringPolicy, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(WebContentFilteringPolicy requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAllowedUrls())
            {
                context.Writer.WritePropertyName("allowedUrls");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAllowedUrlsListValue in requestObject.AllowedUrls)
                {
                        context.Writer.WriteStringValue(requestObjectAllowedUrlsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetBlockedCategories())
            {
                context.Writer.WritePropertyName("blockedCategories");
                context.Writer.WriteStartArray();
                foreach(var requestObjectBlockedCategoriesListValue in requestObject.BlockedCategories)
                {
                        context.Writer.WriteStringValue(requestObjectBlockedCategoriesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetBlockedUrls())
            {
                context.Writer.WritePropertyName("blockedUrls");
                context.Writer.WriteStartArray();
                foreach(var requestObjectBlockedUrlsListValue in requestObject.BlockedUrls)
                {
                        context.Writer.WriteStringValue(requestObjectBlockedUrlsListValue);
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static WebContentFilteringPolicyMarshaller Instance = new WebContentFilteringPolicyMarshaller();

    }
}