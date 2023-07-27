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
 * Do not modify this file. This file is generated from the ebs-2019-11-02.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.EBS
{

    /// <summary>
    /// Constants used for properties of type AccessDeniedExceptionReason.
    /// </summary>
    public class AccessDeniedExceptionReason : ConstantClass
    {

        /// <summary>
        /// Constant DEPENDENCY_ACCESS_DENIED for AccessDeniedExceptionReason
        /// </summary>
        public static readonly AccessDeniedExceptionReason DEPENDENCY_ACCESS_DENIED = new AccessDeniedExceptionReason("DEPENDENCY_ACCESS_DENIED");
        /// <summary>
        /// Constant UNAUTHORIZED_ACCOUNT for AccessDeniedExceptionReason
        /// </summary>
        public static readonly AccessDeniedExceptionReason UNAUTHORIZED_ACCOUNT = new AccessDeniedExceptionReason("UNAUTHORIZED_ACCOUNT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccessDeniedExceptionReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccessDeniedExceptionReason FindValue(string value)
        {
            return FindValue<AccessDeniedExceptionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccessDeniedExceptionReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChecksumAggregationMethod.
    /// </summary>
    public class ChecksumAggregationMethod : ConstantClass
    {

        /// <summary>
        /// Constant LINEAR for ChecksumAggregationMethod
        /// </summary>
        public static readonly ChecksumAggregationMethod LINEAR = new ChecksumAggregationMethod("LINEAR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChecksumAggregationMethod(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChecksumAggregationMethod FindValue(string value)
        {
            return FindValue<ChecksumAggregationMethod>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChecksumAggregationMethod(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChecksumAlgorithm.
    /// </summary>
    public class ChecksumAlgorithm : ConstantClass
    {

        /// <summary>
        /// Constant SHA256 for ChecksumAlgorithm
        /// </summary>
        public static readonly ChecksumAlgorithm SHA256 = new ChecksumAlgorithm("SHA256");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChecksumAlgorithm(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChecksumAlgorithm FindValue(string value)
        {
            return FindValue<ChecksumAlgorithm>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChecksumAlgorithm(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RequestThrottledExceptionReason.
    /// </summary>
    public class RequestThrottledExceptionReason : ConstantClass
    {

        /// <summary>
        /// Constant ACCOUNT_THROTTLED for RequestThrottledExceptionReason
        /// </summary>
        public static readonly RequestThrottledExceptionReason ACCOUNT_THROTTLED = new RequestThrottledExceptionReason("ACCOUNT_THROTTLED");
        /// <summary>
        /// Constant DEPENDENCY_REQUEST_THROTTLED for RequestThrottledExceptionReason
        /// </summary>
        public static readonly RequestThrottledExceptionReason DEPENDENCY_REQUEST_THROTTLED = new RequestThrottledExceptionReason("DEPENDENCY_REQUEST_THROTTLED");
        /// <summary>
        /// Constant RESOURCE_LEVEL_THROTTLE for RequestThrottledExceptionReason
        /// </summary>
        public static readonly RequestThrottledExceptionReason RESOURCE_LEVEL_THROTTLE = new RequestThrottledExceptionReason("RESOURCE_LEVEL_THROTTLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RequestThrottledExceptionReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RequestThrottledExceptionReason FindValue(string value)
        {
            return FindValue<RequestThrottledExceptionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RequestThrottledExceptionReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceNotFoundExceptionReason.
    /// </summary>
    public class ResourceNotFoundExceptionReason : ConstantClass
    {

        /// <summary>
        /// Constant DEPENDENCY_RESOURCE_NOT_FOUND for ResourceNotFoundExceptionReason
        /// </summary>
        public static readonly ResourceNotFoundExceptionReason DEPENDENCY_RESOURCE_NOT_FOUND = new ResourceNotFoundExceptionReason("DEPENDENCY_RESOURCE_NOT_FOUND");
        /// <summary>
        /// Constant GRANT_NOT_FOUND for ResourceNotFoundExceptionReason
        /// </summary>
        public static readonly ResourceNotFoundExceptionReason GRANT_NOT_FOUND = new ResourceNotFoundExceptionReason("GRANT_NOT_FOUND");
        /// <summary>
        /// Constant IMAGE_NOT_FOUND for ResourceNotFoundExceptionReason
        /// </summary>
        public static readonly ResourceNotFoundExceptionReason IMAGE_NOT_FOUND = new ResourceNotFoundExceptionReason("IMAGE_NOT_FOUND");
        /// <summary>
        /// Constant SNAPSHOT_NOT_FOUND for ResourceNotFoundExceptionReason
        /// </summary>
        public static readonly ResourceNotFoundExceptionReason SNAPSHOT_NOT_FOUND = new ResourceNotFoundExceptionReason("SNAPSHOT_NOT_FOUND");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceNotFoundExceptionReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceNotFoundExceptionReason FindValue(string value)
        {
            return FindValue<ResourceNotFoundExceptionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceNotFoundExceptionReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServiceQuotaExceededExceptionReason.
    /// </summary>
    public class ServiceQuotaExceededExceptionReason : ConstantClass
    {

        /// <summary>
        /// Constant DEPENDENCY_SERVICE_QUOTA_EXCEEDED for ServiceQuotaExceededExceptionReason
        /// </summary>
        public static readonly ServiceQuotaExceededExceptionReason DEPENDENCY_SERVICE_QUOTA_EXCEEDED = new ServiceQuotaExceededExceptionReason("DEPENDENCY_SERVICE_QUOTA_EXCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServiceQuotaExceededExceptionReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServiceQuotaExceededExceptionReason FindValue(string value)
        {
            return FindValue<ServiceQuotaExceededExceptionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServiceQuotaExceededExceptionReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SSEType.
    /// </summary>
    public class SSEType : ConstantClass
    {

        /// <summary>
        /// Constant None for SSEType
        /// </summary>
        public static readonly SSEType None = new SSEType("none");
        /// <summary>
        /// Constant SseEbs for SSEType
        /// </summary>
        public static readonly SSEType SseEbs = new SSEType("sse-ebs");
        /// <summary>
        /// Constant SseKms for SSEType
        /// </summary>
        public static readonly SSEType SseKms = new SSEType("sse-kms");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SSEType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SSEType FindValue(string value)
        {
            return FindValue<SSEType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SSEType(string value)
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
        /// Constant Completed for Status
        /// </summary>
        public static readonly Status Completed = new Status("completed");
        /// <summary>
        /// Constant Error for Status
        /// </summary>
        public static readonly Status Error = new Status("error");
        /// <summary>
        /// Constant Pending for Status
        /// </summary>
        public static readonly Status Pending = new Status("pending");

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
        /// Constant CONFLICTING_BLOCK_UPDATE for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason CONFLICTING_BLOCK_UPDATE = new ValidationExceptionReason("CONFLICTING_BLOCK_UPDATE");
        /// <summary>
        /// Constant INVALID_BLOCK for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_BLOCK = new ValidationExceptionReason("INVALID_BLOCK");
        /// <summary>
        /// Constant INVALID_BLOCK_TOKEN for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_BLOCK_TOKEN = new ValidationExceptionReason("INVALID_BLOCK_TOKEN");
        /// <summary>
        /// Constant INVALID_CONTENT_ENCODING for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_CONTENT_ENCODING = new ValidationExceptionReason("INVALID_CONTENT_ENCODING");
        /// <summary>
        /// Constant INVALID_CUSTOMER_KEY for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_CUSTOMER_KEY = new ValidationExceptionReason("INVALID_CUSTOMER_KEY");
        /// <summary>
        /// Constant INVALID_DEPENDENCY_REQUEST for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_DEPENDENCY_REQUEST = new ValidationExceptionReason("INVALID_DEPENDENCY_REQUEST");
        /// <summary>
        /// Constant INVALID_GRANT_TOKEN for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_GRANT_TOKEN = new ValidationExceptionReason("INVALID_GRANT_TOKEN");
        /// <summary>
        /// Constant INVALID_IMAGE_ID for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_IMAGE_ID = new ValidationExceptionReason("INVALID_IMAGE_ID");
        /// <summary>
        /// Constant INVALID_PAGE_TOKEN for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_PAGE_TOKEN = new ValidationExceptionReason("INVALID_PAGE_TOKEN");
        /// <summary>
        /// Constant INVALID_PARAMETER_VALUE for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_PARAMETER_VALUE = new ValidationExceptionReason("INVALID_PARAMETER_VALUE");
        /// <summary>
        /// Constant INVALID_SNAPSHOT_ID for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_SNAPSHOT_ID = new ValidationExceptionReason("INVALID_SNAPSHOT_ID");
        /// <summary>
        /// Constant INVALID_TAG for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_TAG = new ValidationExceptionReason("INVALID_TAG");
        /// <summary>
        /// Constant INVALID_VOLUME_SIZE for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_VOLUME_SIZE = new ValidationExceptionReason("INVALID_VOLUME_SIZE");
        /// <summary>
        /// Constant UNRELATED_SNAPSHOTS for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason UNRELATED_SNAPSHOTS = new ValidationExceptionReason("UNRELATED_SNAPSHOTS");
        /// <summary>
        /// Constant WRITE_REQUEST_TIMEOUT for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason WRITE_REQUEST_TIMEOUT = new ValidationExceptionReason("WRITE_REQUEST_TIMEOUT");

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