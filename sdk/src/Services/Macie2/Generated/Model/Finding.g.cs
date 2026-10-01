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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Provides the details of a finding.
    /// </summary>
    public partial class Finding
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The unique identifier for the Amazon Web Services account that the finding applies
        /// to. This is typically the account that owns the affected resource.
        /// </para>
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property Archived. 
        /// <para>
        /// Specifies whether the finding is archived (suppressed).
        /// </para>
        /// </summary>
        public bool? Archived { get; set; }

        /// <summary>
        /// Checks to see if the Archived property is set.
        /// </summary>
        internal bool IsSetArchived() => this.Archived.HasValue;

        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// The category of the finding. Possible values are: CLASSIFICATION, for a sensitive
        /// data finding; and, POLICY, for a policy finding.
        /// </para>
        /// </summary>
        public FindingCategory Category { get; set; }

        /// <summary>
        /// Checks to see if the Category property is set.
        /// </summary>
        internal bool IsSetCategory() => this.Category != null;

        /// <summary>
        /// Gets and sets the property ClassificationDetails. 
        /// <para>
        /// The details of a sensitive data finding. This value is null for a policy finding.
        /// </para>
        /// </summary>
        public ClassificationDetails ClassificationDetails { get; set; }

        /// <summary>
        /// Checks to see if the ClassificationDetails property is set.
        /// </summary>
        internal bool IsSetClassificationDetails() => this.ClassificationDetails != null;

        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The total number of occurrences of the finding. For sensitive data findings, this
        /// value is always 1. All sensitive data findings are considered unique.
        /// </para>
        /// </summary>
        public long? Count { get; set; }

        /// <summary>
        /// Checks to see if the Count property is set.
        /// </summary>
        internal bool IsSetCount() => this.Count.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time, in UTC and extended ISO 8601 format, when Amazon Macie created
        /// the finding.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the finding.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for the finding. This is a random string that Amazon Macie generates
        /// and assigns to a finding when it creates the finding.
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Partition. 
        /// <para>
        /// The Amazon Web Services partition that Amazon Macie created the finding in.
        /// </para>
        /// </summary>
        public string Partition { get; set; }

        /// <summary>
        /// Checks to see if the Partition property is set.
        /// </summary>
        internal bool IsSetPartition() => this.Partition != null;

        /// <summary>
        /// Gets and sets the property PolicyDetails. 
        /// <para>
        /// The details of a policy finding. This value is null for a sensitive data finding.
        /// </para>
        /// </summary>
        public PolicyDetails PolicyDetails { get; set; }

        /// <summary>
        /// Checks to see if the PolicyDetails property is set.
        /// </summary>
        internal bool IsSetPolicyDetails() => this.PolicyDetails != null;

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Region that Amazon Macie created the finding in.
        /// </para>
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

        /// <summary>
        /// Gets and sets the property ResourcesAffected. 
        /// <para>
        /// The resources that the finding applies to.
        /// </para>
        /// </summary>
        public ResourcesAffected ResourcesAffected { get; set; }

        /// <summary>
        /// Checks to see if the ResourcesAffected property is set.
        /// </summary>
        internal bool IsSetResourcesAffected() => this.ResourcesAffected != null;

        /// <summary>
        /// Gets and sets the property Sample. 
        /// <para>
        /// Specifies whether the finding is a sample finding. A <i>sample finding</i> is a finding
        /// that uses example data to demonstrate what a finding might contain.
        /// </para>
        /// </summary>
        public bool? Sample { get; set; }

        /// <summary>
        /// Checks to see if the Sample property is set.
        /// </summary>
        internal bool IsSetSample() => this.Sample.HasValue;

        /// <summary>
        /// Gets and sets the property SchemaVersion. 
        /// <para>
        /// The version of the schema that was used to define the data structures in the finding.
        /// </para>
        /// </summary>
        public string SchemaVersion { get; set; }

        /// <summary>
        /// Checks to see if the SchemaVersion property is set.
        /// </summary>
        internal bool IsSetSchemaVersion() => this.SchemaVersion != null;

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// The severity level and score for the finding.
        /// </para>
        /// </summary>
        public Severity Severity { get; set; }

        /// <summary>
        /// Checks to see if the Severity property is set.
        /// </summary>
        internal bool IsSetSeverity() => this.Severity != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The brief description of the finding.
        /// </para>
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the finding.
        /// </para>
        /// </summary>
        public FindingType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time, in UTC and extended ISO 8601 format, when Amazon Macie last updated
        /// the finding. For sensitive data findings, this value is the same as the value for
        /// the createdAt property. All sensitive data findings are considered new.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
