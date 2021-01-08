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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ProfilerRuleConfiguration Marshaller
    /// </summary>       
    public class ProfilerRuleConfigurationMarshaller : IRequestMarshaller<ProfilerRuleConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ProfilerRuleConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetInstanceType())
            {
                context.Writer.WritePropertyName("InstanceType");
                context.Writer.Write(requestObject.InstanceType);
            }

            if(requestObject.IsSetLocalPath())
            {
                context.Writer.WritePropertyName("LocalPath");
                context.Writer.Write(requestObject.LocalPath);
            }

            if(requestObject.IsSetRuleConfigurationName())
            {
                context.Writer.WritePropertyName("RuleConfigurationName");
                context.Writer.Write(requestObject.RuleConfigurationName);
            }

            if(requestObject.IsSetRuleEvaluatorImage())
            {
                context.Writer.WritePropertyName("RuleEvaluatorImage");
                context.Writer.Write(requestObject.RuleEvaluatorImage);
            }

            if(requestObject.IsSetRuleParameters())
            {
                context.Writer.WritePropertyName("RuleParameters");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectRuleParametersKvp in requestObject.RuleParameters)
                {
                    context.Writer.WritePropertyName(requestObjectRuleParametersKvp.Key);
                    var requestObjectRuleParametersValue = requestObjectRuleParametersKvp.Value;

                        context.Writer.Write(requestObjectRuleParametersValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetS3OutputPath())
            {
                context.Writer.WritePropertyName("S3OutputPath");
                context.Writer.Write(requestObject.S3OutputPath);
            }

            if(requestObject.IsSetVolumeSizeInGB())
            {
                context.Writer.WritePropertyName("VolumeSizeInGB");
                context.Writer.Write(requestObject.VolumeSizeInGB);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static ProfilerRuleConfigurationMarshaller Instance = new ProfilerRuleConfigurationMarshaller();

    }
}