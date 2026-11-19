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

using Amazon.S3Control.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.S3Control.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// LifecycleRuleAndOperator Marshaller
    /// </summary>
    public partial class LifecycleRuleAndOperatorMarshaller : IRequestMarshaller<LifecycleRuleAndOperator, XmlMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(LifecycleRuleAndOperator requestObject, XmlMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetObjectSizeGreaterThan())
            {
                context.Writer.WriteElementString("ObjectSizeGreaterThan", StringUtils.FromLong(requestObject.ObjectSizeGreaterThan.Value));
            }
            if (requestObject.IsSetObjectSizeLessThan())
            {
                context.Writer.WriteElementString("ObjectSizeLessThan", StringUtils.FromLong(requestObject.ObjectSizeLessThan.Value));
            }
            if (requestObject.IsSetPrefix())
            {
                context.Writer.WriteElementString("Prefix", StringUtils.FromString(requestObject.Prefix));
            }
            if (requestObject.IsSetTags())
            {
                var requestObjectTags = requestObject.Tags;
                context.Writer.WriteStartElement("Tags");
                foreach (var requestObjectTagsValue in requestObjectTags)
                {
                    if (requestObjectTagsValue != null)
                    {
                        context.Writer.WriteStartElement("member");
                        S3TagMarshaller.Instance.Marshall(requestObjectTagsValue, context);
                        context.Writer.WriteEndElement();
                    }
                }
                context.Writer.WriteEndElement();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static LifecycleRuleAndOperatorMarshaller Instance = new LifecycleRuleAndOperatorMarshaller();
    }
}
