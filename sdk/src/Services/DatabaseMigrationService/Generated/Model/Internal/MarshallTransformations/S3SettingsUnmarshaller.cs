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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.DatabaseMigrationService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DatabaseMigrationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for S3Settings Object
    /// </summary>  
    public class S3SettingsUnmarshaller : IUnmarshaller<S3Settings, XmlUnmarshallerContext>, IUnmarshaller<S3Settings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        S3Settings IUnmarshaller<S3Settings, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public S3Settings Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            S3Settings unmarshalledObject = new S3Settings();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AddColumnName", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.AddColumnName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AddTrailingPaddingCharacter", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.AddTrailingPaddingCharacter = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BucketFolder", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BucketFolder = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BucketName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BucketName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CannedAclForObjects", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CannedAclForObjects = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CdcInsertsAndUpdates", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.CdcInsertsAndUpdates = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CdcInsertsOnly", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.CdcInsertsOnly = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CdcMaxBatchInterval", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.CdcMaxBatchInterval = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CdcMinFileSize", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.CdcMinFileSize = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CdcPath", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CdcPath = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CompressionType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CompressionType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CsvDelimiter", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CsvDelimiter = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CsvNoSupValue", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CsvNoSupValue = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CsvNullValue", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CsvNullValue = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CsvRowDelimiter", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CsvRowDelimiter = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DataFormat", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DataFormat = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DataPageSize", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.DataPageSize = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DatePartitionDelimiter", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DatePartitionDelimiter = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DatePartitionEnabled", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.DatePartitionEnabled = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DatePartitionSequence", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DatePartitionSequence = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DatePartitionTimezone", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DatePartitionTimezone = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DictPageSizeLimit", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.DictPageSizeLimit = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EnableStatistics", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.EnableStatistics = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EncodingType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EncodingType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EncryptionMode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EncryptionMode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExpectedBucketOwner", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ExpectedBucketOwner = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExternalTableDefinition", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ExternalTableDefinition = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GlueCatalogGeneration", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.GlueCatalogGeneration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IgnoreHeaderRows", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.IgnoreHeaderRows = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IncludeOpForFullLoad", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.IncludeOpForFullLoad = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaxFileSize", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MaxFileSize = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ParquetTimestampInMillisecond", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.ParquetTimestampInMillisecond = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ParquetVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ParquetVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PreserveTransactions", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.PreserveTransactions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Rfc4180", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.Rfc4180 = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RowGroupLength", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.RowGroupLength = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ServerSideEncryptionKmsKeyId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ServerSideEncryptionKmsKeyId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ServiceAccessRoleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ServiceAccessRoleArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TimestampColumnName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TimestampColumnName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UseCsvNoSupValue", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.UseCsvNoSupValue = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UseTaskStartTimeForFullLoadTimestamp", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.UseTaskStartTimeForFullLoadTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static S3SettingsUnmarshaller _instance = new S3SettingsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static S3SettingsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}