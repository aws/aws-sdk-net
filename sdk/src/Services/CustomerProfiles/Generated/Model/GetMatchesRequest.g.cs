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
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// Container for the parameters to the GetMatches operation. Before calling this API,
    /// use <a href="https://docs.aws.amazon.com/customerprofiles/latest/APIReference/API_CreateDomain.html">CreateDomain</a>
    /// or <a href="https://docs.aws.amazon.com/customerprofiles/latest/APIReference/API_UpdateDomain.html">UpdateDomain</a>
    /// to enable identity resolution: set <c>Matching</c> to true. <para> GetMatches returns
    /// potentially matching profiles, based on the results of the latest run of a machine
    /// learning process. </para> <important> <para> The process of matching duplicate profiles.
    /// If <c>Matching</c> = <c>true</c>, Amazon Connect Customer Profiles starts a weekly
    /// batch process called Identity Resolution Job. If you do not specify a date and time
    /// for Identity Resolution Job to run, by default it runs every Saturday at 12AM UTC
    /// to detect duplicate profiles in your domains. </para> <para> After the Identity Resolution
    /// Job completes, use the <a href="https://docs.aws.amazon.com/customerprofiles/latest/APIReference/API_GetMatches.html">GetMatches</a>
    /// API to return and review the results. Or, if you have configured <c>ExportingConfig</c>
    /// in the <c>MatchingRequest</c>, you can download the results from S3. </para> </important>
    /// <para> Amazon Connect uses the following profile attributes to identify matches: </para>
    /// <ul> <li> <para> PhoneNumber </para> </li> <li> <para> HomePhoneNumber </para> </li>
    /// <li> <para> BusinessPhoneNumber </para> </li> <li> <para> MobilePhoneNumber </para>
    /// </li> <li> <para> EmailAddress </para> </li> <li> <para> PersonalEmailAddress </para>
    /// </li> <li> <para> BusinessEmailAddress </para> </li> <li> <para> FullName </para>
    /// </li> </ul> <para> For example, two or more profiles—with spelling mistakes such as
    /// <b>John Doe</b> and <b>Jhn Doe</b>, or different casing email addresses such as <b>JOHN_DOE@ANYCOMPANY.COM</b>
    /// and <b>johndoe@anycompany.com</b>, or different phone number formats such as <b>555-010-0000</b>
    /// and <b>+1-555-010-0000</b>—can be detected as belonging to the same customer <b>John
    /// Doe</b> and merged into a unified profile. </para>
    /// </summary>
    public partial class GetMatchesRequest : AmazonCustomerProfilesRequest
    {
        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The unique name of the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return per page.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of results. Use the value returned in the previous response
        /// in the next request to retrieve the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
