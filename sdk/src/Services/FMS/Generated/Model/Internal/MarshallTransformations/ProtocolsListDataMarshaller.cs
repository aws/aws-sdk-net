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
#pragma warning disable CS0612,CS0618
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
            if(requestObject == null)
                return;
            if(requestObject.IsSetCreateTime())
            {
                context.Writer.WritePropertyName("CreateTime");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(requestObject.CreateTime.Value)));
            }

            if(requestObject.IsSetLastUpdateTime())
            {
                context.Writer.WritePropertyName("LastUpdateTime");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(requestObject.LastUpdateTime.Value)));
            }

            if(requestObject.IsSetListId())
            {
                context.Writer.WritePropertyName("ListId");
                context.Writer.WriteStringValue(requestObject.ListId);
            }

            if(requestObject.IsSetListName())
            {
                context.Writer.WritePropertyName("ListName");
                context.Writer.WriteStringValue(requestObject.ListName);
            }

            if(requestObject.IsSetListUpdateToken())
            {
                context.Writer.WritePropertyName("ListUpdateToken");
                context.Writer.WriteStringValue(requestObject.ListUpdateToken);
            }

            if(requestObject.IsSetPreviousProtocolsList())
            {
                context.Writer.WritePropertyName("PreviousProtocolsList");
                context.Writer.WriteStartObject();
                foreach (var requestObjectPreviousProtocolsListKvp in requestObject.PreviousProtocolsList)
                {
                    context.Writer.WritePropertyName(requestObjectPreviousProtocolsListKvp.Key);
                    var requestObjectPreviousProtocolsListValue = requestObjectPreviousProtocolsListKvp.Value;

                    context.Writer.WriteStartArray();
                    foreach(var requestObjectPreviousProtocolsListValueListValue in requestObjectPreviousProtocolsListValue)
                    {
                            context.Writer.WriteStringValue(requestObjectPreviousProtocolsListValueListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetProtocolsList())
            {
                context.Writer.WritePropertyName("ProtocolsList");
                context.Writer.WriteStartArray();
                foreach(var requestObjectProtocolsListListValue in requestObject.ProtocolsList)
                {
                        context.Writer.WriteStringValue(requestObjectProtocolsListListValue);
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ProtocolsListDataMarshaller Instance = new ProtocolsListDataMarshaller();

    }
}