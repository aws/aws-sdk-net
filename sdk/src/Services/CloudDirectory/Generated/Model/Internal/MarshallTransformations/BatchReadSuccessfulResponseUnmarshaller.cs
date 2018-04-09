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
 * Do not modify this file. This file is generated from the clouddirectory-2016-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudDirectory.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CloudDirectory.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for BatchReadSuccessfulResponse Object
    /// </summary>  
    public class BatchReadSuccessfulResponseUnmarshaller : IUnmarshaller<BatchReadSuccessfulResponse, XmlUnmarshallerContext>, IUnmarshaller<BatchReadSuccessfulResponse, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        BatchReadSuccessfulResponse IUnmarshaller<BatchReadSuccessfulResponse, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public BatchReadSuccessfulResponse Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            BatchReadSuccessfulResponse unmarshalledObject = new BatchReadSuccessfulResponse();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("GetObjectAttributes", targetDepth))
                {
                    var unmarshaller = BatchGetObjectAttributesResponseUnmarshaller.Instance;
                    unmarshalledObject.GetObjectAttributes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GetObjectInformation", targetDepth))
                {
                    var unmarshaller = BatchGetObjectInformationResponseUnmarshaller.Instance;
                    unmarshalledObject.GetObjectInformation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ListAttachedIndices", targetDepth))
                {
                    var unmarshaller = BatchListAttachedIndicesResponseUnmarshaller.Instance;
                    unmarshalledObject.ListAttachedIndices = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ListIncomingTypedLinks", targetDepth))
                {
                    var unmarshaller = BatchListIncomingTypedLinksResponseUnmarshaller.Instance;
                    unmarshalledObject.ListIncomingTypedLinks = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ListIndex", targetDepth))
                {
                    var unmarshaller = BatchListIndexResponseUnmarshaller.Instance;
                    unmarshalledObject.ListIndex = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ListObjectAttributes", targetDepth))
                {
                    var unmarshaller = BatchListObjectAttributesResponseUnmarshaller.Instance;
                    unmarshalledObject.ListObjectAttributes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ListObjectChildren", targetDepth))
                {
                    var unmarshaller = BatchListObjectChildrenResponseUnmarshaller.Instance;
                    unmarshalledObject.ListObjectChildren = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ListObjectParentPaths", targetDepth))
                {
                    var unmarshaller = BatchListObjectParentPathsResponseUnmarshaller.Instance;
                    unmarshalledObject.ListObjectParentPaths = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ListObjectPolicies", targetDepth))
                {
                    var unmarshaller = BatchListObjectPoliciesResponseUnmarshaller.Instance;
                    unmarshalledObject.ListObjectPolicies = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ListOutgoingTypedLinks", targetDepth))
                {
                    var unmarshaller = BatchListOutgoingTypedLinksResponseUnmarshaller.Instance;
                    unmarshalledObject.ListOutgoingTypedLinks = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ListPolicyAttachments", targetDepth))
                {
                    var unmarshaller = BatchListPolicyAttachmentsResponseUnmarshaller.Instance;
                    unmarshalledObject.ListPolicyAttachments = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LookupPolicy", targetDepth))
                {
                    var unmarshaller = BatchLookupPolicyResponseUnmarshaller.Instance;
                    unmarshalledObject.LookupPolicy = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static BatchReadSuccessfulResponseUnmarshaller _instance = new BatchReadSuccessfulResponseUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BatchReadSuccessfulResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}