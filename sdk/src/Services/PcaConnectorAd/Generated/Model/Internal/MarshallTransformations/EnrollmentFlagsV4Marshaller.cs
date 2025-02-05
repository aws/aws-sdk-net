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
 * Do not modify this file. This file is generated from the pca-connector-ad-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.PcaConnectorAd.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.PcaConnectorAd.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EnrollmentFlagsV4 Marshaller
    /// </summary>
    public class EnrollmentFlagsV4Marshaller : IRequestMarshaller<EnrollmentFlagsV4, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(EnrollmentFlagsV4 requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetEnableKeyReuseOnNtTokenKeysetStorageFull())
            {
                context.Writer.WritePropertyName("EnableKeyReuseOnNtTokenKeysetStorageFull");
                context.Writer.WriteBooleanValue(requestObject.EnableKeyReuseOnNtTokenKeysetStorageFull.Value);
            }

            if(requestObject.IsSetIncludeSymmetricAlgorithms())
            {
                context.Writer.WritePropertyName("IncludeSymmetricAlgorithms");
                context.Writer.WriteBooleanValue(requestObject.IncludeSymmetricAlgorithms.Value);
            }

            if(requestObject.IsSetNoSecurityExtension())
            {
                context.Writer.WritePropertyName("NoSecurityExtension");
                context.Writer.WriteBooleanValue(requestObject.NoSecurityExtension.Value);
            }

            if(requestObject.IsSetRemoveInvalidCertificateFromPersonalStore())
            {
                context.Writer.WritePropertyName("RemoveInvalidCertificateFromPersonalStore");
                context.Writer.WriteBooleanValue(requestObject.RemoveInvalidCertificateFromPersonalStore.Value);
            }

            if(requestObject.IsSetUserInteractionRequired())
            {
                context.Writer.WritePropertyName("UserInteractionRequired");
                context.Writer.WriteBooleanValue(requestObject.UserInteractionRequired.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static EnrollmentFlagsV4Marshaller Instance = new EnrollmentFlagsV4Marshaller();

    }
}