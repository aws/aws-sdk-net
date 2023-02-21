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
    /// Info about the specific network instance.
    /// 
    ///  
    /// <para>
    /// A network instance is a single network created in Amazon Web Services TNB that can
    /// be deployed and on which life-cycle operations (like terminate, update, and delete)
    /// can be performed.
    /// </para>
    /// </summary>
    public partial class ListSolNetworkInstanceInfo
    {
        private string _arn;
        private string _id;
        private ListSolNetworkInstanceMetadata _metadata;
        private string _nsdId;
        private string _nsdInfoId;
        private string _nsInstanceDescription;
        private string _nsInstanceName;
        private NsState _nsState;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// Network instance ARN.
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
        /// Gets and sets the property Id. 
        /// <para>
        /// ID of the network instance.
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
        /// Gets and sets the property Metadata. 
        /// <para>
        /// The metadata of the network instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ListSolNetworkInstanceMetadata Metadata
        {
            get { return this._metadata; }
            set { this._metadata = value; }
        }

        // Check to see if Metadata property is set
        internal bool IsSetMetadata()
        {
            return this._metadata != null;
        }

        /// <summary>
        /// Gets and sets the property NsdId. 
        /// <para>
        /// ID of the network service descriptor in the network package.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string NsdId
        {
            get { return this._nsdId; }
            set { this._nsdId = value; }
        }

        // Check to see if NsdId property is set
        internal bool IsSetNsdId()
        {
            return this._nsdId != null;
        }

        /// <summary>
        /// Gets and sets the property NsdInfoId. 
        /// <para>
        /// ID of the network service descriptor in the network package.
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
        /// Gets and sets the property NsInstanceDescription. 
        /// <para>
        /// Human-readable description of the network instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string NsInstanceDescription
        {
            get { return this._nsInstanceDescription; }
            set { this._nsInstanceDescription = value; }
        }

        // Check to see if NsInstanceDescription property is set
        internal bool IsSetNsInstanceDescription()
        {
            return this._nsInstanceDescription != null;
        }

        /// <summary>
        /// Gets and sets the property NsInstanceName. 
        /// <para>
        /// Human-readable name of the network instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string NsInstanceName
        {
            get { return this._nsInstanceName; }
            set { this._nsInstanceName = value; }
        }

        // Check to see if NsInstanceName property is set
        internal bool IsSetNsInstanceName()
        {
            return this._nsInstanceName != null;
        }

        /// <summary>
        /// Gets and sets the property NsState. 
        /// <para>
        /// The state of the network instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public NsState NsState
        {
            get { return this._nsState; }
            set { this._nsState = value; }
        }

        // Check to see if NsState property is set
        internal bool IsSetNsState()
        {
            return this._nsState != null;
        }

    }
}