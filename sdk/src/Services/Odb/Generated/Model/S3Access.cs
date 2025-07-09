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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
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
namespace Amazon.Odb.Model
{
    /// <summary>
    /// The configuration for Amazon S3 access from the ODB network.
    /// </summary>
    public partial class S3Access
    {
        private string _domainName;
        private List<string> _ipv4Addresses = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _s3PolicyDocument;
        private ManagedResourceStatus _status;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The domain name for the Amazon S3 access.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Ipv4Addresses. 
        /// <para>
        /// The IPv4 addresses for the Amazon S3 access.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public List<string> Ipv4Addresses
        {
            get { return this._ipv4Addresses; }
            set { this._ipv4Addresses = value; }
        }

        // Check to see if Ipv4Addresses property is set
        internal bool IsSetIpv4Addresses()
        {
            return this._ipv4Addresses != null && (this._ipv4Addresses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property S3PolicyDocument. 
        /// <para>
        /// The endpoint policy for the Amazon S3 access.
        /// </para>
        /// </summary>
        public string S3PolicyDocument
        {
            get { return this._s3PolicyDocument; }
            set { this._s3PolicyDocument = value; }
        }

        // Check to see if S3PolicyDocument property is set
        internal bool IsSetS3PolicyDocument()
        {
            return this._s3PolicyDocument != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the Amazon S3 access.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>enabled | disabled</c> 
        /// </para>
        /// </summary>
        public ManagedResourceStatus Status
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