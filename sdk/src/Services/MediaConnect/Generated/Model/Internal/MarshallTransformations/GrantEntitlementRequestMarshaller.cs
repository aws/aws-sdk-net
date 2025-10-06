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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaConnect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.MediaConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GrantEntitlementRequest Marshaller
    /// </summary>
    public class GrantEntitlementRequestMarshaller : IRequestMarshaller<GrantEntitlementRequest, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(GrantEntitlementRequest requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDataTransferSubscriberFeePercent())
            {
                context.Writer.WritePropertyName("dataTransferSubscriberFeePercent");
                context.Writer.Write(requestObject.DataTransferSubscriberFeePercent);
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.Write(requestObject.Description);
            }

            if(requestObject.IsSetEncryption())
            {
                context.Writer.WritePropertyName("encryption");
                context.Writer.WriteObjectStart();

                var marshaller = EncryptionMarshaller.Instance;
                marshaller.Marshall(requestObject.Encryption, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetEntitlementStatus())
            {
                context.Writer.WritePropertyName("entitlementStatus");
                context.Writer.Write(requestObject.EntitlementStatus);
            }

            if(requestObject.IsSetEntitlementTags())
            {
                context.Writer.WritePropertyName("entitlementTags");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectEntitlementTagsKvp in requestObject.EntitlementTags)
                {
                    context.Writer.WritePropertyName(requestObjectEntitlementTagsKvp.Key);
                    var requestObjectEntitlementTagsValue = requestObjectEntitlementTagsKvp.Value;

                        context.Writer.Write(requestObjectEntitlementTagsValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.Write(requestObject.Name);
            }

            if(requestObject.IsSetSubscribers())
            {
                context.Writer.WritePropertyName("subscribers");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSubscribersListValue in requestObject.Subscribers)
                {
                        context.Writer.Write(requestObjectSubscribersListValue);
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static GrantEntitlementRequestMarshaller Instance = new GrantEntitlementRequestMarshaller();

    }
}