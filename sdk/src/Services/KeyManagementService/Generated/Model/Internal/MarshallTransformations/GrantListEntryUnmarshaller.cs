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
 * Do not modify this file. This file is generated from the kms-2014-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.KeyManagementService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.KeyManagementService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GrantListEntry Object
    /// </summary>  
    public class GrantListEntryUnmarshaller : IUnmarshaller<GrantListEntry, XmlUnmarshallerContext>, IUnmarshaller<GrantListEntry, JsonUnmarshallerContext>
    {
        GrantListEntry IUnmarshaller<GrantListEntry, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        public GrantListEntry Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            GrantListEntry unmarshalledObject = new GrantListEntry();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Constraints", targetDepth))
                {
                    var unmarshaller = GrantConstraintsUnmarshaller.Instance;
                    unmarshalledObject.Constraints = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GranteePrincipal", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.GranteePrincipal = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GrantId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.GrantId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IssuingAccount", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.IssuingAccount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Operations", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Operations = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RetiringPrincipal", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RetiringPrincipal = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static GrantListEntryUnmarshaller _instance = new GrantListEntryUnmarshaller();        

        public static GrantListEntryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}