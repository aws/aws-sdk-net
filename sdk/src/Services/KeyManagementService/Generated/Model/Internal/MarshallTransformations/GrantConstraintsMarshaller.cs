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
 * Do not modify this file. This file is generated from the kms-2014-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.KeyManagementService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.KeyManagementService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GrantConstraints Marshaller
    /// </summary>       
    public class GrantConstraintsMarshaller : IRequestMarshaller<GrantConstraints, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(GrantConstraints requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetEncryptionContextEquals())
            {
                context.Writer.WritePropertyName("EncryptionContextEquals");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectEncryptionContextEqualsKvp in requestObject.EncryptionContextEquals)
                {
                    context.Writer.WritePropertyName(requestObjectEncryptionContextEqualsKvp.Key);
                    var requestObjectEncryptionContextEqualsValue = requestObjectEncryptionContextEqualsKvp.Value;

                        context.Writer.Write(requestObjectEncryptionContextEqualsValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetEncryptionContextSubset())
            {
                context.Writer.WritePropertyName("EncryptionContextSubset");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectEncryptionContextSubsetKvp in requestObject.EncryptionContextSubset)
                {
                    context.Writer.WritePropertyName(requestObjectEncryptionContextSubsetKvp.Key);
                    var requestObjectEncryptionContextSubsetValue = requestObjectEncryptionContextSubsetKvp.Value;

                        context.Writer.Write(requestObjectEncryptionContextSubsetValue);
                }
                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static GrantConstraintsMarshaller Instance = new GrantConstraintsMarshaller();

    }
}