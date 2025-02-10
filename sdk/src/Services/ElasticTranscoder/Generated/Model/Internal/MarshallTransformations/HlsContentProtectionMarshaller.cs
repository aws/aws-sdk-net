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
 * Do not modify this file. This file is generated from the elastictranscoder-2012-09-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticTranscoder.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ElasticTranscoder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// HlsContentProtection Marshaller
    /// </summary>
    public class HlsContentProtectionMarshaller : IRequestMarshaller<HlsContentProtection, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(HlsContentProtection requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetInitializationVector())
            {
                context.Writer.WritePropertyName("InitializationVector");
                context.Writer.WriteStringValue(requestObject.InitializationVector);
            }

            if(requestObject.IsSetKey())
            {
                context.Writer.WritePropertyName("Key");
                context.Writer.WriteStringValue(requestObject.Key);
            }

            if(requestObject.IsSetKeyMd5())
            {
                context.Writer.WritePropertyName("KeyMd5");
                context.Writer.WriteStringValue(requestObject.KeyMd5);
            }

            if(requestObject.IsSetKeyStoragePolicy())
            {
                context.Writer.WritePropertyName("KeyStoragePolicy");
                context.Writer.WriteStringValue(requestObject.KeyStoragePolicy);
            }

            if(requestObject.IsSetLicenseAcquisitionUrl())
            {
                context.Writer.WritePropertyName("LicenseAcquisitionUrl");
                context.Writer.WriteStringValue(requestObject.LicenseAcquisitionUrl);
            }

            if(requestObject.IsSetMethod())
            {
                context.Writer.WritePropertyName("Method");
                context.Writer.WriteStringValue(requestObject.Method);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static HlsContentProtectionMarshaller Instance = new HlsContentProtectionMarshaller();

    }
}