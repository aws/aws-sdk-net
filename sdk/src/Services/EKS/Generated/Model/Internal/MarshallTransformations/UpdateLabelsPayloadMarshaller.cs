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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EKS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.EKS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateLabelsPayload Marshaller
    /// </summary>       
    public class UpdateLabelsPayloadMarshaller : IRequestMarshaller<UpdateLabelsPayload, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(UpdateLabelsPayload requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAddOrUpdateLabels())
            {
                context.Writer.WritePropertyName("addOrUpdateLabels");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectAddOrUpdateLabelsKvp in requestObject.AddOrUpdateLabels)
                {
                    context.Writer.WritePropertyName(requestObjectAddOrUpdateLabelsKvp.Key);
                    var requestObjectAddOrUpdateLabelsValue = requestObjectAddOrUpdateLabelsKvp.Value;

                        context.Writer.Write(requestObjectAddOrUpdateLabelsValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRemoveLabels())
            {
                context.Writer.WritePropertyName("removeLabels");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectRemoveLabelsListValue in requestObject.RemoveLabels)
                {
                        context.Writer.Write(requestObjectRemoveLabelsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static UpdateLabelsPayloadMarshaller Instance = new UpdateLabelsPayloadMarshaller();

    }
}