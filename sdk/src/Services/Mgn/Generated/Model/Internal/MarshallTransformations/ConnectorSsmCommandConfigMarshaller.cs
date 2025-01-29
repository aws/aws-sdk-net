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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Mgn.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Mgn.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ConnectorSsmCommandConfig Marshaller
    /// </summary>
    public class ConnectorSsmCommandConfigMarshaller : IRequestMarshaller<ConnectorSsmCommandConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ConnectorSsmCommandConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCloudWatchLogGroupName())
            {
                context.Writer.WritePropertyName("cloudWatchLogGroupName");
                context.Writer.WriteStringValue(requestObject.CloudWatchLogGroupName);
            }

            if(requestObject.IsSetCloudWatchOutputEnabled())
            {
                context.Writer.WritePropertyName("cloudWatchOutputEnabled");
                context.Writer.WriteBooleanValue(requestObject.CloudWatchOutputEnabled.Value);
            }

            if(requestObject.IsSetOutputS3BucketName())
            {
                context.Writer.WritePropertyName("outputS3BucketName");
                context.Writer.WriteStringValue(requestObject.OutputS3BucketName);
            }

            if(requestObject.IsSetS3OutputEnabled())
            {
                context.Writer.WritePropertyName("s3OutputEnabled");
                context.Writer.WriteBooleanValue(requestObject.S3OutputEnabled.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ConnectorSsmCommandConfigMarshaller Instance = new ConnectorSsmCommandConfigMarshaller();

    }
}