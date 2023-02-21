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
    /// Container for the parameters to the CreateSolNetworkInstance operation.
    /// Creates a network instance.
    /// 
    ///  
    /// <para>
    /// A network instance is a single network created in Amazon Web Services TNB that can
    /// be deployed and on which life-cycle operations (like terminate, update, and delete)
    /// can be performed. Creating a network instance is the third step after creating a network
    /// package. For more information about network instances, <a href="https://docs.aws.amazon.com/tnb/latest/ug/network-instances.html">Network
    /// instances</a> in the <i>Amazon Web Services Telco Network Builder User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// Once you create a network instance, you can instantiate it. To instantiate a network,
    /// see <a href="https://docs.aws.amazon.com/TNB/latest/APIReference/API_InstantiateSolNetworkInstance.html">InstantiateSolNetworkInstance</a>.
    /// </para>
    /// </summary>
    public partial class CreateSolNetworkInstanceRequest : AmazonTnbRequest
    {
        private string _nsDescription;
        private string _nsdInfoId;
        private string _nsName;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property NsDescription. 
        /// <para>
        /// Network instance description.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=124)]
        public string NsDescription
        {
            get { return this._nsDescription; }
            set { this._nsDescription = value; }
        }

        // Check to see if NsDescription property is set
        internal bool IsSetNsDescription()
        {
            return this._nsDescription != null;
        }

        /// <summary>
        /// Gets and sets the property NsdInfoId. 
        /// <para>
        /// ID for network service descriptor.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string NsdInfoId
        {
            get { return this._nsdInfoId; }
            set { this._nsdInfoId = value; }
        }

        // Check to see if NsdInfoId property is set
        internal bool IsSetNsdInfoId()
        {
            return this._nsdInfoId != null;
        }

        /// <summary>
        /// Gets and sets the property NsName. 
        /// <para>
        /// Network instance name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=80)]
        public string NsName
        {
            get { return this._nsName; }
            set { this._nsName = value; }
        }

        // Check to see if NsName property is set
        internal bool IsSetNsName()
        {
            return this._nsName != null;
        }

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