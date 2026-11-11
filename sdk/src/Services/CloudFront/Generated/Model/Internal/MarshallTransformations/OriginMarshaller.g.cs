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
    /// Origin Marshaller
    /// </summary>
    public partial class OriginMarshaller : IRequestMarshaller<Origin, XmlMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(Origin requestObject, XmlMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetConnectionAttempts())
            {
                context.Writer.WriteElementString("ConnectionAttempts", StringUtils.FromInt(requestObject.ConnectionAttempts.Value));
            }
            if (requestObject.IsSetConnectionTimeout())
            {
                context.Writer.WriteElementString("ConnectionTimeout", StringUtils.FromInt(requestObject.ConnectionTimeout.Value));
            }
            if (requestObject.IsSetCustomHeaders())
            {
                context.Writer.WriteStartElement("CustomHeaders");
                CustomHeadersMarshaller.Instance.Marshall(requestObject.CustomHeaders, context);
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetCustomOriginConfig())
            {
                context.Writer.WriteStartElement("CustomOriginConfig");
                CustomOriginConfigMarshaller.Instance.Marshall(requestObject.CustomOriginConfig, context);
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetDomainName())
            {
                context.Writer.WriteElementString("DomainName", StringUtils.FromString(requestObject.DomainName));
            }
            if (requestObject.IsSetId())
            {
                context.Writer.WriteElementString("Id", StringUtils.FromString(requestObject.Id));
            }
            if (requestObject.IsSetOriginAccessControlId())
            {
                context.Writer.WriteElementString("OriginAccessControlId", StringUtils.FromString(requestObject.OriginAccessControlId));
            }
            if (requestObject.IsSetOriginPath())
            {
                context.Writer.WriteElementString("OriginPath", StringUtils.FromString(requestObject.OriginPath));
            }
            if (requestObject.IsSetOriginShield())
            {
                context.Writer.WriteStartElement("OriginShield");
                OriginShieldMarshaller.Instance.Marshall(requestObject.OriginShield, context);
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetResponseCompletionTimeout())
            {
                context.Writer.WriteElementString("ResponseCompletionTimeout", StringUtils.FromInt(requestObject.ResponseCompletionTimeout.Value));
            }
            if (requestObject.IsSetS3OriginConfig())
            {
                context.Writer.WriteStartElement("S3OriginConfig");
                S3OriginConfigMarshaller.Instance.Marshall(requestObject.S3OriginConfig, context);
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetVpcOriginConfig())
            {
                context.Writer.WriteStartElement("VpcOriginConfig");
                VpcOriginConfigMarshaller.Instance.Marshall(requestObject.VpcOriginConfig, context);
                context.Writer.WriteEndElement();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static OriginMarshaller Instance = new OriginMarshaller();
    }
}
