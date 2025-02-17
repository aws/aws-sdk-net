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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
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
namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// An Amazon CloudFront VPC origin.
    /// </summary>
    public partial class VpcOrigin
    {
        private string _arn;
        private DateTime? _createdTime;
        private string _id;
        private DateTime? _lastModifiedTime;
        private string _status;
        private VpcOriginEndpointConfig _vpcOriginEndpointConfig;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The VPC origin ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The VPC origin created time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreatedTime
        {
            get { return this._createdTime.GetValueOrDefault(); }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The VPC origin ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The VPC origin last modified time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime LastModifiedTime
        {
            get { return this._lastModifiedTime.GetValueOrDefault(); }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The VPC origin status.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property VpcOriginEndpointConfig. 
        /// <para>
        /// The VPC origin endpoint configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public VpcOriginEndpointConfig VpcOriginEndpointConfig
        {
            get { return this._vpcOriginEndpointConfig; }
            set { this._vpcOriginEndpointConfig = value; }
        }

        // Check to see if VpcOriginEndpointConfig property is set
        internal bool IsSetVpcOriginEndpointConfig()
        {
            return this._vpcOriginEndpointConfig != null;
        }

    }
}