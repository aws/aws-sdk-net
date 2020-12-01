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
 * Do not modify this file. This file is generated from the ecr-public-2020-10-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ECRPublic.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ECRPublic.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RepositoryCatalogDataInput Marshaller
    /// </summary>       
    public class RepositoryCatalogDataInputMarshaller : IRequestMarshaller<RepositoryCatalogDataInput, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RepositoryCatalogDataInput requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAboutText())
            {
                context.Writer.WritePropertyName("aboutText");
                context.Writer.Write(requestObject.AboutText);
            }

            if(requestObject.IsSetArchitectures())
            {
                context.Writer.WritePropertyName("architectures");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectArchitecturesListValue in requestObject.Architectures)
                {
                        context.Writer.Write(requestObjectArchitecturesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.Write(requestObject.Description);
            }

            if(requestObject.IsSetLogoImageBlob())
            {
                context.Writer.WritePropertyName("logoImageBlob");
                context.Writer.Write(StringUtils.FromMemoryStream(requestObject.LogoImageBlob));
            }

            if(requestObject.IsSetOperatingSystems())
            {
                context.Writer.WritePropertyName("operatingSystems");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectOperatingSystemsListValue in requestObject.OperatingSystems)
                {
                        context.Writer.Write(requestObjectOperatingSystemsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetUsageText())
            {
                context.Writer.WritePropertyName("usageText");
                context.Writer.Write(requestObject.UsageText);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static RepositoryCatalogDataInputMarshaller Instance = new RepositoryCatalogDataInputMarshaller();

    }
}