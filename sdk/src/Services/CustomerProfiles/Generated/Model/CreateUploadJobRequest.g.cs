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

namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// Container for the parameters to the CreateUploadJob operation. Creates an Upload job
    /// to ingest data for segment imports. The metadata is created for the job with the provided
    /// field mapping and unique key.
    /// </summary>
    public partial class CreateUploadJobRequest : AmazonCustomerProfilesRequest
    {
        /// <summary>
        /// Gets and sets the property DataExpiry. 
        /// <para>
        /// The expiry duration for the profiles ingested with the job. If not provided, the system
        /// default of 2 weeks is used. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1098)]
        public int? DataExpiry { get; set; }

        /// <summary>
        /// Checks to see if the DataExpiry property is set.
        /// </summary>
        internal bool IsSetDataExpiry() => this.DataExpiry.HasValue;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The unique name of the upload job. Could be a file name to identify the upload job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The unique name of the domain. Domain should be exists for the upload job to be created.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property Fields. 
        /// <para>
        /// The mapping between CSV Columns and Profile Object attributes. A map of the name and
        /// ObjectType field.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public Dictionary<string, ObjectTypeField> Fields { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, ObjectTypeField>() : null;

        /// <summary>
        /// Checks to see if the Fields property is set.
        /// </summary>
        internal bool IsSetFields() => this.Fields != null && (this.Fields.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UniqueKey. 
        /// <para>
        /// The unique key columns for de-duping the profiles used to map data to the profile.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1000)]
        public string UniqueKey { get; set; }

        /// <summary>
        /// Checks to see if the UniqueKey property is set.
        /// </summary>
        internal bool IsSetUniqueKey() => this.UniqueKey != null;
    }
}
