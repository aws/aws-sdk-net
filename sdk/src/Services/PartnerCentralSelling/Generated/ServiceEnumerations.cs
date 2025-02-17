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
 * Do not modify this file. This file is generated from the partnercentral-selling-2022-07-26.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.PartnerCentralSelling
{

    /// <summary>
    /// Constants used for properties of type AwsClosedLostReason.
    /// </summary>
    public class AwsClosedLostReason : ConstantClass
    {

        /// <summary>
        /// Constant Administrative for AwsClosedLostReason
        /// </summary>
        public static readonly AwsClosedLostReason Administrative = new AwsClosedLostReason("Administrative");
        /// <summary>
        /// Constant BusinessAssociateAgreement for AwsClosedLostReason
        /// </summary>
        public static readonly AwsClosedLostReason BusinessAssociateAgreement = new AwsClosedLostReason("Business Associate Agreement");
        /// <summary>
        /// Constant CompanyAcquiredDissolved for AwsClosedLostReason
        /// </summary>
        public static readonly AwsClosedLostReason CompanyAcquiredDissolved = new AwsClosedLostReason("Company Acquired/Dissolved");
        /// <summary>
        /// Constant CompetitiveOffering for AwsClosedLostReason
        /// </summary>
        public static readonly AwsClosedLostReason CompetitiveOffering = new AwsClosedLostReason("Competitive Offering");
        /// <summary>
        /// Constant CustomerDataRequirement for AwsClosedLostReason
        /// </summary>
        public static readonly AwsClosedLostReason CustomerDataRequirement = new AwsClosedLostReason("Customer Data Requirement");
        /// <summary>
        /// Constant CustomerDeficiency for AwsClosedLostReason
        /// </summary>
        public static readonly AwsClosedLostReason CustomerDeficiency = new AwsClosedLostReason("Customer Deficiency");
        /// <summary>
        /// Constant CustomerExperience for AwsClosedLostReason
        /// </summary>
        public static readonly AwsClosedLostReason CustomerExperience = new AwsClosedLostReason("Customer Experience");
        /// <summary>
        /// Constant DelayCancellationOfProject for AwsClosedLostReason
        /// </summary>
        public static readonly AwsClosedLostReason DelayCancellationOfProject = new AwsClosedLostReason("Delay / Cancellation of Project");
        /// <summary>
        /// Constant Duplicate for AwsClosedLostReason
        /// </summary>
        public static readonly AwsClosedLostReason Duplicate = new AwsClosedLostReason("Duplicate");
        /// <summary>
        /// Constant DuplicateOpportunity for AwsClosedLostReason
        /// </summary>
        public static readonly AwsClosedLostReason DuplicateOpportunity = new AwsClosedLostReason("Duplicate Opportunity");
        /// <summary>
        /// Constant ExecutiveBlocker for AwsClosedLostReason
        /// </summary>
        public static readonly AwsClosedLostReason ExecutiveBlocker = new AwsClosedLostReason("Executive Blocker");
        /// <summary>
        /// Constant FailedVetting for AwsClosedLostReason
        /// </summary>
        public static readonly AwsClosedLostReason FailedVetting = new AwsClosedLostReason("Failed Vetting");
        /// <summary>
        /// Constant FeatureLimitation for AwsClosedLostReason
        /// </summary>
        public static readonly AwsClosedLostReason FeatureLimitation = new AwsClosedLostReason("Feature Limitation");
        /// <summary>
        /// Constant FinancialCommercial for AwsClosedLostReason
        /// </summary>
        public static readonly AwsClosedLostReason FinancialCommercial = new AwsClosedLostReason("Financial/Commercial");
        /// <summary>
        /// Constant InsufficientAmazonValue for AwsClosedLostReason
        /// </summary>
        public static readonly AwsClosedLostReason InsufficientAmazonValue = new AwsClosedLostReason("Insufficient Amazon Value");
        /// <summary>
        /// Constant InsufficientAWSValue for AwsClosedLostReason
        /// </summary>
        public static readonly AwsClosedLostReason InsufficientAWSValue = new AwsClosedLostReason("Insufficient AWS Value");
        /// <summary>
        /// Constant InternationalConstraints for AwsClosedLostReason
        /// </summary>
        public static readonly AwsClosedLostReason InternationalConstraints = new AwsClosedLostReason("International Constraints");
        /// <summary>
        /// Constant LegalTaxRegulatory for AwsClosedLostReason
        /// </summary>
        public static readonly AwsClosedLostReason LegalTaxRegulatory = new AwsClosedLostReason("Legal / Tax / Regulatory");
        /// <summary>
        /// Constant LegalTermsAndConditions for AwsClosedLostReason
        /// </summary>
        public static readonly AwsClosedLostReason LegalTermsAndConditions = new AwsClosedLostReason("Legal Terms and Conditions");
        /// <summary>
        /// Constant LostToCompetitor for AwsClosedLostReason
        /// </summary>
        public static readonly AwsClosedLostReason LostToCompetitor = new AwsClosedLostReason("Lost to Competitor");
        /// <summary>
        /// Constant LostToCompetitorGoogle for AwsClosedLostReason
        /// </summary>
        public static readonly AwsClosedLostReason LostToCompetitorGoogle = new AwsClosedLostReason("Lost to Competitor - Google");
        /// <summary>
        /// Constant LostToCompetitorMicrosoft for AwsClosedLostReason
        /// </summary>
        public static readonly AwsClosedLostReason LostToCompetitorMicrosoft = new AwsClosedLostReason("Lost to Competitor - Microsoft");
        /// <summary>
        /// Constant LostToCompetitorOther for AwsClosedLostReason
        /// </summary>
        public static readonly AwsClosedLostReason LostToCompetitorOther = new AwsClosedLostReason("Lost to Competitor - Other");
        /// <summary>
        /// Constant LostToCompetitorRackspace for AwsClosedLostReason
        /// </summary>
        public static readonly AwsClosedLostReason LostToCompetitorRackspace = new AwsClosedLostReason("Lost to Competitor - Rackspace");
        /// <summary>
        /// Constant LostToCompetitorSoftLayer for AwsClosedLostReason
        /// </summary>
        public static readonly AwsClosedLostReason LostToCompetitorSoftLayer = new AwsClosedLostReason("Lost to Competitor - SoftLayer");
        /// <summary>
        /// Constant LostToCompetitorVMWare for AwsClosedLostReason
        /// </summary>
        public static readonly AwsClosedLostReason LostToCompetitorVMWare = new AwsClosedLostReason("Lost to Competitor - VMWare");
        /// <summary>
        /// Constant NoCustomerReference for AwsClosedLostReason
        /// </summary>
        public static readonly AwsClosedLostReason NoCustomerReference = new AwsClosedLostReason("No Customer Reference");
        /// <summary>
        /// Constant NoIntegrationResources for AwsClosedLostReason
        /// </summary>
        public static readonly AwsClosedLostReason NoIntegrationResources = new AwsClosedLostReason("No Integration Resources");
        /// <summary>
        /// Constant NoOpportunity for AwsClosedLostReason
        /// </summary>
        public static readonly AwsClosedLostReason NoOpportunity = new AwsClosedLostReason("No Opportunity");
        /// <summary>
        /// Constant NoPerceivedValueOfMP for AwsClosedLostReason
        /// </summary>
        public static readonly AwsClosedLostReason NoPerceivedValueOfMP = new AwsClosedLostReason("No Perceived Value of MP");
        /// <summary>
        /// Constant NoResponse for AwsClosedLostReason
        /// </summary>
        public static readonly AwsClosedLostReason NoResponse = new AwsClosedLostReason("No Response");
        /// <summary>
        /// Constant NotCommittedToAWS for AwsClosedLostReason
        /// </summary>
        public static readonly AwsClosedLostReason NotCommittedToAWS = new AwsClosedLostReason("Not Committed to AWS");
        /// <summary>
        /// Constant NoUpdate for AwsClosedLostReason
        /// </summary>
        public static readonly AwsClosedLostReason NoUpdate = new AwsClosedLostReason("No Update");
        /// <summary>
        /// Constant OnPremisesDeployment for AwsClosedLostReason
        /// </summary>
        public static readonly AwsClosedLostReason OnPremisesDeployment = new AwsClosedLostReason("On Premises Deployment");
        /// <summary>
        /// Constant Other for AwsClosedLostReason
        /// </summary>
        public static readonly AwsClosedLostReason Other = new AwsClosedLostReason("Other");
        /// <summary>
        /// Constant OtherDetailsInDescription for AwsClosedLostReason
        /// </summary>
        public static readonly AwsClosedLostReason OtherDetailsInDescription = new AwsClosedLostReason("Other (Details in Description)");
        /// <summary>
        /// Constant PartnerGap for AwsClosedLostReason
        /// </summary>
        public static readonly AwsClosedLostReason PartnerGap = new AwsClosedLostReason("Partner Gap");
        /// <summary>
        /// Constant PastDue for AwsClosedLostReason
        /// </summary>
        public static readonly AwsClosedLostReason PastDue = new AwsClosedLostReason("Past Due");
        /// <summary>
        /// Constant PeopleRelationshipGovernance for AwsClosedLostReason
        /// </summary>
        public static readonly AwsClosedLostReason PeopleRelationshipGovernance = new AwsClosedLostReason("People/Relationship/Governance");
        /// <summary>
        /// Constant PlatformTechnologyLimitation for AwsClosedLostReason
        /// </summary>
        public static readonly AwsClosedLostReason PlatformTechnologyLimitation = new AwsClosedLostReason("Platform Technology Limitation");
        /// <summary>
        /// Constant PreferenceForCompetitor for AwsClosedLostReason
        /// </summary>
        public static readonly AwsClosedLostReason PreferenceForCompetitor = new AwsClosedLostReason("Preference for Competitor");
        /// <summary>
        /// Constant Price for AwsClosedLostReason
        /// </summary>
        public static readonly AwsClosedLostReason Price = new AwsClosedLostReason("Price");
        /// <summary>
        /// Constant ProductNotOnAWS for AwsClosedLostReason
        /// </summary>
        public static readonly AwsClosedLostReason ProductNotOnAWS = new AwsClosedLostReason("Product Not on AWS");
        /// <summary>
        /// Constant ProductTechnology for AwsClosedLostReason
        /// </summary>
        public static readonly AwsClosedLostReason ProductTechnology = new AwsClosedLostReason("Product/Technology");
        /// <summary>
        /// Constant SecurityCompliance for AwsClosedLostReason
        /// </summary>
        public static readonly AwsClosedLostReason SecurityCompliance = new AwsClosedLostReason("Security / Compliance");
        /// <summary>
        /// Constant SelfService for AwsClosedLostReason
        /// </summary>
        public static readonly AwsClosedLostReason SelfService = new AwsClosedLostReason("Self-Service");
        /// <summary>
        /// Constant TechnicalLimitations for AwsClosedLostReason
        /// </summary>
        public static readonly AwsClosedLostReason TechnicalLimitations = new AwsClosedLostReason("Technical Limitations");
        /// <summary>
        /// Constant TermSheetImpasse for AwsClosedLostReason
        /// </summary>
        public static readonly AwsClosedLostReason TermSheetImpasse = new AwsClosedLostReason("Term Sheet Impasse");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AwsClosedLostReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AwsClosedLostReason FindValue(string value)
        {
            return FindValue<AwsClosedLostReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AwsClosedLostReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AwsFundingUsed.
    /// </summary>
    public class AwsFundingUsed : ConstantClass
    {

        /// <summary>
        /// Constant No for AwsFundingUsed
        /// </summary>
        public static readonly AwsFundingUsed No = new AwsFundingUsed("No");
        /// <summary>
        /// Constant Yes for AwsFundingUsed
        /// </summary>
        public static readonly AwsFundingUsed Yes = new AwsFundingUsed("Yes");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AwsFundingUsed(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AwsFundingUsed FindValue(string value)
        {
            return FindValue<AwsFundingUsed>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AwsFundingUsed(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AwsMemberBusinessTitle.
    /// </summary>
    public class AwsMemberBusinessTitle : ConstantClass
    {

        /// <summary>
        /// Constant AWSAccountOwner for AwsMemberBusinessTitle
        /// </summary>
        public static readonly AwsMemberBusinessTitle AWSAccountOwner = new AwsMemberBusinessTitle("AWSAccountOwner");
        /// <summary>
        /// Constant AWSSalesRep for AwsMemberBusinessTitle
        /// </summary>
        public static readonly AwsMemberBusinessTitle AWSSalesRep = new AwsMemberBusinessTitle("AWSSalesRep");
        /// <summary>
        /// Constant ISVSM for AwsMemberBusinessTitle
        /// </summary>
        public static readonly AwsMemberBusinessTitle ISVSM = new AwsMemberBusinessTitle("ISVSM");
        /// <summary>
        /// Constant PDM for AwsMemberBusinessTitle
        /// </summary>
        public static readonly AwsMemberBusinessTitle PDM = new AwsMemberBusinessTitle("PDM");
        /// <summary>
        /// Constant PSM for AwsMemberBusinessTitle
        /// </summary>
        public static readonly AwsMemberBusinessTitle PSM = new AwsMemberBusinessTitle("PSM");
        /// <summary>
        /// Constant WWPSPDM for AwsMemberBusinessTitle
        /// </summary>
        public static readonly AwsMemberBusinessTitle WWPSPDM = new AwsMemberBusinessTitle("WWPSPDM");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AwsMemberBusinessTitle(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AwsMemberBusinessTitle FindValue(string value)
        {
            return FindValue<AwsMemberBusinessTitle>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AwsMemberBusinessTitle(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AwsOpportunityStage.
    /// </summary>
    public class AwsOpportunityStage : ConstantClass
    {

        /// <summary>
        /// Constant BuildingIntegration for AwsOpportunityStage
        /// </summary>
        public static readonly AwsOpportunityStage BuildingIntegration = new AwsOpportunityStage("Building Integration");
        /// <summary>
        /// Constant BusinessValidation for AwsOpportunityStage
        /// </summary>
        public static readonly AwsOpportunityStage BusinessValidation = new AwsOpportunityStage("Business Validation");
        /// <summary>
        /// Constant ClosedIncomplete for AwsOpportunityStage
        /// </summary>
        public static readonly AwsOpportunityStage ClosedIncomplete = new AwsOpportunityStage("Closed Incomplete");
        /// <summary>
        /// Constant ClosedLost for AwsOpportunityStage
        /// </summary>
        public static readonly AwsOpportunityStage ClosedLost = new AwsOpportunityStage("Closed Lost");
        /// <summary>
        /// Constant Committed for AwsOpportunityStage
        /// </summary>
        public static readonly AwsOpportunityStage Committed = new AwsOpportunityStage("Committed");
        /// <summary>
        /// Constant Completed for AwsOpportunityStage
        /// </summary>
        public static readonly AwsOpportunityStage Completed = new AwsOpportunityStage("Completed");
        /// <summary>
        /// Constant ContractNegotiation for AwsOpportunityStage
        /// </summary>
        public static readonly AwsOpportunityStage ContractNegotiation = new AwsOpportunityStage("Contract Negotiation");
        /// <summary>
        /// Constant DeferredToPartner for AwsOpportunityStage
        /// </summary>
        public static readonly AwsOpportunityStage DeferredToPartner = new AwsOpportunityStage("Deferred to Partner");
        /// <summary>
        /// Constant Engaged for AwsOpportunityStage
        /// </summary>
        public static readonly AwsOpportunityStage Engaged = new AwsOpportunityStage("Engaged");
        /// <summary>
        /// Constant Evaluating for AwsOpportunityStage
        /// </summary>
        public static readonly AwsOpportunityStage Evaluating = new AwsOpportunityStage("Evaluating");
        /// <summary>
        /// Constant Identified for AwsOpportunityStage
        /// </summary>
        public static readonly AwsOpportunityStage Identified = new AwsOpportunityStage("Identified");
        /// <summary>
        /// Constant InProgress for AwsOpportunityStage
        /// </summary>
        public static readonly AwsOpportunityStage InProgress = new AwsOpportunityStage("In Progress");
        /// <summary>
        /// Constant Launched for AwsOpportunityStage
        /// </summary>
        public static readonly AwsOpportunityStage Launched = new AwsOpportunityStage("Launched");
        /// <summary>
        /// Constant NotStarted for AwsOpportunityStage
        /// </summary>
        public static readonly AwsOpportunityStage NotStarted = new AwsOpportunityStage("Not Started");
        /// <summary>
        /// Constant Onboarding for AwsOpportunityStage
        /// </summary>
        public static readonly AwsOpportunityStage Onboarding = new AwsOpportunityStage("Onboarding");
        /// <summary>
        /// Constant OnHold for AwsOpportunityStage
        /// </summary>
        public static readonly AwsOpportunityStage OnHold = new AwsOpportunityStage("On-hold");
        /// <summary>
        /// Constant Prospect for AwsOpportunityStage
        /// </summary>
        public static readonly AwsOpportunityStage Prospect = new AwsOpportunityStage("Prospect");
        /// <summary>
        /// Constant Qualified for AwsOpportunityStage
        /// </summary>
        public static readonly AwsOpportunityStage Qualified = new AwsOpportunityStage("Qualified");
        /// <summary>
        /// Constant Qualify for AwsOpportunityStage
        /// </summary>
        public static readonly AwsOpportunityStage Qualify = new AwsOpportunityStage("Qualify");
        /// <summary>
        /// Constant Research for AwsOpportunityStage
        /// </summary>
        public static readonly AwsOpportunityStage Research = new AwsOpportunityStage("Research");
        /// <summary>
        /// Constant SellerEngaged for AwsOpportunityStage
        /// </summary>
        public static readonly AwsOpportunityStage SellerEngaged = new AwsOpportunityStage("Seller Engaged");
        /// <summary>
        /// Constant SellerRegistered for AwsOpportunityStage
        /// </summary>
        public static readonly AwsOpportunityStage SellerRegistered = new AwsOpportunityStage("Seller Registered");
        /// <summary>
        /// Constant TechnicalValidation for AwsOpportunityStage
        /// </summary>
        public static readonly AwsOpportunityStage TechnicalValidation = new AwsOpportunityStage("Technical Validation");
        /// <summary>
        /// Constant TermSheetNegotiation for AwsOpportunityStage
        /// </summary>
        public static readonly AwsOpportunityStage TermSheetNegotiation = new AwsOpportunityStage("Term Sheet Negotiation");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AwsOpportunityStage(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AwsOpportunityStage FindValue(string value)
        {
            return FindValue<AwsOpportunityStage>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AwsOpportunityStage(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Channel.
    /// </summary>
    public class Channel : ConstantClass
    {

        /// <summary>
        /// Constant AWSMarketingCentral for Channel
        /// </summary>
        public static readonly Channel AWSMarketingCentral = new Channel("AWS Marketing Central");
        /// <summary>
        /// Constant ContentSyndication for Channel
        /// </summary>
        public static readonly Channel ContentSyndication = new Channel("Content Syndication");
        /// <summary>
        /// Constant Display for Channel
        /// </summary>
        public static readonly Channel Display = new Channel("Display");
        /// <summary>
        /// Constant Email for Channel
        /// </summary>
        public static readonly Channel Email = new Channel("Email");
        /// <summary>
        /// Constant LiveEvent for Channel
        /// </summary>
        public static readonly Channel LiveEvent = new Channel("Live Event");
        /// <summary>
        /// Constant OutOfHomeOOH for Channel
        /// </summary>
        public static readonly Channel OutOfHomeOOH = new Channel("Out Of Home (OOH)");
        /// <summary>
        /// Constant Print for Channel
        /// </summary>
        public static readonly Channel Print = new Channel("Print");
        /// <summary>
        /// Constant Search for Channel
        /// </summary>
        public static readonly Channel Search = new Channel("Search");
        /// <summary>
        /// Constant Social for Channel
        /// </summary>
        public static readonly Channel Social = new Channel("Social");
        /// <summary>
        /// Constant Telemarketing for Channel
        /// </summary>
        public static readonly Channel Telemarketing = new Channel("Telemarketing");
        /// <summary>
        /// Constant TV for Channel
        /// </summary>
        public static readonly Channel TV = new Channel("TV");
        /// <summary>
        /// Constant Video for Channel
        /// </summary>
        public static readonly Channel Video = new Channel("Video");
        /// <summary>
        /// Constant VirtualEvent for Channel
        /// </summary>
        public static readonly Channel VirtualEvent = new Channel("Virtual Event");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Channel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Channel FindValue(string value)
        {
            return FindValue<Channel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Channel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ClosedLostReason.
    /// </summary>
    public class ClosedLostReason : ConstantClass
    {

        /// <summary>
        /// Constant CustomerDeficiency for ClosedLostReason
        /// </summary>
        public static readonly ClosedLostReason CustomerDeficiency = new ClosedLostReason("Customer Deficiency");
        /// <summary>
        /// Constant CustomerExperience for ClosedLostReason
        /// </summary>
        public static readonly ClosedLostReason CustomerExperience = new ClosedLostReason("Customer Experience");
        /// <summary>
        /// Constant DelayCancellationOfProject for ClosedLostReason
        /// </summary>
        public static readonly ClosedLostReason DelayCancellationOfProject = new ClosedLostReason("Delay / Cancellation of Project");
        /// <summary>
        /// Constant FinancialCommercial for ClosedLostReason
        /// </summary>
        public static readonly ClosedLostReason FinancialCommercial = new ClosedLostReason("Financial/Commercial");
        /// <summary>
        /// Constant LegalTaxRegulatory for ClosedLostReason
        /// </summary>
        public static readonly ClosedLostReason LegalTaxRegulatory = new ClosedLostReason("Legal / Tax / Regulatory");
        /// <summary>
        /// Constant LostToCompetitorGoogle for ClosedLostReason
        /// </summary>
        public static readonly ClosedLostReason LostToCompetitorGoogle = new ClosedLostReason("Lost to Competitor - Google");
        /// <summary>
        /// Constant LostToCompetitorMicrosoft for ClosedLostReason
        /// </summary>
        public static readonly ClosedLostReason LostToCompetitorMicrosoft = new ClosedLostReason("Lost to Competitor - Microsoft");
        /// <summary>
        /// Constant LostToCompetitorOther for ClosedLostReason
        /// </summary>
        public static readonly ClosedLostReason LostToCompetitorOther = new ClosedLostReason("Lost to Competitor - Other");
        /// <summary>
        /// Constant LostToCompetitorSoftLayer for ClosedLostReason
        /// </summary>
        public static readonly ClosedLostReason LostToCompetitorSoftLayer = new ClosedLostReason("Lost to Competitor - SoftLayer");
        /// <summary>
        /// Constant LostToCompetitorVMWare for ClosedLostReason
        /// </summary>
        public static readonly ClosedLostReason LostToCompetitorVMWare = new ClosedLostReason("Lost to Competitor - VMWare");
        /// <summary>
        /// Constant NoOpportunity for ClosedLostReason
        /// </summary>
        public static readonly ClosedLostReason NoOpportunity = new ClosedLostReason("No Opportunity");
        /// <summary>
        /// Constant OnPremisesDeployment for ClosedLostReason
        /// </summary>
        public static readonly ClosedLostReason OnPremisesDeployment = new ClosedLostReason("On Premises Deployment");
        /// <summary>
        /// Constant Other for ClosedLostReason
        /// </summary>
        public static readonly ClosedLostReason Other = new ClosedLostReason("Other");
        /// <summary>
        /// Constant PartnerGap for ClosedLostReason
        /// </summary>
        public static readonly ClosedLostReason PartnerGap = new ClosedLostReason("Partner Gap");
        /// <summary>
        /// Constant PeopleRelationshipGovernance for ClosedLostReason
        /// </summary>
        public static readonly ClosedLostReason PeopleRelationshipGovernance = new ClosedLostReason("People/Relationship/Governance");
        /// <summary>
        /// Constant Price for ClosedLostReason
        /// </summary>
        public static readonly ClosedLostReason Price = new ClosedLostReason("Price");
        /// <summary>
        /// Constant ProductTechnology for ClosedLostReason
        /// </summary>
        public static readonly ClosedLostReason ProductTechnology = new ClosedLostReason("Product/Technology");
        /// <summary>
        /// Constant SecurityCompliance for ClosedLostReason
        /// </summary>
        public static readonly ClosedLostReason SecurityCompliance = new ClosedLostReason("Security / Compliance");
        /// <summary>
        /// Constant TechnicalLimitations for ClosedLostReason
        /// </summary>
        public static readonly ClosedLostReason TechnicalLimitations = new ClosedLostReason("Technical Limitations");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ClosedLostReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ClosedLostReason FindValue(string value)
        {
            return FindValue<ClosedLostReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ClosedLostReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CompetitorName.
    /// </summary>
    public class CompetitorName : ConstantClass
    {

        /// <summary>
        /// Constant Akamai for CompetitorName
        /// </summary>
        public static readonly CompetitorName Akamai = new CompetitorName("Akamai");
        /// <summary>
        /// Constant AliCloud for CompetitorName
        /// </summary>
        public static readonly CompetitorName AliCloud = new CompetitorName("AliCloud");
        /// <summary>
        /// Constant CoLocation for CompetitorName
        /// </summary>
        public static readonly CompetitorName CoLocation = new CompetitorName("Co-location");
        /// <summary>
        /// Constant GoogleCloudPlatform for CompetitorName
        /// </summary>
        public static readonly CompetitorName GoogleCloudPlatform = new CompetitorName("Google Cloud Platform");
        /// <summary>
        /// Constant IBMSoftlayer for CompetitorName
        /// </summary>
        public static readonly CompetitorName IBMSoftlayer = new CompetitorName("IBM Softlayer");
        /// <summary>
        /// Constant MicrosoftAzure for CompetitorName
        /// </summary>
        public static readonly CompetitorName MicrosoftAzure = new CompetitorName("Microsoft Azure");
        /// <summary>
        /// Constant NoCompetition for CompetitorName
        /// </summary>
        public static readonly CompetitorName NoCompetition = new CompetitorName("No Competition");
        /// <summary>
        /// Constant OnPrem for CompetitorName
        /// </summary>
        public static readonly CompetitorName OnPrem = new CompetitorName("On-Prem");
        /// <summary>
        /// Constant OracleCloud for CompetitorName
        /// </summary>
        public static readonly CompetitorName OracleCloud = new CompetitorName("Oracle Cloud");
        /// <summary>
        /// Constant Other for CompetitorName
        /// </summary>
        public static readonly CompetitorName Other = new CompetitorName("*Other");
        /// <summary>
        /// Constant OtherCostOptimization for CompetitorName
        /// </summary>
        public static readonly CompetitorName OtherCostOptimization = new CompetitorName("Other- Cost Optimization");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CompetitorName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CompetitorName FindValue(string value)
        {
            return FindValue<CompetitorName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CompetitorName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CountryCode.
    /// </summary>
    public class CountryCode : ConstantClass
    {

        /// <summary>
        /// Constant AD for CountryCode
        /// </summary>
        public static readonly CountryCode AD = new CountryCode("AD");
        /// <summary>
        /// Constant AE for CountryCode
        /// </summary>
        public static readonly CountryCode AE = new CountryCode("AE");
        /// <summary>
        /// Constant AF for CountryCode
        /// </summary>
        public static readonly CountryCode AF = new CountryCode("AF");
        /// <summary>
        /// Constant AG for CountryCode
        /// </summary>
        public static readonly CountryCode AG = new CountryCode("AG");
        /// <summary>
        /// Constant AI for CountryCode
        /// </summary>
        public static readonly CountryCode AI = new CountryCode("AI");
        /// <summary>
        /// Constant AL for CountryCode
        /// </summary>
        public static readonly CountryCode AL = new CountryCode("AL");
        /// <summary>
        /// Constant AM for CountryCode
        /// </summary>
        public static readonly CountryCode AM = new CountryCode("AM");
        /// <summary>
        /// Constant AN for CountryCode
        /// </summary>
        public static readonly CountryCode AN = new CountryCode("AN");
        /// <summary>
        /// Constant AO for CountryCode
        /// </summary>
        public static readonly CountryCode AO = new CountryCode("AO");
        /// <summary>
        /// Constant AQ for CountryCode
        /// </summary>
        public static readonly CountryCode AQ = new CountryCode("AQ");
        /// <summary>
        /// Constant AR for CountryCode
        /// </summary>
        public static readonly CountryCode AR = new CountryCode("AR");
        /// <summary>
        /// Constant AS for CountryCode
        /// </summary>
        public static readonly CountryCode AS = new CountryCode("AS");
        /// <summary>
        /// Constant AT for CountryCode
        /// </summary>
        public static readonly CountryCode AT = new CountryCode("AT");
        /// <summary>
        /// Constant AU for CountryCode
        /// </summary>
        public static readonly CountryCode AU = new CountryCode("AU");
        /// <summary>
        /// Constant AW for CountryCode
        /// </summary>
        public static readonly CountryCode AW = new CountryCode("AW");
        /// <summary>
        /// Constant AX for CountryCode
        /// </summary>
        public static readonly CountryCode AX = new CountryCode("AX");
        /// <summary>
        /// Constant AZ for CountryCode
        /// </summary>
        public static readonly CountryCode AZ = new CountryCode("AZ");
        /// <summary>
        /// Constant BA for CountryCode
        /// </summary>
        public static readonly CountryCode BA = new CountryCode("BA");
        /// <summary>
        /// Constant BB for CountryCode
        /// </summary>
        public static readonly CountryCode BB = new CountryCode("BB");
        /// <summary>
        /// Constant BD for CountryCode
        /// </summary>
        public static readonly CountryCode BD = new CountryCode("BD");
        /// <summary>
        /// Constant BE for CountryCode
        /// </summary>
        public static readonly CountryCode BE = new CountryCode("BE");
        /// <summary>
        /// Constant BF for CountryCode
        /// </summary>
        public static readonly CountryCode BF = new CountryCode("BF");
        /// <summary>
        /// Constant BG for CountryCode
        /// </summary>
        public static readonly CountryCode BG = new CountryCode("BG");
        /// <summary>
        /// Constant BH for CountryCode
        /// </summary>
        public static readonly CountryCode BH = new CountryCode("BH");
        /// <summary>
        /// Constant BI for CountryCode
        /// </summary>
        public static readonly CountryCode BI = new CountryCode("BI");
        /// <summary>
        /// Constant BJ for CountryCode
        /// </summary>
        public static readonly CountryCode BJ = new CountryCode("BJ");
        /// <summary>
        /// Constant BL for CountryCode
        /// </summary>
        public static readonly CountryCode BL = new CountryCode("BL");
        /// <summary>
        /// Constant BM for CountryCode
        /// </summary>
        public static readonly CountryCode BM = new CountryCode("BM");
        /// <summary>
        /// Constant BN for CountryCode
        /// </summary>
        public static readonly CountryCode BN = new CountryCode("BN");
        /// <summary>
        /// Constant BO for CountryCode
        /// </summary>
        public static readonly CountryCode BO = new CountryCode("BO");
        /// <summary>
        /// Constant BQ for CountryCode
        /// </summary>
        public static readonly CountryCode BQ = new CountryCode("BQ");
        /// <summary>
        /// Constant BR for CountryCode
        /// </summary>
        public static readonly CountryCode BR = new CountryCode("BR");
        /// <summary>
        /// Constant BS for CountryCode
        /// </summary>
        public static readonly CountryCode BS = new CountryCode("BS");
        /// <summary>
        /// Constant BT for CountryCode
        /// </summary>
        public static readonly CountryCode BT = new CountryCode("BT");
        /// <summary>
        /// Constant BV for CountryCode
        /// </summary>
        public static readonly CountryCode BV = new CountryCode("BV");
        /// <summary>
        /// Constant BW for CountryCode
        /// </summary>
        public static readonly CountryCode BW = new CountryCode("BW");
        /// <summary>
        /// Constant BY for CountryCode
        /// </summary>
        public static readonly CountryCode BY = new CountryCode("BY");
        /// <summary>
        /// Constant BZ for CountryCode
        /// </summary>
        public static readonly CountryCode BZ = new CountryCode("BZ");
        /// <summary>
        /// Constant CA for CountryCode
        /// </summary>
        public static readonly CountryCode CA = new CountryCode("CA");
        /// <summary>
        /// Constant CC for CountryCode
        /// </summary>
        public static readonly CountryCode CC = new CountryCode("CC");
        /// <summary>
        /// Constant CD for CountryCode
        /// </summary>
        public static readonly CountryCode CD = new CountryCode("CD");
        /// <summary>
        /// Constant CF for CountryCode
        /// </summary>
        public static readonly CountryCode CF = new CountryCode("CF");
        /// <summary>
        /// Constant CG for CountryCode
        /// </summary>
        public static readonly CountryCode CG = new CountryCode("CG");
        /// <summary>
        /// Constant CH for CountryCode
        /// </summary>
        public static readonly CountryCode CH = new CountryCode("CH");
        /// <summary>
        /// Constant CI for CountryCode
        /// </summary>
        public static readonly CountryCode CI = new CountryCode("CI");
        /// <summary>
        /// Constant CK for CountryCode
        /// </summary>
        public static readonly CountryCode CK = new CountryCode("CK");
        /// <summary>
        /// Constant CL for CountryCode
        /// </summary>
        public static readonly CountryCode CL = new CountryCode("CL");
        /// <summary>
        /// Constant CM for CountryCode
        /// </summary>
        public static readonly CountryCode CM = new CountryCode("CM");
        /// <summary>
        /// Constant CN for CountryCode
        /// </summary>
        public static readonly CountryCode CN = new CountryCode("CN");
        /// <summary>
        /// Constant CO for CountryCode
        /// </summary>
        public static readonly CountryCode CO = new CountryCode("CO");
        /// <summary>
        /// Constant CR for CountryCode
        /// </summary>
        public static readonly CountryCode CR = new CountryCode("CR");
        /// <summary>
        /// Constant CU for CountryCode
        /// </summary>
        public static readonly CountryCode CU = new CountryCode("CU");
        /// <summary>
        /// Constant CV for CountryCode
        /// </summary>
        public static readonly CountryCode CV = new CountryCode("CV");
        /// <summary>
        /// Constant CW for CountryCode
        /// </summary>
        public static readonly CountryCode CW = new CountryCode("CW");
        /// <summary>
        /// Constant CX for CountryCode
        /// </summary>
        public static readonly CountryCode CX = new CountryCode("CX");
        /// <summary>
        /// Constant CY for CountryCode
        /// </summary>
        public static readonly CountryCode CY = new CountryCode("CY");
        /// <summary>
        /// Constant CZ for CountryCode
        /// </summary>
        public static readonly CountryCode CZ = new CountryCode("CZ");
        /// <summary>
        /// Constant DE for CountryCode
        /// </summary>
        public static readonly CountryCode DE = new CountryCode("DE");
        /// <summary>
        /// Constant DJ for CountryCode
        /// </summary>
        public static readonly CountryCode DJ = new CountryCode("DJ");
        /// <summary>
        /// Constant DK for CountryCode
        /// </summary>
        public static readonly CountryCode DK = new CountryCode("DK");
        /// <summary>
        /// Constant DM for CountryCode
        /// </summary>
        public static readonly CountryCode DM = new CountryCode("DM");
        /// <summary>
        /// Constant DO for CountryCode
        /// </summary>
        public static readonly CountryCode DO = new CountryCode("DO");
        /// <summary>
        /// Constant DZ for CountryCode
        /// </summary>
        public static readonly CountryCode DZ = new CountryCode("DZ");
        /// <summary>
        /// Constant EC for CountryCode
        /// </summary>
        public static readonly CountryCode EC = new CountryCode("EC");
        /// <summary>
        /// Constant EE for CountryCode
        /// </summary>
        public static readonly CountryCode EE = new CountryCode("EE");
        /// <summary>
        /// Constant EG for CountryCode
        /// </summary>
        public static readonly CountryCode EG = new CountryCode("EG");
        /// <summary>
        /// Constant EH for CountryCode
        /// </summary>
        public static readonly CountryCode EH = new CountryCode("EH");
        /// <summary>
        /// Constant ER for CountryCode
        /// </summary>
        public static readonly CountryCode ER = new CountryCode("ER");
        /// <summary>
        /// Constant ES for CountryCode
        /// </summary>
        public static readonly CountryCode ES = new CountryCode("ES");
        /// <summary>
        /// Constant ET for CountryCode
        /// </summary>
        public static readonly CountryCode ET = new CountryCode("ET");
        /// <summary>
        /// Constant FI for CountryCode
        /// </summary>
        public static readonly CountryCode FI = new CountryCode("FI");
        /// <summary>
        /// Constant FJ for CountryCode
        /// </summary>
        public static readonly CountryCode FJ = new CountryCode("FJ");
        /// <summary>
        /// Constant FK for CountryCode
        /// </summary>
        public static readonly CountryCode FK = new CountryCode("FK");
        /// <summary>
        /// Constant FM for CountryCode
        /// </summary>
        public static readonly CountryCode FM = new CountryCode("FM");
        /// <summary>
        /// Constant FO for CountryCode
        /// </summary>
        public static readonly CountryCode FO = new CountryCode("FO");
        /// <summary>
        /// Constant FR for CountryCode
        /// </summary>
        public static readonly CountryCode FR = new CountryCode("FR");
        /// <summary>
        /// Constant GA for CountryCode
        /// </summary>
        public static readonly CountryCode GA = new CountryCode("GA");
        /// <summary>
        /// Constant GB for CountryCode
        /// </summary>
        public static readonly CountryCode GB = new CountryCode("GB");
        /// <summary>
        /// Constant GD for CountryCode
        /// </summary>
        public static readonly CountryCode GD = new CountryCode("GD");
        /// <summary>
        /// Constant GE for CountryCode
        /// </summary>
        public static readonly CountryCode GE = new CountryCode("GE");
        /// <summary>
        /// Constant GF for CountryCode
        /// </summary>
        public static readonly CountryCode GF = new CountryCode("GF");
        /// <summary>
        /// Constant GG for CountryCode
        /// </summary>
        public static readonly CountryCode GG = new CountryCode("GG");
        /// <summary>
        /// Constant GH for CountryCode
        /// </summary>
        public static readonly CountryCode GH = new CountryCode("GH");
        /// <summary>
        /// Constant GI for CountryCode
        /// </summary>
        public static readonly CountryCode GI = new CountryCode("GI");
        /// <summary>
        /// Constant GL for CountryCode
        /// </summary>
        public static readonly CountryCode GL = new CountryCode("GL");
        /// <summary>
        /// Constant GM for CountryCode
        /// </summary>
        public static readonly CountryCode GM = new CountryCode("GM");
        /// <summary>
        /// Constant GN for CountryCode
        /// </summary>
        public static readonly CountryCode GN = new CountryCode("GN");
        /// <summary>
        /// Constant GP for CountryCode
        /// </summary>
        public static readonly CountryCode GP = new CountryCode("GP");
        /// <summary>
        /// Constant GQ for CountryCode
        /// </summary>
        public static readonly CountryCode GQ = new CountryCode("GQ");
        /// <summary>
        /// Constant GR for CountryCode
        /// </summary>
        public static readonly CountryCode GR = new CountryCode("GR");
        /// <summary>
        /// Constant GS for CountryCode
        /// </summary>
        public static readonly CountryCode GS = new CountryCode("GS");
        /// <summary>
        /// Constant GT for CountryCode
        /// </summary>
        public static readonly CountryCode GT = new CountryCode("GT");
        /// <summary>
        /// Constant GU for CountryCode
        /// </summary>
        public static readonly CountryCode GU = new CountryCode("GU");
        /// <summary>
        /// Constant GW for CountryCode
        /// </summary>
        public static readonly CountryCode GW = new CountryCode("GW");
        /// <summary>
        /// Constant GY for CountryCode
        /// </summary>
        public static readonly CountryCode GY = new CountryCode("GY");
        /// <summary>
        /// Constant HK for CountryCode
        /// </summary>
        public static readonly CountryCode HK = new CountryCode("HK");
        /// <summary>
        /// Constant HM for CountryCode
        /// </summary>
        public static readonly CountryCode HM = new CountryCode("HM");
        /// <summary>
        /// Constant HN for CountryCode
        /// </summary>
        public static readonly CountryCode HN = new CountryCode("HN");
        /// <summary>
        /// Constant HR for CountryCode
        /// </summary>
        public static readonly CountryCode HR = new CountryCode("HR");
        /// <summary>
        /// Constant HT for CountryCode
        /// </summary>
        public static readonly CountryCode HT = new CountryCode("HT");
        /// <summary>
        /// Constant HU for CountryCode
        /// </summary>
        public static readonly CountryCode HU = new CountryCode("HU");
        /// <summary>
        /// Constant ID for CountryCode
        /// </summary>
        public static readonly CountryCode ID = new CountryCode("ID");
        /// <summary>
        /// Constant IE for CountryCode
        /// </summary>
        public static readonly CountryCode IE = new CountryCode("IE");
        /// <summary>
        /// Constant IL for CountryCode
        /// </summary>
        public static readonly CountryCode IL = new CountryCode("IL");
        /// <summary>
        /// Constant IM for CountryCode
        /// </summary>
        public static readonly CountryCode IM = new CountryCode("IM");
        /// <summary>
        /// Constant IN for CountryCode
        /// </summary>
        public static readonly CountryCode IN = new CountryCode("IN");
        /// <summary>
        /// Constant IO for CountryCode
        /// </summary>
        public static readonly CountryCode IO = new CountryCode("IO");
        /// <summary>
        /// Constant IQ for CountryCode
        /// </summary>
        public static readonly CountryCode IQ = new CountryCode("IQ");
        /// <summary>
        /// Constant IR for CountryCode
        /// </summary>
        public static readonly CountryCode IR = new CountryCode("IR");
        /// <summary>
        /// Constant IS for CountryCode
        /// </summary>
        public static readonly CountryCode IS = new CountryCode("IS");
        /// <summary>
        /// Constant IT for CountryCode
        /// </summary>
        public static readonly CountryCode IT = new CountryCode("IT");
        /// <summary>
        /// Constant JE for CountryCode
        /// </summary>
        public static readonly CountryCode JE = new CountryCode("JE");
        /// <summary>
        /// Constant JM for CountryCode
        /// </summary>
        public static readonly CountryCode JM = new CountryCode("JM");
        /// <summary>
        /// Constant JO for CountryCode
        /// </summary>
        public static readonly CountryCode JO = new CountryCode("JO");
        /// <summary>
        /// Constant JP for CountryCode
        /// </summary>
        public static readonly CountryCode JP = new CountryCode("JP");
        /// <summary>
        /// Constant KE for CountryCode
        /// </summary>
        public static readonly CountryCode KE = new CountryCode("KE");
        /// <summary>
        /// Constant KG for CountryCode
        /// </summary>
        public static readonly CountryCode KG = new CountryCode("KG");
        /// <summary>
        /// Constant KH for CountryCode
        /// </summary>
        public static readonly CountryCode KH = new CountryCode("KH");
        /// <summary>
        /// Constant KI for CountryCode
        /// </summary>
        public static readonly CountryCode KI = new CountryCode("KI");
        /// <summary>
        /// Constant KM for CountryCode
        /// </summary>
        public static readonly CountryCode KM = new CountryCode("KM");
        /// <summary>
        /// Constant KN for CountryCode
        /// </summary>
        public static readonly CountryCode KN = new CountryCode("KN");
        /// <summary>
        /// Constant KR for CountryCode
        /// </summary>
        public static readonly CountryCode KR = new CountryCode("KR");
        /// <summary>
        /// Constant KW for CountryCode
        /// </summary>
        public static readonly CountryCode KW = new CountryCode("KW");
        /// <summary>
        /// Constant KY for CountryCode
        /// </summary>
        public static readonly CountryCode KY = new CountryCode("KY");
        /// <summary>
        /// Constant KZ for CountryCode
        /// </summary>
        public static readonly CountryCode KZ = new CountryCode("KZ");
        /// <summary>
        /// Constant LA for CountryCode
        /// </summary>
        public static readonly CountryCode LA = new CountryCode("LA");
        /// <summary>
        /// Constant LB for CountryCode
        /// </summary>
        public static readonly CountryCode LB = new CountryCode("LB");
        /// <summary>
        /// Constant LC for CountryCode
        /// </summary>
        public static readonly CountryCode LC = new CountryCode("LC");
        /// <summary>
        /// Constant LI for CountryCode
        /// </summary>
        public static readonly CountryCode LI = new CountryCode("LI");
        /// <summary>
        /// Constant LK for CountryCode
        /// </summary>
        public static readonly CountryCode LK = new CountryCode("LK");
        /// <summary>
        /// Constant LR for CountryCode
        /// </summary>
        public static readonly CountryCode LR = new CountryCode("LR");
        /// <summary>
        /// Constant LS for CountryCode
        /// </summary>
        public static readonly CountryCode LS = new CountryCode("LS");
        /// <summary>
        /// Constant LT for CountryCode
        /// </summary>
        public static readonly CountryCode LT = new CountryCode("LT");
        /// <summary>
        /// Constant LU for CountryCode
        /// </summary>
        public static readonly CountryCode LU = new CountryCode("LU");
        /// <summary>
        /// Constant LV for CountryCode
        /// </summary>
        public static readonly CountryCode LV = new CountryCode("LV");
        /// <summary>
        /// Constant LY for CountryCode
        /// </summary>
        public static readonly CountryCode LY = new CountryCode("LY");
        /// <summary>
        /// Constant MA for CountryCode
        /// </summary>
        public static readonly CountryCode MA = new CountryCode("MA");
        /// <summary>
        /// Constant MC for CountryCode
        /// </summary>
        public static readonly CountryCode MC = new CountryCode("MC");
        /// <summary>
        /// Constant MD for CountryCode
        /// </summary>
        public static readonly CountryCode MD = new CountryCode("MD");
        /// <summary>
        /// Constant ME for CountryCode
        /// </summary>
        public static readonly CountryCode ME = new CountryCode("ME");
        /// <summary>
        /// Constant MF for CountryCode
        /// </summary>
        public static readonly CountryCode MF = new CountryCode("MF");
        /// <summary>
        /// Constant MG for CountryCode
        /// </summary>
        public static readonly CountryCode MG = new CountryCode("MG");
        /// <summary>
        /// Constant MH for CountryCode
        /// </summary>
        public static readonly CountryCode MH = new CountryCode("MH");
        /// <summary>
        /// Constant MK for CountryCode
        /// </summary>
        public static readonly CountryCode MK = new CountryCode("MK");
        /// <summary>
        /// Constant ML for CountryCode
        /// </summary>
        public static readonly CountryCode ML = new CountryCode("ML");
        /// <summary>
        /// Constant MM for CountryCode
        /// </summary>
        public static readonly CountryCode MM = new CountryCode("MM");
        /// <summary>
        /// Constant MN for CountryCode
        /// </summary>
        public static readonly CountryCode MN = new CountryCode("MN");
        /// <summary>
        /// Constant MO for CountryCode
        /// </summary>
        public static readonly CountryCode MO = new CountryCode("MO");
        /// <summary>
        /// Constant MP for CountryCode
        /// </summary>
        public static readonly CountryCode MP = new CountryCode("MP");
        /// <summary>
        /// Constant MQ for CountryCode
        /// </summary>
        public static readonly CountryCode MQ = new CountryCode("MQ");
        /// <summary>
        /// Constant MR for CountryCode
        /// </summary>
        public static readonly CountryCode MR = new CountryCode("MR");
        /// <summary>
        /// Constant MS for CountryCode
        /// </summary>
        public static readonly CountryCode MS = new CountryCode("MS");
        /// <summary>
        /// Constant MT for CountryCode
        /// </summary>
        public static readonly CountryCode MT = new CountryCode("MT");
        /// <summary>
        /// Constant MU for CountryCode
        /// </summary>
        public static readonly CountryCode MU = new CountryCode("MU");
        /// <summary>
        /// Constant MV for CountryCode
        /// </summary>
        public static readonly CountryCode MV = new CountryCode("MV");
        /// <summary>
        /// Constant MW for CountryCode
        /// </summary>
        public static readonly CountryCode MW = new CountryCode("MW");
        /// <summary>
        /// Constant MX for CountryCode
        /// </summary>
        public static readonly CountryCode MX = new CountryCode("MX");
        /// <summary>
        /// Constant MY for CountryCode
        /// </summary>
        public static readonly CountryCode MY = new CountryCode("MY");
        /// <summary>
        /// Constant MZ for CountryCode
        /// </summary>
        public static readonly CountryCode MZ = new CountryCode("MZ");
        /// <summary>
        /// Constant NA for CountryCode
        /// </summary>
        public static readonly CountryCode NA = new CountryCode("NA");
        /// <summary>
        /// Constant NC for CountryCode
        /// </summary>
        public static readonly CountryCode NC = new CountryCode("NC");
        /// <summary>
        /// Constant NE for CountryCode
        /// </summary>
        public static readonly CountryCode NE = new CountryCode("NE");
        /// <summary>
        /// Constant NF for CountryCode
        /// </summary>
        public static readonly CountryCode NF = new CountryCode("NF");
        /// <summary>
        /// Constant NG for CountryCode
        /// </summary>
        public static readonly CountryCode NG = new CountryCode("NG");
        /// <summary>
        /// Constant NI for CountryCode
        /// </summary>
        public static readonly CountryCode NI = new CountryCode("NI");
        /// <summary>
        /// Constant NL for CountryCode
        /// </summary>
        public static readonly CountryCode NL = new CountryCode("NL");
        /// <summary>
        /// Constant NO for CountryCode
        /// </summary>
        public static readonly CountryCode NO = new CountryCode("NO");
        /// <summary>
        /// Constant NP for CountryCode
        /// </summary>
        public static readonly CountryCode NP = new CountryCode("NP");
        /// <summary>
        /// Constant NR for CountryCode
        /// </summary>
        public static readonly CountryCode NR = new CountryCode("NR");
        /// <summary>
        /// Constant NU for CountryCode
        /// </summary>
        public static readonly CountryCode NU = new CountryCode("NU");
        /// <summary>
        /// Constant NZ for CountryCode
        /// </summary>
        public static readonly CountryCode NZ = new CountryCode("NZ");
        /// <summary>
        /// Constant OM for CountryCode
        /// </summary>
        public static readonly CountryCode OM = new CountryCode("OM");
        /// <summary>
        /// Constant PA for CountryCode
        /// </summary>
        public static readonly CountryCode PA = new CountryCode("PA");
        /// <summary>
        /// Constant PE for CountryCode
        /// </summary>
        public static readonly CountryCode PE = new CountryCode("PE");
        /// <summary>
        /// Constant PF for CountryCode
        /// </summary>
        public static readonly CountryCode PF = new CountryCode("PF");
        /// <summary>
        /// Constant PG for CountryCode
        /// </summary>
        public static readonly CountryCode PG = new CountryCode("PG");
        /// <summary>
        /// Constant PH for CountryCode
        /// </summary>
        public static readonly CountryCode PH = new CountryCode("PH");
        /// <summary>
        /// Constant PK for CountryCode
        /// </summary>
        public static readonly CountryCode PK = new CountryCode("PK");
        /// <summary>
        /// Constant PL for CountryCode
        /// </summary>
        public static readonly CountryCode PL = new CountryCode("PL");
        /// <summary>
        /// Constant PM for CountryCode
        /// </summary>
        public static readonly CountryCode PM = new CountryCode("PM");
        /// <summary>
        /// Constant PN for CountryCode
        /// </summary>
        public static readonly CountryCode PN = new CountryCode("PN");
        /// <summary>
        /// Constant PR for CountryCode
        /// </summary>
        public static readonly CountryCode PR = new CountryCode("PR");
        /// <summary>
        /// Constant PS for CountryCode
        /// </summary>
        public static readonly CountryCode PS = new CountryCode("PS");
        /// <summary>
        /// Constant PT for CountryCode
        /// </summary>
        public static readonly CountryCode PT = new CountryCode("PT");
        /// <summary>
        /// Constant PW for CountryCode
        /// </summary>
        public static readonly CountryCode PW = new CountryCode("PW");
        /// <summary>
        /// Constant PY for CountryCode
        /// </summary>
        public static readonly CountryCode PY = new CountryCode("PY");
        /// <summary>
        /// Constant QA for CountryCode
        /// </summary>
        public static readonly CountryCode QA = new CountryCode("QA");
        /// <summary>
        /// Constant RE for CountryCode
        /// </summary>
        public static readonly CountryCode RE = new CountryCode("RE");
        /// <summary>
        /// Constant RO for CountryCode
        /// </summary>
        public static readonly CountryCode RO = new CountryCode("RO");
        /// <summary>
        /// Constant RS for CountryCode
        /// </summary>
        public static readonly CountryCode RS = new CountryCode("RS");
        /// <summary>
        /// Constant RU for CountryCode
        /// </summary>
        public static readonly CountryCode RU = new CountryCode("RU");
        /// <summary>
        /// Constant RW for CountryCode
        /// </summary>
        public static readonly CountryCode RW = new CountryCode("RW");
        /// <summary>
        /// Constant SA for CountryCode
        /// </summary>
        public static readonly CountryCode SA = new CountryCode("SA");
        /// <summary>
        /// Constant SB for CountryCode
        /// </summary>
        public static readonly CountryCode SB = new CountryCode("SB");
        /// <summary>
        /// Constant SC for CountryCode
        /// </summary>
        public static readonly CountryCode SC = new CountryCode("SC");
        /// <summary>
        /// Constant SD for CountryCode
        /// </summary>
        public static readonly CountryCode SD = new CountryCode("SD");
        /// <summary>
        /// Constant SE for CountryCode
        /// </summary>
        public static readonly CountryCode SE = new CountryCode("SE");
        /// <summary>
        /// Constant SG for CountryCode
        /// </summary>
        public static readonly CountryCode SG = new CountryCode("SG");
        /// <summary>
        /// Constant SH for CountryCode
        /// </summary>
        public static readonly CountryCode SH = new CountryCode("SH");
        /// <summary>
        /// Constant SI for CountryCode
        /// </summary>
        public static readonly CountryCode SI = new CountryCode("SI");
        /// <summary>
        /// Constant SJ for CountryCode
        /// </summary>
        public static readonly CountryCode SJ = new CountryCode("SJ");
        /// <summary>
        /// Constant SK for CountryCode
        /// </summary>
        public static readonly CountryCode SK = new CountryCode("SK");
        /// <summary>
        /// Constant SL for CountryCode
        /// </summary>
        public static readonly CountryCode SL = new CountryCode("SL");
        /// <summary>
        /// Constant SM for CountryCode
        /// </summary>
        public static readonly CountryCode SM = new CountryCode("SM");
        /// <summary>
        /// Constant SN for CountryCode
        /// </summary>
        public static readonly CountryCode SN = new CountryCode("SN");
        /// <summary>
        /// Constant SO for CountryCode
        /// </summary>
        public static readonly CountryCode SO = new CountryCode("SO");
        /// <summary>
        /// Constant SR for CountryCode
        /// </summary>
        public static readonly CountryCode SR = new CountryCode("SR");
        /// <summary>
        /// Constant SS for CountryCode
        /// </summary>
        public static readonly CountryCode SS = new CountryCode("SS");
        /// <summary>
        /// Constant ST for CountryCode
        /// </summary>
        public static readonly CountryCode ST = new CountryCode("ST");
        /// <summary>
        /// Constant SV for CountryCode
        /// </summary>
        public static readonly CountryCode SV = new CountryCode("SV");
        /// <summary>
        /// Constant SX for CountryCode
        /// </summary>
        public static readonly CountryCode SX = new CountryCode("SX");
        /// <summary>
        /// Constant SY for CountryCode
        /// </summary>
        public static readonly CountryCode SY = new CountryCode("SY");
        /// <summary>
        /// Constant SZ for CountryCode
        /// </summary>
        public static readonly CountryCode SZ = new CountryCode("SZ");
        /// <summary>
        /// Constant TC for CountryCode
        /// </summary>
        public static readonly CountryCode TC = new CountryCode("TC");
        /// <summary>
        /// Constant TD for CountryCode
        /// </summary>
        public static readonly CountryCode TD = new CountryCode("TD");
        /// <summary>
        /// Constant TF for CountryCode
        /// </summary>
        public static readonly CountryCode TF = new CountryCode("TF");
        /// <summary>
        /// Constant TG for CountryCode
        /// </summary>
        public static readonly CountryCode TG = new CountryCode("TG");
        /// <summary>
        /// Constant TH for CountryCode
        /// </summary>
        public static readonly CountryCode TH = new CountryCode("TH");
        /// <summary>
        /// Constant TJ for CountryCode
        /// </summary>
        public static readonly CountryCode TJ = new CountryCode("TJ");
        /// <summary>
        /// Constant TK for CountryCode
        /// </summary>
        public static readonly CountryCode TK = new CountryCode("TK");
        /// <summary>
        /// Constant TL for CountryCode
        /// </summary>
        public static readonly CountryCode TL = new CountryCode("TL");
        /// <summary>
        /// Constant TM for CountryCode
        /// </summary>
        public static readonly CountryCode TM = new CountryCode("TM");
        /// <summary>
        /// Constant TN for CountryCode
        /// </summary>
        public static readonly CountryCode TN = new CountryCode("TN");
        /// <summary>
        /// Constant TO for CountryCode
        /// </summary>
        public static readonly CountryCode TO = new CountryCode("TO");
        /// <summary>
        /// Constant TR for CountryCode
        /// </summary>
        public static readonly CountryCode TR = new CountryCode("TR");
        /// <summary>
        /// Constant TT for CountryCode
        /// </summary>
        public static readonly CountryCode TT = new CountryCode("TT");
        /// <summary>
        /// Constant TV for CountryCode
        /// </summary>
        public static readonly CountryCode TV = new CountryCode("TV");
        /// <summary>
        /// Constant TW for CountryCode
        /// </summary>
        public static readonly CountryCode TW = new CountryCode("TW");
        /// <summary>
        /// Constant TZ for CountryCode
        /// </summary>
        public static readonly CountryCode TZ = new CountryCode("TZ");
        /// <summary>
        /// Constant UA for CountryCode
        /// </summary>
        public static readonly CountryCode UA = new CountryCode("UA");
        /// <summary>
        /// Constant UG for CountryCode
        /// </summary>
        public static readonly CountryCode UG = new CountryCode("UG");
        /// <summary>
        /// Constant UM for CountryCode
        /// </summary>
        public static readonly CountryCode UM = new CountryCode("UM");
        /// <summary>
        /// Constant US for CountryCode
        /// </summary>
        public static readonly CountryCode US = new CountryCode("US");
        /// <summary>
        /// Constant UY for CountryCode
        /// </summary>
        public static readonly CountryCode UY = new CountryCode("UY");
        /// <summary>
        /// Constant UZ for CountryCode
        /// </summary>
        public static readonly CountryCode UZ = new CountryCode("UZ");
        /// <summary>
        /// Constant VA for CountryCode
        /// </summary>
        public static readonly CountryCode VA = new CountryCode("VA");
        /// <summary>
        /// Constant VC for CountryCode
        /// </summary>
        public static readonly CountryCode VC = new CountryCode("VC");
        /// <summary>
        /// Constant VE for CountryCode
        /// </summary>
        public static readonly CountryCode VE = new CountryCode("VE");
        /// <summary>
        /// Constant VG for CountryCode
        /// </summary>
        public static readonly CountryCode VG = new CountryCode("VG");
        /// <summary>
        /// Constant VI for CountryCode
        /// </summary>
        public static readonly CountryCode VI = new CountryCode("VI");
        /// <summary>
        /// Constant VN for CountryCode
        /// </summary>
        public static readonly CountryCode VN = new CountryCode("VN");
        /// <summary>
        /// Constant VU for CountryCode
        /// </summary>
        public static readonly CountryCode VU = new CountryCode("VU");
        /// <summary>
        /// Constant WF for CountryCode
        /// </summary>
        public static readonly CountryCode WF = new CountryCode("WF");
        /// <summary>
        /// Constant WS for CountryCode
        /// </summary>
        public static readonly CountryCode WS = new CountryCode("WS");
        /// <summary>
        /// Constant YE for CountryCode
        /// </summary>
        public static readonly CountryCode YE = new CountryCode("YE");
        /// <summary>
        /// Constant YT for CountryCode
        /// </summary>
        public static readonly CountryCode YT = new CountryCode("YT");
        /// <summary>
        /// Constant ZA for CountryCode
        /// </summary>
        public static readonly CountryCode ZA = new CountryCode("ZA");
        /// <summary>
        /// Constant ZM for CountryCode
        /// </summary>
        public static readonly CountryCode ZM = new CountryCode("ZM");
        /// <summary>
        /// Constant ZW for CountryCode
        /// </summary>
        public static readonly CountryCode ZW = new CountryCode("ZW");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CountryCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CountryCode FindValue(string value)
        {
            return FindValue<CountryCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CountryCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CurrencyCode.
    /// </summary>
    public class CurrencyCode : ConstantClass
    {

        /// <summary>
        /// Constant AED for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode AED = new CurrencyCode("AED");
        /// <summary>
        /// Constant AFN for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode AFN = new CurrencyCode("AFN");
        /// <summary>
        /// Constant ALL for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode ALL = new CurrencyCode("ALL");
        /// <summary>
        /// Constant AMD for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode AMD = new CurrencyCode("AMD");
        /// <summary>
        /// Constant ANG for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode ANG = new CurrencyCode("ANG");
        /// <summary>
        /// Constant AOA for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode AOA = new CurrencyCode("AOA");
        /// <summary>
        /// Constant ARS for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode ARS = new CurrencyCode("ARS");
        /// <summary>
        /// Constant AUD for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode AUD = new CurrencyCode("AUD");
        /// <summary>
        /// Constant AWG for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode AWG = new CurrencyCode("AWG");
        /// <summary>
        /// Constant AZN for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode AZN = new CurrencyCode("AZN");
        /// <summary>
        /// Constant BAM for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode BAM = new CurrencyCode("BAM");
        /// <summary>
        /// Constant BBD for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode BBD = new CurrencyCode("BBD");
        /// <summary>
        /// Constant BDT for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode BDT = new CurrencyCode("BDT");
        /// <summary>
        /// Constant BGN for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode BGN = new CurrencyCode("BGN");
        /// <summary>
        /// Constant BHD for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode BHD = new CurrencyCode("BHD");
        /// <summary>
        /// Constant BIF for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode BIF = new CurrencyCode("BIF");
        /// <summary>
        /// Constant BMD for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode BMD = new CurrencyCode("BMD");
        /// <summary>
        /// Constant BND for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode BND = new CurrencyCode("BND");
        /// <summary>
        /// Constant BOB for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode BOB = new CurrencyCode("BOB");
        /// <summary>
        /// Constant BOV for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode BOV = new CurrencyCode("BOV");
        /// <summary>
        /// Constant BRL for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode BRL = new CurrencyCode("BRL");
        /// <summary>
        /// Constant BSD for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode BSD = new CurrencyCode("BSD");
        /// <summary>
        /// Constant BTN for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode BTN = new CurrencyCode("BTN");
        /// <summary>
        /// Constant BWP for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode BWP = new CurrencyCode("BWP");
        /// <summary>
        /// Constant BYN for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode BYN = new CurrencyCode("BYN");
        /// <summary>
        /// Constant BZD for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode BZD = new CurrencyCode("BZD");
        /// <summary>
        /// Constant CAD for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode CAD = new CurrencyCode("CAD");
        /// <summary>
        /// Constant CDF for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode CDF = new CurrencyCode("CDF");
        /// <summary>
        /// Constant CHE for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode CHE = new CurrencyCode("CHE");
        /// <summary>
        /// Constant CHF for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode CHF = new CurrencyCode("CHF");
        /// <summary>
        /// Constant CHW for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode CHW = new CurrencyCode("CHW");
        /// <summary>
        /// Constant CLF for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode CLF = new CurrencyCode("CLF");
        /// <summary>
        /// Constant CLP for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode CLP = new CurrencyCode("CLP");
        /// <summary>
        /// Constant CNY for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode CNY = new CurrencyCode("CNY");
        /// <summary>
        /// Constant COP for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode COP = new CurrencyCode("COP");
        /// <summary>
        /// Constant COU for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode COU = new CurrencyCode("COU");
        /// <summary>
        /// Constant CRC for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode CRC = new CurrencyCode("CRC");
        /// <summary>
        /// Constant CUC for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode CUC = new CurrencyCode("CUC");
        /// <summary>
        /// Constant CUP for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode CUP = new CurrencyCode("CUP");
        /// <summary>
        /// Constant CVE for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode CVE = new CurrencyCode("CVE");
        /// <summary>
        /// Constant CZK for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode CZK = new CurrencyCode("CZK");
        /// <summary>
        /// Constant DJF for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode DJF = new CurrencyCode("DJF");
        /// <summary>
        /// Constant DKK for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode DKK = new CurrencyCode("DKK");
        /// <summary>
        /// Constant DOP for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode DOP = new CurrencyCode("DOP");
        /// <summary>
        /// Constant DZD for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode DZD = new CurrencyCode("DZD");
        /// <summary>
        /// Constant EGP for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode EGP = new CurrencyCode("EGP");
        /// <summary>
        /// Constant ERN for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode ERN = new CurrencyCode("ERN");
        /// <summary>
        /// Constant ETB for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode ETB = new CurrencyCode("ETB");
        /// <summary>
        /// Constant EUR for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode EUR = new CurrencyCode("EUR");
        /// <summary>
        /// Constant FJD for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode FJD = new CurrencyCode("FJD");
        /// <summary>
        /// Constant FKP for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode FKP = new CurrencyCode("FKP");
        /// <summary>
        /// Constant GBP for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode GBP = new CurrencyCode("GBP");
        /// <summary>
        /// Constant GEL for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode GEL = new CurrencyCode("GEL");
        /// <summary>
        /// Constant GHS for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode GHS = new CurrencyCode("GHS");
        /// <summary>
        /// Constant GIP for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode GIP = new CurrencyCode("GIP");
        /// <summary>
        /// Constant GMD for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode GMD = new CurrencyCode("GMD");
        /// <summary>
        /// Constant GNF for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode GNF = new CurrencyCode("GNF");
        /// <summary>
        /// Constant GTQ for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode GTQ = new CurrencyCode("GTQ");
        /// <summary>
        /// Constant GYD for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode GYD = new CurrencyCode("GYD");
        /// <summary>
        /// Constant HKD for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode HKD = new CurrencyCode("HKD");
        /// <summary>
        /// Constant HNL for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode HNL = new CurrencyCode("HNL");
        /// <summary>
        /// Constant HRK for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode HRK = new CurrencyCode("HRK");
        /// <summary>
        /// Constant HTG for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode HTG = new CurrencyCode("HTG");
        /// <summary>
        /// Constant HUF for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode HUF = new CurrencyCode("HUF");
        /// <summary>
        /// Constant IDR for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode IDR = new CurrencyCode("IDR");
        /// <summary>
        /// Constant ILS for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode ILS = new CurrencyCode("ILS");
        /// <summary>
        /// Constant INR for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode INR = new CurrencyCode("INR");
        /// <summary>
        /// Constant IQD for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode IQD = new CurrencyCode("IQD");
        /// <summary>
        /// Constant IRR for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode IRR = new CurrencyCode("IRR");
        /// <summary>
        /// Constant ISK for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode ISK = new CurrencyCode("ISK");
        /// <summary>
        /// Constant JMD for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode JMD = new CurrencyCode("JMD");
        /// <summary>
        /// Constant JOD for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode JOD = new CurrencyCode("JOD");
        /// <summary>
        /// Constant JPY for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode JPY = new CurrencyCode("JPY");
        /// <summary>
        /// Constant KES for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode KES = new CurrencyCode("KES");
        /// <summary>
        /// Constant KGS for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode KGS = new CurrencyCode("KGS");
        /// <summary>
        /// Constant KHR for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode KHR = new CurrencyCode("KHR");
        /// <summary>
        /// Constant KMF for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode KMF = new CurrencyCode("KMF");
        /// <summary>
        /// Constant KPW for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode KPW = new CurrencyCode("KPW");
        /// <summary>
        /// Constant KRW for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode KRW = new CurrencyCode("KRW");
        /// <summary>
        /// Constant KWD for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode KWD = new CurrencyCode("KWD");
        /// <summary>
        /// Constant KYD for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode KYD = new CurrencyCode("KYD");
        /// <summary>
        /// Constant KZT for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode KZT = new CurrencyCode("KZT");
        /// <summary>
        /// Constant LAK for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode LAK = new CurrencyCode("LAK");
        /// <summary>
        /// Constant LBP for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode LBP = new CurrencyCode("LBP");
        /// <summary>
        /// Constant LKR for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode LKR = new CurrencyCode("LKR");
        /// <summary>
        /// Constant LRD for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode LRD = new CurrencyCode("LRD");
        /// <summary>
        /// Constant LSL for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode LSL = new CurrencyCode("LSL");
        /// <summary>
        /// Constant LYD for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode LYD = new CurrencyCode("LYD");
        /// <summary>
        /// Constant MAD for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode MAD = new CurrencyCode("MAD");
        /// <summary>
        /// Constant MDL for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode MDL = new CurrencyCode("MDL");
        /// <summary>
        /// Constant MGA for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode MGA = new CurrencyCode("MGA");
        /// <summary>
        /// Constant MKD for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode MKD = new CurrencyCode("MKD");
        /// <summary>
        /// Constant MMK for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode MMK = new CurrencyCode("MMK");
        /// <summary>
        /// Constant MNT for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode MNT = new CurrencyCode("MNT");
        /// <summary>
        /// Constant MOP for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode MOP = new CurrencyCode("MOP");
        /// <summary>
        /// Constant MRU for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode MRU = new CurrencyCode("MRU");
        /// <summary>
        /// Constant MUR for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode MUR = new CurrencyCode("MUR");
        /// <summary>
        /// Constant MVR for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode MVR = new CurrencyCode("MVR");
        /// <summary>
        /// Constant MWK for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode MWK = new CurrencyCode("MWK");
        /// <summary>
        /// Constant MXN for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode MXN = new CurrencyCode("MXN");
        /// <summary>
        /// Constant MXV for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode MXV = new CurrencyCode("MXV");
        /// <summary>
        /// Constant MYR for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode MYR = new CurrencyCode("MYR");
        /// <summary>
        /// Constant MZN for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode MZN = new CurrencyCode("MZN");
        /// <summary>
        /// Constant NAD for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode NAD = new CurrencyCode("NAD");
        /// <summary>
        /// Constant NGN for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode NGN = new CurrencyCode("NGN");
        /// <summary>
        /// Constant NIO for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode NIO = new CurrencyCode("NIO");
        /// <summary>
        /// Constant NOK for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode NOK = new CurrencyCode("NOK");
        /// <summary>
        /// Constant NPR for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode NPR = new CurrencyCode("NPR");
        /// <summary>
        /// Constant NZD for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode NZD = new CurrencyCode("NZD");
        /// <summary>
        /// Constant OMR for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode OMR = new CurrencyCode("OMR");
        /// <summary>
        /// Constant PAB for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode PAB = new CurrencyCode("PAB");
        /// <summary>
        /// Constant PEN for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode PEN = new CurrencyCode("PEN");
        /// <summary>
        /// Constant PGK for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode PGK = new CurrencyCode("PGK");
        /// <summary>
        /// Constant PHP for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode PHP = new CurrencyCode("PHP");
        /// <summary>
        /// Constant PKR for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode PKR = new CurrencyCode("PKR");
        /// <summary>
        /// Constant PLN for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode PLN = new CurrencyCode("PLN");
        /// <summary>
        /// Constant PYG for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode PYG = new CurrencyCode("PYG");
        /// <summary>
        /// Constant QAR for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode QAR = new CurrencyCode("QAR");
        /// <summary>
        /// Constant RON for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode RON = new CurrencyCode("RON");
        /// <summary>
        /// Constant RSD for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode RSD = new CurrencyCode("RSD");
        /// <summary>
        /// Constant RUB for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode RUB = new CurrencyCode("RUB");
        /// <summary>
        /// Constant RWF for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode RWF = new CurrencyCode("RWF");
        /// <summary>
        /// Constant SAR for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode SAR = new CurrencyCode("SAR");
        /// <summary>
        /// Constant SBD for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode SBD = new CurrencyCode("SBD");
        /// <summary>
        /// Constant SCR for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode SCR = new CurrencyCode("SCR");
        /// <summary>
        /// Constant SDG for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode SDG = new CurrencyCode("SDG");
        /// <summary>
        /// Constant SEK for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode SEK = new CurrencyCode("SEK");
        /// <summary>
        /// Constant SGD for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode SGD = new CurrencyCode("SGD");
        /// <summary>
        /// Constant SHP for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode SHP = new CurrencyCode("SHP");
        /// <summary>
        /// Constant SLL for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode SLL = new CurrencyCode("SLL");
        /// <summary>
        /// Constant SOS for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode SOS = new CurrencyCode("SOS");
        /// <summary>
        /// Constant SRD for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode SRD = new CurrencyCode("SRD");
        /// <summary>
        /// Constant SSP for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode SSP = new CurrencyCode("SSP");
        /// <summary>
        /// Constant STN for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode STN = new CurrencyCode("STN");
        /// <summary>
        /// Constant SVC for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode SVC = new CurrencyCode("SVC");
        /// <summary>
        /// Constant SYP for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode SYP = new CurrencyCode("SYP");
        /// <summary>
        /// Constant SZL for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode SZL = new CurrencyCode("SZL");
        /// <summary>
        /// Constant THB for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode THB = new CurrencyCode("THB");
        /// <summary>
        /// Constant TJS for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode TJS = new CurrencyCode("TJS");
        /// <summary>
        /// Constant TMT for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode TMT = new CurrencyCode("TMT");
        /// <summary>
        /// Constant TND for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode TND = new CurrencyCode("TND");
        /// <summary>
        /// Constant TOP for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode TOP = new CurrencyCode("TOP");
        /// <summary>
        /// Constant TRY for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode TRY = new CurrencyCode("TRY");
        /// <summary>
        /// Constant TTD for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode TTD = new CurrencyCode("TTD");
        /// <summary>
        /// Constant TWD for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode TWD = new CurrencyCode("TWD");
        /// <summary>
        /// Constant TZS for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode TZS = new CurrencyCode("TZS");
        /// <summary>
        /// Constant UAH for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode UAH = new CurrencyCode("UAH");
        /// <summary>
        /// Constant UGX for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode UGX = new CurrencyCode("UGX");
        /// <summary>
        /// Constant USD for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode USD = new CurrencyCode("USD");
        /// <summary>
        /// Constant USN for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode USN = new CurrencyCode("USN");
        /// <summary>
        /// Constant UYI for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode UYI = new CurrencyCode("UYI");
        /// <summary>
        /// Constant UYU for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode UYU = new CurrencyCode("UYU");
        /// <summary>
        /// Constant UZS for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode UZS = new CurrencyCode("UZS");
        /// <summary>
        /// Constant VEF for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode VEF = new CurrencyCode("VEF");
        /// <summary>
        /// Constant VND for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode VND = new CurrencyCode("VND");
        /// <summary>
        /// Constant VUV for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode VUV = new CurrencyCode("VUV");
        /// <summary>
        /// Constant WST for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode WST = new CurrencyCode("WST");
        /// <summary>
        /// Constant XAF for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode XAF = new CurrencyCode("XAF");
        /// <summary>
        /// Constant XCD for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode XCD = new CurrencyCode("XCD");
        /// <summary>
        /// Constant XDR for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode XDR = new CurrencyCode("XDR");
        /// <summary>
        /// Constant XOF for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode XOF = new CurrencyCode("XOF");
        /// <summary>
        /// Constant XPF for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode XPF = new CurrencyCode("XPF");
        /// <summary>
        /// Constant XSU for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode XSU = new CurrencyCode("XSU");
        /// <summary>
        /// Constant XUA for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode XUA = new CurrencyCode("XUA");
        /// <summary>
        /// Constant YER for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode YER = new CurrencyCode("YER");
        /// <summary>
        /// Constant ZAR for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode ZAR = new CurrencyCode("ZAR");
        /// <summary>
        /// Constant ZMW for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode ZMW = new CurrencyCode("ZMW");
        /// <summary>
        /// Constant ZWL for CurrencyCode
        /// </summary>
        public static readonly CurrencyCode ZWL = new CurrencyCode("ZWL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CurrencyCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CurrencyCode FindValue(string value)
        {
            return FindValue<CurrencyCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CurrencyCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DeliveryModel.
    /// </summary>
    public class DeliveryModel : ConstantClass
    {

        /// <summary>
        /// Constant BYOLOrAMI for DeliveryModel
        /// </summary>
        public static readonly DeliveryModel BYOLOrAMI = new DeliveryModel("BYOL or AMI");
        /// <summary>
        /// Constant ManagedServices for DeliveryModel
        /// </summary>
        public static readonly DeliveryModel ManagedServices = new DeliveryModel("Managed Services");
        /// <summary>
        /// Constant Other for DeliveryModel
        /// </summary>
        public static readonly DeliveryModel Other = new DeliveryModel("Other");
        /// <summary>
        /// Constant ProfessionalServices for DeliveryModel
        /// </summary>
        public static readonly DeliveryModel ProfessionalServices = new DeliveryModel("Professional Services");
        /// <summary>
        /// Constant Resell for DeliveryModel
        /// </summary>
        public static readonly DeliveryModel Resell = new DeliveryModel("Resell");
        /// <summary>
        /// Constant SaaSOrPaaS for DeliveryModel
        /// </summary>
        public static readonly DeliveryModel SaaSOrPaaS = new DeliveryModel("SaaS or PaaS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DeliveryModel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DeliveryModel FindValue(string value)
        {
            return FindValue<DeliveryModel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DeliveryModel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EngagementContextType.
    /// </summary>
    public class EngagementContextType : ConstantClass
    {

        /// <summary>
        /// Constant CustomerProject for EngagementContextType
        /// </summary>
        public static readonly EngagementContextType CustomerProject = new EngagementContextType("CustomerProject");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EngagementContextType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EngagementContextType FindValue(string value)
        {
            return FindValue<EngagementContextType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EngagementContextType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EngagementInvitationPayloadType.
    /// </summary>
    public class EngagementInvitationPayloadType : ConstantClass
    {

        /// <summary>
        /// Constant OpportunityInvitation for EngagementInvitationPayloadType
        /// </summary>
        public static readonly EngagementInvitationPayloadType OpportunityInvitation = new EngagementInvitationPayloadType("OpportunityInvitation");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EngagementInvitationPayloadType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EngagementInvitationPayloadType FindValue(string value)
        {
            return FindValue<EngagementInvitationPayloadType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EngagementInvitationPayloadType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EngagementScore.
    /// </summary>
    public class EngagementScore : ConstantClass
    {

        /// <summary>
        /// Constant High for EngagementScore
        /// </summary>
        public static readonly EngagementScore High = new EngagementScore("High");
        /// <summary>
        /// Constant Low for EngagementScore
        /// </summary>
        public static readonly EngagementScore Low = new EngagementScore("Low");
        /// <summary>
        /// Constant Medium for EngagementScore
        /// </summary>
        public static readonly EngagementScore Medium = new EngagementScore("Medium");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EngagementScore(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EngagementScore FindValue(string value)
        {
            return FindValue<EngagementScore>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EngagementScore(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EngagementSortName.
    /// </summary>
    public class EngagementSortName : ConstantClass
    {

        /// <summary>
        /// Constant CreatedDate for EngagementSortName
        /// </summary>
        public static readonly EngagementSortName CreatedDate = new EngagementSortName("CreatedDate");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EngagementSortName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EngagementSortName FindValue(string value)
        {
            return FindValue<EngagementSortName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EngagementSortName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ExpectedCustomerSpendCurrencyCodeEnum.
    /// </summary>
    public class ExpectedCustomerSpendCurrencyCodeEnum : ConstantClass
    {

        /// <summary>
        /// Constant AED for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum AED = new ExpectedCustomerSpendCurrencyCodeEnum("AED");
        /// <summary>
        /// Constant AFN for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum AFN = new ExpectedCustomerSpendCurrencyCodeEnum("AFN");
        /// <summary>
        /// Constant ALL for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum ALL = new ExpectedCustomerSpendCurrencyCodeEnum("ALL");
        /// <summary>
        /// Constant AMD for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum AMD = new ExpectedCustomerSpendCurrencyCodeEnum("AMD");
        /// <summary>
        /// Constant ANG for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum ANG = new ExpectedCustomerSpendCurrencyCodeEnum("ANG");
        /// <summary>
        /// Constant AOA for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum AOA = new ExpectedCustomerSpendCurrencyCodeEnum("AOA");
        /// <summary>
        /// Constant ARS for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum ARS = new ExpectedCustomerSpendCurrencyCodeEnum("ARS");
        /// <summary>
        /// Constant AUD for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum AUD = new ExpectedCustomerSpendCurrencyCodeEnum("AUD");
        /// <summary>
        /// Constant AWG for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum AWG = new ExpectedCustomerSpendCurrencyCodeEnum("AWG");
        /// <summary>
        /// Constant AZN for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum AZN = new ExpectedCustomerSpendCurrencyCodeEnum("AZN");
        /// <summary>
        /// Constant BAM for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum BAM = new ExpectedCustomerSpendCurrencyCodeEnum("BAM");
        /// <summary>
        /// Constant BBD for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum BBD = new ExpectedCustomerSpendCurrencyCodeEnum("BBD");
        /// <summary>
        /// Constant BDT for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum BDT = new ExpectedCustomerSpendCurrencyCodeEnum("BDT");
        /// <summary>
        /// Constant BGN for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum BGN = new ExpectedCustomerSpendCurrencyCodeEnum("BGN");
        /// <summary>
        /// Constant BHD for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum BHD = new ExpectedCustomerSpendCurrencyCodeEnum("BHD");
        /// <summary>
        /// Constant BIF for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum BIF = new ExpectedCustomerSpendCurrencyCodeEnum("BIF");
        /// <summary>
        /// Constant BMD for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum BMD = new ExpectedCustomerSpendCurrencyCodeEnum("BMD");
        /// <summary>
        /// Constant BND for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum BND = new ExpectedCustomerSpendCurrencyCodeEnum("BND");
        /// <summary>
        /// Constant BOB for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum BOB = new ExpectedCustomerSpendCurrencyCodeEnum("BOB");
        /// <summary>
        /// Constant BOV for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum BOV = new ExpectedCustomerSpendCurrencyCodeEnum("BOV");
        /// <summary>
        /// Constant BRL for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum BRL = new ExpectedCustomerSpendCurrencyCodeEnum("BRL");
        /// <summary>
        /// Constant BSD for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum BSD = new ExpectedCustomerSpendCurrencyCodeEnum("BSD");
        /// <summary>
        /// Constant BTN for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum BTN = new ExpectedCustomerSpendCurrencyCodeEnum("BTN");
        /// <summary>
        /// Constant BWP for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum BWP = new ExpectedCustomerSpendCurrencyCodeEnum("BWP");
        /// <summary>
        /// Constant BYN for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum BYN = new ExpectedCustomerSpendCurrencyCodeEnum("BYN");
        /// <summary>
        /// Constant BZD for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum BZD = new ExpectedCustomerSpendCurrencyCodeEnum("BZD");
        /// <summary>
        /// Constant CAD for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum CAD = new ExpectedCustomerSpendCurrencyCodeEnum("CAD");
        /// <summary>
        /// Constant CDF for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum CDF = new ExpectedCustomerSpendCurrencyCodeEnum("CDF");
        /// <summary>
        /// Constant CHE for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum CHE = new ExpectedCustomerSpendCurrencyCodeEnum("CHE");
        /// <summary>
        /// Constant CHF for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum CHF = new ExpectedCustomerSpendCurrencyCodeEnum("CHF");
        /// <summary>
        /// Constant CHW for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum CHW = new ExpectedCustomerSpendCurrencyCodeEnum("CHW");
        /// <summary>
        /// Constant CLF for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum CLF = new ExpectedCustomerSpendCurrencyCodeEnum("CLF");
        /// <summary>
        /// Constant CLP for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum CLP = new ExpectedCustomerSpendCurrencyCodeEnum("CLP");
        /// <summary>
        /// Constant CNY for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum CNY = new ExpectedCustomerSpendCurrencyCodeEnum("CNY");
        /// <summary>
        /// Constant COP for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum COP = new ExpectedCustomerSpendCurrencyCodeEnum("COP");
        /// <summary>
        /// Constant COU for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum COU = new ExpectedCustomerSpendCurrencyCodeEnum("COU");
        /// <summary>
        /// Constant CRC for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum CRC = new ExpectedCustomerSpendCurrencyCodeEnum("CRC");
        /// <summary>
        /// Constant CUC for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum CUC = new ExpectedCustomerSpendCurrencyCodeEnum("CUC");
        /// <summary>
        /// Constant CUP for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum CUP = new ExpectedCustomerSpendCurrencyCodeEnum("CUP");
        /// <summary>
        /// Constant CVE for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum CVE = new ExpectedCustomerSpendCurrencyCodeEnum("CVE");
        /// <summary>
        /// Constant CZK for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum CZK = new ExpectedCustomerSpendCurrencyCodeEnum("CZK");
        /// <summary>
        /// Constant DJF for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum DJF = new ExpectedCustomerSpendCurrencyCodeEnum("DJF");
        /// <summary>
        /// Constant DKK for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum DKK = new ExpectedCustomerSpendCurrencyCodeEnum("DKK");
        /// <summary>
        /// Constant DOP for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum DOP = new ExpectedCustomerSpendCurrencyCodeEnum("DOP");
        /// <summary>
        /// Constant DZD for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum DZD = new ExpectedCustomerSpendCurrencyCodeEnum("DZD");
        /// <summary>
        /// Constant EGP for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum EGP = new ExpectedCustomerSpendCurrencyCodeEnum("EGP");
        /// <summary>
        /// Constant ERN for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum ERN = new ExpectedCustomerSpendCurrencyCodeEnum("ERN");
        /// <summary>
        /// Constant ETB for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum ETB = new ExpectedCustomerSpendCurrencyCodeEnum("ETB");
        /// <summary>
        /// Constant EUR for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum EUR = new ExpectedCustomerSpendCurrencyCodeEnum("EUR");
        /// <summary>
        /// Constant FJD for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum FJD = new ExpectedCustomerSpendCurrencyCodeEnum("FJD");
        /// <summary>
        /// Constant FKP for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum FKP = new ExpectedCustomerSpendCurrencyCodeEnum("FKP");
        /// <summary>
        /// Constant GBP for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum GBP = new ExpectedCustomerSpendCurrencyCodeEnum("GBP");
        /// <summary>
        /// Constant GEL for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum GEL = new ExpectedCustomerSpendCurrencyCodeEnum("GEL");
        /// <summary>
        /// Constant GHS for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum GHS = new ExpectedCustomerSpendCurrencyCodeEnum("GHS");
        /// <summary>
        /// Constant GIP for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum GIP = new ExpectedCustomerSpendCurrencyCodeEnum("GIP");
        /// <summary>
        /// Constant GMD for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum GMD = new ExpectedCustomerSpendCurrencyCodeEnum("GMD");
        /// <summary>
        /// Constant GNF for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum GNF = new ExpectedCustomerSpendCurrencyCodeEnum("GNF");
        /// <summary>
        /// Constant GTQ for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum GTQ = new ExpectedCustomerSpendCurrencyCodeEnum("GTQ");
        /// <summary>
        /// Constant GYD for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum GYD = new ExpectedCustomerSpendCurrencyCodeEnum("GYD");
        /// <summary>
        /// Constant HKD for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum HKD = new ExpectedCustomerSpendCurrencyCodeEnum("HKD");
        /// <summary>
        /// Constant HNL for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum HNL = new ExpectedCustomerSpendCurrencyCodeEnum("HNL");
        /// <summary>
        /// Constant HRK for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum HRK = new ExpectedCustomerSpendCurrencyCodeEnum("HRK");
        /// <summary>
        /// Constant HTG for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum HTG = new ExpectedCustomerSpendCurrencyCodeEnum("HTG");
        /// <summary>
        /// Constant HUF for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum HUF = new ExpectedCustomerSpendCurrencyCodeEnum("HUF");
        /// <summary>
        /// Constant IDR for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum IDR = new ExpectedCustomerSpendCurrencyCodeEnum("IDR");
        /// <summary>
        /// Constant ILS for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum ILS = new ExpectedCustomerSpendCurrencyCodeEnum("ILS");
        /// <summary>
        /// Constant INR for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum INR = new ExpectedCustomerSpendCurrencyCodeEnum("INR");
        /// <summary>
        /// Constant IQD for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum IQD = new ExpectedCustomerSpendCurrencyCodeEnum("IQD");
        /// <summary>
        /// Constant IRR for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum IRR = new ExpectedCustomerSpendCurrencyCodeEnum("IRR");
        /// <summary>
        /// Constant ISK for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum ISK = new ExpectedCustomerSpendCurrencyCodeEnum("ISK");
        /// <summary>
        /// Constant JMD for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum JMD = new ExpectedCustomerSpendCurrencyCodeEnum("JMD");
        /// <summary>
        /// Constant JOD for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum JOD = new ExpectedCustomerSpendCurrencyCodeEnum("JOD");
        /// <summary>
        /// Constant JPY for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum JPY = new ExpectedCustomerSpendCurrencyCodeEnum("JPY");
        /// <summary>
        /// Constant KES for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum KES = new ExpectedCustomerSpendCurrencyCodeEnum("KES");
        /// <summary>
        /// Constant KGS for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum KGS = new ExpectedCustomerSpendCurrencyCodeEnum("KGS");
        /// <summary>
        /// Constant KHR for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum KHR = new ExpectedCustomerSpendCurrencyCodeEnum("KHR");
        /// <summary>
        /// Constant KMF for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum KMF = new ExpectedCustomerSpendCurrencyCodeEnum("KMF");
        /// <summary>
        /// Constant KPW for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum KPW = new ExpectedCustomerSpendCurrencyCodeEnum("KPW");
        /// <summary>
        /// Constant KRW for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum KRW = new ExpectedCustomerSpendCurrencyCodeEnum("KRW");
        /// <summary>
        /// Constant KWD for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum KWD = new ExpectedCustomerSpendCurrencyCodeEnum("KWD");
        /// <summary>
        /// Constant KYD for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum KYD = new ExpectedCustomerSpendCurrencyCodeEnum("KYD");
        /// <summary>
        /// Constant KZT for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum KZT = new ExpectedCustomerSpendCurrencyCodeEnum("KZT");
        /// <summary>
        /// Constant LAK for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum LAK = new ExpectedCustomerSpendCurrencyCodeEnum("LAK");
        /// <summary>
        /// Constant LBP for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum LBP = new ExpectedCustomerSpendCurrencyCodeEnum("LBP");
        /// <summary>
        /// Constant LKR for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum LKR = new ExpectedCustomerSpendCurrencyCodeEnum("LKR");
        /// <summary>
        /// Constant LRD for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum LRD = new ExpectedCustomerSpendCurrencyCodeEnum("LRD");
        /// <summary>
        /// Constant LSL for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum LSL = new ExpectedCustomerSpendCurrencyCodeEnum("LSL");
        /// <summary>
        /// Constant LYD for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum LYD = new ExpectedCustomerSpendCurrencyCodeEnum("LYD");
        /// <summary>
        /// Constant MAD for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum MAD = new ExpectedCustomerSpendCurrencyCodeEnum("MAD");
        /// <summary>
        /// Constant MDL for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum MDL = new ExpectedCustomerSpendCurrencyCodeEnum("MDL");
        /// <summary>
        /// Constant MGA for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum MGA = new ExpectedCustomerSpendCurrencyCodeEnum("MGA");
        /// <summary>
        /// Constant MKD for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum MKD = new ExpectedCustomerSpendCurrencyCodeEnum("MKD");
        /// <summary>
        /// Constant MMK for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum MMK = new ExpectedCustomerSpendCurrencyCodeEnum("MMK");
        /// <summary>
        /// Constant MNT for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum MNT = new ExpectedCustomerSpendCurrencyCodeEnum("MNT");
        /// <summary>
        /// Constant MOP for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum MOP = new ExpectedCustomerSpendCurrencyCodeEnum("MOP");
        /// <summary>
        /// Constant MRU for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum MRU = new ExpectedCustomerSpendCurrencyCodeEnum("MRU");
        /// <summary>
        /// Constant MUR for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum MUR = new ExpectedCustomerSpendCurrencyCodeEnum("MUR");
        /// <summary>
        /// Constant MVR for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum MVR = new ExpectedCustomerSpendCurrencyCodeEnum("MVR");
        /// <summary>
        /// Constant MWK for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum MWK = new ExpectedCustomerSpendCurrencyCodeEnum("MWK");
        /// <summary>
        /// Constant MXN for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum MXN = new ExpectedCustomerSpendCurrencyCodeEnum("MXN");
        /// <summary>
        /// Constant MXV for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum MXV = new ExpectedCustomerSpendCurrencyCodeEnum("MXV");
        /// <summary>
        /// Constant MYR for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum MYR = new ExpectedCustomerSpendCurrencyCodeEnum("MYR");
        /// <summary>
        /// Constant MZN for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum MZN = new ExpectedCustomerSpendCurrencyCodeEnum("MZN");
        /// <summary>
        /// Constant NAD for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum NAD = new ExpectedCustomerSpendCurrencyCodeEnum("NAD");
        /// <summary>
        /// Constant NGN for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum NGN = new ExpectedCustomerSpendCurrencyCodeEnum("NGN");
        /// <summary>
        /// Constant NIO for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum NIO = new ExpectedCustomerSpendCurrencyCodeEnum("NIO");
        /// <summary>
        /// Constant NOK for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum NOK = new ExpectedCustomerSpendCurrencyCodeEnum("NOK");
        /// <summary>
        /// Constant NPR for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum NPR = new ExpectedCustomerSpendCurrencyCodeEnum("NPR");
        /// <summary>
        /// Constant NZD for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum NZD = new ExpectedCustomerSpendCurrencyCodeEnum("NZD");
        /// <summary>
        /// Constant OMR for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum OMR = new ExpectedCustomerSpendCurrencyCodeEnum("OMR");
        /// <summary>
        /// Constant PAB for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum PAB = new ExpectedCustomerSpendCurrencyCodeEnum("PAB");
        /// <summary>
        /// Constant PEN for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum PEN = new ExpectedCustomerSpendCurrencyCodeEnum("PEN");
        /// <summary>
        /// Constant PGK for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum PGK = new ExpectedCustomerSpendCurrencyCodeEnum("PGK");
        /// <summary>
        /// Constant PHP for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum PHP = new ExpectedCustomerSpendCurrencyCodeEnum("PHP");
        /// <summary>
        /// Constant PKR for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum PKR = new ExpectedCustomerSpendCurrencyCodeEnum("PKR");
        /// <summary>
        /// Constant PLN for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum PLN = new ExpectedCustomerSpendCurrencyCodeEnum("PLN");
        /// <summary>
        /// Constant PYG for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum PYG = new ExpectedCustomerSpendCurrencyCodeEnum("PYG");
        /// <summary>
        /// Constant QAR for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum QAR = new ExpectedCustomerSpendCurrencyCodeEnum("QAR");
        /// <summary>
        /// Constant RON for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum RON = new ExpectedCustomerSpendCurrencyCodeEnum("RON");
        /// <summary>
        /// Constant RSD for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum RSD = new ExpectedCustomerSpendCurrencyCodeEnum("RSD");
        /// <summary>
        /// Constant RUB for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum RUB = new ExpectedCustomerSpendCurrencyCodeEnum("RUB");
        /// <summary>
        /// Constant RWF for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum RWF = new ExpectedCustomerSpendCurrencyCodeEnum("RWF");
        /// <summary>
        /// Constant SAR for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum SAR = new ExpectedCustomerSpendCurrencyCodeEnum("SAR");
        /// <summary>
        /// Constant SBD for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum SBD = new ExpectedCustomerSpendCurrencyCodeEnum("SBD");
        /// <summary>
        /// Constant SCR for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum SCR = new ExpectedCustomerSpendCurrencyCodeEnum("SCR");
        /// <summary>
        /// Constant SDG for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum SDG = new ExpectedCustomerSpendCurrencyCodeEnum("SDG");
        /// <summary>
        /// Constant SEK for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum SEK = new ExpectedCustomerSpendCurrencyCodeEnum("SEK");
        /// <summary>
        /// Constant SGD for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum SGD = new ExpectedCustomerSpendCurrencyCodeEnum("SGD");
        /// <summary>
        /// Constant SHP for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum SHP = new ExpectedCustomerSpendCurrencyCodeEnum("SHP");
        /// <summary>
        /// Constant SLL for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum SLL = new ExpectedCustomerSpendCurrencyCodeEnum("SLL");
        /// <summary>
        /// Constant SOS for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum SOS = new ExpectedCustomerSpendCurrencyCodeEnum("SOS");
        /// <summary>
        /// Constant SRD for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum SRD = new ExpectedCustomerSpendCurrencyCodeEnum("SRD");
        /// <summary>
        /// Constant SSP for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum SSP = new ExpectedCustomerSpendCurrencyCodeEnum("SSP");
        /// <summary>
        /// Constant STN for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum STN = new ExpectedCustomerSpendCurrencyCodeEnum("STN");
        /// <summary>
        /// Constant SVC for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum SVC = new ExpectedCustomerSpendCurrencyCodeEnum("SVC");
        /// <summary>
        /// Constant SYP for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum SYP = new ExpectedCustomerSpendCurrencyCodeEnum("SYP");
        /// <summary>
        /// Constant SZL for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum SZL = new ExpectedCustomerSpendCurrencyCodeEnum("SZL");
        /// <summary>
        /// Constant THB for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum THB = new ExpectedCustomerSpendCurrencyCodeEnum("THB");
        /// <summary>
        /// Constant TJS for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum TJS = new ExpectedCustomerSpendCurrencyCodeEnum("TJS");
        /// <summary>
        /// Constant TMT for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum TMT = new ExpectedCustomerSpendCurrencyCodeEnum("TMT");
        /// <summary>
        /// Constant TND for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum TND = new ExpectedCustomerSpendCurrencyCodeEnum("TND");
        /// <summary>
        /// Constant TOP for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum TOP = new ExpectedCustomerSpendCurrencyCodeEnum("TOP");
        /// <summary>
        /// Constant TRY for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum TRY = new ExpectedCustomerSpendCurrencyCodeEnum("TRY");
        /// <summary>
        /// Constant TTD for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum TTD = new ExpectedCustomerSpendCurrencyCodeEnum("TTD");
        /// <summary>
        /// Constant TWD for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum TWD = new ExpectedCustomerSpendCurrencyCodeEnum("TWD");
        /// <summary>
        /// Constant TZS for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum TZS = new ExpectedCustomerSpendCurrencyCodeEnum("TZS");
        /// <summary>
        /// Constant UAH for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum UAH = new ExpectedCustomerSpendCurrencyCodeEnum("UAH");
        /// <summary>
        /// Constant UGX for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum UGX = new ExpectedCustomerSpendCurrencyCodeEnum("UGX");
        /// <summary>
        /// Constant USD for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum USD = new ExpectedCustomerSpendCurrencyCodeEnum("USD");
        /// <summary>
        /// Constant USN for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum USN = new ExpectedCustomerSpendCurrencyCodeEnum("USN");
        /// <summary>
        /// Constant UYI for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum UYI = new ExpectedCustomerSpendCurrencyCodeEnum("UYI");
        /// <summary>
        /// Constant UYU for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum UYU = new ExpectedCustomerSpendCurrencyCodeEnum("UYU");
        /// <summary>
        /// Constant UZS for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum UZS = new ExpectedCustomerSpendCurrencyCodeEnum("UZS");
        /// <summary>
        /// Constant VEF for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum VEF = new ExpectedCustomerSpendCurrencyCodeEnum("VEF");
        /// <summary>
        /// Constant VND for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum VND = new ExpectedCustomerSpendCurrencyCodeEnum("VND");
        /// <summary>
        /// Constant VUV for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum VUV = new ExpectedCustomerSpendCurrencyCodeEnum("VUV");
        /// <summary>
        /// Constant WST for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum WST = new ExpectedCustomerSpendCurrencyCodeEnum("WST");
        /// <summary>
        /// Constant XAF for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum XAF = new ExpectedCustomerSpendCurrencyCodeEnum("XAF");
        /// <summary>
        /// Constant XCD for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum XCD = new ExpectedCustomerSpendCurrencyCodeEnum("XCD");
        /// <summary>
        /// Constant XDR for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum XDR = new ExpectedCustomerSpendCurrencyCodeEnum("XDR");
        /// <summary>
        /// Constant XOF for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum XOF = new ExpectedCustomerSpendCurrencyCodeEnum("XOF");
        /// <summary>
        /// Constant XPF for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum XPF = new ExpectedCustomerSpendCurrencyCodeEnum("XPF");
        /// <summary>
        /// Constant XSU for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum XSU = new ExpectedCustomerSpendCurrencyCodeEnum("XSU");
        /// <summary>
        /// Constant XUA for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum XUA = new ExpectedCustomerSpendCurrencyCodeEnum("XUA");
        /// <summary>
        /// Constant YER for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum YER = new ExpectedCustomerSpendCurrencyCodeEnum("YER");
        /// <summary>
        /// Constant ZAR for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum ZAR = new ExpectedCustomerSpendCurrencyCodeEnum("ZAR");
        /// <summary>
        /// Constant ZMW for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum ZMW = new ExpectedCustomerSpendCurrencyCodeEnum("ZMW");
        /// <summary>
        /// Constant ZWL for ExpectedCustomerSpendCurrencyCodeEnum
        /// </summary>
        public static readonly ExpectedCustomerSpendCurrencyCodeEnum ZWL = new ExpectedCustomerSpendCurrencyCodeEnum("ZWL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ExpectedCustomerSpendCurrencyCodeEnum(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ExpectedCustomerSpendCurrencyCodeEnum FindValue(string value)
        {
            return FindValue<ExpectedCustomerSpendCurrencyCodeEnum>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ExpectedCustomerSpendCurrencyCodeEnum(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Industry.
    /// </summary>
    public class Industry : ConstantClass
    {

        /// <summary>
        /// Constant Aerospace for Industry
        /// </summary>
        public static readonly Industry Aerospace = new Industry("Aerospace");
        /// <summary>
        /// Constant Agriculture for Industry
        /// </summary>
        public static readonly Industry Agriculture = new Industry("Agriculture");
        /// <summary>
        /// Constant Automotive for Industry
        /// </summary>
        public static readonly Industry Automotive = new Industry("Automotive");
        /// <summary>
        /// Constant ComputersAndElectronics for Industry
        /// </summary>
        public static readonly Industry ComputersAndElectronics = new Industry("Computers and Electronics");
        /// <summary>
        /// Constant ConsumerGoods for Industry
        /// </summary>
        public static readonly Industry ConsumerGoods = new Industry("Consumer Goods");
        /// <summary>
        /// Constant Education for Industry
        /// </summary>
        public static readonly Industry Education = new Industry("Education");
        /// <summary>
        /// Constant EnergyOilAndGas for Industry
        /// </summary>
        public static readonly Industry EnergyOilAndGas = new Industry("Energy - Oil and Gas");
        /// <summary>
        /// Constant EnergyPowerAndUtilities for Industry
        /// </summary>
        public static readonly Industry EnergyPowerAndUtilities = new Industry("Energy - Power and Utilities");
        /// <summary>
        /// Constant FinancialServices for Industry
        /// </summary>
        public static readonly Industry FinancialServices = new Industry("Financial Services");
        /// <summary>
        /// Constant Gaming for Industry
        /// </summary>
        public static readonly Industry Gaming = new Industry("Gaming");
        /// <summary>
        /// Constant Government for Industry
        /// </summary>
        public static readonly Industry Government = new Industry("Government");
        /// <summary>
        /// Constant Healthcare for Industry
        /// </summary>
        public static readonly Industry Healthcare = new Industry("Healthcare");
        /// <summary>
        /// Constant Hospitality for Industry
        /// </summary>
        public static readonly Industry Hospitality = new Industry("Hospitality");
        /// <summary>
        /// Constant LifeSciences for Industry
        /// </summary>
        public static readonly Industry LifeSciences = new Industry("Life Sciences");
        /// <summary>
        /// Constant Manufacturing for Industry
        /// </summary>
        public static readonly Industry Manufacturing = new Industry("Manufacturing");
        /// <summary>
        /// Constant MarketingAndAdvertising for Industry
        /// </summary>
        public static readonly Industry MarketingAndAdvertising = new Industry("Marketing and Advertising");
        /// <summary>
        /// Constant MediaAndEntertainment for Industry
        /// </summary>
        public static readonly Industry MediaAndEntertainment = new Industry("Media and Entertainment");
        /// <summary>
        /// Constant Mining for Industry
        /// </summary>
        public static readonly Industry Mining = new Industry("Mining");
        /// <summary>
        /// Constant NonProfitOrganization for Industry
        /// </summary>
        public static readonly Industry NonProfitOrganization = new Industry("Non-Profit Organization");
        /// <summary>
        /// Constant Other for Industry
        /// </summary>
        public static readonly Industry Other = new Industry("Other");
        /// <summary>
        /// Constant ProfessionalServices for Industry
        /// </summary>
        public static readonly Industry ProfessionalServices = new Industry("Professional Services");
        /// <summary>
        /// Constant RealEstateAndConstruction for Industry
        /// </summary>
        public static readonly Industry RealEstateAndConstruction = new Industry("Real Estate and Construction");
        /// <summary>
        /// Constant Retail for Industry
        /// </summary>
        public static readonly Industry Retail = new Industry("Retail");
        /// <summary>
        /// Constant SoftwareAndInternet for Industry
        /// </summary>
        public static readonly Industry SoftwareAndInternet = new Industry("Software and Internet");
        /// <summary>
        /// Constant Telecommunications for Industry
        /// </summary>
        public static readonly Industry Telecommunications = new Industry("Telecommunications");
        /// <summary>
        /// Constant TransportationAndLogistics for Industry
        /// </summary>
        public static readonly Industry TransportationAndLogistics = new Industry("Transportation and Logistics");
        /// <summary>
        /// Constant Travel for Industry
        /// </summary>
        public static readonly Industry Travel = new Industry("Travel");
        /// <summary>
        /// Constant WholesaleAndDistribution for Industry
        /// </summary>
        public static readonly Industry WholesaleAndDistribution = new Industry("Wholesale and Distribution");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Industry(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Industry FindValue(string value)
        {
            return FindValue<Industry>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Industry(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InvitationStatus.
    /// </summary>
    public class InvitationStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACCEPTED for InvitationStatus
        /// </summary>
        public static readonly InvitationStatus ACCEPTED = new InvitationStatus("ACCEPTED");
        /// <summary>
        /// Constant EXPIRED for InvitationStatus
        /// </summary>
        public static readonly InvitationStatus EXPIRED = new InvitationStatus("EXPIRED");
        /// <summary>
        /// Constant PENDING for InvitationStatus
        /// </summary>
        public static readonly InvitationStatus PENDING = new InvitationStatus("PENDING");
        /// <summary>
        /// Constant REJECTED for InvitationStatus
        /// </summary>
        public static readonly InvitationStatus REJECTED = new InvitationStatus("REJECTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InvitationStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InvitationStatus FindValue(string value)
        {
            return FindValue<InvitationStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InvitationStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InvolvementTypeChangeReason.
    /// </summary>
    public class InvolvementTypeChangeReason : ConstantClass
    {

        /// <summary>
        /// Constant ChangeInDealInformation for InvolvementTypeChangeReason
        /// </summary>
        public static readonly InvolvementTypeChangeReason ChangeInDealInformation = new InvolvementTypeChangeReason("Change in Deal Information");
        /// <summary>
        /// Constant CustomerRequested for InvolvementTypeChangeReason
        /// </summary>
        public static readonly InvolvementTypeChangeReason CustomerRequested = new InvolvementTypeChangeReason("Customer Requested");
        /// <summary>
        /// Constant ExpansionOpportunity for InvolvementTypeChangeReason
        /// </summary>
        public static readonly InvolvementTypeChangeReason ExpansionOpportunity = new InvolvementTypeChangeReason("Expansion Opportunity");
        /// <summary>
        /// Constant RiskMitigation for InvolvementTypeChangeReason
        /// </summary>
        public static readonly InvolvementTypeChangeReason RiskMitigation = new InvolvementTypeChangeReason("Risk Mitigation");
        /// <summary>
        /// Constant TechnicalComplexity for InvolvementTypeChangeReason
        /// </summary>
        public static readonly InvolvementTypeChangeReason TechnicalComplexity = new InvolvementTypeChangeReason("Technical Complexity");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InvolvementTypeChangeReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InvolvementTypeChangeReason FindValue(string value)
        {
            return FindValue<InvolvementTypeChangeReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InvolvementTypeChangeReason(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ListTasksSortName.
    /// </summary>
    public class ListTasksSortName : ConstantClass
    {

        /// <summary>
        /// Constant StartTime for ListTasksSortName
        /// </summary>
        public static readonly ListTasksSortName StartTime = new ListTasksSortName("StartTime");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ListTasksSortName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ListTasksSortName FindValue(string value)
        {
            return FindValue<ListTasksSortName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ListTasksSortName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type MarketingSource.
    /// </summary>
    public class MarketingSource : ConstantClass
    {

        /// <summary>
        /// Constant MarketingActivity for MarketingSource
        /// </summary>
        public static readonly MarketingSource MarketingActivity = new MarketingSource("Marketing Activity");
        /// <summary>
        /// Constant None for MarketingSource
        /// </summary>
        public static readonly MarketingSource None = new MarketingSource("None");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public MarketingSource(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static MarketingSource FindValue(string value)
        {
            return FindValue<MarketingSource>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator MarketingSource(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NationalSecurity.
    /// </summary>
    public class NationalSecurity : ConstantClass
    {

        /// <summary>
        /// Constant No for NationalSecurity
        /// </summary>
        public static readonly NationalSecurity No = new NationalSecurity("No");
        /// <summary>
        /// Constant Yes for NationalSecurity
        /// </summary>
        public static readonly NationalSecurity Yes = new NationalSecurity("Yes");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NationalSecurity(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NationalSecurity FindValue(string value)
        {
            return FindValue<NationalSecurity>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NationalSecurity(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OpportunityEngagementInvitationSortName.
    /// </summary>
    public class OpportunityEngagementInvitationSortName : ConstantClass
    {

        /// <summary>
        /// Constant InvitationDate for OpportunityEngagementInvitationSortName
        /// </summary>
        public static readonly OpportunityEngagementInvitationSortName InvitationDate = new OpportunityEngagementInvitationSortName("InvitationDate");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OpportunityEngagementInvitationSortName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OpportunityEngagementInvitationSortName FindValue(string value)
        {
            return FindValue<OpportunityEngagementInvitationSortName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OpportunityEngagementInvitationSortName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OpportunityOrigin.
    /// </summary>
    public class OpportunityOrigin : ConstantClass
    {

        /// <summary>
        /// Constant AWSReferral for OpportunityOrigin
        /// </summary>
        public static readonly OpportunityOrigin AWSReferral = new OpportunityOrigin("AWS Referral");
        /// <summary>
        /// Constant PartnerReferral for OpportunityOrigin
        /// </summary>
        public static readonly OpportunityOrigin PartnerReferral = new OpportunityOrigin("Partner Referral");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OpportunityOrigin(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OpportunityOrigin FindValue(string value)
        {
            return FindValue<OpportunityOrigin>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OpportunityOrigin(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OpportunitySortName.
    /// </summary>
    public class OpportunitySortName : ConstantClass
    {

        /// <summary>
        /// Constant CustomerCompanyName for OpportunitySortName
        /// </summary>
        public static readonly OpportunitySortName CustomerCompanyName = new OpportunitySortName("CustomerCompanyName");
        /// <summary>
        /// Constant Identifier for OpportunitySortName
        /// </summary>
        public static readonly OpportunitySortName Identifier = new OpportunitySortName("Identifier");
        /// <summary>
        /// Constant LastModifiedDate for OpportunitySortName
        /// </summary>
        public static readonly OpportunitySortName LastModifiedDate = new OpportunitySortName("LastModifiedDate");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OpportunitySortName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OpportunitySortName FindValue(string value)
        {
            return FindValue<OpportunitySortName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OpportunitySortName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OpportunityType.
    /// </summary>
    public class OpportunityType : ConstantClass
    {

        /// <summary>
        /// Constant Expansion for OpportunityType
        /// </summary>
        public static readonly OpportunityType Expansion = new OpportunityType("Expansion");
        /// <summary>
        /// Constant FlatRenewal for OpportunityType
        /// </summary>
        public static readonly OpportunityType FlatRenewal = new OpportunityType("Flat Renewal");
        /// <summary>
        /// Constant NetNewBusiness for OpportunityType
        /// </summary>
        public static readonly OpportunityType NetNewBusiness = new OpportunityType("Net New Business");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OpportunityType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OpportunityType FindValue(string value)
        {
            return FindValue<OpportunityType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OpportunityType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ParticipantType.
    /// </summary>
    public class ParticipantType : ConstantClass
    {

        /// <summary>
        /// Constant RECEIVER for ParticipantType
        /// </summary>
        public static readonly ParticipantType RECEIVER = new ParticipantType("RECEIVER");
        /// <summary>
        /// Constant SENDER for ParticipantType
        /// </summary>
        public static readonly ParticipantType SENDER = new ParticipantType("SENDER");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ParticipantType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ParticipantType FindValue(string value)
        {
            return FindValue<ParticipantType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ParticipantType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PaymentFrequency.
    /// </summary>
    public class PaymentFrequency : ConstantClass
    {

        /// <summary>
        /// Constant Monthly for PaymentFrequency
        /// </summary>
        public static readonly PaymentFrequency Monthly = new PaymentFrequency("Monthly");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PaymentFrequency(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PaymentFrequency FindValue(string value)
        {
            return FindValue<PaymentFrequency>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PaymentFrequency(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type PrimaryNeedFromAws.
    /// </summary>
    public class PrimaryNeedFromAws : ConstantClass
    {

        /// <summary>
        /// Constant CoSellArchitecturalValidation for PrimaryNeedFromAws
        /// </summary>
        public static readonly PrimaryNeedFromAws CoSellArchitecturalValidation = new PrimaryNeedFromAws("Co-Sell - Architectural Validation");
        /// <summary>
        /// Constant CoSellBusinessPresentation for PrimaryNeedFromAws
        /// </summary>
        public static readonly PrimaryNeedFromAws CoSellBusinessPresentation = new PrimaryNeedFromAws("Co-Sell - Business Presentation");
        /// <summary>
        /// Constant CoSellCompetitiveInformation for PrimaryNeedFromAws
        /// </summary>
        public static readonly PrimaryNeedFromAws CoSellCompetitiveInformation = new PrimaryNeedFromAws("Co-Sell - Competitive Information");
        /// <summary>
        /// Constant CoSellDealSupport for PrimaryNeedFromAws
        /// </summary>
        public static readonly PrimaryNeedFromAws CoSellDealSupport = new PrimaryNeedFromAws("Co-Sell - Deal Support");
        /// <summary>
        /// Constant CoSellPricingAssistance for PrimaryNeedFromAws
        /// </summary>
        public static readonly PrimaryNeedFromAws CoSellPricingAssistance = new PrimaryNeedFromAws("Co-Sell - Pricing Assistance");
        /// <summary>
        /// Constant CoSellSupportForPublicTenderRFx for PrimaryNeedFromAws
        /// </summary>
        public static readonly PrimaryNeedFromAws CoSellSupportForPublicTenderRFx = new PrimaryNeedFromAws("Co-Sell - Support for Public Tender / RFx");
        /// <summary>
        /// Constant CoSellTechnicalConsultation for PrimaryNeedFromAws
        /// </summary>
        public static readonly PrimaryNeedFromAws CoSellTechnicalConsultation = new PrimaryNeedFromAws("Co-Sell - Technical Consultation");
        /// <summary>
        /// Constant CoSellTotalCostOfOwnershipEvaluation for PrimaryNeedFromAws
        /// </summary>
        public static readonly PrimaryNeedFromAws CoSellTotalCostOfOwnershipEvaluation = new PrimaryNeedFromAws("Co-Sell - Total Cost of Ownership Evaluation");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public PrimaryNeedFromAws(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static PrimaryNeedFromAws FindValue(string value)
        {
            return FindValue<PrimaryNeedFromAws>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator PrimaryNeedFromAws(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReasonCode.
    /// </summary>
    public class ReasonCode : ConstantClass
    {

        /// <summary>
        /// Constant EngagementAccessDenied for ReasonCode
        /// </summary>
        public static readonly ReasonCode EngagementAccessDenied = new ReasonCode("EngagementAccessDenied");
        /// <summary>
        /// Constant EngagementConflict for ReasonCode
        /// </summary>
        public static readonly ReasonCode EngagementConflict = new ReasonCode("EngagementConflict");
        /// <summary>
        /// Constant EngagementInvitationConflict for ReasonCode
        /// </summary>
        public static readonly ReasonCode EngagementInvitationConflict = new ReasonCode("EngagementInvitationConflict");
        /// <summary>
        /// Constant EngagementValidationFailed for ReasonCode
        /// </summary>
        public static readonly ReasonCode EngagementValidationFailed = new ReasonCode("EngagementValidationFailed");
        /// <summary>
        /// Constant InternalError for ReasonCode
        /// </summary>
        public static readonly ReasonCode InternalError = new ReasonCode("InternalError");
        /// <summary>
        /// Constant InvitationAccessDenied for ReasonCode
        /// </summary>
        public static readonly ReasonCode InvitationAccessDenied = new ReasonCode("InvitationAccessDenied");
        /// <summary>
        /// Constant InvitationValidationFailed for ReasonCode
        /// </summary>
        public static readonly ReasonCode InvitationValidationFailed = new ReasonCode("InvitationValidationFailed");
        /// <summary>
        /// Constant OpportunityAccessDenied for ReasonCode
        /// </summary>
        public static readonly ReasonCode OpportunityAccessDenied = new ReasonCode("OpportunityAccessDenied");
        /// <summary>
        /// Constant OpportunityConflict for ReasonCode
        /// </summary>
        public static readonly ReasonCode OpportunityConflict = new ReasonCode("OpportunityConflict");
        /// <summary>
        /// Constant OpportunitySubmissionFailed for ReasonCode
        /// </summary>
        public static readonly ReasonCode OpportunitySubmissionFailed = new ReasonCode("OpportunitySubmissionFailed");
        /// <summary>
        /// Constant OpportunityValidationFailed for ReasonCode
        /// </summary>
        public static readonly ReasonCode OpportunityValidationFailed = new ReasonCode("OpportunityValidationFailed");
        /// <summary>
        /// Constant RequestThrottled for ReasonCode
        /// </summary>
        public static readonly ReasonCode RequestThrottled = new ReasonCode("RequestThrottled");
        /// <summary>
        /// Constant ResourceSnapshotAccessDenied for ReasonCode
        /// </summary>
        public static readonly ReasonCode ResourceSnapshotAccessDenied = new ReasonCode("ResourceSnapshotAccessDenied");
        /// <summary>
        /// Constant ResourceSnapshotConflict for ReasonCode
        /// </summary>
        public static readonly ReasonCode ResourceSnapshotConflict = new ReasonCode("ResourceSnapshotConflict");
        /// <summary>
        /// Constant ResourceSnapshotJobAccessDenied for ReasonCode
        /// </summary>
        public static readonly ReasonCode ResourceSnapshotJobAccessDenied = new ReasonCode("ResourceSnapshotJobAccessDenied");
        /// <summary>
        /// Constant ResourceSnapshotJobConflict for ReasonCode
        /// </summary>
        public static readonly ReasonCode ResourceSnapshotJobConflict = new ReasonCode("ResourceSnapshotJobConflict");
        /// <summary>
        /// Constant ResourceSnapshotJobValidationFailed for ReasonCode
        /// </summary>
        public static readonly ReasonCode ResourceSnapshotJobValidationFailed = new ReasonCode("ResourceSnapshotJobValidationFailed");
        /// <summary>
        /// Constant ResourceSnapshotValidationFailed for ReasonCode
        /// </summary>
        public static readonly ReasonCode ResourceSnapshotValidationFailed = new ReasonCode("ResourceSnapshotValidationFailed");
        /// <summary>
        /// Constant ServiceQuotaExceeded for ReasonCode
        /// </summary>
        public static readonly ReasonCode ServiceQuotaExceeded = new ReasonCode("ServiceQuotaExceeded");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReasonCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReasonCode FindValue(string value)
        {
            return FindValue<ReasonCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReasonCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReceiverResponsibility.
    /// </summary>
    public class ReceiverResponsibility : ConstantClass
    {

        /// <summary>
        /// Constant CoSellFacilitator for ReceiverResponsibility
        /// </summary>
        public static readonly ReceiverResponsibility CoSellFacilitator = new ReceiverResponsibility("Co-Sell Facilitator");
        /// <summary>
        /// Constant Distributor for ReceiverResponsibility
        /// </summary>
        public static readonly ReceiverResponsibility Distributor = new ReceiverResponsibility("Distributor");
        /// <summary>
        /// Constant Facilitator for ReceiverResponsibility
        /// </summary>
        public static readonly ReceiverResponsibility Facilitator = new ReceiverResponsibility("Facilitator");
        /// <summary>
        /// Constant HardwarePartner for ReceiverResponsibility
        /// </summary>
        public static readonly ReceiverResponsibility HardwarePartner = new ReceiverResponsibility("Hardware Partner");
        /// <summary>
        /// Constant ManagedServiceProvider for ReceiverResponsibility
        /// </summary>
        public static readonly ReceiverResponsibility ManagedServiceProvider = new ReceiverResponsibility("Managed Service Provider");
        /// <summary>
        /// Constant Reseller for ReceiverResponsibility
        /// </summary>
        public static readonly ReceiverResponsibility Reseller = new ReceiverResponsibility("Reseller");
        /// <summary>
        /// Constant ServicesPartner for ReceiverResponsibility
        /// </summary>
        public static readonly ReceiverResponsibility ServicesPartner = new ReceiverResponsibility("Services Partner");
        /// <summary>
        /// Constant SoftwarePartner for ReceiverResponsibility
        /// </summary>
        public static readonly ReceiverResponsibility SoftwarePartner = new ReceiverResponsibility("Software Partner");
        /// <summary>
        /// Constant TrainingPartner for ReceiverResponsibility
        /// </summary>
        public static readonly ReceiverResponsibility TrainingPartner = new ReceiverResponsibility("Training Partner");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReceiverResponsibility(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReceiverResponsibility FindValue(string value)
        {
            return FindValue<ReceiverResponsibility>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReceiverResponsibility(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RelatedEntityType.
    /// </summary>
    public class RelatedEntityType : ConstantClass
    {

        /// <summary>
        /// Constant AwsMarketplaceOffers for RelatedEntityType
        /// </summary>
        public static readonly RelatedEntityType AwsMarketplaceOffers = new RelatedEntityType("AwsMarketplaceOffers");
        /// <summary>
        /// Constant AwsProducts for RelatedEntityType
        /// </summary>
        public static readonly RelatedEntityType AwsProducts = new RelatedEntityType("AwsProducts");
        /// <summary>
        /// Constant Solutions for RelatedEntityType
        /// </summary>
        public static readonly RelatedEntityType Solutions = new RelatedEntityType("Solutions");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RelatedEntityType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RelatedEntityType FindValue(string value)
        {
            return FindValue<RelatedEntityType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RelatedEntityType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceSnapshotJobStatus.
    /// </summary>
    public class ResourceSnapshotJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant Running for ResourceSnapshotJobStatus
        /// </summary>
        public static readonly ResourceSnapshotJobStatus Running = new ResourceSnapshotJobStatus("Running");
        /// <summary>
        /// Constant Stopped for ResourceSnapshotJobStatus
        /// </summary>
        public static readonly ResourceSnapshotJobStatus Stopped = new ResourceSnapshotJobStatus("Stopped");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceSnapshotJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceSnapshotJobStatus FindValue(string value)
        {
            return FindValue<ResourceSnapshotJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceSnapshotJobStatus(string value)
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
        /// Constant Opportunity for ResourceType
        /// </summary>
        public static readonly ResourceType Opportunity = new ResourceType("Opportunity");

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
    /// Constants used for properties of type RevenueModel.
    /// </summary>
    public class RevenueModel : ConstantClass
    {

        /// <summary>
        /// Constant Contract for RevenueModel
        /// </summary>
        public static readonly RevenueModel Contract = new RevenueModel("Contract");
        /// <summary>
        /// Constant PayAsYouGo for RevenueModel
        /// </summary>
        public static readonly RevenueModel PayAsYouGo = new RevenueModel("Pay-as-you-go");
        /// <summary>
        /// Constant Subscription for RevenueModel
        /// </summary>
        public static readonly RevenueModel Subscription = new RevenueModel("Subscription");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RevenueModel(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RevenueModel FindValue(string value)
        {
            return FindValue<RevenueModel>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RevenueModel(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ReviewStatus.
    /// </summary>
    public class ReviewStatus : ConstantClass
    {

        /// <summary>
        /// Constant ActionRequired for ReviewStatus
        /// </summary>
        public static readonly ReviewStatus ActionRequired = new ReviewStatus("Action Required");
        /// <summary>
        /// Constant Approved for ReviewStatus
        /// </summary>
        public static readonly ReviewStatus Approved = new ReviewStatus("Approved");
        /// <summary>
        /// Constant InReview for ReviewStatus
        /// </summary>
        public static readonly ReviewStatus InReview = new ReviewStatus("In review");
        /// <summary>
        /// Constant PendingSubmission for ReviewStatus
        /// </summary>
        public static readonly ReviewStatus PendingSubmission = new ReviewStatus("Pending Submission");
        /// <summary>
        /// Constant Rejected for ReviewStatus
        /// </summary>
        public static readonly ReviewStatus Rejected = new ReviewStatus("Rejected");
        /// <summary>
        /// Constant Submitted for ReviewStatus
        /// </summary>
        public static readonly ReviewStatus Submitted = new ReviewStatus("Submitted");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ReviewStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ReviewStatus FindValue(string value)
        {
            return FindValue<ReviewStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ReviewStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SalesActivity.
    /// </summary>
    public class SalesActivity : ConstantClass
    {

        /// <summary>
        /// Constant AgreedOnSolutionToBusinessProblem for SalesActivity
        /// </summary>
        public static readonly SalesActivity AgreedOnSolutionToBusinessProblem = new SalesActivity("Agreed on solution to Business Problem");
        /// <summary>
        /// Constant CompletedActionPlan for SalesActivity
        /// </summary>
        public static readonly SalesActivity CompletedActionPlan = new SalesActivity("Completed Action Plan");
        /// <summary>
        /// Constant ConductedPOCDemo for SalesActivity
        /// </summary>
        public static readonly SalesActivity ConductedPOCDemo = new SalesActivity("Conducted POC / Demo");
        /// <summary>
        /// Constant CustomerHasShownInterestInSolution for SalesActivity
        /// </summary>
        public static readonly SalesActivity CustomerHasShownInterestInSolution = new SalesActivity("Customer has shown interest in solution");
        /// <summary>
        /// Constant FinalizedDeploymentNeed for SalesActivity
        /// </summary>
        public static readonly SalesActivity FinalizedDeploymentNeed = new SalesActivity("Finalized Deployment Need");
        /// <summary>
        /// Constant InEvaluationPlanningStage for SalesActivity
        /// </summary>
        public static readonly SalesActivity InEvaluationPlanningStage = new SalesActivity("In evaluation / planning stage");
        /// <summary>
        /// Constant InitializedDiscussionsWithCustomer for SalesActivity
        /// </summary>
        public static readonly SalesActivity InitializedDiscussionsWithCustomer = new SalesActivity("Initialized discussions with customer");
        /// <summary>
        /// Constant SOWSigned for SalesActivity
        /// </summary>
        public static readonly SalesActivity SOWSigned = new SalesActivity("SOW Signed");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SalesActivity(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SalesActivity FindValue(string value)
        {
            return FindValue<SalesActivity>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SalesActivity(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SalesInvolvementType.
    /// </summary>
    public class SalesInvolvementType : ConstantClass
    {

        /// <summary>
        /// Constant CoSell for SalesInvolvementType
        /// </summary>
        public static readonly SalesInvolvementType CoSell = new SalesInvolvementType("Co-Sell");
        /// <summary>
        /// Constant ForVisibilityOnly for SalesInvolvementType
        /// </summary>
        public static readonly SalesInvolvementType ForVisibilityOnly = new SalesInvolvementType("For Visibility Only");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SalesInvolvementType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SalesInvolvementType FindValue(string value)
        {
            return FindValue<SalesInvolvementType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SalesInvolvementType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SolutionSortName.
    /// </summary>
    public class SolutionSortName : ConstantClass
    {

        /// <summary>
        /// Constant Category for SolutionSortName
        /// </summary>
        public static readonly SolutionSortName Category = new SolutionSortName("Category");
        /// <summary>
        /// Constant CreatedDate for SolutionSortName
        /// </summary>
        public static readonly SolutionSortName CreatedDate = new SolutionSortName("CreatedDate");
        /// <summary>
        /// Constant Identifier for SolutionSortName
        /// </summary>
        public static readonly SolutionSortName Identifier = new SolutionSortName("Identifier");
        /// <summary>
        /// Constant Name for SolutionSortName
        /// </summary>
        public static readonly SolutionSortName Name = new SolutionSortName("Name");
        /// <summary>
        /// Constant Status for SolutionSortName
        /// </summary>
        public static readonly SolutionSortName Status = new SolutionSortName("Status");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SolutionSortName(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SolutionSortName FindValue(string value)
        {
            return FindValue<SolutionSortName>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SolutionSortName(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SolutionStatus.
    /// </summary>
    public class SolutionStatus : ConstantClass
    {

        /// <summary>
        /// Constant Active for SolutionStatus
        /// </summary>
        public static readonly SolutionStatus Active = new SolutionStatus("Active");
        /// <summary>
        /// Constant Draft for SolutionStatus
        /// </summary>
        public static readonly SolutionStatus Draft = new SolutionStatus("Draft");
        /// <summary>
        /// Constant Inactive for SolutionStatus
        /// </summary>
        public static readonly SolutionStatus Inactive = new SolutionStatus("Inactive");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SolutionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SolutionStatus FindValue(string value)
        {
            return FindValue<SolutionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SolutionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortBy.
    /// </summary>
    public class SortBy : ConstantClass
    {

        /// <summary>
        /// Constant CreatedDate for SortBy
        /// </summary>
        public static readonly SortBy CreatedDate = new SortBy("CreatedDate");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortBy FindValue(string value)
        {
            return FindValue<SortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortBy(string value)
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
    /// Constants used for properties of type Stage.
    /// </summary>
    public class Stage : ConstantClass
    {

        /// <summary>
        /// Constant BusinessValidation for Stage
        /// </summary>
        public static readonly Stage BusinessValidation = new Stage("Business Validation");
        /// <summary>
        /// Constant ClosedLost for Stage
        /// </summary>
        public static readonly Stage ClosedLost = new Stage("Closed Lost");
        /// <summary>
        /// Constant Committed for Stage
        /// </summary>
        public static readonly Stage Committed = new Stage("Committed");
        /// <summary>
        /// Constant Launched for Stage
        /// </summary>
        public static readonly Stage Launched = new Stage("Launched");
        /// <summary>
        /// Constant Prospect for Stage
        /// </summary>
        public static readonly Stage Prospect = new Stage("Prospect");
        /// <summary>
        /// Constant Qualified for Stage
        /// </summary>
        public static readonly Stage Qualified = new Stage("Qualified");
        /// <summary>
        /// Constant TechnicalValidation for Stage
        /// </summary>
        public static readonly Stage TechnicalValidation = new Stage("Technical Validation");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Stage(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Stage FindValue(string value)
        {
            return FindValue<Stage>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Stage(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TaskStatus.
    /// </summary>
    public class TaskStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETE for TaskStatus
        /// </summary>
        public static readonly TaskStatus COMPLETE = new TaskStatus("COMPLETE");
        /// <summary>
        /// Constant FAILED for TaskStatus
        /// </summary>
        public static readonly TaskStatus FAILED = new TaskStatus("FAILED");
        /// <summary>
        /// Constant IN_PROGRESS for TaskStatus
        /// </summary>
        public static readonly TaskStatus IN_PROGRESS = new TaskStatus("IN_PROGRESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TaskStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TaskStatus FindValue(string value)
        {
            return FindValue<TaskStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TaskStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ValidationExceptionErrorCode.
    /// </summary>
    public class ValidationExceptionErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant ACTION_NOT_PERMITTED for ValidationExceptionErrorCode
        /// </summary>
        public static readonly ValidationExceptionErrorCode ACTION_NOT_PERMITTED = new ValidationExceptionErrorCode("ACTION_NOT_PERMITTED");
        /// <summary>
        /// Constant DUPLICATE_KEY_VALUE for ValidationExceptionErrorCode
        /// </summary>
        public static readonly ValidationExceptionErrorCode DUPLICATE_KEY_VALUE = new ValidationExceptionErrorCode("DUPLICATE_KEY_VALUE");
        /// <summary>
        /// Constant INVALID_ENUM_VALUE for ValidationExceptionErrorCode
        /// </summary>
        public static readonly ValidationExceptionErrorCode INVALID_ENUM_VALUE = new ValidationExceptionErrorCode("INVALID_ENUM_VALUE");
        /// <summary>
        /// Constant INVALID_RESOURCE_STATE for ValidationExceptionErrorCode
        /// </summary>
        public static readonly ValidationExceptionErrorCode INVALID_RESOURCE_STATE = new ValidationExceptionErrorCode("INVALID_RESOURCE_STATE");
        /// <summary>
        /// Constant INVALID_STRING_FORMAT for ValidationExceptionErrorCode
        /// </summary>
        public static readonly ValidationExceptionErrorCode INVALID_STRING_FORMAT = new ValidationExceptionErrorCode("INVALID_STRING_FORMAT");
        /// <summary>
        /// Constant INVALID_VALUE for ValidationExceptionErrorCode
        /// </summary>
        public static readonly ValidationExceptionErrorCode INVALID_VALUE = new ValidationExceptionErrorCode("INVALID_VALUE");
        /// <summary>
        /// Constant REQUIRED_FIELD_MISSING for ValidationExceptionErrorCode
        /// </summary>
        public static readonly ValidationExceptionErrorCode REQUIRED_FIELD_MISSING = new ValidationExceptionErrorCode("REQUIRED_FIELD_MISSING");
        /// <summary>
        /// Constant TOO_MANY_VALUES for ValidationExceptionErrorCode
        /// </summary>
        public static readonly ValidationExceptionErrorCode TOO_MANY_VALUES = new ValidationExceptionErrorCode("TOO_MANY_VALUES");
        /// <summary>
        /// Constant VALUE_OUT_OF_RANGE for ValidationExceptionErrorCode
        /// </summary>
        public static readonly ValidationExceptionErrorCode VALUE_OUT_OF_RANGE = new ValidationExceptionErrorCode("VALUE_OUT_OF_RANGE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ValidationExceptionErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ValidationExceptionErrorCode FindValue(string value)
        {
            return FindValue<ValidationExceptionErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ValidationExceptionErrorCode(string value)
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
        /// Constant BUSINESS_VALIDATION_FAILED for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason BUSINESS_VALIDATION_FAILED = new ValidationExceptionReason("BUSINESS_VALIDATION_FAILED");
        /// <summary>
        /// Constant REQUEST_VALIDATION_FAILED for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason REQUEST_VALIDATION_FAILED = new ValidationExceptionReason("REQUEST_VALIDATION_FAILED");

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


    /// <summary>
    /// Constants used for properties of type Visibility.
    /// </summary>
    public class Visibility : ConstantClass
    {

        /// <summary>
        /// Constant Full for Visibility
        /// </summary>
        public static readonly Visibility Full = new Visibility("Full");
        /// <summary>
        /// Constant Limited for Visibility
        /// </summary>
        public static readonly Visibility Limited = new Visibility("Limited");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Visibility(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Visibility FindValue(string value)
        {
            return FindValue<Visibility>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Visibility(string value)
        {
            return FindValue(value);
        }
    }

}