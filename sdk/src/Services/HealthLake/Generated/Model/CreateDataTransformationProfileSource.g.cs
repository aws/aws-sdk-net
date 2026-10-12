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

namespace Amazon.HealthLake.Model
{
    /// <summary>
    /// The source for initial content when creating a data transformation profile. Specify
    /// exactly one variant: a built-in starter profile, an existing profile version to clone,
    /// raw profile content, or a sample data file.
    /// </summary>
    public partial class CreateDataTransformationProfileSource
    {
        /// <summary>
        /// Gets and sets the property ExistingVersionedProfileId. 
        /// <para>
        /// Creates the profile by cloning an existing profile at a specific version.
        /// </para>
        /// </summary>
        public ExistingVersionedProfileSource ExistingVersionedProfileId { get; set; }

        /// <summary>
        /// Checks to see if the ExistingVersionedProfileId property is set.
        /// </summary>
        internal bool IsSetExistingVersionedProfileId() => this.ExistingVersionedProfileId != null;

        /// <summary>
        /// Gets and sets the property ProfileMapping. 
        /// <para>
        /// Creates the profile from raw profile content that you provide directly. Use this variant
        /// for continuous integration and continuous delivery (CI/CD) workflows.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public ProfileMappingSource ProfileMapping { get; set; }

        /// <summary>
        /// Checks to see if the ProfileMapping property is set.
        /// </summary>
        internal bool IsSetProfileMapping() => this.ProfileMapping != null;

        /// <summary>
        /// Gets and sets the property SampleData. 
        /// <para>
        /// Creates the profile from a sample data file stored in Amazon S3. Valid only when the
        /// source format is Comma-separated values (CSV).
        /// </para>
        /// </summary>
        public SampleDataSource SampleData { get; set; }

        /// <summary>
        /// Checks to see if the SampleData property is set.
        /// </summary>
        internal bool IsSetSampleData() => this.SampleData != null;

        /// <summary>
        /// Gets and sets the property StarterProfile. 
        /// <para>
        /// Creates the profile from a built-in starter profile. Valid only when the source format
        /// is Consolidated Clinical Document Architecture (C-CDA).
        /// </para>
        /// </summary>
        public StarterProfileSource StarterProfile { get; set; }

        /// <summary>
        /// Checks to see if the StarterProfile property is set.
        /// </summary>
        internal bool IsSetStarterProfile() => this.StarterProfile != null;
    }
}
