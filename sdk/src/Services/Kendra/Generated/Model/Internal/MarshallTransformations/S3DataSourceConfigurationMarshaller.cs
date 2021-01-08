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
    /// S3DataSourceConfiguration Marshaller
    /// </summary>       
    public class S3DataSourceConfigurationMarshaller : IRequestMarshaller<S3DataSourceConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(S3DataSourceConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAccessControlListConfiguration())
            {
                context.Writer.WritePropertyName("AccessControlListConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = AccessControlListConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.AccessControlListConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetBucketName())
            {
                context.Writer.WritePropertyName("BucketName");
                context.Writer.Write(requestObject.BucketName);
            }

            if(requestObject.IsSetDocumentsMetadataConfiguration())
            {
                context.Writer.WritePropertyName("DocumentsMetadataConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = DocumentsMetadataConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.DocumentsMetadataConfiguration, context);

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

            if(requestObject.IsSetInclusionPrefixes())
            {
                context.Writer.WritePropertyName("InclusionPrefixes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectInclusionPrefixesListValue in requestObject.InclusionPrefixes)
                {
                        context.Writer.Write(requestObjectInclusionPrefixesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static S3DataSourceConfigurationMarshaller Instance = new S3DataSourceConfigurationMarshaller();

    }
}