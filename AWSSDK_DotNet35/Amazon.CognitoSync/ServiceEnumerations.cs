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
 * Do not modify this file. This file is generated from the cognito-sync-2014-06-30.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.CognitoSync
{

    /// <summary>
    /// Constants used for properties of type Operation.
    /// </summary>
    public class Operation : ConstantClass
    {

        /// <summary>
        /// Constant Remove for Operation
        /// </summary>
        public static readonly Operation Remove = new Operation("remove");
        /// <summary>
        /// Constant Replace for Operation
        /// </summary>
        public static readonly Operation Replace = new Operation("replace");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Operation(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Operation FindValue(string value)
        {
            return FindValue<Operation>(value);
        }

        public static implicit operator Operation(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Platform.
    /// </summary>
    public class Platform : ConstantClass
    {

        /// <summary>
        /// Constant ADM for Platform
        /// </summary>
        public static readonly Platform ADM = new Platform("ADM");
        /// <summary>
        /// Constant APNS for Platform
        /// </summary>
        public static readonly Platform APNS = new Platform("APNS");
        /// <summary>
        /// Constant APNS_SANDBOX for Platform
        /// </summary>
        public static readonly Platform APNS_SANDBOX = new Platform("APNS_SANDBOX");
        /// <summary>
        /// Constant GCM for Platform
        /// </summary>
        public static readonly Platform GCM = new Platform("GCM");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Platform(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Platform FindValue(string value)
        {
            return FindValue<Platform>(value);
        }

        public static implicit operator Platform(string value)
        {
            return FindValue(value);
        }
    }

}