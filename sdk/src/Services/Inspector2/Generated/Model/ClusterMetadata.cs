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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
        private AwsEcsMetadataDetails _awsEcsMetadataDetails;
        private AwsEksMetadataDetails _awsEksMetadataDetails;

        /// <summary>
        /// Gets and sets the property AwsEcsMetadataDetails. 
        /// <para>
        /// The details for an Amazon ECS cluster in the cluster metadata.
        /// </para>
        /// </summary>
        public AwsEcsMetadataDetails AwsEcsMetadataDetails
        {
            get { return this._awsEcsMetadataDetails; }
            set { this._awsEcsMetadataDetails = value; }
        }

        // Check to see if AwsEcsMetadataDetails property is set
        internal bool IsSetAwsEcsMetadataDetails()
        {
            return this._awsEcsMetadataDetails != null;
        }

        /// <summary>
        /// Gets and sets the property AwsEksMetadataDetails. 
        /// <para>
        /// The details for an Amazon EKS cluster in the cluster metadata.
        /// </para>
        /// </summary>
        public AwsEksMetadataDetails AwsEksMetadataDetails
        {
            get { return this._awsEksMetadataDetails; }
            set { this._awsEksMetadataDetails = value; }
        }

        // Check to see if AwsEksMetadataDetails property is set
        internal bool IsSetAwsEksMetadataDetails()
        {
            return this._awsEksMetadataDetails != null;
        }

    }
}