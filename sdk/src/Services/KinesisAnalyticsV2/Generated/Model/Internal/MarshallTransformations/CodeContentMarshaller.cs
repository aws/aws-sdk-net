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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.KinesisAnalyticsV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.KinesisAnalyticsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CodeContent Marshaller
    /// </summary>       
    public class CodeContentMarshaller : IRequestMarshaller<CodeContent, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CodeContent requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetS3ContentLocation())
            {
                context.Writer.WritePropertyName("S3ContentLocation");
                context.Writer.WriteObjectStart();

                var marshaller = S3ContentLocationMarshaller.Instance;
                marshaller.Marshall(requestObject.S3ContentLocation, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTextContent())
            {
                context.Writer.WritePropertyName("TextContent");
                context.Writer.Write(requestObject.TextContent);
            }

            if(requestObject.IsSetZipFileContent())
            {
                context.Writer.WritePropertyName("ZipFileContent");
                context.Writer.Write(StringUtils.FromMemoryStream(requestObject.ZipFileContent));
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static CodeContentMarshaller Instance = new CodeContentMarshaller();

    }
}