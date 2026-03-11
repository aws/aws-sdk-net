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
 * Do not modify this file. This file is generated from the rpcv2protocol-2020-07-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.RpcV2Protocol.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.RpcV2Protocol.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RecursiveShapesInputOutputNested2 Marshaller
    /// </summary>
    public class RecursiveShapesInputOutputNested2Marshaller : IRequestMarshaller<RecursiveShapesInputOutputNested2, CborMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RecursiveShapesInputOutputNested2 requestObject, CborMarshallerContext context)
        {
            if (requestObject == null)
                return;

            if (requestObject.IsSetBar())
            {
                context.Writer.WriteTextString("bar");
                context.Writer.WriteTextString(requestObject.Bar);
            }
            if (requestObject.IsSetRecursiveMember())
            {
                context.Writer.WriteTextString("recursiveMember");
                context.Writer.WriteStartMap(null);

                var marshaller = RecursiveShapesInputOutputNested1Marshaller.Instance;
                marshaller.Marshall(requestObject.RecursiveMember, context);

                context.Writer.WriteEndMap();
            }
        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RecursiveShapesInputOutputNested2Marshaller Instance = new RecursiveShapesInputOutputNested2Marshaller();

    }
}