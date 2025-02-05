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
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SoftwarePackage Marshaller
    /// </summary>
    public class SoftwarePackageMarshaller : IRequestMarshaller<SoftwarePackage, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SoftwarePackage requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetArchitecture())
            {
                context.Writer.WritePropertyName("Architecture");
                context.Writer.WriteStringValue(requestObject.Architecture);
            }

            if(requestObject.IsSetEpoch())
            {
                context.Writer.WritePropertyName("Epoch");
                context.Writer.WriteStringValue(requestObject.Epoch);
            }

            if(requestObject.IsSetFilePath())
            {
                context.Writer.WritePropertyName("FilePath");
                context.Writer.WriteStringValue(requestObject.FilePath);
            }

            if(requestObject.IsSetFixedInVersion())
            {
                context.Writer.WritePropertyName("FixedInVersion");
                context.Writer.WriteStringValue(requestObject.FixedInVersion);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetPackageManager())
            {
                context.Writer.WritePropertyName("PackageManager");
                context.Writer.WriteStringValue(requestObject.PackageManager);
            }

            if(requestObject.IsSetRelease())
            {
                context.Writer.WritePropertyName("Release");
                context.Writer.WriteStringValue(requestObject.Release);
            }

            if(requestObject.IsSetRemediation())
            {
                context.Writer.WritePropertyName("Remediation");
                context.Writer.WriteStringValue(requestObject.Remediation);
            }

            if(requestObject.IsSetSourceLayerArn())
            {
                context.Writer.WritePropertyName("SourceLayerArn");
                context.Writer.WriteStringValue(requestObject.SourceLayerArn);
            }

            if(requestObject.IsSetSourceLayerHash())
            {
                context.Writer.WritePropertyName("SourceLayerHash");
                context.Writer.WriteStringValue(requestObject.SourceLayerHash);
            }

            if(requestObject.IsSetVersion())
            {
                context.Writer.WritePropertyName("Version");
                context.Writer.WriteStringValue(requestObject.Version);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SoftwarePackageMarshaller Instance = new SoftwarePackageMarshaller();

    }
}