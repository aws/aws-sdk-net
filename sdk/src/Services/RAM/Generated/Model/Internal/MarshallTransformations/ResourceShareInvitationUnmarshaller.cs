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
 * Do not modify this file. This file is generated from the ram-2018-01-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.RAM.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.RAM.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ResourceShareInvitation Object
    /// </summary>  
    public class ResourceShareInvitationUnmarshaller : IUnmarshaller<ResourceShareInvitation, XmlUnmarshallerContext>, IUnmarshaller<ResourceShareInvitation, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ResourceShareInvitation IUnmarshaller<ResourceShareInvitation, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ResourceShareInvitation Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ResourceShareInvitation unmarshalledObject = new ResourceShareInvitation();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("invitationTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.InvitationTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("receiverAccountId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReceiverAccountId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("resourceShareArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ResourceShareArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("resourceShareAssociations", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ResourceShareAssociation, ResourceShareAssociationUnmarshaller>(ResourceShareAssociationUnmarshaller.Instance);
                    unmarshalledObject.ResourceShareAssociations = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("resourceShareInvitationArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ResourceShareInvitationArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("resourceShareName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ResourceShareName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("senderAccountId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SenderAccountId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ResourceShareInvitationUnmarshaller _instance = new ResourceShareInvitationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ResourceShareInvitationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}