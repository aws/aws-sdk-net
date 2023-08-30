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
using ThirdParty.Json.LitJson;

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
            if(requestObject.IsSetRequireCommonName())
            {
                context.Writer.WritePropertyName("RequireCommonName");
                context.Writer.Write(requestObject.RequireCommonName);
            }

            if(requestObject.IsSetRequireDirectoryPath())
            {
                context.Writer.WritePropertyName("RequireDirectoryPath");
                context.Writer.Write(requestObject.RequireDirectoryPath);
            }

            if(requestObject.IsSetRequireDnsAsCn())
            {
                context.Writer.WritePropertyName("RequireDnsAsCn");
                context.Writer.Write(requestObject.RequireDnsAsCn);
            }

            if(requestObject.IsSetRequireEmail())
            {
                context.Writer.WritePropertyName("RequireEmail");
                context.Writer.Write(requestObject.RequireEmail);
            }

            if(requestObject.IsSetSanRequireDirectoryGuid())
            {
                context.Writer.WritePropertyName("SanRequireDirectoryGuid");
                context.Writer.Write(requestObject.SanRequireDirectoryGuid);
            }

            if(requestObject.IsSetSanRequireDns())
            {
                context.Writer.WritePropertyName("SanRequireDns");
                context.Writer.Write(requestObject.SanRequireDns);
            }

            if(requestObject.IsSetSanRequireDomainDns())
            {
                context.Writer.WritePropertyName("SanRequireDomainDns");
                context.Writer.Write(requestObject.SanRequireDomainDns);
            }

            if(requestObject.IsSetSanRequireEmail())
            {
                context.Writer.WritePropertyName("SanRequireEmail");
                context.Writer.Write(requestObject.SanRequireEmail);
            }

            if(requestObject.IsSetSanRequireSpn())
            {
                context.Writer.WritePropertyName("SanRequireSpn");
                context.Writer.Write(requestObject.SanRequireSpn);
            }

            if(requestObject.IsSetSanRequireUpn())
            {
                context.Writer.WritePropertyName("SanRequireUpn");
                context.Writer.Write(requestObject.SanRequireUpn);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SubjectNameFlagsV4Marshaller Instance = new SubjectNameFlagsV4Marshaller();

    }
}