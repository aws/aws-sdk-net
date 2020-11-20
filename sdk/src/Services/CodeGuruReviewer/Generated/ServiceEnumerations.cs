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
 * Do not modify this file. This file is generated from the codeguru-reviewer-2019-09-19.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.CodeGuruReviewer
{

    /// <summary>
    /// Constants used for properties of type JobState.
    /// </summary>
    public class JobState : ConstantClass
    {

        /// <summary>
        /// Constant Completed for JobState
        /// </summary>
        public static readonly JobState Completed = new JobState("Completed");
        /// <summary>
        /// Constant Deleting for JobState
        /// </summary>
        public static readonly JobState Deleting = new JobState("Deleting");
        /// <summary>
        /// Constant Failed for JobState
        /// </summary>
        public static readonly JobState Failed = new JobState("Failed");
        /// <summary>
        /// Constant Pending for JobState
        /// </summary>
        public static readonly JobState Pending = new JobState("Pending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JobState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JobState FindValue(string value)
        {
            return FindValue<JobState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JobState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProviderType.
    /// </summary>
    public class ProviderType : ConstantClass
    {

        /// <summary>
        /// Constant Bitbucket for ProviderType
        /// </summary>
        public static readonly ProviderType Bitbucket = new ProviderType("Bitbucket");
        /// <summary>
        /// Constant CodeCommit for ProviderType
        /// </summary>
        public static readonly ProviderType CodeCommit = new ProviderType("CodeCommit");
        /// <summary>
        /// Constant GitHub for ProviderType
        /// </summary>
        public static readonly ProviderType GitHub = new ProviderType("GitHub");
        /// <summary>
        /// Constant GitHubEnterpriseServer for ProviderType
        /// </summary>
        public static readonly ProviderType GitHubEnterpriseServer = new ProviderType("GitHubEnterpriseServer");

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
    /// Constants used for properties of type Reaction.
    /// </summary>
    public class Reaction : ConstantClass
    {

        /// <summary>
        /// Constant ThumbsDown for Reaction
        /// </summary>
        public static readonly Reaction ThumbsDown = new Reaction("ThumbsDown");
        /// <summary>
        /// Constant ThumbsUp for Reaction
        /// </summary>
        public static readonly Reaction ThumbsUp = new Reaction("ThumbsUp");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Reaction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Reaction FindValue(string value)
        {
            return FindValue<Reaction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Reaction(string value)
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
        /// Constant Disassociated for RepositoryAssociationState
        /// </summary>
        public static readonly RepositoryAssociationState Disassociated = new RepositoryAssociationState("Disassociated");
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


    /// <summary>
    /// Constants used for properties of type Type.
    /// </summary>
    public class Type : ConstantClass
    {

        /// <summary>
        /// Constant PullRequest for Type
        /// </summary>
        public static readonly Type PullRequest = new Type("PullRequest");
        /// <summary>
        /// Constant RepositoryAnalysis for Type
        /// </summary>
        public static readonly Type RepositoryAnalysis = new Type("RepositoryAnalysis");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Type(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Type FindValue(string value)
        {
            return FindValue<Type>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Type(string value)
        {
            return FindValue(value);
        }
    }

}