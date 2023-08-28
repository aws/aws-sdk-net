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
 * Do not modify this file. This file is generated from the service-quotas-2019-06-24.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.ServiceQuotas
{

    /// <summary>
    /// Constants used for properties of type AppliedLevelEnum.
    /// </summary>
    public class AppliedLevelEnum : ConstantClass
    {

        /// <summary>
        /// Constant ACCOUNT for AppliedLevelEnum
        /// </summary>
        public static readonly AppliedLevelEnum ACCOUNT = new AppliedLevelEnum("ACCOUNT");
        /// <summary>
        /// Constant ALL for AppliedLevelEnum
        /// </summary>
        public static readonly AppliedLevelEnum ALL = new AppliedLevelEnum("ALL");
        /// <summary>
        /// Constant RESOURCE for AppliedLevelEnum
        /// </summary>
        public static readonly AppliedLevelEnum RESOURCE = new AppliedLevelEnum("RESOURCE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AppliedLevelEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AppliedLevelEnum FindValue(string value)
        {
            return FindValue<AppliedLevelEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AppliedLevelEnum(string value)
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
        /// Constant DEPENDENCY_ACCESS_DENIED_ERROR for ErrorCode
        /// </summary>
        public static readonly ErrorCode DEPENDENCY_ACCESS_DENIED_ERROR = new ErrorCode("DEPENDENCY_ACCESS_DENIED_ERROR");
        /// <summary>
        /// Constant DEPENDENCY_SERVICE_ERROR for ErrorCode
        /// </summary>
        public static readonly ErrorCode DEPENDENCY_SERVICE_ERROR = new ErrorCode("DEPENDENCY_SERVICE_ERROR");
        /// <summary>
        /// Constant DEPENDENCY_THROTTLING_ERROR for ErrorCode
        /// </summary>
        public static readonly ErrorCode DEPENDENCY_THROTTLING_ERROR = new ErrorCode("DEPENDENCY_THROTTLING_ERROR");
        /// <summary>
        /// Constant SERVICE_QUOTA_NOT_AVAILABLE_ERROR for ErrorCode
        /// </summary>
        public static readonly ErrorCode SERVICE_QUOTA_NOT_AVAILABLE_ERROR = new ErrorCode("SERVICE_QUOTA_NOT_AVAILABLE_ERROR");

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
    /// Constants used for properties of type PeriodUnit.
    /// </summary>
    public class PeriodUnit : ConstantClass
    {

        /// <summary>
        /// Constant DAY for PeriodUnit
        /// </summary>
        public static readonly PeriodUnit DAY = new PeriodUnit("DAY");
        /// <summary>
        /// Constant HOUR for PeriodUnit
        /// </summary>
        public static readonly PeriodUnit HOUR = new PeriodUnit("HOUR");
        /// <summary>
        /// Constant MICROSECOND for PeriodUnit
        /// </summary>
        public static readonly PeriodUnit MICROSECOND = new PeriodUnit("MICROSECOND");
        /// <summary>
        /// Constant MILLISECOND for PeriodUnit
        /// </summary>
        public static readonly PeriodUnit MILLISECOND = new PeriodUnit("MILLISECOND");
        /// <summary>
        /// Constant MINUTE for PeriodUnit
        /// </summary>
        public static readonly PeriodUnit MINUTE = new PeriodUnit("MINUTE");
        /// <summary>
        /// Constant SECOND for PeriodUnit
        /// </summary>
        public static readonly PeriodUnit SECOND = new PeriodUnit("SECOND");
        /// <summary>
        /// Constant WEEK for PeriodUnit
        /// </summary>
        public static readonly PeriodUnit WEEK = new PeriodUnit("WEEK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PeriodUnit(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PeriodUnit FindValue(string value)
        {
            return FindValue<PeriodUnit>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PeriodUnit(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type QuotaContextScope.
    /// </summary>
    public class QuotaContextScope : ConstantClass
    {

        /// <summary>
        /// Constant ACCOUNT for QuotaContextScope
        /// </summary>
        public static readonly QuotaContextScope ACCOUNT = new QuotaContextScope("ACCOUNT");
        /// <summary>
        /// Constant RESOURCE for QuotaContextScope
        /// </summary>
        public static readonly QuotaContextScope RESOURCE = new QuotaContextScope("RESOURCE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public QuotaContextScope(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static QuotaContextScope FindValue(string value)
        {
            return FindValue<QuotaContextScope>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator QuotaContextScope(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RequestStatus.
    /// </summary>
    public class RequestStatus : ConstantClass
    {

        /// <summary>
        /// Constant APPROVED for RequestStatus
        /// </summary>
        public static readonly RequestStatus APPROVED = new RequestStatus("APPROVED");
        /// <summary>
        /// Constant CASE_CLOSED for RequestStatus
        /// </summary>
        public static readonly RequestStatus CASE_CLOSED = new RequestStatus("CASE_CLOSED");
        /// <summary>
        /// Constant CASE_OPENED for RequestStatus
        /// </summary>
        public static readonly RequestStatus CASE_OPENED = new RequestStatus("CASE_OPENED");
        /// <summary>
        /// Constant DENIED for RequestStatus
        /// </summary>
        public static readonly RequestStatus DENIED = new RequestStatus("DENIED");
        /// <summary>
        /// Constant INVALID_REQUEST for RequestStatus
        /// </summary>
        public static readonly RequestStatus INVALID_REQUEST = new RequestStatus("INVALID_REQUEST");
        /// <summary>
        /// Constant NOT_APPROVED for RequestStatus
        /// </summary>
        public static readonly RequestStatus NOT_APPROVED = new RequestStatus("NOT_APPROVED");
        /// <summary>
        /// Constant PENDING for RequestStatus
        /// </summary>
        public static readonly RequestStatus PENDING = new RequestStatus("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RequestStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RequestStatus FindValue(string value)
        {
            return FindValue<RequestStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RequestStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServiceQuotaTemplateAssociationStatus.
    /// </summary>
    public class ServiceQuotaTemplateAssociationStatus : ConstantClass
    {

        /// <summary>
        /// Constant ASSOCIATED for ServiceQuotaTemplateAssociationStatus
        /// </summary>
        public static readonly ServiceQuotaTemplateAssociationStatus ASSOCIATED = new ServiceQuotaTemplateAssociationStatus("ASSOCIATED");
        /// <summary>
        /// Constant DISASSOCIATED for ServiceQuotaTemplateAssociationStatus
        /// </summary>
        public static readonly ServiceQuotaTemplateAssociationStatus DISASSOCIATED = new ServiceQuotaTemplateAssociationStatus("DISASSOCIATED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServiceQuotaTemplateAssociationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServiceQuotaTemplateAssociationStatus FindValue(string value)
        {
            return FindValue<ServiceQuotaTemplateAssociationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServiceQuotaTemplateAssociationStatus(string value)
        {
            return FindValue(value);
        }
    }

}