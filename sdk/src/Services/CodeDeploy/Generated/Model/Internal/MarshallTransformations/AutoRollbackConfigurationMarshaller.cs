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
    /// AutoRollbackConfiguration Marshaller
    /// </summary>       
    public class AutoRollbackConfigurationMarshaller : IRequestMarshaller<AutoRollbackConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AutoRollbackConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetEnabled())
            {
                context.Writer.WritePropertyName("enabled");
                context.Writer.Write(requestObject.Enabled);
            }

            if(requestObject.IsSetEvents())
            {
                context.Writer.WritePropertyName("events");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectEventsListValue in requestObject.Events)
                {
                        context.Writer.Write(requestObjectEventsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static AutoRollbackConfigurationMarshaller Instance = new AutoRollbackConfigurationMarshaller();

    }
}