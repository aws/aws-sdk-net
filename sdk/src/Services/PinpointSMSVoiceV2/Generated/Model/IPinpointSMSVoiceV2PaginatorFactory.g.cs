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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618

namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// Paginators for the PinpointSMSVoiceV2 service
    /// </summary>
    public interface IPinpointSMSVoiceV2PaginatorFactory
    {
        /// <summary>
        /// Paginator for DescribeAccountAttributes operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IDescribeAccountAttributesPaginator DescribeAccountAttributes(DescribeAccountAttributesRequest request);

        /// <summary>
        /// Paginator for DescribeAccountLimits operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IDescribeAccountLimitsPaginator DescribeAccountLimits(DescribeAccountLimitsRequest request);

        /// <summary>
        /// Paginator for DescribeConfigurationSets operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IDescribeConfigurationSetsPaginator DescribeConfigurationSets(DescribeConfigurationSetsRequest request);

        /// <summary>
        /// Paginator for DescribeKeywords operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IDescribeKeywordsPaginator DescribeKeywords(DescribeKeywordsRequest request);

        /// <summary>
        /// Paginator for DescribeNotifyConfigurations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IDescribeNotifyConfigurationsPaginator DescribeNotifyConfigurations(DescribeNotifyConfigurationsRequest request);

        /// <summary>
        /// Paginator for DescribeNotifyTemplates operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IDescribeNotifyTemplatesPaginator DescribeNotifyTemplates(DescribeNotifyTemplatesRequest request);

        /// <summary>
        /// Paginator for DescribeOptOutLists operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IDescribeOptOutListsPaginator DescribeOptOutLists(DescribeOptOutListsRequest request);

        /// <summary>
        /// Paginator for DescribeOptedOutNumbers operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IDescribeOptedOutNumbersPaginator DescribeOptedOutNumbers(DescribeOptedOutNumbersRequest request);

        /// <summary>
        /// Paginator for DescribePhoneNumbers operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IDescribePhoneNumbersPaginator DescribePhoneNumbers(DescribePhoneNumbersRequest request);

        /// <summary>
        /// Paginator for DescribePools operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IDescribePoolsPaginator DescribePools(DescribePoolsRequest request);

        /// <summary>
        /// Paginator for DescribeProtectConfigurations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IDescribeProtectConfigurationsPaginator DescribeProtectConfigurations(DescribeProtectConfigurationsRequest request);

        /// <summary>
        /// Paginator for DescribeRcsAgentCountryLaunchStatus operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IDescribeRcsAgentCountryLaunchStatusPaginator DescribeRcsAgentCountryLaunchStatus(DescribeRcsAgentCountryLaunchStatusRequest request);

        /// <summary>
        /// Paginator for DescribeRcsAgents operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IDescribeRcsAgentsPaginator DescribeRcsAgents(DescribeRcsAgentsRequest request);

        /// <summary>
        /// Paginator for DescribeRegistrationAttachments operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IDescribeRegistrationAttachmentsPaginator DescribeRegistrationAttachments(DescribeRegistrationAttachmentsRequest request);

        /// <summary>
        /// Paginator for DescribeRegistrationFieldDefinitions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IDescribeRegistrationFieldDefinitionsPaginator DescribeRegistrationFieldDefinitions(DescribeRegistrationFieldDefinitionsRequest request);

        /// <summary>
        /// Paginator for DescribeRegistrationFieldValues operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IDescribeRegistrationFieldValuesPaginator DescribeRegistrationFieldValues(DescribeRegistrationFieldValuesRequest request);

        /// <summary>
        /// Paginator for DescribeRegistrationSectionDefinitions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IDescribeRegistrationSectionDefinitionsPaginator DescribeRegistrationSectionDefinitions(DescribeRegistrationSectionDefinitionsRequest request);

        /// <summary>
        /// Paginator for DescribeRegistrationTypeDefinitions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IDescribeRegistrationTypeDefinitionsPaginator DescribeRegistrationTypeDefinitions(DescribeRegistrationTypeDefinitionsRequest request);

        /// <summary>
        /// Paginator for DescribeRegistrationVersions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IDescribeRegistrationVersionsPaginator DescribeRegistrationVersions(DescribeRegistrationVersionsRequest request);

        /// <summary>
        /// Paginator for DescribeRegistrations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IDescribeRegistrationsPaginator DescribeRegistrations(DescribeRegistrationsRequest request);

        /// <summary>
        /// Paginator for DescribeSenderIds operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IDescribeSenderIdsPaginator DescribeSenderIds(DescribeSenderIdsRequest request);

        /// <summary>
        /// Paginator for DescribeSpendLimits operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IDescribeSpendLimitsPaginator DescribeSpendLimits(DescribeSpendLimitsRequest request);

        /// <summary>
        /// Paginator for DescribeVerifiedDestinationNumbers operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IDescribeVerifiedDestinationNumbersPaginator DescribeVerifiedDestinationNumbers(DescribeVerifiedDestinationNumbersRequest request);

        /// <summary>
        /// Paginator for ListAvailablePhoneNumbers operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAvailablePhoneNumbersPaginator ListAvailablePhoneNumbers(ListAvailablePhoneNumbersRequest request);

        /// <summary>
        /// Paginator for ListNotifyCountries operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListNotifyCountriesPaginator ListNotifyCountries(ListNotifyCountriesRequest request);

        /// <summary>
        /// Paginator for ListPoolOriginationIdentities operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListPoolOriginationIdentitiesPaginator ListPoolOriginationIdentities(ListPoolOriginationIdentitiesRequest request);

        /// <summary>
        /// Paginator for ListProtectConfigurationRuleSetNumberOverrides operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListProtectConfigurationRuleSetNumberOverridesPaginator ListProtectConfigurationRuleSetNumberOverrides(ListProtectConfigurationRuleSetNumberOverridesRequest request);

        /// <summary>
        /// Paginator for ListRegistrationAssociations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListRegistrationAssociationsPaginator ListRegistrationAssociations(ListRegistrationAssociationsRequest request);
    }
}
