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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides a standard to identify security findings using OCSF.
    /// </summary>
    public partial class OcsfFindingIdentifier
    {
        private string _cloudAccountUid;
        private string _findingInfoUid;
        private string _metadataProductUid;

        /// <summary>
        /// Gets and sets the property CloudAccountUid. 
        /// <para>
        /// Finding cloud.account.uid, which is a unique identifier in the Amazon Web Services
        /// account..
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CloudAccountUid
        {
            get { return this._cloudAccountUid; }
            set { this._cloudAccountUid = value; }
        }

        // Check to see if CloudAccountUid property is set
        internal bool IsSetCloudAccountUid()
        {
            return this._cloudAccountUid != null;
        }

        /// <summary>
        /// Gets and sets the property FindingInfoUid. 
        /// <para>
        /// Finding finding_info.uid, which is a unique identifier for the finding from the finding
        /// provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FindingInfoUid
        {
            get { return this._findingInfoUid; }
            set { this._findingInfoUid = value; }
        }

        // Check to see if FindingInfoUid property is set
        internal bool IsSetFindingInfoUid()
        {
            return this._findingInfoUid != null;
        }

        /// <summary>
        /// Gets and sets the property MetadataProductUid. 
        /// <para>
        /// Finding metadata.product.uid, which is a unique identifier for the product.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string MetadataProductUid
        {
            get { return this._metadataProductUid; }
            set { this._metadataProductUid = value; }
        }

        // Check to see if MetadataProductUid property is set
        internal bool IsSetMetadataProductUid()
        {
            return this._metadataProductUid != null;
        }

    }
}