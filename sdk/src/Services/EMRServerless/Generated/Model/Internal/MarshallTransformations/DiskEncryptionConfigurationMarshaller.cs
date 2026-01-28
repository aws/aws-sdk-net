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
 * Do not modify this file. This file is generated from the emr-serverless-2021-07-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EMRServerless.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.EMRServerless.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DiskEncryptionConfiguration Marshaller
    /// </summary>
    public class DiskEncryptionConfigurationMarshaller : IRequestMarshaller<DiskEncryptionConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DiskEncryptionConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetEncryptionContext())
            {
                context.Writer.WritePropertyName("encryptionContext");
                context.Writer.WriteStartObject();
                foreach (var requestObjectEncryptionContextKvp in requestObject.EncryptionContext)
                {
                    context.Writer.WritePropertyName(requestObjectEncryptionContextKvp.Key);
                    var requestObjectEncryptionContextValue = requestObjectEncryptionContextKvp.Value;

                        context.Writer.WriteStringValue(requestObjectEncryptionContextValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEncryptionKeyArn())
            {
                context.Writer.WritePropertyName("encryptionKeyArn");
                context.Writer.WriteStringValue(requestObject.EncryptionKeyArn);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DiskEncryptionConfigurationMarshaller Instance = new DiskEncryptionConfigurationMarshaller();

    }
}