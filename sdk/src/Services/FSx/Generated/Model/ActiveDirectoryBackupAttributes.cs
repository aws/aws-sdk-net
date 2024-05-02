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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
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
namespace Amazon.FSx.Model
{
    /// <summary>
    /// The Microsoft Active Directory attributes of the Amazon FSx for Windows File Server
    /// file system.
    /// </summary>
    public partial class ActiveDirectoryBackupAttributes
    {
        private string _activeDirectoryId;
        private string _domainName;
        private string _resourceARN;

        /// <summary>
        /// Gets and sets the property ActiveDirectoryId. 
        /// <para>
        /// The ID of the Amazon Web Services Managed Microsoft Active Directory instance to which
        /// the file system is joined.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string ActiveDirectoryId
        {
            get { return this._activeDirectoryId; }
            set { this._activeDirectoryId = value; }
        }

        // Check to see if ActiveDirectoryId property is set
        internal bool IsSetActiveDirectoryId()
        {
            return this._activeDirectoryId != null;
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The fully qualified domain name of the self-managed Active Directory directory.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property ResourceARN.
        /// </summary>
        [AWSProperty(Min=8, Max=512)]
        public string ResourceARN
        {
            get { return this._resourceARN; }
            set { this._resourceARN = value; }
        }

        // Check to see if ResourceARN property is set
        internal bool IsSetResourceARN()
        {
            return this._resourceARN != null;
        }

    }
}