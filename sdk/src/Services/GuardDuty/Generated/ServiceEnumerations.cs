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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.GuardDuty
{

    /// <summary>
    /// Constants used for properties of type DetectorStatus.
    /// </summary>
    public class DetectorStatus : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for DetectorStatus
        /// </summary>
        public static readonly DetectorStatus DISABLED = new DetectorStatus("DISABLED");
        /// <summary>
        /// Constant ENABLED for DetectorStatus
        /// </summary>
        public static readonly DetectorStatus ENABLED = new DetectorStatus("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DetectorStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DetectorStatus FindValue(string value)
        {
            return FindValue<DetectorStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DetectorStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Feedback.
    /// </summary>
    public class Feedback : ConstantClass
    {

        /// <summary>
        /// Constant NOT_USEFUL for Feedback
        /// </summary>
        public static readonly Feedback NOT_USEFUL = new Feedback("NOT_USEFUL");
        /// <summary>
        /// Constant USEFUL for Feedback
        /// </summary>
        public static readonly Feedback USEFUL = new Feedback("USEFUL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Feedback(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Feedback FindValue(string value)
        {
            return FindValue<Feedback>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Feedback(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FilterAction.
    /// </summary>
    public class FilterAction : ConstantClass
    {

        /// <summary>
        /// Constant ARCHIVE for FilterAction
        /// </summary>
        public static readonly FilterAction ARCHIVE = new FilterAction("ARCHIVE");
        /// <summary>
        /// Constant NOOP for FilterAction
        /// </summary>
        public static readonly FilterAction NOOP = new FilterAction("NOOP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FilterAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FilterAction FindValue(string value)
        {
            return FindValue<FilterAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FilterAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FindingStatisticType.
    /// </summary>
    public class FindingStatisticType : ConstantClass
    {

        /// <summary>
        /// Constant COUNT_BY_SEVERITY for FindingStatisticType
        /// </summary>
        public static readonly FindingStatisticType COUNT_BY_SEVERITY = new FindingStatisticType("COUNT_BY_SEVERITY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FindingStatisticType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FindingStatisticType FindValue(string value)
        {
            return FindValue<FindingStatisticType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FindingStatisticType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IpSetFormat.
    /// </summary>
    public class IpSetFormat : ConstantClass
    {

        /// <summary>
        /// Constant ALIEN_VAULT for IpSetFormat
        /// </summary>
        public static readonly IpSetFormat ALIEN_VAULT = new IpSetFormat("ALIEN_VAULT");
        /// <summary>
        /// Constant FIRE_EYE for IpSetFormat
        /// </summary>
        public static readonly IpSetFormat FIRE_EYE = new IpSetFormat("FIRE_EYE");
        /// <summary>
        /// Constant OTX_CSV for IpSetFormat
        /// </summary>
        public static readonly IpSetFormat OTX_CSV = new IpSetFormat("OTX_CSV");
        /// <summary>
        /// Constant PROOF_POINT for IpSetFormat
        /// </summary>
        public static readonly IpSetFormat PROOF_POINT = new IpSetFormat("PROOF_POINT");
        /// <summary>
        /// Constant STIX for IpSetFormat
        /// </summary>
        public static readonly IpSetFormat STIX = new IpSetFormat("STIX");
        /// <summary>
        /// Constant TXT for IpSetFormat
        /// </summary>
        public static readonly IpSetFormat TXT = new IpSetFormat("TXT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IpSetFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IpSetFormat FindValue(string value)
        {
            return FindValue<IpSetFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IpSetFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IpSetStatus.
    /// </summary>
    public class IpSetStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVATING for IpSetStatus
        /// </summary>
        public static readonly IpSetStatus ACTIVATING = new IpSetStatus("ACTIVATING");
        /// <summary>
        /// Constant ACTIVE for IpSetStatus
        /// </summary>
        public static readonly IpSetStatus ACTIVE = new IpSetStatus("ACTIVE");
        /// <summary>
        /// Constant DEACTIVATING for IpSetStatus
        /// </summary>
        public static readonly IpSetStatus DEACTIVATING = new IpSetStatus("DEACTIVATING");
        /// <summary>
        /// Constant DELETE_PENDING for IpSetStatus
        /// </summary>
        public static readonly IpSetStatus DELETE_PENDING = new IpSetStatus("DELETE_PENDING");
        /// <summary>
        /// Constant DELETED for IpSetStatus
        /// </summary>
        public static readonly IpSetStatus DELETED = new IpSetStatus("DELETED");
        /// <summary>
        /// Constant ERROR for IpSetStatus
        /// </summary>
        public static readonly IpSetStatus ERROR = new IpSetStatus("ERROR");
        /// <summary>
        /// Constant INACTIVE for IpSetStatus
        /// </summary>
        public static readonly IpSetStatus INACTIVE = new IpSetStatus("INACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IpSetStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IpSetStatus FindValue(string value)
        {
            return FindValue<IpSetStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IpSetStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OrderBy.
    /// </summary>
    public class OrderBy : ConstantClass
    {

        /// <summary>
        /// Constant ASC for OrderBy
        /// </summary>
        public static readonly OrderBy ASC = new OrderBy("ASC");
        /// <summary>
        /// Constant DESC for OrderBy
        /// </summary>
        public static readonly OrderBy DESC = new OrderBy("DESC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OrderBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OrderBy FindValue(string value)
        {
            return FindValue<OrderBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OrderBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ThreatIntelSetFormat.
    /// </summary>
    public class ThreatIntelSetFormat : ConstantClass
    {

        /// <summary>
        /// Constant ALIEN_VAULT for ThreatIntelSetFormat
        /// </summary>
        public static readonly ThreatIntelSetFormat ALIEN_VAULT = new ThreatIntelSetFormat("ALIEN_VAULT");
        /// <summary>
        /// Constant FIRE_EYE for ThreatIntelSetFormat
        /// </summary>
        public static readonly ThreatIntelSetFormat FIRE_EYE = new ThreatIntelSetFormat("FIRE_EYE");
        /// <summary>
        /// Constant OTX_CSV for ThreatIntelSetFormat
        /// </summary>
        public static readonly ThreatIntelSetFormat OTX_CSV = new ThreatIntelSetFormat("OTX_CSV");
        /// <summary>
        /// Constant PROOF_POINT for ThreatIntelSetFormat
        /// </summary>
        public static readonly ThreatIntelSetFormat PROOF_POINT = new ThreatIntelSetFormat("PROOF_POINT");
        /// <summary>
        /// Constant STIX for ThreatIntelSetFormat
        /// </summary>
        public static readonly ThreatIntelSetFormat STIX = new ThreatIntelSetFormat("STIX");
        /// <summary>
        /// Constant TXT for ThreatIntelSetFormat
        /// </summary>
        public static readonly ThreatIntelSetFormat TXT = new ThreatIntelSetFormat("TXT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ThreatIntelSetFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ThreatIntelSetFormat FindValue(string value)
        {
            return FindValue<ThreatIntelSetFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ThreatIntelSetFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ThreatIntelSetStatus.
    /// </summary>
    public class ThreatIntelSetStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVATING for ThreatIntelSetStatus
        /// </summary>
        public static readonly ThreatIntelSetStatus ACTIVATING = new ThreatIntelSetStatus("ACTIVATING");
        /// <summary>
        /// Constant ACTIVE for ThreatIntelSetStatus
        /// </summary>
        public static readonly ThreatIntelSetStatus ACTIVE = new ThreatIntelSetStatus("ACTIVE");
        /// <summary>
        /// Constant DEACTIVATING for ThreatIntelSetStatus
        /// </summary>
        public static readonly ThreatIntelSetStatus DEACTIVATING = new ThreatIntelSetStatus("DEACTIVATING");
        /// <summary>
        /// Constant DELETE_PENDING for ThreatIntelSetStatus
        /// </summary>
        public static readonly ThreatIntelSetStatus DELETE_PENDING = new ThreatIntelSetStatus("DELETE_PENDING");
        /// <summary>
        /// Constant DELETED for ThreatIntelSetStatus
        /// </summary>
        public static readonly ThreatIntelSetStatus DELETED = new ThreatIntelSetStatus("DELETED");
        /// <summary>
        /// Constant ERROR for ThreatIntelSetStatus
        /// </summary>
        public static readonly ThreatIntelSetStatus ERROR = new ThreatIntelSetStatus("ERROR");
        /// <summary>
        /// Constant INACTIVE for ThreatIntelSetStatus
        /// </summary>
        public static readonly ThreatIntelSetStatus INACTIVE = new ThreatIntelSetStatus("INACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ThreatIntelSetStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ThreatIntelSetStatus FindValue(string value)
        {
            return FindValue<ThreatIntelSetStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ThreatIntelSetStatus(string value)
        {
            return FindValue(value);
        }
    }

}