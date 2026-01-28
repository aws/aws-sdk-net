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
    public partial class AnalyticsS3ExportFileFormat : ConstantClass
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
    public partial class ArchiveStatus : ConstantClass
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
    /// Constants used for properties of type BucketAbacStatus.
    /// </summary>
    public partial class BucketAbacStatus : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for BucketAbacStatus
        /// </summary>
        public static readonly BucketAbacStatus Disabled = new BucketAbacStatus("Disabled");
        /// <summary>
        /// Constant Enabled for BucketAbacStatus
        /// </summary>
        public static readonly BucketAbacStatus Enabled = new BucketAbacStatus("Enabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BucketAbacStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BucketAbacStatus FindValue(string value)
        {
            return FindValue<BucketAbacStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BucketAbacStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BucketAccelerateStatus.
    /// </summary>
    public partial class BucketAccelerateStatus : ConstantClass
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
    /// Constants used for properties of type BucketLocationConstraint.
    /// </summary>
    public partial class BucketLocationConstraint : ConstantClass
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
        /// Constant CaWest1 for BucketLocationConstraint
        /// </summary>
        public static readonly BucketLocationConstraint CaWest1 = new BucketLocationConstraint("ca-west-1");
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
    /// Constants used for properties of type BucketType.
    /// </summary>
    public partial class BucketType : ConstantClass
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
    /// Constants used for properties of type ChecksumAlgorithm.
    /// </summary>
    public partial class ChecksumAlgorithm : ConstantClass
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
    public partial class ChecksumMode : ConstantClass
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
    public partial class ChecksumType : ConstantClass
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
    public partial class CompressionType : ConstantClass
    {

        /// <summary>
        /// Constant Bzip2 for CompressionType
        /// </summary>
        public static readonly CompressionType Bzip2 = new CompressionType("BZIP2");
        /// <summary>
        /// Constant Gzip for CompressionType
        /// </summary>
        public static readonly CompressionType Gzip = new CompressionType("GZIP");
        /// <summary>
        /// Constant None for CompressionType
        /// </summary>
        public static readonly CompressionType None = new CompressionType("NONE");

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
    public partial class DataRedundancy : ConstantClass
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
    public partial class DeleteMarkerReplicationStatus : ConstantClass
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
    public partial class EncodingType : ConstantClass
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
    /// Constants used for properties of type EncryptionType.
    /// </summary>
    public partial class EncryptionType : ConstantClass
    {

        /// <summary>
        /// Constant NONE for EncryptionType
        /// </summary>
        public static readonly EncryptionType NONE = new EncryptionType("NONE");
        /// <summary>
        /// Constant SSEC for EncryptionType
        /// </summary>
        public static readonly EncryptionType SSEC = new EncryptionType("SSE-C");

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
    /// Constants used for properties of type EventType.
    /// </summary>
    public partial class EventType : ConstantClass
    {

        /// <summary>
        /// Constant ObjectCreatedAll for EventType
        /// </summary>
        public static readonly EventType ObjectCreatedAll = new EventType("s3:ObjectCreated:*");
        /// <summary>
        /// Constant ObjectCreatedCompleteMultipartUpload for EventType
        /// </summary>
        public static readonly EventType ObjectCreatedCompleteMultipartUpload = new EventType("s3:ObjectCreated:CompleteMultipartUpload");
        /// <summary>
        /// Constant ObjectCreatedCopy for EventType
        /// </summary>
        public static readonly EventType ObjectCreatedCopy = new EventType("s3:ObjectCreated:Copy");
        /// <summary>
        /// Constant ObjectCreatedPost for EventType
        /// </summary>
        public static readonly EventType ObjectCreatedPost = new EventType("s3:ObjectCreated:Post");
        /// <summary>
        /// Constant ObjectCreatedPut for EventType
        /// </summary>
        public static readonly EventType ObjectCreatedPut = new EventType("s3:ObjectCreated:Put");
        /// <summary>
        /// Constant ObjectRemovedAll for EventType
        /// </summary>
        public static readonly EventType ObjectRemovedAll = new EventType("s3:ObjectRemoved:*");
        /// <summary>
        /// Constant ObjectRemovedDelete for EventType
        /// </summary>
        public static readonly EventType ObjectRemovedDelete = new EventType("s3:ObjectRemoved:Delete");
        /// <summary>
        /// Constant ObjectRemovedDeleteMarkerCreated for EventType
        /// </summary>
        public static readonly EventType ObjectRemovedDeleteMarkerCreated = new EventType("s3:ObjectRemoved:DeleteMarkerCreated");
        /// <summary>
        /// Constant ObjectRestoreAll for EventType
        /// </summary>
        public static readonly EventType ObjectRestoreAll = new EventType("s3:ObjectRestore:*");
        /// <summary>
        /// Constant ObjectRestoreCompleted for EventType
        /// </summary>
        public static readonly EventType ObjectRestoreCompleted = new EventType("s3:ObjectRestore:Completed");
        /// <summary>
        /// Constant ObjectRestorePost for EventType
        /// </summary>
        public static readonly EventType ObjectRestorePost = new EventType("s3:ObjectRestore:Post");
        /// <summary>
        /// Constant ReducedRedundancyLostObject for EventType
        /// </summary>
        public static readonly EventType ReducedRedundancyLostObject = new EventType("s3:ReducedRedundancyLostObject");
        /// <summary>
        /// Constant ReplicationAll for EventType
        /// </summary>
        public static readonly EventType ReplicationAll = new EventType("s3:Replication:*");
        /// <summary>
        /// Constant ReplicationOperationFailedReplication for EventType
        /// </summary>
        public static readonly EventType ReplicationOperationFailedReplication = new EventType("s3:Replication:OperationFailedReplication");
        /// <summary>
        /// Constant ReplicationOperationMissedThreshold for EventType
        /// </summary>
        public static readonly EventType ReplicationOperationMissedThreshold = new EventType("s3:Replication:OperationMissedThreshold");
        /// <summary>
        /// Constant ReplicationOperationNotTracked for EventType
        /// </summary>
        public static readonly EventType ReplicationOperationNotTracked = new EventType("s3:Replication:OperationNotTracked");
        /// <summary>
        /// Constant ReplicationOperationReplicatedAfterThreshold for EventType
        /// </summary>
        public static readonly EventType ReplicationOperationReplicatedAfterThreshold = new EventType("s3:Replication:OperationReplicatedAfterThreshold");
        /// <summary>
        /// Constant S3IntelligentTiering for EventType
        /// </summary>
        public static readonly EventType S3IntelligentTiering = new EventType("s3:IntelligentTiering");
        /// <summary>
        /// Constant S3LifecycleExpirationAll for EventType
        /// </summary>
        public static readonly EventType S3LifecycleExpirationAll = new EventType("s3:LifecycleExpiration:*");
        /// <summary>
        /// Constant S3LifecycleExpirationDelete for EventType
        /// </summary>
        public static readonly EventType S3LifecycleExpirationDelete = new EventType("s3:LifecycleExpiration:Delete");
        /// <summary>
        /// Constant S3LifecycleExpirationDeleteMarkerCreated for EventType
        /// </summary>
        public static readonly EventType S3LifecycleExpirationDeleteMarkerCreated = new EventType("s3:LifecycleExpiration:DeleteMarkerCreated");
        /// <summary>
        /// Constant S3LifecycleTransition for EventType
        /// </summary>
        public static readonly EventType S3LifecycleTransition = new EventType("s3:LifecycleTransition");
        /// <summary>
        /// Constant S3ObjectAclPut for EventType
        /// </summary>
        public static readonly EventType S3ObjectAclPut = new EventType("s3:ObjectAcl:Put");
        /// <summary>
        /// Constant S3ObjectRestoreDelete for EventType
        /// </summary>
        public static readonly EventType S3ObjectRestoreDelete = new EventType("s3:ObjectRestore:Delete");
        /// <summary>
        /// Constant S3ObjectTaggingAll for EventType
        /// </summary>
        public static readonly EventType S3ObjectTaggingAll = new EventType("s3:ObjectTagging:*");
        /// <summary>
        /// Constant S3ObjectTaggingDelete for EventType
        /// </summary>
        public static readonly EventType S3ObjectTaggingDelete = new EventType("s3:ObjectTagging:Delete");
        /// <summary>
        /// Constant S3ObjectTaggingPut for EventType
        /// </summary>
        public static readonly EventType S3ObjectTaggingPut = new EventType("s3:ObjectTagging:Put");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EventType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EventType FindValue(string value)
        {
            return FindValue<EventType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EventType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExistingObjectReplicationStatus.
    /// </summary>
    public partial class ExistingObjectReplicationStatus : ConstantClass
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
    /// Constants used for properties of type ExpirationState.
    /// </summary>
    public partial class ExpirationState : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for ExpirationState
        /// </summary>
        public static readonly ExpirationState Disabled = new ExpirationState("DISABLED");
        /// <summary>
        /// Constant Enabled for ExpirationState
        /// </summary>
        public static readonly ExpirationState Enabled = new ExpirationState("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExpirationState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExpirationState FindValue(string value)
        {
            return FindValue<ExpirationState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExpirationState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExpressionType.
    /// </summary>
    public partial class ExpressionType : ConstantClass
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
    public partial class FileHeaderInfo : ConstantClass
    {

        /// <summary>
        /// Constant Ignore for FileHeaderInfo
        /// </summary>
        public static readonly FileHeaderInfo Ignore = new FileHeaderInfo("IGNORE");
        /// <summary>
        /// Constant None for FileHeaderInfo
        /// </summary>
        public static readonly FileHeaderInfo None = new FileHeaderInfo("NONE");
        /// <summary>
        /// Constant Use for FileHeaderInfo
        /// </summary>
        public static readonly FileHeaderInfo Use = new FileHeaderInfo("USE");

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
    public partial class FilterRuleName : ConstantClass
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
    /// Constants used for properties of type GlacierJobTier.
    /// </summary>
    public partial class GlacierJobTier : ConstantClass
    {

        /// <summary>
        /// Constant Bulk for GlacierJobTier
        /// </summary>
        public static readonly GlacierJobTier Bulk = new GlacierJobTier("Bulk");
        /// <summary>
        /// Constant Expedited for GlacierJobTier
        /// </summary>
        public static readonly GlacierJobTier Expedited = new GlacierJobTier("Expedited");
        /// <summary>
        /// Constant Standard for GlacierJobTier
        /// </summary>
        public static readonly GlacierJobTier Standard = new GlacierJobTier("Standard");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GlacierJobTier(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GlacierJobTier FindValue(string value)
        {
            return FindValue<GlacierJobTier>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GlacierJobTier(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type GranteeType.
    /// </summary>
    public partial class GranteeType : ConstantClass
    {

        /// <summary>
        /// Constant CanonicalUser for GranteeType
        /// </summary>
        public static readonly GranteeType CanonicalUser = new GranteeType("CanonicalUser");
        /// <summary>
        /// Constant Email for GranteeType
        /// </summary>
        public static readonly GranteeType Email = new GranteeType("AmazonCustomerByEmail");
        /// <summary>
        /// Constant Group for GranteeType
        /// </summary>
        public static readonly GranteeType Group = new GranteeType("Group");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public GranteeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static GranteeType FindValue(string value)
        {
            return FindValue<GranteeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator GranteeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IntelligentTieringAccessTier.
    /// </summary>
    public partial class IntelligentTieringAccessTier : ConstantClass
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
    public partial class IntelligentTieringStatus : ConstantClass
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
    /// Constants used for properties of type InventoryConfigurationState.
    /// </summary>
    public partial class InventoryConfigurationState : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for InventoryConfigurationState
        /// </summary>
        public static readonly InventoryConfigurationState Disabled = new InventoryConfigurationState("DISABLED");
        /// <summary>
        /// Constant Enabled for InventoryConfigurationState
        /// </summary>
        public static readonly InventoryConfigurationState Enabled = new InventoryConfigurationState("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InventoryConfigurationState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InventoryConfigurationState FindValue(string value)
        {
            return FindValue<InventoryConfigurationState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InventoryConfigurationState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InventoryFormat.
    /// </summary>
    public partial class InventoryFormat : ConstantClass
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
    public partial class InventoryFrequency : ConstantClass
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
    public partial class InventoryIncludedObjectVersions : ConstantClass
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
    public partial class InventoryOptionalField : ConstantClass
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
        /// Constant LifecycleExpirationDate for InventoryOptionalField
        /// </summary>
        public static readonly InventoryOptionalField LifecycleExpirationDate = new InventoryOptionalField("LifecycleExpirationDate");
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
    /// Constants used for properties of type JsonType.
    /// </summary>
    public partial class JsonType : ConstantClass
    {

        /// <summary>
        /// Constant Document for JsonType
        /// </summary>
        public static readonly JsonType Document = new JsonType("DOCUMENT");
        /// <summary>
        /// Constant Lines for JsonType
        /// </summary>
        public static readonly JsonType Lines = new JsonType("LINES");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JsonType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JsonType FindValue(string value)
        {
            return FindValue<JsonType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JsonType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LifecycleRuleStatus.
    /// </summary>
    public partial class LifecycleRuleStatus : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for LifecycleRuleStatus
        /// </summary>
        public static readonly LifecycleRuleStatus Disabled = new LifecycleRuleStatus("Disabled");
        /// <summary>
        /// Constant Enabled for LifecycleRuleStatus
        /// </summary>
        public static readonly LifecycleRuleStatus Enabled = new LifecycleRuleStatus("Enabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LifecycleRuleStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LifecycleRuleStatus FindValue(string value)
        {
            return FindValue<LifecycleRuleStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LifecycleRuleStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LocationType.
    /// </summary>
    public partial class LocationType : ConstantClass
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
    /// Constants used for properties of type MetricsStatus.
    /// </summary>
    public partial class MetricsStatus : ConstantClass
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
    /// Constants used for properties of type ObjectAttributes.
    /// </summary>
    public partial class ObjectAttributes : ConstantClass
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
    /// Constants used for properties of type ObjectLockEnabled.
    /// </summary>
    public partial class ObjectLockEnabled : ConstantClass
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
    public partial class ObjectLockLegalHoldStatus : ConstantClass
    {

        /// <summary>
        /// Constant Off for ObjectLockLegalHoldStatus
        /// </summary>
        public static readonly ObjectLockLegalHoldStatus Off = new ObjectLockLegalHoldStatus("OFF");
        /// <summary>
        /// Constant On for ObjectLockLegalHoldStatus
        /// </summary>
        public static readonly ObjectLockLegalHoldStatus On = new ObjectLockLegalHoldStatus("ON");

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
    public partial class ObjectLockMode : ConstantClass
    {

        /// <summary>
        /// Constant Compliance for ObjectLockMode
        /// </summary>
        public static readonly ObjectLockMode Compliance = new ObjectLockMode("COMPLIANCE");
        /// <summary>
        /// Constant Governance for ObjectLockMode
        /// </summary>
        public static readonly ObjectLockMode Governance = new ObjectLockMode("GOVERNANCE");

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
    public partial class ObjectLockRetentionMode : ConstantClass
    {

        /// <summary>
        /// Constant Compliance for ObjectLockRetentionMode
        /// </summary>
        public static readonly ObjectLockRetentionMode Compliance = new ObjectLockRetentionMode("COMPLIANCE");
        /// <summary>
        /// Constant Governance for ObjectLockRetentionMode
        /// </summary>
        public static readonly ObjectLockRetentionMode Governance = new ObjectLockRetentionMode("GOVERNANCE");

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
    public partial class ObjectOwnership : ConstantClass
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
    /// Constants used for properties of type OptionalObjectAttributes.
    /// </summary>
    public partial class OptionalObjectAttributes : ConstantClass
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
    public partial class OwnerOverride : ConstantClass
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
    public partial class PartitionDateSource : ConstantClass
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
    public partial class Payer : ConstantClass
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
    /// Constants used for properties of type QuoteFields.
    /// </summary>
    public partial class QuoteFields : ConstantClass
    {

        /// <summary>
        /// Constant Always for QuoteFields
        /// </summary>
        public static readonly QuoteFields Always = new QuoteFields("ALWAYS");
        /// <summary>
        /// Constant AsNeeded for QuoteFields
        /// </summary>
        public static readonly QuoteFields AsNeeded = new QuoteFields("ASNEEDED");

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
    public partial class ReplicaModificationsStatus : ConstantClass
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
    public partial class ReplicationRuleStatus : ConstantClass
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
    public partial class ReplicationStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETE for ReplicationStatus
        /// </summary>
        public static readonly ReplicationStatus COMPLETE = new ReplicationStatus("COMPLETE");
        /// <summary>
        /// Constant Completed for ReplicationStatus
        /// </summary>
        public static readonly ReplicationStatus Completed = new ReplicationStatus("COMPLETED");
        /// <summary>
        /// Constant Failed for ReplicationStatus
        /// </summary>
        public static readonly ReplicationStatus Failed = new ReplicationStatus("FAILED");
        /// <summary>
        /// Constant Pending for ReplicationStatus
        /// </summary>
        public static readonly ReplicationStatus Pending = new ReplicationStatus("PENDING");
        /// <summary>
        /// Constant Replica for ReplicationStatus
        /// </summary>
        public static readonly ReplicationStatus Replica = new ReplicationStatus("REPLICA");

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
    public partial class ReplicationTimeStatus : ConstantClass
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
    public partial class RequestCharged : ConstantClass
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
    public partial class RequestPayer : ConstantClass
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
    public partial class RestoreRequestType : ConstantClass
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
    /// Constants used for properties of type S3CannedACL.
    /// </summary>
    public partial class S3CannedACL : ConstantClass
    {

        /// <summary>
        /// Constant AuthenticatedRead for S3CannedACL
        /// </summary>
        public static readonly S3CannedACL AuthenticatedRead = new S3CannedACL("authenticated-read");
        /// <summary>
        /// Constant AWSExecRead for S3CannedACL
        /// </summary>
        public static readonly S3CannedACL AWSExecRead = new S3CannedACL("aws-exec-read");
        /// <summary>
        /// Constant BucketOwnerFullControl for S3CannedACL
        /// </summary>
        public static readonly S3CannedACL BucketOwnerFullControl = new S3CannedACL("bucket-owner-full-control");
        /// <summary>
        /// Constant BucketOwnerRead for S3CannedACL
        /// </summary>
        public static readonly S3CannedACL BucketOwnerRead = new S3CannedACL("bucket-owner-read");
        /// <summary>
        /// Constant LogDeliveryWrite for S3CannedACL
        /// </summary>
        public static readonly S3CannedACL LogDeliveryWrite = new S3CannedACL("log-delivery-write");
        /// <summary>
        /// Constant NoACL for S3CannedACL
        /// </summary>
        public static readonly S3CannedACL NoACL = new S3CannedACL("");
        /// <summary>
        /// Constant Private for S3CannedACL
        /// </summary>
        public static readonly S3CannedACL Private = new S3CannedACL("private");
        /// <summary>
        /// Constant PublicRead for S3CannedACL
        /// </summary>
        public static readonly S3CannedACL PublicRead = new S3CannedACL("public-read");
        /// <summary>
        /// Constant PublicReadWrite for S3CannedACL
        /// </summary>
        public static readonly S3CannedACL PublicReadWrite = new S3CannedACL("public-read-write");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public S3CannedACL(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static S3CannedACL FindValue(string value)
        {
            return FindValue<S3CannedACL>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator S3CannedACL(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type S3Permission.
    /// </summary>
    public partial class S3Permission : ConstantClass
    {


        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public S3Permission(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static S3Permission FindValue(string value)
        {
            return FindValue<S3Permission>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator S3Permission(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type S3StorageClass.
    /// </summary>
    public partial class S3StorageClass : ConstantClass
    {

        /// <summary>
        /// Constant DeepArchive for S3StorageClass
        /// </summary>
        public static readonly S3StorageClass DeepArchive = new S3StorageClass("DEEP_ARCHIVE");
        /// <summary>
        /// Constant ExpressOnezone for S3StorageClass
        /// </summary>
        public static readonly S3StorageClass ExpressOnezone = new S3StorageClass("EXPRESS_ONEZONE");
        /// <summary>
        /// Constant FSX_ONTAP for S3StorageClass
        /// </summary>
        public static readonly S3StorageClass FSX_ONTAP = new S3StorageClass("FSX_ONTAP");
        /// <summary>
        /// Constant FSX_OPENZFS for S3StorageClass
        /// </summary>
        public static readonly S3StorageClass FSX_OPENZFS = new S3StorageClass("FSX_OPENZFS");
        /// <summary>
        /// Constant Glacier for S3StorageClass
        /// </summary>
        public static readonly S3StorageClass Glacier = new S3StorageClass("GLACIER");
        /// <summary>
        /// Constant GlacierInstantRetrieval for S3StorageClass
        /// </summary>
        public static readonly S3StorageClass GlacierInstantRetrieval = new S3StorageClass("GLACIER_IR");
        /// <summary>
        /// Constant IntelligentTiering for S3StorageClass
        /// </summary>
        public static readonly S3StorageClass IntelligentTiering = new S3StorageClass("INTELLIGENT_TIERING");
        /// <summary>
        /// Constant OneZoneInfrequentAccess for S3StorageClass
        /// </summary>
        public static readonly S3StorageClass OneZoneInfrequentAccess = new S3StorageClass("ONEZONE_IA");
        /// <summary>
        /// Constant Outposts for S3StorageClass
        /// </summary>
        public static readonly S3StorageClass Outposts = new S3StorageClass("OUTPOSTS");
        /// <summary>
        /// Constant ReducedRedundancy for S3StorageClass
        /// </summary>
        public static readonly S3StorageClass ReducedRedundancy = new S3StorageClass("REDUCED_REDUNDANCY");
        /// <summary>
        /// Constant Snow for S3StorageClass
        /// </summary>
        public static readonly S3StorageClass Snow = new S3StorageClass("SNOW");
        /// <summary>
        /// Constant Standard for S3StorageClass
        /// </summary>
        public static readonly S3StorageClass Standard = new S3StorageClass("STANDARD");
        /// <summary>
        /// Constant StandardInfrequentAccess for S3StorageClass
        /// </summary>
        public static readonly S3StorageClass StandardInfrequentAccess = new S3StorageClass("STANDARD_IA");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public S3StorageClass(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static S3StorageClass FindValue(string value)
        {
            return FindValue<S3StorageClass>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator S3StorageClass(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type S3TablesBucketType.
    /// </summary>
    public partial class S3TablesBucketType : ConstantClass
    {

        /// <summary>
        /// Constant Aws for S3TablesBucketType
        /// </summary>
        public static readonly S3TablesBucketType Aws = new S3TablesBucketType("aws");
        /// <summary>
        /// Constant Customer for S3TablesBucketType
        /// </summary>
        public static readonly S3TablesBucketType Customer = new S3TablesBucketType("customer");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public S3TablesBucketType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static S3TablesBucketType FindValue(string value)
        {
            return FindValue<S3TablesBucketType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator S3TablesBucketType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServerSideEncryptionMethod.
    /// </summary>
    public partial class ServerSideEncryptionMethod : ConstantClass
    {

        /// <summary>
        /// Constant AES256 for ServerSideEncryptionMethod
        /// </summary>
        public static readonly ServerSideEncryptionMethod AES256 = new ServerSideEncryptionMethod("AES256");
        /// <summary>
        /// Constant AWSFSX for ServerSideEncryptionMethod
        /// </summary>
        public static readonly ServerSideEncryptionMethod AWSFSX = new ServerSideEncryptionMethod("aws:fsx");
        /// <summary>
        /// Constant AWSKMS for ServerSideEncryptionMethod
        /// </summary>
        public static readonly ServerSideEncryptionMethod AWSKMS = new ServerSideEncryptionMethod("aws:kms");
        /// <summary>
        /// Constant AWSKMSDSSE for ServerSideEncryptionMethod
        /// </summary>
        public static readonly ServerSideEncryptionMethod AWSKMSDSSE = new ServerSideEncryptionMethod("aws:kms:dsse");
        /// <summary>
        /// Constant None for ServerSideEncryptionMethod
        /// </summary>
        public static readonly ServerSideEncryptionMethod None = new ServerSideEncryptionMethod("");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServerSideEncryptionMethod(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServerSideEncryptionMethod FindValue(string value)
        {
            return FindValue<ServerSideEncryptionMethod>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServerSideEncryptionMethod(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SessionMode.
    /// </summary>
    public partial class SessionMode : ConstantClass
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
    public partial class SseKmsEncryptedObjectsStatus : ConstantClass
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
    /// Constants used for properties of type StorageClassAnalysisSchemaVersion.
    /// </summary>
    public partial class StorageClassAnalysisSchemaVersion : ConstantClass
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
    /// Constants used for properties of type TableSseAlgorithm.
    /// </summary>
    public partial class TableSseAlgorithm : ConstantClass
    {

        /// <summary>
        /// Constant AES256 for TableSseAlgorithm
        /// </summary>
        public static readonly TableSseAlgorithm AES256 = new TableSseAlgorithm("AES256");
        /// <summary>
        /// Constant AwsKms for TableSseAlgorithm
        /// </summary>
        public static readonly TableSseAlgorithm AwsKms = new TableSseAlgorithm("aws:kms");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TableSseAlgorithm(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TableSseAlgorithm FindValue(string value)
        {
            return FindValue<TableSseAlgorithm>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TableSseAlgorithm(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TaggingDirective.
    /// </summary>
    public partial class TaggingDirective : ConstantClass
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
    /// Constants used for properties of type TransitionDefaultMinimumObjectSize.
    /// </summary>
    public partial class TransitionDefaultMinimumObjectSize : ConstantClass
    {

        /// <summary>
        /// Constant AllStorageClasses128K for TransitionDefaultMinimumObjectSize
        /// </summary>
        public static readonly TransitionDefaultMinimumObjectSize AllStorageClasses128K = new TransitionDefaultMinimumObjectSize("all_storage_classes_128K");
        /// <summary>
        /// Constant VariesByStorageClass for TransitionDefaultMinimumObjectSize
        /// </summary>
        public static readonly TransitionDefaultMinimumObjectSize VariesByStorageClass = new TransitionDefaultMinimumObjectSize("varies_by_storage_class");

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
    /// Constants used for properties of type VersionStatus.
    /// </summary>
    public partial class VersionStatus : ConstantClass
    {

        /// <summary>
        /// Constant Enabled for VersionStatus
        /// </summary>
        public static readonly VersionStatus Enabled = new VersionStatus("Enabled");
        /// <summary>
        /// Constant Off for VersionStatus
        /// </summary>
        public static readonly VersionStatus Off = new VersionStatus("Off");
        /// <summary>
        /// Constant Suspended for VersionStatus
        /// </summary>
        public static readonly VersionStatus Suspended = new VersionStatus("Suspended");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VersionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VersionStatus FindValue(string value)
        {
            return FindValue<VersionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VersionStatus(string value)
        {
            return FindValue(value);
        }
    }

}