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
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.FMS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ProtocolsListData Marshaller
    /// </summary>
    public class ProtocolsListDataMarshaller : IRequestMarshaller<ProtocolsListData, CborMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ProtocolsListData requestObject, CborMarshallerContext context)
        {
            if (requestObject == null)
                return;

            if (requestObject.IsSetCreateTime())
            {
                context.Writer.WriteTextString("CreateTime");
                context.Writer.WriteDateTime(requestObject.CreateTime.Value);
            }
            if (requestObject.IsSetLastUpdateTime())
            {
                context.Writer.WriteTextString("LastUpdateTime");
                context.Writer.WriteDateTime(requestObject.LastUpdateTime.Value);
            }
            if (requestObject.IsSetListId())
            {
                context.Writer.WriteTextString("ListId");
                context.Writer.WriteTextString(requestObject.ListId);
            }
            if (requestObject.IsSetListName())
            {
                context.Writer.WriteTextString("ListName");
                context.Writer.WriteTextString(requestObject.ListName);
            }
            if (requestObject.IsSetListUpdateToken())
            {
                context.Writer.WriteTextString("ListUpdateToken");
                context.Writer.WriteTextString(requestObject.ListUpdateToken);
            }
            if (requestObject.IsSetPreviousProtocolsList())
            {
                context.Writer.WriteTextString("PreviousProtocolsList");
                context.Writer.WriteStartMap(null);
                foreach (var requestObjectPreviousProtocolsListKvp in requestObject.PreviousProtocolsList)
                {
                    context.Writer.WriteTextString(requestObjectPreviousProtocolsListKvp.Key);
                    var requestObjectPreviousProtocolsListValue = requestObjectPreviousProtocolsListKvp.Value;

                    context.Writer.WriteStartArray(requestObjectPreviousProtocolsListValue.Count);
                    foreach(var requestObjectPreviousProtocolsListValueListValue in requestObjectPreviousProtocolsListValue)
                    {
                            context.Writer.WriteTextString(requestObjectPreviousProtocolsListValueListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetProtocolsList())
            {
                context.Writer.WriteTextString("ProtocolsList");
                context.Writer.WriteStartArray(requestObject.ProtocolsList.Count);
                foreach(var requestObjectProtocolsListListValue in requestObject.ProtocolsList)
                {
                        context.Writer.WriteTextString(requestObjectProtocolsListListValue);
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