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
 * Do not modify this file. This file is generated from the networkmanager-2019-07-05.normal.json service model.
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
namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// Describes a VPC attachment.
    /// </summary>
    public partial class VpcAttachment
    {
        private Attachment _attachment;
        private VpcOptions _options;
        private List<string> _subnetArns = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Attachment. 
        /// <para>
        /// Provides details about the VPC attachment.
        /// </para>
        /// </summary>
        public Attachment Attachment
        {
            get { return this._attachment; }
            set { this._attachment = value; }
        }

        // Check to see if Attachment property is set
        internal bool IsSetAttachment()
        {
            return this._attachment != null;
        }

        /// <summary>
        /// Gets and sets the property Options. 
        /// <para>
        /// Provides details about the VPC attachment.
        /// </para>
        /// </summary>
        public VpcOptions Options
        {
            get { return this._options; }
            set { this._options = value; }
        }

        // Check to see if Options property is set
        internal bool IsSetOptions()
        {
            return this._options != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetArns. 
        /// <para>
        /// The subnet ARNs.
        /// </para>
        /// </summary>
        public List<string> SubnetArns
        {
            get { return this._subnetArns; }
            set { this._subnetArns = value; }
        }

        // Check to see if SubnetArns property is set
        internal bool IsSetSubnetArns()
        {
            return this._subnetArns != null && (this._subnetArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}