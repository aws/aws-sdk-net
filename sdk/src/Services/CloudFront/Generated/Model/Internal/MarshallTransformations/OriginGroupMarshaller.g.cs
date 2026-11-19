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
    /// OriginGroup Marshaller
    /// </summary>
    public partial class OriginGroupMarshaller : IRequestMarshaller<OriginGroup, XmlMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(OriginGroup requestObject, XmlMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetFailoverCriteria())
            {
                context.Writer.WriteStartElement("FailoverCriteria");
                OriginGroupFailoverCriteriaMarshaller.Instance.Marshall(requestObject.FailoverCriteria, context);
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetId())
            {
                context.Writer.WriteElementString("Id", StringUtils.FromString(requestObject.Id));
            }
            if (requestObject.IsSetMembers())
            {
                context.Writer.WriteStartElement("Members");
                OriginGroupMembersMarshaller.Instance.Marshall(requestObject.Members, context);
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetSelectionCriteria())
            {
                context.Writer.WriteElementString("SelectionCriteria", StringUtils.FromString(requestObject.SelectionCriteria));
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static OriginGroupMarshaller Instance = new OriginGroupMarshaller();
    }
}
