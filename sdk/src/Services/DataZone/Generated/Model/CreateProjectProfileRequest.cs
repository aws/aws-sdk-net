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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// Container for the parameters to the CreateProjectProfile operation.
    /// Creates a project profile.
    /// </summary>
    public partial class CreateProjectProfileRequest : AmazonDataZoneRequest
    {
        private string _description;
        private string _domainIdentifier;
        private string _domainUnitIdentifier;
        private List<EnvironmentConfiguration> _environmentConfigurations = AWSConfigs.InitializeCollections ? new List<EnvironmentConfiguration>() : null;
        private string _name;
        private Status _status;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of a project profile.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=2048)]
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
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// A domain ID of the project profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DomainIdentifier
        {
            get { return this._domainIdentifier; }
            set { this._domainIdentifier = value; }
        }

        // Check to see if DomainIdentifier property is set
        internal bool IsSetDomainIdentifier()
        {
            return this._domainIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property DomainUnitIdentifier. 
        /// <para>
        /// A domain unit ID of the project profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string DomainUnitIdentifier
        {
            get { return this._domainUnitIdentifier; }
            set { this._domainUnitIdentifier = value; }
        }

        // Check to see if DomainUnitIdentifier property is set
        internal bool IsSetDomainUnitIdentifier()
        {
            return this._domainUnitIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentConfigurations. 
        /// <para>
        /// Environment configurations of the project profile.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EnvironmentConfiguration> EnvironmentConfigurations
        {
            get { return this._environmentConfigurations; }
            set { this._environmentConfigurations = value; }
        }

        // Check to see if EnvironmentConfigurations property is set
        internal bool IsSetEnvironmentConfigurations()
        {
            return this._environmentConfigurations != null && (this._environmentConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Project profile name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=64)]
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
        /// Project profile status.
        /// </para>
        /// </summary>
        public Status Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}