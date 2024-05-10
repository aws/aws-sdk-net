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
 * Do not modify this file. This file is generated from the securitylake-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityLake.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityLake.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CustomLogSourceResource Marshaller
    /// </summary>
    public class CustomLogSourceResourceMarshaller : IRequestMarshaller<CustomLogSourceResource, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CustomLogSourceResource requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAttributes())
            {
                context.Writer.WritePropertyName("attributes");
                context.Writer.WriteObjectStart();

                var marshaller = CustomLogSourceAttributesMarshaller.Instance;
                marshaller.Marshall(requestObject.Attributes, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetProvider())
            {
                context.Writer.WritePropertyName("provider");
                context.Writer.WriteObjectStart();

                var marshaller = CustomLogSourceProviderMarshaller.Instance;
                marshaller.Marshall(requestObject.Provider, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSourceName())
            {
                context.Writer.WritePropertyName("sourceName");
                context.Writer.Write(requestObject.SourceName);
            }

            if(requestObject.IsSetSourceVersion())
            {
                context.Writer.WritePropertyName("sourceVersion");
                context.Writer.Write(requestObject.SourceVersion);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CustomLogSourceResourceMarshaller Instance = new CustomLogSourceResourceMarshaller();

    }
}