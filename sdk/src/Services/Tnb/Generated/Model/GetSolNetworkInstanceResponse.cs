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
    /// This is the response object from the GetSolNetworkInstance operation.
    /// </summary>
    public partial class GetSolNetworkInstanceResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private string _id;
        private LcmOperationInfo _lcmOpInfo;
        private GetSolNetworkInstanceMetadata _metadata;
        private string _nsdId;
        private string _nsdInfoId;
        private string _nsInstanceDescription;
        private string _nsInstanceName;
        private NsState _nsState;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

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
        /// Network instance ID.
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
        /// Gets and sets the property LcmOpInfo.
        /// </summary>
        public LcmOperationInfo LcmOpInfo
        {
            get { return this._lcmOpInfo; }
            set { this._lcmOpInfo = value; }
        }

        // Check to see if LcmOpInfo property is set
        internal bool IsSetLcmOpInfo()
        {
            return this._lcmOpInfo != null;
        }

        /// <summary>
        /// Gets and sets the property Metadata.
        /// </summary>
        [AWSProperty(Required=true)]
        public GetSolNetworkInstanceMetadata Metadata
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
        /// Network service descriptor ID.
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
        /// Network service descriptor info ID.
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
        /// Network instance description.
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
        /// Network instance name.
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
        /// Network instance state.
        /// </para>
        /// </summary>
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