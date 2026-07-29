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
 * Do not modify this file. This file is generated from the kendra-ranking-2022-10-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.KendraRanking.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.KendraRanking.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Document Marshaller
    /// </summary>
    public class DocumentMarshaller : IRequestMarshaller<Document, CborMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Document requestObject, CborMarshallerContext context)
        {
            if (requestObject == null)
                return;

            if (requestObject.IsSetBody())
            {
                context.Writer.WriteTextString("Body");
                context.Writer.WriteTextString(requestObject.Body);
            }
            if (requestObject.IsSetGroupId())
            {
                context.Writer.WriteTextString("GroupId");
                context.Writer.WriteTextString(requestObject.GroupId);
            }
            if (requestObject.IsSetId())
            {
                context.Writer.WriteTextString("Id");
                context.Writer.WriteTextString(requestObject.Id);
            }
            if (requestObject.IsSetOriginalScore())
            {
                context.Writer.WriteTextString("OriginalScore");
                context.Writer.WriteOptimizedNumber(requestObject.OriginalScore.Value);
            }
            if (requestObject.IsSetTitle())
            {
                context.Writer.WriteTextString("Title");
                context.Writer.WriteTextString(requestObject.Title);
            }
            if (requestObject.IsSetTokenizedBody())
            {
                context.Writer.WriteTextString("TokenizedBody");
                context.Writer.WriteStartArray(requestObject.TokenizedBody.Count);
                foreach(var requestObjectTokenizedBodyListValue in requestObject.TokenizedBody)
                {
                        context.Writer.WriteTextString(requestObjectTokenizedBodyListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetTokenizedTitle())
            {
                context.Writer.WriteTextString("TokenizedTitle");
                context.Writer.WriteStartArray(requestObject.TokenizedTitle.Count);
                foreach(var requestObjectTokenizedTitleListValue in requestObject.TokenizedTitle)
                {
                        context.Writer.WriteTextString(requestObjectTokenizedTitleListValue);
                }
                context.Writer.WriteEndArray();
            }
        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DocumentMarshaller Instance = new DocumentMarshaller();

    }
}