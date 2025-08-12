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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatchLogs.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatchLogs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ParseKeyValue Marshaller
    /// </summary>
    public class ParseKeyValueMarshaller : IRequestMarshaller<ParseKeyValue, CborMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ParseKeyValue requestObject, CborMarshallerContext context)
        {
            if (requestObject == null)
                return;

            if (requestObject.IsSetDestination())
            {
                context.Writer.WriteTextString("destination");
                context.Writer.WriteTextString(requestObject.Destination);
            }
            if (requestObject.IsSetFieldDelimiter())
            {
                context.Writer.WriteTextString("fieldDelimiter");
                context.Writer.WriteTextString(requestObject.FieldDelimiter);
            }
            if (requestObject.IsSetKeyPrefix())
            {
                context.Writer.WriteTextString("keyPrefix");
                context.Writer.WriteTextString(requestObject.KeyPrefix);
            }
            if (requestObject.IsSetKeyValueDelimiter())
            {
                context.Writer.WriteTextString("keyValueDelimiter");
                context.Writer.WriteTextString(requestObject.KeyValueDelimiter);
            }
            if (requestObject.IsSetNonMatchValue())
            {
                context.Writer.WriteTextString("nonMatchValue");
                context.Writer.WriteTextString(requestObject.NonMatchValue);
            }
            if (requestObject.IsSetOverwriteIfExists())
            {
                context.Writer.WriteTextString("overwriteIfExists");
                context.Writer.WriteBoolean(requestObject.OverwriteIfExists.Value);
            }
            if (requestObject.IsSetSource())
            {
                context.Writer.WriteTextString("source");
                context.Writer.WriteTextString(requestObject.Source);
            }
        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ParseKeyValueMarshaller Instance = new ParseKeyValueMarshaller();

    }
}