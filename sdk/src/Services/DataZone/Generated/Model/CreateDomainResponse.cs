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
    /// This is the response object from the CreateDomain operation.
    /// </summary>
    public partial class CreateDomainResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private string _description;
        private string _domainExecutionRole;
        private DomainVersion _domainVersion;
        private string _id;
        private string _kmsKeyIdentifier;
        private string _name;
        private string _portalUrl;
        private string _rootDomainUnitId;
        private string _serviceRole;
        private SingleSignOn _singleSignOn;
        private DomainStatus _status;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the Amazon DataZone domain.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the Amazon DataZone domain.
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
        /// Gets and sets the property DomainExecutionRole. 
        /// <para>
        /// The domain execution role that is created when an Amazon DataZone domain is created.
        /// The domain execution role is created in the Amazon Web Services account that houses
        /// the Amazon DataZone domain.
        /// </para>
        /// </summary>
        public string DomainExecutionRole
        {
            get { return this._domainExecutionRole; }
            set { this._domainExecutionRole = value; }
        }

        // Check to see if DomainExecutionRole property is set
        internal bool IsSetDomainExecutionRole()
        {
            return this._domainExecutionRole != null;
        }

        /// <summary>
        /// Gets and sets the property DomainVersion. 
        /// <para>
        /// The version of the domain that is created.
        /// </para>
        /// </summary>
        public DomainVersion DomainVersion
        {
            get { return this._domainVersion; }
            set { this._domainVersion = value; }
        }

        // Check to see if DomainVersion property is set
        internal bool IsSetDomainVersion()
        {
            return this._domainVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the Amazon DataZone domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyIdentifier. 
        /// <para>
        /// The identifier of the Amazon Web Services Key Management Service (KMS) key that is
        /// used to encrypt the Amazon DataZone domain, metadata, and reporting data. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string KmsKeyIdentifier
        {
            get { return this._kmsKeyIdentifier; }
            set { this._kmsKeyIdentifier = value; }
        }

        // Check to see if KmsKeyIdentifier property is set
        internal bool IsSetKmsKeyIdentifier()
        {
            return this._kmsKeyIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the Amazon DataZone domain.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property PortalUrl. 
        /// <para>
        /// The URL of the data portal for this Amazon DataZone domain.
        /// </para>
        /// </summary>
        public string PortalUrl
        {
            get { return this._portalUrl; }
            set { this._portalUrl = value; }
        }

        // Check to see if PortalUrl property is set
        internal bool IsSetPortalUrl()
        {
            return this._portalUrl != null;
        }

        /// <summary>
        /// Gets and sets the property RootDomainUnitId. 
        /// <para>
        /// The ID of the root domain unit.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string RootDomainUnitId
        {
            get { return this._rootDomainUnitId; }
            set { this._rootDomainUnitId = value; }
        }

        // Check to see if RootDomainUnitId property is set
        internal bool IsSetRootDomainUnitId()
        {
            return this._rootDomainUnitId != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceRole. 
        /// <para>
        /// Te service role of the domain that is created.
        /// </para>
        /// </summary>
        public string ServiceRole
        {
            get { return this._serviceRole; }
            set { this._serviceRole = value; }
        }

        // Check to see if ServiceRole property is set
        internal bool IsSetServiceRole()
        {
            return this._serviceRole != null;
        }

        /// <summary>
        /// Gets and sets the property SingleSignOn. 
        /// <para>
        /// The single-sign on configuration of the Amazon DataZone domain.
        /// </para>
        /// </summary>
        public SingleSignOn SingleSignOn
        {
            get { return this._singleSignOn; }
            set { this._singleSignOn = value; }
        }

        // Check to see if SingleSignOn property is set
        internal bool IsSetSingleSignOn()
        {
            return this._singleSignOn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the Amazon DataZone domain.
        /// </para>
        /// </summary>
        public DomainStatus Status
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags specified for the Amazon DataZone domain.
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