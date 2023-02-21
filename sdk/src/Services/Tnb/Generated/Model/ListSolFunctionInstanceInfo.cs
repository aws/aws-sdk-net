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
    /// Lists information about a network function instance.
    /// 
    ///  
    /// <para>
    /// A network function instance is a function in a function package .
    /// </para>
    /// </summary>
    public partial class ListSolFunctionInstanceInfo
    {
        private string _arn;
        private string _id;
        private GetSolInstantiatedVnfInfo _instantiatedVnfInfo;
        private VnfInstantiationState _instantiationState;
        private ListSolFunctionInstanceMetadata _metadata;
        private string _nsInstanceId;
        private string _vnfPkgId;
        private string _vnfPkgName;

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
        public GetSolInstantiatedVnfInfo InstantiatedVnfInfo
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
        /// Network function instance instantiation state.
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
        /// <para>
        /// Network function instance metadata.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ListSolFunctionInstanceMetadata Metadata
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
        /// Gets and sets the property VnfPkgName. 
        /// <para>
        /// Function package name.
        /// </para>
        /// </summary>
        public string VnfPkgName
        {
            get { return this._vnfPkgName; }
            set { this._vnfPkgName = value; }
        }

        // Check to see if VnfPkgName property is set
        internal bool IsSetVnfPkgName()
        {
            return this._vnfPkgName != null;
        }

    }
}