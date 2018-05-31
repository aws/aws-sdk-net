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
 * Do not modify this file. This file is generated from the neptune-2018-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Neptune.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.Neptune.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DBClusterSnapshotAttributesResult Object
    /// </summary>  
    public class DBClusterSnapshotAttributesResultUnmarshaller : IUnmarshaller<DBClusterSnapshotAttributesResult, XmlUnmarshallerContext>, IUnmarshaller<DBClusterSnapshotAttributesResult, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public DBClusterSnapshotAttributesResult Unmarshall(XmlUnmarshallerContext context)
        {
            DBClusterSnapshotAttributesResult unmarshalledObject = new DBClusterSnapshotAttributesResult();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("DBClusterSnapshotAttributes/DBClusterSnapshotAttribute", targetDepth))
                    {
                        var unmarshaller = DBClusterSnapshotAttributeUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.DBClusterSnapshotAttributes.Add(item);
                        continue;
                    }
                    if (context.TestExpression("DBClusterSnapshotIdentifier", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DBClusterSnapshotIdentifier = unmarshaller.Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return unmarshalledObject;
                }
            }

            return unmarshalledObject;
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public DBClusterSnapshotAttributesResult Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static DBClusterSnapshotAttributesResultUnmarshaller _instance = new DBClusterSnapshotAttributesResultUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DBClusterSnapshotAttributesResultUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}