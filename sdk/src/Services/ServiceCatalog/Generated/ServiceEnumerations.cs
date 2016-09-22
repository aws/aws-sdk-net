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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.ServiceCatalog
{

    /// <summary>
    /// Constants used for properties of type AccessLevelFilterKey.
    /// </summary>
    public class AccessLevelFilterKey : ConstantClass
    {

        /// <summary>
        /// Constant Account for AccessLevelFilterKey
        /// </summary>
        public static readonly AccessLevelFilterKey Account = new AccessLevelFilterKey("Account");
        /// <summary>
        /// Constant Role for AccessLevelFilterKey
        /// </summary>
        public static readonly AccessLevelFilterKey Role = new AccessLevelFilterKey("Role");
        /// <summary>
        /// Constant User for AccessLevelFilterKey
        /// </summary>
        public static readonly AccessLevelFilterKey User = new AccessLevelFilterKey("User");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccessLevelFilterKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccessLevelFilterKey FindValue(string value)
        {
            return FindValue<AccessLevelFilterKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccessLevelFilterKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProductViewFilterBy.
    /// </summary>
    public class ProductViewFilterBy : ConstantClass
    {

        /// <summary>
        /// Constant FullTextSearch for ProductViewFilterBy
        /// </summary>
        public static readonly ProductViewFilterBy FullTextSearch = new ProductViewFilterBy("FullTextSearch");
        /// <summary>
        /// Constant Owner for ProductViewFilterBy
        /// </summary>
        public static readonly ProductViewFilterBy Owner = new ProductViewFilterBy("Owner");
        /// <summary>
        /// Constant ProductType for ProductViewFilterBy
        /// </summary>
        public static readonly ProductViewFilterBy ProductType = new ProductViewFilterBy("ProductType");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProductViewFilterBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProductViewFilterBy FindValue(string value)
        {
            return FindValue<ProductViewFilterBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProductViewFilterBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProductViewSortBy.
    /// </summary>
    public class ProductViewSortBy : ConstantClass
    {

        /// <summary>
        /// Constant CreationDate for ProductViewSortBy
        /// </summary>
        public static readonly ProductViewSortBy CreationDate = new ProductViewSortBy("CreationDate");
        /// <summary>
        /// Constant Title for ProductViewSortBy
        /// </summary>
        public static readonly ProductViewSortBy Title = new ProductViewSortBy("Title");
        /// <summary>
        /// Constant VersionCount for ProductViewSortBy
        /// </summary>
        public static readonly ProductViewSortBy VersionCount = new ProductViewSortBy("VersionCount");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProductViewSortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProductViewSortBy FindValue(string value)
        {
            return FindValue<ProductViewSortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProductViewSortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RecordStatus.
    /// </summary>
    public class RecordStatus : ConstantClass
    {

        /// <summary>
        /// Constant ERROR for RecordStatus
        /// </summary>
        public static readonly RecordStatus ERROR = new RecordStatus("ERROR");
        /// <summary>
        /// Constant IN_PROGRESS for RecordStatus
        /// </summary>
        public static readonly RecordStatus IN_PROGRESS = new RecordStatus("IN_PROGRESS");
        /// <summary>
        /// Constant SUCCEEDED for RecordStatus
        /// </summary>
        public static readonly RecordStatus SUCCEEDED = new RecordStatus("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecordStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecordStatus FindValue(string value)
        {
            return FindValue<RecordStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecordStatus(string value)
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