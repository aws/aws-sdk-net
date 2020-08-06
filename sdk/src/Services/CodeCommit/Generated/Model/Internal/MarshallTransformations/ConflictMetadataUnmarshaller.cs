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
 * Do not modify this file. This file is generated from the codecommit-2015-04-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeCommit.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CodeCommit.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ConflictMetadata Object
    /// </summary>  
    public class ConflictMetadataUnmarshaller : IUnmarshaller<ConflictMetadata, XmlUnmarshallerContext>, IUnmarshaller<ConflictMetadata, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ConflictMetadata IUnmarshaller<ConflictMetadata, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ConflictMetadata Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ConflictMetadata unmarshalledObject = new ConflictMetadata();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("contentConflict", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.ContentConflict = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("fileModeConflict", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.FileModeConflict = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("fileModes", targetDepth))
                {
                    var unmarshaller = FileModesUnmarshaller.Instance;
                    unmarshalledObject.FileModes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("filePath", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FilePath = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("fileSizes", targetDepth))
                {
                    var unmarshaller = FileSizesUnmarshaller.Instance;
                    unmarshalledObject.FileSizes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("isBinaryFile", targetDepth))
                {
                    var unmarshaller = IsBinaryFileUnmarshaller.Instance;
                    unmarshalledObject.IsBinaryFile = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("mergeOperations", targetDepth))
                {
                    var unmarshaller = MergeOperationsUnmarshaller.Instance;
                    unmarshalledObject.MergeOperations = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("numberOfConflicts", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.NumberOfConflicts = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("objectTypeConflict", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.ObjectTypeConflict = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("objectTypes", targetDepth))
                {
                    var unmarshaller = ObjectTypesUnmarshaller.Instance;
                    unmarshalledObject.ObjectTypes = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ConflictMetadataUnmarshaller _instance = new ConflictMetadataUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ConflictMetadataUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}