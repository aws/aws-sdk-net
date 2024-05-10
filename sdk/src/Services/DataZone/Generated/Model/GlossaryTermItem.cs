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
    /// The details of a business glossary term.
    /// </summary>
    public partial class GlossaryTermItem
    {
        private DateTime? _createdAt;
        private string _createdBy;
        private string _domainId;
        private string _glossaryId;
        private string _id;
        private string _longDescription;
        private string _name;
        private string _shortDescription;
        private GlossaryTermStatus _status;
        private TermRelations _termRelations;
        private DateTime? _updatedAt;
        private string _updatedBy;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp of when a business glossary term was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The Amazon DataZone user who created the business glossary.
        /// </para>
        /// </summary>
        public string CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
        }

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The identifier of the Amazon DataZone domain in which the business glossary exists.
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
        /// Gets and sets the property GlossaryId. 
        /// <para>
        /// The identifier of the business glossary to which the term belongs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string GlossaryId
        {
            get { return this._glossaryId; }
            set { this._glossaryId = value; }
        }

        // Check to see if GlossaryId property is set
        internal bool IsSetGlossaryId()
        {
            return this._glossaryId != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the business glossary term.
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
        /// Gets and sets the property LongDescription. 
        /// <para>
        /// The long description of the business glossary term.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=4096)]
        public string LongDescription
        {
            get { return this._longDescription; }
            set { this._longDescription = value; }
        }

        // Check to see if LongDescription property is set
        internal bool IsSetLongDescription()
        {
            return this._longDescription != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the business glossary term.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=256)]
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
        /// Gets and sets the property ShortDescription. 
        /// <para>
        /// The short description of the business glossary term.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=1024)]
        public string ShortDescription
        {
            get { return this._shortDescription; }
            set { this._shortDescription = value; }
        }

        // Check to see if ShortDescription property is set
        internal bool IsSetShortDescription()
        {
            return this._shortDescription != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the business glossary term.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GlossaryTermStatus Status
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
        /// Gets and sets the property TermRelations. 
        /// <para>
        /// The relations of the business glossary term.
        /// </para>
        /// </summary>
        public TermRelations TermRelations
        {
            get { return this._termRelations; }
            set { this._termRelations = value; }
        }

        // Check to see if TermRelations property is set
        internal bool IsSetTermRelations()
        {
            return this._termRelations != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp of when a business glossary term was updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UpdatedBy. 
        /// <para>
        /// The Amazon DataZone user who updated the business glossary term.
        /// </para>
        /// </summary>
        public string UpdatedBy
        {
            get { return this._updatedBy; }
            set { this._updatedBy = value; }
        }

        // Check to see if UpdatedBy property is set
        internal bool IsSetUpdatedBy()
        {
            return this._updatedBy != null;
        }

    }
}