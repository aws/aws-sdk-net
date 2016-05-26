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
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.ElastiCache
{

    /// <summary>
    /// Constants used for properties of type AutomaticFailoverStatus.
    /// </summary>
    public class AutomaticFailoverStatus : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for AutomaticFailoverStatus
        /// </summary>
        public static readonly AutomaticFailoverStatus Disabled = new AutomaticFailoverStatus("disabled");
        /// <summary>
        /// Constant Disabling for AutomaticFailoverStatus
        /// </summary>
        public static readonly AutomaticFailoverStatus Disabling = new AutomaticFailoverStatus("disabling");
        /// <summary>
        /// Constant Enabled for AutomaticFailoverStatus
        /// </summary>
        public static readonly AutomaticFailoverStatus Enabled = new AutomaticFailoverStatus("enabled");
        /// <summary>
        /// Constant Enabling for AutomaticFailoverStatus
        /// </summary>
        public static readonly AutomaticFailoverStatus Enabling = new AutomaticFailoverStatus("enabling");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AutomaticFailoverStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AutomaticFailoverStatus FindValue(string value)
        {
            return FindValue<AutomaticFailoverStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AutomaticFailoverStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AZMode.
    /// </summary>
    public class AZMode : ConstantClass
    {

        /// <summary>
        /// Constant CrossAz for AZMode
        /// </summary>
        public static readonly AZMode CrossAz = new AZMode("cross-az");
        /// <summary>
        /// Constant SingleAz for AZMode
        /// </summary>
        public static readonly AZMode SingleAz = new AZMode("single-az");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AZMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AZMode FindValue(string value)
        {
            return FindValue<AZMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AZMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChangeType.
    /// </summary>
    public class ChangeType : ConstantClass
    {

        /// <summary>
        /// Constant Immediate for ChangeType
        /// </summary>
        public static readonly ChangeType Immediate = new ChangeType("immediate");
        /// <summary>
        /// Constant RequiresReboot for ChangeType
        /// </summary>
        public static readonly ChangeType RequiresReboot = new ChangeType("requires-reboot");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChangeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChangeType FindValue(string value)
        {
            return FindValue<ChangeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChangeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PendingAutomaticFailoverStatus.
    /// </summary>
    public class PendingAutomaticFailoverStatus : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for PendingAutomaticFailoverStatus
        /// </summary>
        public static readonly PendingAutomaticFailoverStatus Disabled = new PendingAutomaticFailoverStatus("disabled");
        /// <summary>
        /// Constant Enabled for PendingAutomaticFailoverStatus
        /// </summary>
        public static readonly PendingAutomaticFailoverStatus Enabled = new PendingAutomaticFailoverStatus("enabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PendingAutomaticFailoverStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PendingAutomaticFailoverStatus FindValue(string value)
        {
            return FindValue<PendingAutomaticFailoverStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PendingAutomaticFailoverStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SourceType.
    /// </summary>
    public class SourceType : ConstantClass
    {

        /// <summary>
        /// Constant CacheCluster for SourceType
        /// </summary>
        public static readonly SourceType CacheCluster = new SourceType("cache-cluster");
        /// <summary>
        /// Constant CacheParameterGroup for SourceType
        /// </summary>
        public static readonly SourceType CacheParameterGroup = new SourceType("cache-parameter-group");
        /// <summary>
        /// Constant CacheSecurityGroup for SourceType
        /// </summary>
        public static readonly SourceType CacheSecurityGroup = new SourceType("cache-security-group");
        /// <summary>
        /// Constant CacheSubnetGroup for SourceType
        /// </summary>
        public static readonly SourceType CacheSubnetGroup = new SourceType("cache-subnet-group");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SourceType FindValue(string value)
        {
            return FindValue<SourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SourceType(string value)
        {
            return FindValue(value);
        }
    }

}