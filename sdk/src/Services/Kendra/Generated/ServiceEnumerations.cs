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
        /// Constant DATABASE for DataSourceType
        /// </summary>
        public static readonly DataSourceType DATABASE = new DataSourceType("DATABASE");
        /// <summary>
        /// Constant S3 for DataSourceType
        /// </summary>
        public static readonly DataSourceType S3 = new DataSourceType("S3");
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

}