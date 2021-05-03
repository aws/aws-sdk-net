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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AwsEc2NetworkAclDetails Object
    /// </summary>  
    public class AwsEc2NetworkAclDetailsUnmarshaller : IUnmarshaller<AwsEc2NetworkAclDetails, XmlUnmarshallerContext>, IUnmarshaller<AwsEc2NetworkAclDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AwsEc2NetworkAclDetails IUnmarshaller<AwsEc2NetworkAclDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AwsEc2NetworkAclDetails Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AwsEc2NetworkAclDetails unmarshalledObject = new AwsEc2NetworkAclDetails();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Associations", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AwsEc2NetworkAclAssociation, AwsEc2NetworkAclAssociationUnmarshaller>(AwsEc2NetworkAclAssociationUnmarshaller.Instance);
                    unmarshalledObject.Associations = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Entries", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AwsEc2NetworkAclEntry, AwsEc2NetworkAclEntryUnmarshaller>(AwsEc2NetworkAclEntryUnmarshaller.Instance);
                    unmarshalledObject.Entries = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IsDefault", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.IsDefault = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NetworkAclId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.NetworkAclId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OwnerId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OwnerId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VpcId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VpcId = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AwsEc2NetworkAclDetailsUnmarshaller _instance = new AwsEc2NetworkAclDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AwsEc2NetworkAclDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}