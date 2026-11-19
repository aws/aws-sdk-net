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

using Amazon.Route53.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.Route53.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CidrRoutingConfig Marshaller
    /// </summary>
    public partial class CidrRoutingConfigMarshaller : IRequestMarshaller<CidrRoutingConfig, XmlMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(CidrRoutingConfig requestObject, XmlMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetCollectionId())
            {
                context.Writer.WriteElementString("CollectionId", StringUtils.FromString(requestObject.CollectionId));
            }
            if (requestObject.IsSetLocationName())
            {
                context.Writer.WriteElementString("LocationName", StringUtils.FromString(requestObject.LocationName));
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static CidrRoutingConfigMarshaller Instance = new CidrRoutingConfigMarshaller();
    }
}
