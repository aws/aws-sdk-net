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
    /// Metadata related to a network operation.
    /// 
    ///  
    /// <para>
    /// A network operation is any operation that is done to your network, such as network
    /// instance instantiation or termination.
    /// </para>
    /// </summary>
    public partial class ListSolNetworkOperationsMetadata
    {
        private DateTime? _createdAt;
        private DateTime? _lastModified;
        private string _nsdInfoId;
        private string _vnfInstanceId;

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
        /// Gets and sets the property NsdInfoId. 
        /// <para>
        /// The network service descriptor id used for the operation.
        /// </para>
        ///  
        /// <para>
        /// Only present if the updateType is <c>UPDATE_NS</c>.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property VnfInstanceId. 
        /// <para>
        /// The network function id used for the operation.
        /// </para>
        ///  
        /// <para>
        /// Only present if the updateType is <c>MODIFY_VNF_INFO</c>.
        /// </para>
        /// </summary>
        public string VnfInstanceId
        {
            get { return this._vnfInstanceId; }
            set { this._vnfInstanceId = value; }
        }

        // Check to see if VnfInstanceId property is set
        internal bool IsSetVnfInstanceId()
        {
            return this._vnfInstanceId != null;
        }

    }
}