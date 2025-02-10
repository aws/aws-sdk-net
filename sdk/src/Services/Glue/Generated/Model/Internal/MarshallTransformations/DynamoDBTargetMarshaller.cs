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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DynamoDBTarget Marshaller
    /// </summary>
    public class DynamoDBTargetMarshaller : IRequestMarshaller<DynamoDBTarget, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DynamoDBTarget requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetPath())
            {
                context.Writer.WritePropertyName("Path");
                context.Writer.WriteStringValue(requestObject.Path);
            }

            if(requestObject.IsSetScanAll())
            {
                context.Writer.WritePropertyName("scanAll");
                context.Writer.WriteBooleanValue(requestObject.ScanAll.Value);
            }

            if(requestObject.IsSetScanRate())
            {
                context.Writer.WritePropertyName("scanRate");
                if(StringUtils.IsSpecialDoubleValue(requestObject.ScanRate.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.ScanRate.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.ScanRate.Value);
                }
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DynamoDBTargetMarshaller Instance = new DynamoDBTargetMarshaller();

    }
}