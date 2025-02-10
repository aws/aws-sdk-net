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
 * Do not modify this file. This file is generated from the mailmanager-2023-10-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MailManager.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.MailManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeliverToQBusinessAction Marshaller
    /// </summary>
    public class DeliverToQBusinessActionMarshaller : IRequestMarshaller<DeliverToQBusinessAction, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DeliverToQBusinessAction requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetActionFailurePolicy())
            {
                context.Writer.WritePropertyName("ActionFailurePolicy");
                context.Writer.WriteStringValue(requestObject.ActionFailurePolicy);
            }

            if(requestObject.IsSetApplicationId())
            {
                context.Writer.WritePropertyName("ApplicationId");
                context.Writer.WriteStringValue(requestObject.ApplicationId);
            }

            if(requestObject.IsSetIndexId())
            {
                context.Writer.WritePropertyName("IndexId");
                context.Writer.WriteStringValue(requestObject.IndexId);
            }

            if(requestObject.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("RoleArn");
                context.Writer.WriteStringValue(requestObject.RoleArn);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DeliverToQBusinessActionMarshaller Instance = new DeliverToQBusinessActionMarshaller();

    }
}