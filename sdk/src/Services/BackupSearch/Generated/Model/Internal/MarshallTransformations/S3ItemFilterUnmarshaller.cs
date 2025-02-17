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
 * Do not modify this file. This file is generated from the backupsearch-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.BackupSearch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.BackupSearch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for S3ItemFilter Object
    /// </summary>  
    public class S3ItemFilterUnmarshaller : IUnmarshaller<S3ItemFilter, XmlUnmarshallerContext>, IUnmarshaller<S3ItemFilter, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        S3ItemFilter IUnmarshaller<S3ItemFilter, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public S3ItemFilter Unmarshall(JsonUnmarshallerContext context)
        {
            S3ItemFilter unmarshalledObject = new S3ItemFilter();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CreationTimes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<TimeCondition, TimeConditionUnmarshaller>(TimeConditionUnmarshaller.Instance);
                    unmarshalledObject.CreationTimes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ETags", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringCondition, StringConditionUnmarshaller>(StringConditionUnmarshaller.Instance);
                    unmarshalledObject.ETags = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ObjectKeys", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringCondition, StringConditionUnmarshaller>(StringConditionUnmarshaller.Instance);
                    unmarshalledObject.ObjectKeys = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Sizes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<LongCondition, LongConditionUnmarshaller>(LongConditionUnmarshaller.Instance);
                    unmarshalledObject.Sizes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VersionIds", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringCondition, StringConditionUnmarshaller>(StringConditionUnmarshaller.Instance);
                    unmarshalledObject.VersionIds = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static S3ItemFilterUnmarshaller _instance = new S3ItemFilterUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static S3ItemFilterUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}