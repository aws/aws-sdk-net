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
    /// CidrCollectionChange Marshaller
    /// </summary>
    public partial class CidrCollectionChangeMarshaller : IRequestMarshaller<CidrCollectionChange, XmlMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(CidrCollectionChange requestObject, XmlMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetLocationName())
            {
                context.Writer.WriteElementString("LocationName", StringUtils.FromString(requestObject.LocationName));
            }
            if (requestObject.IsSetAction())
            {
                context.Writer.WriteElementString("Action", StringUtils.FromString(requestObject.Action));
            }
            if (requestObject.IsSetCidrList())
            {
                var requestObjectCidrList = requestObject.CidrList;
                context.Writer.WriteStartElement("CidrList");
                foreach (var requestObjectCidrListValue in requestObjectCidrList)
                {
                    context.Writer.WriteStartElement("Cidr");
                    context.Writer.WriteValue(requestObjectCidrListValue);
                    context.Writer.WriteEndElement();
                }
                context.Writer.WriteEndElement();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static CidrCollectionChangeMarshaller Instance = new CidrCollectionChangeMarshaller();
    }
}
