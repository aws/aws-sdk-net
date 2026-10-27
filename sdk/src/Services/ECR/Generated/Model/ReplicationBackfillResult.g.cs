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

namespace Amazon.ECR.Model
{
    /// <summary>
    /// An object representing the result of a single replication during a replication backfill.
    /// Each image and tag combination is replicated as a single replication.
    /// </summary>
    public partial class ReplicationBackfillResult
    {
        /// <summary>
        /// Gets and sets the property FailureCode. 
        /// <para>
        /// The failure code for a replication that has failed.
        /// </para>
        /// </summary>
        public string FailureCode { get; set; }

        /// <summary>
        /// Checks to see if the FailureCode property is set.
        /// </summary>
        internal bool IsSetFailureCode() => this.FailureCode != null;

        /// <summary>
        /// Gets and sets the property ImageId. 
        /// <para>
        /// An object with identifying information for the image.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ImageIdentifier ImageId { get; set; }

        /// <summary>
        /// Checks to see if the ImageId property is set.
        /// </summary>
        internal bool IsSetImageId() => this.ImageId != null;

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The name of the repository that contains the image.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 256)]
        public string RepositoryName { get; set; }

        /// <summary>
        /// Checks to see if the RepositoryName property is set.
        /// </summary>
        internal bool IsSetRepositoryName() => this.RepositoryName != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The replication status of the image.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ReplicationBackfillResultStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property SubImageFailureCodes. 
        /// <para>
        /// The distinct failure codes for the images referenced by a manifest list that failed
        /// to replicate. Each failure code appears at most once, regardless of how many referenced
        /// images failed with that code. This field is present only when the image is a manifest
        /// list.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SubImageFailureCodes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SubImageFailureCodes property is set.
        /// </summary>
        internal bool IsSetSubImageFailureCodes() => this.SubImageFailureCodes != null && (this.SubImageFailureCodes.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
