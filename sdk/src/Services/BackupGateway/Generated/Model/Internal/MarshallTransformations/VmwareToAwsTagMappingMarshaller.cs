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
 * Do not modify this file. This file is generated from the backup-gateway-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BackupGateway.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.BackupGateway.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// VmwareToAwsTagMapping Marshaller
    /// </summary>
    public class VmwareToAwsTagMappingMarshaller : IRequestMarshaller<VmwareToAwsTagMapping, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(VmwareToAwsTagMapping requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAwsTagKey())
            {
                context.Writer.WritePropertyName("AwsTagKey");
                context.Writer.Write(requestObject.AwsTagKey);
            }

            if(requestObject.IsSetAwsTagValue())
            {
                context.Writer.WritePropertyName("AwsTagValue");
                context.Writer.Write(requestObject.AwsTagValue);
            }

            if(requestObject.IsSetVmwareCategory())
            {
                context.Writer.WritePropertyName("VmwareCategory");
                context.Writer.Write(requestObject.VmwareCategory);
            }

            if(requestObject.IsSetVmwareTagName())
            {
                context.Writer.WritePropertyName("VmwareTagName");
                context.Writer.Write(requestObject.VmwareTagName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static VmwareToAwsTagMappingMarshaller Instance = new VmwareToAwsTagMappingMarshaller();

    }
}