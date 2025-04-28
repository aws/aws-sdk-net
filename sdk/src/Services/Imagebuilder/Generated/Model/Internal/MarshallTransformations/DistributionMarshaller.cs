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
#pragma warning disable CS0612,CS0618
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
            if(requestObject == null)
                return;
            if(requestObject.IsSetAmiDistributionConfiguration())
            {
                context.Writer.WritePropertyName("amiDistributionConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = AmiDistributionConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.AmiDistributionConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetContainerDistributionConfiguration())
            {
                context.Writer.WritePropertyName("containerDistributionConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ContainerDistributionConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ContainerDistributionConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFastLaunchConfigurations())
            {
                context.Writer.WritePropertyName("fastLaunchConfigurations");
                context.Writer.WriteStartArray();
                foreach(var requestObjectFastLaunchConfigurationsListValue in requestObject.FastLaunchConfigurations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = FastLaunchConfigurationMarshaller.Instance;
                    marshaller.Marshall(requestObjectFastLaunchConfigurationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetLaunchTemplateConfigurations())
            {
                context.Writer.WritePropertyName("launchTemplateConfigurations");
                context.Writer.WriteStartArray();
                foreach(var requestObjectLaunchTemplateConfigurationsListValue in requestObject.LaunchTemplateConfigurations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = LaunchTemplateConfigurationMarshaller.Instance;
                    marshaller.Marshall(requestObjectLaunchTemplateConfigurationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetLicenseConfigurationArns())
            {
                context.Writer.WritePropertyName("licenseConfigurationArns");
                context.Writer.WriteStartArray();
                foreach(var requestObjectLicenseConfigurationArnsListValue in requestObject.LicenseConfigurationArns)
                {
                        context.Writer.WriteStringValue(requestObjectLicenseConfigurationArnsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetRegion())
            {
                context.Writer.WritePropertyName("region");
                context.Writer.WriteStringValue(requestObject.Region);
            }

            if(requestObject.IsSetS3ExportConfiguration())
            {
                context.Writer.WritePropertyName("s3ExportConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = S3ExportConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.S3ExportConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSsmParameterConfigurations())
            {
                context.Writer.WritePropertyName("ssmParameterConfigurations");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSsmParameterConfigurationsListValue in requestObject.SsmParameterConfigurations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = SsmParameterConfigurationMarshaller.Instance;
                    marshaller.Marshall(requestObjectSsmParameterConfigurationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DistributionMarshaller Instance = new DistributionMarshaller();

    }
}