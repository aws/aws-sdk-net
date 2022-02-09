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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsOpenSearchServiceDomainServiceSoftwareOptionsDetails Marshaller
    /// </summary>
    public class AwsOpenSearchServiceDomainServiceSoftwareOptionsDetailsMarshaller : IRequestMarshaller<AwsOpenSearchServiceDomainServiceSoftwareOptionsDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsOpenSearchServiceDomainServiceSoftwareOptionsDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAutomatedUpdateDate())
            {
                context.Writer.WritePropertyName("AutomatedUpdateDate");
                context.Writer.Write(requestObject.AutomatedUpdateDate);
            }

            if(requestObject.IsSetCancellable())
            {
                context.Writer.WritePropertyName("Cancellable");
                context.Writer.Write(requestObject.Cancellable);
            }

            if(requestObject.IsSetCurrentVersion())
            {
                context.Writer.WritePropertyName("CurrentVersion");
                context.Writer.Write(requestObject.CurrentVersion);
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.Write(requestObject.Description);
            }

            if(requestObject.IsSetNewVersion())
            {
                context.Writer.WritePropertyName("NewVersion");
                context.Writer.Write(requestObject.NewVersion);
            }

            if(requestObject.IsSetOptionalDeployment())
            {
                context.Writer.WritePropertyName("OptionalDeployment");
                context.Writer.Write(requestObject.OptionalDeployment);
            }

            if(requestObject.IsSetUpdateAvailable())
            {
                context.Writer.WritePropertyName("UpdateAvailable");
                context.Writer.Write(requestObject.UpdateAvailable);
            }

            if(requestObject.IsSetUpdateStatus())
            {
                context.Writer.WritePropertyName("UpdateStatus");
                context.Writer.Write(requestObject.UpdateStatus);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsOpenSearchServiceDomainServiceSoftwareOptionsDetailsMarshaller Instance = new AwsOpenSearchServiceDomainServiceSoftwareOptionsDetailsMarshaller();

    }
}