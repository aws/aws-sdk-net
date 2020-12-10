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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Kendra
{

    /// <summary>
    /// Constants used for properties of type AdditionalResultAttributeValueType.
    /// </summary>
    public class AdditionalResultAttributeValueType : ConstantClass
    {

        /// <summary>
        /// Constant TEXT_WITH_HIGHLIGHTS_VALUE for AdditionalResultAttributeValueType
        /// </summary>
        public static readonly AdditionalResultAttributeValueType TEXT_WITH_HIGHLIGHTS_VALUE = new AdditionalResultAttributeValueType("TEXT_WITH_HIGHLIGHTS_VALUE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AdditionalResultAttributeValueType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AdditionalResultAttributeValueType FindValue(string value)
        {
            return FindValue<AdditionalResultAttributeValueType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AdditionalResultAttributeValueType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConfluenceAttachmentFieldName.
    /// </summary>
    public class ConfluenceAttachmentFieldName : ConstantClass
    {

        /// <summary>
        /// Constant AUTHOR for ConfluenceAttachmentFieldName
        /// </summary>
        public static readonly ConfluenceAttachmentFieldName AUTHOR = new ConfluenceAttachmentFieldName("AUTHOR");
        /// <summary>
        /// Constant CONTENT_TYPE for ConfluenceAttachmentFieldName
        /// </summary>
        public static readonly ConfluenceAttachmentFieldName CONTENT_TYPE = new ConfluenceAttachmentFieldName("CONTENT_TYPE");
        /// <summary>
        /// Constant CREATED_DATE for ConfluenceAttachmentFieldName
        /// </summary>
        public static readonly ConfluenceAttachmentFieldName CREATED_DATE = new ConfluenceAttachmentFieldName("CREATED_DATE");
        /// <summary>
        /// Constant DISPLAY_URL for ConfluenceAttachmentFieldName
        /// </summary>
        public static readonly ConfluenceAttachmentFieldName DISPLAY_URL = new ConfluenceAttachmentFieldName("DISPLAY_URL");
        /// <summary>
        /// Constant FILE_SIZE for ConfluenceAttachmentFieldName
        /// </summary>
        public static readonly ConfluenceAttachmentFieldName FILE_SIZE = new ConfluenceAttachmentFieldName("FILE_SIZE");
        /// <summary>
        /// Constant ITEM_TYPE for ConfluenceAttachmentFieldName
        /// </summary>
        public static readonly ConfluenceAttachmentFieldName ITEM_TYPE = new ConfluenceAttachmentFieldName("ITEM_TYPE");
        /// <summary>
        /// Constant PARENT_ID for ConfluenceAttachmentFieldName
        /// </summary>
        public static readonly ConfluenceAttachmentFieldName PARENT_ID = new ConfluenceAttachmentFieldName("PARENT_ID");
        /// <summary>
        /// Constant SPACE_KEY for ConfluenceAttachmentFieldName
        /// </summary>
        public static readonly ConfluenceAttachmentFieldName SPACE_KEY = new ConfluenceAttachmentFieldName("SPACE_KEY");
        /// <summary>
        /// Constant SPACE_NAME for ConfluenceAttachmentFieldName
        /// </summary>
        public static readonly ConfluenceAttachmentFieldName SPACE_NAME = new ConfluenceAttachmentFieldName("SPACE_NAME");
        /// <summary>
        /// Constant URL for ConfluenceAttachmentFieldName
        /// </summary>
        public static readonly ConfluenceAttachmentFieldName URL = new ConfluenceAttachmentFieldName("URL");
        /// <summary>
        /// Constant VERSION for ConfluenceAttachmentFieldName
        /// </summary>
        public static readonly ConfluenceAttachmentFieldName VERSION = new ConfluenceAttachmentFieldName("VERSION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConfluenceAttachmentFieldName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConfluenceAttachmentFieldName FindValue(string value)
        {
            return FindValue<ConfluenceAttachmentFieldName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConfluenceAttachmentFieldName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConfluenceBlogFieldName.
    /// </summary>
    public class ConfluenceBlogFieldName : ConstantClass
    {

        /// <summary>
        /// Constant AUTHOR for ConfluenceBlogFieldName
        /// </summary>
        public static readonly ConfluenceBlogFieldName AUTHOR = new ConfluenceBlogFieldName("AUTHOR");
        /// <summary>
        /// Constant DISPLAY_URL for ConfluenceBlogFieldName
        /// </summary>
        public static readonly ConfluenceBlogFieldName DISPLAY_URL = new ConfluenceBlogFieldName("DISPLAY_URL");
        /// <summary>
        /// Constant ITEM_TYPE for ConfluenceBlogFieldName
        /// </summary>
        public static readonly ConfluenceBlogFieldName ITEM_TYPE = new ConfluenceBlogFieldName("ITEM_TYPE");
        /// <summary>
        /// Constant LABELS for ConfluenceBlogFieldName
        /// </summary>
        public static readonly ConfluenceBlogFieldName LABELS = new ConfluenceBlogFieldName("LABELS");
        /// <summary>
        /// Constant PUBLISH_DATE for ConfluenceBlogFieldName
        /// </summary>
        public static readonly ConfluenceBlogFieldName PUBLISH_DATE = new ConfluenceBlogFieldName("PUBLISH_DATE");
        /// <summary>
        /// Constant SPACE_KEY for ConfluenceBlogFieldName
        /// </summary>
        public static readonly ConfluenceBlogFieldName SPACE_KEY = new ConfluenceBlogFieldName("SPACE_KEY");
        /// <summary>
        /// Constant SPACE_NAME for ConfluenceBlogFieldName
        /// </summary>
        public static readonly ConfluenceBlogFieldName SPACE_NAME = new ConfluenceBlogFieldName("SPACE_NAME");
        /// <summary>
        /// Constant URL for ConfluenceBlogFieldName
        /// </summary>
        public static readonly ConfluenceBlogFieldName URL = new ConfluenceBlogFieldName("URL");
        /// <summary>
        /// Constant VERSION for ConfluenceBlogFieldName
        /// </summary>
        public static readonly ConfluenceBlogFieldName VERSION = new ConfluenceBlogFieldName("VERSION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConfluenceBlogFieldName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConfluenceBlogFieldName FindValue(string value)
        {
            return FindValue<ConfluenceBlogFieldName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConfluenceBlogFieldName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConfluencePageFieldName.
    /// </summary>
    public class ConfluencePageFieldName : ConstantClass
    {

        /// <summary>
        /// Constant AUTHOR for ConfluencePageFieldName
        /// </summary>
        public static readonly ConfluencePageFieldName AUTHOR = new ConfluencePageFieldName("AUTHOR");
        /// <summary>
        /// Constant CONTENT_STATUS for ConfluencePageFieldName
        /// </summary>
        public static readonly ConfluencePageFieldName CONTENT_STATUS = new ConfluencePageFieldName("CONTENT_STATUS");
        /// <summary>
        /// Constant CREATED_DATE for ConfluencePageFieldName
        /// </summary>
        public static readonly ConfluencePageFieldName CREATED_DATE = new ConfluencePageFieldName("CREATED_DATE");
        /// <summary>
        /// Constant DISPLAY_URL for ConfluencePageFieldName
        /// </summary>
        public static readonly ConfluencePageFieldName DISPLAY_URL = new ConfluencePageFieldName("DISPLAY_URL");
        /// <summary>
        /// Constant ITEM_TYPE for ConfluencePageFieldName
        /// </summary>
        public static readonly ConfluencePageFieldName ITEM_TYPE = new ConfluencePageFieldName("ITEM_TYPE");
        /// <summary>
        /// Constant LABELS for ConfluencePageFieldName
        /// </summary>
        public static readonly ConfluencePageFieldName LABELS = new ConfluencePageFieldName("LABELS");
        /// <summary>
        /// Constant MODIFIED_DATE for ConfluencePageFieldName
        /// </summary>
        public static readonly ConfluencePageFieldName MODIFIED_DATE = new ConfluencePageFieldName("MODIFIED_DATE");
        /// <summary>
        /// Constant PARENT_ID for ConfluencePageFieldName
        /// </summary>
        public static readonly ConfluencePageFieldName PARENT_ID = new ConfluencePageFieldName("PARENT_ID");
        /// <summary>
        /// Constant SPACE_KEY for ConfluencePageFieldName
        /// </summary>
        public static readonly ConfluencePageFieldName SPACE_KEY = new ConfluencePageFieldName("SPACE_KEY");
        /// <summary>
        /// Constant SPACE_NAME for ConfluencePageFieldName
        /// </summary>
        public static readonly ConfluencePageFieldName SPACE_NAME = new ConfluencePageFieldName("SPACE_NAME");
        /// <summary>
        /// Constant URL for ConfluencePageFieldName
        /// </summary>
        public static readonly ConfluencePageFieldName URL = new ConfluencePageFieldName("URL");
        /// <summary>
        /// Constant VERSION for ConfluencePageFieldName
        /// </summary>
        public static readonly ConfluencePageFieldName VERSION = new ConfluencePageFieldName("VERSION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConfluencePageFieldName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConfluencePageFieldName FindValue(string value)
        {
            return FindValue<ConfluencePageFieldName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConfluencePageFieldName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConfluenceSpaceFieldName.
    /// </summary>
    public class ConfluenceSpaceFieldName : ConstantClass
    {

        /// <summary>
        /// Constant DISPLAY_URL for ConfluenceSpaceFieldName
        /// </summary>
        public static readonly ConfluenceSpaceFieldName DISPLAY_URL = new ConfluenceSpaceFieldName("DISPLAY_URL");
        /// <summary>
        /// Constant ITEM_TYPE for ConfluenceSpaceFieldName
        /// </summary>
        public static readonly ConfluenceSpaceFieldName ITEM_TYPE = new ConfluenceSpaceFieldName("ITEM_TYPE");
        /// <summary>
        /// Constant SPACE_KEY for ConfluenceSpaceFieldName
        /// </summary>
        public static readonly ConfluenceSpaceFieldName SPACE_KEY = new ConfluenceSpaceFieldName("SPACE_KEY");
        /// <summary>
        /// Constant URL for ConfluenceSpaceFieldName
        /// </summary>
        public static readonly ConfluenceSpaceFieldName URL = new ConfluenceSpaceFieldName("URL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConfluenceSpaceFieldName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConfluenceSpaceFieldName FindValue(string value)
        {
            return FindValue<ConfluenceSpaceFieldName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConfluenceSpaceFieldName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConfluenceVersion.
    /// </summary>
    public class ConfluenceVersion : ConstantClass
    {

        /// <summary>
        /// Constant CLOUD for ConfluenceVersion
        /// </summary>
        public static readonly ConfluenceVersion CLOUD = new ConfluenceVersion("CLOUD");
        /// <summary>
        /// Constant SERVER for ConfluenceVersion
        /// </summary>
        public static readonly ConfluenceVersion SERVER = new ConfluenceVersion("SERVER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConfluenceVersion(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConfluenceVersion FindValue(string value)
        {
            return FindValue<ConfluenceVersion>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConfluenceVersion(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContentType.
    /// </summary>
    public class ContentType : ConstantClass
    {

        /// <summary>
        /// Constant HTML for ContentType
        /// </summary>
        public static readonly ContentType HTML = new ContentType("HTML");
        /// <summary>
        /// Constant MS_WORD for ContentType
        /// </summary>
        public static readonly ContentType MS_WORD = new ContentType("MS_WORD");
        /// <summary>
        /// Constant PDF for ContentType
        /// </summary>
        public static readonly ContentType PDF = new ContentType("PDF");
        /// <summary>
        /// Constant PLAIN_TEXT for ContentType
        /// </summary>
        public static readonly ContentType PLAIN_TEXT = new ContentType("PLAIN_TEXT");
        /// <summary>
        /// Constant PPT for ContentType
        /// </summary>
        public static readonly ContentType PPT = new ContentType("PPT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContentType FindValue(string value)
        {
            return FindValue<ContentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DatabaseEngineType.
    /// </summary>
    public class DatabaseEngineType : ConstantClass
    {

        /// <summary>
        /// Constant RDS_AURORA_MYSQL for DatabaseEngineType
        /// </summary>
        public static readonly DatabaseEngineType RDS_AURORA_MYSQL = new DatabaseEngineType("RDS_AURORA_MYSQL");
        /// <summary>
        /// Constant RDS_AURORA_POSTGRESQL for DatabaseEngineType
        /// </summary>
        public static readonly DatabaseEngineType RDS_AURORA_POSTGRESQL = new DatabaseEngineType("RDS_AURORA_POSTGRESQL");
        /// <summary>
        /// Constant RDS_MYSQL for DatabaseEngineType
        /// </summary>
        public static readonly DatabaseEngineType RDS_MYSQL = new DatabaseEngineType("RDS_MYSQL");
        /// <summary>
        /// Constant RDS_POSTGRESQL for DatabaseEngineType
        /// </summary>
        public static readonly DatabaseEngineType RDS_POSTGRESQL = new DatabaseEngineType("RDS_POSTGRESQL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DatabaseEngineType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DatabaseEngineType FindValue(string value)
        {
            return FindValue<DatabaseEngineType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DatabaseEngineType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataSourceStatus.
    /// </summary>
    public class DataSourceStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for DataSourceStatus
        /// </summary>
        public static readonly DataSourceStatus ACTIVE = new DataSourceStatus("ACTIVE");
        /// <summary>
        /// Constant CREATING for DataSourceStatus
        /// </summary>
        public static readonly DataSourceStatus CREATING = new DataSourceStatus("CREATING");
        /// <summary>
        /// Constant DELETING for DataSourceStatus
        /// </summary>
        public static readonly DataSourceStatus DELETING = new DataSourceStatus("DELETING");
        /// <summary>
        /// Constant FAILED for DataSourceStatus
        /// </summary>
        public static readonly DataSourceStatus FAILED = new DataSourceStatus("FAILED");
        /// <summary>
        /// Constant UPDATING for DataSourceStatus
        /// </summary>
        public static readonly DataSourceStatus UPDATING = new DataSourceStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataSourceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataSourceStatus FindValue(string value)
        {
            return FindValue<DataSourceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataSourceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataSourceSyncJobStatus.
    /// </summary>
    public class DataSourceSyncJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant ABORTED for DataSourceSyncJobStatus
        /// </summary>
        public static readonly DataSourceSyncJobStatus ABORTED = new DataSourceSyncJobStatus("ABORTED");
        /// <summary>
        /// Constant FAILED for DataSourceSyncJobStatus
        /// </summary>
        public static readonly DataSourceSyncJobStatus FAILED = new DataSourceSyncJobStatus("FAILED");
        /// <summary>
        /// Constant INCOMPLETE for DataSourceSyncJobStatus
        /// </summary>
        public static readonly DataSourceSyncJobStatus INCOMPLETE = new DataSourceSyncJobStatus("INCOMPLETE");
        /// <summary>
        /// Constant STOPPING for DataSourceSyncJobStatus
        /// </summary>
        public static readonly DataSourceSyncJobStatus STOPPING = new DataSourceSyncJobStatus("STOPPING");
        /// <summary>
        /// Constant SUCCEEDED for DataSourceSyncJobStatus
        /// </summary>
        public static readonly DataSourceSyncJobStatus SUCCEEDED = new DataSourceSyncJobStatus("SUCCEEDED");
        /// <summary>
        /// Constant SYNCING for DataSourceSyncJobStatus
        /// </summary>
        public static readonly DataSourceSyncJobStatus SYNCING = new DataSourceSyncJobStatus("SYNCING");
        /// <summary>
        /// Constant SYNCING_INDEXING for DataSourceSyncJobStatus
        /// </summary>
        public static readonly DataSourceSyncJobStatus SYNCING_INDEXING = new DataSourceSyncJobStatus("SYNCING_INDEXING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataSourceSyncJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataSourceSyncJobStatus FindValue(string value)
        {
            return FindValue<DataSourceSyncJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataSourceSyncJobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataSourceType.
    /// </summary>
    public class DataSourceType : ConstantClass
    {

        /// <summary>
        /// Constant CONFLUENCE for DataSourceType
        /// </summary>
        public static readonly DataSourceType CONFLUENCE = new DataSourceType("CONFLUENCE");
        /// <summary>
        /// Constant CUSTOM for DataSourceType
        /// </summary>
        public static readonly DataSourceType CUSTOM = new DataSourceType("CUSTOM");
        /// <summary>
        /// Constant DATABASE for DataSourceType
        /// </summary>
        public static readonly DataSourceType DATABASE = new DataSourceType("DATABASE");
        /// <summary>
        /// Constant GOOGLEDRIVE for DataSourceType
        /// </summary>
        public static readonly DataSourceType GOOGLEDRIVE = new DataSourceType("GOOGLEDRIVE");
        /// <summary>
        /// Constant ONEDRIVE for DataSourceType
        /// </summary>
        public static readonly DataSourceType ONEDRIVE = new DataSourceType("ONEDRIVE");
        /// <summary>
        /// Constant S3 for DataSourceType
        /// </summary>
        public static readonly DataSourceType S3 = new DataSourceType("S3");
        /// <summary>
        /// Constant SALESFORCE for DataSourceType
        /// </summary>
        public static readonly DataSourceType SALESFORCE = new DataSourceType("SALESFORCE");
        /// <summary>
        /// Constant SERVICENOW for DataSourceType
        /// </summary>
        public static readonly DataSourceType SERVICENOW = new DataSourceType("SERVICENOW");
        /// <summary>
        /// Constant SHAREPOINT for DataSourceType
        /// </summary>
        public static readonly DataSourceType SHAREPOINT = new DataSourceType("SHAREPOINT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataSourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataSourceType FindValue(string value)
        {
            return FindValue<DataSourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataSourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DocumentAttributeValueType.
    /// </summary>
    public class DocumentAttributeValueType : ConstantClass
    {

        /// <summary>
        /// Constant DATE_VALUE for DocumentAttributeValueType
        /// </summary>
        public static readonly DocumentAttributeValueType DATE_VALUE = new DocumentAttributeValueType("DATE_VALUE");
        /// <summary>
        /// Constant LONG_VALUE for DocumentAttributeValueType
        /// </summary>
        public static readonly DocumentAttributeValueType LONG_VALUE = new DocumentAttributeValueType("LONG_VALUE");
        /// <summary>
        /// Constant STRING_LIST_VALUE for DocumentAttributeValueType
        /// </summary>
        public static readonly DocumentAttributeValueType STRING_LIST_VALUE = new DocumentAttributeValueType("STRING_LIST_VALUE");
        /// <summary>
        /// Constant STRING_VALUE for DocumentAttributeValueType
        /// </summary>
        public static readonly DocumentAttributeValueType STRING_VALUE = new DocumentAttributeValueType("STRING_VALUE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DocumentAttributeValueType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DocumentAttributeValueType FindValue(string value)
        {
            return FindValue<DocumentAttributeValueType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DocumentAttributeValueType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ErrorCode.
    /// </summary>
    public class ErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant InternalError for ErrorCode
        /// </summary>
        public static readonly ErrorCode InternalError = new ErrorCode("InternalError");
        /// <summary>
        /// Constant InvalidRequest for ErrorCode
        /// </summary>
        public static readonly ErrorCode InvalidRequest = new ErrorCode("InvalidRequest");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ErrorCode FindValue(string value)
        {
            return FindValue<ErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FaqFileFormat.
    /// </summary>
    public class FaqFileFormat : ConstantClass
    {

        /// <summary>
        /// Constant CSV for FaqFileFormat
        /// </summary>
        public static readonly FaqFileFormat CSV = new FaqFileFormat("CSV");
        /// <summary>
        /// Constant CSV_WITH_HEADER for FaqFileFormat
        /// </summary>
        public static readonly FaqFileFormat CSV_WITH_HEADER = new FaqFileFormat("CSV_WITH_HEADER");
        /// <summary>
        /// Constant JSON for FaqFileFormat
        /// </summary>
        public static readonly FaqFileFormat JSON = new FaqFileFormat("JSON");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FaqFileFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FaqFileFormat FindValue(string value)
        {
            return FindValue<FaqFileFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FaqFileFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FaqStatus.
    /// </summary>
    public class FaqStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for FaqStatus
        /// </summary>
        public static readonly FaqStatus ACTIVE = new FaqStatus("ACTIVE");
        /// <summary>
        /// Constant CREATING for FaqStatus
        /// </summary>
        public static readonly FaqStatus CREATING = new FaqStatus("CREATING");
        /// <summary>
        /// Constant DELETING for FaqStatus
        /// </summary>
        public static readonly FaqStatus DELETING = new FaqStatus("DELETING");
        /// <summary>
        /// Constant FAILED for FaqStatus
        /// </summary>
        public static readonly FaqStatus FAILED = new FaqStatus("FAILED");
        /// <summary>
        /// Constant UPDATING for FaqStatus
        /// </summary>
        public static readonly FaqStatus UPDATING = new FaqStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FaqStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FaqStatus FindValue(string value)
        {
            return FindValue<FaqStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FaqStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HighlightType.
    /// </summary>
    public class HighlightType : ConstantClass
    {

        /// <summary>
        /// Constant STANDARD for HighlightType
        /// </summary>
        public static readonly HighlightType STANDARD = new HighlightType("STANDARD");
        /// <summary>
        /// Constant THESAURUS_SYNONYM for HighlightType
        /// </summary>
        public static readonly HighlightType THESAURUS_SYNONYM = new HighlightType("THESAURUS_SYNONYM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HighlightType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HighlightType FindValue(string value)
        {
            return FindValue<HighlightType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HighlightType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IndexEdition.
    /// </summary>
    public class IndexEdition : ConstantClass
    {

        /// <summary>
        /// Constant DEVELOPER_EDITION for IndexEdition
        /// </summary>
        public static readonly IndexEdition DEVELOPER_EDITION = new IndexEdition("DEVELOPER_EDITION");
        /// <summary>
        /// Constant ENTERPRISE_EDITION for IndexEdition
        /// </summary>
        public static readonly IndexEdition ENTERPRISE_EDITION = new IndexEdition("ENTERPRISE_EDITION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IndexEdition(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IndexEdition FindValue(string value)
        {
            return FindValue<IndexEdition>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IndexEdition(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IndexStatus.
    /// </summary>
    public class IndexStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for IndexStatus
        /// </summary>
        public static readonly IndexStatus ACTIVE = new IndexStatus("ACTIVE");
        /// <summary>
        /// Constant CREATING for IndexStatus
        /// </summary>
        public static readonly IndexStatus CREATING = new IndexStatus("CREATING");
        /// <summary>
        /// Constant DELETING for IndexStatus
        /// </summary>
        public static readonly IndexStatus DELETING = new IndexStatus("DELETING");
        /// <summary>
        /// Constant FAILED for IndexStatus
        /// </summary>
        public static readonly IndexStatus FAILED = new IndexStatus("FAILED");
        /// <summary>
        /// Constant SYSTEM_UPDATING for IndexStatus
        /// </summary>
        public static readonly IndexStatus SYSTEM_UPDATING = new IndexStatus("SYSTEM_UPDATING");
        /// <summary>
        /// Constant UPDATING for IndexStatus
        /// </summary>
        public static readonly IndexStatus UPDATING = new IndexStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IndexStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IndexStatus FindValue(string value)
        {
            return FindValue<IndexStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IndexStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type KeyLocation.
    /// </summary>
    public class KeyLocation : ConstantClass
    {

        /// <summary>
        /// Constant SECRET_MANAGER for KeyLocation
        /// </summary>
        public static readonly KeyLocation SECRET_MANAGER = new KeyLocation("SECRET_MANAGER");
        /// <summary>
        /// Constant URL for KeyLocation
        /// </summary>
        public static readonly KeyLocation URL = new KeyLocation("URL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public KeyLocation(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static KeyLocation FindValue(string value)
        {
            return FindValue<KeyLocation>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator KeyLocation(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Order.
    /// </summary>
    public class Order : ConstantClass
    {

        /// <summary>
        /// Constant ASCENDING for Order
        /// </summary>
        public static readonly Order ASCENDING = new Order("ASCENDING");
        /// <summary>
        /// Constant DESCENDING for Order
        /// </summary>
        public static readonly Order DESCENDING = new Order("DESCENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Order(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Order FindValue(string value)
        {
            return FindValue<Order>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Order(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PrincipalType.
    /// </summary>
    public class PrincipalType : ConstantClass
    {

        /// <summary>
        /// Constant GROUP for PrincipalType
        /// </summary>
        public static readonly PrincipalType GROUP = new PrincipalType("GROUP");
        /// <summary>
        /// Constant USER for PrincipalType
        /// </summary>
        public static readonly PrincipalType USER = new PrincipalType("USER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PrincipalType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PrincipalType FindValue(string value)
        {
            return FindValue<PrincipalType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PrincipalType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type QueryIdentifiersEnclosingOption.
    /// </summary>
    public class QueryIdentifiersEnclosingOption : ConstantClass
    {

        /// <summary>
        /// Constant DOUBLE_QUOTES for QueryIdentifiersEnclosingOption
        /// </summary>
        public static readonly QueryIdentifiersEnclosingOption DOUBLE_QUOTES = new QueryIdentifiersEnclosingOption("DOUBLE_QUOTES");
        /// <summary>
        /// Constant NONE for QueryIdentifiersEnclosingOption
        /// </summary>
        public static readonly QueryIdentifiersEnclosingOption NONE = new QueryIdentifiersEnclosingOption("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public QueryIdentifiersEnclosingOption(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static QueryIdentifiersEnclosingOption FindValue(string value)
        {
            return FindValue<QueryIdentifiersEnclosingOption>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator QueryIdentifiersEnclosingOption(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type QueryResultType.
    /// </summary>
    public class QueryResultType : ConstantClass
    {

        /// <summary>
        /// Constant ANSWER for QueryResultType
        /// </summary>
        public static readonly QueryResultType ANSWER = new QueryResultType("ANSWER");
        /// <summary>
        /// Constant DOCUMENT for QueryResultType
        /// </summary>
        public static readonly QueryResultType DOCUMENT = new QueryResultType("DOCUMENT");
        /// <summary>
        /// Constant QUESTION_ANSWER for QueryResultType
        /// </summary>
        public static readonly QueryResultType QUESTION_ANSWER = new QueryResultType("QUESTION_ANSWER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public QueryResultType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static QueryResultType FindValue(string value)
        {
            return FindValue<QueryResultType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator QueryResultType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReadAccessType.
    /// </summary>
    public class ReadAccessType : ConstantClass
    {

        /// <summary>
        /// Constant ALLOW for ReadAccessType
        /// </summary>
        public static readonly ReadAccessType ALLOW = new ReadAccessType("ALLOW");
        /// <summary>
        /// Constant DENY for ReadAccessType
        /// </summary>
        public static readonly ReadAccessType DENY = new ReadAccessType("DENY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReadAccessType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReadAccessType FindValue(string value)
        {
            return FindValue<ReadAccessType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReadAccessType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RelevanceType.
    /// </summary>
    public class RelevanceType : ConstantClass
    {

        /// <summary>
        /// Constant NOT_RELEVANT for RelevanceType
        /// </summary>
        public static readonly RelevanceType NOT_RELEVANT = new RelevanceType("NOT_RELEVANT");
        /// <summary>
        /// Constant RELEVANT for RelevanceType
        /// </summary>
        public static readonly RelevanceType RELEVANT = new RelevanceType("RELEVANT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RelevanceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RelevanceType FindValue(string value)
        {
            return FindValue<RelevanceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RelevanceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SalesforceChatterFeedIncludeFilterType.
    /// </summary>
    public class SalesforceChatterFeedIncludeFilterType : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE_USER for SalesforceChatterFeedIncludeFilterType
        /// </summary>
        public static readonly SalesforceChatterFeedIncludeFilterType ACTIVE_USER = new SalesforceChatterFeedIncludeFilterType("ACTIVE_USER");
        /// <summary>
        /// Constant STANDARD_USER for SalesforceChatterFeedIncludeFilterType
        /// </summary>
        public static readonly SalesforceChatterFeedIncludeFilterType STANDARD_USER = new SalesforceChatterFeedIncludeFilterType("STANDARD_USER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SalesforceChatterFeedIncludeFilterType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SalesforceChatterFeedIncludeFilterType FindValue(string value)
        {
            return FindValue<SalesforceChatterFeedIncludeFilterType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SalesforceChatterFeedIncludeFilterType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SalesforceKnowledgeArticleState.
    /// </summary>
    public class SalesforceKnowledgeArticleState : ConstantClass
    {

        /// <summary>
        /// Constant ARCHIVED for SalesforceKnowledgeArticleState
        /// </summary>
        public static readonly SalesforceKnowledgeArticleState ARCHIVED = new SalesforceKnowledgeArticleState("ARCHIVED");
        /// <summary>
        /// Constant DRAFT for SalesforceKnowledgeArticleState
        /// </summary>
        public static readonly SalesforceKnowledgeArticleState DRAFT = new SalesforceKnowledgeArticleState("DRAFT");
        /// <summary>
        /// Constant PUBLISHED for SalesforceKnowledgeArticleState
        /// </summary>
        public static readonly SalesforceKnowledgeArticleState PUBLISHED = new SalesforceKnowledgeArticleState("PUBLISHED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SalesforceKnowledgeArticleState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SalesforceKnowledgeArticleState FindValue(string value)
        {
            return FindValue<SalesforceKnowledgeArticleState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SalesforceKnowledgeArticleState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SalesforceStandardObjectName.
    /// </summary>
    public class SalesforceStandardObjectName : ConstantClass
    {

        /// <summary>
        /// Constant ACCOUNT for SalesforceStandardObjectName
        /// </summary>
        public static readonly SalesforceStandardObjectName ACCOUNT = new SalesforceStandardObjectName("ACCOUNT");
        /// <summary>
        /// Constant CAMPAIGN for SalesforceStandardObjectName
        /// </summary>
        public static readonly SalesforceStandardObjectName CAMPAIGN = new SalesforceStandardObjectName("CAMPAIGN");
        /// <summary>
        /// Constant CASE for SalesforceStandardObjectName
        /// </summary>
        public static readonly SalesforceStandardObjectName CASE = new SalesforceStandardObjectName("CASE");
        /// <summary>
        /// Constant CONTACT for SalesforceStandardObjectName
        /// </summary>
        public static readonly SalesforceStandardObjectName CONTACT = new SalesforceStandardObjectName("CONTACT");
        /// <summary>
        /// Constant CONTRACT for SalesforceStandardObjectName
        /// </summary>
        public static readonly SalesforceStandardObjectName CONTRACT = new SalesforceStandardObjectName("CONTRACT");
        /// <summary>
        /// Constant DOCUMENT for SalesforceStandardObjectName
        /// </summary>
        public static readonly SalesforceStandardObjectName DOCUMENT = new SalesforceStandardObjectName("DOCUMENT");
        /// <summary>
        /// Constant GROUP for SalesforceStandardObjectName
        /// </summary>
        public static readonly SalesforceStandardObjectName GROUP = new SalesforceStandardObjectName("GROUP");
        /// <summary>
        /// Constant IDEA for SalesforceStandardObjectName
        /// </summary>
        public static readonly SalesforceStandardObjectName IDEA = new SalesforceStandardObjectName("IDEA");
        /// <summary>
        /// Constant LEAD for SalesforceStandardObjectName
        /// </summary>
        public static readonly SalesforceStandardObjectName LEAD = new SalesforceStandardObjectName("LEAD");
        /// <summary>
        /// Constant OPPORTUNITY for SalesforceStandardObjectName
        /// </summary>
        public static readonly SalesforceStandardObjectName OPPORTUNITY = new SalesforceStandardObjectName("OPPORTUNITY");
        /// <summary>
        /// Constant PARTNER for SalesforceStandardObjectName
        /// </summary>
        public static readonly SalesforceStandardObjectName PARTNER = new SalesforceStandardObjectName("PARTNER");
        /// <summary>
        /// Constant PRICEBOOK for SalesforceStandardObjectName
        /// </summary>
        public static readonly SalesforceStandardObjectName PRICEBOOK = new SalesforceStandardObjectName("PRICEBOOK");
        /// <summary>
        /// Constant PRODUCT for SalesforceStandardObjectName
        /// </summary>
        public static readonly SalesforceStandardObjectName PRODUCT = new SalesforceStandardObjectName("PRODUCT");
        /// <summary>
        /// Constant PROFILE for SalesforceStandardObjectName
        /// </summary>
        public static readonly SalesforceStandardObjectName PROFILE = new SalesforceStandardObjectName("PROFILE");
        /// <summary>
        /// Constant SOLUTION for SalesforceStandardObjectName
        /// </summary>
        public static readonly SalesforceStandardObjectName SOLUTION = new SalesforceStandardObjectName("SOLUTION");
        /// <summary>
        /// Constant TASK for SalesforceStandardObjectName
        /// </summary>
        public static readonly SalesforceStandardObjectName TASK = new SalesforceStandardObjectName("TASK");
        /// <summary>
        /// Constant USER for SalesforceStandardObjectName
        /// </summary>
        public static readonly SalesforceStandardObjectName USER = new SalesforceStandardObjectName("USER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SalesforceStandardObjectName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SalesforceStandardObjectName FindValue(string value)
        {
            return FindValue<SalesforceStandardObjectName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SalesforceStandardObjectName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScoreConfidence.
    /// </summary>
    public class ScoreConfidence : ConstantClass
    {

        /// <summary>
        /// Constant HIGH for ScoreConfidence
        /// </summary>
        public static readonly ScoreConfidence HIGH = new ScoreConfidence("HIGH");
        /// <summary>
        /// Constant LOW for ScoreConfidence
        /// </summary>
        public static readonly ScoreConfidence LOW = new ScoreConfidence("LOW");
        /// <summary>
        /// Constant MEDIUM for ScoreConfidence
        /// </summary>
        public static readonly ScoreConfidence MEDIUM = new ScoreConfidence("MEDIUM");
        /// <summary>
        /// Constant VERY_HIGH for ScoreConfidence
        /// </summary>
        public static readonly ScoreConfidence VERY_HIGH = new ScoreConfidence("VERY_HIGH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScoreConfidence(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScoreConfidence FindValue(string value)
        {
            return FindValue<ScoreConfidence>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScoreConfidence(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServiceNowBuildVersionType.
    /// </summary>
    public class ServiceNowBuildVersionType : ConstantClass
    {

        /// <summary>
        /// Constant LONDON for ServiceNowBuildVersionType
        /// </summary>
        public static readonly ServiceNowBuildVersionType LONDON = new ServiceNowBuildVersionType("LONDON");
        /// <summary>
        /// Constant OTHERS for ServiceNowBuildVersionType
        /// </summary>
        public static readonly ServiceNowBuildVersionType OTHERS = new ServiceNowBuildVersionType("OTHERS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServiceNowBuildVersionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServiceNowBuildVersionType FindValue(string value)
        {
            return FindValue<ServiceNowBuildVersionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServiceNowBuildVersionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SharePointVersion.
    /// </summary>
    public class SharePointVersion : ConstantClass
    {

        /// <summary>
        /// Constant SHAREPOINT_ONLINE for SharePointVersion
        /// </summary>
        public static readonly SharePointVersion SHAREPOINT_ONLINE = new SharePointVersion("SHAREPOINT_ONLINE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SharePointVersion(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SharePointVersion FindValue(string value)
        {
            return FindValue<SharePointVersion>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SharePointVersion(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortOrder.
    /// </summary>
    public class SortOrder : ConstantClass
    {

        /// <summary>
        /// Constant ASC for SortOrder
        /// </summary>
        public static readonly SortOrder ASC = new SortOrder("ASC");
        /// <summary>
        /// Constant DESC for SortOrder
        /// </summary>
        public static readonly SortOrder DESC = new SortOrder("DESC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SortOrder(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortOrder FindValue(string value)
        {
            return FindValue<SortOrder>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortOrder(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ThesaurusStatus.
    /// </summary>
    public class ThesaurusStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ThesaurusStatus
        /// </summary>
        public static readonly ThesaurusStatus ACTIVE = new ThesaurusStatus("ACTIVE");
        /// <summary>
        /// Constant ACTIVE_BUT_UPDATE_FAILED for ThesaurusStatus
        /// </summary>
        public static readonly ThesaurusStatus ACTIVE_BUT_UPDATE_FAILED = new ThesaurusStatus("ACTIVE_BUT_UPDATE_FAILED");
        /// <summary>
        /// Constant CREATING for ThesaurusStatus
        /// </summary>
        public static readonly ThesaurusStatus CREATING = new ThesaurusStatus("CREATING");
        /// <summary>
        /// Constant DELETING for ThesaurusStatus
        /// </summary>
        public static readonly ThesaurusStatus DELETING = new ThesaurusStatus("DELETING");
        /// <summary>
        /// Constant FAILED for ThesaurusStatus
        /// </summary>
        public static readonly ThesaurusStatus FAILED = new ThesaurusStatus("FAILED");
        /// <summary>
        /// Constant UPDATING for ThesaurusStatus
        /// </summary>
        public static readonly ThesaurusStatus UPDATING = new ThesaurusStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ThesaurusStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ThesaurusStatus FindValue(string value)
        {
            return FindValue<ThesaurusStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ThesaurusStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UserContextPolicy.
    /// </summary>
    public class UserContextPolicy : ConstantClass
    {

        /// <summary>
        /// Constant ATTRIBUTE_FILTER for UserContextPolicy
        /// </summary>
        public static readonly UserContextPolicy ATTRIBUTE_FILTER = new UserContextPolicy("ATTRIBUTE_FILTER");
        /// <summary>
        /// Constant USER_TOKEN for UserContextPolicy
        /// </summary>
        public static readonly UserContextPolicy USER_TOKEN = new UserContextPolicy("USER_TOKEN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UserContextPolicy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UserContextPolicy FindValue(string value)
        {
            return FindValue<UserContextPolicy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UserContextPolicy(string value)
        {
            return FindValue(value);
        }
    }

}