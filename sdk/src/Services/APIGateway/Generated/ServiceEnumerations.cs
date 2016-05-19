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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.APIGateway
{

    /// <summary>
    /// Constants used for properties of type AuthorizerType.
    /// </summary>
    public class AuthorizerType : ConstantClass
    {

        /// <summary>
        /// Constant TOKEN for AuthorizerType
        /// </summary>
        public static readonly AuthorizerType TOKEN = new AuthorizerType("TOKEN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuthorizerType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuthorizerType FindValue(string value)
        {
            return FindValue<AuthorizerType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuthorizerType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CacheClusterSize.
    /// </summary>
    public class CacheClusterSize : ConstantClass
    {

        /// <summary>
        /// Constant GB_0_5 for CacheClusterSize
        /// </summary>
        public static readonly CacheClusterSize GB_0_5 = new CacheClusterSize("0.5");
        /// <summary>
        /// Constant GB_1_6 for CacheClusterSize
        /// </summary>
        public static readonly CacheClusterSize GB_1_6 = new CacheClusterSize("1.6");
        /// <summary>
        /// Constant GB_118 for CacheClusterSize
        /// </summary>
        public static readonly CacheClusterSize GB_118 = new CacheClusterSize("118");
        /// <summary>
        /// Constant GB_13_5 for CacheClusterSize
        /// </summary>
        public static readonly CacheClusterSize GB_13_5 = new CacheClusterSize("13.5");
        /// <summary>
        /// Constant GB_237 for CacheClusterSize
        /// </summary>
        public static readonly CacheClusterSize GB_237 = new CacheClusterSize("237");
        /// <summary>
        /// Constant GB_28_4 for CacheClusterSize
        /// </summary>
        public static readonly CacheClusterSize GB_28_4 = new CacheClusterSize("28.4");
        /// <summary>
        /// Constant GB_58_2 for CacheClusterSize
        /// </summary>
        public static readonly CacheClusterSize GB_58_2 = new CacheClusterSize("58.2");
        /// <summary>
        /// Constant GB_6_1 for CacheClusterSize
        /// </summary>
        public static readonly CacheClusterSize GB_6_1 = new CacheClusterSize("6.1");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CacheClusterSize(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CacheClusterSize FindValue(string value)
        {
            return FindValue<CacheClusterSize>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CacheClusterSize(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CacheClusterStatus.
    /// </summary>
    public class CacheClusterStatus : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for CacheClusterStatus
        /// </summary>
        public static readonly CacheClusterStatus AVAILABLE = new CacheClusterStatus("AVAILABLE");
        /// <summary>
        /// Constant CREATE_IN_PROGRESS for CacheClusterStatus
        /// </summary>
        public static readonly CacheClusterStatus CREATE_IN_PROGRESS = new CacheClusterStatus("CREATE_IN_PROGRESS");
        /// <summary>
        /// Constant DELETE_IN_PROGRESS for CacheClusterStatus
        /// </summary>
        public static readonly CacheClusterStatus DELETE_IN_PROGRESS = new CacheClusterStatus("DELETE_IN_PROGRESS");
        /// <summary>
        /// Constant FLUSH_IN_PROGRESS for CacheClusterStatus
        /// </summary>
        public static readonly CacheClusterStatus FLUSH_IN_PROGRESS = new CacheClusterStatus("FLUSH_IN_PROGRESS");
        /// <summary>
        /// Constant NOT_AVAILABLE for CacheClusterStatus
        /// </summary>
        public static readonly CacheClusterStatus NOT_AVAILABLE = new CacheClusterStatus("NOT_AVAILABLE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CacheClusterStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CacheClusterStatus FindValue(string value)
        {
            return FindValue<CacheClusterStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CacheClusterStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IntegrationType.
    /// </summary>
    public class IntegrationType : ConstantClass
    {

        /// <summary>
        /// Constant AWS for IntegrationType
        /// </summary>
        public static readonly IntegrationType AWS = new IntegrationType("AWS");
        /// <summary>
        /// Constant HTTP for IntegrationType
        /// </summary>
        public static readonly IntegrationType HTTP = new IntegrationType("HTTP");
        /// <summary>
        /// Constant MOCK for IntegrationType
        /// </summary>
        public static readonly IntegrationType MOCK = new IntegrationType("MOCK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IntegrationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IntegrationType FindValue(string value)
        {
            return FindValue<IntegrationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IntegrationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Op.
    /// </summary>
    public class Op : ConstantClass
    {

        /// <summary>
        /// Constant Add for Op
        /// </summary>
        public static readonly Op Add = new Op("add");
        /// <summary>
        /// Constant Copy for Op
        /// </summary>
        public static readonly Op Copy = new Op("copy");
        /// <summary>
        /// Constant Move for Op
        /// </summary>
        public static readonly Op Move = new Op("move");
        /// <summary>
        /// Constant Remove for Op
        /// </summary>
        public static readonly Op Remove = new Op("remove");
        /// <summary>
        /// Constant Replace for Op
        /// </summary>
        public static readonly Op Replace = new Op("replace");
        /// <summary>
        /// Constant Test for Op
        /// </summary>
        public static readonly Op Test = new Op("test");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Op(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Op FindValue(string value)
        {
            return FindValue<Op>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Op(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PutMode.
    /// </summary>
    public class PutMode : ConstantClass
    {

        /// <summary>
        /// Constant Merge for PutMode
        /// </summary>
        public static readonly PutMode Merge = new PutMode("merge");
        /// <summary>
        /// Constant Overwrite for PutMode
        /// </summary>
        public static readonly PutMode Overwrite = new PutMode("overwrite");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PutMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PutMode FindValue(string value)
        {
            return FindValue<PutMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PutMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UnauthorizedCacheControlHeaderStrategy.
    /// </summary>
    public class UnauthorizedCacheControlHeaderStrategy : ConstantClass
    {

        /// <summary>
        /// Constant FAIL_WITH_403 for UnauthorizedCacheControlHeaderStrategy
        /// </summary>
        public static readonly UnauthorizedCacheControlHeaderStrategy FAIL_WITH_403 = new UnauthorizedCacheControlHeaderStrategy("FAIL_WITH_403");
        /// <summary>
        /// Constant SUCCEED_WITH_RESPONSE_HEADER for UnauthorizedCacheControlHeaderStrategy
        /// </summary>
        public static readonly UnauthorizedCacheControlHeaderStrategy SUCCEED_WITH_RESPONSE_HEADER = new UnauthorizedCacheControlHeaderStrategy("SUCCEED_WITH_RESPONSE_HEADER");
        /// <summary>
        /// Constant SUCCEED_WITHOUT_RESPONSE_HEADER for UnauthorizedCacheControlHeaderStrategy
        /// </summary>
        public static readonly UnauthorizedCacheControlHeaderStrategy SUCCEED_WITHOUT_RESPONSE_HEADER = new UnauthorizedCacheControlHeaderStrategy("SUCCEED_WITHOUT_RESPONSE_HEADER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UnauthorizedCacheControlHeaderStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UnauthorizedCacheControlHeaderStrategy FindValue(string value)
        {
            return FindValue<UnauthorizedCacheControlHeaderStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UnauthorizedCacheControlHeaderStrategy(string value)
        {
            return FindValue(value);
        }
    }

}