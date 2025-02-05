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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsRedshiftClusterClusterParameterGroup Marshaller
    /// </summary>
    public class AwsRedshiftClusterClusterParameterGroupMarshaller : IRequestMarshaller<AwsRedshiftClusterClusterParameterGroup, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsRedshiftClusterClusterParameterGroup requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetClusterParameterStatusList())
            {
                context.Writer.WritePropertyName("ClusterParameterStatusList");
                context.Writer.WriteStartArray();
                foreach(var requestObjectClusterParameterStatusListListValue in requestObject.ClusterParameterStatusList)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsRedshiftClusterClusterParameterStatusMarshaller.Instance;
                    marshaller.Marshall(requestObjectClusterParameterStatusListListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetParameterApplyStatus())
            {
                context.Writer.WritePropertyName("ParameterApplyStatus");
                context.Writer.WriteStringValue(requestObject.ParameterApplyStatus);
            }

            if(requestObject.IsSetParameterGroupName())
            {
                context.Writer.WritePropertyName("ParameterGroupName");
                context.Writer.WriteStringValue(requestObject.ParameterGroupName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsRedshiftClusterClusterParameterGroupMarshaller Instance = new AwsRedshiftClusterClusterParameterGroupMarshaller();

    }
}