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
 * Do not modify this file. This file is generated from the pi-2018-02-27.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.PI
{

    /// <summary>
    /// Constants used for properties of type DetailStatus.
    /// </summary>
    public class DetailStatus : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for DetailStatus
        /// </summary>
        public static readonly DetailStatus AVAILABLE = new DetailStatus("AVAILABLE");
        /// <summary>
        /// Constant PROCESSING for DetailStatus
        /// </summary>
        public static readonly DetailStatus PROCESSING = new DetailStatus("PROCESSING");
        /// <summary>
        /// Constant UNAVAILABLE for DetailStatus
        /// </summary>
        public static readonly DetailStatus UNAVAILABLE = new DetailStatus("UNAVAILABLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DetailStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DetailStatus FindValue(string value)
        {
            return FindValue<DetailStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DetailStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FeatureStatus.
    /// </summary>
    public class FeatureStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for FeatureStatus
        /// </summary>
        public static readonly FeatureStatus DISABLED = new FeatureStatus("DISABLED");
        /// <summary>
        /// Constant DISABLED_PENDING_REBOOT for FeatureStatus
        /// </summary>
        public static readonly FeatureStatus DISABLED_PENDING_REBOOT = new FeatureStatus("DISABLED_PENDING_REBOOT");
        /// <summary>
        /// Constant ENABLED for FeatureStatus
        /// </summary>
        public static readonly FeatureStatus ENABLED = new FeatureStatus("ENABLED");
        /// <summary>
        /// Constant ENABLED_PENDING_REBOOT for FeatureStatus
        /// </summary>
        public static readonly FeatureStatus ENABLED_PENDING_REBOOT = new FeatureStatus("ENABLED_PENDING_REBOOT");
        /// <summary>
        /// Constant UNKNOWN for FeatureStatus
        /// </summary>
        public static readonly FeatureStatus UNKNOWN = new FeatureStatus("UNKNOWN");
        /// <summary>
        /// Constant UNSUPPORTED for FeatureStatus
        /// </summary>
        public static readonly FeatureStatus UNSUPPORTED = new FeatureStatus("UNSUPPORTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FeatureStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FeatureStatus FindValue(string value)
        {
            return FindValue<FeatureStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FeatureStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PeriodAlignment.
    /// </summary>
    public class PeriodAlignment : ConstantClass
    {

        /// <summary>
        /// Constant END_TIME for PeriodAlignment
        /// </summary>
        public static readonly PeriodAlignment END_TIME = new PeriodAlignment("END_TIME");
        /// <summary>
        /// Constant START_TIME for PeriodAlignment
        /// </summary>
        public static readonly PeriodAlignment START_TIME = new PeriodAlignment("START_TIME");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PeriodAlignment(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PeriodAlignment FindValue(string value)
        {
            return FindValue<PeriodAlignment>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PeriodAlignment(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServiceType.
    /// </summary>
    public class ServiceType : ConstantClass
    {

        /// <summary>
        /// Constant DOCDB for ServiceType
        /// </summary>
        public static readonly ServiceType DOCDB = new ServiceType("DOCDB");
        /// <summary>
        /// Constant RDS for ServiceType
        /// </summary>
        public static readonly ServiceType RDS = new ServiceType("RDS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServiceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServiceType FindValue(string value)
        {
            return FindValue<ServiceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServiceType(string value)
        {
            return FindValue(value);
        }
    }

}