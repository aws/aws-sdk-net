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
 * Do not modify this file. This file is generated from the finspace-2021-03-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Finspace.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Finspace.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ChangeRequest Marshaller
    /// </summary>
    public class ChangeRequestMarshaller : IRequestMarshaller<ChangeRequest, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ChangeRequest requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetChangeType())
            {
                context.Writer.WritePropertyName("changeType");
                context.Writer.WriteStringValue(requestObject.ChangeType);
            }

            if(requestObject.IsSetDbPath())
            {
                context.Writer.WritePropertyName("dbPath");
                context.Writer.WriteStringValue(requestObject.DbPath);
            }

            if(requestObject.IsSetS3Path())
            {
                context.Writer.WritePropertyName("s3Path");
                context.Writer.WriteStringValue(requestObject.S3Path);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ChangeRequestMarshaller Instance = new ChangeRequestMarshaller();

    }
}