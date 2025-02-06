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
    /// ModelPackageContainerDefinition Marshaller
    /// </summary>
    public class ModelPackageContainerDefinitionMarshaller : IRequestMarshaller<ModelPackageContainerDefinition, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ModelPackageContainerDefinition requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAdditionalS3DataSource())
            {
                context.Writer.WritePropertyName("AdditionalS3DataSource");
                context.Writer.WriteStartObject();

                var marshaller = AdditionalS3DataSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.AdditionalS3DataSource, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetContainerHostname())
            {
                context.Writer.WritePropertyName("ContainerHostname");
                context.Writer.WriteStringValue(requestObject.ContainerHostname);
            }

            if(requestObject.IsSetEnvironment())
            {
                context.Writer.WritePropertyName("Environment");
                context.Writer.WriteStartObject();
                foreach (var requestObjectEnvironmentKvp in requestObject.Environment)
                {
                    context.Writer.WritePropertyName(requestObjectEnvironmentKvp.Key);
                    var requestObjectEnvironmentValue = requestObjectEnvironmentKvp.Value;

                        context.Writer.WriteStringValue(requestObjectEnvironmentValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFramework())
            {
                context.Writer.WritePropertyName("Framework");
                context.Writer.WriteStringValue(requestObject.Framework);
            }

            if(requestObject.IsSetFrameworkVersion())
            {
                context.Writer.WritePropertyName("FrameworkVersion");
                context.Writer.WriteStringValue(requestObject.FrameworkVersion);
            }

            if(requestObject.IsSetImage())
            {
                context.Writer.WritePropertyName("Image");
                context.Writer.WriteStringValue(requestObject.Image);
            }

            if(requestObject.IsSetImageDigest())
            {
                context.Writer.WritePropertyName("ImageDigest");
                context.Writer.WriteStringValue(requestObject.ImageDigest);
            }

            if(requestObject.IsSetModelDataETag())
            {
                context.Writer.WritePropertyName("ModelDataETag");
                context.Writer.WriteStringValue(requestObject.ModelDataETag);
            }

            if(requestObject.IsSetModelDataSource())
            {
                context.Writer.WritePropertyName("ModelDataSource");
                context.Writer.WriteStartObject();

                var marshaller = ModelDataSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.ModelDataSource, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetModelDataUrl())
            {
                context.Writer.WritePropertyName("ModelDataUrl");
                context.Writer.WriteStringValue(requestObject.ModelDataUrl);
            }

            if(requestObject.IsSetModelInput())
            {
                context.Writer.WritePropertyName("ModelInput");
                context.Writer.WriteStartObject();

                var marshaller = ModelInputMarshaller.Instance;
                marshaller.Marshall(requestObject.ModelInput, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetNearestModelName())
            {
                context.Writer.WritePropertyName("NearestModelName");
                context.Writer.WriteStringValue(requestObject.NearestModelName);
            }

            if(requestObject.IsSetProductId())
            {
                context.Writer.WritePropertyName("ProductId");
                context.Writer.WriteStringValue(requestObject.ProductId);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ModelPackageContainerDefinitionMarshaller Instance = new ModelPackageContainerDefinitionMarshaller();

    }
}