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
 * Do not modify this file. This file is generated from the drs-2020-02-26.normal.json service model.
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
namespace Amazon.Drs.Model
{
    /// <summary>
    /// Container for the parameters to the CreateSourceNetwork operation.
    /// Create a new Source Network resource for a provided VPC ID.
    /// </summary>
    public partial class CreateSourceNetworkRequest : AmazonDrsRequest
    {
        private string _originAccountID;
        private string _originRegion;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _vpcid;

        /// <summary>
        /// Gets and sets the property OriginAccountID. 
        /// <para>
        /// Account containing the VPC to protect.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string OriginAccountID
        {
            get { return this._originAccountID; }
            set { this._originAccountID = value; }
        }

        // Check to see if OriginAccountID property is set
        internal bool IsSetOriginAccountID()
        {
            return this._originAccountID != null;
        }

        /// <summary>
        /// Gets and sets the property OriginRegion. 
        /// <para>
        /// Region containing the VPC to protect.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=255)]
        public string OriginRegion
        {
            get { return this._originRegion; }
            set { this._originRegion = value; }
        }

        // Check to see if OriginRegion property is set
        internal bool IsSetOriginRegion()
        {
            return this._originRegion != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A set of tags to be associated with the Source Network resource.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VpcID. 
        /// <para>
        /// Which VPC ID to protect.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=21)]
        public string VpcID
        {
            get { return this._vpcid; }
            set { this._vpcid = value; }
        }

        // Check to see if VpcID property is set
        internal bool IsSetVpcID()
        {
            return this._vpcid != null;
        }

    }
}