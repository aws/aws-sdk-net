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
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.CodeCommit.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ConflictMetadata Object
    /// </summary>  
    public class ConflictMetadataUnmarshaller : IJsonUnmarshaller<ConflictMetadata, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public ConflictMetadata Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            ConflictMetadata unmarshalledObject = new ConflictMetadata();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("contentConflict", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.ContentConflict = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("fileModeConflict", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.FileModeConflict = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("fileModes", targetDepth))
                {
                    var unmarshaller = FileModesUnmarshaller.Instance;
                    unmarshalledObject.FileModes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("filePath", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FilePath = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("fileSizes", targetDepth))
                {
                    var unmarshaller = FileSizesUnmarshaller.Instance;
                    unmarshalledObject.FileSizes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("isBinaryFile", targetDepth))
                {
                    var unmarshaller = IsBinaryFileUnmarshaller.Instance;
                    unmarshalledObject.IsBinaryFile = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("mergeOperations", targetDepth))
                {
                    var unmarshaller = MergeOperationsUnmarshaller.Instance;
                    unmarshalledObject.MergeOperations = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("numberOfConflicts", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.NumberOfConflicts = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("objectTypeConflict", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.ObjectTypeConflict = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("objectTypes", targetDepth))
                {
                    var unmarshaller = ObjectTypesUnmarshaller.Instance;
                    unmarshalledObject.ObjectTypes = unmarshaller.Unmarshall(context, ref reader);
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