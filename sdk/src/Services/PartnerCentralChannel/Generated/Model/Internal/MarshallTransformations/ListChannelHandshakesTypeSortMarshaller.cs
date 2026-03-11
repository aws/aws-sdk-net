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
 * Do not modify this file. This file is generated from the partnercentral-channel-2024-03-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.PartnerCentralChannel.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.PartnerCentralChannel.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListChannelHandshakesTypeSort Marshaller
    /// </summary>
    public class ListChannelHandshakesTypeSortMarshaller : IRequestMarshaller<ListChannelHandshakesTypeSort, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ListChannelHandshakesTypeSort requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetProgramManagementAccountTypeSort())
            {
                context.Writer.WritePropertyName("programManagementAccountTypeSort");
                context.Writer.WriteStartObject();

                var marshaller = ProgramManagementAccountTypeSortMarshaller.Instance;
                marshaller.Marshall(requestObject.ProgramManagementAccountTypeSort, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRevokeServicePeriodTypeSort())
            {
                context.Writer.WritePropertyName("revokeServicePeriodTypeSort");
                context.Writer.WriteStartObject();

                var marshaller = RevokeServicePeriodTypeSortMarshaller.Instance;
                marshaller.Marshall(requestObject.RevokeServicePeriodTypeSort, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetStartServicePeriodTypeSort())
            {
                context.Writer.WritePropertyName("startServicePeriodTypeSort");
                context.Writer.WriteStartObject();

                var marshaller = StartServicePeriodTypeSortMarshaller.Instance;
                marshaller.Marshall(requestObject.StartServicePeriodTypeSort, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ListChannelHandshakesTypeSortMarshaller Instance = new ListChannelHandshakesTypeSortMarshaller();

    }
}