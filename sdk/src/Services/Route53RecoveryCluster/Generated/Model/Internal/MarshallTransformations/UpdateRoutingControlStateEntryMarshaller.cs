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
 * Do not modify this file. This file is generated from the route53-recovery-cluster-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Route53RecoveryCluster.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Route53RecoveryCluster.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateRoutingControlStateEntry Marshaller
    /// </summary>
    public class UpdateRoutingControlStateEntryMarshaller : IRequestMarshaller<UpdateRoutingControlStateEntry, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(UpdateRoutingControlStateEntry requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetRoutingControlArn())
            {
                context.Writer.WritePropertyName("RoutingControlArn");
                context.Writer.WriteStringValue(requestObject.RoutingControlArn);
            }

            if(requestObject.IsSetRoutingControlState())
            {
                context.Writer.WritePropertyName("RoutingControlState");
                context.Writer.WriteStringValue(requestObject.RoutingControlState);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static UpdateRoutingControlStateEntryMarshaller Instance = new UpdateRoutingControlStateEntryMarshaller();

    }
}