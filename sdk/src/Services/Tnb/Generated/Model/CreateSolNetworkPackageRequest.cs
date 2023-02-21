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
 * Do not modify this file. This file is generated from the tnb-2008-10-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Tnb.Model
{
    /// <summary>
    /// Container for the parameters to the CreateSolNetworkPackage operation.
    /// Creates a network package.
    /// 
    ///  
    /// <para>
    /// A network package is a .zip file in CSAR (Cloud Service Archive) format defines the
    /// function packages you want to deploy and the Amazon Web Services infrastructure you
    /// want to deploy them on. For more information, see <a href="https://docs.aws.amazon.com/tnb/latest/ug/network-instances.html">Network
    /// instances</a> in the <i>Amazon Web Services Telco Network Builder User Guide</i>.
    /// 
    /// </para>
    ///  
    /// <para>
    /// A network package consists of a network service descriptor (NSD) file (required) and
    /// any additional files (optional), such as scripts specific to your needs. For example,
    /// if you have multiple function packages in your network package, you can use the NSD
    /// to define which network functions should run in certain VPCs, subnets, or EKS clusters.
    /// </para>
    ///  
    /// <para>
    /// This request creates an empty network package container with an ID. Once you create
    /// a network package, you can upload the network package content using <a href="https://docs.aws.amazon.com/TNB/latest/APIReference/API_PutSolNetworkPackageContent.html">PutSolNetworkPackageContent</a>.
    /// </para>
    /// </summary>
    public partial class CreateSolNetworkPackageRequest : AmazonTnbRequest
    {
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A tag is a label that you assign to an Amazon Web Services resource. Each tag consists
        /// of a key and an optional value. You can use tags to search and filter your resources
        /// or track your Amazon Web Services costs.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}