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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.FSx.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.FSx.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for S3AccessPointAttachment Object
    /// </summary>  
    public class S3AccessPointAttachmentUnmarshaller : IUnmarshaller<S3AccessPointAttachment, XmlUnmarshallerContext>, IUnmarshaller<S3AccessPointAttachment, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        S3AccessPointAttachment IUnmarshaller<S3AccessPointAttachment, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public S3AccessPointAttachment Unmarshall(JsonUnmarshallerContext context)
        {
            S3AccessPointAttachment unmarshalledObject = new S3AccessPointAttachment();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CreationTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreationTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Lifecycle", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Lifecycle = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LifecycleTransitionReason", targetDepth))
                {
                    var unmarshaller = LifecycleTransitionReasonUnmarshaller.Instance;
                    unmarshalledObject.LifecycleTransitionReason = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OntapConfiguration", targetDepth))
                {
                    var unmarshaller = S3AccessPointOntapConfigurationUnmarshaller.Instance;
                    unmarshalledObject.OntapConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OpenZFSConfiguration", targetDepth))
                {
                    var unmarshaller = S3AccessPointOpenZFSConfigurationUnmarshaller.Instance;
                    unmarshalledObject.OpenZFSConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("S3AccessPoint", targetDepth))
                {
                    var unmarshaller = S3AccessPointUnmarshaller.Instance;
                    unmarshalledObject.S3AccessPoint = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Type", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Type = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static S3AccessPointAttachmentUnmarshaller _instance = new S3AccessPointAttachmentUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static S3AccessPointAttachmentUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}