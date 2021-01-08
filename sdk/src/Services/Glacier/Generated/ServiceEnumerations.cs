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
 * Do not modify this file. This file is generated from the glacier-2012-06-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Glacier
{

    /// <summary>
    /// Constants used for properties of type ActionCode.
    /// </summary>
    public class ActionCode : ConstantClass
    {

        /// <summary>
        /// Constant ArchiveRetrieval for ActionCode
        /// </summary>
        public static readonly ActionCode ArchiveRetrieval = new ActionCode("ArchiveRetrieval");
        /// <summary>
        /// Constant InventoryRetrieval for ActionCode
        /// </summary>
        public static readonly ActionCode InventoryRetrieval = new ActionCode("InventoryRetrieval");
        /// <summary>
        /// Constant Select for ActionCode
        /// </summary>
        public static readonly ActionCode Select = new ActionCode("Select");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ActionCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ActionCode FindValue(string value)
        {
            return FindValue<ActionCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ActionCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CannedACL.
    /// </summary>
    public class CannedACL : ConstantClass
    {

        /// <summary>
        /// Constant AuthenticatedRead for CannedACL
        /// </summary>
        public static readonly CannedACL AuthenticatedRead = new CannedACL("authenticated-read");
        /// <summary>
        /// Constant AwsExecRead for CannedACL
        /// </summary>
        public static readonly CannedACL AwsExecRead = new CannedACL("aws-exec-read");
        /// <summary>
        /// Constant BucketOwnerFullControl for CannedACL
        /// </summary>
        public static readonly CannedACL BucketOwnerFullControl = new CannedACL("bucket-owner-full-control");
        /// <summary>
        /// Constant BucketOwnerRead for CannedACL
        /// </summary>
        public static readonly CannedACL BucketOwnerRead = new CannedACL("bucket-owner-read");
        /// <summary>
        /// Constant Private for CannedACL
        /// </summary>
        public static readonly CannedACL Private = new CannedACL("private");
        /// <summary>
        /// Constant PublicRead for CannedACL
        /// </summary>
        public static readonly CannedACL PublicRead = new CannedACL("public-read");
        /// <summary>
        /// Constant PublicReadWrite for CannedACL
        /// </summary>
        public static readonly CannedACL PublicReadWrite = new CannedACL("public-read-write");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CannedACL(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CannedACL FindValue(string value)
        {
            return FindValue<CannedACL>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CannedACL(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EncryptionType.
    /// </summary>
    public class EncryptionType : ConstantClass
    {

        /// <summary>
        /// Constant AES256 for EncryptionType
        /// </summary>
        public static readonly EncryptionType AES256 = new EncryptionType("AES256");
        /// <summary>
        /// Constant AwsKms for EncryptionType
        /// </summary>
        public static readonly EncryptionType AwsKms = new EncryptionType("aws:kms");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EncryptionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EncryptionType FindValue(string value)
        {
            return FindValue<EncryptionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EncryptionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExpressionType.
    /// </summary>
    public class ExpressionType : ConstantClass
    {

        /// <summary>
        /// Constant SQL for ExpressionType
        /// </summary>
        public static readonly ExpressionType SQL = new ExpressionType("SQL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExpressionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExpressionType FindValue(string value)
        {
            return FindValue<ExpressionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExpressionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FileHeaderInfo.
    /// </summary>
    public class FileHeaderInfo : ConstantClass
    {

        /// <summary>
        /// Constant IGNORE for FileHeaderInfo
        /// </summary>
        public static readonly FileHeaderInfo IGNORE = new FileHeaderInfo("IGNORE");
        /// <summary>
        /// Constant NONE for FileHeaderInfo
        /// </summary>
        public static readonly FileHeaderInfo NONE = new FileHeaderInfo("NONE");
        /// <summary>
        /// Constant USE for FileHeaderInfo
        /// </summary>
        public static readonly FileHeaderInfo USE = new FileHeaderInfo("USE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FileHeaderInfo(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FileHeaderInfo FindValue(string value)
        {
            return FindValue<FileHeaderInfo>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FileHeaderInfo(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Permission.
    /// </summary>
    public class Permission : ConstantClass
    {

        /// <summary>
        /// Constant FULL_CONTROL for Permission
        /// </summary>
        public static readonly Permission FULL_CONTROL = new Permission("FULL_CONTROL");
        /// <summary>
        /// Constant READ for Permission
        /// </summary>
        public static readonly Permission READ = new Permission("READ");
        /// <summary>
        /// Constant READ_ACP for Permission
        /// </summary>
        public static readonly Permission READ_ACP = new Permission("READ_ACP");
        /// <summary>
        /// Constant WRITE for Permission
        /// </summary>
        public static readonly Permission WRITE = new Permission("WRITE");
        /// <summary>
        /// Constant WRITE_ACP for Permission
        /// </summary>
        public static readonly Permission WRITE_ACP = new Permission("WRITE_ACP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Permission(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Permission FindValue(string value)
        {
            return FindValue<Permission>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Permission(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type QuoteFields.
    /// </summary>
    public class QuoteFields : ConstantClass
    {

        /// <summary>
        /// Constant ALWAYS for QuoteFields
        /// </summary>
        public static readonly QuoteFields ALWAYS = new QuoteFields("ALWAYS");
        /// <summary>
        /// Constant ASNEEDED for QuoteFields
        /// </summary>
        public static readonly QuoteFields ASNEEDED = new QuoteFields("ASNEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public QuoteFields(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static QuoteFields FindValue(string value)
        {
            return FindValue<QuoteFields>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator QuoteFields(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StatusCode.
    /// </summary>
    public class StatusCode : ConstantClass
    {

        /// <summary>
        /// Constant Failed for StatusCode
        /// </summary>
        public static readonly StatusCode Failed = new StatusCode("Failed");
        /// <summary>
        /// Constant InProgress for StatusCode
        /// </summary>
        public static readonly StatusCode InProgress = new StatusCode("InProgress");
        /// <summary>
        /// Constant Succeeded for StatusCode
        /// </summary>
        public static readonly StatusCode Succeeded = new StatusCode("Succeeded");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StatusCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StatusCode FindValue(string value)
        {
            return FindValue<StatusCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StatusCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type StorageClass.
    /// </summary>
    public class StorageClass : ConstantClass
    {

        /// <summary>
        /// Constant REDUCED_REDUNDANCY for StorageClass
        /// </summary>
        public static readonly StorageClass REDUCED_REDUNDANCY = new StorageClass("REDUCED_REDUNDANCY");
        /// <summary>
        /// Constant STANDARD for StorageClass
        /// </summary>
        public static readonly StorageClass STANDARD = new StorageClass("STANDARD");
        /// <summary>
        /// Constant STANDARD_IA for StorageClass
        /// </summary>
        public static readonly StorageClass STANDARD_IA = new StorageClass("STANDARD_IA");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StorageClass(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StorageClass FindValue(string value)
        {
            return FindValue<StorageClass>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StorageClass(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Type.
    /// </summary>
    public class Type : ConstantClass
    {

        /// <summary>
        /// Constant AmazonCustomerByEmail for Type
        /// </summary>
        public static readonly Type AmazonCustomerByEmail = new Type("AmazonCustomerByEmail");
        /// <summary>
        /// Constant CanonicalUser for Type
        /// </summary>
        public static readonly Type CanonicalUser = new Type("CanonicalUser");
        /// <summary>
        /// Constant Group for Type
        /// </summary>
        public static readonly Type Group = new Type("Group");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Type(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Type FindValue(string value)
        {
            return FindValue<Type>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Type(string value)
        {
            return FindValue(value);
        }
    }

}