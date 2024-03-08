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
 * Do not modify this file. This file is generated from the json-rpc-10-2020-07-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.JSONRPC10.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.JSONRPC10.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TopLevel Marshaller
    /// </summary>
    public class TopLevelMarshaller : IRequestMarshaller<TopLevel, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TopLevel requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDialog())
            {
                context.Writer.WritePropertyName("dialog");
                context.Writer.WriteObjectStart();

                var marshaller = DialogMarshaller.Instance;
                marshaller.Marshall(requestObject.Dialog, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDialogList())
            {
                context.Writer.WritePropertyName("dialogList");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectDialogListListValue in requestObject.DialogList)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = DialogMarshaller.Instance;
                    marshaller.Marshall(requestObjectDialogListListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetDialogMap())
            {
                context.Writer.WritePropertyName("dialogMap");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectDialogMapKvp in requestObject.DialogMap)
                {
                    context.Writer.WritePropertyName(requestObjectDialogMapKvp.Key);
                    var requestObjectDialogMapValue = requestObjectDialogMapKvp.Value;

                    context.Writer.WriteObjectStart();

                    var marshaller = DialogMarshaller.Instance;
                    marshaller.Marshall(requestObjectDialogMapValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TopLevelMarshaller Instance = new TopLevelMarshaller();

    }
}