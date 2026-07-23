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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppStream.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.AppStream.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ApplicationConfig Marshaller
    /// </summary>
    public class ApplicationConfigMarshaller : IRequestMarshaller<ApplicationConfig, CborMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ApplicationConfig requestObject, CborMarshallerContext context)
        {
            if (requestObject == null)
                return;

            if (requestObject.IsSetAbsoluteAppPath())
            {
                context.Writer.WriteTextString("AbsoluteAppPath");
                context.Writer.WriteTextString(requestObject.AbsoluteAppPath);
            }
            if (requestObject.IsSetAbsoluteIconPath())
            {
                context.Writer.WriteTextString("AbsoluteIconPath");
                context.Writer.WriteTextString(requestObject.AbsoluteIconPath);
            }
            if (requestObject.IsSetAbsoluteManifestPath())
            {
                context.Writer.WriteTextString("AbsoluteManifestPath");
                context.Writer.WriteTextString(requestObject.AbsoluteManifestPath);
            }
            if (requestObject.IsSetDisplayName())
            {
                context.Writer.WriteTextString("DisplayName");
                context.Writer.WriteTextString(requestObject.DisplayName);
            }
            if (requestObject.IsSetLaunchParameters())
            {
                context.Writer.WriteTextString("LaunchParameters");
                context.Writer.WriteTextString(requestObject.LaunchParameters);
            }
            if (requestObject.IsSetName())
            {
                context.Writer.WriteTextString("Name");
                context.Writer.WriteTextString(requestObject.Name);
            }
            if (requestObject.IsSetWorkingDirectory())
            {
                context.Writer.WriteTextString("WorkingDirectory");
                context.Writer.WriteTextString(requestObject.WorkingDirectory);
            }
        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ApplicationConfigMarshaller Instance = new ApplicationConfigMarshaller();

    }
}