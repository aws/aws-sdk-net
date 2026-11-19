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
    /// StorageLensGroupOrOperator Marshaller
    /// </summary>
    public partial class StorageLensGroupOrOperatorMarshaller : IRequestMarshaller<StorageLensGroupOrOperator, XmlMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(StorageLensGroupOrOperator requestObject, XmlMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetMatchAnyPrefix())
            {
                var requestObjectMatchAnyPrefix = requestObject.MatchAnyPrefix;
                context.Writer.WriteStartElement("MatchAnyPrefix");
                foreach (var requestObjectMatchAnyPrefixValue in requestObjectMatchAnyPrefix)
                {
                    context.Writer.WriteStartElement("Prefix");
                    context.Writer.WriteValue(requestObjectMatchAnyPrefixValue);
                    context.Writer.WriteEndElement();
                }
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetMatchAnySuffix())
            {
                var requestObjectMatchAnySuffix = requestObject.MatchAnySuffix;
                context.Writer.WriteStartElement("MatchAnySuffix");
                foreach (var requestObjectMatchAnySuffixValue in requestObjectMatchAnySuffix)
                {
                    context.Writer.WriteStartElement("Suffix");
                    context.Writer.WriteValue(requestObjectMatchAnySuffixValue);
                    context.Writer.WriteEndElement();
                }
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetMatchAnyTag())
            {
                var requestObjectMatchAnyTag = requestObject.MatchAnyTag;
                context.Writer.WriteStartElement("MatchAnyTag");
                foreach (var requestObjectMatchAnyTagValue in requestObjectMatchAnyTag)
                {
                    if (requestObjectMatchAnyTagValue != null)
                    {
                        context.Writer.WriteStartElement("Tag");
                        S3TagMarshaller.Instance.Marshall(requestObjectMatchAnyTagValue, context);
                        context.Writer.WriteEndElement();
                    }
                }
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetMatchObjectAge())
            {
                context.Writer.WriteStartElement("MatchObjectAge");
                MatchObjectAgeMarshaller.Instance.Marshall(requestObject.MatchObjectAge, context);
                context.Writer.WriteEndElement();
            }
            if (requestObject.IsSetMatchObjectSize())
            {
                context.Writer.WriteStartElement("MatchObjectSize");
                MatchObjectSizeMarshaller.Instance.Marshall(requestObject.MatchObjectSize, context);
                context.Writer.WriteEndElement();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static StorageLensGroupOrOperatorMarshaller Instance = new StorageLensGroupOrOperatorMarshaller();
    }
}
