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
 * Do not modify this file. This file is generated from the resource-explorer-2-2022-07-28.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.ResourceExplorer2
{

    /// <summary>
    /// Constants used for properties of type AWSServiceAccessStatus.
    /// </summary>
    public class AWSServiceAccessStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for AWSServiceAccessStatus
        /// </summary>
        public static readonly AWSServiceAccessStatus DISABLED = new AWSServiceAccessStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for AWSServiceAccessStatus
        /// </summary>
        public static readonly AWSServiceAccessStatus ENABLED = new AWSServiceAccessStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AWSServiceAccessStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AWSServiceAccessStatus FindValue(string value)
        {
            return FindValue<AWSServiceAccessStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AWSServiceAccessStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IndexState.
    /// </summary>
    public class IndexState : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for IndexState
        /// </summary>
        public static readonly IndexState ACTIVE = new IndexState("ACTIVE");
        /// <summary>
        /// Constant CREATING for IndexState
        /// </summary>
        public static readonly IndexState CREATING = new IndexState("CREATING");
        /// <summary>
        /// Constant DELETED for IndexState
        /// </summary>
        public static readonly IndexState DELETED = new IndexState("DELETED");
        /// <summary>
        /// Constant DELETING for IndexState
        /// </summary>
        public static readonly IndexState DELETING = new IndexState("DELETING");
        /// <summary>
        /// Constant UPDATING for IndexState
        /// </summary>
        public static readonly IndexState UPDATING = new IndexState("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IndexState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IndexState FindValue(string value)
        {
            return FindValue<IndexState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IndexState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IndexType.
    /// </summary>
    public class IndexType : ConstantClass
    {

        /// <summary>
        /// Constant AGGREGATOR for IndexType
        /// </summary>
        public static readonly IndexType AGGREGATOR = new IndexType("AGGREGATOR");
        /// <summary>
        /// Constant LOCAL for IndexType
        /// </summary>
        public static readonly IndexType LOCAL = new IndexType("LOCAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IndexType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IndexType FindValue(string value)
        {
            return FindValue<IndexType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IndexType(string value)
        {
            return FindValue(value);
        }
    }

}