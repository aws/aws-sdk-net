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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Kendra.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Kendra.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ConfluenceConfiguration Marshaller
    /// </summary>       
    public class ConfluenceConfigurationMarshaller : IRequestMarshaller<ConfluenceConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ConfluenceConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAttachmentConfiguration())
            {
                context.Writer.WritePropertyName("AttachmentConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = ConfluenceAttachmentConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.AttachmentConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetBlogConfiguration())
            {
                context.Writer.WritePropertyName("BlogConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = ConfluenceBlogConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.BlogConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetExclusionPatterns())
            {
                context.Writer.WritePropertyName("ExclusionPatterns");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectExclusionPatternsListValue in requestObject.ExclusionPatterns)
                {
                        context.Writer.Write(requestObjectExclusionPatternsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetInclusionPatterns())
            {
                context.Writer.WritePropertyName("InclusionPatterns");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectInclusionPatternsListValue in requestObject.InclusionPatterns)
                {
                        context.Writer.Write(requestObjectInclusionPatternsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetPageConfiguration())
            {
                context.Writer.WritePropertyName("PageConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = ConfluencePageConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.PageConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSecretArn())
            {
                context.Writer.WritePropertyName("SecretArn");
                context.Writer.Write(requestObject.SecretArn);
            }

            if(requestObject.IsSetServerUrl())
            {
                context.Writer.WritePropertyName("ServerUrl");
                context.Writer.Write(requestObject.ServerUrl);
            }

            if(requestObject.IsSetSpaceConfiguration())
            {
                context.Writer.WritePropertyName("SpaceConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = ConfluenceSpaceConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.SpaceConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetVersion())
            {
                context.Writer.WritePropertyName("Version");
                context.Writer.Write(requestObject.Version);
            }

            if(requestObject.IsSetVpcConfiguration())
            {
                context.Writer.WritePropertyName("VpcConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = DataSourceVpcConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.VpcConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static ConfluenceConfigurationMarshaller Instance = new ConfluenceConfigurationMarshaller();

    }
}