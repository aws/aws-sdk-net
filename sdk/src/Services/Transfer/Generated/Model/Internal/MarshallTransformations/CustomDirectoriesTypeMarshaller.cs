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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Transfer.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Transfer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CustomDirectoriesType Marshaller
    /// </summary>
    public class CustomDirectoriesTypeMarshaller : IRequestMarshaller<CustomDirectoriesType, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CustomDirectoriesType requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetFailedFilesDirectory())
            {
                context.Writer.WritePropertyName("FailedFilesDirectory");
                context.Writer.WriteStringValue(requestObject.FailedFilesDirectory);
            }

            if(requestObject.IsSetMdnFilesDirectory())
            {
                context.Writer.WritePropertyName("MdnFilesDirectory");
                context.Writer.WriteStringValue(requestObject.MdnFilesDirectory);
            }

            if(requestObject.IsSetPayloadFilesDirectory())
            {
                context.Writer.WritePropertyName("PayloadFilesDirectory");
                context.Writer.WriteStringValue(requestObject.PayloadFilesDirectory);
            }

            if(requestObject.IsSetStatusFilesDirectory())
            {
                context.Writer.WritePropertyName("StatusFilesDirectory");
                context.Writer.WriteStringValue(requestObject.StatusFilesDirectory);
            }

            if(requestObject.IsSetTemporaryFilesDirectory())
            {
                context.Writer.WritePropertyName("TemporaryFilesDirectory");
                context.Writer.WriteStringValue(requestObject.TemporaryFilesDirectory);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CustomDirectoriesTypeMarshaller Instance = new CustomDirectoriesTypeMarshaller();

    }
}