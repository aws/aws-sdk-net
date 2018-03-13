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
 * Do not modify this file. This file is generated from the servicediscovery-2017-03-14.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.ServiceDiscovery
{

    /// <summary>
    /// Constants used for properties of type CustomHealthStatus.
    /// </summary>
    public class CustomHealthStatus : ConstantClass
    {

        /// <summary>
        /// Constant HEALTHY for CustomHealthStatus
        /// </summary>
        public static readonly CustomHealthStatus HEALTHY = new CustomHealthStatus("HEALTHY");
        /// <summary>
        /// Constant UNHEALTHY for CustomHealthStatus
        /// </summary>
        public static readonly CustomHealthStatus UNHEALTHY = new CustomHealthStatus("UNHEALTHY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CustomHealthStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CustomHealthStatus FindValue(string value)
        {
            return FindValue<CustomHealthStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CustomHealthStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FilterCondition.
    /// </summary>
    public class FilterCondition : ConstantClass
    {

        /// <summary>
        /// Constant BETWEEN for FilterCondition
        /// </summary>
        public static readonly FilterCondition BETWEEN = new FilterCondition("BETWEEN");
        /// <summary>
        /// Constant EQ for FilterCondition
        /// </summary>
        public static readonly FilterCondition EQ = new FilterCondition("EQ");
        /// <summary>
        /// Constant IN for FilterCondition
        /// </summary>
        public static readonly FilterCondition IN = new FilterCondition("IN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FilterCondition(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FilterCondition FindValue(string value)
        {
            return FindValue<FilterCondition>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FilterCondition(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HealthCheckType.
    /// </summary>
    public class HealthCheckType : ConstantClass
    {

        /// <summary>
        /// Constant HTTP for HealthCheckType
        /// </summary>
        public static readonly HealthCheckType HTTP = new HealthCheckType("HTTP");
        /// <summary>
        /// Constant HTTPS for HealthCheckType
        /// </summary>
        public static readonly HealthCheckType HTTPS = new HealthCheckType("HTTPS");
        /// <summary>
        /// Constant TCP for HealthCheckType
        /// </summary>
        public static readonly HealthCheckType TCP = new HealthCheckType("TCP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HealthCheckType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HealthCheckType FindValue(string value)
        {
            return FindValue<HealthCheckType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HealthCheckType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HealthStatus.
    /// </summary>
    public class HealthStatus : ConstantClass
    {

        /// <summary>
        /// Constant HEALTHY for HealthStatus
        /// </summary>
        public static readonly HealthStatus HEALTHY = new HealthStatus("HEALTHY");
        /// <summary>
        /// Constant UNHEALTHY for HealthStatus
        /// </summary>
        public static readonly HealthStatus UNHEALTHY = new HealthStatus("UNHEALTHY");
        /// <summary>
        /// Constant UNKNOWN for HealthStatus
        /// </summary>
        public static readonly HealthStatus UNKNOWN = new HealthStatus("UNKNOWN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HealthStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HealthStatus FindValue(string value)
        {
            return FindValue<HealthStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HealthStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NamespaceFilterName.
    /// </summary>
    public class NamespaceFilterName : ConstantClass
    {

        /// <summary>
        /// Constant TYPE for NamespaceFilterName
        /// </summary>
        public static readonly NamespaceFilterName TYPE = new NamespaceFilterName("TYPE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NamespaceFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NamespaceFilterName FindValue(string value)
        {
            return FindValue<NamespaceFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NamespaceFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NamespaceType.
    /// </summary>
    public class NamespaceType : ConstantClass
    {

        /// <summary>
        /// Constant DNS_PRIVATE for NamespaceType
        /// </summary>
        public static readonly NamespaceType DNS_PRIVATE = new NamespaceType("DNS_PRIVATE");
        /// <summary>
        /// Constant DNS_PUBLIC for NamespaceType
        /// </summary>
        public static readonly NamespaceType DNS_PUBLIC = new NamespaceType("DNS_PUBLIC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NamespaceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NamespaceType FindValue(string value)
        {
            return FindValue<NamespaceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NamespaceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OperationFilterName.
    /// </summary>
    public class OperationFilterName : ConstantClass
    {

        /// <summary>
        /// Constant NAMESPACE_ID for OperationFilterName
        /// </summary>
        public static readonly OperationFilterName NAMESPACE_ID = new OperationFilterName("NAMESPACE_ID");
        /// <summary>
        /// Constant SERVICE_ID for OperationFilterName
        /// </summary>
        public static readonly OperationFilterName SERVICE_ID = new OperationFilterName("SERVICE_ID");
        /// <summary>
        /// Constant STATUS for OperationFilterName
        /// </summary>
        public static readonly OperationFilterName STATUS = new OperationFilterName("STATUS");
        /// <summary>
        /// Constant TYPE for OperationFilterName
        /// </summary>
        public static readonly OperationFilterName TYPE = new OperationFilterName("TYPE");
        /// <summary>
        /// Constant UPDATE_DATE for OperationFilterName
        /// </summary>
        public static readonly OperationFilterName UPDATE_DATE = new OperationFilterName("UPDATE_DATE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OperationFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OperationFilterName FindValue(string value)
        {
            return FindValue<OperationFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OperationFilterName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OperationStatus.
    /// </summary>
    public class OperationStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAIL for OperationStatus
        /// </summary>
        public static readonly OperationStatus FAIL = new OperationStatus("FAIL");
        /// <summary>
        /// Constant PENDING for OperationStatus
        /// </summary>
        public static readonly OperationStatus PENDING = new OperationStatus("PENDING");
        /// <summary>
        /// Constant SUBMITTED for OperationStatus
        /// </summary>
        public static readonly OperationStatus SUBMITTED = new OperationStatus("SUBMITTED");
        /// <summary>
        /// Constant SUCCESS for OperationStatus
        /// </summary>
        public static readonly OperationStatus SUCCESS = new OperationStatus("SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OperationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OperationStatus FindValue(string value)
        {
            return FindValue<OperationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OperationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OperationTargetType.
    /// </summary>
    public class OperationTargetType : ConstantClass
    {

        /// <summary>
        /// Constant INSTANCE for OperationTargetType
        /// </summary>
        public static readonly OperationTargetType INSTANCE = new OperationTargetType("INSTANCE");
        /// <summary>
        /// Constant NAMESPACE for OperationTargetType
        /// </summary>
        public static readonly OperationTargetType NAMESPACE = new OperationTargetType("NAMESPACE");
        /// <summary>
        /// Constant SERVICE for OperationTargetType
        /// </summary>
        public static readonly OperationTargetType SERVICE = new OperationTargetType("SERVICE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OperationTargetType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OperationTargetType FindValue(string value)
        {
            return FindValue<OperationTargetType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OperationTargetType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OperationType.
    /// </summary>
    public class OperationType : ConstantClass
    {

        /// <summary>
        /// Constant CREATE_NAMESPACE for OperationType
        /// </summary>
        public static readonly OperationType CREATE_NAMESPACE = new OperationType("CREATE_NAMESPACE");
        /// <summary>
        /// Constant DELETE_NAMESPACE for OperationType
        /// </summary>
        public static readonly OperationType DELETE_NAMESPACE = new OperationType("DELETE_NAMESPACE");
        /// <summary>
        /// Constant DEREGISTER_INSTANCE for OperationType
        /// </summary>
        public static readonly OperationType DEREGISTER_INSTANCE = new OperationType("DEREGISTER_INSTANCE");
        /// <summary>
        /// Constant REGISTER_INSTANCE for OperationType
        /// </summary>
        public static readonly OperationType REGISTER_INSTANCE = new OperationType("REGISTER_INSTANCE");
        /// <summary>
        /// Constant UPDATE_SERVICE for OperationType
        /// </summary>
        public static readonly OperationType UPDATE_SERVICE = new OperationType("UPDATE_SERVICE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OperationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OperationType FindValue(string value)
        {
            return FindValue<OperationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OperationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RecordType.
    /// </summary>
    public class RecordType : ConstantClass
    {

        /// <summary>
        /// Constant A for RecordType
        /// </summary>
        public static readonly RecordType A = new RecordType("A");
        /// <summary>
        /// Constant AAAA for RecordType
        /// </summary>
        public static readonly RecordType AAAA = new RecordType("AAAA");
        /// <summary>
        /// Constant CNAME for RecordType
        /// </summary>
        public static readonly RecordType CNAME = new RecordType("CNAME");
        /// <summary>
        /// Constant SRV for RecordType
        /// </summary>
        public static readonly RecordType SRV = new RecordType("SRV");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecordType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecordType FindValue(string value)
        {
            return FindValue<RecordType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecordType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RoutingPolicy.
    /// </summary>
    public class RoutingPolicy : ConstantClass
    {

        /// <summary>
        /// Constant MULTIVALUE for RoutingPolicy
        /// </summary>
        public static readonly RoutingPolicy MULTIVALUE = new RoutingPolicy("MULTIVALUE");
        /// <summary>
        /// Constant WEIGHTED for RoutingPolicy
        /// </summary>
        public static readonly RoutingPolicy WEIGHTED = new RoutingPolicy("WEIGHTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RoutingPolicy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RoutingPolicy FindValue(string value)
        {
            return FindValue<RoutingPolicy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RoutingPolicy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ServiceFilterName.
    /// </summary>
    public class ServiceFilterName : ConstantClass
    {

        /// <summary>
        /// Constant NAMESPACE_ID for ServiceFilterName
        /// </summary>
        public static readonly ServiceFilterName NAMESPACE_ID = new ServiceFilterName("NAMESPACE_ID");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ServiceFilterName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ServiceFilterName FindValue(string value)
        {
            return FindValue<ServiceFilterName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ServiceFilterName(string value)
        {
            return FindValue(value);
        }
    }

}