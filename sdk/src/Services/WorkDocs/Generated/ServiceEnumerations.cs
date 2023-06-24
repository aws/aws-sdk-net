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
 * Do not modify this file. This file is generated from the workdocs-2016-05-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.WorkDocs
{

    /// <summary>
    /// Constants used for properties of type ActivityType.
    /// </summary>
    public class ActivityType : ConstantClass
    {

        /// <summary>
        /// Constant DOCUMENT_ANNOTATION_ADDED for ActivityType
        /// </summary>
        public static readonly ActivityType DOCUMENT_ANNOTATION_ADDED = new ActivityType("DOCUMENT_ANNOTATION_ADDED");
        /// <summary>
        /// Constant DOCUMENT_ANNOTATION_DELETED for ActivityType
        /// </summary>
        public static readonly ActivityType DOCUMENT_ANNOTATION_DELETED = new ActivityType("DOCUMENT_ANNOTATION_DELETED");
        /// <summary>
        /// Constant DOCUMENT_CHECKED_IN for ActivityType
        /// </summary>
        public static readonly ActivityType DOCUMENT_CHECKED_IN = new ActivityType("DOCUMENT_CHECKED_IN");
        /// <summary>
        /// Constant DOCUMENT_CHECKED_OUT for ActivityType
        /// </summary>
        public static readonly ActivityType DOCUMENT_CHECKED_OUT = new ActivityType("DOCUMENT_CHECKED_OUT");
        /// <summary>
        /// Constant DOCUMENT_COMMENT_ADDED for ActivityType
        /// </summary>
        public static readonly ActivityType DOCUMENT_COMMENT_ADDED = new ActivityType("DOCUMENT_COMMENT_ADDED");
        /// <summary>
        /// Constant DOCUMENT_COMMENT_DELETED for ActivityType
        /// </summary>
        public static readonly ActivityType DOCUMENT_COMMENT_DELETED = new ActivityType("DOCUMENT_COMMENT_DELETED");
        /// <summary>
        /// Constant DOCUMENT_MOVED for ActivityType
        /// </summary>
        public static readonly ActivityType DOCUMENT_MOVED = new ActivityType("DOCUMENT_MOVED");
        /// <summary>
        /// Constant DOCUMENT_RECYCLED for ActivityType
        /// </summary>
        public static readonly ActivityType DOCUMENT_RECYCLED = new ActivityType("DOCUMENT_RECYCLED");
        /// <summary>
        /// Constant DOCUMENT_RENAMED for ActivityType
        /// </summary>
        public static readonly ActivityType DOCUMENT_RENAMED = new ActivityType("DOCUMENT_RENAMED");
        /// <summary>
        /// Constant DOCUMENT_RESTORED for ActivityType
        /// </summary>
        public static readonly ActivityType DOCUMENT_RESTORED = new ActivityType("DOCUMENT_RESTORED");
        /// <summary>
        /// Constant DOCUMENT_REVERTED for ActivityType
        /// </summary>
        public static readonly ActivityType DOCUMENT_REVERTED = new ActivityType("DOCUMENT_REVERTED");
        /// <summary>
        /// Constant DOCUMENT_SHARE_PERMISSION_CHANGED for ActivityType
        /// </summary>
        public static readonly ActivityType DOCUMENT_SHARE_PERMISSION_CHANGED = new ActivityType("DOCUMENT_SHARE_PERMISSION_CHANGED");
        /// <summary>
        /// Constant DOCUMENT_SHAREABLE_LINK_CREATED for ActivityType
        /// </summary>
        public static readonly ActivityType DOCUMENT_SHAREABLE_LINK_CREATED = new ActivityType("DOCUMENT_SHAREABLE_LINK_CREATED");
        /// <summary>
        /// Constant DOCUMENT_SHAREABLE_LINK_PERMISSION_CHANGED for ActivityType
        /// </summary>
        public static readonly ActivityType DOCUMENT_SHAREABLE_LINK_PERMISSION_CHANGED = new ActivityType("DOCUMENT_SHAREABLE_LINK_PERMISSION_CHANGED");
        /// <summary>
        /// Constant DOCUMENT_SHAREABLE_LINK_REMOVED for ActivityType
        /// </summary>
        public static readonly ActivityType DOCUMENT_SHAREABLE_LINK_REMOVED = new ActivityType("DOCUMENT_SHAREABLE_LINK_REMOVED");
        /// <summary>
        /// Constant DOCUMENT_SHARED for ActivityType
        /// </summary>
        public static readonly ActivityType DOCUMENT_SHARED = new ActivityType("DOCUMENT_SHARED");
        /// <summary>
        /// Constant DOCUMENT_UNSHARED for ActivityType
        /// </summary>
        public static readonly ActivityType DOCUMENT_UNSHARED = new ActivityType("DOCUMENT_UNSHARED");
        /// <summary>
        /// Constant DOCUMENT_VERSION_DELETED for ActivityType
        /// </summary>
        public static readonly ActivityType DOCUMENT_VERSION_DELETED = new ActivityType("DOCUMENT_VERSION_DELETED");
        /// <summary>
        /// Constant DOCUMENT_VERSION_DOWNLOADED for ActivityType
        /// </summary>
        public static readonly ActivityType DOCUMENT_VERSION_DOWNLOADED = new ActivityType("DOCUMENT_VERSION_DOWNLOADED");
        /// <summary>
        /// Constant DOCUMENT_VERSION_UPLOADED for ActivityType
        /// </summary>
        public static readonly ActivityType DOCUMENT_VERSION_UPLOADED = new ActivityType("DOCUMENT_VERSION_UPLOADED");
        /// <summary>
        /// Constant DOCUMENT_VERSION_VIEWED for ActivityType
        /// </summary>
        public static readonly ActivityType DOCUMENT_VERSION_VIEWED = new ActivityType("DOCUMENT_VERSION_VIEWED");
        /// <summary>
        /// Constant FOLDER_CREATED for ActivityType
        /// </summary>
        public static readonly ActivityType FOLDER_CREATED = new ActivityType("FOLDER_CREATED");
        /// <summary>
        /// Constant FOLDER_DELETED for ActivityType
        /// </summary>
        public static readonly ActivityType FOLDER_DELETED = new ActivityType("FOLDER_DELETED");
        /// <summary>
        /// Constant FOLDER_MOVED for ActivityType
        /// </summary>
        public static readonly ActivityType FOLDER_MOVED = new ActivityType("FOLDER_MOVED");
        /// <summary>
        /// Constant FOLDER_RECYCLED for ActivityType
        /// </summary>
        public static readonly ActivityType FOLDER_RECYCLED = new ActivityType("FOLDER_RECYCLED");
        /// <summary>
        /// Constant FOLDER_RENAMED for ActivityType
        /// </summary>
        public static readonly ActivityType FOLDER_RENAMED = new ActivityType("FOLDER_RENAMED");
        /// <summary>
        /// Constant FOLDER_RESTORED for ActivityType
        /// </summary>
        public static readonly ActivityType FOLDER_RESTORED = new ActivityType("FOLDER_RESTORED");
        /// <summary>
        /// Constant FOLDER_SHARE_PERMISSION_CHANGED for ActivityType
        /// </summary>
        public static readonly ActivityType FOLDER_SHARE_PERMISSION_CHANGED = new ActivityType("FOLDER_SHARE_PERMISSION_CHANGED");
        /// <summary>
        /// Constant FOLDER_SHAREABLE_LINK_CREATED for ActivityType
        /// </summary>
        public static readonly ActivityType FOLDER_SHAREABLE_LINK_CREATED = new ActivityType("FOLDER_SHAREABLE_LINK_CREATED");
        /// <summary>
        /// Constant FOLDER_SHAREABLE_LINK_PERMISSION_CHANGED for ActivityType
        /// </summary>
        public static readonly ActivityType FOLDER_SHAREABLE_LINK_PERMISSION_CHANGED = new ActivityType("FOLDER_SHAREABLE_LINK_PERMISSION_CHANGED");
        /// <summary>
        /// Constant FOLDER_SHAREABLE_LINK_REMOVED for ActivityType
        /// </summary>
        public static readonly ActivityType FOLDER_SHAREABLE_LINK_REMOVED = new ActivityType("FOLDER_SHAREABLE_LINK_REMOVED");
        /// <summary>
        /// Constant FOLDER_SHARED for ActivityType
        /// </summary>
        public static readonly ActivityType FOLDER_SHARED = new ActivityType("FOLDER_SHARED");
        /// <summary>
        /// Constant FOLDER_UNSHARED for ActivityType
        /// </summary>
        public static readonly ActivityType FOLDER_UNSHARED = new ActivityType("FOLDER_UNSHARED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ActivityType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ActivityType FindValue(string value)
        {
            return FindValue<ActivityType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ActivityType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AdditionalResponseFieldType.
    /// </summary>
    public class AdditionalResponseFieldType : ConstantClass
    {

        /// <summary>
        /// Constant WEBURL for AdditionalResponseFieldType
        /// </summary>
        public static readonly AdditionalResponseFieldType WEBURL = new AdditionalResponseFieldType("WEBURL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AdditionalResponseFieldType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AdditionalResponseFieldType FindValue(string value)
        {
            return FindValue<AdditionalResponseFieldType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AdditionalResponseFieldType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BooleanEnumType.
    /// </summary>
    public class BooleanEnumType : ConstantClass
    {

        /// <summary>
        /// Constant FALSE for BooleanEnumType
        /// </summary>
        public static readonly BooleanEnumType FALSE = new BooleanEnumType("FALSE");
        /// <summary>
        /// Constant TRUE for BooleanEnumType
        /// </summary>
        public static readonly BooleanEnumType TRUE = new BooleanEnumType("TRUE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BooleanEnumType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BooleanEnumType FindValue(string value)
        {
            return FindValue<BooleanEnumType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BooleanEnumType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CommentStatusType.
    /// </summary>
    public class CommentStatusType : ConstantClass
    {

        /// <summary>
        /// Constant DELETED for CommentStatusType
        /// </summary>
        public static readonly CommentStatusType DELETED = new CommentStatusType("DELETED");
        /// <summary>
        /// Constant DRAFT for CommentStatusType
        /// </summary>
        public static readonly CommentStatusType DRAFT = new CommentStatusType("DRAFT");
        /// <summary>
        /// Constant PUBLISHED for CommentStatusType
        /// </summary>
        public static readonly CommentStatusType PUBLISHED = new CommentStatusType("PUBLISHED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CommentStatusType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CommentStatusType FindValue(string value)
        {
            return FindValue<CommentStatusType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CommentStatusType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CommentVisibilityType.
    /// </summary>
    public class CommentVisibilityType : ConstantClass
    {

        /// <summary>
        /// Constant PRIVATE for CommentVisibilityType
        /// </summary>
        public static readonly CommentVisibilityType PRIVATE = new CommentVisibilityType("PRIVATE");
        /// <summary>
        /// Constant PUBLIC for CommentVisibilityType
        /// </summary>
        public static readonly CommentVisibilityType PUBLIC = new CommentVisibilityType("PUBLIC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CommentVisibilityType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CommentVisibilityType FindValue(string value)
        {
            return FindValue<CommentVisibilityType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CommentVisibilityType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContentCategoryType.
    /// </summary>
    public class ContentCategoryType : ConstantClass
    {

        /// <summary>
        /// Constant AUDIO for ContentCategoryType
        /// </summary>
        public static readonly ContentCategoryType AUDIO = new ContentCategoryType("AUDIO");
        /// <summary>
        /// Constant DOCUMENT for ContentCategoryType
        /// </summary>
        public static readonly ContentCategoryType DOCUMENT = new ContentCategoryType("DOCUMENT");
        /// <summary>
        /// Constant IMAGE for ContentCategoryType
        /// </summary>
        public static readonly ContentCategoryType IMAGE = new ContentCategoryType("IMAGE");
        /// <summary>
        /// Constant OTHER for ContentCategoryType
        /// </summary>
        public static readonly ContentCategoryType OTHER = new ContentCategoryType("OTHER");
        /// <summary>
        /// Constant PDF for ContentCategoryType
        /// </summary>
        public static readonly ContentCategoryType PDF = new ContentCategoryType("PDF");
        /// <summary>
        /// Constant PRESENTATION for ContentCategoryType
        /// </summary>
        public static readonly ContentCategoryType PRESENTATION = new ContentCategoryType("PRESENTATION");
        /// <summary>
        /// Constant SOURCE_CODE for ContentCategoryType
        /// </summary>
        public static readonly ContentCategoryType SOURCE_CODE = new ContentCategoryType("SOURCE_CODE");
        /// <summary>
        /// Constant SPREADSHEET for ContentCategoryType
        /// </summary>
        public static readonly ContentCategoryType SPREADSHEET = new ContentCategoryType("SPREADSHEET");
        /// <summary>
        /// Constant VIDEO for ContentCategoryType
        /// </summary>
        public static readonly ContentCategoryType VIDEO = new ContentCategoryType("VIDEO");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContentCategoryType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContentCategoryType FindValue(string value)
        {
            return FindValue<ContentCategoryType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContentCategoryType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DocumentSourceType.
    /// </summary>
    public class DocumentSourceType : ConstantClass
    {

        /// <summary>
        /// Constant ORIGINAL for DocumentSourceType
        /// </summary>
        public static readonly DocumentSourceType ORIGINAL = new DocumentSourceType("ORIGINAL");
        /// <summary>
        /// Constant WITH_COMMENTS for DocumentSourceType
        /// </summary>
        public static readonly DocumentSourceType WITH_COMMENTS = new DocumentSourceType("WITH_COMMENTS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DocumentSourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DocumentSourceType FindValue(string value)
        {
            return FindValue<DocumentSourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DocumentSourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DocumentStatusType.
    /// </summary>
    public class DocumentStatusType : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for DocumentStatusType
        /// </summary>
        public static readonly DocumentStatusType ACTIVE = new DocumentStatusType("ACTIVE");
        /// <summary>
        /// Constant INITIALIZED for DocumentStatusType
        /// </summary>
        public static readonly DocumentStatusType INITIALIZED = new DocumentStatusType("INITIALIZED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DocumentStatusType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DocumentStatusType FindValue(string value)
        {
            return FindValue<DocumentStatusType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DocumentStatusType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DocumentThumbnailType.
    /// </summary>
    public class DocumentThumbnailType : ConstantClass
    {

        /// <summary>
        /// Constant LARGE for DocumentThumbnailType
        /// </summary>
        public static readonly DocumentThumbnailType LARGE = new DocumentThumbnailType("LARGE");
        /// <summary>
        /// Constant SMALL for DocumentThumbnailType
        /// </summary>
        public static readonly DocumentThumbnailType SMALL = new DocumentThumbnailType("SMALL");
        /// <summary>
        /// Constant SMALL_HQ for DocumentThumbnailType
        /// </summary>
        public static readonly DocumentThumbnailType SMALL_HQ = new DocumentThumbnailType("SMALL_HQ");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DocumentThumbnailType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DocumentThumbnailType FindValue(string value)
        {
            return FindValue<DocumentThumbnailType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DocumentThumbnailType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DocumentVersionStatus.
    /// </summary>
    public class DocumentVersionStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for DocumentVersionStatus
        /// </summary>
        public static readonly DocumentVersionStatus ACTIVE = new DocumentVersionStatus("ACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DocumentVersionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DocumentVersionStatus FindValue(string value)
        {
            return FindValue<DocumentVersionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DocumentVersionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FolderContentType.
    /// </summary>
    public class FolderContentType : ConstantClass
    {

        /// <summary>
        /// Constant ALL for FolderContentType
        /// </summary>
        public static readonly FolderContentType ALL = new FolderContentType("ALL");
        /// <summary>
        /// Constant DOCUMENT for FolderContentType
        /// </summary>
        public static readonly FolderContentType DOCUMENT = new FolderContentType("DOCUMENT");
        /// <summary>
        /// Constant FOLDER for FolderContentType
        /// </summary>
        public static readonly FolderContentType FOLDER = new FolderContentType("FOLDER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FolderContentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FolderContentType FindValue(string value)
        {
            return FindValue<FolderContentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FolderContentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LanguageCodeType.
    /// </summary>
    public class LanguageCodeType : ConstantClass
    {

        /// <summary>
        /// Constant AR for LanguageCodeType
        /// </summary>
        public static readonly LanguageCodeType AR = new LanguageCodeType("AR");
        /// <summary>
        /// Constant BG for LanguageCodeType
        /// </summary>
        public static readonly LanguageCodeType BG = new LanguageCodeType("BG");
        /// <summary>
        /// Constant BN for LanguageCodeType
        /// </summary>
        public static readonly LanguageCodeType BN = new LanguageCodeType("BN");
        /// <summary>
        /// Constant CS for LanguageCodeType
        /// </summary>
        public static readonly LanguageCodeType CS = new LanguageCodeType("CS");
        /// <summary>
        /// Constant DA for LanguageCodeType
        /// </summary>
        public static readonly LanguageCodeType DA = new LanguageCodeType("DA");
        /// <summary>
        /// Constant DE for LanguageCodeType
        /// </summary>
        public static readonly LanguageCodeType DE = new LanguageCodeType("DE");
        /// <summary>
        /// Constant DEFAULT for LanguageCodeType
        /// </summary>
        public static readonly LanguageCodeType DEFAULT = new LanguageCodeType("DEFAULT");
        /// <summary>
        /// Constant EL for LanguageCodeType
        /// </summary>
        public static readonly LanguageCodeType EL = new LanguageCodeType("EL");
        /// <summary>
        /// Constant EN for LanguageCodeType
        /// </summary>
        public static readonly LanguageCodeType EN = new LanguageCodeType("EN");
        /// <summary>
        /// Constant ES for LanguageCodeType
        /// </summary>
        public static readonly LanguageCodeType ES = new LanguageCodeType("ES");
        /// <summary>
        /// Constant FA for LanguageCodeType
        /// </summary>
        public static readonly LanguageCodeType FA = new LanguageCodeType("FA");
        /// <summary>
        /// Constant FI for LanguageCodeType
        /// </summary>
        public static readonly LanguageCodeType FI = new LanguageCodeType("FI");
        /// <summary>
        /// Constant FR for LanguageCodeType
        /// </summary>
        public static readonly LanguageCodeType FR = new LanguageCodeType("FR");
        /// <summary>
        /// Constant HI for LanguageCodeType
        /// </summary>
        public static readonly LanguageCodeType HI = new LanguageCodeType("HI");
        /// <summary>
        /// Constant HU for LanguageCodeType
        /// </summary>
        public static readonly LanguageCodeType HU = new LanguageCodeType("HU");
        /// <summary>
        /// Constant ID for LanguageCodeType
        /// </summary>
        public static readonly LanguageCodeType ID = new LanguageCodeType("ID");
        /// <summary>
        /// Constant IT for LanguageCodeType
        /// </summary>
        public static readonly LanguageCodeType IT = new LanguageCodeType("IT");
        /// <summary>
        /// Constant JA for LanguageCodeType
        /// </summary>
        public static readonly LanguageCodeType JA = new LanguageCodeType("JA");
        /// <summary>
        /// Constant KO for LanguageCodeType
        /// </summary>
        public static readonly LanguageCodeType KO = new LanguageCodeType("KO");
        /// <summary>
        /// Constant LT for LanguageCodeType
        /// </summary>
        public static readonly LanguageCodeType LT = new LanguageCodeType("LT");
        /// <summary>
        /// Constant LV for LanguageCodeType
        /// </summary>
        public static readonly LanguageCodeType LV = new LanguageCodeType("LV");
        /// <summary>
        /// Constant NL for LanguageCodeType
        /// </summary>
        public static readonly LanguageCodeType NL = new LanguageCodeType("NL");
        /// <summary>
        /// Constant NO for LanguageCodeType
        /// </summary>
        public static readonly LanguageCodeType NO = new LanguageCodeType("NO");
        /// <summary>
        /// Constant PT for LanguageCodeType
        /// </summary>
        public static readonly LanguageCodeType PT = new LanguageCodeType("PT");
        /// <summary>
        /// Constant RO for LanguageCodeType
        /// </summary>
        public static readonly LanguageCodeType RO = new LanguageCodeType("RO");
        /// <summary>
        /// Constant RU for LanguageCodeType
        /// </summary>
        public static readonly LanguageCodeType RU = new LanguageCodeType("RU");
        /// <summary>
        /// Constant SV for LanguageCodeType
        /// </summary>
        public static readonly LanguageCodeType SV = new LanguageCodeType("SV");
        /// <summary>
        /// Constant SW for LanguageCodeType
        /// </summary>
        public static readonly LanguageCodeType SW = new LanguageCodeType("SW");
        /// <summary>
        /// Constant TH for LanguageCodeType
        /// </summary>
        public static readonly LanguageCodeType TH = new LanguageCodeType("TH");
        /// <summary>
        /// Constant TR for LanguageCodeType
        /// </summary>
        public static readonly LanguageCodeType TR = new LanguageCodeType("TR");
        /// <summary>
        /// Constant ZH for LanguageCodeType
        /// </summary>
        public static readonly LanguageCodeType ZH = new LanguageCodeType("ZH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LanguageCodeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LanguageCodeType FindValue(string value)
        {
            return FindValue<LanguageCodeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LanguageCodeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LocaleType.
    /// </summary>
    public class LocaleType : ConstantClass
    {

        /// <summary>
        /// Constant De for LocaleType
        /// </summary>
        public static readonly LocaleType De = new LocaleType("de");
        /// <summary>
        /// Constant Default for LocaleType
        /// </summary>
        public static readonly LocaleType Default = new LocaleType("default");
        /// <summary>
        /// Constant En for LocaleType
        /// </summary>
        public static readonly LocaleType En = new LocaleType("en");
        /// <summary>
        /// Constant Es for LocaleType
        /// </summary>
        public static readonly LocaleType Es = new LocaleType("es");
        /// <summary>
        /// Constant Fr for LocaleType
        /// </summary>
        public static readonly LocaleType Fr = new LocaleType("fr");
        /// <summary>
        /// Constant Ja for LocaleType
        /// </summary>
        public static readonly LocaleType Ja = new LocaleType("ja");
        /// <summary>
        /// Constant Ko for LocaleType
        /// </summary>
        public static readonly LocaleType Ko = new LocaleType("ko");
        /// <summary>
        /// Constant Pt_BR for LocaleType
        /// </summary>
        public static readonly LocaleType Pt_BR = new LocaleType("pt_BR");
        /// <summary>
        /// Constant Ru for LocaleType
        /// </summary>
        public static readonly LocaleType Ru = new LocaleType("ru");
        /// <summary>
        /// Constant Zh_CN for LocaleType
        /// </summary>
        public static readonly LocaleType Zh_CN = new LocaleType("zh_CN");
        /// <summary>
        /// Constant Zh_TW for LocaleType
        /// </summary>
        public static readonly LocaleType Zh_TW = new LocaleType("zh_TW");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LocaleType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LocaleType FindValue(string value)
        {
            return FindValue<LocaleType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LocaleType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OrderByFieldType.
    /// </summary>
    public class OrderByFieldType : ConstantClass
    {

        /// <summary>
        /// Constant CREATED_TIMESTAMP for OrderByFieldType
        /// </summary>
        public static readonly OrderByFieldType CREATED_TIMESTAMP = new OrderByFieldType("CREATED_TIMESTAMP");
        /// <summary>
        /// Constant MODIFIED_TIMESTAMP for OrderByFieldType
        /// </summary>
        public static readonly OrderByFieldType MODIFIED_TIMESTAMP = new OrderByFieldType("MODIFIED_TIMESTAMP");
        /// <summary>
        /// Constant NAME for OrderByFieldType
        /// </summary>
        public static readonly OrderByFieldType NAME = new OrderByFieldType("NAME");
        /// <summary>
        /// Constant RELEVANCE for OrderByFieldType
        /// </summary>
        public static readonly OrderByFieldType RELEVANCE = new OrderByFieldType("RELEVANCE");
        /// <summary>
        /// Constant SIZE for OrderByFieldType
        /// </summary>
        public static readonly OrderByFieldType SIZE = new OrderByFieldType("SIZE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OrderByFieldType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OrderByFieldType FindValue(string value)
        {
            return FindValue<OrderByFieldType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OrderByFieldType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OrderType.
    /// </summary>
    public class OrderType : ConstantClass
    {

        /// <summary>
        /// Constant ASCENDING for OrderType
        /// </summary>
        public static readonly OrderType ASCENDING = new OrderType("ASCENDING");
        /// <summary>
        /// Constant DESCENDING for OrderType
        /// </summary>
        public static readonly OrderType DESCENDING = new OrderType("DESCENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OrderType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OrderType FindValue(string value)
        {
            return FindValue<OrderType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OrderType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PrincipalRoleType.
    /// </summary>
    public class PrincipalRoleType : ConstantClass
    {

        /// <summary>
        /// Constant CONTRIBUTOR for PrincipalRoleType
        /// </summary>
        public static readonly PrincipalRoleType CONTRIBUTOR = new PrincipalRoleType("CONTRIBUTOR");
        /// <summary>
        /// Constant COOWNER for PrincipalRoleType
        /// </summary>
        public static readonly PrincipalRoleType COOWNER = new PrincipalRoleType("COOWNER");
        /// <summary>
        /// Constant OWNER for PrincipalRoleType
        /// </summary>
        public static readonly PrincipalRoleType OWNER = new PrincipalRoleType("OWNER");
        /// <summary>
        /// Constant VIEWER for PrincipalRoleType
        /// </summary>
        public static readonly PrincipalRoleType VIEWER = new PrincipalRoleType("VIEWER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PrincipalRoleType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PrincipalRoleType FindValue(string value)
        {
            return FindValue<PrincipalRoleType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PrincipalRoleType(string value)
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
        /// Constant ANONYMOUS for PrincipalType
        /// </summary>
        public static readonly PrincipalType ANONYMOUS = new PrincipalType("ANONYMOUS");
        /// <summary>
        /// Constant GROUP for PrincipalType
        /// </summary>
        public static readonly PrincipalType GROUP = new PrincipalType("GROUP");
        /// <summary>
        /// Constant INVITE for PrincipalType
        /// </summary>
        public static readonly PrincipalType INVITE = new PrincipalType("INVITE");
        /// <summary>
        /// Constant ORGANIZATION for PrincipalType
        /// </summary>
        public static readonly PrincipalType ORGANIZATION = new PrincipalType("ORGANIZATION");
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
    /// Constants used for properties of type ResourceCollectionType.
    /// </summary>
    public class ResourceCollectionType : ConstantClass
    {

        /// <summary>
        /// Constant SHARED_WITH_ME for ResourceCollectionType
        /// </summary>
        public static readonly ResourceCollectionType SHARED_WITH_ME = new ResourceCollectionType("SHARED_WITH_ME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceCollectionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceCollectionType FindValue(string value)
        {
            return FindValue<ResourceCollectionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceCollectionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceSortType.
    /// </summary>
    public class ResourceSortType : ConstantClass
    {

        /// <summary>
        /// Constant DATE for ResourceSortType
        /// </summary>
        public static readonly ResourceSortType DATE = new ResourceSortType("DATE");
        /// <summary>
        /// Constant NAME for ResourceSortType
        /// </summary>
        public static readonly ResourceSortType NAME = new ResourceSortType("NAME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceSortType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceSortType FindValue(string value)
        {
            return FindValue<ResourceSortType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceSortType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceStateType.
    /// </summary>
    public class ResourceStateType : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ResourceStateType
        /// </summary>
        public static readonly ResourceStateType ACTIVE = new ResourceStateType("ACTIVE");
        /// <summary>
        /// Constant RECYCLED for ResourceStateType
        /// </summary>
        public static readonly ResourceStateType RECYCLED = new ResourceStateType("RECYCLED");
        /// <summary>
        /// Constant RECYCLING for ResourceStateType
        /// </summary>
        public static readonly ResourceStateType RECYCLING = new ResourceStateType("RECYCLING");
        /// <summary>
        /// Constant RESTORING for ResourceStateType
        /// </summary>
        public static readonly ResourceStateType RESTORING = new ResourceStateType("RESTORING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceStateType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceStateType FindValue(string value)
        {
            return FindValue<ResourceStateType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceStateType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceType.
    /// </summary>
    public class ResourceType : ConstantClass
    {

        /// <summary>
        /// Constant DOCUMENT for ResourceType
        /// </summary>
        public static readonly ResourceType DOCUMENT = new ResourceType("DOCUMENT");
        /// <summary>
        /// Constant FOLDER for ResourceType
        /// </summary>
        public static readonly ResourceType FOLDER = new ResourceType("FOLDER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceType FindValue(string value)
        {
            return FindValue<ResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResponseItemType.
    /// </summary>
    public class ResponseItemType : ConstantClass
    {

        /// <summary>
        /// Constant COMMENT for ResponseItemType
        /// </summary>
        public static readonly ResponseItemType COMMENT = new ResponseItemType("COMMENT");
        /// <summary>
        /// Constant DOCUMENT for ResponseItemType
        /// </summary>
        public static readonly ResponseItemType DOCUMENT = new ResponseItemType("DOCUMENT");
        /// <summary>
        /// Constant DOCUMENT_VERSION for ResponseItemType
        /// </summary>
        public static readonly ResponseItemType DOCUMENT_VERSION = new ResponseItemType("DOCUMENT_VERSION");
        /// <summary>
        /// Constant FOLDER for ResponseItemType
        /// </summary>
        public static readonly ResponseItemType FOLDER = new ResponseItemType("FOLDER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResponseItemType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResponseItemType FindValue(string value)
        {
            return FindValue<ResponseItemType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResponseItemType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RolePermissionType.
    /// </summary>
    public class RolePermissionType : ConstantClass
    {

        /// <summary>
        /// Constant DIRECT for RolePermissionType
        /// </summary>
        public static readonly RolePermissionType DIRECT = new RolePermissionType("DIRECT");
        /// <summary>
        /// Constant INHERITED for RolePermissionType
        /// </summary>
        public static readonly RolePermissionType INHERITED = new RolePermissionType("INHERITED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RolePermissionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RolePermissionType FindValue(string value)
        {
            return FindValue<RolePermissionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RolePermissionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RoleType.
    /// </summary>
    public class RoleType : ConstantClass
    {

        /// <summary>
        /// Constant CONTRIBUTOR for RoleType
        /// </summary>
        public static readonly RoleType CONTRIBUTOR = new RoleType("CONTRIBUTOR");
        /// <summary>
        /// Constant COOWNER for RoleType
        /// </summary>
        public static readonly RoleType COOWNER = new RoleType("COOWNER");
        /// <summary>
        /// Constant OWNER for RoleType
        /// </summary>
        public static readonly RoleType OWNER = new RoleType("OWNER");
        /// <summary>
        /// Constant VIEWER for RoleType
        /// </summary>
        public static readonly RoleType VIEWER = new RoleType("VIEWER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RoleType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RoleType FindValue(string value)
        {
            return FindValue<RoleType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RoleType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SearchCollectionType.
    /// </summary>
    public class SearchCollectionType : ConstantClass
    {

        /// <summary>
        /// Constant OWNED for SearchCollectionType
        /// </summary>
        public static readonly SearchCollectionType OWNED = new SearchCollectionType("OWNED");
        /// <summary>
        /// Constant SHARED_WITH_ME for SearchCollectionType
        /// </summary>
        public static readonly SearchCollectionType SHARED_WITH_ME = new SearchCollectionType("SHARED_WITH_ME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SearchCollectionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SearchCollectionType FindValue(string value)
        {
            return FindValue<SearchCollectionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SearchCollectionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SearchQueryScopeType.
    /// </summary>
    public class SearchQueryScopeType : ConstantClass
    {

        /// <summary>
        /// Constant CONTENT for SearchQueryScopeType
        /// </summary>
        public static readonly SearchQueryScopeType CONTENT = new SearchQueryScopeType("CONTENT");
        /// <summary>
        /// Constant NAME for SearchQueryScopeType
        /// </summary>
        public static readonly SearchQueryScopeType NAME = new SearchQueryScopeType("NAME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SearchQueryScopeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SearchQueryScopeType FindValue(string value)
        {
            return FindValue<SearchQueryScopeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SearchQueryScopeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SearchResourceType.
    /// </summary>
    public class SearchResourceType : ConstantClass
    {

        /// <summary>
        /// Constant COMMENT for SearchResourceType
        /// </summary>
        public static readonly SearchResourceType COMMENT = new SearchResourceType("COMMENT");
        /// <summary>
        /// Constant DOCUMENT for SearchResourceType
        /// </summary>
        public static readonly SearchResourceType DOCUMENT = new SearchResourceType("DOCUMENT");
        /// <summary>
        /// Constant DOCUMENT_VERSION for SearchResourceType
        /// </summary>
        public static readonly SearchResourceType DOCUMENT_VERSION = new SearchResourceType("DOCUMENT_VERSION");
        /// <summary>
        /// Constant FOLDER for SearchResourceType
        /// </summary>
        public static readonly SearchResourceType FOLDER = new SearchResourceType("FOLDER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SearchResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SearchResourceType FindValue(string value)
        {
            return FindValue<SearchResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SearchResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ShareStatusType.
    /// </summary>
    public class ShareStatusType : ConstantClass
    {

        /// <summary>
        /// Constant FAILURE for ShareStatusType
        /// </summary>
        public static readonly ShareStatusType FAILURE = new ShareStatusType("FAILURE");
        /// <summary>
        /// Constant SUCCESS for ShareStatusType
        /// </summary>
        public static readonly ShareStatusType SUCCESS = new ShareStatusType("SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ShareStatusType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ShareStatusType FindValue(string value)
        {
            return FindValue<ShareStatusType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ShareStatusType(string value)
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
    /// Constants used for properties of type StorageType.
    /// </summary>
    public class StorageType : ConstantClass
    {

        /// <summary>
        /// Constant QUOTA for StorageType
        /// </summary>
        public static readonly StorageType QUOTA = new StorageType("QUOTA");
        /// <summary>
        /// Constant UNLIMITED for StorageType
        /// </summary>
        public static readonly StorageType UNLIMITED = new StorageType("UNLIMITED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StorageType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StorageType FindValue(string value)
        {
            return FindValue<StorageType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StorageType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SubscriptionProtocolType.
    /// </summary>
    public class SubscriptionProtocolType : ConstantClass
    {

        /// <summary>
        /// Constant HTTPS for SubscriptionProtocolType
        /// </summary>
        public static readonly SubscriptionProtocolType HTTPS = new SubscriptionProtocolType("HTTPS");
        /// <summary>
        /// Constant SQS for SubscriptionProtocolType
        /// </summary>
        public static readonly SubscriptionProtocolType SQS = new SubscriptionProtocolType("SQS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SubscriptionProtocolType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SubscriptionProtocolType FindValue(string value)
        {
            return FindValue<SubscriptionProtocolType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SubscriptionProtocolType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SubscriptionType.
    /// </summary>
    public class SubscriptionType : ConstantClass
    {

        /// <summary>
        /// Constant ALL for SubscriptionType
        /// </summary>
        public static readonly SubscriptionType ALL = new SubscriptionType("ALL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SubscriptionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SubscriptionType FindValue(string value)
        {
            return FindValue<SubscriptionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SubscriptionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UserFilterType.
    /// </summary>
    public class UserFilterType : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE_PENDING for UserFilterType
        /// </summary>
        public static readonly UserFilterType ACTIVE_PENDING = new UserFilterType("ACTIVE_PENDING");
        /// <summary>
        /// Constant ALL for UserFilterType
        /// </summary>
        public static readonly UserFilterType ALL = new UserFilterType("ALL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UserFilterType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UserFilterType FindValue(string value)
        {
            return FindValue<UserFilterType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UserFilterType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UserSortType.
    /// </summary>
    public class UserSortType : ConstantClass
    {

        /// <summary>
        /// Constant FULL_NAME for UserSortType
        /// </summary>
        public static readonly UserSortType FULL_NAME = new UserSortType("FULL_NAME");
        /// <summary>
        /// Constant STORAGE_LIMIT for UserSortType
        /// </summary>
        public static readonly UserSortType STORAGE_LIMIT = new UserSortType("STORAGE_LIMIT");
        /// <summary>
        /// Constant STORAGE_USED for UserSortType
        /// </summary>
        public static readonly UserSortType STORAGE_USED = new UserSortType("STORAGE_USED");
        /// <summary>
        /// Constant USER_NAME for UserSortType
        /// </summary>
        public static readonly UserSortType USER_NAME = new UserSortType("USER_NAME");
        /// <summary>
        /// Constant USER_STATUS for UserSortType
        /// </summary>
        public static readonly UserSortType USER_STATUS = new UserSortType("USER_STATUS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UserSortType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UserSortType FindValue(string value)
        {
            return FindValue<UserSortType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UserSortType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UserStatusType.
    /// </summary>
    public class UserStatusType : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for UserStatusType
        /// </summary>
        public static readonly UserStatusType ACTIVE = new UserStatusType("ACTIVE");
        /// <summary>
        /// Constant INACTIVE for UserStatusType
        /// </summary>
        public static readonly UserStatusType INACTIVE = new UserStatusType("INACTIVE");
        /// <summary>
        /// Constant PENDING for UserStatusType
        /// </summary>
        public static readonly UserStatusType PENDING = new UserStatusType("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UserStatusType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UserStatusType FindValue(string value)
        {
            return FindValue<UserStatusType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UserStatusType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UserType.
    /// </summary>
    public class UserType : ConstantClass
    {

        /// <summary>
        /// Constant ADMIN for UserType
        /// </summary>
        public static readonly UserType ADMIN = new UserType("ADMIN");
        /// <summary>
        /// Constant MINIMALUSER for UserType
        /// </summary>
        public static readonly UserType MINIMALUSER = new UserType("MINIMALUSER");
        /// <summary>
        /// Constant POWERUSER for UserType
        /// </summary>
        public static readonly UserType POWERUSER = new UserType("POWERUSER");
        /// <summary>
        /// Constant USER for UserType
        /// </summary>
        public static readonly UserType USER = new UserType("USER");
        /// <summary>
        /// Constant WORKSPACESUSER for UserType
        /// </summary>
        public static readonly UserType WORKSPACESUSER = new UserType("WORKSPACESUSER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UserType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UserType FindValue(string value)
        {
            return FindValue<UserType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UserType(string value)
        {
            return FindValue(value);
        }
    }

}