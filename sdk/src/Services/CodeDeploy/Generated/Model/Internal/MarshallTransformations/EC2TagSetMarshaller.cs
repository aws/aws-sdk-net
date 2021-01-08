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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeDeploy.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CodeDeploy.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EC2TagSet Marshaller
    /// </summary>       
    public class EC2TagSetMarshaller : IRequestMarshaller<EC2TagSet, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(EC2TagSet requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetEc2TagSetList())
            {
                context.Writer.WritePropertyName("ec2TagSetList");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectEc2TagSetListListValue in requestObject.Ec2TagSetList)
                {
                    context.Writer.WriteArrayStart();
                    foreach(var requestObjectEc2TagSetListListValueListValue in requestObjectEc2TagSetListListValue)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = EC2TagFilterMarshaller.Instance;
                        marshaller.Marshall(requestObjectEc2TagSetListListValueListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static EC2TagSetMarshaller Instance = new EC2TagSetMarshaller();

    }
}