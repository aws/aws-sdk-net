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
 * Do not modify this file. This file is generated from the marketplace-catalog-2018-09-17.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.MarketplaceCatalog
{

    /// <summary>
    /// Constants used for properties of type AmiProductSortBy.
    /// </summary>
    public class AmiProductSortBy : ConstantClass
    {

        /// <summary>
        /// Constant EntityId for AmiProductSortBy
        /// </summary>
        public static readonly AmiProductSortBy EntityId = new AmiProductSortBy("EntityId");
        /// <summary>
        /// Constant LastModifiedDate for AmiProductSortBy
        /// </summary>
        public static readonly AmiProductSortBy LastModifiedDate = new AmiProductSortBy("LastModifiedDate");
        /// <summary>
        /// Constant ProductTitle for AmiProductSortBy
        /// </summary>
        public static readonly AmiProductSortBy ProductTitle = new AmiProductSortBy("ProductTitle");
        /// <summary>
        /// Constant Visibility for AmiProductSortBy
        /// </summary>
        public static readonly AmiProductSortBy Visibility = new AmiProductSortBy("Visibility");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AmiProductSortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AmiProductSortBy FindValue(string value)
        {
            return FindValue<AmiProductSortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AmiProductSortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AmiProductVisibilityString.
    /// </summary>
    public class AmiProductVisibilityString : ConstantClass
    {

        /// <summary>
        /// Constant Draft for AmiProductVisibilityString
        /// </summary>
        public static readonly AmiProductVisibilityString Draft = new AmiProductVisibilityString("Draft");
        /// <summary>
        /// Constant Limited for AmiProductVisibilityString
        /// </summary>
        public static readonly AmiProductVisibilityString Limited = new AmiProductVisibilityString("Limited");
        /// <summary>
        /// Constant Public for AmiProductVisibilityString
        /// </summary>
        public static readonly AmiProductVisibilityString Public = new AmiProductVisibilityString("Public");
        /// <summary>
        /// Constant Restricted for AmiProductVisibilityString
        /// </summary>
        public static readonly AmiProductVisibilityString Restricted = new AmiProductVisibilityString("Restricted");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AmiProductVisibilityString(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AmiProductVisibilityString FindValue(string value)
        {
            return FindValue<AmiProductVisibilityString>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AmiProductVisibilityString(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChangeStatus.
    /// </summary>
    public class ChangeStatus : ConstantClass
    {

        /// <summary>
        /// Constant APPLYING for ChangeStatus
        /// </summary>
        public static readonly ChangeStatus APPLYING = new ChangeStatus("APPLYING");
        /// <summary>
        /// Constant CANCELLED for ChangeStatus
        /// </summary>
        public static readonly ChangeStatus CANCELLED = new ChangeStatus("CANCELLED");
        /// <summary>
        /// Constant FAILED for ChangeStatus
        /// </summary>
        public static readonly ChangeStatus FAILED = new ChangeStatus("FAILED");
        /// <summary>
        /// Constant PREPARING for ChangeStatus
        /// </summary>
        public static readonly ChangeStatus PREPARING = new ChangeStatus("PREPARING");
        /// <summary>
        /// Constant SUCCEEDED for ChangeStatus
        /// </summary>
        public static readonly ChangeStatus SUCCEEDED = new ChangeStatus("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChangeStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChangeStatus FindValue(string value)
        {
            return FindValue<ChangeStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChangeStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContainerProductSortBy.
    /// </summary>
    public class ContainerProductSortBy : ConstantClass
    {

        /// <summary>
        /// Constant EntityId for ContainerProductSortBy
        /// </summary>
        public static readonly ContainerProductSortBy EntityId = new ContainerProductSortBy("EntityId");
        /// <summary>
        /// Constant LastModifiedDate for ContainerProductSortBy
        /// </summary>
        public static readonly ContainerProductSortBy LastModifiedDate = new ContainerProductSortBy("LastModifiedDate");
        /// <summary>
        /// Constant ProductTitle for ContainerProductSortBy
        /// </summary>
        public static readonly ContainerProductSortBy ProductTitle = new ContainerProductSortBy("ProductTitle");
        /// <summary>
        /// Constant Visibility for ContainerProductSortBy
        /// </summary>
        public static readonly ContainerProductSortBy Visibility = new ContainerProductSortBy("Visibility");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContainerProductSortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContainerProductSortBy FindValue(string value)
        {
            return FindValue<ContainerProductSortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContainerProductSortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContainerProductVisibilityString.
    /// </summary>
    public class ContainerProductVisibilityString : ConstantClass
    {

        /// <summary>
        /// Constant Draft for ContainerProductVisibilityString
        /// </summary>
        public static readonly ContainerProductVisibilityString Draft = new ContainerProductVisibilityString("Draft");
        /// <summary>
        /// Constant Limited for ContainerProductVisibilityString
        /// </summary>
        public static readonly ContainerProductVisibilityString Limited = new ContainerProductVisibilityString("Limited");
        /// <summary>
        /// Constant Public for ContainerProductVisibilityString
        /// </summary>
        public static readonly ContainerProductVisibilityString Public = new ContainerProductVisibilityString("Public");
        /// <summary>
        /// Constant Restricted for ContainerProductVisibilityString
        /// </summary>
        public static readonly ContainerProductVisibilityString Restricted = new ContainerProductVisibilityString("Restricted");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContainerProductVisibilityString(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContainerProductVisibilityString FindValue(string value)
        {
            return FindValue<ContainerProductVisibilityString>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContainerProductVisibilityString(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataProductSortBy.
    /// </summary>
    public class DataProductSortBy : ConstantClass
    {

        /// <summary>
        /// Constant EntityId for DataProductSortBy
        /// </summary>
        public static readonly DataProductSortBy EntityId = new DataProductSortBy("EntityId");
        /// <summary>
        /// Constant LastModifiedDate for DataProductSortBy
        /// </summary>
        public static readonly DataProductSortBy LastModifiedDate = new DataProductSortBy("LastModifiedDate");
        /// <summary>
        /// Constant ProductTitle for DataProductSortBy
        /// </summary>
        public static readonly DataProductSortBy ProductTitle = new DataProductSortBy("ProductTitle");
        /// <summary>
        /// Constant Visibility for DataProductSortBy
        /// </summary>
        public static readonly DataProductSortBy Visibility = new DataProductSortBy("Visibility");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataProductSortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataProductSortBy FindValue(string value)
        {
            return FindValue<DataProductSortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataProductSortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataProductVisibilityString.
    /// </summary>
    public class DataProductVisibilityString : ConstantClass
    {

        /// <summary>
        /// Constant Draft for DataProductVisibilityString
        /// </summary>
        public static readonly DataProductVisibilityString Draft = new DataProductVisibilityString("Draft");
        /// <summary>
        /// Constant Limited for DataProductVisibilityString
        /// </summary>
        public static readonly DataProductVisibilityString Limited = new DataProductVisibilityString("Limited");
        /// <summary>
        /// Constant Public for DataProductVisibilityString
        /// </summary>
        public static readonly DataProductVisibilityString Public = new DataProductVisibilityString("Public");
        /// <summary>
        /// Constant Restricted for DataProductVisibilityString
        /// </summary>
        public static readonly DataProductVisibilityString Restricted = new DataProductVisibilityString("Restricted");
        /// <summary>
        /// Constant Unavailable for DataProductVisibilityString
        /// </summary>
        public static readonly DataProductVisibilityString Unavailable = new DataProductVisibilityString("Unavailable");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataProductVisibilityString(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataProductVisibilityString FindValue(string value)
        {
            return FindValue<DataProductVisibilityString>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataProductVisibilityString(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FailureCode.
    /// </summary>
    public class FailureCode : ConstantClass
    {

        /// <summary>
        /// Constant CLIENT_ERROR for FailureCode
        /// </summary>
        public static readonly FailureCode CLIENT_ERROR = new FailureCode("CLIENT_ERROR");
        /// <summary>
        /// Constant SERVER_FAULT for FailureCode
        /// </summary>
        public static readonly FailureCode SERVER_FAULT = new FailureCode("SERVER_FAULT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FailureCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FailureCode FindValue(string value)
        {
            return FindValue<FailureCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FailureCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Intent.
    /// </summary>
    public class Intent : ConstantClass
    {

        /// <summary>
        /// Constant APPLY for Intent
        /// </summary>
        public static readonly Intent APPLY = new Intent("APPLY");
        /// <summary>
        /// Constant VALIDATE for Intent
        /// </summary>
        public static readonly Intent VALIDATE = new Intent("VALIDATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Intent(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Intent FindValue(string value)
        {
            return FindValue<Intent>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Intent(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MachineLearningProductSortBy.
    /// </summary>
    public class MachineLearningProductSortBy : ConstantClass
    {

        /// <summary>
        /// Constant EntityId for MachineLearningProductSortBy
        /// </summary>
        public static readonly MachineLearningProductSortBy EntityId = new MachineLearningProductSortBy("EntityId");
        /// <summary>
        /// Constant LastModifiedDate for MachineLearningProductSortBy
        /// </summary>
        public static readonly MachineLearningProductSortBy LastModifiedDate = new MachineLearningProductSortBy("LastModifiedDate");
        /// <summary>
        /// Constant ProductTitle for MachineLearningProductSortBy
        /// </summary>
        public static readonly MachineLearningProductSortBy ProductTitle = new MachineLearningProductSortBy("ProductTitle");
        /// <summary>
        /// Constant Visibility for MachineLearningProductSortBy
        /// </summary>
        public static readonly MachineLearningProductSortBy Visibility = new MachineLearningProductSortBy("Visibility");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MachineLearningProductSortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MachineLearningProductSortBy FindValue(string value)
        {
            return FindValue<MachineLearningProductSortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MachineLearningProductSortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MachineLearningProductVisibilityString.
    /// </summary>
    public class MachineLearningProductVisibilityString : ConstantClass
    {

        /// <summary>
        /// Constant Draft for MachineLearningProductVisibilityString
        /// </summary>
        public static readonly MachineLearningProductVisibilityString Draft = new MachineLearningProductVisibilityString("Draft");
        /// <summary>
        /// Constant Limited for MachineLearningProductVisibilityString
        /// </summary>
        public static readonly MachineLearningProductVisibilityString Limited = new MachineLearningProductVisibilityString("Limited");
        /// <summary>
        /// Constant Public for MachineLearningProductVisibilityString
        /// </summary>
        public static readonly MachineLearningProductVisibilityString Public = new MachineLearningProductVisibilityString("Public");
        /// <summary>
        /// Constant Restricted for MachineLearningProductVisibilityString
        /// </summary>
        public static readonly MachineLearningProductVisibilityString Restricted = new MachineLearningProductVisibilityString("Restricted");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MachineLearningProductVisibilityString(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MachineLearningProductVisibilityString FindValue(string value)
        {
            return FindValue<MachineLearningProductVisibilityString>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MachineLearningProductVisibilityString(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OfferSortBy.
    /// </summary>
    public class OfferSortBy : ConstantClass
    {

        /// <summary>
        /// Constant AvailabilityEndDate for OfferSortBy
        /// </summary>
        public static readonly OfferSortBy AvailabilityEndDate = new OfferSortBy("AvailabilityEndDate");
        /// <summary>
        /// Constant BuyerAccounts for OfferSortBy
        /// </summary>
        public static readonly OfferSortBy BuyerAccounts = new OfferSortBy("BuyerAccounts");
        /// <summary>
        /// Constant EntityId for OfferSortBy
        /// </summary>
        public static readonly OfferSortBy EntityId = new OfferSortBy("EntityId");
        /// <summary>
        /// Constant LastModifiedDate for OfferSortBy
        /// </summary>
        public static readonly OfferSortBy LastModifiedDate = new OfferSortBy("LastModifiedDate");
        /// <summary>
        /// Constant Name for OfferSortBy
        /// </summary>
        public static readonly OfferSortBy Name = new OfferSortBy("Name");
        /// <summary>
        /// Constant ProductId for OfferSortBy
        /// </summary>
        public static readonly OfferSortBy ProductId = new OfferSortBy("ProductId");
        /// <summary>
        /// Constant ReleaseDate for OfferSortBy
        /// </summary>
        public static readonly OfferSortBy ReleaseDate = new OfferSortBy("ReleaseDate");
        /// <summary>
        /// Constant ResaleAuthorizationId for OfferSortBy
        /// </summary>
        public static readonly OfferSortBy ResaleAuthorizationId = new OfferSortBy("ResaleAuthorizationId");
        /// <summary>
        /// Constant State for OfferSortBy
        /// </summary>
        public static readonly OfferSortBy State = new OfferSortBy("State");
        /// <summary>
        /// Constant Targeting for OfferSortBy
        /// </summary>
        public static readonly OfferSortBy Targeting = new OfferSortBy("Targeting");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OfferSortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OfferSortBy FindValue(string value)
        {
            return FindValue<OfferSortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OfferSortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OfferStateString.
    /// </summary>
    public class OfferStateString : ConstantClass
    {

        /// <summary>
        /// Constant Draft for OfferStateString
        /// </summary>
        public static readonly OfferStateString Draft = new OfferStateString("Draft");
        /// <summary>
        /// Constant Released for OfferStateString
        /// </summary>
        public static readonly OfferStateString Released = new OfferStateString("Released");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OfferStateString(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OfferStateString FindValue(string value)
        {
            return FindValue<OfferStateString>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OfferStateString(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OfferTargetingString.
    /// </summary>
    public class OfferTargetingString : ConstantClass
    {

        /// <summary>
        /// Constant BuyerAccounts for OfferTargetingString
        /// </summary>
        public static readonly OfferTargetingString BuyerAccounts = new OfferTargetingString("BuyerAccounts");
        /// <summary>
        /// Constant CountryCodes for OfferTargetingString
        /// </summary>
        public static readonly OfferTargetingString CountryCodes = new OfferTargetingString("CountryCodes");
        /// <summary>
        /// Constant None for OfferTargetingString
        /// </summary>
        public static readonly OfferTargetingString None = new OfferTargetingString("None");
        /// <summary>
        /// Constant ParticipatingPrograms for OfferTargetingString
        /// </summary>
        public static readonly OfferTargetingString ParticipatingPrograms = new OfferTargetingString("ParticipatingPrograms");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OfferTargetingString(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OfferTargetingString FindValue(string value)
        {
            return FindValue<OfferTargetingString>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OfferTargetingString(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OwnershipType.
    /// </summary>
    public class OwnershipType : ConstantClass
    {

        /// <summary>
        /// Constant SELF for OwnershipType
        /// </summary>
        public static readonly OwnershipType SELF = new OwnershipType("SELF");
        /// <summary>
        /// Constant SHARED for OwnershipType
        /// </summary>
        public static readonly OwnershipType SHARED = new OwnershipType("SHARED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OwnershipType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OwnershipType FindValue(string value)
        {
            return FindValue<OwnershipType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OwnershipType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResaleAuthorizationSortBy.
    /// </summary>
    public class ResaleAuthorizationSortBy : ConstantClass
    {

        /// <summary>
        /// Constant AvailabilityEndDate for ResaleAuthorizationSortBy
        /// </summary>
        public static readonly ResaleAuthorizationSortBy AvailabilityEndDate = new ResaleAuthorizationSortBy("AvailabilityEndDate");
        /// <summary>
        /// Constant CreatedDate for ResaleAuthorizationSortBy
        /// </summary>
        public static readonly ResaleAuthorizationSortBy CreatedDate = new ResaleAuthorizationSortBy("CreatedDate");
        /// <summary>
        /// Constant EntityId for ResaleAuthorizationSortBy
        /// </summary>
        public static readonly ResaleAuthorizationSortBy EntityId = new ResaleAuthorizationSortBy("EntityId");
        /// <summary>
        /// Constant LastModifiedDate for ResaleAuthorizationSortBy
        /// </summary>
        public static readonly ResaleAuthorizationSortBy LastModifiedDate = new ResaleAuthorizationSortBy("LastModifiedDate");
        /// <summary>
        /// Constant ManufacturerAccountId for ResaleAuthorizationSortBy
        /// </summary>
        public static readonly ResaleAuthorizationSortBy ManufacturerAccountId = new ResaleAuthorizationSortBy("ManufacturerAccountId");
        /// <summary>
        /// Constant ManufacturerLegalName for ResaleAuthorizationSortBy
        /// </summary>
        public static readonly ResaleAuthorizationSortBy ManufacturerLegalName = new ResaleAuthorizationSortBy("ManufacturerLegalName");
        /// <summary>
        /// Constant Name for ResaleAuthorizationSortBy
        /// </summary>
        public static readonly ResaleAuthorizationSortBy Name = new ResaleAuthorizationSortBy("Name");
        /// <summary>
        /// Constant OfferExtendedStatus for ResaleAuthorizationSortBy
        /// </summary>
        public static readonly ResaleAuthorizationSortBy OfferExtendedStatus = new ResaleAuthorizationSortBy("OfferExtendedStatus");
        /// <summary>
        /// Constant ProductId for ResaleAuthorizationSortBy
        /// </summary>
        public static readonly ResaleAuthorizationSortBy ProductId = new ResaleAuthorizationSortBy("ProductId");
        /// <summary>
        /// Constant ProductName for ResaleAuthorizationSortBy
        /// </summary>
        public static readonly ResaleAuthorizationSortBy ProductName = new ResaleAuthorizationSortBy("ProductName");
        /// <summary>
        /// Constant ResellerAccountID for ResaleAuthorizationSortBy
        /// </summary>
        public static readonly ResaleAuthorizationSortBy ResellerAccountID = new ResaleAuthorizationSortBy("ResellerAccountID");
        /// <summary>
        /// Constant ResellerLegalName for ResaleAuthorizationSortBy
        /// </summary>
        public static readonly ResaleAuthorizationSortBy ResellerLegalName = new ResaleAuthorizationSortBy("ResellerLegalName");
        /// <summary>
        /// Constant Status for ResaleAuthorizationSortBy
        /// </summary>
        public static readonly ResaleAuthorizationSortBy Status = new ResaleAuthorizationSortBy("Status");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResaleAuthorizationSortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResaleAuthorizationSortBy FindValue(string value)
        {
            return FindValue<ResaleAuthorizationSortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResaleAuthorizationSortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResaleAuthorizationStatusString.
    /// </summary>
    public class ResaleAuthorizationStatusString : ConstantClass
    {

        /// <summary>
        /// Constant Active for ResaleAuthorizationStatusString
        /// </summary>
        public static readonly ResaleAuthorizationStatusString Active = new ResaleAuthorizationStatusString("Active");
        /// <summary>
        /// Constant Draft for ResaleAuthorizationStatusString
        /// </summary>
        public static readonly ResaleAuthorizationStatusString Draft = new ResaleAuthorizationStatusString("Draft");
        /// <summary>
        /// Constant Restricted for ResaleAuthorizationStatusString
        /// </summary>
        public static readonly ResaleAuthorizationStatusString Restricted = new ResaleAuthorizationStatusString("Restricted");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResaleAuthorizationStatusString(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResaleAuthorizationStatusString FindValue(string value)
        {
            return FindValue<ResaleAuthorizationStatusString>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResaleAuthorizationStatusString(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SaaSProductSortBy.
    /// </summary>
    public class SaaSProductSortBy : ConstantClass
    {

        /// <summary>
        /// Constant EntityId for SaaSProductSortBy
        /// </summary>
        public static readonly SaaSProductSortBy EntityId = new SaaSProductSortBy("EntityId");
        /// <summary>
        /// Constant LastModifiedDate for SaaSProductSortBy
        /// </summary>
        public static readonly SaaSProductSortBy LastModifiedDate = new SaaSProductSortBy("LastModifiedDate");
        /// <summary>
        /// Constant ProductTitle for SaaSProductSortBy
        /// </summary>
        public static readonly SaaSProductSortBy ProductTitle = new SaaSProductSortBy("ProductTitle");
        /// <summary>
        /// Constant Visibility for SaaSProductSortBy
        /// </summary>
        public static readonly SaaSProductSortBy Visibility = new SaaSProductSortBy("Visibility");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SaaSProductSortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SaaSProductSortBy FindValue(string value)
        {
            return FindValue<SaaSProductSortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SaaSProductSortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SaaSProductVisibilityString.
    /// </summary>
    public class SaaSProductVisibilityString : ConstantClass
    {

        /// <summary>
        /// Constant Draft for SaaSProductVisibilityString
        /// </summary>
        public static readonly SaaSProductVisibilityString Draft = new SaaSProductVisibilityString("Draft");
        /// <summary>
        /// Constant Limited for SaaSProductVisibilityString
        /// </summary>
        public static readonly SaaSProductVisibilityString Limited = new SaaSProductVisibilityString("Limited");
        /// <summary>
        /// Constant Public for SaaSProductVisibilityString
        /// </summary>
        public static readonly SaaSProductVisibilityString Public = new SaaSProductVisibilityString("Public");
        /// <summary>
        /// Constant Restricted for SaaSProductVisibilityString
        /// </summary>
        public static readonly SaaSProductVisibilityString Restricted = new SaaSProductVisibilityString("Restricted");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SaaSProductVisibilityString(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SaaSProductVisibilityString FindValue(string value)
        {
            return FindValue<SaaSProductVisibilityString>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SaaSProductVisibilityString(string value)
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
        /// Constant ASCENDING for SortOrder
        /// </summary>
        public static readonly SortOrder ASCENDING = new SortOrder("ASCENDING");
        /// <summary>
        /// Constant DESCENDING for SortOrder
        /// </summary>
        public static readonly SortOrder DESCENDING = new SortOrder("DESCENDING");

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

}