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
    /// RecommendationJobContainerConfig Marshaller
    /// </summary>
    public class RecommendationJobContainerConfigMarshaller : IRequestMarshaller<RecommendationJobContainerConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RecommendationJobContainerConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDataInputConfig())
            {
                context.Writer.WritePropertyName("DataInputConfig");
                context.Writer.Write(requestObject.DataInputConfig);
            }

            if(requestObject.IsSetDomain())
            {
                context.Writer.WritePropertyName("Domain");
                context.Writer.Write(requestObject.Domain);
            }

            if(requestObject.IsSetFramework())
            {
                context.Writer.WritePropertyName("Framework");
                context.Writer.Write(requestObject.Framework);
            }

            if(requestObject.IsSetFrameworkVersion())
            {
                context.Writer.WritePropertyName("FrameworkVersion");
                context.Writer.Write(requestObject.FrameworkVersion);
            }

            if(requestObject.IsSetNearestModelName())
            {
                context.Writer.WritePropertyName("NearestModelName");
                context.Writer.Write(requestObject.NearestModelName);
            }

            if(requestObject.IsSetPayloadConfig())
            {
                context.Writer.WritePropertyName("PayloadConfig");
                context.Writer.WriteObjectStart();

                var marshaller = RecommendationJobPayloadConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.PayloadConfig, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSupportedInstanceTypes())
            {
                context.Writer.WritePropertyName("SupportedInstanceTypes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSupportedInstanceTypesListValue in requestObject.SupportedInstanceTypes)
                {
                        context.Writer.Write(requestObjectSupportedInstanceTypesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetTask())
            {
                context.Writer.WritePropertyName("Task");
                context.Writer.Write(requestObject.Task);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RecommendationJobContainerConfigMarshaller Instance = new RecommendationJobContainerConfigMarshaller();

    }
}