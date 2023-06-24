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
    /// ProductionVariant Marshaller
    /// </summary>
    public class ProductionVariantMarshaller : IRequestMarshaller<ProductionVariant, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ProductionVariant requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAcceleratorType())
            {
                context.Writer.WritePropertyName("AcceleratorType");
                context.Writer.Write(requestObject.AcceleratorType);
            }

            if(requestObject.IsSetContainerStartupHealthCheckTimeoutInSeconds())
            {
                context.Writer.WritePropertyName("ContainerStartupHealthCheckTimeoutInSeconds");
                context.Writer.Write(requestObject.ContainerStartupHealthCheckTimeoutInSeconds);
            }

            if(requestObject.IsSetCoreDumpConfig())
            {
                context.Writer.WritePropertyName("CoreDumpConfig");
                context.Writer.WriteObjectStart();

                var marshaller = ProductionVariantCoreDumpConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.CoreDumpConfig, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetEnableSSMAccess())
            {
                context.Writer.WritePropertyName("EnableSSMAccess");
                context.Writer.Write(requestObject.EnableSSMAccess);
            }

            if(requestObject.IsSetInitialInstanceCount())
            {
                context.Writer.WritePropertyName("InitialInstanceCount");
                context.Writer.Write(requestObject.InitialInstanceCount);
            }

            if(requestObject.IsSetInitialVariantWeight())
            {
                context.Writer.WritePropertyName("InitialVariantWeight");
                context.Writer.Write(requestObject.InitialVariantWeight);
            }

            if(requestObject.IsSetInstanceType())
            {
                context.Writer.WritePropertyName("InstanceType");
                context.Writer.Write(requestObject.InstanceType);
            }

            if(requestObject.IsSetModelDataDownloadTimeoutInSeconds())
            {
                context.Writer.WritePropertyName("ModelDataDownloadTimeoutInSeconds");
                context.Writer.Write(requestObject.ModelDataDownloadTimeoutInSeconds);
            }

            if(requestObject.IsSetModelName())
            {
                context.Writer.WritePropertyName("ModelName");
                context.Writer.Write(requestObject.ModelName);
            }

            if(requestObject.IsSetServerlessConfig())
            {
                context.Writer.WritePropertyName("ServerlessConfig");
                context.Writer.WriteObjectStart();

                var marshaller = ProductionVariantServerlessConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.ServerlessConfig, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetVariantName())
            {
                context.Writer.WritePropertyName("VariantName");
                context.Writer.Write(requestObject.VariantName);
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
        public readonly static ProductionVariantMarshaller Instance = new ProductionVariantMarshaller();

    }
}