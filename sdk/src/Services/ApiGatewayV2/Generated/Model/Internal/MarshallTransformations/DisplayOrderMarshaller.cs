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
 * Do not modify this file. This file is generated from the apigatewayv2-2018-11-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ApiGatewayV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ApiGatewayV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DisplayOrder Marshaller
    /// </summary>
    public class DisplayOrderMarshaller : IRequestMarshaller<DisplayOrder, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DisplayOrder requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetContents())
            {
                context.Writer.WritePropertyName("contents");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectContentsListValue in requestObject.Contents)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = SectionMarshaller.Instance;
                    marshaller.Marshall(requestObjectContentsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetOverviewPageArn())
            {
                context.Writer.WritePropertyName("overviewPageArn");
                context.Writer.Write(requestObject.OverviewPageArn);
            }

            if(requestObject.IsSetProductPageArns())
            {
                context.Writer.WritePropertyName("productPageArns");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectProductPageArnsListValue in requestObject.ProductPageArns)
                {
                        context.Writer.Write(requestObjectProductPageArnsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DisplayOrderMarshaller Instance = new DisplayOrderMarshaller();

    }
}