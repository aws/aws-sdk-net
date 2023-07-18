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
 * Do not modify this file. This file is generated from the sagemaker-featurestore-runtime-2020-07-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.SageMakerFeatureStoreRuntime
{

    /// <summary>
    /// Constants used for properties of type DeletionMode.
    /// </summary>
    public class DeletionMode : ConstantClass
    {

        /// <summary>
        /// Constant HardDelete for DeletionMode
        /// </summary>
        public static readonly DeletionMode HardDelete = new DeletionMode("HardDelete");
        /// <summary>
        /// Constant SoftDelete for DeletionMode
        /// </summary>
        public static readonly DeletionMode SoftDelete = new DeletionMode("SoftDelete");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeletionMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeletionMode FindValue(string value)
        {
            return FindValue<DeletionMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeletionMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExpirationTimeResponse.
    /// </summary>
    public class ExpirationTimeResponse : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for ExpirationTimeResponse
        /// </summary>
        public static readonly ExpirationTimeResponse Disabled = new ExpirationTimeResponse("Disabled");
        /// <summary>
        /// Constant Enabled for ExpirationTimeResponse
        /// </summary>
        public static readonly ExpirationTimeResponse Enabled = new ExpirationTimeResponse("Enabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExpirationTimeResponse(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExpirationTimeResponse FindValue(string value)
        {
            return FindValue<ExpirationTimeResponse>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExpirationTimeResponse(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TargetStore.
    /// </summary>
    public class TargetStore : ConstantClass
    {

        /// <summary>
        /// Constant OfflineStore for TargetStore
        /// </summary>
        public static readonly TargetStore OfflineStore = new TargetStore("OfflineStore");
        /// <summary>
        /// Constant OnlineStore for TargetStore
        /// </summary>
        public static readonly TargetStore OnlineStore = new TargetStore("OnlineStore");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TargetStore(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TargetStore FindValue(string value)
        {
            return FindValue<TargetStore>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TargetStore(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TtlDurationUnit.
    /// </summary>
    public class TtlDurationUnit : ConstantClass
    {

        /// <summary>
        /// Constant Days for TtlDurationUnit
        /// </summary>
        public static readonly TtlDurationUnit Days = new TtlDurationUnit("Days");
        /// <summary>
        /// Constant Hours for TtlDurationUnit
        /// </summary>
        public static readonly TtlDurationUnit Hours = new TtlDurationUnit("Hours");
        /// <summary>
        /// Constant Minutes for TtlDurationUnit
        /// </summary>
        public static readonly TtlDurationUnit Minutes = new TtlDurationUnit("Minutes");
        /// <summary>
        /// Constant Seconds for TtlDurationUnit
        /// </summary>
        public static readonly TtlDurationUnit Seconds = new TtlDurationUnit("Seconds");
        /// <summary>
        /// Constant Weeks for TtlDurationUnit
        /// </summary>
        public static readonly TtlDurationUnit Weeks = new TtlDurationUnit("Weeks");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TtlDurationUnit(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TtlDurationUnit FindValue(string value)
        {
            return FindValue<TtlDurationUnit>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TtlDurationUnit(string value)
        {
            return FindValue(value);
        }
    }

}