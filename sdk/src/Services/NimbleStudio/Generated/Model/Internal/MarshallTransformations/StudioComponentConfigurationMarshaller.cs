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
 * Do not modify this file. This file is generated from the nimble-2020-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.NimbleStudio.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.NimbleStudio.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StudioComponentConfiguration Marshaller
    /// </summary>       
    public class StudioComponentConfigurationMarshaller : IRequestMarshaller<StudioComponentConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(StudioComponentConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetActiveDirectoryConfiguration())
            {
                context.Writer.WritePropertyName("activeDirectoryConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = ActiveDirectoryConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ActiveDirectoryConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetComputeFarmConfiguration())
            {
                context.Writer.WritePropertyName("computeFarmConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = ComputeFarmConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ComputeFarmConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetLicenseServiceConfiguration())
            {
                context.Writer.WritePropertyName("licenseServiceConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = LicenseServiceConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.LicenseServiceConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSharedFileSystemConfiguration())
            {
                context.Writer.WritePropertyName("sharedFileSystemConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = SharedFileSystemConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.SharedFileSystemConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static StudioComponentConfigurationMarshaller Instance = new StudioComponentConfigurationMarshaller();

    }
}