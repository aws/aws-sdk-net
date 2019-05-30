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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.RDS
{

    /// <summary>
    /// Constants used for properties of type ActivityStreamMode.
    /// </summary>
    public class ActivityStreamMode : ConstantClass
    {

        /// <summary>
        /// Constant Async for ActivityStreamMode
        /// </summary>
        public static readonly ActivityStreamMode Async = new ActivityStreamMode("async");
        /// <summary>
        /// Constant Sync for ActivityStreamMode
        /// </summary>
        public static readonly ActivityStreamMode Sync = new ActivityStreamMode("sync");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ActivityStreamMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ActivityStreamMode FindValue(string value)
        {
            return FindValue<ActivityStreamMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ActivityStreamMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ActivityStreamStatus.
    /// </summary>
    public class ActivityStreamStatus : ConstantClass
    {

        /// <summary>
        /// Constant Started for ActivityStreamStatus
        /// </summary>
        public static readonly ActivityStreamStatus Started = new ActivityStreamStatus("started");
        /// <summary>
        /// Constant Starting for ActivityStreamStatus
        /// </summary>
        public static readonly ActivityStreamStatus Starting = new ActivityStreamStatus("starting");
        /// <summary>
        /// Constant Stopped for ActivityStreamStatus
        /// </summary>
        public static readonly ActivityStreamStatus Stopped = new ActivityStreamStatus("stopped");
        /// <summary>
        /// Constant Stopping for ActivityStreamStatus
        /// </summary>
        public static readonly ActivityStreamStatus Stopping = new ActivityStreamStatus("stopping");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ActivityStreamStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ActivityStreamStatus FindValue(string value)
        {
            return FindValue<ActivityStreamStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ActivityStreamStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ApplyMethod.
    /// </summary>
    public class ApplyMethod : ConstantClass
    {

        /// <summary>
        /// Constant Immediate for ApplyMethod
        /// </summary>
        public static readonly ApplyMethod Immediate = new ApplyMethod("immediate");
        /// <summary>
        /// Constant PendingReboot for ApplyMethod
        /// </summary>
        public static readonly ApplyMethod PendingReboot = new ApplyMethod("pending-reboot");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ApplyMethod(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ApplyMethod FindValue(string value)
        {
            return FindValue<ApplyMethod>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ApplyMethod(string value)
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
        /// Constant DbCluster for SourceType
        /// </summary>
        public static readonly SourceType DbCluster = new SourceType("db-cluster");
        /// <summary>
        /// Constant DbClusterSnapshot for SourceType
        /// </summary>
        public static readonly SourceType DbClusterSnapshot = new SourceType("db-cluster-snapshot");
        /// <summary>
        /// Constant DbInstance for SourceType
        /// </summary>
        public static readonly SourceType DbInstance = new SourceType("db-instance");
        /// <summary>
        /// Constant DbParameterGroup for SourceType
        /// </summary>
        public static readonly SourceType DbParameterGroup = new SourceType("db-parameter-group");
        /// <summary>
        /// Constant DbSecurityGroup for SourceType
        /// </summary>
        public static readonly SourceType DbSecurityGroup = new SourceType("db-security-group");
        /// <summary>
        /// Constant DbSnapshot for SourceType
        /// </summary>
        public static readonly SourceType DbSnapshot = new SourceType("db-snapshot");

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