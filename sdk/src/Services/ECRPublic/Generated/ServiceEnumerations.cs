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
 * Do not modify this file. This file is generated from the ecr-public-2020-10-30.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.ECRPublic
{

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
    /// Constants used for properties of type RegistryAliasStatus.
    /// </summary>
    public class RegistryAliasStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for RegistryAliasStatus
        /// </summary>
        public static readonly RegistryAliasStatus ACTIVE = new RegistryAliasStatus("ACTIVE");
        /// <summary>
        /// Constant PENDING for RegistryAliasStatus
        /// </summary>
        public static readonly RegistryAliasStatus PENDING = new RegistryAliasStatus("PENDING");
        /// <summary>
        /// Constant REJECTED for RegistryAliasStatus
        /// </summary>
        public static readonly RegistryAliasStatus REJECTED = new RegistryAliasStatus("REJECTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RegistryAliasStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RegistryAliasStatus FindValue(string value)
        {
            return FindValue<RegistryAliasStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RegistryAliasStatus(string value)
        {
            return FindValue(value);
        }
    }

}