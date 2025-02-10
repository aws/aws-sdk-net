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
    /// AwsCloudFrontDistributionDetails Marshaller
    /// </summary>
    public class AwsCloudFrontDistributionDetailsMarshaller : IRequestMarshaller<AwsCloudFrontDistributionDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsCloudFrontDistributionDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCacheBehaviors())
            {
                context.Writer.WritePropertyName("CacheBehaviors");
                context.Writer.WriteStartObject();

                var marshaller = AwsCloudFrontDistributionCacheBehaviorsMarshaller.Instance;
                marshaller.Marshall(requestObject.CacheBehaviors, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDefaultCacheBehavior())
            {
                context.Writer.WritePropertyName("DefaultCacheBehavior");
                context.Writer.WriteStartObject();

                var marshaller = AwsCloudFrontDistributionDefaultCacheBehaviorMarshaller.Instance;
                marshaller.Marshall(requestObject.DefaultCacheBehavior, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDefaultRootObject())
            {
                context.Writer.WritePropertyName("DefaultRootObject");
                context.Writer.WriteStringValue(requestObject.DefaultRootObject);
            }

            if(requestObject.IsSetDomainName())
            {
                context.Writer.WritePropertyName("DomainName");
                context.Writer.WriteStringValue(requestObject.DomainName);
            }

            if(requestObject.IsSetETag())
            {
                context.Writer.WritePropertyName("ETag");
                context.Writer.WriteStringValue(requestObject.ETag);
            }

            if(requestObject.IsSetLastModifiedTime())
            {
                context.Writer.WritePropertyName("LastModifiedTime");
                context.Writer.WriteStringValue(requestObject.LastModifiedTime);
            }

            if(requestObject.IsSetLogging())
            {
                context.Writer.WritePropertyName("Logging");
                context.Writer.WriteStartObject();

                var marshaller = AwsCloudFrontDistributionLoggingMarshaller.Instance;
                marshaller.Marshall(requestObject.Logging, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetOriginGroups())
            {
                context.Writer.WritePropertyName("OriginGroups");
                context.Writer.WriteStartObject();

                var marshaller = AwsCloudFrontDistributionOriginGroupsMarshaller.Instance;
                marshaller.Marshall(requestObject.OriginGroups, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetOrigins())
            {
                context.Writer.WritePropertyName("Origins");
                context.Writer.WriteStartObject();

                var marshaller = AwsCloudFrontDistributionOriginsMarshaller.Instance;
                marshaller.Marshall(requestObject.Origins, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetStatus())
            {
                context.Writer.WritePropertyName("Status");
                context.Writer.WriteStringValue(requestObject.Status);
            }

            if(requestObject.IsSetViewerCertificate())
            {
                context.Writer.WritePropertyName("ViewerCertificate");
                context.Writer.WriteStartObject();

                var marshaller = AwsCloudFrontDistributionViewerCertificateMarshaller.Instance;
                marshaller.Marshall(requestObject.ViewerCertificate, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetWebAclId())
            {
                context.Writer.WritePropertyName("WebAclId");
                context.Writer.WriteStringValue(requestObject.WebAclId);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsCloudFrontDistributionDetailsMarshaller Instance = new AwsCloudFrontDistributionDetailsMarshaller();

    }
}