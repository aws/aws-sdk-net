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

#pragma warning disable CS0612,CS0618
namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ServerlessJobConfig Marshaller
    /// </summary>
    public class ServerlessJobConfigMarshaller : IRequestMarshaller<ServerlessJobConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ServerlessJobConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAcceptEula())
            {
                context.Writer.WritePropertyName("AcceptEula");
                context.Writer.Write(requestObject.AcceptEula);
            }

            if(requestObject.IsSetBaseModelArn())
            {
                context.Writer.WritePropertyName("BaseModelArn");
                context.Writer.Write(requestObject.BaseModelArn);
            }

            if(requestObject.IsSetCustomizationTechnique())
            {
                context.Writer.WritePropertyName("CustomizationTechnique");
                context.Writer.Write(requestObject.CustomizationTechnique);
            }

            if(requestObject.IsSetEvaluationType())
            {
                context.Writer.WritePropertyName("EvaluationType");
                context.Writer.Write(requestObject.EvaluationType);
            }

            if(requestObject.IsSetEvaluatorArn())
            {
                context.Writer.WritePropertyName("EvaluatorArn");
                context.Writer.Write(requestObject.EvaluatorArn);
            }

            if(requestObject.IsSetJobType())
            {
                context.Writer.WritePropertyName("JobType");
                context.Writer.Write(requestObject.JobType);
            }

            if(requestObject.IsSetPeft())
            {
                context.Writer.WritePropertyName("Peft");
                context.Writer.Write(requestObject.Peft);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ServerlessJobConfigMarshaller Instance = new ServerlessJobConfigMarshaller();

    }
}