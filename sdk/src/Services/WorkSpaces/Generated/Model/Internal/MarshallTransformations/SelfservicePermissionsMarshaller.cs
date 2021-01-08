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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WorkSpaces.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.WorkSpaces.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SelfservicePermissions Marshaller
    /// </summary>       
    public class SelfservicePermissionsMarshaller : IRequestMarshaller<SelfservicePermissions, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SelfservicePermissions requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetChangeComputeType())
            {
                context.Writer.WritePropertyName("ChangeComputeType");
                context.Writer.Write(requestObject.ChangeComputeType);
            }

            if(requestObject.IsSetIncreaseVolumeSize())
            {
                context.Writer.WritePropertyName("IncreaseVolumeSize");
                context.Writer.Write(requestObject.IncreaseVolumeSize);
            }

            if(requestObject.IsSetRebuildWorkspace())
            {
                context.Writer.WritePropertyName("RebuildWorkspace");
                context.Writer.Write(requestObject.RebuildWorkspace);
            }

            if(requestObject.IsSetRestartWorkspace())
            {
                context.Writer.WritePropertyName("RestartWorkspace");
                context.Writer.Write(requestObject.RestartWorkspace);
            }

            if(requestObject.IsSetSwitchRunningMode())
            {
                context.Writer.WritePropertyName("SwitchRunningMode");
                context.Writer.Write(requestObject.SwitchRunningMode);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static SelfservicePermissionsMarshaller Instance = new SelfservicePermissionsMarshaller();

    }
}