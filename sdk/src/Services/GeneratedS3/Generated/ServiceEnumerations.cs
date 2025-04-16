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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.S3
{

    /// <summary>
    /// Constants used for properties of type AnalyticsS3ExportFileFormat.
    /// </summary>
    public class AnalyticsS3ExportFileFormat : ConstantClass
    {

        /// <summary>
        /// Constant CSV for AnalyticsS3ExportFileFormat
        /// </summary>
        public static readonly AnalyticsS3ExportFileFormat CSV = new AnalyticsS3ExportFileFormat("CSV");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AnalyticsS3ExportFileFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AnalyticsS3ExportFileFormat FindValue(string value)
        {
            return FindValue<AnalyticsS3ExportFileFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AnalyticsS3ExportFileFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ArchiveStatus.
    /// </summary>
    public class ArchiveStatus : ConstantClass
    {

        /// <summary>
        /// Constant ARCHIVE_ACCESS for ArchiveStatus
        /// </summary>
        public static readonly ArchiveStatus ARCHIVE_ACCESS = new ArchiveStatus("ARCHIVE_ACCESS");
        /// <summary>
        /// Constant DEEP_ARCHIVE_ACCESS for ArchiveStatus
        /// </summary>
        public static readonly ArchiveStatus DEEP_ARCHIVE_ACCESS = new ArchiveStatus("DEEP_ARCHIVE_ACCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ArchiveStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ArchiveStatus FindValue(string value)
        {
            return FindValue<ArchiveStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ArchiveStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BucketAccelerateStatus.
    /// </summary>
    public class BucketAccelerateStatus : ConstantClass
    {

        /// <summary>
        /// Constant Enabled for BucketAccelerateStatus
        /// </summary>
        public static readonly BucketAccelerateStatus Enabled = new BucketAccelerateStatus("Enabled");
        /// <summary>
        /// Constant Suspended for BucketAccelerateStatus
        /// </summary>
        public static readonly BucketAccelerateStatus Suspended = new BucketAccelerateStatus("Suspended");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BucketAccelerateStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BucketAccelerateStatus FindValue(string value)
        {
            return FindValue<BucketAccelerateStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BucketAccelerateStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BucketCannedACL.
    /// </summary>
    public class BucketCannedACL : ConstantClass
    {

        /// <summary>
        /// Constant AuthenticatedRead for BucketCannedACL
        /// </summary>
        public static readonly BucketCannedACL AuthenticatedRead = new BucketCannedACL("authenticated-read");
        /// <summary>
        /// Constant Private for BucketCannedACL
        /// </summary>
        public static readonly BucketCannedACL Private = new BucketCannedACL("private");
        /// <summary>
        /// Constant PublicRead for BucketCannedACL
        /// </summary>
        public static readonly BucketCannedACL PublicRead = new BucketCannedACL("public-read");
        /// <summary>
        /// Constant PublicReadWrite for BucketCannedACL
        /// </summary>
        public static readonly BucketCannedACL PublicReadWrite = new BucketCannedACL("public-read-write");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BucketCannedACL(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BucketCannedACL FindValue(string value)
        {
            return FindValue<BucketCannedACL>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BucketCannedACL(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BucketLocationConstraint.
    /// </summary>
    public class BucketLocationConstraint : ConstantClass
    {

        /// <summary>
        /// Constant AfSouth1 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint AfSouth1 = new BucketLocationConstraint("af-south-1");
        /// <summary>
        /// Constant ApEast1 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint ApEast1 = new BucketLocationConstraint("ap-east-1");
        /// <summary>
        /// Constant ApNortheast1 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint ApNortheast1 = new BucketLocationConstraint("ap-northeast-1");
        /// <summary>
        /// Constant ApNortheast2 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint ApNortheast2 = new BucketLocationConstraint("ap-northeast-2");
        /// <summary>
        /// Constant ApNortheast3 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint ApNortheast3 = new BucketLocationConstraint("ap-northeast-3");
        /// <summary>
        /// Constant ApSouth1 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint ApSouth1 = new BucketLocationConstraint("ap-south-1");
        /// <summary>
        /// Constant ApSouth2 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint ApSouth2 = new BucketLocationConstraint("ap-south-2");
        /// <summary>
        /// Constant ApSoutheast1 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint ApSoutheast1 = new BucketLocationConstraint("ap-southeast-1");
        /// <summary>
        /// Constant ApSoutheast2 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint ApSoutheast2 = new BucketLocationConstraint("ap-southeast-2");
        /// <summary>
        /// Constant ApSoutheast3 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint ApSoutheast3 = new BucketLocationConstraint("ap-southeast-3");
        /// <summary>
        /// Constant ApSoutheast4 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint ApSoutheast4 = new BucketLocationConstraint("ap-southeast-4");
        /// <summary>
        /// Constant ApSoutheast5 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint ApSoutheast5 = new BucketLocationConstraint("ap-southeast-5");
        /// <summary>
        /// Constant CaCentral1 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint CaCentral1 = new BucketLocationConstraint("ca-central-1");
        /// <summary>
        /// Constant CnNorth1 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint CnNorth1 = new BucketLocationConstraint("cn-north-1");
        /// <summary>
        /// Constant CnNorthwest1 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint CnNorthwest1 = new BucketLocationConstraint("cn-northwest-1");
        /// <summary>
        /// Constant EU for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint EU = new BucketLocationConstraint("EU");
        /// <summary>
        /// Constant EuCentral1 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint EuCentral1 = new BucketLocationConstraint("eu-central-1");
        /// <summary>
        /// Constant EuCentral2 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint EuCentral2 = new BucketLocationConstraint("eu-central-2");
        /// <summary>
        /// Constant EuNorth1 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint EuNorth1 = new BucketLocationConstraint("eu-north-1");
        /// <summary>
        /// Constant EuSouth1 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint EuSouth1 = new BucketLocationConstraint("eu-south-1");
        /// <summary>
        /// Constant EuSouth2 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint EuSouth2 = new BucketLocationConstraint("eu-south-2");
        /// <summary>
        /// Constant EuWest1 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint EuWest1 = new BucketLocationConstraint("eu-west-1");
        /// <summary>
        /// Constant EuWest2 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint EuWest2 = new BucketLocationConstraint("eu-west-2");
        /// <summary>
        /// Constant EuWest3 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint EuWest3 = new BucketLocationConstraint("eu-west-3");
        /// <summary>
        /// Constant IlCentral1 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint IlCentral1 = new BucketLocationConstraint("il-central-1");
        /// <summary>
        /// Constant MeCentral1 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint MeCentral1 = new BucketLocationConstraint("me-central-1");
        /// <summary>
        /// Constant MeSouth1 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint MeSouth1 = new BucketLocationConstraint("me-south-1");
        /// <summary>
        /// Constant SaEast1 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint SaEast1 = new BucketLocationConstraint("sa-east-1");
        /// <summary>
        /// Constant UsEast2 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint UsEast2 = new BucketLocationConstraint("us-east-2");
        /// <summary>
        /// Constant UsGovEast1 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint UsGovEast1 = new BucketLocationConstraint("us-gov-east-1");
        /// <summary>
        /// Constant UsGovWest1 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint UsGovWest1 = new BucketLocationConstraint("us-gov-west-1");
        /// <summary>
        /// Constant UsWest1 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint UsWest1 = new BucketLocationConstraint("us-west-1");
        /// <summary>
        /// Constant UsWest2 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint UsWest2 = new BucketLocationConstraint("us-west-2");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BucketLocationConstraint(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BucketLocationConstraint FindValue(string value)
        {
            return FindValue<BucketLocationConstraint>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BucketLocationConstraint(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BucketLogsPermission.
    /// </summary>
    public class BucketLogsPermission : ConstantClass
    {

        /// <summary>
        /// Constant FULL_CONTROL for BucketLogsPermission
        /// </summary>
        public static readonly BucketLogsPermission FULL_CONTROL = new BucketLogsPermission("FULL_CONTROL");
        /// <summary>
        /// Constant READ for BucketLogsPermission
        /// </summary>
        public static readonly BucketLogsPermission READ = new BucketLogsPermission("READ");
        /// <summary>
        /// Constant WRITE for BucketLogsPermission
        /// </summary>
        public static readonly BucketLogsPermission WRITE = new BucketLogsPermission("WRITE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BucketLogsPermission(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BucketLogsPermission FindValue(string value)
        {
            return FindValue<BucketLogsPermission>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BucketLogsPermission(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BucketType.
    /// </summary>
    public class BucketType : ConstantClass
    {

        /// <summary>
        /// Constant Directory for BucketType
        /// </summary>
        public static readonly BucketType Directory = new BucketType("Directory");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BucketType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BucketType FindValue(string value)
        {
            return FindValue<BucketType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BucketType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BucketVersioningStatus.
    /// </summary>
    public class BucketVersioningStatus : ConstantClass
    {

        /// <summary>
        /// Constant Enabled for BucketVersioningStatus
        /// </summary>
        public static readonly BucketVersioningStatus Enabled = new BucketVersioningStatus("Enabled");
        /// <summary>
        /// Constant Suspended for BucketVersioningStatus
        /// </summary>
        public static readonly BucketVersioningStatus Suspended = new BucketVersioningStatus("Suspended");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BucketVersioningStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BucketVersioningStatus FindValue(string value)
        {
            return FindValue<BucketVersioningStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BucketVersioningStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChecksumAlgorithm.
    /// </summary>
    public class ChecksumAlgorithm : ConstantClass
    {

        /// <summary>
        /// Constant CRC32 for ChecksumAlgorithm
        /// </summary>
        public static readonly ChecksumAlgorithm CRC32 = new ChecksumAlgorithm("CRC32");
        /// <summary>
        /// Constant CRC32C for ChecksumAlgorithm
        /// </summary>
        public static readonly ChecksumAlgorithm CRC32C = new ChecksumAlgorithm("CRC32C");
        /// <summary>
        /// Constant CRC64NVME for ChecksumAlgorithm
        /// </summary>
        public static readonly ChecksumAlgorithm CRC64NVME = new ChecksumAlgorithm("CRC64NVME");
        /// <summary>
        /// Constant SHA1 for ChecksumAlgorithm
        /// </summary>
        public static readonly ChecksumAlgorithm SHA1 = new ChecksumAlgorithm("SHA1");
        /// <summary>
        /// Constant SHA256 for ChecksumAlgorithm
        /// </summary>
        public static readonly ChecksumAlgorithm SHA256 = new ChecksumAlgorithm("SHA256");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChecksumAlgorithm(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChecksumAlgorithm FindValue(string value)
        {
            return FindValue<ChecksumAlgorithm>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChecksumAlgorithm(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChecksumMode.
    /// </summary>
    public class ChecksumMode : ConstantClass
    {

        /// <summary>
        /// Constant ENABLED for ChecksumMode
        /// </summary>
        public static readonly ChecksumMode ENABLED = new ChecksumMode("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChecksumMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChecksumMode FindValue(string value)
        {
            return FindValue<ChecksumMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChecksumMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChecksumType.
    /// </summary>
    public class ChecksumType : ConstantClass
    {

        /// <summary>
        /// Constant COMPOSITE for ChecksumType
        /// </summary>
        public static readonly ChecksumType COMPOSITE = new ChecksumType("COMPOSITE");
        /// <summary>
        /// Constant FULL_OBJECT for ChecksumType
        /// </summary>
        public static readonly ChecksumType FULL_OBJECT = new ChecksumType("FULL_OBJECT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChecksumType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChecksumType FindValue(string value)
        {
            return FindValue<ChecksumType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChecksumType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CompressionType.
    /// </summary>
    public class CompressionType : ConstantClass
    {

        /// <summary>
        /// Constant BZIP2 for CompressionType
        /// </summary>
        public static readonly CompressionType BZIP2 = new CompressionType("BZIP2");
        /// <summary>
        /// Constant GZIP for CompressionType
        /// </summary>
        public static readonly CompressionType GZIP = new CompressionType("GZIP");
        /// <summary>
        /// Constant NONE for CompressionType
        /// </summary>
        public static readonly CompressionType NONE = new CompressionType("NONE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CompressionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CompressionType FindValue(string value)
        {
            return FindValue<CompressionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CompressionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataRedundancy.
    /// </summary>
    public class DataRedundancy : ConstantClass
    {

        /// <summary>
        /// Constant SingleAvailabilityZone for DataRedundancy
        /// </summary>
        public static readonly DataRedundancy SingleAvailabilityZone = new DataRedundancy("SingleAvailabilityZone");
        /// <summary>
        /// Constant SingleLocalZone for DataRedundancy
        /// </summary>
        public static readonly DataRedundancy SingleLocalZone = new DataRedundancy("SingleLocalZone");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataRedundancy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataRedundancy FindValue(string value)
        {
            return FindValue<DataRedundancy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataRedundancy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeleteMarkerReplicationStatus.
    /// </summary>
    public class DeleteMarkerReplicationStatus : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for DeleteMarkerReplicationStatus
        /// </summary>
        public static readonly DeleteMarkerReplicationStatus Disabled = new DeleteMarkerReplicationStatus("Disabled");
        /// <summary>
        /// Constant Enabled for DeleteMarkerReplicationStatus
        /// </summary>
        public static readonly DeleteMarkerReplicationStatus Enabled = new DeleteMarkerReplicationStatus("Enabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeleteMarkerReplicationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeleteMarkerReplicationStatus FindValue(string value)
        {
            return FindValue<DeleteMarkerReplicationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeleteMarkerReplicationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EncodingType.
    /// </summary>
    public class EncodingType : ConstantClass
    {

        /// <summary>
        /// Constant Url for EncodingType
        /// </summary>
        public static readonly EncodingType Url = new EncodingType("url");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EncodingType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EncodingType FindValue(string value)
        {
            return FindValue<EncodingType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EncodingType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Event.
    /// </summary>
    public class Event : ConstantClass
    {

        /// <summary>
        /// Constant S3IntelligentTiering for Event
        /// </summary>
        public static readonly Event S3IntelligentTiering = new Event("s3:IntelligentTiering");
        /// <summary>
        /// Constant S3LifecycleExpiration for Event
        /// </summary>
        public static readonly Event S3LifecycleExpiration = new Event("s3:LifecycleExpiration:*");
        /// <summary>
        /// Constant S3LifecycleExpirationDelete for Event
        /// </summary>
        public static readonly Event S3LifecycleExpirationDelete = new Event("s3:LifecycleExpiration:Delete");
        /// <summary>
        /// Constant S3LifecycleExpirationDeleteMarkerCreated for Event
        /// </summary>
        public static readonly Event S3LifecycleExpirationDeleteMarkerCreated = new Event("s3:LifecycleExpiration:DeleteMarkerCreated");
        /// <summary>
        /// Constant S3LifecycleTransition for Event
        /// </summary>
        public static readonly Event S3LifecycleTransition = new Event("s3:LifecycleTransition");
        /// <summary>
        /// Constant S3ObjectAclPut for Event
        /// </summary>
        public static readonly Event S3ObjectAclPut = new Event("s3:ObjectAcl:Put");
        /// <summary>
        /// Constant S3ObjectCreated for Event
        /// </summary>
        public static readonly Event S3ObjectCreated = new Event("s3:ObjectCreated:*");
        /// <summary>
        /// Constant S3ObjectCreatedCompleteMultipartUpload for Event
        /// </summary>
        public static readonly Event S3ObjectCreatedCompleteMultipartUpload = new Event("s3:ObjectCreated:CompleteMultipartUpload");
        /// <summary>
        /// Constant S3ObjectCreatedCopy for Event
        /// </summary>
        public static readonly Event S3ObjectCreatedCopy = new Event("s3:ObjectCreated:Copy");
        /// <summary>
        /// Constant S3ObjectCreatedPost for Event
        /// </summary>
        public static readonly Event S3ObjectCreatedPost = new Event("s3:ObjectCreated:Post");
        /// <summary>
        /// Constant S3ObjectCreatedPut for Event
        /// </summary>
        public static readonly Event S3ObjectCreatedPut = new Event("s3:ObjectCreated:Put");
        /// <summary>
        /// Constant S3ObjectRemoved for Event
        /// </summary>
        public static readonly Event S3ObjectRemoved = new Event("s3:ObjectRemoved:*");
        /// <summary>
        /// Constant S3ObjectRemovedDelete for Event
        /// </summary>
        public static readonly Event S3ObjectRemovedDelete = new Event("s3:ObjectRemoved:Delete");
        /// <summary>
        /// Constant S3ObjectRemovedDeleteMarkerCreated for Event
        /// </summary>
        public static readonly Event S3ObjectRemovedDeleteMarkerCreated = new Event("s3:ObjectRemoved:DeleteMarkerCreated");
        /// <summary>
        /// Constant S3ObjectRestore for Event
        /// </summary>
        public static readonly Event S3ObjectRestore = new Event("s3:ObjectRestore:*");
        /// <summary>
        /// Constant S3ObjectRestoreCompleted for Event
        /// </summary>
        public static readonly Event S3ObjectRestoreCompleted = new Event("s3:ObjectRestore:Completed");
        /// <summary>
        /// Constant S3ObjectRestoreDelete for Event
        /// </summary>
        public static readonly Event S3ObjectRestoreDelete = new Event("s3:ObjectRestore:Delete");
        /// <summary>
        /// Constant S3ObjectRestorePost for Event
        /// </summary>
        public static readonly Event S3ObjectRestorePost = new Event("s3:ObjectRestore:Post");
        /// <summary>
        /// Constant S3ObjectTagging for Event
        /// </summary>
        public static readonly Event S3ObjectTagging = new Event("s3:ObjectTagging:*");
        /// <summary>
        /// Constant S3ObjectTaggingDelete for Event
        /// </summary>
        public static readonly Event S3ObjectTaggingDelete = new Event("s3:ObjectTagging:Delete");
        /// <summary>
        /// Constant S3ObjectTaggingPut for Event
        /// </summary>
        public static readonly Event S3ObjectTaggingPut = new Event("s3:ObjectTagging:Put");
        /// <summary>
        /// Constant S3ReducedRedundancyLostObject for Event
        /// </summary>
        public static readonly Event S3ReducedRedundancyLostObject = new Event("s3:ReducedRedundancyLostObject");
        /// <summary>
        /// Constant S3Replication for Event
        /// </summary>
        public static readonly Event S3Replication = new Event("s3:Replication:*");
        /// <summary>
        /// Constant S3ReplicationOperationFailedReplication for Event
        /// </summary>
        public static readonly Event S3ReplicationOperationFailedReplication = new Event("s3:Replication:OperationFailedReplication");
        /// <summary>
        /// Constant S3ReplicationOperationMissedThreshold for Event
        /// </summary>
        public static readonly Event S3ReplicationOperationMissedThreshold = new Event("s3:Replication:OperationMissedThreshold");
        /// <summary>
        /// Constant S3ReplicationOperationNotTracked for Event
        /// </summary>
        public static readonly Event S3ReplicationOperationNotTracked = new Event("s3:Replication:OperationNotTracked");
        /// <summary>
        /// Constant S3ReplicationOperationReplicatedAfterThreshold for Event
        /// </summary>
        public static readonly Event S3ReplicationOperationReplicatedAfterThreshold = new Event("s3:Replication:OperationReplicatedAfterThreshold");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Event(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Event FindValue(string value)
        {
            return FindValue<Event>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Event(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExistingObjectReplicationStatus.
    /// </summary>
    public class ExistingObjectReplicationStatus : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for ExistingObjectReplicationStatus
        /// </summary>
        public static readonly ExistingObjectReplicationStatus Disabled = new ExistingObjectReplicationStatus("Disabled");
        /// <summary>
        /// Constant Enabled for ExistingObjectReplicationStatus
        /// </summary>
        public static readonly ExistingObjectReplicationStatus Enabled = new ExistingObjectReplicationStatus("Enabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExistingObjectReplicationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExistingObjectReplicationStatus FindValue(string value)
        {
            return FindValue<ExistingObjectReplicationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExistingObjectReplicationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExpirationStatus.
    /// </summary>
    public class ExpirationStatus : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for ExpirationStatus
        /// </summary>
        public static readonly ExpirationStatus Disabled = new ExpirationStatus("Disabled");
        /// <summary>
        /// Constant Enabled for ExpirationStatus
        /// </summary>
        public static readonly ExpirationStatus Enabled = new ExpirationStatus("Enabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExpirationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExpirationStatus FindValue(string value)
        {
            return FindValue<ExpirationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExpirationStatus(string value)
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
    /// Constants used for properties of type FilterRuleName.
    /// </summary>
    public class FilterRuleName : ConstantClass
    {

        /// <summary>
        /// Constant Prefix for FilterRuleName
        /// </summary>
        public static readonly FilterRuleName Prefix = new FilterRuleName("prefix");
        /// <summary>
        /// Constant Suffix for FilterRuleName
        /// </summary>
        public static readonly FilterRuleName Suffix = new FilterRuleName("suffix");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FilterRuleName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FilterRuleName FindValue(string value)
        {
            return FindValue<FilterRuleName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FilterRuleName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IntelligentTieringAccessTier.
    /// </summary>
    public class IntelligentTieringAccessTier : ConstantClass
    {

        /// <summary>
        /// Constant ARCHIVE_ACCESS for IntelligentTieringAccessTier
        /// </summary>
        public static readonly IntelligentTieringAccessTier ARCHIVE_ACCESS = new IntelligentTieringAccessTier("ARCHIVE_ACCESS");
        /// <summary>
        /// Constant DEEP_ARCHIVE_ACCESS for IntelligentTieringAccessTier
        /// </summary>
        public static readonly IntelligentTieringAccessTier DEEP_ARCHIVE_ACCESS = new IntelligentTieringAccessTier("DEEP_ARCHIVE_ACCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IntelligentTieringAccessTier(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IntelligentTieringAccessTier FindValue(string value)
        {
            return FindValue<IntelligentTieringAccessTier>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IntelligentTieringAccessTier(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IntelligentTieringStatus.
    /// </summary>
    public class IntelligentTieringStatus : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for IntelligentTieringStatus
        /// </summary>
        public static readonly IntelligentTieringStatus Disabled = new IntelligentTieringStatus("Disabled");
        /// <summary>
        /// Constant Enabled for IntelligentTieringStatus
        /// </summary>
        public static readonly IntelligentTieringStatus Enabled = new IntelligentTieringStatus("Enabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IntelligentTieringStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IntelligentTieringStatus FindValue(string value)
        {
            return FindValue<IntelligentTieringStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IntelligentTieringStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InventoryFormat.
    /// </summary>
    public class InventoryFormat : ConstantClass
    {

        /// <summary>
        /// Constant CSV for InventoryFormat
        /// </summary>
        public static readonly InventoryFormat CSV = new InventoryFormat("CSV");
        /// <summary>
        /// Constant ORC for InventoryFormat
        /// </summary>
        public static readonly InventoryFormat ORC = new InventoryFormat("ORC");
        /// <summary>
        /// Constant Parquet for InventoryFormat
        /// </summary>
        public static readonly InventoryFormat Parquet = new InventoryFormat("Parquet");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InventoryFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InventoryFormat FindValue(string value)
        {
            return FindValue<InventoryFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InventoryFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InventoryFrequency.
    /// </summary>
    public class InventoryFrequency : ConstantClass
    {

        /// <summary>
        /// Constant Daily for InventoryFrequency
        /// </summary>
        public static readonly InventoryFrequency Daily = new InventoryFrequency("Daily");
        /// <summary>
        /// Constant Weekly for InventoryFrequency
        /// </summary>
        public static readonly InventoryFrequency Weekly = new InventoryFrequency("Weekly");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InventoryFrequency(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InventoryFrequency FindValue(string value)
        {
            return FindValue<InventoryFrequency>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InventoryFrequency(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InventoryIncludedObjectVersions.
    /// </summary>
    public class InventoryIncludedObjectVersions : ConstantClass
    {

        /// <summary>
        /// Constant All for InventoryIncludedObjectVersions
        /// </summary>
        public static readonly InventoryIncludedObjectVersions All = new InventoryIncludedObjectVersions("All");
        /// <summary>
        /// Constant Current for InventoryIncludedObjectVersions
        /// </summary>
        public static readonly InventoryIncludedObjectVersions Current = new InventoryIncludedObjectVersions("Current");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InventoryIncludedObjectVersions(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InventoryIncludedObjectVersions FindValue(string value)
        {
            return FindValue<InventoryIncludedObjectVersions>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InventoryIncludedObjectVersions(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InventoryOptionalField.
    /// </summary>
    public class InventoryOptionalField : ConstantClass
    {

        /// <summary>
        /// Constant BucketKeyStatus for InventoryOptionalField
        /// </summary>
        public static readonly InventoryOptionalField BucketKeyStatus = new InventoryOptionalField("BucketKeyStatus");
        /// <summary>
        /// Constant ChecksumAlgorithm for InventoryOptionalField
        /// </summary>
        public static readonly InventoryOptionalField ChecksumAlgorithm = new InventoryOptionalField("ChecksumAlgorithm");
        /// <summary>
        /// Constant EncryptionStatus for InventoryOptionalField
        /// </summary>
        public static readonly InventoryOptionalField EncryptionStatus = new InventoryOptionalField("EncryptionStatus");
        /// <summary>
        /// Constant ETag for InventoryOptionalField
        /// </summary>
        public static readonly InventoryOptionalField ETag = new InventoryOptionalField("ETag");
        /// <summary>
        /// Constant IntelligentTieringAccessTier for InventoryOptionalField
        /// </summary>
        public static readonly InventoryOptionalField IntelligentTieringAccessTier = new InventoryOptionalField("IntelligentTieringAccessTier");
        /// <summary>
        /// Constant IsMultipartUploaded for InventoryOptionalField
        /// </summary>
        public static readonly InventoryOptionalField IsMultipartUploaded = new InventoryOptionalField("IsMultipartUploaded");
        /// <summary>
        /// Constant LastModifiedDate for InventoryOptionalField
        /// </summary>
        public static readonly InventoryOptionalField LastModifiedDate = new InventoryOptionalField("LastModifiedDate");
        /// <summary>
        /// Constant ObjectAccessControlList for InventoryOptionalField
        /// </summary>
        public static readonly InventoryOptionalField ObjectAccessControlList = new InventoryOptionalField("ObjectAccessControlList");
        /// <summary>
        /// Constant ObjectLockLegalHoldStatus for InventoryOptionalField
        /// </summary>
        public static readonly InventoryOptionalField ObjectLockLegalHoldStatus = new InventoryOptionalField("ObjectLockLegalHoldStatus");
        /// <summary>
        /// Constant ObjectLockMode for InventoryOptionalField
        /// </summary>
        public static readonly InventoryOptionalField ObjectLockMode = new InventoryOptionalField("ObjectLockMode");
        /// <summary>
        /// Constant ObjectLockRetainUntilDate for InventoryOptionalField
        /// </summary>
        public static readonly InventoryOptionalField ObjectLockRetainUntilDate = new InventoryOptionalField("ObjectLockRetainUntilDate");
        /// <summary>
        /// Constant ObjectOwner for InventoryOptionalField
        /// </summary>
        public static readonly InventoryOptionalField ObjectOwner = new InventoryOptionalField("ObjectOwner");
        /// <summary>
        /// Constant ReplicationStatus for InventoryOptionalField
        /// </summary>
        public static readonly InventoryOptionalField ReplicationStatus = new InventoryOptionalField("ReplicationStatus");
        /// <summary>
        /// Constant Size for InventoryOptionalField
        /// </summary>
        public static readonly InventoryOptionalField Size = new InventoryOptionalField("Size");
        /// <summary>
        /// Constant StorageClass for InventoryOptionalField
        /// </summary>
        public static readonly InventoryOptionalField StorageClass = new InventoryOptionalField("StorageClass");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InventoryOptionalField(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InventoryOptionalField FindValue(string value)
        {
            return FindValue<InventoryOptionalField>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InventoryOptionalField(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JSONType.
    /// </summary>
    public class JSONType : ConstantClass
    {

        /// <summary>
        /// Constant DOCUMENT for JSONType
        /// </summary>
        public static readonly JSONType DOCUMENT = new JSONType("DOCUMENT");
        /// <summary>
        /// Constant LINES for JSONType
        /// </summary>
        public static readonly JSONType LINES = new JSONType("LINES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JSONType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JSONType FindValue(string value)
        {
            return FindValue<JSONType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JSONType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LocationType.
    /// </summary>
    public class LocationType : ConstantClass
    {

        /// <summary>
        /// Constant AvailabilityZone for LocationType
        /// </summary>
        public static readonly LocationType AvailabilityZone = new LocationType("AvailabilityZone");
        /// <summary>
        /// Constant LocalZone for LocationType
        /// </summary>
        public static readonly LocationType LocalZone = new LocationType("LocalZone");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LocationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LocationType FindValue(string value)
        {
            return FindValue<LocationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LocationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MetadataDirective.
    /// </summary>
    public class MetadataDirective : ConstantClass
    {

        /// <summary>
        /// Constant COPY for MetadataDirective
        /// </summary>
        public static readonly MetadataDirective COPY = new MetadataDirective("COPY");
        /// <summary>
        /// Constant REPLACE for MetadataDirective
        /// </summary>
        public static readonly MetadataDirective REPLACE = new MetadataDirective("REPLACE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MetadataDirective(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MetadataDirective FindValue(string value)
        {
            return FindValue<MetadataDirective>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MetadataDirective(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MetricsStatus.
    /// </summary>
    public class MetricsStatus : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for MetricsStatus
        /// </summary>
        public static readonly MetricsStatus Disabled = new MetricsStatus("Disabled");
        /// <summary>
        /// Constant Enabled for MetricsStatus
        /// </summary>
        public static readonly MetricsStatus Enabled = new MetricsStatus("Enabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MetricsStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MetricsStatus FindValue(string value)
        {
            return FindValue<MetricsStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MetricsStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MFADelete.
    /// </summary>
    public class MFADelete : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for MFADelete
        /// </summary>
        public static readonly MFADelete Disabled = new MFADelete("Disabled");
        /// <summary>
        /// Constant Enabled for MFADelete
        /// </summary>
        public static readonly MFADelete Enabled = new MFADelete("Enabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MFADelete(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MFADelete FindValue(string value)
        {
            return FindValue<MFADelete>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MFADelete(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MFADeleteStatus.
    /// </summary>
    public class MFADeleteStatus : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for MFADeleteStatus
        /// </summary>
        public static readonly MFADeleteStatus Disabled = new MFADeleteStatus("Disabled");
        /// <summary>
        /// Constant Enabled for MFADeleteStatus
        /// </summary>
        public static readonly MFADeleteStatus Enabled = new MFADeleteStatus("Enabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MFADeleteStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MFADeleteStatus FindValue(string value)
        {
            return FindValue<MFADeleteStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MFADeleteStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ObjectAttributes.
    /// </summary>
    public class ObjectAttributes : ConstantClass
    {

        /// <summary>
        /// Constant Checksum for ObjectAttributes
        /// </summary>
        public static readonly ObjectAttributes Checksum = new ObjectAttributes("Checksum");
        /// <summary>
        /// Constant ETag for ObjectAttributes
        /// </summary>
        public static readonly ObjectAttributes ETag = new ObjectAttributes("ETag");
        /// <summary>
        /// Constant ObjectParts for ObjectAttributes
        /// </summary>
        public static readonly ObjectAttributes ObjectParts = new ObjectAttributes("ObjectParts");
        /// <summary>
        /// Constant ObjectSize for ObjectAttributes
        /// </summary>
        public static readonly ObjectAttributes ObjectSize = new ObjectAttributes("ObjectSize");
        /// <summary>
        /// Constant StorageClass for ObjectAttributes
        /// </summary>
        public static readonly ObjectAttributes StorageClass = new ObjectAttributes("StorageClass");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ObjectAttributes(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ObjectAttributes FindValue(string value)
        {
            return FindValue<ObjectAttributes>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ObjectAttributes(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ObjectCannedACL.
    /// </summary>
    public class ObjectCannedACL : ConstantClass
    {

        /// <summary>
        /// Constant AuthenticatedRead for ObjectCannedACL
        /// </summary>
        public static readonly ObjectCannedACL AuthenticatedRead = new ObjectCannedACL("authenticated-read");
        /// <summary>
        /// Constant AwsExecRead for ObjectCannedACL
        /// </summary>
        public static readonly ObjectCannedACL AwsExecRead = new ObjectCannedACL("aws-exec-read");
        /// <summary>
        /// Constant BucketOwnerFullControl for ObjectCannedACL
        /// </summary>
        public static readonly ObjectCannedACL BucketOwnerFullControl = new ObjectCannedACL("bucket-owner-full-control");
        /// <summary>
        /// Constant BucketOwnerRead for ObjectCannedACL
        /// </summary>
        public static readonly ObjectCannedACL BucketOwnerRead = new ObjectCannedACL("bucket-owner-read");
        /// <summary>
        /// Constant Private for ObjectCannedACL
        /// </summary>
        public static readonly ObjectCannedACL Private = new ObjectCannedACL("private");
        /// <summary>
        /// Constant PublicRead for ObjectCannedACL
        /// </summary>
        public static readonly ObjectCannedACL PublicRead = new ObjectCannedACL("public-read");
        /// <summary>
        /// Constant PublicReadWrite for ObjectCannedACL
        /// </summary>
        public static readonly ObjectCannedACL PublicReadWrite = new ObjectCannedACL("public-read-write");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ObjectCannedACL(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ObjectCannedACL FindValue(string value)
        {
            return FindValue<ObjectCannedACL>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ObjectCannedACL(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ObjectLockEnabled.
    /// </summary>
    public class ObjectLockEnabled : ConstantClass
    {

        /// <summary>
        /// Constant Enabled for ObjectLockEnabled
        /// </summary>
        public static readonly ObjectLockEnabled Enabled = new ObjectLockEnabled("Enabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ObjectLockEnabled(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ObjectLockEnabled FindValue(string value)
        {
            return FindValue<ObjectLockEnabled>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ObjectLockEnabled(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ObjectLockLegalHoldStatus.
    /// </summary>
    public class ObjectLockLegalHoldStatus : ConstantClass
    {

        /// <summary>
        /// Constant OFF for ObjectLockLegalHoldStatus
        /// </summary>
        public static readonly ObjectLockLegalHoldStatus OFF = new ObjectLockLegalHoldStatus("OFF");
        /// <summary>
        /// Constant ON for ObjectLockLegalHoldStatus
        /// </summary>
        public static readonly ObjectLockLegalHoldStatus ON = new ObjectLockLegalHoldStatus("ON");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ObjectLockLegalHoldStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ObjectLockLegalHoldStatus FindValue(string value)
        {
            return FindValue<ObjectLockLegalHoldStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ObjectLockLegalHoldStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ObjectLockMode.
    /// </summary>
    public class ObjectLockMode : ConstantClass
    {

        /// <summary>
        /// Constant COMPLIANCE for ObjectLockMode
        /// </summary>
        public static readonly ObjectLockMode COMPLIANCE = new ObjectLockMode("COMPLIANCE");
        /// <summary>
        /// Constant GOVERNANCE for ObjectLockMode
        /// </summary>
        public static readonly ObjectLockMode GOVERNANCE = new ObjectLockMode("GOVERNANCE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ObjectLockMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ObjectLockMode FindValue(string value)
        {
            return FindValue<ObjectLockMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ObjectLockMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ObjectLockRetentionMode.
    /// </summary>
    public class ObjectLockRetentionMode : ConstantClass
    {

        /// <summary>
        /// Constant COMPLIANCE for ObjectLockRetentionMode
        /// </summary>
        public static readonly ObjectLockRetentionMode COMPLIANCE = new ObjectLockRetentionMode("COMPLIANCE");
        /// <summary>
        /// Constant GOVERNANCE for ObjectLockRetentionMode
        /// </summary>
        public static readonly ObjectLockRetentionMode GOVERNANCE = new ObjectLockRetentionMode("GOVERNANCE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ObjectLockRetentionMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ObjectLockRetentionMode FindValue(string value)
        {
            return FindValue<ObjectLockRetentionMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ObjectLockRetentionMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ObjectOwnership.
    /// </summary>
    public class ObjectOwnership : ConstantClass
    {

        /// <summary>
        /// Constant BucketOwnerEnforced for ObjectOwnership
        /// </summary>
        public static readonly ObjectOwnership BucketOwnerEnforced = new ObjectOwnership("BucketOwnerEnforced");
        /// <summary>
        /// Constant BucketOwnerPreferred for ObjectOwnership
        /// </summary>
        public static readonly ObjectOwnership BucketOwnerPreferred = new ObjectOwnership("BucketOwnerPreferred");
        /// <summary>
        /// Constant ObjectWriter for ObjectOwnership
        /// </summary>
        public static readonly ObjectOwnership ObjectWriter = new ObjectOwnership("ObjectWriter");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ObjectOwnership(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ObjectOwnership FindValue(string value)
        {
            return FindValue<ObjectOwnership>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ObjectOwnership(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ObjectStorageClass.
    /// </summary>
    public class ObjectStorageClass : ConstantClass
    {

        /// <summary>
        /// Constant DEEP_ARCHIVE for ObjectStorageClass
        /// </summary>
        public static readonly ObjectStorageClass DEEP_ARCHIVE = new ObjectStorageClass("DEEP_ARCHIVE");
        /// <summary>
        /// Constant EXPRESS_ONEZONE for ObjectStorageClass
        /// </summary>
        public static readonly ObjectStorageClass EXPRESS_ONEZONE = new ObjectStorageClass("EXPRESS_ONEZONE");
        /// <summary>
        /// Constant GLACIER for ObjectStorageClass
        /// </summary>
        public static readonly ObjectStorageClass GLACIER = new ObjectStorageClass("GLACIER");
        /// <summary>
        /// Constant GLACIER_IR for ObjectStorageClass
        /// </summary>
        public static readonly ObjectStorageClass GLACIER_IR = new ObjectStorageClass("GLACIER_IR");
        /// <summary>
        /// Constant INTELLIGENT_TIERING for ObjectStorageClass
        /// </summary>
        public static readonly ObjectStorageClass INTELLIGENT_TIERING = new ObjectStorageClass("INTELLIGENT_TIERING");
        /// <summary>
        /// Constant ONEZONE_IA for ObjectStorageClass
        /// </summary>
        public static readonly ObjectStorageClass ONEZONE_IA = new ObjectStorageClass("ONEZONE_IA");
        /// <summary>
        /// Constant OUTPOSTS for ObjectStorageClass
        /// </summary>
        public static readonly ObjectStorageClass OUTPOSTS = new ObjectStorageClass("OUTPOSTS");
        /// <summary>
        /// Constant REDUCED_REDUNDANCY for ObjectStorageClass
        /// </summary>
        public static readonly ObjectStorageClass REDUCED_REDUNDANCY = new ObjectStorageClass("REDUCED_REDUNDANCY");
        /// <summary>
        /// Constant SNOW for ObjectStorageClass
        /// </summary>
        public static readonly ObjectStorageClass SNOW = new ObjectStorageClass("SNOW");
        /// <summary>
        /// Constant STANDARD for ObjectStorageClass
        /// </summary>
        public static readonly ObjectStorageClass STANDARD = new ObjectStorageClass("STANDARD");
        /// <summary>
        /// Constant STANDARD_IA for ObjectStorageClass
        /// </summary>
        public static readonly ObjectStorageClass STANDARD_IA = new ObjectStorageClass("STANDARD_IA");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ObjectStorageClass(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ObjectStorageClass FindValue(string value)
        {
            return FindValue<ObjectStorageClass>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ObjectStorageClass(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ObjectVersionStorageClass.
    /// </summary>
    public class ObjectVersionStorageClass : ConstantClass
    {

        /// <summary>
        /// Constant STANDARD for ObjectVersionStorageClass
        /// </summary>
        public static readonly ObjectVersionStorageClass STANDARD = new ObjectVersionStorageClass("STANDARD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ObjectVersionStorageClass(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ObjectVersionStorageClass FindValue(string value)
        {
            return FindValue<ObjectVersionStorageClass>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ObjectVersionStorageClass(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OptionalObjectAttributes.
    /// </summary>
    public class OptionalObjectAttributes : ConstantClass
    {

        /// <summary>
        /// Constant RestoreStatus for OptionalObjectAttributes
        /// </summary>
        public static readonly OptionalObjectAttributes RestoreStatus = new OptionalObjectAttributes("RestoreStatus");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OptionalObjectAttributes(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OptionalObjectAttributes FindValue(string value)
        {
            return FindValue<OptionalObjectAttributes>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OptionalObjectAttributes(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OwnerOverride.
    /// </summary>
    public class OwnerOverride : ConstantClass
    {

        /// <summary>
        /// Constant Destination for OwnerOverride
        /// </summary>
        public static readonly OwnerOverride Destination = new OwnerOverride("Destination");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OwnerOverride(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OwnerOverride FindValue(string value)
        {
            return FindValue<OwnerOverride>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OwnerOverride(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PartitionDateSource.
    /// </summary>
    public class PartitionDateSource : ConstantClass
    {

        /// <summary>
        /// Constant DeliveryTime for PartitionDateSource
        /// </summary>
        public static readonly PartitionDateSource DeliveryTime = new PartitionDateSource("DeliveryTime");
        /// <summary>
        /// Constant EventTime for PartitionDateSource
        /// </summary>
        public static readonly PartitionDateSource EventTime = new PartitionDateSource("EventTime");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PartitionDateSource(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PartitionDateSource FindValue(string value)
        {
            return FindValue<PartitionDateSource>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PartitionDateSource(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Payer.
    /// </summary>
    public class Payer : ConstantClass
    {

        /// <summary>
        /// Constant BucketOwner for Payer
        /// </summary>
        public static readonly Payer BucketOwner = new Payer("BucketOwner");
        /// <summary>
        /// Constant Requester for Payer
        /// </summary>
        public static readonly Payer Requester = new Payer("Requester");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Payer(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Payer FindValue(string value)
        {
            return FindValue<Payer>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Payer(string value)
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
    /// Constants used for properties of type Protocol.
    /// </summary>
    public class Protocol : ConstantClass
    {

        /// <summary>
        /// Constant Http for Protocol
        /// </summary>
        public static readonly Protocol Http = new Protocol("http");
        /// <summary>
        /// Constant Https for Protocol
        /// </summary>
        public static readonly Protocol Https = new Protocol("https");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Protocol(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Protocol FindValue(string value)
        {
            return FindValue<Protocol>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Protocol(string value)
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
    /// Constants used for properties of type ReplicaModificationsStatus.
    /// </summary>
    public class ReplicaModificationsStatus : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for ReplicaModificationsStatus
        /// </summary>
        public static readonly ReplicaModificationsStatus Disabled = new ReplicaModificationsStatus("Disabled");
        /// <summary>
        /// Constant Enabled for ReplicaModificationsStatus
        /// </summary>
        public static readonly ReplicaModificationsStatus Enabled = new ReplicaModificationsStatus("Enabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReplicaModificationsStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReplicaModificationsStatus FindValue(string value)
        {
            return FindValue<ReplicaModificationsStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReplicaModificationsStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReplicationRuleStatus.
    /// </summary>
    public class ReplicationRuleStatus : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for ReplicationRuleStatus
        /// </summary>
        public static readonly ReplicationRuleStatus Disabled = new ReplicationRuleStatus("Disabled");
        /// <summary>
        /// Constant Enabled for ReplicationRuleStatus
        /// </summary>
        public static readonly ReplicationRuleStatus Enabled = new ReplicationRuleStatus("Enabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReplicationRuleStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReplicationRuleStatus FindValue(string value)
        {
            return FindValue<ReplicationRuleStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReplicationRuleStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReplicationStatus.
    /// </summary>
    public class ReplicationStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETE for ReplicationStatus
        /// </summary>
        public static readonly ReplicationStatus COMPLETE = new ReplicationStatus("COMPLETE");
        /// <summary>
        /// Constant COMPLETED for ReplicationStatus
        /// </summary>
        public static readonly ReplicationStatus COMPLETED = new ReplicationStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for ReplicationStatus
        /// </summary>
        public static readonly ReplicationStatus FAILED = new ReplicationStatus("FAILED");
        /// <summary>
        /// Constant PENDING for ReplicationStatus
        /// </summary>
        public static readonly ReplicationStatus PENDING = new ReplicationStatus("PENDING");
        /// <summary>
        /// Constant REPLICA for ReplicationStatus
        /// </summary>
        public static readonly ReplicationStatus REPLICA = new ReplicationStatus("REPLICA");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReplicationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReplicationStatus FindValue(string value)
        {
            return FindValue<ReplicationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReplicationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReplicationTimeStatus.
    /// </summary>
    public class ReplicationTimeStatus : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for ReplicationTimeStatus
        /// </summary>
        public static readonly ReplicationTimeStatus Disabled = new ReplicationTimeStatus("Disabled");
        /// <summary>
        /// Constant Enabled for ReplicationTimeStatus
        /// </summary>
        public static readonly ReplicationTimeStatus Enabled = new ReplicationTimeStatus("Enabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReplicationTimeStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReplicationTimeStatus FindValue(string value)
        {
            return FindValue<ReplicationTimeStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReplicationTimeStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RequestCharged.
    /// </summary>
    public class RequestCharged : ConstantClass
    {

        /// <summary>
        /// Constant Requester for RequestCharged
        /// </summary>
        public static readonly RequestCharged Requester = new RequestCharged("requester");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RequestCharged(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RequestCharged FindValue(string value)
        {
            return FindValue<RequestCharged>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RequestCharged(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RequestPayer.
    /// </summary>
    public class RequestPayer : ConstantClass
    {

        /// <summary>
        /// Constant Requester for RequestPayer
        /// </summary>
        public static readonly RequestPayer Requester = new RequestPayer("requester");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RequestPayer(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RequestPayer FindValue(string value)
        {
            return FindValue<RequestPayer>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RequestPayer(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RestoreRequestType.
    /// </summary>
    public class RestoreRequestType : ConstantClass
    {

        /// <summary>
        /// Constant SELECT for RestoreRequestType
        /// </summary>
        public static readonly RestoreRequestType SELECT = new RestoreRequestType("SELECT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RestoreRequestType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RestoreRequestType FindValue(string value)
        {
            return FindValue<RestoreRequestType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RestoreRequestType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServerSideEncryption.
    /// </summary>
    public class ServerSideEncryption : ConstantClass
    {

        /// <summary>
        /// Constant AES256 for ServerSideEncryption
        /// </summary>
        public static readonly ServerSideEncryption AES256 = new ServerSideEncryption("AES256");
        /// <summary>
        /// Constant AWSKMS for ServerSideEncryption
        /// </summary>
        public static readonly ServerSideEncryption AWSKMS = new ServerSideEncryption("aws:kms");
        /// <summary>
        /// Constant AwsKmsDsse for ServerSideEncryption
        /// </summary>
        public static readonly ServerSideEncryption AwsKmsDsse = new ServerSideEncryption("aws:kms:dsse");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServerSideEncryption(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServerSideEncryption FindValue(string value)
        {
            return FindValue<ServerSideEncryption>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServerSideEncryption(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SessionMode.
    /// </summary>
    public class SessionMode : ConstantClass
    {

        /// <summary>
        /// Constant ReadOnly for SessionMode
        /// </summary>
        public static readonly SessionMode ReadOnly = new SessionMode("ReadOnly");
        /// <summary>
        /// Constant ReadWrite for SessionMode
        /// </summary>
        public static readonly SessionMode ReadWrite = new SessionMode("ReadWrite");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SessionMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SessionMode FindValue(string value)
        {
            return FindValue<SessionMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SessionMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SseKmsEncryptedObjectsStatus.
    /// </summary>
    public class SseKmsEncryptedObjectsStatus : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for SseKmsEncryptedObjectsStatus
        /// </summary>
        public static readonly SseKmsEncryptedObjectsStatus Disabled = new SseKmsEncryptedObjectsStatus("Disabled");
        /// <summary>
        /// Constant Enabled for SseKmsEncryptedObjectsStatus
        /// </summary>
        public static readonly SseKmsEncryptedObjectsStatus Enabled = new SseKmsEncryptedObjectsStatus("Enabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SseKmsEncryptedObjectsStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SseKmsEncryptedObjectsStatus FindValue(string value)
        {
            return FindValue<SseKmsEncryptedObjectsStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SseKmsEncryptedObjectsStatus(string value)
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
        /// Constant DeepArchive for StorageClass
        /// </summary>
        public static readonly StorageClass DeepArchive = new StorageClass("DEEP_ARCHIVE");
        /// <summary>
        /// Constant EXPRESS_ONEZONE for StorageClass
        /// </summary>
        public static readonly StorageClass EXPRESS_ONEZONE = new StorageClass("EXPRESS_ONEZONE");
        /// <summary>
        /// Constant Glacier for StorageClass
        /// </summary>
        public static readonly StorageClass Glacier = new StorageClass("GLACIER");
        /// <summary>
        /// Constant GLACIER_IR for StorageClass
        /// </summary>
        public static readonly StorageClass GLACIER_IR = new StorageClass("GLACIER_IR");
        /// <summary>
        /// Constant IntelligentTiering for StorageClass
        /// </summary>
        public static readonly StorageClass IntelligentTiering = new StorageClass("INTELLIGENT_TIERING");
        /// <summary>
        /// Constant OneZoneInfrequentAccess for StorageClass
        /// </summary>
        public static readonly StorageClass OneZoneInfrequentAccess = new StorageClass("ONEZONE_IA");
        /// <summary>
        /// Constant OUTPOSTS for StorageClass
        /// </summary>
        public static readonly StorageClass OUTPOSTS = new StorageClass("OUTPOSTS");
        /// <summary>
        /// Constant ReducedRedundancy for StorageClass
        /// </summary>
        public static readonly StorageClass ReducedRedundancy = new StorageClass("REDUCED_REDUNDANCY");
        /// <summary>
        /// Constant SNOW for StorageClass
        /// </summary>
        public static readonly StorageClass SNOW = new StorageClass("SNOW");
        /// <summary>
        /// Constant Standard for StorageClass
        /// </summary>
        public static readonly StorageClass Standard = new StorageClass("STANDARD");
        /// <summary>
        /// Constant StandardInfrequentAccess for StorageClass
        /// </summary>
        public static readonly StorageClass StandardInfrequentAccess = new StorageClass("STANDARD_IA");

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
    /// Constants used for properties of type StorageClassAnalysisSchemaVersion.
    /// </summary>
    public class StorageClassAnalysisSchemaVersion : ConstantClass
    {

        /// <summary>
        /// Constant V_1 for StorageClassAnalysisSchemaVersion
        /// </summary>
        public static readonly StorageClassAnalysisSchemaVersion V_1 = new StorageClassAnalysisSchemaVersion("V_1");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public StorageClassAnalysisSchemaVersion(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static StorageClassAnalysisSchemaVersion FindValue(string value)
        {
            return FindValue<StorageClassAnalysisSchemaVersion>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator StorageClassAnalysisSchemaVersion(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TaggingDirective.
    /// </summary>
    public class TaggingDirective : ConstantClass
    {

        /// <summary>
        /// Constant COPY for TaggingDirective
        /// </summary>
        public static readonly TaggingDirective COPY = new TaggingDirective("COPY");
        /// <summary>
        /// Constant REPLACE for TaggingDirective
        /// </summary>
        public static readonly TaggingDirective REPLACE = new TaggingDirective("REPLACE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TaggingDirective(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TaggingDirective FindValue(string value)
        {
            return FindValue<TaggingDirective>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TaggingDirective(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Tier.
    /// </summary>
    public class Tier : ConstantClass
    {

        /// <summary>
        /// Constant Bulk for Tier
        /// </summary>
        public static readonly Tier Bulk = new Tier("Bulk");
        /// <summary>
        /// Constant Expedited for Tier
        /// </summary>
        public static readonly Tier Expedited = new Tier("Expedited");
        /// <summary>
        /// Constant Standard for Tier
        /// </summary>
        public static readonly Tier Standard = new Tier("Standard");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Tier(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Tier FindValue(string value)
        {
            return FindValue<Tier>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Tier(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TransitionDefaultMinimumObjectSize.
    /// </summary>
    public class TransitionDefaultMinimumObjectSize : ConstantClass
    {

        /// <summary>
        /// Constant All_storage_classes_128K for TransitionDefaultMinimumObjectSize
        /// </summary>
        public static readonly TransitionDefaultMinimumObjectSize All_storage_classes_128K = new TransitionDefaultMinimumObjectSize("all_storage_classes_128K");
        /// <summary>
        /// Constant Varies_by_storage_class for TransitionDefaultMinimumObjectSize
        /// </summary>
        public static readonly TransitionDefaultMinimumObjectSize Varies_by_storage_class = new TransitionDefaultMinimumObjectSize("varies_by_storage_class");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TransitionDefaultMinimumObjectSize(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TransitionDefaultMinimumObjectSize FindValue(string value)
        {
            return FindValue<TransitionDefaultMinimumObjectSize>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TransitionDefaultMinimumObjectSize(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TransitionStorageClass.
    /// </summary>
    public class TransitionStorageClass : ConstantClass
    {

        /// <summary>
        /// Constant DEEP_ARCHIVE for TransitionStorageClass
        /// </summary>
        public static readonly TransitionStorageClass DEEP_ARCHIVE = new TransitionStorageClass("DEEP_ARCHIVE");
        /// <summary>
        /// Constant GLACIER for TransitionStorageClass
        /// </summary>
        public static readonly TransitionStorageClass GLACIER = new TransitionStorageClass("GLACIER");
        /// <summary>
        /// Constant GLACIER_IR for TransitionStorageClass
        /// </summary>
        public static readonly TransitionStorageClass GLACIER_IR = new TransitionStorageClass("GLACIER_IR");
        /// <summary>
        /// Constant INTELLIGENT_TIERING for TransitionStorageClass
        /// </summary>
        public static readonly TransitionStorageClass INTELLIGENT_TIERING = new TransitionStorageClass("INTELLIGENT_TIERING");
        /// <summary>
        /// Constant ONEZONE_IA for TransitionStorageClass
        /// </summary>
        public static readonly TransitionStorageClass ONEZONE_IA = new TransitionStorageClass("ONEZONE_IA");
        /// <summary>
        /// Constant STANDARD_IA for TransitionStorageClass
        /// </summary>
        public static readonly TransitionStorageClass STANDARD_IA = new TransitionStorageClass("STANDARD_IA");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TransitionStorageClass(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TransitionStorageClass FindValue(string value)
        {
            return FindValue<TransitionStorageClass>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TransitionStorageClass(string value)
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