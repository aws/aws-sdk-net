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
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.OpsWorks.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.OpsWorks.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeploymentCommand Marshaller
    /// </summary>       
    public class DeploymentCommandMarshaller : IRequestMarshaller<DeploymentCommand, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DeploymentCommand requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetArgs())
            {
                context.Writer.WritePropertyName("Args");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectArgsKvp in requestObject.Args)
                {
                    context.Writer.WritePropertyName(requestObjectArgsKvp.Key);
                    var requestObjectArgsValue = requestObjectArgsKvp.Value;

                    context.Writer.WriteArrayStart();
                    foreach(var requestObjectArgsValueListValue in requestObjectArgsValue)
                    {
                            context.Writer.Write(requestObjectArgsValueListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.Write(requestObject.Name);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static DeploymentCommandMarshaller Instance = new DeploymentCommandMarshaller();

    }
}