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
 * Do not modify this file. This file is generated from the observabilityadmin-2018-05-10.normal.json service model.
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
namespace Amazon.ObservabilityAdmin.Model
{
    /// <summary>
    /// This is the response object from the GetS3TableIntegration operation.
    /// </summary>
    public partial class GetS3TableIntegrationResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private long? _createdTimeStamp;
        private string _destinationTableBucketArn;
        private Encryption _encryption;
        private string _roleArn;
        private IntegrationStatus _status;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the S3 Table integration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1011)]
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
        /// Gets and sets the property CreatedTimeStamp. 
        /// <para>
        /// The timestamp when the S3 Table integration was created.
        /// </para>
        /// </summary>
        public long CreatedTimeStamp
        {
            get { return this._createdTimeStamp.GetValueOrDefault(); }
            set { this._createdTimeStamp = value; }
        }

        // Check to see if CreatedTimeStamp property is set
        internal bool IsSetCreatedTimeStamp()
        {
            return this._createdTimeStamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DestinationTableBucketArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the S3 bucket used as the destination for the table
        /// data.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1011)]
        public string DestinationTableBucketArn
        {
            get { return this._destinationTableBucketArn; }
            set { this._destinationTableBucketArn = value; }
        }

        // Check to see if DestinationTableBucketArn property is set
        internal bool IsSetDestinationTableBucketArn()
        {
            return this._destinationTableBucketArn != null;
        }

        /// <summary>
        /// Gets and sets the property Encryption. 
        /// <para>
        /// The encryption configuration for the S3 Table integration.
        /// </para>
        /// </summary>
        public Encryption Encryption
        {
            get { return this._encryption; }
            set { this._encryption = value; }
        }

        // Check to see if Encryption property is set
        internal bool IsSetEncryption()
        {
            return this._encryption != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role used by the S3 Table integration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1011)]
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the S3 Table integration.
        /// </para>
        /// </summary>
        public IntegrationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}