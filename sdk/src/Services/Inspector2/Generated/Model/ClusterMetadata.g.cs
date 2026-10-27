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

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// The metadata for a cluster.
    /// </summary>
    public partial class ClusterMetadata
    {
        /// <summary>
        /// Gets and sets the property AwsEcsMetadataDetails. 
        /// <para>
        /// The details for an Amazon ECS cluster in the cluster metadata.
        /// </para>
        /// </summary>
        public AwsEcsMetadataDetails AwsEcsMetadataDetails { get; set; }

        /// <summary>
        /// Checks to see if the AwsEcsMetadataDetails property is set.
        /// </summary>
        internal bool IsSetAwsEcsMetadataDetails() => this.AwsEcsMetadataDetails != null;

        /// <summary>
        /// Gets and sets the property AwsEksMetadataDetails. 
        /// <para>
        /// The details for an Amazon EKS cluster in the cluster metadata.
        /// </para>
        /// </summary>
        public AwsEksMetadataDetails AwsEksMetadataDetails { get; set; }

        /// <summary>
        /// Checks to see if the AwsEksMetadataDetails property is set.
        /// </summary>
        internal bool IsSetAwsEksMetadataDetails() => this.AwsEksMetadataDetails != null;
    }
}
