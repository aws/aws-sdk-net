/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeKeyPairs operation.
    /// Describes the specified key pairs or all of your key pairs.
    /// 
    ///  
    /// <para>
    /// For more information about key pairs, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html">Key
    /// Pairs</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// </para>
    /// </summary>
    public partial class DescribeKeyPairsRequest : AmazonEC2Request
    {
        private List<Filter> _filters = new List<Filter>();
        private List<string> _keyNames = new List<string>();
        private List<string> _keyPairIds = new List<string>();

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>key-pair-id</code> - The ID of the key pair.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>fingerprint</code> - The fingerprint of the key pair.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>key-name</code> - The name of the key pair.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>tag-key</code> - The key of a tag assigned to the resource. Use this filter
        /// to find all resources assigned a tag with a specific key, regardless of the tag value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>tag</code>:&lt;key&gt; - The key/value combination of a tag assigned to the
        /// resource. Use the tag key in the filter name and the tag value as the filter value.
        /// For example, to find all resources that have a tag with the key <code>Owner</code>
        /// and the value <code>TeamA</code>, specify <code>tag:Owner</code> for the filter name
        /// and <code>TeamA</code> for the filter value.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property KeyNames. 
        /// <para>
        /// The key pair names.
        /// </para>
        ///  
        /// <para>
        /// Default: Describes all your key pairs.
        /// </para>
        /// </summary>
        public List<string> KeyNames
        {
            get { return this._keyNames; }
            set { this._keyNames = value; }
        }

        // Check to see if KeyNames property is set
        internal bool IsSetKeyNames()
        {
            return this._keyNames != null && this._keyNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property KeyPairIds. 
        /// <para>
        /// The IDs of the key pairs.
        /// </para>
        /// </summary>
        public List<string> KeyPairIds
        {
            get { return this._keyPairIds; }
            set { this._keyPairIds = value; }
        }

        // Check to see if KeyPairIds property is set
        internal bool IsSetKeyPairIds()
        {
            return this._keyPairIds != null && this._keyPairIds.Count > 0; 
        }

    }
}