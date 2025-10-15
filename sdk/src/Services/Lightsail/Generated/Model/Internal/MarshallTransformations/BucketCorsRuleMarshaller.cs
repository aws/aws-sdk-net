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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Lightsail.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Lightsail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BucketCorsRule Marshaller
    /// </summary>
    public class BucketCorsRuleMarshaller : IRequestMarshaller<BucketCorsRule, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(BucketCorsRule requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAllowedHeaders())
            {
                context.Writer.WritePropertyName("allowedHeaders");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAllowedHeadersListValue in requestObject.AllowedHeaders)
                {
                        context.Writer.Write(requestObjectAllowedHeadersListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetAllowedMethods())
            {
                context.Writer.WritePropertyName("allowedMethods");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAllowedMethodsListValue in requestObject.AllowedMethods)
                {
                        context.Writer.Write(requestObjectAllowedMethodsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetAllowedOrigins())
            {
                context.Writer.WritePropertyName("allowedOrigins");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAllowedOriginsListValue in requestObject.AllowedOrigins)
                {
                        context.Writer.Write(requestObjectAllowedOriginsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetExposeHeaders())
            {
                context.Writer.WritePropertyName("exposeHeaders");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectExposeHeadersListValue in requestObject.ExposeHeaders)
                {
                        context.Writer.Write(requestObjectExposeHeadersListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetId())
            {
                context.Writer.WritePropertyName("id");
                context.Writer.Write(requestObject.Id);
            }

            if(requestObject.IsSetMaxAgeSeconds())
            {
                context.Writer.WritePropertyName("maxAgeSeconds");
                context.Writer.Write(requestObject.MaxAgeSeconds);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static BucketCorsRuleMarshaller Instance = new BucketCorsRuleMarshaller();

    }
}