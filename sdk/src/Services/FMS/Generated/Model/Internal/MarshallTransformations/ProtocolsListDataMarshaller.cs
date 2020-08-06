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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.FMS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.FMS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ProtocolsListData Marshaller
    /// </summary>       
    public class ProtocolsListDataMarshaller : IRequestMarshaller<ProtocolsListData, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ProtocolsListData requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCreateTime())
            {
                context.Writer.WritePropertyName("CreateTime");
                context.Writer.Write(requestObject.CreateTime);
            }

            if(requestObject.IsSetLastUpdateTime())
            {
                context.Writer.WritePropertyName("LastUpdateTime");
                context.Writer.Write(requestObject.LastUpdateTime);
            }

            if(requestObject.IsSetListId())
            {
                context.Writer.WritePropertyName("ListId");
                context.Writer.Write(requestObject.ListId);
            }

            if(requestObject.IsSetListName())
            {
                context.Writer.WritePropertyName("ListName");
                context.Writer.Write(requestObject.ListName);
            }

            if(requestObject.IsSetListUpdateToken())
            {
                context.Writer.WritePropertyName("ListUpdateToken");
                context.Writer.Write(requestObject.ListUpdateToken);
            }

            if(requestObject.IsSetPreviousProtocolsList())
            {
                context.Writer.WritePropertyName("PreviousProtocolsList");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectPreviousProtocolsListKvp in requestObject.PreviousProtocolsList)
                {
                    context.Writer.WritePropertyName(requestObjectPreviousProtocolsListKvp.Key);
                    var requestObjectPreviousProtocolsListValue = requestObjectPreviousProtocolsListKvp.Value;

                    context.Writer.WriteArrayStart();
                    foreach(var requestObjectPreviousProtocolsListValueListValue in requestObjectPreviousProtocolsListValue)
                    {
                            context.Writer.Write(requestObjectPreviousProtocolsListValueListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetProtocolsList())
            {
                context.Writer.WritePropertyName("ProtocolsList");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectProtocolsListListValue in requestObject.ProtocolsList)
                {
                        context.Writer.Write(requestObjectProtocolsListListValue);
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static ProtocolsListDataMarshaller Instance = new ProtocolsListDataMarshaller();

    }
}