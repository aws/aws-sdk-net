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
 * Do not modify this file. This file is generated from the vpc-lattice-2022-11-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.VPCLattice.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.VPCLattice.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// HeaderMatchType Marshaller
    /// </summary>
    public class HeaderMatchTypeMarshaller : IRequestMarshaller<HeaderMatchType, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(HeaderMatchType requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetContains())
            {
                context.Writer.WritePropertyName("contains");
                context.Writer.Write(requestObject.Contains);
            }

            if(requestObject.IsSetExact())
            {
                context.Writer.WritePropertyName("exact");
                context.Writer.Write(requestObject.Exact);
            }

            if(requestObject.IsSetPrefix())
            {
                context.Writer.WritePropertyName("prefix");
                context.Writer.Write(requestObject.Prefix);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static HeaderMatchTypeMarshaller Instance = new HeaderMatchTypeMarshaller();

    }
}