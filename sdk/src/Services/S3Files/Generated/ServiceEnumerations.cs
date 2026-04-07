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
 * Do not modify this file. This file is generated from the s3files-2025-05-05.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.S3Files
{

    /// <summary>
    /// Constants used for properties of type ImportTrigger.
    /// </summary>
    public class ImportTrigger : ConstantClass
    {

        /// <summary>
        /// Constant ON_DIRECTORY_FIRST_ACCESS for ImportTrigger
        /// </summary>
        public static readonly ImportTrigger ON_DIRECTORY_FIRST_ACCESS = new ImportTrigger("ON_DIRECTORY_FIRST_ACCESS");
        /// <summary>
        /// Constant ON_FILE_ACCESS for ImportTrigger
        /// </summary>
        public static readonly ImportTrigger ON_FILE_ACCESS = new ImportTrigger("ON_FILE_ACCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ImportTrigger(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ImportTrigger FindValue(string value)
        {
            return FindValue<ImportTrigger>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ImportTrigger(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IpAddressType.
    /// </summary>
    public class IpAddressType : ConstantClass
    {

        /// <summary>
        /// Constant DUAL_STACK for IpAddressType
        /// </summary>
        public static readonly IpAddressType DUAL_STACK = new IpAddressType("DUAL_STACK");
        /// <summary>
        /// Constant IPV4_ONLY for IpAddressType
        /// </summary>
        public static readonly IpAddressType IPV4_ONLY = new IpAddressType("IPV4_ONLY");
        /// <summary>
        /// Constant IPV6_ONLY for IpAddressType
        /// </summary>
        public static readonly IpAddressType IPV6_ONLY = new IpAddressType("IPV6_ONLY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IpAddressType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IpAddressType FindValue(string value)
        {
            return FindValue<IpAddressType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IpAddressType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LifeCycleState.
    /// </summary>
    public class LifeCycleState : ConstantClass
    {

        /// <summary>
        /// Constant Available for LifeCycleState
        /// </summary>
        public static readonly LifeCycleState Available = new LifeCycleState("available");
        /// <summary>
        /// Constant Creating for LifeCycleState
        /// </summary>
        public static readonly LifeCycleState Creating = new LifeCycleState("creating");
        /// <summary>
        /// Constant Deleted for LifeCycleState
        /// </summary>
        public static readonly LifeCycleState Deleted = new LifeCycleState("deleted");
        /// <summary>
        /// Constant Deleting for LifeCycleState
        /// </summary>
        public static readonly LifeCycleState Deleting = new LifeCycleState("deleting");
        /// <summary>
        /// Constant Error for LifeCycleState
        /// </summary>
        public static readonly LifeCycleState Error = new LifeCycleState("error");
        /// <summary>
        /// Constant Updating for LifeCycleState
        /// </summary>
        public static readonly LifeCycleState Updating = new LifeCycleState("updating");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LifeCycleState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LifeCycleState FindValue(string value)
        {
            return FindValue<LifeCycleState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LifeCycleState(string value)
        {
            return FindValue(value);
        }
    }

}