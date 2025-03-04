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
 * Do not modify this file. This file is generated from the acm-pca-2017-08-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ACMPCA.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ACMPCA.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CrlConfiguration Marshaller
    /// </summary>
    public class CrlConfigurationMarshaller : IRequestMarshaller<CrlConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CrlConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCrlDistributionPointExtensionConfiguration())
            {
                context.Writer.WritePropertyName("CrlDistributionPointExtensionConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = CrlDistributionPointExtensionConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.CrlDistributionPointExtensionConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCrlType())
            {
                context.Writer.WritePropertyName("CrlType");
                context.Writer.WriteStringValue(requestObject.CrlType);
            }

            if(requestObject.IsSetCustomCname())
            {
                context.Writer.WritePropertyName("CustomCname");
                context.Writer.WriteStringValue(requestObject.CustomCname);
            }

            if(requestObject.IsSetCustomPath())
            {
                context.Writer.WritePropertyName("CustomPath");
                context.Writer.WriteStringValue(requestObject.CustomPath);
            }

            if(requestObject.IsSetEnabled())
            {
                context.Writer.WritePropertyName("Enabled");
                context.Writer.WriteBooleanValue(requestObject.Enabled.Value);
            }

            if(requestObject.IsSetExpirationInDays())
            {
                context.Writer.WritePropertyName("ExpirationInDays");
                context.Writer.WriteNumberValue(requestObject.ExpirationInDays.Value);
            }

            if(requestObject.IsSetS3BucketName())
            {
                context.Writer.WritePropertyName("S3BucketName");
                context.Writer.WriteStringValue(requestObject.S3BucketName);
            }

            if(requestObject.IsSetS3ObjectAcl())
            {
                context.Writer.WritePropertyName("S3ObjectAcl");
                context.Writer.WriteStringValue(requestObject.S3ObjectAcl);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CrlConfigurationMarshaller Instance = new CrlConfigurationMarshaller();

    }
}