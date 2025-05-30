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
    /// UnifiedStudioSettings Marshaller
    /// </summary>
    public class UnifiedStudioSettingsMarshaller : IRequestMarshaller<UnifiedStudioSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(UnifiedStudioSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDomainAccountId())
            {
                context.Writer.WritePropertyName("DomainAccountId");
                context.Writer.WriteStringValue(requestObject.DomainAccountId);
            }

            if(requestObject.IsSetDomainId())
            {
                context.Writer.WritePropertyName("DomainId");
                context.Writer.WriteStringValue(requestObject.DomainId);
            }

            if(requestObject.IsSetDomainRegion())
            {
                context.Writer.WritePropertyName("DomainRegion");
                context.Writer.WriteStringValue(requestObject.DomainRegion);
            }

            if(requestObject.IsSetEnvironmentId())
            {
                context.Writer.WritePropertyName("EnvironmentId");
                context.Writer.WriteStringValue(requestObject.EnvironmentId);
            }

            if(requestObject.IsSetProjectId())
            {
                context.Writer.WritePropertyName("ProjectId");
                context.Writer.WriteStringValue(requestObject.ProjectId);
            }

            if(requestObject.IsSetProjectS3Path())
            {
                context.Writer.WritePropertyName("ProjectS3Path");
                context.Writer.WriteStringValue(requestObject.ProjectS3Path);
            }

            if(requestObject.IsSetSingleSignOnApplicationArn())
            {
                context.Writer.WritePropertyName("SingleSignOnApplicationArn");
                context.Writer.WriteStringValue(requestObject.SingleSignOnApplicationArn);
            }

            if(requestObject.IsSetStudioWebPortalAccess())
            {
                context.Writer.WritePropertyName("StudioWebPortalAccess");
                context.Writer.WriteStringValue(requestObject.StudioWebPortalAccess);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static UnifiedStudioSettingsMarshaller Instance = new UnifiedStudioSettingsMarshaller();

    }
}