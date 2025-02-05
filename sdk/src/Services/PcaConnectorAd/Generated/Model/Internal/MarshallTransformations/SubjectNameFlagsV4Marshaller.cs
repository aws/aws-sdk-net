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
 * Do not modify this file. This file is generated from the pca-connector-ad-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.PcaConnectorAd.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.PcaConnectorAd.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SubjectNameFlagsV4 Marshaller
    /// </summary>
    public class SubjectNameFlagsV4Marshaller : IRequestMarshaller<SubjectNameFlagsV4, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SubjectNameFlagsV4 requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetRequireCommonName())
            {
                context.Writer.WritePropertyName("RequireCommonName");
                context.Writer.WriteBooleanValue(requestObject.RequireCommonName.Value);
            }

            if(requestObject.IsSetRequireDirectoryPath())
            {
                context.Writer.WritePropertyName("RequireDirectoryPath");
                context.Writer.WriteBooleanValue(requestObject.RequireDirectoryPath.Value);
            }

            if(requestObject.IsSetRequireDnsAsCn())
            {
                context.Writer.WritePropertyName("RequireDnsAsCn");
                context.Writer.WriteBooleanValue(requestObject.RequireDnsAsCn.Value);
            }

            if(requestObject.IsSetRequireEmail())
            {
                context.Writer.WritePropertyName("RequireEmail");
                context.Writer.WriteBooleanValue(requestObject.RequireEmail.Value);
            }

            if(requestObject.IsSetSanRequireDirectoryGuid())
            {
                context.Writer.WritePropertyName("SanRequireDirectoryGuid");
                context.Writer.WriteBooleanValue(requestObject.SanRequireDirectoryGuid.Value);
            }

            if(requestObject.IsSetSanRequireDns())
            {
                context.Writer.WritePropertyName("SanRequireDns");
                context.Writer.WriteBooleanValue(requestObject.SanRequireDns.Value);
            }

            if(requestObject.IsSetSanRequireDomainDns())
            {
                context.Writer.WritePropertyName("SanRequireDomainDns");
                context.Writer.WriteBooleanValue(requestObject.SanRequireDomainDns.Value);
            }

            if(requestObject.IsSetSanRequireEmail())
            {
                context.Writer.WritePropertyName("SanRequireEmail");
                context.Writer.WriteBooleanValue(requestObject.SanRequireEmail.Value);
            }

            if(requestObject.IsSetSanRequireSpn())
            {
                context.Writer.WritePropertyName("SanRequireSpn");
                context.Writer.WriteBooleanValue(requestObject.SanRequireSpn.Value);
            }

            if(requestObject.IsSetSanRequireUpn())
            {
                context.Writer.WritePropertyName("SanRequireUpn");
                context.Writer.WriteBooleanValue(requestObject.SanRequireUpn.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SubjectNameFlagsV4Marshaller Instance = new SubjectNameFlagsV4Marshaller();

    }
}