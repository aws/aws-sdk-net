/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes a domain where you are storing recordsets in Lightsail.
    /// </summary>
    public partial class Domain
    {
        private string _arn;
        private DateTime? _createdAt;
        private List<DomainEntry> _domainEntries = new List<DomainEntry>();
        private ResourceLocation _location;
        private string _name;
        private ResourceType _resourceType;
        private string _supportCode;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the domain recordset (e.g., <code>arn:aws:lightsail:global:123456789101:Domain/824cede0-abc7-4f84-8dbc-12345EXAMPLE</code>).
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
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date when the domain recordset was created.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DomainEntries. 
        /// <para>
        /// An array of key-value pairs containing information about the domain entries.
        /// </para>
        /// </summary>
        public List<DomainEntry> DomainEntries
        {
            get { return this._domainEntries; }
            set { this._domainEntries = value; }
        }

        // Check to see if DomainEntries property is set
        internal bool IsSetDomainEntries()
        {
            return this._domainEntries != null && this._domainEntries.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The AWS Region and Availability Zones where the domain recordset was created.
        /// </para>
        /// </summary>
        public ResourceLocation Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the domain.
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
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The resource type. 
        /// </para>
        /// </summary>
        public ResourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property SupportCode. 
        /// <para>
        /// The support code. Include this code in your email to support when you have questions
        /// about an instance or another resource in Lightsail. This code enables our support
        /// team to look up your Lightsail information more easily.
        /// </para>
        /// </summary>
        public string SupportCode
        {
            get { return this._supportCode; }
            set { this._supportCode = value; }
        }

        // Check to see if SupportCode property is set
        internal bool IsSetSupportCode()
        {
            return this._supportCode != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tag keys and optional values for the resource. For more information about tags
        /// in Lightsail, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-tags">Lightsail
        /// Dev Guide</a>.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}