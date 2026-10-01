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
    /// Container for the parameters to the CreateSegmentSnapshot operation. Triggers a job
    /// to export a segment to a specified destination.
    /// </summary>
    public partial class CreateSegmentSnapshotRequest : AmazonCustomerProfilesRequest
    {
        /// <summary>
        /// Gets and sets the property DataFormat. 
        /// <para>
        /// The format in which the segment will be exported.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DataFormat DataFormat { get; set; }

        /// <summary>
        /// Checks to see if the DataFormat property is set.
        /// </summary>
        internal bool IsSetDataFormat() => this.DataFormat != null;

        /// <summary>
        /// Gets and sets the property DestinationUri. 
        /// <para>
        /// The destination to which the segment will be exported. This field must be provided
        /// if the request is not submitted from the Connect Customer Admin Website.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string DestinationUri { get; set; }

        /// <summary>
        /// Checks to see if the DestinationUri property is set.
        /// </summary>
        internal bool IsSetDestinationUri() => this.DestinationUri != null;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The unique name of the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property EncryptionKey. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the KMS key used to encrypt the exported segment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string EncryptionKey { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionKey property is set.
        /// </summary>
        internal bool IsSetEncryptionKey() => this.EncryptionKey != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that allows Customer Profiles service
        /// principal to assume the role for conducting KMS and S3 operations.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property SegmentDefinitionName. 
        /// <para>
        /// The name of the segment definition used in this snapshot request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string SegmentDefinitionName { get; set; }

        /// <summary>
        /// Checks to see if the SegmentDefinitionName property is set.
        /// </summary>
        internal bool IsSetSegmentDefinitionName() => this.SegmentDefinitionName != null;
    }
}
