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
#pragma warning disable CS0612,CS0618
namespace Amazon.Lightsail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CookieObject Marshaller
    /// </summary>
    public class CookieObjectMarshaller : IRequestMarshaller<CookieObject, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CookieObject requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCookiesAllowList())
            {
                context.Writer.WritePropertyName("cookiesAllowList");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCookiesAllowListListValue in requestObject.CookiesAllowList)
                {
                        context.Writer.WriteStringValue(requestObjectCookiesAllowListListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetOption())
            {
                context.Writer.WritePropertyName("option");
                context.Writer.WriteStringValue(requestObject.Option);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CookieObjectMarshaller Instance = new CookieObjectMarshaller();

    }
}