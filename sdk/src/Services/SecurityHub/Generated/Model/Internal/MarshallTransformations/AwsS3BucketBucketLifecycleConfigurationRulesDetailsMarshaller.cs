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
    /// AwsS3BucketBucketLifecycleConfigurationRulesDetails Marshaller
    /// </summary>       
    public class AwsS3BucketBucketLifecycleConfigurationRulesDetailsMarshaller : IRequestMarshaller<AwsS3BucketBucketLifecycleConfigurationRulesDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsS3BucketBucketLifecycleConfigurationRulesDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAbortIncompleteMultipartUpload())
            {
                context.Writer.WritePropertyName("AbortIncompleteMultipartUpload");
                context.Writer.WriteObjectStart();

                var marshaller = AwsS3BucketBucketLifecycleConfigurationRulesAbortIncompleteMultipartUploadDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AbortIncompleteMultipartUpload, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetExpirationDate())
            {
                context.Writer.WritePropertyName("ExpirationDate");
                context.Writer.Write(requestObject.ExpirationDate);
            }

            if(requestObject.IsSetExpirationInDays())
            {
                context.Writer.WritePropertyName("ExpirationInDays");
                context.Writer.Write(requestObject.ExpirationInDays);
            }

            if(requestObject.IsSetExpiredObjectDeleteMarker())
            {
                context.Writer.WritePropertyName("ExpiredObjectDeleteMarker");
                context.Writer.Write(requestObject.ExpiredObjectDeleteMarker);
            }

            if(requestObject.IsSetFilter())
            {
                context.Writer.WritePropertyName("Filter");
                context.Writer.WriteObjectStart();

                var marshaller = AwsS3BucketBucketLifecycleConfigurationRulesFilterDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.Filter, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetID())
            {
                context.Writer.WritePropertyName("ID");
                context.Writer.Write(requestObject.ID);
            }

            if(requestObject.IsSetNoncurrentVersionExpirationInDays())
            {
                context.Writer.WritePropertyName("NoncurrentVersionExpirationInDays");
                context.Writer.Write(requestObject.NoncurrentVersionExpirationInDays);
            }

            if(requestObject.IsSetNoncurrentVersionTransitions())
            {
                context.Writer.WritePropertyName("NoncurrentVersionTransitions");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectNoncurrentVersionTransitionsListValue in requestObject.NoncurrentVersionTransitions)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsS3BucketBucketLifecycleConfigurationRulesNoncurrentVersionTransitionsDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectNoncurrentVersionTransitionsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetPrefix())
            {
                context.Writer.WritePropertyName("Prefix");
                context.Writer.Write(requestObject.Prefix);
            }

            if(requestObject.IsSetStatus())
            {
                context.Writer.WritePropertyName("Status");
                context.Writer.Write(requestObject.Status);
            }

            if(requestObject.IsSetTransitions())
            {
                context.Writer.WritePropertyName("Transitions");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectTransitionsListValue in requestObject.Transitions)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsS3BucketBucketLifecycleConfigurationRulesTransitionsDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectTransitionsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static AwsS3BucketBucketLifecycleConfigurationRulesDetailsMarshaller Instance = new AwsS3BucketBucketLifecycleConfigurationRulesDetailsMarshaller();

    }
}