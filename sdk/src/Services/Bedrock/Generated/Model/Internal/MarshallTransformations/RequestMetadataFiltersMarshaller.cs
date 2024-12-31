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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Bedrock.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Bedrock.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RequestMetadataFilters Marshaller
    /// </summary>
    public class RequestMetadataFiltersMarshaller : IRequestMarshaller<RequestMetadataFilters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RequestMetadataFilters requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAndAll())
            {
                context.Writer.WritePropertyName("andAll");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAndAllListValue in requestObject.AndAll)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = RequestMetadataBaseFiltersMarshaller.Instance;
                    marshaller.Marshall(requestObjectAndAllListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEquals())
            {
                context.Writer.WritePropertyName("equals");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectEqualsKvp in requestObject.Equals)
                {
                    context.Writer.WritePropertyName(requestObjectEqualsKvp.Key);
                    var requestObjectEqualsValue = requestObjectEqualsKvp.Value;

                        context.Writer.Write(requestObjectEqualsValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetNotEquals())
            {
                context.Writer.WritePropertyName("notEquals");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectNotEqualsKvp in requestObject.NotEquals)
                {
                    context.Writer.WritePropertyName(requestObjectNotEqualsKvp.Key);
                    var requestObjectNotEqualsValue = requestObjectNotEqualsKvp.Value;

                        context.Writer.Write(requestObjectNotEqualsValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetOrAll())
            {
                context.Writer.WritePropertyName("orAll");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectOrAllListValue in requestObject.OrAll)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = RequestMetadataBaseFiltersMarshaller.Instance;
                    marshaller.Marshall(requestObjectOrAllListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RequestMetadataFiltersMarshaller Instance = new RequestMetadataFiltersMarshaller();

    }
}