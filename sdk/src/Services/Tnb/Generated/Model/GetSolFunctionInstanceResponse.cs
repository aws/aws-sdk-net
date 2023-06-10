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
    /// This is the response object from the GetSolFunctionInstance operation.
    /// </summary>
    public partial class GetSolFunctionInstanceResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private string _id;
        private GetSolVnfInfo _instantiatedVnfInfo;
        private VnfInstantiationState _instantiationState;
        private GetSolFunctionInstanceMetadata _metadata;
        private string _nsInstanceId;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private string _vnfdId;
        private string _vnfdVersion;
        private string _vnfPkgId;
        private string _vnfProductName;
        private string _vnfProvider;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// Network function instance ARN.
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
        /// Network function instance ID.
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
        /// Gets and sets the property InstantiatedVnfInfo.
        /// </summary>
        public GetSolVnfInfo InstantiatedVnfInfo
        {
            get { return this._instantiatedVnfInfo; }
            set { this._instantiatedVnfInfo = value; }
        }

        // Check to see if InstantiatedVnfInfo property is set
        internal bool IsSetInstantiatedVnfInfo()
        {
            return this._instantiatedVnfInfo != null;
        }

        /// <summary>
        /// Gets and sets the property InstantiationState. 
        /// <para>
        /// Network function instantiation state.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public VnfInstantiationState InstantiationState
        {
            get { return this._instantiationState; }
            set { this._instantiationState = value; }
        }

        // Check to see if InstantiationState property is set
        internal bool IsSetInstantiationState()
        {
            return this._instantiationState != null;
        }

        /// <summary>
        /// Gets and sets the property Metadata.
        /// </summary>
        [AWSProperty(Required=true)]
        public GetSolFunctionInstanceMetadata Metadata
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
        /// Gets and sets the property NsInstanceId. 
        /// <para>
        /// Network instance ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string NsInstanceId
        {
            get { return this._nsInstanceId; }
            set { this._nsInstanceId = value; }
        }

        // Check to see if NsInstanceId property is set
        internal bool IsSetNsInstanceId()
        {
            return this._nsInstanceId != null;
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

        /// <summary>
        /// Gets and sets the property VnfdId. 
        /// <para>
        /// Function package descriptor ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VnfdId
        {
            get { return this._vnfdId; }
            set { this._vnfdId = value; }
        }

        // Check to see if VnfdId property is set
        internal bool IsSetVnfdId()
        {
            return this._vnfdId != null;
        }

        /// <summary>
        /// Gets and sets the property VnfdVersion. 
        /// <para>
        /// Function package descriptor version.
        /// </para>
        /// </summary>
        public string VnfdVersion
        {
            get { return this._vnfdVersion; }
            set { this._vnfdVersion = value; }
        }

        // Check to see if VnfdVersion property is set
        internal bool IsSetVnfdVersion()
        {
            return this._vnfdVersion != null;
        }

        /// <summary>
        /// Gets and sets the property VnfPkgId. 
        /// <para>
        /// Function package ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VnfPkgId
        {
            get { return this._vnfPkgId; }
            set { this._vnfPkgId = value; }
        }

        // Check to see if VnfPkgId property is set
        internal bool IsSetVnfPkgId()
        {
            return this._vnfPkgId != null;
        }

        /// <summary>
        /// Gets and sets the property VnfProductName. 
        /// <para>
        /// Network function product name.
        /// </para>
        /// </summary>
        public string VnfProductName
        {
            get { return this._vnfProductName; }
            set { this._vnfProductName = value; }
        }

        // Check to see if VnfProductName property is set
        internal bool IsSetVnfProductName()
        {
            return this._vnfProductName != null;
        }

        /// <summary>
        /// Gets and sets the property VnfProvider. 
        /// <para>
        /// Network function provider.
        /// </para>
        /// </summary>
        public string VnfProvider
        {
            get { return this._vnfProvider; }
            set { this._vnfProvider = value; }
        }

        // Check to see if VnfProvider property is set
        internal bool IsSetVnfProvider()
        {
            return this._vnfProvider != null;
        }

    }
}