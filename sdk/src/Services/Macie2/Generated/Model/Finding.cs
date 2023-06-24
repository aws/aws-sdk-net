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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Provides the details of a finding.
    /// </summary>
    public partial class Finding
    {
        private string _accountId;
        private bool? _archived;
        private FindingCategory _category;
        private ClassificationDetails _classificationDetails;
        private long? _count;
        private DateTime? _createdAt;
        private string _description;
        private string _id;
        private string _partition;
        private PolicyDetails _policyDetails;
        private string _region;
        private ResourcesAffected _resourcesAffected;
        private bool? _sample;
        private string _schemaVersion;
        private Severity _severity;
        private string _title;
        private FindingType _type;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The unique identifier for the Amazon Web Services account that the finding applies
        /// to. This is typically the account that owns the affected resource.
        /// </para>
        /// </summary>
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property Archived. 
        /// <para>
        /// Specifies whether the finding is archived (suppressed).
        /// </para>
        /// </summary>
        public bool Archived
        {
            get { return this._archived.GetValueOrDefault(); }
            set { this._archived = value; }
        }

        // Check to see if Archived property is set
        internal bool IsSetArchived()
        {
            return this._archived.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// The category of the finding. Possible values are: CLASSIFICATION, for a sensitive
        /// data finding; and, POLICY, for a policy finding.
        /// </para>
        /// </summary>
        public FindingCategory Category
        {
            get { return this._category; }
            set { this._category = value; }
        }

        // Check to see if Category property is set
        internal bool IsSetCategory()
        {
            return this._category != null;
        }

        /// <summary>
        /// Gets and sets the property ClassificationDetails. 
        /// <para>
        /// The details of a sensitive data finding. This value is null for a policy finding.
        /// </para>
        /// </summary>
        public ClassificationDetails ClassificationDetails
        {
            get { return this._classificationDetails; }
            set { this._classificationDetails = value; }
        }

        // Check to see if ClassificationDetails property is set
        internal bool IsSetClassificationDetails()
        {
            return this._classificationDetails != null;
        }

        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The total number of occurrences of the finding. For sensitive data findings, this
        /// value is always 1. All sensitive data findings are considered unique.
        /// </para>
        /// </summary>
        public long Count
        {
            get { return this._count.GetValueOrDefault(); }
            set { this._count = value; }
        }

        // Check to see if Count property is set
        internal bool IsSetCount()
        {
            return this._count.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time, in UTC and extended ISO 8601 format, when Amazon Macie created
        /// the finding.
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the finding.
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for the finding. This is a random string that Amazon Macie generates
        /// and assigns to a finding when it creates the finding.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Partition. 
        /// <para>
        /// The Amazon Web Services partition that Amazon Macie created the finding in.
        /// </para>
        /// </summary>
        public string Partition
        {
            get { return this._partition; }
            set { this._partition = value; }
        }

        // Check to see if Partition property is set
        internal bool IsSetPartition()
        {
            return this._partition != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyDetails. 
        /// <para>
        /// The details of a policy finding. This value is null for a sensitive data finding.
        /// </para>
        /// </summary>
        public PolicyDetails PolicyDetails
        {
            get { return this._policyDetails; }
            set { this._policyDetails = value; }
        }

        // Check to see if PolicyDetails property is set
        internal bool IsSetPolicyDetails()
        {
            return this._policyDetails != null;
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Region that Amazon Macie created the finding in.
        /// </para>
        /// </summary>
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property ResourcesAffected. 
        /// <para>
        /// The resources that the finding applies to.
        /// </para>
        /// </summary>
        public ResourcesAffected ResourcesAffected
        {
            get { return this._resourcesAffected; }
            set { this._resourcesAffected = value; }
        }

        // Check to see if ResourcesAffected property is set
        internal bool IsSetResourcesAffected()
        {
            return this._resourcesAffected != null;
        }

        /// <summary>
        /// Gets and sets the property Sample. 
        /// <para>
        /// Specifies whether the finding is a sample finding. A <i>sample finding</i> is a finding
        /// that uses example data to demonstrate what a finding might contain.
        /// </para>
        /// </summary>
        public bool Sample
        {
            get { return this._sample.GetValueOrDefault(); }
            set { this._sample = value; }
        }

        // Check to see if Sample property is set
        internal bool IsSetSample()
        {
            return this._sample.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SchemaVersion. 
        /// <para>
        /// The version of the schema that was used to define the data structures in the finding.
        /// </para>
        /// </summary>
        public string SchemaVersion
        {
            get { return this._schemaVersion; }
            set { this._schemaVersion = value; }
        }

        // Check to see if SchemaVersion property is set
        internal bool IsSetSchemaVersion()
        {
            return this._schemaVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// The severity level and score for the finding.
        /// </para>
        /// </summary>
        public Severity Severity
        {
            get { return this._severity; }
            set { this._severity = value; }
        }

        // Check to see if Severity property is set
        internal bool IsSetSeverity()
        {
            return this._severity != null;
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The brief description of the finding.
        /// </para>
        /// </summary>
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the finding.
        /// </para>
        /// </summary>
        public FindingType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time, in UTC and extended ISO 8601 format, when Amazon Macie last updated
        /// the finding. For sensitive data findings, this value is the same as the value for
        /// the createdAt property. All sensitive data findings are considered new.
        /// </para>
        /// </summary>
        public DateTime UpdatedAt
        {
            get { return this._updatedAt.GetValueOrDefault(); }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}