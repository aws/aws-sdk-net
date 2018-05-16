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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.ServiceCatalog
{

    /// <summary>
    /// Constants used for properties of type AccessLevelFilterKey.
    /// </summary>
    public class AccessLevelFilterKey : ConstantClass
    {

        /// <summary>
        /// Constant Account for AccessLevelFilterKey
        /// </summary>
        public static readonly AccessLevelFilterKey Account = new AccessLevelFilterKey("Account");
        /// <summary>
        /// Constant Role for AccessLevelFilterKey
        /// </summary>
        public static readonly AccessLevelFilterKey Role = new AccessLevelFilterKey("Role");
        /// <summary>
        /// Constant User for AccessLevelFilterKey
        /// </summary>
        public static readonly AccessLevelFilterKey User = new AccessLevelFilterKey("User");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccessLevelFilterKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccessLevelFilterKey FindValue(string value)
        {
            return FindValue<AccessLevelFilterKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccessLevelFilterKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ChangeAction.
    /// </summary>
    public class ChangeAction : ConstantClass
    {

        /// <summary>
        /// Constant ADD for ChangeAction
        /// </summary>
        public static readonly ChangeAction ADD = new ChangeAction("ADD");
        /// <summary>
        /// Constant MODIFY for ChangeAction
        /// </summary>
        public static readonly ChangeAction MODIFY = new ChangeAction("MODIFY");
        /// <summary>
        /// Constant REMOVE for ChangeAction
        /// </summary>
        public static readonly ChangeAction REMOVE = new ChangeAction("REMOVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ChangeAction(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ChangeAction FindValue(string value)
        {
            return FindValue<ChangeAction>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ChangeAction(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CopyOption.
    /// </summary>
    public class CopyOption : ConstantClass
    {

        /// <summary>
        /// Constant CopyTags for CopyOption
        /// </summary>
        public static readonly CopyOption CopyTags = new CopyOption("CopyTags");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CopyOption(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CopyOption FindValue(string value)
        {
            return FindValue<CopyOption>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CopyOption(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CopyProductStatus.
    /// </summary>
    public class CopyProductStatus : ConstantClass
    {

        /// <summary>
        /// Constant FAILED for CopyProductStatus
        /// </summary>
        public static readonly CopyProductStatus FAILED = new CopyProductStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for CopyProductStatus
        /// </summary>
        public static readonly CopyProductStatus IN_PROGRESS = new CopyProductStatus("IN_PROGRESS");
        /// <summary>
        /// Constant SUCCEEDED for CopyProductStatus
        /// </summary>
        public static readonly CopyProductStatus SUCCEEDED = new CopyProductStatus("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CopyProductStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CopyProductStatus FindValue(string value)
        {
            return FindValue<CopyProductStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CopyProductStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EvaluationType.
    /// </summary>
    public class EvaluationType : ConstantClass
    {

        /// <summary>
        /// Constant DYNAMIC for EvaluationType
        /// </summary>
        public static readonly EvaluationType DYNAMIC = new EvaluationType("DYNAMIC");
        /// <summary>
        /// Constant STATIC for EvaluationType
        /// </summary>
        public static readonly EvaluationType STATIC = new EvaluationType("STATIC");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EvaluationType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EvaluationType FindValue(string value)
        {
            return FindValue<EvaluationType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EvaluationType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PortfolioShareType.
    /// </summary>
    public class PortfolioShareType : ConstantClass
    {

        /// <summary>
        /// Constant AWS_SERVICECATALOG for PortfolioShareType
        /// </summary>
        public static readonly PortfolioShareType AWS_SERVICECATALOG = new PortfolioShareType("AWS_SERVICECATALOG");
        /// <summary>
        /// Constant IMPORTED for PortfolioShareType
        /// </summary>
        public static readonly PortfolioShareType IMPORTED = new PortfolioShareType("IMPORTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PortfolioShareType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PortfolioShareType FindValue(string value)
        {
            return FindValue<PortfolioShareType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PortfolioShareType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PrincipalType.
    /// </summary>
    public class PrincipalType : ConstantClass
    {

        /// <summary>
        /// Constant IAM for PrincipalType
        /// </summary>
        public static readonly PrincipalType IAM = new PrincipalType("IAM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PrincipalType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PrincipalType FindValue(string value)
        {
            return FindValue<PrincipalType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PrincipalType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProductSource.
    /// </summary>
    public class ProductSource : ConstantClass
    {

        /// <summary>
        /// Constant ACCOUNT for ProductSource
        /// </summary>
        public static readonly ProductSource ACCOUNT = new ProductSource("ACCOUNT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProductSource(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProductSource FindValue(string value)
        {
            return FindValue<ProductSource>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProductSource(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProductType.
    /// </summary>
    public class ProductType : ConstantClass
    {

        /// <summary>
        /// Constant CLOUD_FORMATION_TEMPLATE for ProductType
        /// </summary>
        public static readonly ProductType CLOUD_FORMATION_TEMPLATE = new ProductType("CLOUD_FORMATION_TEMPLATE");
        /// <summary>
        /// Constant MARKETPLACE for ProductType
        /// </summary>
        public static readonly ProductType MARKETPLACE = new ProductType("MARKETPLACE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProductType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProductType FindValue(string value)
        {
            return FindValue<ProductType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProductType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProductViewFilterBy.
    /// </summary>
    public class ProductViewFilterBy : ConstantClass
    {

        /// <summary>
        /// Constant FullTextSearch for ProductViewFilterBy
        /// </summary>
        public static readonly ProductViewFilterBy FullTextSearch = new ProductViewFilterBy("FullTextSearch");
        /// <summary>
        /// Constant Owner for ProductViewFilterBy
        /// </summary>
        public static readonly ProductViewFilterBy Owner = new ProductViewFilterBy("Owner");
        /// <summary>
        /// Constant ProductType for ProductViewFilterBy
        /// </summary>
        public static readonly ProductViewFilterBy ProductType = new ProductViewFilterBy("ProductType");
        /// <summary>
        /// Constant SourceProductId for ProductViewFilterBy
        /// </summary>
        public static readonly ProductViewFilterBy SourceProductId = new ProductViewFilterBy("SourceProductId");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProductViewFilterBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProductViewFilterBy FindValue(string value)
        {
            return FindValue<ProductViewFilterBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProductViewFilterBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProductViewSortBy.
    /// </summary>
    public class ProductViewSortBy : ConstantClass
    {

        /// <summary>
        /// Constant CreationDate for ProductViewSortBy
        /// </summary>
        public static readonly ProductViewSortBy CreationDate = new ProductViewSortBy("CreationDate");
        /// <summary>
        /// Constant Title for ProductViewSortBy
        /// </summary>
        public static readonly ProductViewSortBy Title = new ProductViewSortBy("Title");
        /// <summary>
        /// Constant VersionCount for ProductViewSortBy
        /// </summary>
        public static readonly ProductViewSortBy VersionCount = new ProductViewSortBy("VersionCount");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProductViewSortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProductViewSortBy FindValue(string value)
        {
            return FindValue<ProductViewSortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProductViewSortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProvisionedProductPlanStatus.
    /// </summary>
    public class ProvisionedProductPlanStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATE_FAILED for ProvisionedProductPlanStatus
        /// </summary>
        public static readonly ProvisionedProductPlanStatus CREATE_FAILED = new ProvisionedProductPlanStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATE_IN_PROGRESS for ProvisionedProductPlanStatus
        /// </summary>
        public static readonly ProvisionedProductPlanStatus CREATE_IN_PROGRESS = new ProvisionedProductPlanStatus("CREATE_IN_PROGRESS");
        /// <summary>
        /// Constant CREATE_SUCCESS for ProvisionedProductPlanStatus
        /// </summary>
        public static readonly ProvisionedProductPlanStatus CREATE_SUCCESS = new ProvisionedProductPlanStatus("CREATE_SUCCESS");
        /// <summary>
        /// Constant EXECUTE_FAILED for ProvisionedProductPlanStatus
        /// </summary>
        public static readonly ProvisionedProductPlanStatus EXECUTE_FAILED = new ProvisionedProductPlanStatus("EXECUTE_FAILED");
        /// <summary>
        /// Constant EXECUTE_IN_PROGRESS for ProvisionedProductPlanStatus
        /// </summary>
        public static readonly ProvisionedProductPlanStatus EXECUTE_IN_PROGRESS = new ProvisionedProductPlanStatus("EXECUTE_IN_PROGRESS");
        /// <summary>
        /// Constant EXECUTE_SUCCESS for ProvisionedProductPlanStatus
        /// </summary>
        public static readonly ProvisionedProductPlanStatus EXECUTE_SUCCESS = new ProvisionedProductPlanStatus("EXECUTE_SUCCESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProvisionedProductPlanStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProvisionedProductPlanStatus FindValue(string value)
        {
            return FindValue<ProvisionedProductPlanStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProvisionedProductPlanStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProvisionedProductPlanType.
    /// </summary>
    public class ProvisionedProductPlanType : ConstantClass
    {

        /// <summary>
        /// Constant CLOUDFORMATION for ProvisionedProductPlanType
        /// </summary>
        public static readonly ProvisionedProductPlanType CLOUDFORMATION = new ProvisionedProductPlanType("CLOUDFORMATION");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProvisionedProductPlanType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProvisionedProductPlanType FindValue(string value)
        {
            return FindValue<ProvisionedProductPlanType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProvisionedProductPlanType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProvisionedProductStatus.
    /// </summary>
    public class ProvisionedProductStatus : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for ProvisionedProductStatus
        /// </summary>
        public static readonly ProvisionedProductStatus AVAILABLE = new ProvisionedProductStatus("AVAILABLE");
        /// <summary>
        /// Constant ERROR for ProvisionedProductStatus
        /// </summary>
        public static readonly ProvisionedProductStatus ERROR = new ProvisionedProductStatus("ERROR");
        /// <summary>
        /// Constant PLAN_IN_PROGRESS for ProvisionedProductStatus
        /// </summary>
        public static readonly ProvisionedProductStatus PLAN_IN_PROGRESS = new ProvisionedProductStatus("PLAN_IN_PROGRESS");
        /// <summary>
        /// Constant TAINTED for ProvisionedProductStatus
        /// </summary>
        public static readonly ProvisionedProductStatus TAINTED = new ProvisionedProductStatus("TAINTED");
        /// <summary>
        /// Constant UNDER_CHANGE for ProvisionedProductStatus
        /// </summary>
        public static readonly ProvisionedProductStatus UNDER_CHANGE = new ProvisionedProductStatus("UNDER_CHANGE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProvisionedProductStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProvisionedProductStatus FindValue(string value)
        {
            return FindValue<ProvisionedProductStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProvisionedProductStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProvisionedProductViewFilterBy.
    /// </summary>
    public class ProvisionedProductViewFilterBy : ConstantClass
    {

        /// <summary>
        /// Constant SearchQuery for ProvisionedProductViewFilterBy
        /// </summary>
        public static readonly ProvisionedProductViewFilterBy SearchQuery = new ProvisionedProductViewFilterBy("SearchQuery");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProvisionedProductViewFilterBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProvisionedProductViewFilterBy FindValue(string value)
        {
            return FindValue<ProvisionedProductViewFilterBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProvisionedProductViewFilterBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProvisioningArtifactPropertyName.
    /// </summary>
    public class ProvisioningArtifactPropertyName : ConstantClass
    {

        /// <summary>
        /// Constant Id for ProvisioningArtifactPropertyName
        /// </summary>
        public static readonly ProvisioningArtifactPropertyName Id = new ProvisioningArtifactPropertyName("Id");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProvisioningArtifactPropertyName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProvisioningArtifactPropertyName FindValue(string value)
        {
            return FindValue<ProvisioningArtifactPropertyName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProvisioningArtifactPropertyName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProvisioningArtifactType.
    /// </summary>
    public class ProvisioningArtifactType : ConstantClass
    {

        /// <summary>
        /// Constant CLOUD_FORMATION_TEMPLATE for ProvisioningArtifactType
        /// </summary>
        public static readonly ProvisioningArtifactType CLOUD_FORMATION_TEMPLATE = new ProvisioningArtifactType("CLOUD_FORMATION_TEMPLATE");
        /// <summary>
        /// Constant MARKETPLACE_AMI for ProvisioningArtifactType
        /// </summary>
        public static readonly ProvisioningArtifactType MARKETPLACE_AMI = new ProvisioningArtifactType("MARKETPLACE_AMI");
        /// <summary>
        /// Constant MARKETPLACE_CAR for ProvisioningArtifactType
        /// </summary>
        public static readonly ProvisioningArtifactType MARKETPLACE_CAR = new ProvisioningArtifactType("MARKETPLACE_CAR");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProvisioningArtifactType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProvisioningArtifactType FindValue(string value)
        {
            return FindValue<ProvisioningArtifactType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProvisioningArtifactType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RecordStatus.
    /// </summary>
    public class RecordStatus : ConstantClass
    {

        /// <summary>
        /// Constant CREATED for RecordStatus
        /// </summary>
        public static readonly RecordStatus CREATED = new RecordStatus("CREATED");
        /// <summary>
        /// Constant FAILED for RecordStatus
        /// </summary>
        public static readonly RecordStatus FAILED = new RecordStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for RecordStatus
        /// </summary>
        public static readonly RecordStatus IN_PROGRESS = new RecordStatus("IN_PROGRESS");
        /// <summary>
        /// Constant IN_PROGRESS_IN_ERROR for RecordStatus
        /// </summary>
        public static readonly RecordStatus IN_PROGRESS_IN_ERROR = new RecordStatus("IN_PROGRESS_IN_ERROR");
        /// <summary>
        /// Constant SUCCEEDED for RecordStatus
        /// </summary>
        public static readonly RecordStatus SUCCEEDED = new RecordStatus("SUCCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecordStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecordStatus FindValue(string value)
        {
            return FindValue<RecordStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecordStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Replacement.
    /// </summary>
    public class Replacement : ConstantClass
    {

        /// <summary>
        /// Constant CONDITIONAL for Replacement
        /// </summary>
        public static readonly Replacement CONDITIONAL = new Replacement("CONDITIONAL");
        /// <summary>
        /// Constant FALSE for Replacement
        /// </summary>
        public static readonly Replacement FALSE = new Replacement("FALSE");
        /// <summary>
        /// Constant TRUE for Replacement
        /// </summary>
        public static readonly Replacement TRUE = new Replacement("TRUE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Replacement(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Replacement FindValue(string value)
        {
            return FindValue<Replacement>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Replacement(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RequiresRecreation.
    /// </summary>
    public class RequiresRecreation : ConstantClass
    {

        /// <summary>
        /// Constant ALWAYS for RequiresRecreation
        /// </summary>
        public static readonly RequiresRecreation ALWAYS = new RequiresRecreation("ALWAYS");
        /// <summary>
        /// Constant CONDITIONALLY for RequiresRecreation
        /// </summary>
        public static readonly RequiresRecreation CONDITIONALLY = new RequiresRecreation("CONDITIONALLY");
        /// <summary>
        /// Constant NEVER for RequiresRecreation
        /// </summary>
        public static readonly RequiresRecreation NEVER = new RequiresRecreation("NEVER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RequiresRecreation(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RequiresRecreation FindValue(string value)
        {
            return FindValue<RequiresRecreation>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RequiresRecreation(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceAttribute.
    /// </summary>
    public class ResourceAttribute : ConstantClass
    {

        /// <summary>
        /// Constant CREATIONPOLICY for ResourceAttribute
        /// </summary>
        public static readonly ResourceAttribute CREATIONPOLICY = new ResourceAttribute("CREATIONPOLICY");
        /// <summary>
        /// Constant DELETIONPOLICY for ResourceAttribute
        /// </summary>
        public static readonly ResourceAttribute DELETIONPOLICY = new ResourceAttribute("DELETIONPOLICY");
        /// <summary>
        /// Constant METADATA for ResourceAttribute
        /// </summary>
        public static readonly ResourceAttribute METADATA = new ResourceAttribute("METADATA");
        /// <summary>
        /// Constant PROPERTIES for ResourceAttribute
        /// </summary>
        public static readonly ResourceAttribute PROPERTIES = new ResourceAttribute("PROPERTIES");
        /// <summary>
        /// Constant TAGS for ResourceAttribute
        /// </summary>
        public static readonly ResourceAttribute TAGS = new ResourceAttribute("TAGS");
        /// <summary>
        /// Constant UPDATEPOLICY for ResourceAttribute
        /// </summary>
        public static readonly ResourceAttribute UPDATEPOLICY = new ResourceAttribute("UPDATEPOLICY");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceAttribute FindValue(string value)
        {
            return FindValue<ResourceAttribute>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortOrder.
    /// </summary>
    public class SortOrder : ConstantClass
    {

        /// <summary>
        /// Constant ASCENDING for SortOrder
        /// </summary>
        public static readonly SortOrder ASCENDING = new SortOrder("ASCENDING");
        /// <summary>
        /// Constant DESCENDING for SortOrder
        /// </summary>
        public static readonly SortOrder DESCENDING = new SortOrder("DESCENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SortOrder(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortOrder FindValue(string value)
        {
            return FindValue<SortOrder>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortOrder(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Status.
    /// </summary>
    public class Status : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABLE for Status
        /// </summary>
        public static readonly Status AVAILABLE = new Status("AVAILABLE");
        /// <summary>
        /// Constant CREATING for Status
        /// </summary>
        public static readonly Status CREATING = new Status("CREATING");
        /// <summary>
        /// Constant FAILED for Status
        /// </summary>
        public static readonly Status FAILED = new Status("FAILED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Status(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Status FindValue(string value)
        {
            return FindValue<Status>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Status(string value)
        {
            return FindValue(value);
        }
    }

}