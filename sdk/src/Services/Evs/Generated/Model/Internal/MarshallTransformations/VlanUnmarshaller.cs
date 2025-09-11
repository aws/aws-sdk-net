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
 * Do not modify this file. This file is generated from the evs-2023-07-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Evs.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Evs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Vlan Object
    /// </summary>  
    public class VlanUnmarshaller : IUnmarshaller<Vlan, XmlUnmarshallerContext>, IUnmarshaller<Vlan, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Vlan IUnmarshaller<Vlan, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Vlan Unmarshall(JsonUnmarshallerContext context)
        {
            Vlan unmarshalledObject = new Vlan();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("availabilityZone", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AvailabilityZone = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("cidr", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Cidr = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("createdAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("eipAssociations", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<EipAssociation, EipAssociationUnmarshaller>(EipAssociationUnmarshaller.Instance);
                    unmarshalledObject.EipAssociations = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("functionName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FunctionName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("isPublic", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.IsPublic = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("modifiedAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.ModifiedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("networkAclId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.NetworkAclId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("stateDetails", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StateDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("subnetId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SubnetId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("vlanId", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.VlanId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("vlanState", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VlanState = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static VlanUnmarshaller _instance = new VlanUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static VlanUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}