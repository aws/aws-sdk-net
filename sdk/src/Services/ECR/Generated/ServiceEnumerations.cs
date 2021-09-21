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
 * Do not modify this file. This file is generated from the ecr-2015-09-21.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.ECR
{

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
        /// Constant KMS for EncryptionType
        /// </summary>
        public static readonly EncryptionType KMS = new EncryptionType("KMS");

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
    /// Constants used for properties of type FindingSeverity.
    /// </summary>
    public class FindingSeverity : ConstantClass
    {

        /// <summary>
        /// Constant CRITICAL for FindingSeverity
        /// </summary>
        public static readonly FindingSeverity CRITICAL = new FindingSeverity("CRITICAL");
        /// <summary>
        /// Constant HIGH for FindingSeverity
        /// </summary>
        public static readonly FindingSeverity HIGH = new FindingSeverity("HIGH");
        /// <summary>
        /// Constant INFORMATIONAL for FindingSeverity
        /// </summary>
        public static readonly FindingSeverity INFORMATIONAL = new FindingSeverity("INFORMATIONAL");
        /// <summary>
        /// Constant LOW for FindingSeverity
        /// </summary>
        public static readonly FindingSeverity LOW = new FindingSeverity("LOW");
        /// <summary>
        /// Constant MEDIUM for FindingSeverity
        /// </summary>
        public static readonly FindingSeverity MEDIUM = new FindingSeverity("MEDIUM");
        /// <summary>
        /// Constant UNDEFINED for FindingSeverity
        /// </summary>
        public static readonly FindingSeverity UNDEFINED = new FindingSeverity("UNDEFINED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FindingSeverity(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FindingSeverity FindValue(string value)
        {
            return FindValue<FindingSeverity>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FindingSeverity(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImageActionType.
    /// </summary>
    public class ImageActionType : ConstantClass
    {

        /// <summary>
        /// Constant EXPIRE for ImageActionType
        /// </summary>
        public static readonly ImageActionType EXPIRE = new ImageActionType("EXPIRE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImageActionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImageActionType FindValue(string value)
        {
            return FindValue<ImageActionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImageActionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImageFailureCode.
    /// </summary>
    public class ImageFailureCode : ConstantClass
    {

        /// <summary>
        /// Constant ImageNotFound for ImageFailureCode
        /// </summary>
        public static readonly ImageFailureCode ImageNotFound = new ImageFailureCode("ImageNotFound");
        /// <summary>
        /// Constant ImageReferencedByManifestList for ImageFailureCode
        /// </summary>
        public static readonly ImageFailureCode ImageReferencedByManifestList = new ImageFailureCode("ImageReferencedByManifestList");
        /// <summary>
        /// Constant ImageTagDoesNotMatchDigest for ImageFailureCode
        /// </summary>
        public static readonly ImageFailureCode ImageTagDoesNotMatchDigest = new ImageFailureCode("ImageTagDoesNotMatchDigest");
        /// <summary>
        /// Constant InvalidImageDigest for ImageFailureCode
        /// </summary>
        public static readonly ImageFailureCode InvalidImageDigest = new ImageFailureCode("InvalidImageDigest");
        /// <summary>
        /// Constant InvalidImageTag for ImageFailureCode
        /// </summary>
        public static readonly ImageFailureCode InvalidImageTag = new ImageFailureCode("InvalidImageTag");
        /// <summary>
        /// Constant KmsError for ImageFailureCode
        /// </summary>
        public static readonly ImageFailureCode KmsError = new ImageFailureCode("KmsError");
        /// <summary>
        /// Constant MissingDigestAndTag for ImageFailureCode
        /// </summary>
        public static readonly ImageFailureCode MissingDigestAndTag = new ImageFailureCode("MissingDigestAndTag");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImageFailureCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImageFailureCode FindValue(string value)
        {
            return FindValue<ImageFailureCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImageFailureCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ImageTagMutability.
    /// </summary>
    public class ImageTagMutability : ConstantClass
    {

        /// <summary>
        /// Constant IMMUTABLE for ImageTagMutability
        /// </summary>
        public static readonly ImageTagMutability IMMUTABLE = new ImageTagMutability("IMMUTABLE");
        /// <summary>
        /// Constant MUTABLE for ImageTagMutability
        /// </summary>
        public static readonly ImageTagMutability MUTABLE = new ImageTagMutability("MUTABLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImageTagMutability(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImageTagMutability FindValue(string value)
        {
            return FindValue<ImageTagMutability>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImageTagMutability(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LayerAvailability.
    /// </summary>
    public class LayerAvailability : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for LayerAvailability
        /// </summary>
        public static readonly LayerAvailability AVAILABLE = new LayerAvailability("AVAILABLE");
        /// <summary>
        /// Constant UNAVAILABLE for LayerAvailability
        /// </summary>
        public static readonly LayerAvailability UNAVAILABLE = new LayerAvailability("UNAVAILABLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LayerAvailability(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LayerAvailability FindValue(string value)
        {
            return FindValue<LayerAvailability>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LayerAvailability(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LayerFailureCode.
    /// </summary>
    public class LayerFailureCode : ConstantClass
    {

        /// <summary>
        /// Constant InvalidLayerDigest for LayerFailureCode
        /// </summary>
        public static readonly LayerFailureCode InvalidLayerDigest = new LayerFailureCode("InvalidLayerDigest");
        /// <summary>
        /// Constant MissingLayerDigest for LayerFailureCode
        /// </summary>
        public static readonly LayerFailureCode MissingLayerDigest = new LayerFailureCode("MissingLayerDigest");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LayerFailureCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LayerFailureCode FindValue(string value)
        {
            return FindValue<LayerFailureCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LayerFailureCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LifecyclePolicyPreviewStatus.
    /// </summary>
    public class LifecyclePolicyPreviewStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETE for LifecyclePolicyPreviewStatus
        /// </summary>
        public static readonly LifecyclePolicyPreviewStatus COMPLETE = new LifecyclePolicyPreviewStatus("COMPLETE");
        /// <summary>
        /// Constant EXPIRED for LifecyclePolicyPreviewStatus
        /// </summary>
        public static readonly LifecyclePolicyPreviewStatus EXPIRED = new LifecyclePolicyPreviewStatus("EXPIRED");
        /// <summary>
        /// Constant FAILED for LifecyclePolicyPreviewStatus
        /// </summary>
        public static readonly LifecyclePolicyPreviewStatus FAILED = new LifecyclePolicyPreviewStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for LifecyclePolicyPreviewStatus
        /// </summary>
        public static readonly LifecyclePolicyPreviewStatus IN_PROGRESS = new LifecyclePolicyPreviewStatus("IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LifecyclePolicyPreviewStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LifecyclePolicyPreviewStatus FindValue(string value)
        {
            return FindValue<LifecyclePolicyPreviewStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LifecyclePolicyPreviewStatus(string value)
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
        /// Constant FAILED for ReplicationStatus
        /// </summary>
        public static readonly ReplicationStatus FAILED = new ReplicationStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for ReplicationStatus
        /// </summary>
        public static readonly ReplicationStatus IN_PROGRESS = new ReplicationStatus("IN_PROGRESS");

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
    /// Constants used for properties of type RepositoryFilterType.
    /// </summary>
    public class RepositoryFilterType : ConstantClass
    {

        /// <summary>
        /// Constant PREFIX_MATCH for RepositoryFilterType
        /// </summary>
        public static readonly RepositoryFilterType PREFIX_MATCH = new RepositoryFilterType("PREFIX_MATCH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RepositoryFilterType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RepositoryFilterType FindValue(string value)
        {
            return FindValue<RepositoryFilterType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RepositoryFilterType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScanStatus.
    /// </summary>
    public class ScanStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETE for ScanStatus
        /// </summary>
        public static readonly ScanStatus COMPLETE = new ScanStatus("COMPLETE");
        /// <summary>
        /// Constant FAILED for ScanStatus
        /// </summary>
        public static readonly ScanStatus FAILED = new ScanStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for ScanStatus
        /// </summary>
        public static readonly ScanStatus IN_PROGRESS = new ScanStatus("IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScanStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScanStatus FindValue(string value)
        {
            return FindValue<ScanStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScanStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TagStatus.
    /// </summary>
    public class TagStatus : ConstantClass
    {

        /// <summary>
        /// Constant ANY for TagStatus
        /// </summary>
        public static readonly TagStatus ANY = new TagStatus("ANY");
        /// <summary>
        /// Constant TAGGED for TagStatus
        /// </summary>
        public static readonly TagStatus TAGGED = new TagStatus("TAGGED");
        /// <summary>
        /// Constant UNTAGGED for TagStatus
        /// </summary>
        public static readonly TagStatus UNTAGGED = new TagStatus("UNTAGGED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TagStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TagStatus FindValue(string value)
        {
            return FindValue<TagStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TagStatus(string value)
        {
            return FindValue(value);
        }
    }

}