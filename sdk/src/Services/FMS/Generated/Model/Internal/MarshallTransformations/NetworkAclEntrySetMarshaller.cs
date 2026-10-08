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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.FMS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.FMS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// NetworkAclEntrySet Marshaller
    /// </summary>
    public class NetworkAclEntrySetMarshaller : IRequestMarshaller<NetworkAclEntrySet, CborMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(NetworkAclEntrySet requestObject, CborMarshallerContext context)
        {
            if (requestObject == null)
                return;

            if (requestObject.IsSetFirstEntries())
            {
                context.Writer.WriteTextString("FirstEntries");
                context.Writer.WriteStartArray(requestObject.FirstEntries.Count);
                foreach(var requestObjectFirstEntriesListValue in requestObject.FirstEntries)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = NetworkAclEntryMarshaller.Instance;
                    marshaller.Marshall(requestObjectFirstEntriesListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetForceRemediateForFirstEntries())
            {
                context.Writer.WriteTextString("ForceRemediateForFirstEntries");
                context.Writer.WriteBoolean(requestObject.ForceRemediateForFirstEntries.Value);
            }
            if (requestObject.IsSetForceRemediateForLastEntries())
            {
                context.Writer.WriteTextString("ForceRemediateForLastEntries");
                context.Writer.WriteBoolean(requestObject.ForceRemediateForLastEntries.Value);
            }
            if (requestObject.IsSetLastEntries())
            {
                context.Writer.WriteTextString("LastEntries");
                context.Writer.WriteStartArray(requestObject.LastEntries.Count);
                foreach(var requestObjectLastEntriesListValue in requestObject.LastEntries)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = NetworkAclEntryMarshaller.Instance;
                    marshaller.Marshall(requestObjectLastEntriesListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }
        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static NetworkAclEntrySetMarshaller Instance = new NetworkAclEntrySetMarshaller();

    }
}