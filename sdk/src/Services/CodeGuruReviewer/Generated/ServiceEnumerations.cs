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
 * Do not modify this file. This file is generated from the codeguru-reviewer-2019-09-19.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.CodeGuruReviewer
{

    /// <summary>
    /// Constants used for properties of type ProviderType.
    /// </summary>
    public class ProviderType : ConstantClass
    {

        /// <summary>
        /// Constant CodeCommit for ProviderType
        /// </summary>
        public static readonly ProviderType CodeCommit = new ProviderType("CodeCommit");
        /// <summary>
        /// Constant GitHub for ProviderType
        /// </summary>
        public static readonly ProviderType GitHub = new ProviderType("GitHub");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProviderType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProviderType FindValue(string value)
        {
            return FindValue<ProviderType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProviderType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RepositoryAssociationState.
    /// </summary>
    public class RepositoryAssociationState : ConstantClass
    {

        /// <summary>
        /// Constant Associated for RepositoryAssociationState
        /// </summary>
        public static readonly RepositoryAssociationState Associated = new RepositoryAssociationState("Associated");
        /// <summary>
        /// Constant Associating for RepositoryAssociationState
        /// </summary>
        public static readonly RepositoryAssociationState Associating = new RepositoryAssociationState("Associating");
        /// <summary>
        /// Constant Disassociating for RepositoryAssociationState
        /// </summary>
        public static readonly RepositoryAssociationState Disassociating = new RepositoryAssociationState("Disassociating");
        /// <summary>
        /// Constant Failed for RepositoryAssociationState
        /// </summary>
        public static readonly RepositoryAssociationState Failed = new RepositoryAssociationState("Failed");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RepositoryAssociationState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RepositoryAssociationState FindValue(string value)
        {
            return FindValue<RepositoryAssociationState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RepositoryAssociationState(string value)
        {
            return FindValue(value);
        }
    }

}