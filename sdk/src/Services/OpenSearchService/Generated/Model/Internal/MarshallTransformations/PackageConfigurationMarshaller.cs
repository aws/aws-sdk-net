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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.OpenSearchService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.OpenSearchService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PackageConfiguration Marshaller
    /// </summary>
    public class PackageConfigurationMarshaller : IRequestMarshaller<PackageConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(PackageConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetConfigurationRequirement())
            {
                context.Writer.WritePropertyName("ConfigurationRequirement");
                context.Writer.Write(requestObject.ConfigurationRequirement);
            }

            if(requestObject.IsSetLicenseFilepath())
            {
                context.Writer.WritePropertyName("LicenseFilepath");
                context.Writer.Write(requestObject.LicenseFilepath);
            }

            if(requestObject.IsSetLicenseRequirement())
            {
                context.Writer.WritePropertyName("LicenseRequirement");
                context.Writer.Write(requestObject.LicenseRequirement);
            }

            if(requestObject.IsSetRequiresRestartForConfigurationUpdate())
            {
                context.Writer.WritePropertyName("RequiresRestartForConfigurationUpdate");
                context.Writer.Write(requestObject.RequiresRestartForConfigurationUpdate);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PackageConfigurationMarshaller Instance = new PackageConfigurationMarshaller();

    }
}