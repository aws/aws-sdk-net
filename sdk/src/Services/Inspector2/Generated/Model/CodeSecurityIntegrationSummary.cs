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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// A summary of information about a code security integration.
    /// </summary>
    public partial class CodeSecurityIntegrationSummary
    {
        private DateTime? _createdOn;
        private string _integrationArn;
        private DateTime? _lastUpdateOn;
        private string _name;
        private IntegrationStatus _status;
        private string _statusReason;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private IntegrationType _type;

        /// <summary>
        /// Gets and sets the property CreatedOn. 
        /// <para>
        /// The timestamp when the code security integration was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedOn
        {
            get { return this._createdOn; }
            set { this._createdOn = value; }
        }

        // Check to see if CreatedOn property is set
        internal bool IsSetCreatedOn()
        {
            return this._createdOn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IntegrationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the code security integration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string IntegrationArn
        {
            get { return this._integrationArn; }
            set { this._integrationArn = value; }
        }

        // Check to see if IntegrationArn property is set
        internal bool IsSetIntegrationArn()
        {
            return this._integrationArn != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdateOn. 
        /// <para>
        /// The timestamp when the code security integration was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastUpdateOn
        {
            get { return this._lastUpdateOn; }
            set { this._lastUpdateOn = value; }
        }

        // Check to see if LastUpdateOn property is set
        internal bool IsSetLastUpdateOn()
        {
            return this._lastUpdateOn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the code security integration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=60)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the code security integration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IntegrationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// The reason for the current status of the code security integration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with the code security integration.
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

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of repository provider for the integration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IntegrationType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}