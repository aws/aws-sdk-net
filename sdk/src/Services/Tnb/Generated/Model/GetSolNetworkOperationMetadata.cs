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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Tnb.Model
{
    /// <summary>
    /// Metadata related to a network operation occurrence.
    /// 
    ///  
    /// <para>
    /// A network operation is any operation that is done to your network, such as network
    /// instance instantiation or termination.
    /// </para>
    /// </summary>
    public partial class GetSolNetworkOperationMetadata
    {
        private DateTime? _createdAt;
        private InstantiateMetadata _instantiateMetadata;
        private DateTime? _lastModified;
        private ModifyVnfInfoMetadata _modifyVnfInfoMetadata;
        private UpdateNsMetadata _updateNsMetadata;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date that the resource was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstantiateMetadata. 
        /// <para>
        /// Metadata related to the network operation occurrence for network instantiation. This
        /// is populated only if the lcmOperationType is <c>INSTANTIATE</c>.
        /// </para>
        /// </summary>
        public InstantiateMetadata InstantiateMetadata
        {
            get { return this._instantiateMetadata; }
            set { this._instantiateMetadata = value; }
        }

        // Check to see if InstantiateMetadata property is set
        internal bool IsSetInstantiateMetadata()
        {
            return this._instantiateMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property LastModified. 
        /// <para>
        /// The date that the resource was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastModified
        {
            get { return this._lastModified; }
            set { this._lastModified = value; }
        }

        // Check to see if LastModified property is set
        internal bool IsSetLastModified()
        {
            return this._lastModified.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModifyVnfInfoMetadata. 
        /// <para>
        /// Metadata related to the network operation occurrence for network function updates
        /// in a network instance. This is populated only if the lcmOperationType is <c>UPDATE</c>
        /// and the updateType is <c>MODIFY_VNF_INFORMATION</c>.
        /// </para>
        /// </summary>
        public ModifyVnfInfoMetadata ModifyVnfInfoMetadata
        {
            get { return this._modifyVnfInfoMetadata; }
            set { this._modifyVnfInfoMetadata = value; }
        }

        // Check to see if ModifyVnfInfoMetadata property is set
        internal bool IsSetModifyVnfInfoMetadata()
        {
            return this._modifyVnfInfoMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateNsMetadata. 
        /// <para>
        /// Metadata related to the network operation occurrence for network instance updates.
        /// This is populated only if the lcmOperationType is <c>UPDATE</c> and the updateType
        /// is <c>UPDATE_NS</c>.
        /// </para>
        /// </summary>
        public UpdateNsMetadata UpdateNsMetadata
        {
            get { return this._updateNsMetadata; }
            set { this._updateNsMetadata = value; }
        }

        // Check to see if UpdateNsMetadata property is set
        internal bool IsSetUpdateNsMetadata()
        {
            return this._updateNsMetadata != null;
        }

    }
}