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
 * Do not modify this file. This file is generated from the health-2016-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AWSHealth.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeEventDetailsForOrganization operation.
    /// Returns detailed information about one or more specified events for one or more accounts
    /// in your organization. Information includes standard event data (Region, service, and
    /// so on, as returned by <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_DescribeEventsForOrganization.html">DescribeEventsForOrganization</a>),
    /// a detailed event description, and possible additional metadata that depends upon the
    /// nature of the event. Affected entities are not included; to retrieve those, use the
    /// <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_DescribeAffectedEntitiesForOrganization.html">DescribeAffectedEntitiesForOrganization</a>
    /// operation.
    /// 
    ///  
    /// <para>
    /// Before you can call this operation, you must first enable AWS Health to work with
    /// AWS Organizations. To do this, call the <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_EnableHealthServiceAccessForOrganization.html">EnableHealthServiceAccessForOrganization</a>
    /// operation from your organization's master account.
    /// </para>
    ///  
    /// <para>
    /// When you call the <code>DescribeEventDetailsForOrganization</code> operation, you
    /// specify the <code>organizationEventDetailFilters</code> object in the request. Depending
    /// on the AWS Health event type, note the following differences:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If the event is public, the <code>awsAccountId</code> parameter must be empty. If
    /// you specify an account ID for a public event, then an error message is returned. That's
    /// because the event might apply to all AWS accounts and isn't specific to an account
    /// in your organization.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the event is specific to an account, then you must specify the <code>awsAccountId</code>
    /// parameter in the request. If you don't specify an account ID, an error message returns
    /// because the event is specific to an AWS account in your organization. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_Event.html">Event</a>.
    /// </para>
    /// </summary>
    public partial class DescribeEventDetailsForOrganizationRequest : AmazonAWSHealthRequest
    {
        private string _locale;
        private List<EventAccountFilter> _organizationEventDetailFilters = new List<EventAccountFilter>();

        /// <summary>
        /// Gets and sets the property Locale. 
        /// <para>
        /// The locale (language) to return information in. English (en) is the default and the
        /// only supported value at this time.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=256)]
        public string Locale
        {
            get { return this._locale; }
            set { this._locale = value; }
        }

        // Check to see if Locale property is set
        internal bool IsSetLocale()
        {
            return this._locale != null;
        }

        /// <summary>
        /// Gets and sets the property OrganizationEventDetailFilters. 
        /// <para>
        /// A set of JSON elements that includes the <code>awsAccountId</code> and the <code>eventArn</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<EventAccountFilter> OrganizationEventDetailFilters
        {
            get { return this._organizationEventDetailFilters; }
            set { this._organizationEventDetailFilters = value; }
        }

        // Check to see if OrganizationEventDetailFilters property is set
        internal bool IsSetOrganizationEventDetailFilters()
        {
            return this._organizationEventDetailFilters != null && this._organizationEventDetailFilters.Count > 0; 
        }

    }
}