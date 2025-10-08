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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
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
namespace Amazon.Outposts.Model
{
    /// <summary>
    /// Container for the parameters to the StartOutpostDecommission operation.
    /// Starts the decommission process to return the Outposts racks or servers.
    /// </summary>
    public partial class StartOutpostDecommissionRequest : AmazonOutpostsRequest
    {
        private string _outpostIdentifier;
        private bool? _validateOnly;

        /// <summary>
        /// Gets and sets the property OutpostIdentifier. 
        /// <para>
        /// The ID or ARN of the Outpost that you want to decommission.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=180)]
        public string OutpostIdentifier
        {
            get { return this._outpostIdentifier; }
            set { this._outpostIdentifier = value; }
        }

        // Check to see if OutpostIdentifier property is set
        internal bool IsSetOutpostIdentifier()
        {
            return this._outpostIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ValidateOnly. 
        /// <para>
        /// Validates the request without starting the decommission process.
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