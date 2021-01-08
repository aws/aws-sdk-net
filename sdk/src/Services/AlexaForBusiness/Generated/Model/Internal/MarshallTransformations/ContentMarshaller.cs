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
 * Do not modify this file. This file is generated from the alexaforbusiness-2017-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AlexaForBusiness.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AlexaForBusiness.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Content Marshaller
    /// </summary>       
    public class ContentMarshaller : IRequestMarshaller<Content, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Content requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAudioList())
            {
                context.Writer.WritePropertyName("AudioList");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAudioListListValue in requestObject.AudioList)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AudioMarshaller.Instance;
                    marshaller.Marshall(requestObjectAudioListListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSsmlList())
            {
                context.Writer.WritePropertyName("SsmlList");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSsmlListListValue in requestObject.SsmlList)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = SsmlMarshaller.Instance;
                    marshaller.Marshall(requestObjectSsmlListListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetTextList())
            {
                context.Writer.WritePropertyName("TextList");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectTextListListValue in requestObject.TextList)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = TextMarshaller.Instance;
                    marshaller.Marshall(requestObjectTextListListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static ContentMarshaller Instance = new ContentMarshaller();

    }
}