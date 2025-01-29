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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RedshiftDatasetDefinition Marshaller
    /// </summary>
    public class RedshiftDatasetDefinitionMarshaller : IRequestMarshaller<RedshiftDatasetDefinition, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RedshiftDatasetDefinition requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetClusterId())
            {
                context.Writer.WritePropertyName("ClusterId");
                context.Writer.WriteStringValue(requestObject.ClusterId);
            }

            if(requestObject.IsSetClusterRoleArn())
            {
                context.Writer.WritePropertyName("ClusterRoleArn");
                context.Writer.WriteStringValue(requestObject.ClusterRoleArn);
            }

            if(requestObject.IsSetDatabase())
            {
                context.Writer.WritePropertyName("Database");
                context.Writer.WriteStringValue(requestObject.Database);
            }

            if(requestObject.IsSetDbUser())
            {
                context.Writer.WritePropertyName("DbUser");
                context.Writer.WriteStringValue(requestObject.DbUser);
            }

            if(requestObject.IsSetKmsKeyId())
            {
                context.Writer.WritePropertyName("KmsKeyId");
                context.Writer.WriteStringValue(requestObject.KmsKeyId);
            }

            if(requestObject.IsSetOutputCompression())
            {
                context.Writer.WritePropertyName("OutputCompression");
                context.Writer.WriteStringValue(requestObject.OutputCompression);
            }

            if(requestObject.IsSetOutputFormat())
            {
                context.Writer.WritePropertyName("OutputFormat");
                context.Writer.WriteStringValue(requestObject.OutputFormat);
            }

            if(requestObject.IsSetOutputS3Uri())
            {
                context.Writer.WritePropertyName("OutputS3Uri");
                context.Writer.WriteStringValue(requestObject.OutputS3Uri);
            }

            if(requestObject.IsSetQueryString())
            {
                context.Writer.WritePropertyName("QueryString");
                context.Writer.WriteStringValue(requestObject.QueryString);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RedshiftDatasetDefinitionMarshaller Instance = new RedshiftDatasetDefinitionMarshaller();

    }
}