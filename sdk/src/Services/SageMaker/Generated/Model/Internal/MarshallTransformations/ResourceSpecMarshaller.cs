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
#pragma warning disable CS0612,CS0618
namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ResourceSpec Marshaller
    /// </summary>
    public class ResourceSpecMarshaller : IRequestMarshaller<ResourceSpec, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ResourceSpec requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetInstanceType())
            {
                context.Writer.WritePropertyName("InstanceType");
                context.Writer.WriteStringValue(requestObject.InstanceType);
            }

            if(requestObject.IsSetLifecycleConfigArn())
            {
                context.Writer.WritePropertyName("LifecycleConfigArn");
                context.Writer.WriteStringValue(requestObject.LifecycleConfigArn);
            }

            if(requestObject.IsSetSageMakerImageArn())
            {
                context.Writer.WritePropertyName("SageMakerImageArn");
                context.Writer.WriteStringValue(requestObject.SageMakerImageArn);
            }

            if(requestObject.IsSetSageMakerImageVersionAlias())
            {
                context.Writer.WritePropertyName("SageMakerImageVersionAlias");
                context.Writer.WriteStringValue(requestObject.SageMakerImageVersionAlias);
            }

            if(requestObject.IsSetSageMakerImageVersionArn())
            {
                context.Writer.WritePropertyName("SageMakerImageVersionArn");
                context.Writer.WriteStringValue(requestObject.SageMakerImageVersionArn);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ResourceSpecMarshaller Instance = new ResourceSpecMarshaller();

    }
}