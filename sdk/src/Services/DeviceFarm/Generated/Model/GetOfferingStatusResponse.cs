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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// Returns the status result for a device offering.
    /// </summary>
    public partial class GetOfferingStatusResponse : AmazonWebServiceResponse
    {
        private Dictionary<string, OfferingStatus> _current = new Dictionary<string, OfferingStatus>();
        private Dictionary<string, OfferingStatus> _nextPeriod = new Dictionary<string, OfferingStatus>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Current. 
        /// <para>
        /// When specified, gets the offering status for the current period.
        /// </para>
        /// </summary>
        public Dictionary<string, OfferingStatus> Current
        {
            get { return this._current; }
            set { this._current = value; }
        }

        // Check to see if Current property is set
        internal bool IsSetCurrent()
        {
            return this._current != null && this._current.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextPeriod. 
        /// <para>
        /// When specified, gets the offering status for the next period.
        /// </para>
        /// </summary>
        public Dictionary<string, OfferingStatus> NextPeriod
        {
            get { return this._nextPeriod; }
            set { this._nextPeriod = value; }
        }

        // Check to see if NextPeriod property is set
        internal bool IsSetNextPeriod()
        {
            return this._nextPeriod != null && this._nextPeriod.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An identifier that was returned from the previous call to this operation, which can
        /// be used to return the next set of items in the list.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=1024)]
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

    }
}