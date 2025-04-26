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
 * Do not modify this file. This file is generated from the pinpoint-sms-voice-v2-2022-03-31.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// Paginators for the PinpointSMSVoiceV2 service
    ///</summary>
    public interface IPinpointSMSVoiceV2PaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeAccountAttributes operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeAccountAttributesPaginator DescribeAccountAttributes(DescribeAccountAttributesRequest request);

        /// <summary>
        /// Paginator for DescribeAccountLimits operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeAccountLimitsPaginator DescribeAccountLimits(DescribeAccountLimitsRequest request);

        /// <summary>
        /// Paginator for DescribeConfigurationSets operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeConfigurationSetsPaginator DescribeConfigurationSets(DescribeConfigurationSetsRequest request);

        /// <summary>
        /// Paginator for DescribeKeywords operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeKeywordsPaginator DescribeKeywords(DescribeKeywordsRequest request);

        /// <summary>
        /// Paginator for DescribeOptedOutNumbers operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeOptedOutNumbersPaginator DescribeOptedOutNumbers(DescribeOptedOutNumbersRequest request);

        /// <summary>
        /// Paginator for DescribeOptOutLists operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeOptOutListsPaginator DescribeOptOutLists(DescribeOptOutListsRequest request);

        /// <summary>
        /// Paginator for DescribePhoneNumbers operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribePhoneNumbersPaginator DescribePhoneNumbers(DescribePhoneNumbersRequest request);

        /// <summary>
        /// Paginator for DescribePools operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribePoolsPaginator DescribePools(DescribePoolsRequest request);

        /// <summary>
        /// Paginator for DescribeProtectConfigurations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeProtectConfigurationsPaginator DescribeProtectConfigurations(DescribeProtectConfigurationsRequest request);

        /// <summary>
        /// Paginator for DescribeRegistrationAttachments operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeRegistrationAttachmentsPaginator DescribeRegistrationAttachments(DescribeRegistrationAttachmentsRequest request);

        /// <summary>
        /// Paginator for DescribeRegistrationFieldDefinitions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeRegistrationFieldDefinitionsPaginator DescribeRegistrationFieldDefinitions(DescribeRegistrationFieldDefinitionsRequest request);

        /// <summary>
        /// Paginator for DescribeRegistrationFieldValues operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeRegistrationFieldValuesPaginator DescribeRegistrationFieldValues(DescribeRegistrationFieldValuesRequest request);

        /// <summary>
        /// Paginator for DescribeRegistrations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeRegistrationsPaginator DescribeRegistrations(DescribeRegistrationsRequest request);

        /// <summary>
        /// Paginator for DescribeRegistrationSectionDefinitions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeRegistrationSectionDefinitionsPaginator DescribeRegistrationSectionDefinitions(DescribeRegistrationSectionDefinitionsRequest request);

        /// <summary>
        /// Paginator for DescribeRegistrationTypeDefinitions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeRegistrationTypeDefinitionsPaginator DescribeRegistrationTypeDefinitions(DescribeRegistrationTypeDefinitionsRequest request);

        /// <summary>
        /// Paginator for DescribeRegistrationVersions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeRegistrationVersionsPaginator DescribeRegistrationVersions(DescribeRegistrationVersionsRequest request);

        /// <summary>
        /// Paginator for DescribeSenderIds operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeSenderIdsPaginator DescribeSenderIds(DescribeSenderIdsRequest request);

        /// <summary>
        /// Paginator for DescribeSpendLimits operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeSpendLimitsPaginator DescribeSpendLimits(DescribeSpendLimitsRequest request);

        /// <summary>
        /// Paginator for DescribeVerifiedDestinationNumbers operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IDescribeVerifiedDestinationNumbersPaginator DescribeVerifiedDestinationNumbers(DescribeVerifiedDestinationNumbersRequest request);

        /// <summary>
        /// Paginator for ListPoolOriginationIdentities operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListPoolOriginationIdentitiesPaginator ListPoolOriginationIdentities(ListPoolOriginationIdentitiesRequest request);

        /// <summary>
        /// Paginator for ListProtectConfigurationRuleSetNumberOverrides operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListProtectConfigurationRuleSetNumberOverridesPaginator ListProtectConfigurationRuleSetNumberOverrides(ListProtectConfigurationRuleSetNumberOverridesRequest request);

        /// <summary>
        /// Paginator for ListRegistrationAssociations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListRegistrationAssociationsPaginator ListRegistrationAssociations(ListRegistrationAssociationsRequest request);
    }
}