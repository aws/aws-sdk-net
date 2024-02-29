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
 * Do not modify this file. This file is generated from the securitylake-2018-05-10.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.SecurityLake
{

    /// <summary>
    /// Constants used for properties of type AccessType.
    /// </summary>
    public class AccessType : ConstantClass
    {

        /// <summary>
        /// Constant LAKEFORMATION for AccessType
        /// </summary>
        public static readonly AccessType LAKEFORMATION = new AccessType("LAKEFORMATION");
        /// <summary>
        /// Constant S3 for AccessType
        /// </summary>
        public static readonly AccessType S3 = new AccessType("S3");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccessType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccessType FindValue(string value)
        {
            return FindValue<AccessType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccessType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AwsLogSourceName.
    /// </summary>
    public class AwsLogSourceName : ConstantClass
    {

        /// <summary>
        /// Constant CLOUD_TRAIL_MGMT for AwsLogSourceName
        /// </summary>
        public static readonly AwsLogSourceName CLOUD_TRAIL_MGMT = new AwsLogSourceName("CLOUD_TRAIL_MGMT");
        /// <summary>
        /// Constant EKS_AUDIT for AwsLogSourceName
        /// </summary>
        public static readonly AwsLogSourceName EKS_AUDIT = new AwsLogSourceName("EKS_AUDIT");
        /// <summary>
        /// Constant LAMBDA_EXECUTION for AwsLogSourceName
        /// </summary>
        public static readonly AwsLogSourceName LAMBDA_EXECUTION = new AwsLogSourceName("LAMBDA_EXECUTION");
        /// <summary>
        /// Constant ROUTE53 for AwsLogSourceName
        /// </summary>
        public static readonly AwsLogSourceName ROUTE53 = new AwsLogSourceName("ROUTE53");
        /// <summary>
        /// Constant S3_DATA for AwsLogSourceName
        /// </summary>
        public static readonly AwsLogSourceName S3_DATA = new AwsLogSourceName("S3_DATA");
        /// <summary>
        /// Constant SH_FINDINGS for AwsLogSourceName
        /// </summary>
        public static readonly AwsLogSourceName SH_FINDINGS = new AwsLogSourceName("SH_FINDINGS");
        /// <summary>
        /// Constant VPC_FLOW for AwsLogSourceName
        /// </summary>
        public static readonly AwsLogSourceName VPC_FLOW = new AwsLogSourceName("VPC_FLOW");
        /// <summary>
        /// Constant WAF for AwsLogSourceName
        /// </summary>
        public static readonly AwsLogSourceName WAF = new AwsLogSourceName("WAF");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AwsLogSourceName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AwsLogSourceName FindValue(string value)
        {
            return FindValue<AwsLogSourceName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AwsLogSourceName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DataLakeStatus.
    /// </summary>
    public class DataLakeStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for DataLakeStatus
        /// </summary>
        public static readonly DataLakeStatus COMPLETED = new DataLakeStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for DataLakeStatus
        /// </summary>
        public static readonly DataLakeStatus FAILED = new DataLakeStatus("FAILED");
        /// <summary>
        /// Constant INITIALIZED for DataLakeStatus
        /// </summary>
        public static readonly DataLakeStatus INITIALIZED = new DataLakeStatus("INITIALIZED");
        /// <summary>
        /// Constant PENDING for DataLakeStatus
        /// </summary>
        public static readonly DataLakeStatus PENDING = new DataLakeStatus("PENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DataLakeStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DataLakeStatus FindValue(string value)
        {
            return FindValue<DataLakeStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DataLakeStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HttpMethod.
    /// </summary>
    public class HttpMethod : ConstantClass
    {

        /// <summary>
        /// Constant POST for HttpMethod
        /// </summary>
        public static readonly HttpMethod POST = new HttpMethod("POST");
        /// <summary>
        /// Constant PUT for HttpMethod
        /// </summary>
        public static readonly HttpMethod PUT = new HttpMethod("PUT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HttpMethod(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HttpMethod FindValue(string value)
        {
            return FindValue<HttpMethod>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HttpMethod(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SourceCollectionStatus.
    /// </summary>
    public class SourceCollectionStatus : ConstantClass
    {

        /// <summary>
        /// Constant COLLECTING for SourceCollectionStatus
        /// </summary>
        public static readonly SourceCollectionStatus COLLECTING = new SourceCollectionStatus("COLLECTING");
        /// <summary>
        /// Constant MISCONFIGURED for SourceCollectionStatus
        /// </summary>
        public static readonly SourceCollectionStatus MISCONFIGURED = new SourceCollectionStatus("MISCONFIGURED");
        /// <summary>
        /// Constant NOT_COLLECTING for SourceCollectionStatus
        /// </summary>
        public static readonly SourceCollectionStatus NOT_COLLECTING = new SourceCollectionStatus("NOT_COLLECTING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SourceCollectionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SourceCollectionStatus FindValue(string value)
        {
            return FindValue<SourceCollectionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SourceCollectionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SubscriberStatus.
    /// </summary>
    public class SubscriberStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for SubscriberStatus
        /// </summary>
        public static readonly SubscriberStatus ACTIVE = new SubscriberStatus("ACTIVE");
        /// <summary>
        /// Constant DEACTIVATED for SubscriberStatus
        /// </summary>
        public static readonly SubscriberStatus DEACTIVATED = new SubscriberStatus("DEACTIVATED");
        /// <summary>
        /// Constant PENDING for SubscriberStatus
        /// </summary>
        public static readonly SubscriberStatus PENDING = new SubscriberStatus("PENDING");
        /// <summary>
        /// Constant READY for SubscriberStatus
        /// </summary>
        public static readonly SubscriberStatus READY = new SubscriberStatus("READY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SubscriberStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SubscriberStatus FindValue(string value)
        {
            return FindValue<SubscriberStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SubscriberStatus(string value)
        {
            return FindValue(value);
        }
    }

}