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
    /// This is the response object from the CreateDiscoverer operation.
    /// </summary>
    public partial class CreateDiscovererResponse : AmazonWebServiceResponse
    {
        private bool? _crossAccount;
        private string _description;
        private string _discovererArn;
        private string _discovererId;
        private string _sourceArn;
        private DiscovererState _state;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property CrossAccount. 
        /// <para>
        /// The Status if the discoverer will discover schemas from events sent from another account.
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
        /// The description of the discoverer.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property DiscovererArn. 
        /// <para>
        /// The ARN of the discoverer.
        /// </para>
        /// </summary>
        public string DiscovererArn
        {
            get { return this._discovererArn; }
            set { this._discovererArn = value; }
        }

        // Check to see if DiscovererArn property is set
        internal bool IsSetDiscovererArn()
        {
            return this._discovererArn != null;
        }

        /// <summary>
        /// Gets and sets the property DiscovererId. 
        /// <para>
        /// The ID of the discoverer.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property SourceArn. 
        /// <para>
        /// The ARN of the event bus.
        /// </para>
        /// </summary>
        public string SourceArn
        {
            get { return this._sourceArn; }
            set { this._sourceArn = value; }
        }

        // Check to see if SourceArn property is set
        internal bool IsSetSourceArn()
        {
            return this._sourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the discoverer.
        /// </para>
        /// </summary>
        public DiscovererState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags associated with the resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}