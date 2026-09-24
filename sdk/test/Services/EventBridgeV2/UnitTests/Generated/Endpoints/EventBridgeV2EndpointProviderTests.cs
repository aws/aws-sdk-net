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
 * Do not modify this file. This file is generated from the eventbridgev2-2025-05-15.normal.json service model.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.EventBridgeV2.Endpoints;
using Amazon.EventBridgeV2.Internal;

namespace AWSSDK_DotNet.UnitTests.Endpoints
{
    [TestClass]
    public partial class EventBridgeV2EndpointsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridgeV2")]
        [Description("Bus ARN account takes precedence over the credentials-sourced account (cross-account call).")]
        public void Bus_ARN_account_takes_precedence_over_the_credentialssourced_account_crossaccount_call_Test()
        {
            var parameters = new EventBridgeV2EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["EventBusArn"] = "arn:aws:events:us-east-1:210987654321:event-busv2/owner-bus/abcdefghij0123456789abcde";
            parameters["AccountId"] = "123456789012";
            parameters["AccountIdEndpointMode"] = "preferred";
            var endpoint = new AmazonEventBridgeV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://210987654321.eventsv2.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridgeV2")]
        [Description("Bus ARN routing works without a credentials-sourced account ID.")]
        public void Bus_ARN_routing_works_without_a_credentialssourced_account_ID_Test()
        {
            var parameters = new EventBridgeV2EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["EventBusArn"] = "arn:aws:events:us-east-1:210987654321:event-busv2/owner-bus/abcdefghij0123456789abcde";
            parameters["AccountIdEndpointMode"] = "preferred";
            var endpoint = new AmazonEventBridgeV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://210987654321.eventsv2.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridgeV2")]
        [Description("Disabled mode ignores the bus ARN and the credentials-sourced account.")]
        public void Disabled_mode_ignores_the_bus_ARN_and_the_credentialssourced_account_Test()
        {
            var parameters = new EventBridgeV2EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["EventBusArn"] = "arn:aws:events:us-east-1:210987654321:event-busv2/owner-bus/abcdefghij0123456789abcde";
            parameters["AccountId"] = "123456789012";
            parameters["AccountIdEndpointMode"] = "disabled";
            var endpoint = new AmazonEventBridgeV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://eventsv2.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridgeV2")]
        [Description("An unparseable bus ARN falls through to the credentials-sourced account.")]
        public void An_unparseable_bus_ARN_falls_through_to_the_credentialssourced_account_Test()
        {
            var parameters = new EventBridgeV2EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["EventBusArn"] = "not-an-arn";
            parameters["AccountId"] = "123456789012";
            parameters["AccountIdEndpointMode"] = "preferred";
            var endpoint = new AmazonEventBridgeV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://123456789012.eventsv2.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridgeV2")]
        [Description("FIPS account-based endpoint from the bus ARN.")]
        public void FIPS_accountbased_endpoint_from_the_bus_ARN_Test()
        {
            var parameters = new EventBridgeV2EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["EventBusArn"] = "arn:aws:events:us-east-1:210987654321:event-busv2/owner-bus/abcdefghij0123456789abcde";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonEventBridgeV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://210987654321.eventsv2-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridgeV2")]
        [Description("DualStack account-based endpoint from the bus ARN.")]
        public void DualStack_accountbased_endpoint_from_the_bus_ARN_Test()
        {
            var parameters = new EventBridgeV2EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["EventBusArn"] = "arn:aws:events:us-east-1:210987654321:event-busv2/owner-bus/abcdefghij0123456789abcde";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://210987654321.eventsv2.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridgeV2")]
        [Description("FIPS + DualStack account-based endpoint from the bus ARN.")]
        public void FIPS_DualStack_accountbased_endpoint_from_the_bus_ARN_Test()
        {
            var parameters = new EventBridgeV2EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["EventBusArn"] = "arn:aws:events:us-east-1:210987654321:event-busv2/owner-bus/abcdefghij0123456789abcde";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://210987654321.eventsv2-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridgeV2")]
        [Description("FIPS account-based endpoint from the credentials-sourced account.")]
        public void FIPS_accountbased_endpoint_from_the_credentialssourced_account_Test()
        {
            var parameters = new EventBridgeV2EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["AccountId"] = "123456789012";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonEventBridgeV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://123456789012.eventsv2-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridgeV2")]
        [Description("FIPS + DualStack account-based endpoint from the credentials-sourced account.")]
        public void FIPS_DualStack_accountbased_endpoint_from_the_credentialssourced_account_Test()
        {
            var parameters = new EventBridgeV2EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["AccountId"] = "123456789012";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://123456789012.eventsv2-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridgeV2")]
        [Description("Explicit endpoint override wins over account-based routing.")]
        public void Explicit_endpoint_override_wins_over_accountbased_routing_Test()
        {
            var parameters = new EventBridgeV2EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            parameters["AccountId"] = "123456789012";
            parameters["AccountIdEndpointMode"] = "preferred";
            var endpoint = new AmazonEventBridgeV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://example.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridgeV2")]
        [Description("FIPS cannot be combined with an endpoint override.")]
        public void FIPS_cannot_be_combined_with_an_endpoint_override_Test()
        {
            var parameters = new EventBridgeV2EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            parameters["UseFIPS"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonEventBridgeV2EndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: FIPS and custom endpoint are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridgeV2")]
        [Description("DualStack cannot be combined with an endpoint override.")]
        public void DualStack_cannot_be_combined_with_an_endpoint_override_Test()
        {
            var parameters = new EventBridgeV2EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["Endpoint"] = "https://example.com";
            parameters["UseDualStack"] = true;
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonEventBridgeV2EndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Invalid Configuration: Dualstack and custom endpoint are not supported", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridgeV2")]
        [Description("Account-based endpoint when mode is preferred and account ID is available.")]
        public void Accountbased_endpoint_when_mode_is_preferred_and_account_ID_is_available_Test()
        {
            var parameters = new EventBridgeV2EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["AccountId"] = "123456789012";
            parameters["AccountIdEndpointMode"] = "preferred";
            var endpoint = new AmazonEventBridgeV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://123456789012.eventsv2.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridgeV2")]
        [Description("Regional endpoint when mode is disabled.")]
        public void Regional_endpoint_when_mode_is_disabled_Test()
        {
            var parameters = new EventBridgeV2EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["AccountId"] = "123456789012";
            parameters["AccountIdEndpointMode"] = "disabled";
            var endpoint = new AmazonEventBridgeV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://eventsv2.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridgeV2")]
        [Description("Regional FIPS endpoint when mode is disabled.")]
        public void Regional_FIPS_endpoint_when_mode_is_disabled_Test()
        {
            var parameters = new EventBridgeV2EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["AccountId"] = "123456789012";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonEventBridgeV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://eventsv2-fips.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridgeV2")]
        [Description("Regional DualStack endpoint when mode is disabled.")]
        public void Regional_DualStack_endpoint_when_mode_is_disabled_Test()
        {
            var parameters = new EventBridgeV2EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["AccountId"] = "123456789012";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://eventsv2.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridgeV2")]
        [Description("Regional FIPS + DualStack endpoint when mode is disabled.")]
        public void Regional_FIPS_DualStack_endpoint_when_mode_is_disabled_Test()
        {
            var parameters = new EventBridgeV2EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["AccountId"] = "123456789012";
            parameters["AccountIdEndpointMode"] = "disabled";
            parameters["UseFIPS"] = true;
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://eventsv2-fips.us-east-1.api.aws", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridgeV2")]
        [Description("Regional endpoint when no account ID is available and mode is preferred.")]
        public void Regional_endpoint_when_no_account_ID_is_available_and_mode_is_preferred_Test()
        {
            var parameters = new EventBridgeV2EndpointParameters();
            parameters["Region"] = "eu-west-1";
            parameters["AccountIdEndpointMode"] = "preferred";
            var endpoint = new AmazonEventBridgeV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://eventsv2.eu-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridgeV2")]
        [Description("Error when mode is required but no account ID is available.")]
        public void Error_when_mode_is_required_but_no_account_ID_is_available_Test()
        {
            var parameters = new EventBridgeV2EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["AccountIdEndpointMode"] = "required";
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonEventBridgeV2EndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"AccountIdEndpointMode is required but no AccountID was provided or able to be loaded", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridgeV2")]
        [Description("Account-based endpoint in the aws-cn partition when mode is required (account routing works in every partition).")]
        public void Accountbased_endpoint_in_the_awscn_partition_when_mode_is_required_account_routing_works_in_every_partition_Test()
        {
            var parameters = new EventBridgeV2EndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["AccountId"] = "123456789012";
            parameters["AccountIdEndpointMode"] = "required";
            var endpoint = new AmazonEventBridgeV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://123456789012.eventsv2.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridgeV2")]
        [Description("Error when the credentials-sourced account ID is not a valid host label.")]
        public void Error_when_the_credentialssourced_account_ID_is_not_a_valid_host_label_Test()
        {
            var parameters = new EventBridgeV2EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["AccountId"] = "not/valid";
            parameters["AccountIdEndpointMode"] = "preferred";
            var exception = Assert.ThrowsExactly<AmazonClientException>(() => {
                new AmazonEventBridgeV2EndpointProvider().ResolveEndpoint(parameters);
            });
            Assert.AreEqual(@"Credentials-sourced account ID parameter is invalid", exception.Message);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridgeV2")]
        [Description("Regional endpoint when AccountIdEndpointMode is not set at all, even with an account ID and bus ARN available. The explicit empty properties pin that regional endpoints carry no adoption metric.")]
        public void Regional_endpoint_when_AccountIdEndpointMode_is_not_set_at_all_even_with_an_account_ID_and_bus_ARN_available_The_explicit_empty_properties_pin_that_regional_endpoints_carry_no_adoption_metric_Test()
        {
            var parameters = new EventBridgeV2EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["EventBusArn"] = "arn:aws:events:us-east-1:210987654321:event-busv2/owner-bus/abcdefghij0123456789abcde";
            parameters["AccountId"] = "123456789012";
            var endpoint = new AmazonEventBridgeV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://eventsv2.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridgeV2")]
        [Description("Account-based endpoint in the aws-us-gov partition when mode is preferred (account routing works in every partition).")]
        public void Accountbased_endpoint_in_the_awsusgov_partition_when_mode_is_preferred_account_routing_works_in_every_partition_Test()
        {
            var parameters = new EventBridgeV2EndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["AccountId"] = "123456789012";
            parameters["AccountIdEndpointMode"] = "preferred";
            var endpoint = new AmazonEventBridgeV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://123456789012.eventsv2.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridgeV2")]
        [Description("Account-based FIPS endpoint in the aws-us-gov partition when mode is required.")]
        public void Accountbased_FIPS_endpoint_in_the_awsusgov_partition_when_mode_is_required_Test()
        {
            var parameters = new EventBridgeV2EndpointParameters();
            parameters["Region"] = "us-gov-west-1";
            parameters["AccountId"] = "123456789012";
            parameters["AccountIdEndpointMode"] = "required";
            parameters["UseFIPS"] = true;
            var endpoint = new AmazonEventBridgeV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://123456789012.eventsv2-fips.us-gov-west-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridgeV2")]
        [Description("Account-based endpoint in the aws-iso partition when mode is preferred, composing the iso DNS suffix.")]
        public void Accountbased_endpoint_in_the_awsiso_partition_when_mode_is_preferred_composing_the_iso_DNS_suffix_Test()
        {
            var parameters = new EventBridgeV2EndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountId"] = "123456789012";
            parameters["AccountIdEndpointMode"] = "preferred";
            var endpoint = new AmazonEventBridgeV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://123456789012.eventsv2.us-iso-east-1.c2s.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridgeV2")]
        [Description("DualStack account-based endpoint in the aws-iso partition, composing the iso dualstack DNS suffix.")]
        public void DualStack_accountbased_endpoint_in_the_awsiso_partition_composing_the_iso_dualstack_DNS_suffix_Test()
        {
            var parameters = new EventBridgeV2EndpointParameters();
            parameters["Region"] = "us-iso-east-1";
            parameters["AccountId"] = "123456789012";
            parameters["AccountIdEndpointMode"] = "preferred";
            parameters["UseDualStack"] = true;
            var endpoint = new AmazonEventBridgeV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://123456789012.eventsv2.us-iso-east-1.api.aws.ic.gov", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridgeV2")]
        [Description("A parseable bus ARN whose account is not a valid host label falls through to the credentials-sourced account.")]
        public void A_parseable_bus_ARN_whose_account_is_not_a_valid_host_label_falls_through_to_the_credentialssourced_account_Test()
        {
            var parameters = new EventBridgeV2EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["EventBusArn"] = "arn:aws:events:us-east-1:not_a_valid_label!:event-busv2/owner-bus/abcdefghij0123456789abcde";
            parameters["AccountId"] = "123456789012";
            parameters["AccountIdEndpointMode"] = "preferred";
            var endpoint = new AmazonEventBridgeV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://123456789012.eventsv2.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridgeV2")]
        [Description("A bus ARN for another service falls through to the credentials-sourced account.")]
        public void A_bus_ARN_for_another_service_falls_through_to_the_credentialssourced_account_Test()
        {
            var parameters = new EventBridgeV2EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["EventBusArn"] = "arn:aws:sqs:us-east-1:210987654321:some-queue";
            parameters["AccountId"] = "123456789012";
            parameters["AccountIdEndpointMode"] = "preferred";
            var endpoint = new AmazonEventBridgeV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://123456789012.eventsv2.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridgeV2")]
        [Description("Cross-region bus ARN: the ARN account routes within the CLIENT region (cells are per-account per-region).")]
        public void Crossregion_bus_ARN_the_ARN_account_routes_within_the_CLIENT_region_cells_are_peraccount_perregion_Test()
        {
            var parameters = new EventBridgeV2EndpointParameters();
            parameters["Region"] = "us-west-2";
            parameters["EventBusArn"] = "arn:aws:events:us-east-1:210987654321:event-busv2/owner-bus/abcdefghij0123456789abcde";
            parameters["AccountIdEndpointMode"] = "preferred";
            var endpoint = new AmazonEventBridgeV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://210987654321.eventsv2.us-west-2.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridgeV2")]
        [Description("Required mode succeeds through the bus ARN account.")]
        public void Required_mode_succeeds_through_the_bus_ARN_account_Test()
        {
            var parameters = new EventBridgeV2EndpointParameters();
            parameters["Region"] = "us-east-1";
            parameters["EventBusArn"] = "arn:aws:events:us-east-1:210987654321:event-busv2/owner-bus/abcdefghij0123456789abcde";
            parameters["AccountIdEndpointMode"] = "required";
            var endpoint = new AmazonEventBridgeV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://210987654321.eventsv2.us-east-1.amazonaws.com", endpoint.URL);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Endpoints")]
        [TestCategory("EventBridgeV2")]
        [Description("Account-based endpoint in the aws-cn partition when mode is preferred, composing the cn DNS suffix.")]
        public void Accountbased_endpoint_in_the_awscn_partition_when_mode_is_preferred_composing_the_cn_DNS_suffix_Test()
        {
            var parameters = new EventBridgeV2EndpointParameters();
            parameters["Region"] = "cn-north-1";
            parameters["AccountId"] = "123456789012";
            parameters["AccountIdEndpointMode"] = "preferred";
            var endpoint = new AmazonEventBridgeV2EndpointProvider().ResolveEndpoint(parameters);
            Assert.AreEqual("https://123456789012.eventsv2.cn-north-1.amazonaws.com.cn", endpoint.URL);
        }

    }
}