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
    /// Constants used for properties of type AnalysisType.
    /// </summary>
    public class AnalysisType : ConstantClass
    {

        /// <summary>
        /// Constant CodeQuality for AnalysisType
        /// </summary>
        public static readonly AnalysisType CodeQuality = new AnalysisType("CodeQuality");
        /// <summary>
        /// Constant Security for AnalysisType
        /// </summary>
        public static readonly AnalysisType Security = new AnalysisType("Security");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AnalysisType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AnalysisType FindValue(string value)
        {
            return FindValue<AnalysisType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AnalysisType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConfigFileState.
    /// </summary>
    public class ConfigFileState : ConstantClass
    {

        /// <summary>
        /// Constant Absent for ConfigFileState
        /// </summary>
        public static readonly ConfigFileState Absent = new ConfigFileState("Absent");
        /// <summary>
        /// Constant Present for ConfigFileState
        /// </summary>
        public static readonly ConfigFileState Present = new ConfigFileState("Present");
        /// <summary>
        /// Constant PresentWithErrors for ConfigFileState
        /// </summary>
        public static readonly ConfigFileState PresentWithErrors = new ConfigFileState("PresentWithErrors");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConfigFileState(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConfigFileState FindValue(string value)
        {
            return FindValue<ConfigFileState>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConfigFileState(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EncryptionOption.
    /// </summary>
    public class EncryptionOption : ConstantClass
    {

        /// <summary>
        /// Constant AWS_OWNED_CMK for EncryptionOption
        /// </summary>
        public static readonly EncryptionOption AWS_OWNED_CMK = new EncryptionOption("AWS_OWNED_CMK");
        /// <summary>
        /// Constant CUSTOMER_MANAGED_CMK for EncryptionOption
        /// </summary>
        public static readonly EncryptionOption CUSTOMER_MANAGED_CMK = new EncryptionOption("CUSTOMER_MANAGED_CMK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EncryptionOption(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EncryptionOption FindValue(string value)
        {
            return FindValue<EncryptionOption>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EncryptionOption(string value)
        {
            return FindValue(value);
        }
    }


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
        /// Constant S3Bucket for ProviderType
        /// </summary>
        public static readonly ProviderType S3Bucket = new ProviderType("S3Bucket");

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
    /// Constants used for properties of type RecommendationCategory.
    /// </summary>
    public class RecommendationCategory : ConstantClass
    {

        /// <summary>
        /// Constant AWSBestPractices for RecommendationCategory
        /// </summary>
        public static readonly RecommendationCategory AWSBestPractices = new RecommendationCategory("AWSBestPractices");
        /// <summary>
        /// Constant AWSCloudFormationIssues for RecommendationCategory
        /// </summary>
        public static readonly RecommendationCategory AWSCloudFormationIssues = new RecommendationCategory("AWSCloudFormationIssues");
        /// <summary>
        /// Constant CodeInconsistencies for RecommendationCategory
        /// </summary>
        public static readonly RecommendationCategory CodeInconsistencies = new RecommendationCategory("CodeInconsistencies");
        /// <summary>
        /// Constant CodeMaintenanceIssues for RecommendationCategory
        /// </summary>
        public static readonly RecommendationCategory CodeMaintenanceIssues = new RecommendationCategory("CodeMaintenanceIssues");
        /// <summary>
        /// Constant ConcurrencyIssues for RecommendationCategory
        /// </summary>
        public static readonly RecommendationCategory ConcurrencyIssues = new RecommendationCategory("ConcurrencyIssues");
        /// <summary>
        /// Constant DuplicateCode for RecommendationCategory
        /// </summary>
        public static readonly RecommendationCategory DuplicateCode = new RecommendationCategory("DuplicateCode");
        /// <summary>
        /// Constant InputValidations for RecommendationCategory
        /// </summary>
        public static readonly RecommendationCategory InputValidations = new RecommendationCategory("InputValidations");
        /// <summary>
        /// Constant JavaBestPractices for RecommendationCategory
        /// </summary>
        public static readonly RecommendationCategory JavaBestPractices = new RecommendationCategory("JavaBestPractices");
        /// <summary>
        /// Constant PythonBestPractices for RecommendationCategory
        /// </summary>
        public static readonly RecommendationCategory PythonBestPractices = new RecommendationCategory("PythonBestPractices");
        /// <summary>
        /// Constant ResourceLeaks for RecommendationCategory
        /// </summary>
        public static readonly RecommendationCategory ResourceLeaks = new RecommendationCategory("ResourceLeaks");
        /// <summary>
        /// Constant SecurityIssues for RecommendationCategory
        /// </summary>
        public static readonly RecommendationCategory SecurityIssues = new RecommendationCategory("SecurityIssues");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecommendationCategory(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecommendationCategory FindValue(string value)
        {
            return FindValue<RecommendationCategory>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecommendationCategory(string value)
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
    /// Constants used for properties of type Severity.
    /// </summary>
    public class Severity : ConstantClass
    {

        /// <summary>
        /// Constant Critical for Severity
        /// </summary>
        public static readonly Severity Critical = new Severity("Critical");
        /// <summary>
        /// Constant High for Severity
        /// </summary>
        public static readonly Severity High = new Severity("High");
        /// <summary>
        /// Constant Info for Severity
        /// </summary>
        public static readonly Severity Info = new Severity("Info");
        /// <summary>
        /// Constant Low for Severity
        /// </summary>
        public static readonly Severity Low = new Severity("Low");
        /// <summary>
        /// Constant Medium for Severity
        /// </summary>
        public static readonly Severity Medium = new Severity("Medium");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Severity(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Severity FindValue(string value)
        {
            return FindValue<Severity>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Severity(string value)
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


    /// <summary>
    /// Constants used for properties of type VendorName.
    /// </summary>
    public class VendorName : ConstantClass
    {

        /// <summary>
        /// Constant GitHub for VendorName
        /// </summary>
        public static readonly VendorName GitHub = new VendorName("GitHub");
        /// <summary>
        /// Constant GitLab for VendorName
        /// </summary>
        public static readonly VendorName GitLab = new VendorName("GitLab");
        /// <summary>
        /// Constant NativeS3 for VendorName
        /// </summary>
        public static readonly VendorName NativeS3 = new VendorName("NativeS3");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VendorName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VendorName FindValue(string value)
        {
            return FindValue<VendorName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VendorName(string value)
        {
            return FindValue(value);
        }
    }

}