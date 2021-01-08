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
    /// ServiceCatalogProvisioningDetails Marshaller
    /// </summary>       
    public class ServiceCatalogProvisioningDetailsMarshaller : IRequestMarshaller<ServiceCatalogProvisioningDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ServiceCatalogProvisioningDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetPathId())
            {
                context.Writer.WritePropertyName("PathId");
                context.Writer.Write(requestObject.PathId);
            }

            if(requestObject.IsSetProductId())
            {
                context.Writer.WritePropertyName("ProductId");
                context.Writer.Write(requestObject.ProductId);
            }

            if(requestObject.IsSetProvisioningArtifactId())
            {
                context.Writer.WritePropertyName("ProvisioningArtifactId");
                context.Writer.Write(requestObject.ProvisioningArtifactId);
            }

            if(requestObject.IsSetProvisioningParameters())
            {
                context.Writer.WritePropertyName("ProvisioningParameters");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectProvisioningParametersListValue in requestObject.ProvisioningParameters)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ProvisioningParameterMarshaller.Instance;
                    marshaller.Marshall(requestObjectProvisioningParametersListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static ServiceCatalogProvisioningDetailsMarshaller Instance = new ServiceCatalogProvisioningDetailsMarshaller();

    }
}