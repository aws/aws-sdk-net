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
 * Do not modify this file. This file is generated from the cloud9-2017-09-23.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Cloud9
{

    /// <summary>
    /// Constants used for properties of type EnvironmentStatus.
    /// </summary>
    public class EnvironmentStatus : ConstantClass
    {

        /// <summary>
        /// Constant Connecting for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus Connecting = new EnvironmentStatus("connecting");
        /// <summary>
        /// Constant Creating for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus Creating = new EnvironmentStatus("creating");
        /// <summary>
        /// Constant Deleting for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus Deleting = new EnvironmentStatus("deleting");
        /// <summary>
        /// Constant Error for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus Error = new EnvironmentStatus("error");
        /// <summary>
        /// Constant Ready for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus Ready = new EnvironmentStatus("ready");
        /// <summary>
        /// Constant Stopped for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus Stopped = new EnvironmentStatus("stopped");
        /// <summary>
        /// Constant Stopping for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus Stopping = new EnvironmentStatus("stopping");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EnvironmentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EnvironmentStatus FindValue(string value)
        {
            return FindValue<EnvironmentStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EnvironmentStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EnvironmentType.
    /// </summary>
    public class EnvironmentType : ConstantClass
    {

        /// <summary>
        /// Constant Ec2 for EnvironmentType
        /// </summary>
        public static readonly EnvironmentType Ec2 = new EnvironmentType("ec2");
        /// <summary>
        /// Constant Ssh for EnvironmentType
        /// </summary>
        public static readonly EnvironmentType Ssh = new EnvironmentType("ssh");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EnvironmentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EnvironmentType FindValue(string value)
        {
            return FindValue<EnvironmentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EnvironmentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MemberPermissions.
    /// </summary>
    public class MemberPermissions : ConstantClass
    {

        /// <summary>
        /// Constant ReadOnly for MemberPermissions
        /// </summary>
        public static readonly MemberPermissions ReadOnly = new MemberPermissions("read-only");
        /// <summary>
        /// Constant ReadWrite for MemberPermissions
        /// </summary>
        public static readonly MemberPermissions ReadWrite = new MemberPermissions("read-write");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MemberPermissions(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MemberPermissions FindValue(string value)
        {
            return FindValue<MemberPermissions>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MemberPermissions(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PermissionsType.
    /// </summary>
    public class PermissionsType : ConstantClass
    {

        /// <summary>
        /// Constant Owner for PermissionsType
        /// </summary>
        public static readonly PermissionsType Owner = new PermissionsType("owner");
        /// <summary>
        /// Constant ReadOnly for PermissionsType
        /// </summary>
        public static readonly PermissionsType ReadOnly = new PermissionsType("read-only");
        /// <summary>
        /// Constant ReadWrite for PermissionsType
        /// </summary>
        public static readonly PermissionsType ReadWrite = new PermissionsType("read-write");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PermissionsType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PermissionsType FindValue(string value)
        {
            return FindValue<PermissionsType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PermissionsType(string value)
        {
            return FindValue(value);
        }
    }

}