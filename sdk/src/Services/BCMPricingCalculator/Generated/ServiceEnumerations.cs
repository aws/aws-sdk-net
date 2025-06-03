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
 * Do not modify this file. This file is generated from the bcm-pricing-calculator-2024-06-19.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.BCMPricingCalculator
{

    /// <summary>
    /// Constants used for properties of type BatchCreateBillScenarioCommitmentModificationErrorCode.
    /// </summary>
    public class BatchCreateBillScenarioCommitmentModificationErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant CONFLICT for BatchCreateBillScenarioCommitmentModificationErrorCode
        /// </summary>
        public static readonly BatchCreateBillScenarioCommitmentModificationErrorCode CONFLICT = new BatchCreateBillScenarioCommitmentModificationErrorCode("CONFLICT");
        /// <summary>
        /// Constant INTERNAL_SERVER_ERROR for BatchCreateBillScenarioCommitmentModificationErrorCode
        /// </summary>
        public static readonly BatchCreateBillScenarioCommitmentModificationErrorCode INTERNAL_SERVER_ERROR = new BatchCreateBillScenarioCommitmentModificationErrorCode("INTERNAL_SERVER_ERROR");
        /// <summary>
        /// Constant INVALID_ACCOUNT for BatchCreateBillScenarioCommitmentModificationErrorCode
        /// </summary>
        public static readonly BatchCreateBillScenarioCommitmentModificationErrorCode INVALID_ACCOUNT = new BatchCreateBillScenarioCommitmentModificationErrorCode("INVALID_ACCOUNT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BatchCreateBillScenarioCommitmentModificationErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BatchCreateBillScenarioCommitmentModificationErrorCode FindValue(string value)
        {
            return FindValue<BatchCreateBillScenarioCommitmentModificationErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BatchCreateBillScenarioCommitmentModificationErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BatchCreateBillScenarioUsageModificationErrorCode.
    /// </summary>
    public class BatchCreateBillScenarioUsageModificationErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant BAD_REQUEST for BatchCreateBillScenarioUsageModificationErrorCode
        /// </summary>
        public static readonly BatchCreateBillScenarioUsageModificationErrorCode BAD_REQUEST = new BatchCreateBillScenarioUsageModificationErrorCode("BAD_REQUEST");
        /// <summary>
        /// Constant CONFLICT for BatchCreateBillScenarioUsageModificationErrorCode
        /// </summary>
        public static readonly BatchCreateBillScenarioUsageModificationErrorCode CONFLICT = new BatchCreateBillScenarioUsageModificationErrorCode("CONFLICT");
        /// <summary>
        /// Constant INTERNAL_SERVER_ERROR for BatchCreateBillScenarioUsageModificationErrorCode
        /// </summary>
        public static readonly BatchCreateBillScenarioUsageModificationErrorCode INTERNAL_SERVER_ERROR = new BatchCreateBillScenarioUsageModificationErrorCode("INTERNAL_SERVER_ERROR");
        /// <summary>
        /// Constant NOT_FOUND for BatchCreateBillScenarioUsageModificationErrorCode
        /// </summary>
        public static readonly BatchCreateBillScenarioUsageModificationErrorCode NOT_FOUND = new BatchCreateBillScenarioUsageModificationErrorCode("NOT_FOUND");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BatchCreateBillScenarioUsageModificationErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BatchCreateBillScenarioUsageModificationErrorCode FindValue(string value)
        {
            return FindValue<BatchCreateBillScenarioUsageModificationErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BatchCreateBillScenarioUsageModificationErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BatchCreateWorkloadEstimateUsageCode.
    /// </summary>
    public class BatchCreateWorkloadEstimateUsageCode : ConstantClass
    {

        /// <summary>
        /// Constant BAD_REQUEST for BatchCreateWorkloadEstimateUsageCode
        /// </summary>
        public static readonly BatchCreateWorkloadEstimateUsageCode BAD_REQUEST = new BatchCreateWorkloadEstimateUsageCode("BAD_REQUEST");
        /// <summary>
        /// Constant CONFLICT for BatchCreateWorkloadEstimateUsageCode
        /// </summary>
        public static readonly BatchCreateWorkloadEstimateUsageCode CONFLICT = new BatchCreateWorkloadEstimateUsageCode("CONFLICT");
        /// <summary>
        /// Constant INTERNAL_SERVER_ERROR for BatchCreateWorkloadEstimateUsageCode
        /// </summary>
        public static readonly BatchCreateWorkloadEstimateUsageCode INTERNAL_SERVER_ERROR = new BatchCreateWorkloadEstimateUsageCode("INTERNAL_SERVER_ERROR");
        /// <summary>
        /// Constant NOT_FOUND for BatchCreateWorkloadEstimateUsageCode
        /// </summary>
        public static readonly BatchCreateWorkloadEstimateUsageCode NOT_FOUND = new BatchCreateWorkloadEstimateUsageCode("NOT_FOUND");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BatchCreateWorkloadEstimateUsageCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BatchCreateWorkloadEstimateUsageCode FindValue(string value)
        {
            return FindValue<BatchCreateWorkloadEstimateUsageCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BatchCreateWorkloadEstimateUsageCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BatchDeleteBillScenarioCommitmentModificationErrorCode.
    /// </summary>
    public class BatchDeleteBillScenarioCommitmentModificationErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant BAD_REQUEST for BatchDeleteBillScenarioCommitmentModificationErrorCode
        /// </summary>
        public static readonly BatchDeleteBillScenarioCommitmentModificationErrorCode BAD_REQUEST = new BatchDeleteBillScenarioCommitmentModificationErrorCode("BAD_REQUEST");
        /// <summary>
        /// Constant CONFLICT for BatchDeleteBillScenarioCommitmentModificationErrorCode
        /// </summary>
        public static readonly BatchDeleteBillScenarioCommitmentModificationErrorCode CONFLICT = new BatchDeleteBillScenarioCommitmentModificationErrorCode("CONFLICT");
        /// <summary>
        /// Constant INTERNAL_SERVER_ERROR for BatchDeleteBillScenarioCommitmentModificationErrorCode
        /// </summary>
        public static readonly BatchDeleteBillScenarioCommitmentModificationErrorCode INTERNAL_SERVER_ERROR = new BatchDeleteBillScenarioCommitmentModificationErrorCode("INTERNAL_SERVER_ERROR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BatchDeleteBillScenarioCommitmentModificationErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BatchDeleteBillScenarioCommitmentModificationErrorCode FindValue(string value)
        {
            return FindValue<BatchDeleteBillScenarioCommitmentModificationErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BatchDeleteBillScenarioCommitmentModificationErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BatchDeleteBillScenarioUsageModificationErrorCode.
    /// </summary>
    public class BatchDeleteBillScenarioUsageModificationErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant BAD_REQUEST for BatchDeleteBillScenarioUsageModificationErrorCode
        /// </summary>
        public static readonly BatchDeleteBillScenarioUsageModificationErrorCode BAD_REQUEST = new BatchDeleteBillScenarioUsageModificationErrorCode("BAD_REQUEST");
        /// <summary>
        /// Constant CONFLICT for BatchDeleteBillScenarioUsageModificationErrorCode
        /// </summary>
        public static readonly BatchDeleteBillScenarioUsageModificationErrorCode CONFLICT = new BatchDeleteBillScenarioUsageModificationErrorCode("CONFLICT");
        /// <summary>
        /// Constant INTERNAL_SERVER_ERROR for BatchDeleteBillScenarioUsageModificationErrorCode
        /// </summary>
        public static readonly BatchDeleteBillScenarioUsageModificationErrorCode INTERNAL_SERVER_ERROR = new BatchDeleteBillScenarioUsageModificationErrorCode("INTERNAL_SERVER_ERROR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BatchDeleteBillScenarioUsageModificationErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BatchDeleteBillScenarioUsageModificationErrorCode FindValue(string value)
        {
            return FindValue<BatchDeleteBillScenarioUsageModificationErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BatchDeleteBillScenarioUsageModificationErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BatchUpdateBillScenarioCommitmentModificationErrorCode.
    /// </summary>
    public class BatchUpdateBillScenarioCommitmentModificationErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant BAD_REQUEST for BatchUpdateBillScenarioCommitmentModificationErrorCode
        /// </summary>
        public static readonly BatchUpdateBillScenarioCommitmentModificationErrorCode BAD_REQUEST = new BatchUpdateBillScenarioCommitmentModificationErrorCode("BAD_REQUEST");
        /// <summary>
        /// Constant CONFLICT for BatchUpdateBillScenarioCommitmentModificationErrorCode
        /// </summary>
        public static readonly BatchUpdateBillScenarioCommitmentModificationErrorCode CONFLICT = new BatchUpdateBillScenarioCommitmentModificationErrorCode("CONFLICT");
        /// <summary>
        /// Constant INTERNAL_SERVER_ERROR for BatchUpdateBillScenarioCommitmentModificationErrorCode
        /// </summary>
        public static readonly BatchUpdateBillScenarioCommitmentModificationErrorCode INTERNAL_SERVER_ERROR = new BatchUpdateBillScenarioCommitmentModificationErrorCode("INTERNAL_SERVER_ERROR");
        /// <summary>
        /// Constant NOT_FOUND for BatchUpdateBillScenarioCommitmentModificationErrorCode
        /// </summary>
        public static readonly BatchUpdateBillScenarioCommitmentModificationErrorCode NOT_FOUND = new BatchUpdateBillScenarioCommitmentModificationErrorCode("NOT_FOUND");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BatchUpdateBillScenarioCommitmentModificationErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BatchUpdateBillScenarioCommitmentModificationErrorCode FindValue(string value)
        {
            return FindValue<BatchUpdateBillScenarioCommitmentModificationErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BatchUpdateBillScenarioCommitmentModificationErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BatchUpdateBillScenarioUsageModificationErrorCode.
    /// </summary>
    public class BatchUpdateBillScenarioUsageModificationErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant BAD_REQUEST for BatchUpdateBillScenarioUsageModificationErrorCode
        /// </summary>
        public static readonly BatchUpdateBillScenarioUsageModificationErrorCode BAD_REQUEST = new BatchUpdateBillScenarioUsageModificationErrorCode("BAD_REQUEST");
        /// <summary>
        /// Constant CONFLICT for BatchUpdateBillScenarioUsageModificationErrorCode
        /// </summary>
        public static readonly BatchUpdateBillScenarioUsageModificationErrorCode CONFLICT = new BatchUpdateBillScenarioUsageModificationErrorCode("CONFLICT");
        /// <summary>
        /// Constant INTERNAL_SERVER_ERROR for BatchUpdateBillScenarioUsageModificationErrorCode
        /// </summary>
        public static readonly BatchUpdateBillScenarioUsageModificationErrorCode INTERNAL_SERVER_ERROR = new BatchUpdateBillScenarioUsageModificationErrorCode("INTERNAL_SERVER_ERROR");
        /// <summary>
        /// Constant NOT_FOUND for BatchUpdateBillScenarioUsageModificationErrorCode
        /// </summary>
        public static readonly BatchUpdateBillScenarioUsageModificationErrorCode NOT_FOUND = new BatchUpdateBillScenarioUsageModificationErrorCode("NOT_FOUND");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BatchUpdateBillScenarioUsageModificationErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BatchUpdateBillScenarioUsageModificationErrorCode FindValue(string value)
        {
            return FindValue<BatchUpdateBillScenarioUsageModificationErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BatchUpdateBillScenarioUsageModificationErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BillEstimateStatus.
    /// </summary>
    public class BillEstimateStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETE for BillEstimateStatus
        /// </summary>
        public static readonly BillEstimateStatus COMPLETE = new BillEstimateStatus("COMPLETE");
        /// <summary>
        /// Constant FAILED for BillEstimateStatus
        /// </summary>
        public static readonly BillEstimateStatus FAILED = new BillEstimateStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for BillEstimateStatus
        /// </summary>
        public static readonly BillEstimateStatus IN_PROGRESS = new BillEstimateStatus("IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BillEstimateStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BillEstimateStatus FindValue(string value)
        {
            return FindValue<BillEstimateStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BillEstimateStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BillScenarioStatus.
    /// </summary>
    public class BillScenarioStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for BillScenarioStatus
        /// </summary>
        public static readonly BillScenarioStatus FAILED = new BillScenarioStatus("FAILED");
        /// <summary>
        /// Constant LOCKED for BillScenarioStatus
        /// </summary>
        public static readonly BillScenarioStatus LOCKED = new BillScenarioStatus("LOCKED");
        /// <summary>
        /// Constant READY for BillScenarioStatus
        /// </summary>
        public static readonly BillScenarioStatus READY = new BillScenarioStatus("READY");
        /// <summary>
        /// Constant STALE for BillScenarioStatus
        /// </summary>
        public static readonly BillScenarioStatus STALE = new BillScenarioStatus("STALE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BillScenarioStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BillScenarioStatus FindValue(string value)
        {
            return FindValue<BillScenarioStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BillScenarioStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CurrencyCode.
    /// </summary>
    public class CurrencyCode : ConstantClass
    {

        /// <summary>
        /// Constant USD for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode USD = new CurrencyCode("USD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CurrencyCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CurrencyCode FindValue(string value)
        {
            return FindValue<CurrencyCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CurrencyCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ListBillEstimateLineItemsFilterName.
    /// </summary>
    public class ListBillEstimateLineItemsFilterName : ConstantClass
    {

        /// <summary>
        /// Constant LINE_ITEM_TYPE for ListBillEstimateLineItemsFilterName
        /// </summary>
        public static readonly ListBillEstimateLineItemsFilterName LINE_ITEM_TYPE = new ListBillEstimateLineItemsFilterName("LINE_ITEM_TYPE");
        /// <summary>
        /// Constant LOCATION for ListBillEstimateLineItemsFilterName
        /// </summary>
        public static readonly ListBillEstimateLineItemsFilterName LOCATION = new ListBillEstimateLineItemsFilterName("LOCATION");
        /// <summary>
        /// Constant OPERATION for ListBillEstimateLineItemsFilterName
        /// </summary>
        public static readonly ListBillEstimateLineItemsFilterName OPERATION = new ListBillEstimateLineItemsFilterName("OPERATION");
        /// <summary>
        /// Constant SERVICE_CODE for ListBillEstimateLineItemsFilterName
        /// </summary>
        public static readonly ListBillEstimateLineItemsFilterName SERVICE_CODE = new ListBillEstimateLineItemsFilterName("SERVICE_CODE");
        /// <summary>
        /// Constant USAGE_ACCOUNT_ID for ListBillEstimateLineItemsFilterName
        /// </summary>
        public static readonly ListBillEstimateLineItemsFilterName USAGE_ACCOUNT_ID = new ListBillEstimateLineItemsFilterName("USAGE_ACCOUNT_ID");
        /// <summary>
        /// Constant USAGE_TYPE for ListBillEstimateLineItemsFilterName
        /// </summary>
        public static readonly ListBillEstimateLineItemsFilterName USAGE_TYPE = new ListBillEstimateLineItemsFilterName("USAGE_TYPE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ListBillEstimateLineItemsFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ListBillEstimateLineItemsFilterName FindValue(string value)
        {
            return FindValue<ListBillEstimateLineItemsFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ListBillEstimateLineItemsFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ListBillEstimatesFilterName.
    /// </summary>
    public class ListBillEstimatesFilterName : ConstantClass
    {

        /// <summary>
        /// Constant NAME for ListBillEstimatesFilterName
        /// </summary>
        public static readonly ListBillEstimatesFilterName NAME = new ListBillEstimatesFilterName("NAME");
        /// <summary>
        /// Constant STATUS for ListBillEstimatesFilterName
        /// </summary>
        public static readonly ListBillEstimatesFilterName STATUS = new ListBillEstimatesFilterName("STATUS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ListBillEstimatesFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ListBillEstimatesFilterName FindValue(string value)
        {
            return FindValue<ListBillEstimatesFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ListBillEstimatesFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ListBillScenariosFilterName.
    /// </summary>
    public class ListBillScenariosFilterName : ConstantClass
    {

        /// <summary>
        /// Constant NAME for ListBillScenariosFilterName
        /// </summary>
        public static readonly ListBillScenariosFilterName NAME = new ListBillScenariosFilterName("NAME");
        /// <summary>
        /// Constant STATUS for ListBillScenariosFilterName
        /// </summary>
        public static readonly ListBillScenariosFilterName STATUS = new ListBillScenariosFilterName("STATUS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ListBillScenariosFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ListBillScenariosFilterName FindValue(string value)
        {
            return FindValue<ListBillScenariosFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ListBillScenariosFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ListUsageFilterName.
    /// </summary>
    public class ListUsageFilterName : ConstantClass
    {

        /// <summary>
        /// Constant HISTORICAL_LOCATION for ListUsageFilterName
        /// </summary>
        public static readonly ListUsageFilterName HISTORICAL_LOCATION = new ListUsageFilterName("HISTORICAL_LOCATION");
        /// <summary>
        /// Constant HISTORICAL_OPERATION for ListUsageFilterName
        /// </summary>
        public static readonly ListUsageFilterName HISTORICAL_OPERATION = new ListUsageFilterName("HISTORICAL_OPERATION");
        /// <summary>
        /// Constant HISTORICAL_SERVICE_CODE for ListUsageFilterName
        /// </summary>
        public static readonly ListUsageFilterName HISTORICAL_SERVICE_CODE = new ListUsageFilterName("HISTORICAL_SERVICE_CODE");
        /// <summary>
        /// Constant HISTORICAL_USAGE_ACCOUNT_ID for ListUsageFilterName
        /// </summary>
        public static readonly ListUsageFilterName HISTORICAL_USAGE_ACCOUNT_ID = new ListUsageFilterName("HISTORICAL_USAGE_ACCOUNT_ID");
        /// <summary>
        /// Constant HISTORICAL_USAGE_TYPE for ListUsageFilterName
        /// </summary>
        public static readonly ListUsageFilterName HISTORICAL_USAGE_TYPE = new ListUsageFilterName("HISTORICAL_USAGE_TYPE");
        /// <summary>
        /// Constant LOCATION for ListUsageFilterName
        /// </summary>
        public static readonly ListUsageFilterName LOCATION = new ListUsageFilterName("LOCATION");
        /// <summary>
        /// Constant OPERATION for ListUsageFilterName
        /// </summary>
        public static readonly ListUsageFilterName OPERATION = new ListUsageFilterName("OPERATION");
        /// <summary>
        /// Constant SERVICE_CODE for ListUsageFilterName
        /// </summary>
        public static readonly ListUsageFilterName SERVICE_CODE = new ListUsageFilterName("SERVICE_CODE");
        /// <summary>
        /// Constant USAGE_ACCOUNT_ID for ListUsageFilterName
        /// </summary>
        public static readonly ListUsageFilterName USAGE_ACCOUNT_ID = new ListUsageFilterName("USAGE_ACCOUNT_ID");
        /// <summary>
        /// Constant USAGE_GROUP for ListUsageFilterName
        /// </summary>
        public static readonly ListUsageFilterName USAGE_GROUP = new ListUsageFilterName("USAGE_GROUP");
        /// <summary>
        /// Constant USAGE_TYPE for ListUsageFilterName
        /// </summary>
        public static readonly ListUsageFilterName USAGE_TYPE = new ListUsageFilterName("USAGE_TYPE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ListUsageFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ListUsageFilterName FindValue(string value)
        {
            return FindValue<ListUsageFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ListUsageFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ListWorkloadEstimatesFilterName.
    /// </summary>
    public class ListWorkloadEstimatesFilterName : ConstantClass
    {

        /// <summary>
        /// Constant NAME for ListWorkloadEstimatesFilterName
        /// </summary>
        public static readonly ListWorkloadEstimatesFilterName NAME = new ListWorkloadEstimatesFilterName("NAME");
        /// <summary>
        /// Constant STATUS for ListWorkloadEstimatesFilterName
        /// </summary>
        public static readonly ListWorkloadEstimatesFilterName STATUS = new ListWorkloadEstimatesFilterName("STATUS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ListWorkloadEstimatesFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ListWorkloadEstimatesFilterName FindValue(string value)
        {
            return FindValue<ListWorkloadEstimatesFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ListWorkloadEstimatesFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MatchOption.
    /// </summary>
    public class MatchOption : ConstantClass
    {

        /// <summary>
        /// Constant CONTAINS for MatchOption
        /// </summary>
        public static readonly MatchOption CONTAINS = new MatchOption("CONTAINS");
        /// <summary>
        /// Constant EQUALS for MatchOption
        /// </summary>
        public static readonly MatchOption EQUALS = new MatchOption("EQUALS");
        /// <summary>
        /// Constant STARTS_WITH for MatchOption
        /// </summary>
        public static readonly MatchOption STARTS_WITH = new MatchOption("STARTS_WITH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MatchOption(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MatchOption FindValue(string value)
        {
            return FindValue<MatchOption>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MatchOption(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PurchaseAgreementType.
    /// </summary>
    public class PurchaseAgreementType : ConstantClass
    {

        /// <summary>
        /// Constant RESERVED_INSTANCE for PurchaseAgreementType
        /// </summary>
        public static readonly PurchaseAgreementType RESERVED_INSTANCE = new PurchaseAgreementType("RESERVED_INSTANCE");
        /// <summary>
        /// Constant SAVINGS_PLANS for PurchaseAgreementType
        /// </summary>
        public static readonly PurchaseAgreementType SAVINGS_PLANS = new PurchaseAgreementType("SAVINGS_PLANS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PurchaseAgreementType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PurchaseAgreementType FindValue(string value)
        {
            return FindValue<PurchaseAgreementType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PurchaseAgreementType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RateType.
    /// </summary>
    public class RateType : ConstantClass
    {

        /// <summary>
        /// Constant AFTER_DISCOUNTS for RateType
        /// </summary>
        public static readonly RateType AFTER_DISCOUNTS = new RateType("AFTER_DISCOUNTS");
        /// <summary>
        /// Constant AFTER_DISCOUNTS_AND_COMMITMENTS for RateType
        /// </summary>
        public static readonly RateType AFTER_DISCOUNTS_AND_COMMITMENTS = new RateType("AFTER_DISCOUNTS_AND_COMMITMENTS");
        /// <summary>
        /// Constant BEFORE_DISCOUNTS for RateType
        /// </summary>
        public static readonly RateType BEFORE_DISCOUNTS = new RateType("BEFORE_DISCOUNTS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RateType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RateType FindValue(string value)
        {
            return FindValue<RateType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RateType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ValidationExceptionReason.
    /// </summary>
    public class ValidationExceptionReason : ConstantClass
    {

        /// <summary>
        /// Constant CannotParse for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason CannotParse = new ValidationExceptionReason("cannotParse");
        /// <summary>
        /// Constant DisallowedRate for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason DisallowedRate = new ValidationExceptionReason("disallowedRate");
        /// <summary>
        /// Constant FieldValidationFailed for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason FieldValidationFailed = new ValidationExceptionReason("fieldValidationFailed");
        /// <summary>
        /// Constant InvalidRequestFromMember for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason InvalidRequestFromMember = new ValidationExceptionReason("invalidRequestFromMember");
        /// <summary>
        /// Constant Other for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason Other = new ValidationExceptionReason("other");
        /// <summary>
        /// Constant UnknownOperation for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason UnknownOperation = new ValidationExceptionReason("unknownOperation");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ValidationExceptionReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ValidationExceptionReason FindValue(string value)
        {
            return FindValue<ValidationExceptionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ValidationExceptionReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WorkloadEstimateCostStatus.
    /// </summary>
    public class WorkloadEstimateCostStatus : ConstantClass
    {

        /// <summary>
        /// Constant INVALID for WorkloadEstimateCostStatus
        /// </summary>
        public static readonly WorkloadEstimateCostStatus INVALID = new WorkloadEstimateCostStatus("INVALID");
        /// <summary>
        /// Constant STALE for WorkloadEstimateCostStatus
        /// </summary>
        public static readonly WorkloadEstimateCostStatus STALE = new WorkloadEstimateCostStatus("STALE");
        /// <summary>
        /// Constant VALID for WorkloadEstimateCostStatus
        /// </summary>
        public static readonly WorkloadEstimateCostStatus VALID = new WorkloadEstimateCostStatus("VALID");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorkloadEstimateCostStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorkloadEstimateCostStatus FindValue(string value)
        {
            return FindValue<WorkloadEstimateCostStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorkloadEstimateCostStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WorkloadEstimateRateType.
    /// </summary>
    public class WorkloadEstimateRateType : ConstantClass
    {

        /// <summary>
        /// Constant AFTER_DISCOUNTS for WorkloadEstimateRateType
        /// </summary>
        public static readonly WorkloadEstimateRateType AFTER_DISCOUNTS = new WorkloadEstimateRateType("AFTER_DISCOUNTS");
        /// <summary>
        /// Constant AFTER_DISCOUNTS_AND_COMMITMENTS for WorkloadEstimateRateType
        /// </summary>
        public static readonly WorkloadEstimateRateType AFTER_DISCOUNTS_AND_COMMITMENTS = new WorkloadEstimateRateType("AFTER_DISCOUNTS_AND_COMMITMENTS");
        /// <summary>
        /// Constant BEFORE_DISCOUNTS for WorkloadEstimateRateType
        /// </summary>
        public static readonly WorkloadEstimateRateType BEFORE_DISCOUNTS = new WorkloadEstimateRateType("BEFORE_DISCOUNTS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorkloadEstimateRateType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorkloadEstimateRateType FindValue(string value)
        {
            return FindValue<WorkloadEstimateRateType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorkloadEstimateRateType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WorkloadEstimateStatus.
    /// </summary>
    public class WorkloadEstimateStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTION_NEEDED for WorkloadEstimateStatus
        /// </summary>
        public static readonly WorkloadEstimateStatus ACTION_NEEDED = new WorkloadEstimateStatus("ACTION_NEEDED");
        /// <summary>
        /// Constant INVALID for WorkloadEstimateStatus
        /// </summary>
        public static readonly WorkloadEstimateStatus INVALID = new WorkloadEstimateStatus("INVALID");
        /// <summary>
        /// Constant UPDATING for WorkloadEstimateStatus
        /// </summary>
        public static readonly WorkloadEstimateStatus UPDATING = new WorkloadEstimateStatus("UPDATING");
        /// <summary>
        /// Constant VALID for WorkloadEstimateStatus
        /// </summary>
        public static readonly WorkloadEstimateStatus VALID = new WorkloadEstimateStatus("VALID");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorkloadEstimateStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorkloadEstimateStatus FindValue(string value)
        {
            return FindValue<WorkloadEstimateStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorkloadEstimateStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type WorkloadEstimateUpdateUsageErrorCode.
    /// </summary>
    public class WorkloadEstimateUpdateUsageErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant BAD_REQUEST for WorkloadEstimateUpdateUsageErrorCode
        /// </summary>
        public static readonly WorkloadEstimateUpdateUsageErrorCode BAD_REQUEST = new WorkloadEstimateUpdateUsageErrorCode("BAD_REQUEST");
        /// <summary>
        /// Constant CONFLICT for WorkloadEstimateUpdateUsageErrorCode
        /// </summary>
        public static readonly WorkloadEstimateUpdateUsageErrorCode CONFLICT = new WorkloadEstimateUpdateUsageErrorCode("CONFLICT");
        /// <summary>
        /// Constant INTERNAL_SERVER_ERROR for WorkloadEstimateUpdateUsageErrorCode
        /// </summary>
        public static readonly WorkloadEstimateUpdateUsageErrorCode INTERNAL_SERVER_ERROR = new WorkloadEstimateUpdateUsageErrorCode("INTERNAL_SERVER_ERROR");
        /// <summary>
        /// Constant NOT_FOUND for WorkloadEstimateUpdateUsageErrorCode
        /// </summary>
        public static readonly WorkloadEstimateUpdateUsageErrorCode NOT_FOUND = new WorkloadEstimateUpdateUsageErrorCode("NOT_FOUND");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public WorkloadEstimateUpdateUsageErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static WorkloadEstimateUpdateUsageErrorCode FindValue(string value)
        {
            return FindValue<WorkloadEstimateUpdateUsageErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator WorkloadEstimateUpdateUsageErrorCode(string value)
        {
            return FindValue(value);
        }
    }

}