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
    /// Response Unmarshaller for EBSItemFilter Object
    /// </summary>  
    public class EBSItemFilterUnmarshaller : IUnmarshaller<EBSItemFilter, XmlUnmarshallerContext>, IUnmarshaller<EBSItemFilter, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        EBSItemFilter IUnmarshaller<EBSItemFilter, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public EBSItemFilter Unmarshall(JsonUnmarshallerContext context)
        {
            EBSItemFilter unmarshalledObject = new EBSItemFilter();
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
                if (context.TestExpression("FilePaths", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StringCondition, StringConditionUnmarshaller>(StringConditionUnmarshaller.Instance);
                    unmarshalledObject.FilePaths = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastModificationTimes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<TimeCondition, TimeConditionUnmarshaller>(TimeConditionUnmarshaller.Instance);
                    unmarshalledObject.LastModificationTimes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Sizes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<LongCondition, LongConditionUnmarshaller>(LongConditionUnmarshaller.Instance);
                    unmarshalledObject.Sizes = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static EBSItemFilterUnmarshaller _instance = new EBSItemFilterUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static EBSItemFilterUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}