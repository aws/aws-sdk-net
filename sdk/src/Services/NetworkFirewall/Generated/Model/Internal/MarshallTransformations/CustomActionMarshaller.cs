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
 * Do not modify this file. This file is generated from the network-firewall-2020-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.NetworkFirewall.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.NetworkFirewall.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CustomAction Marshaller
    /// </summary>       
    public class CustomActionMarshaller : IRequestMarshaller<CustomAction, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CustomAction requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetActionDefinition())
            {
                context.Writer.WritePropertyName("ActionDefinition");
                context.Writer.WriteObjectStart();

                var marshaller = ActionDefinitionMarshaller.Instance;
                marshaller.Marshall(requestObject.ActionDefinition, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetActionName())
            {
                context.Writer.WritePropertyName("ActionName");
                context.Writer.Write(requestObject.ActionName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static CustomActionMarshaller Instance = new CustomActionMarshaller();

    }
}