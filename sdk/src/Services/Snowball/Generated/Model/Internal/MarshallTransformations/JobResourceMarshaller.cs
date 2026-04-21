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
 * Do not modify this file. This file is generated from the snowball-2016-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Snowball.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.Snowball.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// JobResource Marshaller
    /// </summary>
    public class JobResourceMarshaller : IRequestMarshaller<JobResource, CborMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(JobResource requestObject, CborMarshallerContext context)
        {
            if (requestObject == null)
                return;

            if (requestObject.IsSetEc2AmiResources())
            {
                context.Writer.WriteTextString("Ec2AmiResources");
                context.Writer.WriteStartArray(requestObject.Ec2AmiResources.Count);
                foreach(var requestObjectEc2AmiResourcesListValue in requestObject.Ec2AmiResources)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = Ec2AmiResourceMarshaller.Instance;
                    marshaller.Marshall(requestObjectEc2AmiResourcesListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetLambdaResources())
            {
                context.Writer.WriteTextString("LambdaResources");
                context.Writer.WriteStartArray(requestObject.LambdaResources.Count);
                foreach(var requestObjectLambdaResourcesListValue in requestObject.LambdaResources)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = LambdaResourceMarshaller.Instance;
                    marshaller.Marshall(requestObjectLambdaResourcesListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetS3Resources())
            {
                context.Writer.WriteTextString("S3Resources");
                context.Writer.WriteStartArray(requestObject.S3Resources.Count);
                foreach(var requestObjectS3ResourcesListValue in requestObject.S3Resources)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = S3ResourceMarshaller.Instance;
                    marshaller.Marshall(requestObjectS3ResourcesListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }
        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static JobResourceMarshaller Instance = new JobResourceMarshaller();

    }
}