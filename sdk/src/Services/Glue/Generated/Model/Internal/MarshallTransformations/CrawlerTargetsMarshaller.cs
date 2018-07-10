/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using ThirdParty.Json.LitJson;

namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CrawlerTargets Marshaller
    /// </summary>       
    public class CrawlerTargetsMarshaller : IRequestMarshaller<CrawlerTargets, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CrawlerTargets requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDynamoDBTargets())
            {
                context.Writer.WritePropertyName("DynamoDBTargets");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectDynamoDBTargetsListValue in requestObject.DynamoDBTargets)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = DynamoDBTargetMarshaller.Instance;
                    marshaller.Marshall(requestObjectDynamoDBTargetsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetJdbcTargets())
            {
                context.Writer.WritePropertyName("JdbcTargets");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectJdbcTargetsListValue in requestObject.JdbcTargets)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = JdbcTargetMarshaller.Instance;
                    marshaller.Marshall(requestObjectJdbcTargetsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetS3Targets())
            {
                context.Writer.WritePropertyName("S3Targets");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectS3TargetsListValue in requestObject.S3Targets)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = S3TargetMarshaller.Instance;
                    marshaller.Marshall(requestObjectS3TargetsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static CrawlerTargetsMarshaller Instance = new CrawlerTargetsMarshaller();

    }
}