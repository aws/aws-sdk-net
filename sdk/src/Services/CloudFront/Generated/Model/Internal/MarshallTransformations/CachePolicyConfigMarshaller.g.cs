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
    /// CachePolicyConfig Marshaller
    /// </summary>
    public partial class CachePolicyConfigMarshaller : IRequestMarshaller<CachePolicyConfig, XmlMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(CachePolicyConfig requestObject, XmlMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetComment())
            {
                context.Writer.WriteElementString("Comment", StringUtils.FromString(requestObject.Comment));
            }
            if (requestObject.IsSetDefaultTTL())
            {
                context.Writer.WriteElementString("DefaultTTL", StringUtils.FromLong(requestObject.DefaultTTL.Value));
            }
            if (requestObject.IsSetMaxTTL())
            {
                context.Writer.WriteElementString("MaxTTL", StringUtils.FromLong(requestObject.MaxTTL.Value));
            }
            if (requestObject.IsSetMinTTL())
            {
                context.Writer.WriteElementString("MinTTL", StringUtils.FromLong(requestObject.MinTTL.Value));
            }
            if (requestObject.IsSetName())
            {
                context.Writer.WriteElementString("Name", StringUtils.FromString(requestObject.Name));
            }
            if (requestObject.IsSetParametersInCacheKeyAndForwardedToOrigin())
            {
                context.Writer.WriteStartElement("ParametersInCacheKeyAndForwardedToOrigin");
                ParametersInCacheKeyAndForwardedToOriginMarshaller.Instance.Marshall(requestObject.ParametersInCacheKeyAndForwardedToOrigin, context);
                context.Writer.WriteEndElement();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static CachePolicyConfigMarshaller Instance = new CachePolicyConfigMarshaller();
    }
}
