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
 * Do not modify this file. This file is generated from the marketplace-discovery-2026-02-05.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.MarketplaceDiscovery
{

    /// <summary>
    /// Constants used for properties of type BillingPeriodType.
    /// </summary>
    public class BillingPeriodType : ConstantClass
    {

        /// <summary>
        /// Constant Monthly for BillingPeriodType
        /// </summary>
        public static readonly BillingPeriodType Monthly = new BillingPeriodType("Monthly");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BillingPeriodType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BillingPeriodType FindValue(string value)
        {
            return FindValue<BillingPeriodType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BillingPeriodType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeployedOnAwsStatus.
    /// </summary>
    public class DeployedOnAwsStatus : ConstantClass
    {

        /// <summary>
        /// Constant DEPLOYED for DeployedOnAwsStatus
        /// </summary>
        public static readonly DeployedOnAwsStatus DEPLOYED = new DeployedOnAwsStatus("DEPLOYED");
        /// <summary>
        /// Constant NOT_APPLICABLE for DeployedOnAwsStatus
        /// </summary>
        public static readonly DeployedOnAwsStatus NOT_APPLICABLE = new DeployedOnAwsStatus("NOT_APPLICABLE");
        /// <summary>
        /// Constant NOT_DEPLOYED for DeployedOnAwsStatus
        /// </summary>
        public static readonly DeployedOnAwsStatus NOT_DEPLOYED = new DeployedOnAwsStatus("NOT_DEPLOYED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeployedOnAwsStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeployedOnAwsStatus FindValue(string value)
        {
            return FindValue<DeployedOnAwsStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeployedOnAwsStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DimensionLabelType.
    /// </summary>
    public class DimensionLabelType : ConstantClass
    {

        /// <summary>
        /// Constant Region for DimensionLabelType
        /// </summary>
        public static readonly DimensionLabelType Region = new DimensionLabelType("Region");
        /// <summary>
        /// Constant SagemakerOption for DimensionLabelType
        /// </summary>
        public static readonly DimensionLabelType SagemakerOption = new DimensionLabelType("SagemakerOption");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DimensionLabelType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DimensionLabelType FindValue(string value)
        {
            return FindValue<DimensionLabelType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DimensionLabelType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FulfillmentOptionType.
    /// </summary>
    public class FulfillmentOptionType : ConstantClass
    {

        /// <summary>
        /// Constant AMAZON_MACHINE_IMAGE for FulfillmentOptionType
        /// </summary>
        public static readonly FulfillmentOptionType AMAZON_MACHINE_IMAGE = new FulfillmentOptionType("AMAZON_MACHINE_IMAGE");
        /// <summary>
        /// Constant API for FulfillmentOptionType
        /// </summary>
        public static readonly FulfillmentOptionType API = new FulfillmentOptionType("API");
        /// <summary>
        /// Constant CLOUDFORMATION_TEMPLATE for FulfillmentOptionType
        /// </summary>
        public static readonly FulfillmentOptionType CLOUDFORMATION_TEMPLATE = new FulfillmentOptionType("CLOUDFORMATION_TEMPLATE");
        /// <summary>
        /// Constant CONTAINER for FulfillmentOptionType
        /// </summary>
        public static readonly FulfillmentOptionType CONTAINER = new FulfillmentOptionType("CONTAINER");
        /// <summary>
        /// Constant DATA_EXCHANGE for FulfillmentOptionType
        /// </summary>
        public static readonly FulfillmentOptionType DATA_EXCHANGE = new FulfillmentOptionType("DATA_EXCHANGE");
        /// <summary>
        /// Constant EC2_IMAGE_BUILDER_COMPONENT for FulfillmentOptionType
        /// </summary>
        public static readonly FulfillmentOptionType EC2_IMAGE_BUILDER_COMPONENT = new FulfillmentOptionType("EC2_IMAGE_BUILDER_COMPONENT");
        /// <summary>
        /// Constant EKS_ADD_ON for FulfillmentOptionType
        /// </summary>
        public static readonly FulfillmentOptionType EKS_ADD_ON = new FulfillmentOptionType("EKS_ADD_ON");
        /// <summary>
        /// Constant HELM for FulfillmentOptionType
        /// </summary>
        public static readonly FulfillmentOptionType HELM = new FulfillmentOptionType("HELM");
        /// <summary>
        /// Constant PROFESSIONAL_SERVICES for FulfillmentOptionType
        /// </summary>
        public static readonly FulfillmentOptionType PROFESSIONAL_SERVICES = new FulfillmentOptionType("PROFESSIONAL_SERVICES");
        /// <summary>
        /// Constant SAAS for FulfillmentOptionType
        /// </summary>
        public static readonly FulfillmentOptionType SAAS = new FulfillmentOptionType("SAAS");
        /// <summary>
        /// Constant SAGEMAKER_ALGORITHM for FulfillmentOptionType
        /// </summary>
        public static readonly FulfillmentOptionType SAGEMAKER_ALGORITHM = new FulfillmentOptionType("SAGEMAKER_ALGORITHM");
        /// <summary>
        /// Constant SAGEMAKER_MODEL for FulfillmentOptionType
        /// </summary>
        public static readonly FulfillmentOptionType SAGEMAKER_MODEL = new FulfillmentOptionType("SAGEMAKER_MODEL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FulfillmentOptionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FulfillmentOptionType FindValue(string value)
        {
            return FindValue<FulfillmentOptionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FulfillmentOptionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LegalDocumentType.
    /// </summary>
    public class LegalDocumentType : ConstantClass
    {

        /// <summary>
        /// Constant CustomDsa for LegalDocumentType
        /// </summary>
        public static readonly LegalDocumentType CustomDsa = new LegalDocumentType("CustomDsa");
        /// <summary>
        /// Constant CustomEula for LegalDocumentType
        /// </summary>
        public static readonly LegalDocumentType CustomEula = new LegalDocumentType("CustomEula");
        /// <summary>
        /// Constant EnterpriseEula for LegalDocumentType
        /// </summary>
        public static readonly LegalDocumentType EnterpriseEula = new LegalDocumentType("EnterpriseEula");
        /// <summary>
        /// Constant StandardDsa for LegalDocumentType
        /// </summary>
        public static readonly LegalDocumentType StandardDsa = new LegalDocumentType("StandardDsa");
        /// <summary>
        /// Constant StandardEula for LegalDocumentType
        /// </summary>
        public static readonly LegalDocumentType StandardEula = new LegalDocumentType("StandardEula");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LegalDocumentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LegalDocumentType FindValue(string value)
        {
            return FindValue<LegalDocumentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LegalDocumentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ListingBadgeType.
    /// </summary>
    public class ListingBadgeType : ConstantClass
    {

        /// <summary>
        /// Constant AWS_FREE_TIER for ListingBadgeType
        /// </summary>
        public static readonly ListingBadgeType AWS_FREE_TIER = new ListingBadgeType("AWS_FREE_TIER");
        /// <summary>
        /// Constant DEPLOYED_ON_AWS for ListingBadgeType
        /// </summary>
        public static readonly ListingBadgeType DEPLOYED_ON_AWS = new ListingBadgeType("DEPLOYED_ON_AWS");
        /// <summary>
        /// Constant FREE_TRIAL for ListingBadgeType
        /// </summary>
        public static readonly ListingBadgeType FREE_TRIAL = new ListingBadgeType("FREE_TRIAL");
        /// <summary>
        /// Constant MULTI_PRODUCT for ListingBadgeType
        /// </summary>
        public static readonly ListingBadgeType MULTI_PRODUCT = new ListingBadgeType("MULTI_PRODUCT");
        /// <summary>
        /// Constant QUICK_LAUNCH for ListingBadgeType
        /// </summary>
        public static readonly ListingBadgeType QUICK_LAUNCH = new ListingBadgeType("QUICK_LAUNCH");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ListingBadgeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ListingBadgeType FindValue(string value)
        {
            return FindValue<ListingBadgeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ListingBadgeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PricingModelType.
    /// </summary>
    public class PricingModelType : ConstantClass
    {

        /// <summary>
        /// Constant BYOL for PricingModelType
        /// </summary>
        public static readonly PricingModelType BYOL = new PricingModelType("BYOL");
        /// <summary>
        /// Constant CONTRACT for PricingModelType
        /// </summary>
        public static readonly PricingModelType CONTRACT = new PricingModelType("CONTRACT");
        /// <summary>
        /// Constant FREE for PricingModelType
        /// </summary>
        public static readonly PricingModelType FREE = new PricingModelType("FREE");
        /// <summary>
        /// Constant USAGE for PricingModelType
        /// </summary>
        public static readonly PricingModelType USAGE = new PricingModelType("USAGE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PricingModelType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PricingModelType FindValue(string value)
        {
            return FindValue<PricingModelType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PricingModelType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PricingUnitType.
    /// </summary>
    public class PricingUnitType : ConstantClass
    {

        /// <summary>
        /// Constant BANDWIDTH for PricingUnitType
        /// </summary>
        public static readonly PricingUnitType BANDWIDTH = new PricingUnitType("BANDWIDTH");
        /// <summary>
        /// Constant DATA for PricingUnitType
        /// </summary>
        public static readonly PricingUnitType DATA = new PricingUnitType("DATA");
        /// <summary>
        /// Constant HOSTS for PricingUnitType
        /// </summary>
        public static readonly PricingUnitType HOSTS = new PricingUnitType("HOSTS");
        /// <summary>
        /// Constant REQUESTS for PricingUnitType
        /// </summary>
        public static readonly PricingUnitType REQUESTS = new PricingUnitType("REQUESTS");
        /// <summary>
        /// Constant TIERS for PricingUnitType
        /// </summary>
        public static readonly PricingUnitType TIERS = new PricingUnitType("TIERS");
        /// <summary>
        /// Constant UNITS for PricingUnitType
        /// </summary>
        public static readonly PricingUnitType UNITS = new PricingUnitType("UNITS");
        /// <summary>
        /// Constant USERS for PricingUnitType
        /// </summary>
        public static readonly PricingUnitType USERS = new PricingUnitType("USERS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PricingUnitType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PricingUnitType FindValue(string value)
        {
            return FindValue<PricingUnitType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PricingUnitType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PurchaseOptionBadgeType.
    /// </summary>
    public class PurchaseOptionBadgeType : ConstantClass
    {

        /// <summary>
        /// Constant FUTURE_DATED for PurchaseOptionBadgeType
        /// </summary>
        public static readonly PurchaseOptionBadgeType FUTURE_DATED = new PurchaseOptionBadgeType("FUTURE_DATED");
        /// <summary>
        /// Constant PRIVATE_PRICING for PurchaseOptionBadgeType
        /// </summary>
        public static readonly PurchaseOptionBadgeType PRIVATE_PRICING = new PurchaseOptionBadgeType("PRIVATE_PRICING");
        /// <summary>
        /// Constant REPLACEMENT_OFFER for PurchaseOptionBadgeType
        /// </summary>
        public static readonly PurchaseOptionBadgeType REPLACEMENT_OFFER = new PurchaseOptionBadgeType("REPLACEMENT_OFFER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PurchaseOptionBadgeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PurchaseOptionBadgeType FindValue(string value)
        {
            return FindValue<PurchaseOptionBadgeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PurchaseOptionBadgeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PurchaseOptionFilterType.
    /// </summary>
    public class PurchaseOptionFilterType : ConstantClass
    {

        /// <summary>
        /// Constant AVAILABILITY_STATUS for PurchaseOptionFilterType
        /// </summary>
        public static readonly PurchaseOptionFilterType AVAILABILITY_STATUS = new PurchaseOptionFilterType("AVAILABILITY_STATUS");
        /// <summary>
        /// Constant PRODUCT_ID for PurchaseOptionFilterType
        /// </summary>
        public static readonly PurchaseOptionFilterType PRODUCT_ID = new PurchaseOptionFilterType("PRODUCT_ID");
        /// <summary>
        /// Constant PURCHASE_OPTION_TYPE for PurchaseOptionFilterType
        /// </summary>
        public static readonly PurchaseOptionFilterType PURCHASE_OPTION_TYPE = new PurchaseOptionFilterType("PURCHASE_OPTION_TYPE");
        /// <summary>
        /// Constant SELLER_OF_RECORD_PROFILE_ID for PurchaseOptionFilterType
        /// </summary>
        public static readonly PurchaseOptionFilterType SELLER_OF_RECORD_PROFILE_ID = new PurchaseOptionFilterType("SELLER_OF_RECORD_PROFILE_ID");
        /// <summary>
        /// Constant VISIBILITY_SCOPE for PurchaseOptionFilterType
        /// </summary>
        public static readonly PurchaseOptionFilterType VISIBILITY_SCOPE = new PurchaseOptionFilterType("VISIBILITY_SCOPE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PurchaseOptionFilterType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PurchaseOptionFilterType FindValue(string value)
        {
            return FindValue<PurchaseOptionFilterType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PurchaseOptionFilterType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PurchaseOptionType.
    /// </summary>
    public class PurchaseOptionType : ConstantClass
    {

        /// <summary>
        /// Constant OFFER for PurchaseOptionType
        /// </summary>
        public static readonly PurchaseOptionType OFFER = new PurchaseOptionType("OFFER");
        /// <summary>
        /// Constant OFFERSET for PurchaseOptionType
        /// </summary>
        public static readonly PurchaseOptionType OFFERSET = new PurchaseOptionType("OFFERSET");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PurchaseOptionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PurchaseOptionType FindValue(string value)
        {
            return FindValue<PurchaseOptionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PurchaseOptionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RateCardConstraintType.
    /// </summary>
    public class RateCardConstraintType : ConstantClass
    {

        /// <summary>
        /// Constant Allowed for RateCardConstraintType
        /// </summary>
        public static readonly RateCardConstraintType Allowed = new RateCardConstraintType("Allowed");
        /// <summary>
        /// Constant Disallowed for RateCardConstraintType
        /// </summary>
        public static readonly RateCardConstraintType Disallowed = new RateCardConstraintType("Disallowed");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RateCardConstraintType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RateCardConstraintType FindValue(string value)
        {
            return FindValue<RateCardConstraintType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RateCardConstraintType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceContentType.
    /// </summary>
    public class ResourceContentType : ConstantClass
    {

        /// <summary>
        /// Constant EMAIL for ResourceContentType
        /// </summary>
        public static readonly ResourceContentType EMAIL = new ResourceContentType("EMAIL");
        /// <summary>
        /// Constant LINK for ResourceContentType
        /// </summary>
        public static readonly ResourceContentType LINK = new ResourceContentType("LINK");
        /// <summary>
        /// Constant OTHER for ResourceContentType
        /// </summary>
        public static readonly ResourceContentType OTHER = new ResourceContentType("OTHER");
        /// <summary>
        /// Constant PHONE_NUMBER for ResourceContentType
        /// </summary>
        public static readonly ResourceContentType PHONE_NUMBER = new ResourceContentType("PHONE_NUMBER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceContentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceContentType FindValue(string value)
        {
            return FindValue<ResourceContentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceContentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceType.
    /// </summary>
    public class ResourceType : ConstantClass
    {

        /// <summary>
        /// Constant MANUFACTURER_INSTRUCTIONS for ResourceType
        /// </summary>
        public static readonly ResourceType MANUFACTURER_INSTRUCTIONS = new ResourceType("MANUFACTURER_INSTRUCTIONS");
        /// <summary>
        /// Constant MANUFACTURER_SUPPORT for ResourceType
        /// </summary>
        public static readonly ResourceType MANUFACTURER_SUPPORT = new ResourceType("MANUFACTURER_SUPPORT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceType FindValue(string value)
        {
            return FindValue<ResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReviewSourceId.
    /// </summary>
    public class ReviewSourceId : ConstantClass
    {

        /// <summary>
        /// Constant AWS_MARKETPLACE for ReviewSourceId
        /// </summary>
        public static readonly ReviewSourceId AWS_MARKETPLACE = new ReviewSourceId("AWS_MARKETPLACE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReviewSourceId(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReviewSourceId FindValue(string value)
        {
            return FindValue<ReviewSourceId>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReviewSourceId(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SearchFacetType.
    /// </summary>
    public class SearchFacetType : ConstantClass
    {

        /// <summary>
        /// Constant AVERAGE_CUSTOMER_RATING for SearchFacetType
        /// </summary>
        public static readonly SearchFacetType AVERAGE_CUSTOMER_RATING = new SearchFacetType("AVERAGE_CUSTOMER_RATING");
        /// <summary>
        /// Constant CATEGORY for SearchFacetType
        /// </summary>
        public static readonly SearchFacetType CATEGORY = new SearchFacetType("CATEGORY");
        /// <summary>
        /// Constant DEPLOYED_ON_AWS for SearchFacetType
        /// </summary>
        public static readonly SearchFacetType DEPLOYED_ON_AWS = new SearchFacetType("DEPLOYED_ON_AWS");
        /// <summary>
        /// Constant FULFILLMENT_OPTION_TYPE for SearchFacetType
        /// </summary>
        public static readonly SearchFacetType FULFILLMENT_OPTION_TYPE = new SearchFacetType("FULFILLMENT_OPTION_TYPE");
        /// <summary>
        /// Constant NUMBER_OF_PRODUCTS for SearchFacetType
        /// </summary>
        public static readonly SearchFacetType NUMBER_OF_PRODUCTS = new SearchFacetType("NUMBER_OF_PRODUCTS");
        /// <summary>
        /// Constant PRICING_MODEL for SearchFacetType
        /// </summary>
        public static readonly SearchFacetType PRICING_MODEL = new SearchFacetType("PRICING_MODEL");
        /// <summary>
        /// Constant PRICING_UNIT for SearchFacetType
        /// </summary>
        public static readonly SearchFacetType PRICING_UNIT = new SearchFacetType("PRICING_UNIT");
        /// <summary>
        /// Constant PUBLISHER for SearchFacetType
        /// </summary>
        public static readonly SearchFacetType PUBLISHER = new SearchFacetType("PUBLISHER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SearchFacetType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SearchFacetType FindValue(string value)
        {
            return FindValue<SearchFacetType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SearchFacetType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SearchFilterType.
    /// </summary>
    public class SearchFilterType : ConstantClass
    {

        /// <summary>
        /// Constant CATEGORY for SearchFilterType
        /// </summary>
        public static readonly SearchFilterType CATEGORY = new SearchFilterType("CATEGORY");
        /// <summary>
        /// Constant DEPLOYED_ON_AWS for SearchFilterType
        /// </summary>
        public static readonly SearchFilterType DEPLOYED_ON_AWS = new SearchFilterType("DEPLOYED_ON_AWS");
        /// <summary>
        /// Constant FULFILLMENT_OPTION_TYPE for SearchFilterType
        /// </summary>
        public static readonly SearchFilterType FULFILLMENT_OPTION_TYPE = new SearchFilterType("FULFILLMENT_OPTION_TYPE");
        /// <summary>
        /// Constant MAX_AVERAGE_CUSTOMER_RATING for SearchFilterType
        /// </summary>
        public static readonly SearchFilterType MAX_AVERAGE_CUSTOMER_RATING = new SearchFilterType("MAX_AVERAGE_CUSTOMER_RATING");
        /// <summary>
        /// Constant MIN_AVERAGE_CUSTOMER_RATING for SearchFilterType
        /// </summary>
        public static readonly SearchFilterType MIN_AVERAGE_CUSTOMER_RATING = new SearchFilterType("MIN_AVERAGE_CUSTOMER_RATING");
        /// <summary>
        /// Constant NUMBER_OF_PRODUCTS for SearchFilterType
        /// </summary>
        public static readonly SearchFilterType NUMBER_OF_PRODUCTS = new SearchFilterType("NUMBER_OF_PRODUCTS");
        /// <summary>
        /// Constant PRICING_MODEL for SearchFilterType
        /// </summary>
        public static readonly SearchFilterType PRICING_MODEL = new SearchFilterType("PRICING_MODEL");
        /// <summary>
        /// Constant PRICING_UNIT for SearchFilterType
        /// </summary>
        public static readonly SearchFilterType PRICING_UNIT = new SearchFilterType("PRICING_UNIT");
        /// <summary>
        /// Constant PUBLISHER for SearchFilterType
        /// </summary>
        public static readonly SearchFilterType PUBLISHER = new SearchFilterType("PUBLISHER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SearchFilterType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SearchFilterType FindValue(string value)
        {
            return FindValue<SearchFilterType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SearchFilterType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SearchListingsSortBy.
    /// </summary>
    public class SearchListingsSortBy : ConstantClass
    {

        /// <summary>
        /// Constant AVERAGE_CUSTOMER_RATING for SearchListingsSortBy
        /// </summary>
        public static readonly SearchListingsSortBy AVERAGE_CUSTOMER_RATING = new SearchListingsSortBy("AVERAGE_CUSTOMER_RATING");
        /// <summary>
        /// Constant RELEVANCE for SearchListingsSortBy
        /// </summary>
        public static readonly SearchListingsSortBy RELEVANCE = new SearchListingsSortBy("RELEVANCE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SearchListingsSortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SearchListingsSortBy FindValue(string value)
        {
            return FindValue<SearchListingsSortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SearchListingsSortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SearchListingsSortOrder.
    /// </summary>
    public class SearchListingsSortOrder : ConstantClass
    {

        /// <summary>
        /// Constant ASCENDING for SearchListingsSortOrder
        /// </summary>
        public static readonly SearchListingsSortOrder ASCENDING = new SearchListingsSortOrder("ASCENDING");
        /// <summary>
        /// Constant DESCENDING for SearchListingsSortOrder
        /// </summary>
        public static readonly SearchListingsSortOrder DESCENDING = new SearchListingsSortOrder("DESCENDING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SearchListingsSortOrder(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SearchListingsSortOrder FindValue(string value)
        {
            return FindValue<SearchListingsSortOrder>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SearchListingsSortOrder(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SelectorType.
    /// </summary>
    public class SelectorType : ConstantClass
    {

        /// <summary>
        /// Constant Duration for SelectorType
        /// </summary>
        public static readonly SelectorType Duration = new SelectorType("Duration");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SelectorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SelectorType FindValue(string value)
        {
            return FindValue<SelectorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SelectorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SellerEngagementContentType.
    /// </summary>
    public class SellerEngagementContentType : ConstantClass
    {

        /// <summary>
        /// Constant LINK for SellerEngagementContentType
        /// </summary>
        public static readonly SellerEngagementContentType LINK = new SellerEngagementContentType("LINK");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SellerEngagementContentType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SellerEngagementContentType FindValue(string value)
        {
            return FindValue<SellerEngagementContentType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SellerEngagementContentType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SellerEngagementType.
    /// </summary>
    public class SellerEngagementType : ConstantClass
    {

        /// <summary>
        /// Constant REQUEST_FOR_DEMO for SellerEngagementType
        /// </summary>
        public static readonly SellerEngagementType REQUEST_FOR_DEMO = new SellerEngagementType("REQUEST_FOR_DEMO");
        /// <summary>
        /// Constant REQUEST_FOR_PRIVATE_OFFER for SellerEngagementType
        /// </summary>
        public static readonly SellerEngagementType REQUEST_FOR_PRIVATE_OFFER = new SellerEngagementType("REQUEST_FOR_PRIVATE_OFFER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SellerEngagementType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SellerEngagementType FindValue(string value)
        {
            return FindValue<SellerEngagementType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SellerEngagementType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TermType.
    /// </summary>
    public class TermType : ConstantClass
    {

        /// <summary>
        /// Constant ByolPricingTerm for TermType
        /// </summary>
        public static readonly TermType ByolPricingTerm = new TermType("ByolPricingTerm");
        /// <summary>
        /// Constant ConfigurableUpfrontPricingTerm for TermType
        /// </summary>
        public static readonly TermType ConfigurableUpfrontPricingTerm = new TermType("ConfigurableUpfrontPricingTerm");
        /// <summary>
        /// Constant FixedUpfrontPricingTerm for TermType
        /// </summary>
        public static readonly TermType FixedUpfrontPricingTerm = new TermType("FixedUpfrontPricingTerm");
        /// <summary>
        /// Constant FreeTrialPricingTerm for TermType
        /// </summary>
        public static readonly TermType FreeTrialPricingTerm = new TermType("FreeTrialPricingTerm");
        /// <summary>
        /// Constant LegalTerm for TermType
        /// </summary>
        public static readonly TermType LegalTerm = new TermType("LegalTerm");
        /// <summary>
        /// Constant PaymentScheduleTerm for TermType
        /// </summary>
        public static readonly TermType PaymentScheduleTerm = new TermType("PaymentScheduleTerm");
        /// <summary>
        /// Constant RecurringPaymentTerm for TermType
        /// </summary>
        public static readonly TermType RecurringPaymentTerm = new TermType("RecurringPaymentTerm");
        /// <summary>
        /// Constant RenewalTerm for TermType
        /// </summary>
        public static readonly TermType RenewalTerm = new TermType("RenewalTerm");
        /// <summary>
        /// Constant SupportTerm for TermType
        /// </summary>
        public static readonly TermType SupportTerm = new TermType("SupportTerm");
        /// <summary>
        /// Constant UsageBasedPricingTerm for TermType
        /// </summary>
        public static readonly TermType UsageBasedPricingTerm = new TermType("UsageBasedPricingTerm");
        /// <summary>
        /// Constant ValidityTerm for TermType
        /// </summary>
        public static readonly TermType ValidityTerm = new TermType("ValidityTerm");
        /// <summary>
        /// Constant VariablePaymentTerm for TermType
        /// </summary>
        public static readonly TermType VariablePaymentTerm = new TermType("VariablePaymentTerm");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TermType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TermType FindValue(string value)
        {
            return FindValue<TermType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TermType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ValidationExceptionReason.
    /// </summary>
    public class ValidationExceptionReason : ConstantClass
    {

        /// <summary>
        /// Constant INVALID_PAGINATION_TOKEN for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason INVALID_PAGINATION_TOKEN = new ValidationExceptionReason("INVALID_PAGINATION_TOKEN");
        /// <summary>
        /// Constant MALFORMED_REQUEST_PARAMETERS for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason MALFORMED_REQUEST_PARAMETERS = new ValidationExceptionReason("MALFORMED_REQUEST_PARAMETERS");
        /// <summary>
        /// Constant PAGINATION_LIMIT_EXCEEDED for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason PAGINATION_LIMIT_EXCEEDED = new ValidationExceptionReason("PAGINATION_LIMIT_EXCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ValidationExceptionReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ValidationExceptionReason FindValue(string value)
        {
            return FindValue<ValidationExceptionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ValidationExceptionReason(string value)
        {
            return FindValue(value);
        }
    }

}