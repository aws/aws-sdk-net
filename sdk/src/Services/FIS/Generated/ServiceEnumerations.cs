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
 * Do not modify this file. This file is generated from the fis-2020-12-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.FIS
{

    /// <summary>
    /// Constants used for properties of type AccountTargeting.
    /// </summary>
    public class AccountTargeting : ConstantClass
    {

        /// <summary>
        /// Constant MultiAccount for AccountTargeting
        /// </summary>
        public static readonly AccountTargeting MultiAccount = new AccountTargeting("multi-account");
        /// <summary>
        /// Constant SingleAccount for AccountTargeting
        /// </summary>
        public static readonly AccountTargeting SingleAccount = new AccountTargeting("single-account");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccountTargeting(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccountTargeting FindValue(string value)
        {
            return FindValue<AccountTargeting>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccountTargeting(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ActionsMode.
    /// </summary>
    public class ActionsMode : ConstantClass
    {

        /// <summary>
        /// Constant RunAll for ActionsMode
        /// </summary>
        public static readonly ActionsMode RunAll = new ActionsMode("run-all");
        /// <summary>
        /// Constant SkipAll for ActionsMode
        /// </summary>
        public static readonly ActionsMode SkipAll = new ActionsMode("skip-all");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ActionsMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ActionsMode FindValue(string value)
        {
            return FindValue<ActionsMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ActionsMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EmptyTargetResolutionMode.
    /// </summary>
    public class EmptyTargetResolutionMode : ConstantClass
    {

        /// <summary>
        /// Constant Fail for EmptyTargetResolutionMode
        /// </summary>
        public static readonly EmptyTargetResolutionMode Fail = new EmptyTargetResolutionMode("fail");
        /// <summary>
        /// Constant Skip for EmptyTargetResolutionMode
        /// </summary>
        public static readonly EmptyTargetResolutionMode Skip = new EmptyTargetResolutionMode("skip");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EmptyTargetResolutionMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EmptyTargetResolutionMode FindValue(string value)
        {
            return FindValue<EmptyTargetResolutionMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EmptyTargetResolutionMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExperimentActionStatus.
    /// </summary>
    public class ExperimentActionStatus : ConstantClass
    {

        /// <summary>
        /// Constant Cancelled for ExperimentActionStatus
        /// </summary>
        public static readonly ExperimentActionStatus Cancelled = new ExperimentActionStatus("cancelled");
        /// <summary>
        /// Constant Completed for ExperimentActionStatus
        /// </summary>
        public static readonly ExperimentActionStatus Completed = new ExperimentActionStatus("completed");
        /// <summary>
        /// Constant Failed for ExperimentActionStatus
        /// </summary>
        public static readonly ExperimentActionStatus Failed = new ExperimentActionStatus("failed");
        /// <summary>
        /// Constant Initiating for ExperimentActionStatus
        /// </summary>
        public static readonly ExperimentActionStatus Initiating = new ExperimentActionStatus("initiating");
        /// <summary>
        /// Constant Pending for ExperimentActionStatus
        /// </summary>
        public static readonly ExperimentActionStatus Pending = new ExperimentActionStatus("pending");
        /// <summary>
        /// Constant Running for ExperimentActionStatus
        /// </summary>
        public static readonly ExperimentActionStatus Running = new ExperimentActionStatus("running");
        /// <summary>
        /// Constant Skipped for ExperimentActionStatus
        /// </summary>
        public static readonly ExperimentActionStatus Skipped = new ExperimentActionStatus("skipped");
        /// <summary>
        /// Constant Stopped for ExperimentActionStatus
        /// </summary>
        public static readonly ExperimentActionStatus Stopped = new ExperimentActionStatus("stopped");
        /// <summary>
        /// Constant Stopping for ExperimentActionStatus
        /// </summary>
        public static readonly ExperimentActionStatus Stopping = new ExperimentActionStatus("stopping");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExperimentActionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExperimentActionStatus FindValue(string value)
        {
            return FindValue<ExperimentActionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExperimentActionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExperimentReportStatus.
    /// </summary>
    public class ExperimentReportStatus : ConstantClass
    {

        /// <summary>
        /// Constant Cancelled for ExperimentReportStatus
        /// </summary>
        public static readonly ExperimentReportStatus Cancelled = new ExperimentReportStatus("cancelled");
        /// <summary>
        /// Constant Completed for ExperimentReportStatus
        /// </summary>
        public static readonly ExperimentReportStatus Completed = new ExperimentReportStatus("completed");
        /// <summary>
        /// Constant Failed for ExperimentReportStatus
        /// </summary>
        public static readonly ExperimentReportStatus Failed = new ExperimentReportStatus("failed");
        /// <summary>
        /// Constant Pending for ExperimentReportStatus
        /// </summary>
        public static readonly ExperimentReportStatus Pending = new ExperimentReportStatus("pending");
        /// <summary>
        /// Constant Running for ExperimentReportStatus
        /// </summary>
        public static readonly ExperimentReportStatus Running = new ExperimentReportStatus("running");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExperimentReportStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExperimentReportStatus FindValue(string value)
        {
            return FindValue<ExperimentReportStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExperimentReportStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExperimentStatus.
    /// </summary>
    public class ExperimentStatus : ConstantClass
    {

        /// <summary>
        /// Constant Cancelled for ExperimentStatus
        /// </summary>
        public static readonly ExperimentStatus Cancelled = new ExperimentStatus("cancelled");
        /// <summary>
        /// Constant Completed for ExperimentStatus
        /// </summary>
        public static readonly ExperimentStatus Completed = new ExperimentStatus("completed");
        /// <summary>
        /// Constant Failed for ExperimentStatus
        /// </summary>
        public static readonly ExperimentStatus Failed = new ExperimentStatus("failed");
        /// <summary>
        /// Constant Initiating for ExperimentStatus
        /// </summary>
        public static readonly ExperimentStatus Initiating = new ExperimentStatus("initiating");
        /// <summary>
        /// Constant Pending for ExperimentStatus
        /// </summary>
        public static readonly ExperimentStatus Pending = new ExperimentStatus("pending");
        /// <summary>
        /// Constant Running for ExperimentStatus
        /// </summary>
        public static readonly ExperimentStatus Running = new ExperimentStatus("running");
        /// <summary>
        /// Constant Stopped for ExperimentStatus
        /// </summary>
        public static readonly ExperimentStatus Stopped = new ExperimentStatus("stopped");
        /// <summary>
        /// Constant Stopping for ExperimentStatus
        /// </summary>
        public static readonly ExperimentStatus Stopping = new ExperimentStatus("stopping");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExperimentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExperimentStatus FindValue(string value)
        {
            return FindValue<ExperimentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExperimentStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SafetyLeverStatus.
    /// </summary>
    public class SafetyLeverStatus : ConstantClass
    {

        /// <summary>
        /// Constant Disengaged for SafetyLeverStatus
        /// </summary>
        public static readonly SafetyLeverStatus Disengaged = new SafetyLeverStatus("disengaged");
        /// <summary>
        /// Constant Engaged for SafetyLeverStatus
        /// </summary>
        public static readonly SafetyLeverStatus Engaged = new SafetyLeverStatus("engaged");
        /// <summary>
        /// Constant Engaging for SafetyLeverStatus
        /// </summary>
        public static readonly SafetyLeverStatus Engaging = new SafetyLeverStatus("engaging");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SafetyLeverStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SafetyLeverStatus FindValue(string value)
        {
            return FindValue<SafetyLeverStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SafetyLeverStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SafetyLeverStatusInput.
    /// </summary>
    public class SafetyLeverStatusInput : ConstantClass
    {

        /// <summary>
        /// Constant Disengaged for SafetyLeverStatusInput
        /// </summary>
        public static readonly SafetyLeverStatusInput Disengaged = new SafetyLeverStatusInput("disengaged");
        /// <summary>
        /// Constant Engaged for SafetyLeverStatusInput
        /// </summary>
        public static readonly SafetyLeverStatusInput Engaged = new SafetyLeverStatusInput("engaged");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SafetyLeverStatusInput(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SafetyLeverStatusInput FindValue(string value)
        {
            return FindValue<SafetyLeverStatusInput>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SafetyLeverStatusInput(string value)
        {
            return FindValue(value);
        }
    }

}