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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Batch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Batch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ComputeResourceUpdate Marshaller
    /// </summary>       
    public class ComputeResourceUpdateMarshaller : IRequestMarshaller<ComputeResourceUpdate, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ComputeResourceUpdate requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDesiredvCpus())
            {
                context.Writer.WritePropertyName("desiredvCpus");
                context.Writer.Write(requestObject.DesiredvCpus);
            }

            if(requestObject.IsSetMaxvCpus())
            {
                context.Writer.WritePropertyName("maxvCpus");
                context.Writer.Write(requestObject.MaxvCpus);
            }

            if(requestObject.IsSetMinvCpus())
            {
                context.Writer.WritePropertyName("minvCpus");
                context.Writer.Write(requestObject.MinvCpus);
            }

            if(requestObject.IsSetSecurityGroupIds())
            {
                context.Writer.WritePropertyName("securityGroupIds");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSecurityGroupIdsListValue in requestObject.SecurityGroupIds)
                {
                        context.Writer.Write(requestObjectSecurityGroupIdsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSubnets())
            {
                context.Writer.WritePropertyName("subnets");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSubnetsListValue in requestObject.Subnets)
                {
                        context.Writer.Write(requestObjectSubnetsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static ComputeResourceUpdateMarshaller Instance = new ComputeResourceUpdateMarshaller();

    }
}