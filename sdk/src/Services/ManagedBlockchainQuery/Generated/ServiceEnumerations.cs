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
 * Do not modify this file. This file is generated from the managedblockchain-query-2023-05-04.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.ManagedBlockchainQuery
{

    /// <summary>
    /// Constants used for properties of type ConfirmationStatus.
    /// </summary>
    public class ConfirmationStatus : ConstantClass
    {

        /// <summary>
        /// Constant FINAL for ConfirmationStatus
        /// </summary>
        public static readonly ConfirmationStatus FINAL = new ConfirmationStatus("FINAL");
        /// <summary>
        /// Constant NONFINAL for ConfirmationStatus
        /// </summary>
        public static readonly ConfirmationStatus NONFINAL = new ConfirmationStatus("NONFINAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConfirmationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConfirmationStatus FindValue(string value)
        {
            return FindValue<ConfirmationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConfirmationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ErrorType.
    /// </summary>
    public class ErrorType : ConstantClass
    {

        /// <summary>
        /// Constant RESOURCE_NOT_FOUND_EXCEPTION for ErrorType
        /// </summary>
        public static readonly ErrorType RESOURCE_NOT_FOUND_EXCEPTION = new ErrorType("RESOURCE_NOT_FOUND_EXCEPTION");
        /// <summary>
        /// Constant VALIDATION_EXCEPTION for ErrorType
        /// </summary>
        public static readonly ErrorType VALIDATION_EXCEPTION = new ErrorType("VALIDATION_EXCEPTION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ErrorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ErrorType FindValue(string value)
        {
            return FindValue<ErrorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ErrorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExecutionStatus.
    /// </summary>
    public class ExecutionStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for ExecutionStatus
        /// </summary>
        public static readonly ExecutionStatus FAILED = new ExecutionStatus("FAILED");
        /// <summary>
        /// Constant SUCCEEDED for ExecutionStatus
        /// </summary>
        public static readonly ExecutionStatus SUCCEEDED = new ExecutionStatus("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExecutionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExecutionStatus FindValue(string value)
        {
            return FindValue<ExecutionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExecutionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ListFilteredTransactionEventsSortBy.
    /// </summary>
    public class ListFilteredTransactionEventsSortBy : ConstantClass
    {

        /// <summary>
        /// Constant BlockchainInstant for ListFilteredTransactionEventsSortBy
        /// </summary>
        public static readonly ListFilteredTransactionEventsSortBy BlockchainInstant = new ListFilteredTransactionEventsSortBy("blockchainInstant");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ListFilteredTransactionEventsSortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ListFilteredTransactionEventsSortBy FindValue(string value)
        {
            return FindValue<ListFilteredTransactionEventsSortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ListFilteredTransactionEventsSortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ListTransactionsSortBy.
    /// </summary>
    public class ListTransactionsSortBy : ConstantClass
    {

        /// <summary>
        /// Constant TRANSACTION_TIMESTAMP for ListTransactionsSortBy
        /// </summary>
        public static readonly ListTransactionsSortBy TRANSACTION_TIMESTAMP = new ListTransactionsSortBy("TRANSACTION_TIMESTAMP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ListTransactionsSortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ListTransactionsSortBy FindValue(string value)
        {
            return FindValue<ListTransactionsSortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ListTransactionsSortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type QueryNetwork.
    /// </summary>
    public class QueryNetwork : ConstantClass
    {

        /// <summary>
        /// Constant BITCOIN_MAINNET for QueryNetwork
        /// </summary>
        public static readonly QueryNetwork BITCOIN_MAINNET = new QueryNetwork("BITCOIN_MAINNET");
        /// <summary>
        /// Constant BITCOIN_TESTNET for QueryNetwork
        /// </summary>
        public static readonly QueryNetwork BITCOIN_TESTNET = new QueryNetwork("BITCOIN_TESTNET");
        /// <summary>
        /// Constant ETHEREUM_MAINNET for QueryNetwork
        /// </summary>
        public static readonly QueryNetwork ETHEREUM_MAINNET = new QueryNetwork("ETHEREUM_MAINNET");
        /// <summary>
        /// Constant ETHEREUM_SEPOLIA_TESTNET for QueryNetwork
        /// </summary>
        public static readonly QueryNetwork ETHEREUM_SEPOLIA_TESTNET = new QueryNetwork("ETHEREUM_SEPOLIA_TESTNET");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public QueryNetwork(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static QueryNetwork FindValue(string value)
        {
            return FindValue<QueryNetwork>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator QueryNetwork(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type QueryTokenStandard.
    /// </summary>
    public class QueryTokenStandard : ConstantClass
    {

        /// <summary>
        /// Constant ERC1155 for QueryTokenStandard
        /// </summary>
        public static readonly QueryTokenStandard ERC1155 = new QueryTokenStandard("ERC1155");
        /// <summary>
        /// Constant ERC20 for QueryTokenStandard
        /// </summary>
        public static readonly QueryTokenStandard ERC20 = new QueryTokenStandard("ERC20");
        /// <summary>
        /// Constant ERC721 for QueryTokenStandard
        /// </summary>
        public static readonly QueryTokenStandard ERC721 = new QueryTokenStandard("ERC721");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public QueryTokenStandard(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static QueryTokenStandard FindValue(string value)
        {
            return FindValue<QueryTokenStandard>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator QueryTokenStandard(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type QueryTransactionEventType.
    /// </summary>
    public class QueryTransactionEventType : ConstantClass
    {

        /// <summary>
        /// Constant BITCOIN_VIN for QueryTransactionEventType
        /// </summary>
        public static readonly QueryTransactionEventType BITCOIN_VIN = new QueryTransactionEventType("BITCOIN_VIN");
        /// <summary>
        /// Constant BITCOIN_VOUT for QueryTransactionEventType
        /// </summary>
        public static readonly QueryTransactionEventType BITCOIN_VOUT = new QueryTransactionEventType("BITCOIN_VOUT");
        /// <summary>
        /// Constant ERC1155_TRANSFER for QueryTransactionEventType
        /// </summary>
        public static readonly QueryTransactionEventType ERC1155_TRANSFER = new QueryTransactionEventType("ERC1155_TRANSFER");
        /// <summary>
        /// Constant ERC20_BURN for QueryTransactionEventType
        /// </summary>
        public static readonly QueryTransactionEventType ERC20_BURN = new QueryTransactionEventType("ERC20_BURN");
        /// <summary>
        /// Constant ERC20_DEPOSIT for QueryTransactionEventType
        /// </summary>
        public static readonly QueryTransactionEventType ERC20_DEPOSIT = new QueryTransactionEventType("ERC20_DEPOSIT");
        /// <summary>
        /// Constant ERC20_MINT for QueryTransactionEventType
        /// </summary>
        public static readonly QueryTransactionEventType ERC20_MINT = new QueryTransactionEventType("ERC20_MINT");
        /// <summary>
        /// Constant ERC20_TRANSFER for QueryTransactionEventType
        /// </summary>
        public static readonly QueryTransactionEventType ERC20_TRANSFER = new QueryTransactionEventType("ERC20_TRANSFER");
        /// <summary>
        /// Constant ERC20_WITHDRAWAL for QueryTransactionEventType
        /// </summary>
        public static readonly QueryTransactionEventType ERC20_WITHDRAWAL = new QueryTransactionEventType("ERC20_WITHDRAWAL");
        /// <summary>
        /// Constant ERC721_TRANSFER for QueryTransactionEventType
        /// </summary>
        public static readonly QueryTransactionEventType ERC721_TRANSFER = new QueryTransactionEventType("ERC721_TRANSFER");
        /// <summary>
        /// Constant ETH_TRANSFER for QueryTransactionEventType
        /// </summary>
        public static readonly QueryTransactionEventType ETH_TRANSFER = new QueryTransactionEventType("ETH_TRANSFER");
        /// <summary>
        /// Constant INTERNAL_ETH_TRANSFER for QueryTransactionEventType
        /// </summary>
        public static readonly QueryTransactionEventType INTERNAL_ETH_TRANSFER = new QueryTransactionEventType("INTERNAL_ETH_TRANSFER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public QueryTransactionEventType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static QueryTransactionEventType FindValue(string value)
        {
            return FindValue<QueryTransactionEventType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator QueryTransactionEventType(string value)
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
        /// Constant Collection for ResourceType
        /// </summary>
        public static readonly ResourceType Collection = new ResourceType("collection");

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
        /// Constant FieldValidationFailed for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason FieldValidationFailed = new ValidationExceptionReason("fieldValidationFailed");
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

}