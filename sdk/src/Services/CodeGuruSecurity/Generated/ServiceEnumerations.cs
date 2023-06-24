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
 * Do not modify this file. This file is generated from the codeguru-security-2018-05-10.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.CodeGuruSecurity
{

    /// <summary>
    /// Constants used for properties of type AnalysisType.
    /// </summary>
    public class AnalysisType : ConstantClass
    {

        /// <summary>
        /// Constant All for AnalysisType
        /// </summary>
        public static readonly AnalysisType All = new AnalysisType("All");
        /// <summary>
        /// Constant Security for AnalysisType
        /// </summary>
        public static readonly AnalysisType Security = new AnalysisType("Security");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AnalysisType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AnalysisType FindValue(string value)
        {
            return FindValue<AnalysisType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AnalysisType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ErrorCode.
    /// </summary>
    public class ErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant DUPLICATE_IDENTIFIER for ErrorCode
        /// </summary>
        public static readonly ErrorCode DUPLICATE_IDENTIFIER = new ErrorCode("DUPLICATE_IDENTIFIER");
        /// <summary>
        /// Constant INTERNAL_ERROR for ErrorCode
        /// </summary>
        public static readonly ErrorCode INTERNAL_ERROR = new ErrorCode("INTERNAL_ERROR");
        /// <summary>
        /// Constant INVALID_FINDING_ID for ErrorCode
        /// </summary>
        public static readonly ErrorCode INVALID_FINDING_ID = new ErrorCode("INVALID_FINDING_ID");
        /// <summary>
        /// Constant INVALID_SCAN_NAME for ErrorCode
        /// </summary>
        public static readonly ErrorCode INVALID_SCAN_NAME = new ErrorCode("INVALID_SCAN_NAME");
        /// <summary>
        /// Constant ITEM_DOES_NOT_EXIST for ErrorCode
        /// </summary>
        public static readonly ErrorCode ITEM_DOES_NOT_EXIST = new ErrorCode("ITEM_DOES_NOT_EXIST");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ErrorCode FindValue(string value)
        {
            return FindValue<ErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScanState.
    /// </summary>
    public class ScanState : ConstantClass
    {

        /// <summary>
        /// Constant Failed for ScanState
        /// </summary>
        public static readonly ScanState Failed = new ScanState("Failed");
        /// <summary>
        /// Constant InProgress for ScanState
        /// </summary>
        public static readonly ScanState InProgress = new ScanState("InProgress");
        /// <summary>
        /// Constant Successful for ScanState
        /// </summary>
        public static readonly ScanState Successful = new ScanState("Successful");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScanState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScanState FindValue(string value)
        {
            return FindValue<ScanState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScanState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ScanType.
    /// </summary>
    public class ScanType : ConstantClass
    {

        /// <summary>
        /// Constant Express for ScanType
        /// </summary>
        public static readonly ScanType Express = new ScanType("Express");
        /// <summary>
        /// Constant Standard for ScanType
        /// </summary>
        public static readonly ScanType Standard = new ScanType("Standard");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ScanType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ScanType FindValue(string value)
        {
            return FindValue<ScanType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ScanType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Severity.
    /// </summary>
    public class Severity : ConstantClass
    {

        /// <summary>
        /// Constant Critical for Severity
        /// </summary>
        public static readonly Severity Critical = new Severity("Critical");
        /// <summary>
        /// Constant High for Severity
        /// </summary>
        public static readonly Severity High = new Severity("High");
        /// <summary>
        /// Constant Info for Severity
        /// </summary>
        public static readonly Severity Info = new Severity("Info");
        /// <summary>
        /// Constant Low for Severity
        /// </summary>
        public static readonly Severity Low = new Severity("Low");
        /// <summary>
        /// Constant Medium for Severity
        /// </summary>
        public static readonly Severity Medium = new Severity("Medium");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Severity(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Severity FindValue(string value)
        {
            return FindValue<Severity>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Severity(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Status.
    /// </summary>
    public class Status : ConstantClass
    {

        /// <summary>
        /// Constant All for Status
        /// </summary>
        public static readonly Status All = new Status("All");
        /// <summary>
        /// Constant Closed for Status
        /// </summary>
        public static readonly Status Closed = new Status("Closed");
        /// <summary>
        /// Constant Open for Status
        /// </summary>
        public static readonly Status Open = new Status("Open");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Status(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Status FindValue(string value)
        {
            return FindValue<Status>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Status(string value)
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
        /// Constant LambdaCodeShaMisMatch for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason LambdaCodeShaMisMatch = new ValidationExceptionReason("lambdaCodeShaMisMatch");
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