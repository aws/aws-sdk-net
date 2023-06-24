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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// Container for the parameters to the ListSuppressedDestinations operation.
    /// Retrieves a list of email addresses that are on the suppression list for your account.
    /// </summary>
    public partial class ListSuppressedDestinationsRequest : AmazonSimpleEmailServiceV2Request
    {
        private DateTime? _endDate;
        private string _nextToken;
        private int? _pageSize;
        private List<string> _reasons = new List<string>();
        private DateTime? _startDate;

        /// <summary>
        /// Gets and sets the property EndDate. 
        /// <para>
        /// Used to filter the list of suppressed email destinations so that it only includes
        /// addresses that were added to the list before a specific date.
        /// </para>
        /// </summary>
        public DateTime EndDate
        {
            get { return this._endDate.GetValueOrDefault(); }
            set { this._endDate = value; }
        }

        // Check to see if EndDate property is set
        internal bool IsSetEndDate()
        {
            return this._endDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token returned from a previous call to <code>ListSuppressedDestinations</code> to
        /// indicate the position in the list of suppressed email addresses.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property PageSize. 
        /// <para>
        /// The number of results to show in a single call to <code>ListSuppressedDestinations</code>.
        /// If the number of results is larger than the number you specified in this parameter,
        /// then the response includes a <code>NextToken</code> element, which you can use to
        /// obtain additional results.
        /// </para>
        /// </summary>
        public int PageSize
        {
            get { return this._pageSize.GetValueOrDefault(); }
            set { this._pageSize = value; }
        }

        // Check to see if PageSize property is set
        internal bool IsSetPageSize()
        {
            return this._pageSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Reasons. 
        /// <para>
        /// The factors that caused the email address to be added to .
        /// </para>
        /// </summary>
        public List<string> Reasons
        {
            get { return this._reasons; }
            set { this._reasons = value; }
        }

        // Check to see if Reasons property is set
        internal bool IsSetReasons()
        {
            return this._reasons != null && this._reasons.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StartDate. 
        /// <para>
        /// Used to filter the list of suppressed email destinations so that it only includes
        /// addresses that were added to the list after a specific date.
        /// </para>
        /// </summary>
        public DateTime StartDate
        {
            get { return this._startDate.GetValueOrDefault(); }
            set { this._startDate = value; }
        }

        // Check to see if StartDate property is set
        internal bool IsSetStartDate()
        {
            return this._startDate.HasValue; 
        }

    }
}