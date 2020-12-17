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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Imagebuilder.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Imagebuilder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Distribution Marshaller
    /// </summary>       
    public class DistributionMarshaller : IRequestMarshaller<Distribution, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Distribution requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAmiDistributionConfiguration())
            {
                context.Writer.WritePropertyName("amiDistributionConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = AmiDistributionConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.AmiDistributionConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetContainerDistributionConfiguration())
            {
                context.Writer.WritePropertyName("containerDistributionConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = ContainerDistributionConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ContainerDistributionConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetLicenseConfigurationArns())
            {
                context.Writer.WritePropertyName("licenseConfigurationArns");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectLicenseConfigurationArnsListValue in requestObject.LicenseConfigurationArns)
                {
                        context.Writer.Write(requestObjectLicenseConfigurationArnsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetRegion())
            {
                context.Writer.WritePropertyName("region");
                context.Writer.Write(requestObject.Region);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static DistributionMarshaller Instance = new DistributionMarshaller();

    }
}