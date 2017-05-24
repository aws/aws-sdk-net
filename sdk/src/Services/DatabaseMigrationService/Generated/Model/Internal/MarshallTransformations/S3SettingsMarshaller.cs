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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
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
    /// S3Settings Marshaller
    /// </summary>       
    public class S3SettingsMarshaller : IRequestMarshaller<S3Settings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(S3Settings requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetBucketFolder())
            {
                context.Writer.WritePropertyName("BucketFolder");
                context.Writer.Write(requestObject.BucketFolder);
            }

            if(requestObject.IsSetBucketName())
            {
                context.Writer.WritePropertyName("BucketName");
                context.Writer.Write(requestObject.BucketName);
            }

            if(requestObject.IsSetCompressionType())
            {
                context.Writer.WritePropertyName("CompressionType");
                context.Writer.Write(requestObject.CompressionType);
            }

            if(requestObject.IsSetCsvDelimiter())
            {
                context.Writer.WritePropertyName("CsvDelimiter");
                context.Writer.Write(requestObject.CsvDelimiter);
            }

            if(requestObject.IsSetCsvRowDelimiter())
            {
                context.Writer.WritePropertyName("CsvRowDelimiter");
                context.Writer.Write(requestObject.CsvRowDelimiter);
            }

            if(requestObject.IsSetExternalTableDefinition())
            {
                context.Writer.WritePropertyName("ExternalTableDefinition");
                context.Writer.Write(requestObject.ExternalTableDefinition);
            }

            if(requestObject.IsSetServiceAccessRoleArn())
            {
                context.Writer.WritePropertyName("ServiceAccessRoleArn");
                context.Writer.Write(requestObject.ServiceAccessRoleArn);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static S3SettingsMarshaller Instance = new S3SettingsMarshaller();

    }
}