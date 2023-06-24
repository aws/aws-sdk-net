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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsEc2LaunchTemplateDetails Marshaller
    /// </summary>
    public class AwsEc2LaunchTemplateDetailsMarshaller : IRequestMarshaller<AwsEc2LaunchTemplateDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsEc2LaunchTemplateDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDefaultVersionNumber())
            {
                context.Writer.WritePropertyName("DefaultVersionNumber");
                context.Writer.Write(requestObject.DefaultVersionNumber);
            }

            if(requestObject.IsSetId())
            {
                context.Writer.WritePropertyName("Id");
                context.Writer.Write(requestObject.Id);
            }

            if(requestObject.IsSetLatestVersionNumber())
            {
                context.Writer.WritePropertyName("LatestVersionNumber");
                context.Writer.Write(requestObject.LatestVersionNumber);
            }

            if(requestObject.IsSetLaunchTemplateData())
            {
                context.Writer.WritePropertyName("LaunchTemplateData");
                context.Writer.WriteObjectStart();

                var marshaller = AwsEc2LaunchTemplateDataDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.LaunchTemplateData, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetLaunchTemplateName())
            {
                context.Writer.WritePropertyName("LaunchTemplateName");
                context.Writer.Write(requestObject.LaunchTemplateName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsEc2LaunchTemplateDetailsMarshaller Instance = new AwsEc2LaunchTemplateDetailsMarshaller();

    }
}