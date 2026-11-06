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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

using Amazon.CloudFront.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.CloudFront.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StreamingDistributionConfig Marshaller
    /// </summary>
    public partial class StreamingDistributionConfigMarshaller : IRequestMarshaller<StreamingDistributionConfig, XmlMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(StreamingDistributionConfig requestObject, XmlMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetAliases())
            {
                context.Writer.WriteStartElement("Aliases");
                AliasesMarshaller.Instance.Marshall(requestObject.Aliases, context);
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetCallerReference())
            {
                context.Writer.WriteElementString("CallerReference", StringUtils.FromString(requestObject.CallerReference));
            }
            if (requestObject.IsSetComment())
            {
                context.Writer.WriteElementString("Comment", StringUtils.FromString(requestObject.Comment));
            }
            if (requestObject.IsSetEnabled())
            {
                context.Writer.WriteElementString("Enabled", StringUtils.FromBool(requestObject.Enabled.Value));
            }
            if (requestObject.IsSetLogging())
            {
                context.Writer.WriteStartElement("Logging");
                StreamingLoggingConfigMarshaller.Instance.Marshall(requestObject.Logging, context);
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetPriceClass())
            {
                context.Writer.WriteElementString("PriceClass", StringUtils.FromString(requestObject.PriceClass));
            }
            if (requestObject.IsSetS3Origin())
            {
                context.Writer.WriteStartElement("S3Origin");
                S3OriginMarshaller.Instance.Marshall(requestObject.S3Origin, context);
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetTrustedSigners())
            {
                context.Writer.WriteStartElement("TrustedSigners");
                TrustedSignersMarshaller.Instance.Marshall(requestObject.TrustedSigners, context);
                context.Writer.WriteEndElement();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static StreamingDistributionConfigMarshaller Instance = new StreamingDistributionConfigMarshaller();
    }
}
