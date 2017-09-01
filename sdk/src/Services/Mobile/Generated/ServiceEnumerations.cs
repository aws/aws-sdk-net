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
 * Do not modify this file. This file is generated from the mobile-2017-07-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.Mobile
{

    /// <summary>
    /// Constants used for properties of type Platform.
    /// </summary>
    public class Platform : ConstantClass
    {

        /// <summary>
        /// Constant ANDROID for Platform
        /// </summary>
        public static readonly Platform ANDROID = new Platform("ANDROID");
        /// <summary>
        /// Constant JAVASCRIPT for Platform
        /// </summary>
        public static readonly Platform JAVASCRIPT = new Platform("JAVASCRIPT");
        /// <summary>
        /// Constant LINUX for Platform
        /// </summary>
        public static readonly Platform LINUX = new Platform("LINUX");
        /// <summary>
        /// Constant OBJC for Platform
        /// </summary>
        public static readonly Platform OBJC = new Platform("OBJC");
        /// <summary>
        /// Constant OSX for Platform
        /// </summary>
        public static readonly Platform OSX = new Platform("OSX");
        /// <summary>
        /// Constant SWIFT for Platform
        /// </summary>
        public static readonly Platform SWIFT = new Platform("SWIFT");
        /// <summary>
        /// Constant WINDOWS for Platform
        /// </summary>
        public static readonly Platform WINDOWS = new Platform("WINDOWS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
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

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Platform(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProjectState.
    /// </summary>
    public class ProjectState : ConstantClass
    {

        /// <summary>
        /// Constant IMPORTING for ProjectState
        /// </summary>
        public static readonly ProjectState IMPORTING = new ProjectState("IMPORTING");
        /// <summary>
        /// Constant NORMAL for ProjectState
        /// </summary>
        public static readonly ProjectState NORMAL = new ProjectState("NORMAL");
        /// <summary>
        /// Constant SYNCING for ProjectState
        /// </summary>
        public static readonly ProjectState SYNCING = new ProjectState("SYNCING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProjectState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProjectState FindValue(string value)
        {
            return FindValue<ProjectState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProjectState(string value)
        {
            return FindValue(value);
        }
    }

}