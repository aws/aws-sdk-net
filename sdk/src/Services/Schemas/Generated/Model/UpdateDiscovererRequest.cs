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
 * Do not modify this file. This file is generated from the schemas-2019-12-02.normal.json service model.
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
namespace Amazon.Schemas.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDiscoverer operation.
    /// Updates the discoverer
    /// </summary>
    public partial class UpdateDiscovererRequest : AmazonSchemasRequest
    {
        private bool? _crossAccount;
        private string _description;
        private string _discovererId;

        /// <summary>
        /// Gets and sets the property CrossAccount. 
        /// <para>
        /// Support discovery of schemas in events sent to the bus from another account. (default:
        /// true)
        /// </para>
        /// </summary>
        public bool? CrossAccount
        {
            get { return this._crossAccount; }
            set { this._crossAccount = value; }
        }

        // Check to see if CrossAccount property is set
        internal bool IsSetCrossAccount()
        {
            return this._crossAccount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the discoverer to update.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DiscovererId. 
        /// <para>
        /// The ID of the discoverer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DiscovererId
        {
            get { return this._discovererId; }
            set { this._discovererId = value; }
        }

        // Check to see if DiscovererId property is set
        internal bool IsSetDiscovererId()
        {
            return this._discovererId != null;
        }

    }
}