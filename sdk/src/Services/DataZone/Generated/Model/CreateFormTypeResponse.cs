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
    /// This is the response object from the CreateFormType operation.
    /// </summary>
    public partial class CreateFormTypeResponse : AmazonWebServiceResponse
    {
        private string _description;
        private string _domainId;
        private string _name;
        private string _originDomainId;
        private string _originProjectId;
        private string _owningProjectId;
        private string _revision;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of this Amazon DataZone metadata form type.
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
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The ID of the Amazon DataZone domain in which this metadata form type is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DomainId
        {
            get { return this._domainId; }
            set { this._domainId = value; }
        }

        // Check to see if DomainId property is set
        internal bool IsSetDomainId()
        {
            return this._domainId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of this Amazon DataZone metadata form type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=128)]
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
        /// Gets and sets the property OriginDomainId. 
        /// <para>
        /// The ID of the Amazon DataZone domain in which this metadata form type was originally
        /// created.
        /// </para>
        /// </summary>
        public string OriginDomainId
        {
            get { return this._originDomainId; }
            set { this._originDomainId = value; }
        }

        // Check to see if OriginDomainId property is set
        internal bool IsSetOriginDomainId()
        {
            return this._originDomainId != null;
        }

        /// <summary>
        /// Gets and sets the property OriginProjectId. 
        /// <para>
        /// The ID of the project in which this Amazon DataZone metadata form type was originally
        /// created.
        /// </para>
        /// </summary>
        public string OriginProjectId
        {
            get { return this._originProjectId; }
            set { this._originProjectId = value; }
        }

        // Check to see if OriginProjectId property is set
        internal bool IsSetOriginProjectId()
        {
            return this._originProjectId != null;
        }

        /// <summary>
        /// Gets and sets the property OwningProjectId. 
        /// <para>
        /// The ID of the project that owns this Amazon DataZone metadata form type.
        /// </para>
        /// </summary>
        public string OwningProjectId
        {
            get { return this._owningProjectId; }
            set { this._owningProjectId = value; }
        }

        // Check to see if OwningProjectId property is set
        internal bool IsSetOwningProjectId()
        {
            return this._owningProjectId != null;
        }

        /// <summary>
        /// Gets and sets the property Revision. 
        /// <para>
        /// The revision of this Amazon DataZone metadata form type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Revision
        {
            get { return this._revision; }
            set { this._revision = value; }
        }

        // Check to see if Revision property is set
        internal bool IsSetRevision()
        {
            return this._revision != null;
        }

    }
}