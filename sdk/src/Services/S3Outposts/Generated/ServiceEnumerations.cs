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
 * Do not modify this file. This file is generated from the s3outposts-2017-07-25.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.S3Outposts
{

    /// <summary>
    /// Constants used for properties of type EndpointAccessType.
    /// </summary>
    public class EndpointAccessType : ConstantClass
    {

        /// <summary>
        /// Constant CustomerOwnedIp for EndpointAccessType
        /// </summary>
        public static readonly EndpointAccessType CustomerOwnedIp = new EndpointAccessType("CustomerOwnedIp");
        /// <summary>
        /// Constant Private for EndpointAccessType
        /// </summary>
        public static readonly EndpointAccessType Private = new EndpointAccessType("Private");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EndpointAccessType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EndpointAccessType FindValue(string value)
        {
            return FindValue<EndpointAccessType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EndpointAccessType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EndpointStatus.
    /// </summary>
    public class EndpointStatus : ConstantClass
    {

        /// <summary>
        /// Constant Available for EndpointStatus
        /// </summary>
        public static readonly EndpointStatus Available = new EndpointStatus("Available");
        /// <summary>
        /// Constant Create_Failed for EndpointStatus
        /// </summary>
        public static readonly EndpointStatus Create_Failed = new EndpointStatus("Create_Failed");
        /// <summary>
        /// Constant Delete_Failed for EndpointStatus
        /// </summary>
        public static readonly EndpointStatus Delete_Failed = new EndpointStatus("Delete_Failed");
        /// <summary>
        /// Constant Deleting for EndpointStatus
        /// </summary>
        public static readonly EndpointStatus Deleting = new EndpointStatus("Deleting");
        /// <summary>
        /// Constant Pending for EndpointStatus
        /// </summary>
        public static readonly EndpointStatus Pending = new EndpointStatus("Pending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EndpointStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EndpointStatus FindValue(string value)
        {
            return FindValue<EndpointStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EndpointStatus(string value)
        {
            return FindValue(value);
        }
    }

}