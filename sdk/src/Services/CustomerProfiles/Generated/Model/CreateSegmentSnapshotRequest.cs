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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
    /// Container for the parameters to the CreateSegmentSnapshot operation.
    /// Triggers a job to export a segment to a specified destination.
    /// </summary>
    public partial class CreateSegmentSnapshotRequest : AmazonCustomerProfilesRequest
    {
        private DataFormat _dataFormat;
        private string _destinationUri;
        private string _domainName;
        private string _encryptionKey;
        private string _roleArn;
        private string _segmentDefinitionName;

        /// <summary>
        /// Gets and sets the property DataFormat. 
        /// <para>
        /// The format in which the segment will be exported.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DataFormat DataFormat
        {
            get { return this._dataFormat; }
            set { this._dataFormat = value; }
        }

        // Check to see if DataFormat property is set
        internal bool IsSetDataFormat()
        {
            return this._dataFormat != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationUri. 
        /// <para>
        /// The destination to which the segment will be exported. This field must be provided
        /// if the request is not submitted from the Amazon Connect Admin Website.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string DestinationUri
        {
            get { return this._destinationUri; }
            set { this._destinationUri = value; }
        }

        // Check to see if DestinationUri property is set
        internal bool IsSetDestinationUri()
        {
            return this._destinationUri != null;
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The unique name of the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionKey. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the KMS key used to encrypt the exported segment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string EncryptionKey
        {
            get { return this._encryptionKey; }
            set { this._encryptionKey = value; }
        }

        // Check to see if EncryptionKey property is set
        internal bool IsSetEncryptionKey()
        {
            return this._encryptionKey != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that allows Customer Profiles service
        /// principal to assume the role for conducting KMS and S3 operations.
        /// </para>
        /// </summary>
        [AWSProperty(Max=512)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property SegmentDefinitionName. 
        /// <para>
        /// The name of the segment definition used in this snapshot request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string SegmentDefinitionName
        {
            get { return this._segmentDefinitionName; }
            set { this._segmentDefinitionName = value; }
        }

        // Check to see if SegmentDefinitionName property is set
        internal bool IsSetSegmentDefinitionName()
        {
            return this._segmentDefinitionName != null;
        }

    }
}