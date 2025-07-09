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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Batch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Batch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// LaunchTemplateSpecification Marshaller
    /// </summary>
    public class LaunchTemplateSpecificationMarshaller : IRequestMarshaller<LaunchTemplateSpecification, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(LaunchTemplateSpecification requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetLaunchTemplateId())
            {
                context.Writer.WritePropertyName("launchTemplateId");
                context.Writer.WriteStringValue(requestObject.LaunchTemplateId);
            }

            if(requestObject.IsSetLaunchTemplateName())
            {
                context.Writer.WritePropertyName("launchTemplateName");
                context.Writer.WriteStringValue(requestObject.LaunchTemplateName);
            }

            if(requestObject.IsSetOverrides())
            {
                context.Writer.WritePropertyName("overrides");
                context.Writer.WriteStartArray();
                foreach(var requestObjectOverridesListValue in requestObject.Overrides)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = LaunchTemplateSpecificationOverrideMarshaller.Instance;
                    marshaller.Marshall(requestObjectOverridesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetUserdataType())
            {
                context.Writer.WritePropertyName("userdataType");
                context.Writer.WriteStringValue(requestObject.UserdataType);
            }

            if(requestObject.IsSetVersion())
            {
                context.Writer.WritePropertyName("version");
                context.Writer.WriteStringValue(requestObject.Version);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static LaunchTemplateSpecificationMarshaller Instance = new LaunchTemplateSpecificationMarshaller();

    }
}