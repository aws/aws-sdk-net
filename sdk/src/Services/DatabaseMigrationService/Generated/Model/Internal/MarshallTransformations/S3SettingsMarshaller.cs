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
using System.Text;
using System.Xml.Serialization;

using Amazon.DatabaseMigrationService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
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
            if(requestObject == null)
                return;
            if(requestObject.IsSetAddColumnName())
            {
                context.Writer.WritePropertyName("AddColumnName");
                context.Writer.WriteBooleanValue(requestObject.AddColumnName.Value);
            }

            if(requestObject.IsSetAddTrailingPaddingCharacter())
            {
                context.Writer.WritePropertyName("AddTrailingPaddingCharacter");
                context.Writer.WriteBooleanValue(requestObject.AddTrailingPaddingCharacter.Value);
            }

            if(requestObject.IsSetBucketFolder())
            {
                context.Writer.WritePropertyName("BucketFolder");
                context.Writer.WriteStringValue(requestObject.BucketFolder);
            }

            if(requestObject.IsSetBucketName())
            {
                context.Writer.WritePropertyName("BucketName");
                context.Writer.WriteStringValue(requestObject.BucketName);
            }

            if(requestObject.IsSetCannedAclForObjects())
            {
                context.Writer.WritePropertyName("CannedAclForObjects");
                context.Writer.WriteStringValue(requestObject.CannedAclForObjects);
            }

            if(requestObject.IsSetCdcInsertsAndUpdates())
            {
                context.Writer.WritePropertyName("CdcInsertsAndUpdates");
                context.Writer.WriteBooleanValue(requestObject.CdcInsertsAndUpdates.Value);
            }

            if(requestObject.IsSetCdcInsertsOnly())
            {
                context.Writer.WritePropertyName("CdcInsertsOnly");
                context.Writer.WriteBooleanValue(requestObject.CdcInsertsOnly.Value);
            }

            if(requestObject.IsSetCdcMaxBatchInterval())
            {
                context.Writer.WritePropertyName("CdcMaxBatchInterval");
                context.Writer.WriteNumberValue(requestObject.CdcMaxBatchInterval.Value);
            }

            if(requestObject.IsSetCdcMinFileSize())
            {
                context.Writer.WritePropertyName("CdcMinFileSize");
                context.Writer.WriteNumberValue(requestObject.CdcMinFileSize.Value);
            }

            if(requestObject.IsSetCdcPath())
            {
                context.Writer.WritePropertyName("CdcPath");
                context.Writer.WriteStringValue(requestObject.CdcPath);
            }

            if(requestObject.IsSetCompressionType())
            {
                context.Writer.WritePropertyName("CompressionType");
                context.Writer.WriteStringValue(requestObject.CompressionType);
            }

            if(requestObject.IsSetCsvDelimiter())
            {
                context.Writer.WritePropertyName("CsvDelimiter");
                context.Writer.WriteStringValue(requestObject.CsvDelimiter);
            }

            if(requestObject.IsSetCsvNoSupValue())
            {
                context.Writer.WritePropertyName("CsvNoSupValue");
                context.Writer.WriteStringValue(requestObject.CsvNoSupValue);
            }

            if(requestObject.IsSetCsvNullValue())
            {
                context.Writer.WritePropertyName("CsvNullValue");
                context.Writer.WriteStringValue(requestObject.CsvNullValue);
            }

            if(requestObject.IsSetCsvRowDelimiter())
            {
                context.Writer.WritePropertyName("CsvRowDelimiter");
                context.Writer.WriteStringValue(requestObject.CsvRowDelimiter);
            }

            if(requestObject.IsSetDataFormat())
            {
                context.Writer.WritePropertyName("DataFormat");
                context.Writer.WriteStringValue(requestObject.DataFormat);
            }

            if(requestObject.IsSetDataPageSize())
            {
                context.Writer.WritePropertyName("DataPageSize");
                context.Writer.WriteNumberValue(requestObject.DataPageSize.Value);
            }

            if(requestObject.IsSetDatePartitionDelimiter())
            {
                context.Writer.WritePropertyName("DatePartitionDelimiter");
                context.Writer.WriteStringValue(requestObject.DatePartitionDelimiter);
            }

            if(requestObject.IsSetDatePartitionEnabled())
            {
                context.Writer.WritePropertyName("DatePartitionEnabled");
                context.Writer.WriteBooleanValue(requestObject.DatePartitionEnabled.Value);
            }

            if(requestObject.IsSetDatePartitionSequence())
            {
                context.Writer.WritePropertyName("DatePartitionSequence");
                context.Writer.WriteStringValue(requestObject.DatePartitionSequence);
            }

            if(requestObject.IsSetDatePartitionTimezone())
            {
                context.Writer.WritePropertyName("DatePartitionTimezone");
                context.Writer.WriteStringValue(requestObject.DatePartitionTimezone);
            }

            if(requestObject.IsSetDictPageSizeLimit())
            {
                context.Writer.WritePropertyName("DictPageSizeLimit");
                context.Writer.WriteNumberValue(requestObject.DictPageSizeLimit.Value);
            }

            if(requestObject.IsSetEnableStatistics())
            {
                context.Writer.WritePropertyName("EnableStatistics");
                context.Writer.WriteBooleanValue(requestObject.EnableStatistics.Value);
            }

            if(requestObject.IsSetEncodingType())
            {
                context.Writer.WritePropertyName("EncodingType");
                context.Writer.WriteStringValue(requestObject.EncodingType);
            }

            if(requestObject.IsSetEncryptionMode())
            {
                context.Writer.WritePropertyName("EncryptionMode");
                context.Writer.WriteStringValue(requestObject.EncryptionMode);
            }

            if(requestObject.IsSetExpectedBucketOwner())
            {
                context.Writer.WritePropertyName("ExpectedBucketOwner");
                context.Writer.WriteStringValue(requestObject.ExpectedBucketOwner);
            }

            if(requestObject.IsSetExternalTableDefinition())
            {
                context.Writer.WritePropertyName("ExternalTableDefinition");
                context.Writer.WriteStringValue(requestObject.ExternalTableDefinition);
            }

            if(requestObject.IsSetGlueCatalogGeneration())
            {
                context.Writer.WritePropertyName("GlueCatalogGeneration");
                context.Writer.WriteBooleanValue(requestObject.GlueCatalogGeneration.Value);
            }

            if(requestObject.IsSetIgnoreHeaderRows())
            {
                context.Writer.WritePropertyName("IgnoreHeaderRows");
                context.Writer.WriteNumberValue(requestObject.IgnoreHeaderRows.Value);
            }

            if(requestObject.IsSetIncludeOpForFullLoad())
            {
                context.Writer.WritePropertyName("IncludeOpForFullLoad");
                context.Writer.WriteBooleanValue(requestObject.IncludeOpForFullLoad.Value);
            }

            if(requestObject.IsSetMaxFileSize())
            {
                context.Writer.WritePropertyName("MaxFileSize");
                context.Writer.WriteNumberValue(requestObject.MaxFileSize.Value);
            }

            if(requestObject.IsSetParquetTimestampInMillisecond())
            {
                context.Writer.WritePropertyName("ParquetTimestampInMillisecond");
                context.Writer.WriteBooleanValue(requestObject.ParquetTimestampInMillisecond.Value);
            }

            if(requestObject.IsSetParquetVersion())
            {
                context.Writer.WritePropertyName("ParquetVersion");
                context.Writer.WriteStringValue(requestObject.ParquetVersion);
            }

            if(requestObject.IsSetPreserveTransactions())
            {
                context.Writer.WritePropertyName("PreserveTransactions");
                context.Writer.WriteBooleanValue(requestObject.PreserveTransactions.Value);
            }

            if(requestObject.IsSetRfc4180())
            {
                context.Writer.WritePropertyName("Rfc4180");
                context.Writer.WriteBooleanValue(requestObject.Rfc4180.Value);
            }

            if(requestObject.IsSetRowGroupLength())
            {
                context.Writer.WritePropertyName("RowGroupLength");
                context.Writer.WriteNumberValue(requestObject.RowGroupLength.Value);
            }

            if(requestObject.IsSetServerSideEncryptionKmsKeyId())
            {
                context.Writer.WritePropertyName("ServerSideEncryptionKmsKeyId");
                context.Writer.WriteStringValue(requestObject.ServerSideEncryptionKmsKeyId);
            }

            if(requestObject.IsSetServiceAccessRoleArn())
            {
                context.Writer.WritePropertyName("ServiceAccessRoleArn");
                context.Writer.WriteStringValue(requestObject.ServiceAccessRoleArn);
            }

            if(requestObject.IsSetTimestampColumnName())
            {
                context.Writer.WritePropertyName("TimestampColumnName");
                context.Writer.WriteStringValue(requestObject.TimestampColumnName);
            }

            if(requestObject.IsSetUseCsvNoSupValue())
            {
                context.Writer.WritePropertyName("UseCsvNoSupValue");
                context.Writer.WriteBooleanValue(requestObject.UseCsvNoSupValue.Value);
            }

            if(requestObject.IsSetUseTaskStartTimeForFullLoadTimestamp())
            {
                context.Writer.WritePropertyName("UseTaskStartTimeForFullLoadTimestamp");
                context.Writer.WriteBooleanValue(requestObject.UseTaskStartTimeForFullLoadTimestamp.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static S3SettingsMarshaller Instance = new S3SettingsMarshaller();

    }
}