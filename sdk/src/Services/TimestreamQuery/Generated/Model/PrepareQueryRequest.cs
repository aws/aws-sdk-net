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
 * Do not modify this file. This file is generated from the timestream-query-2018-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.TimestreamQuery.Model
{
    /// <summary>
    /// Container for the parameters to the PrepareQuery operation.
    /// A synchronous operation that allows you to submit a query with parameters to be stored
    /// by Timestream for later running. Timestream only supports using this operation with
    /// the <code>PrepareQueryRequest$ValidateOnly</code> set to <code>true</code>.
    /// </summary>
    public partial class PrepareQueryRequest : AmazonTimestreamQueryRequest
    {
        private string _queryString;
        private bool? _validateOnly;

        /// <summary>
        /// Gets and sets the property QueryString. 
        /// <para>
        /// The Timestream query string that you want to use as a prepared statement. Parameter
        /// names can be specified in the query string <code>@</code> character followed by an
        /// identifier. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=262144)]
        public string QueryString
        {
            get { return this._queryString; }
            set { this._queryString = value; }
        }

        // Check to see if QueryString property is set
        internal bool IsSetQueryString()
        {
            return this._queryString != null;
        }

        /// <summary>
        /// Gets and sets the property ValidateOnly. 
        /// <para>
        /// By setting this value to <code>true</code>, Timestream will only validate that the
        /// query string is a valid Timestream query, and not store the prepared query for later
        /// use.
        /// </para>
        /// </summary>
        public bool ValidateOnly
        {
            get { return this._validateOnly.GetValueOrDefault(); }
            set { this._validateOnly = value; }
        }

        // Check to see if ValidateOnly property is set
        internal bool IsSetValidateOnly()
        {
            return this._validateOnly.HasValue; 
        }

    }
}