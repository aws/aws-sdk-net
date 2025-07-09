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
 * Do not modify this file. This file is generated from the opsworkscm-2016-11-01.normal.json service model.
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
namespace Amazon.OpsWorksCM.Model
{
    /// <summary>
    /// This is the response object from the DescribeNodeAssociationStatus operation.
    /// </summary>
    public partial class DescribeNodeAssociationStatusResponse : AmazonWebServiceResponse
    {
        private List<EngineAttribute> _engineAttributes = AWSConfigs.InitializeCollections ? new List<EngineAttribute>() : null;
        private NodeAssociationStatus _nodeAssociationStatus;

        /// <summary>
        /// Gets and sets the property EngineAttributes. 
        /// <para>
        /// Attributes specific to the node association. In Puppet, the attribute PUPPET_NODE_CERT
        /// contains the signed certificate (the result of the CSR). 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EngineAttribute> EngineAttributes
        {
            get { return this._engineAttributes; }
            set { this._engineAttributes = value; }
        }

        // Check to see if EngineAttributes property is set
        internal bool IsSetEngineAttributes()
        {
            return this._engineAttributes != null && (this._engineAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NodeAssociationStatus. 
        /// <para>
        /// The status of the association or disassociation request. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Possible values:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SUCCESS</c>: The association or disassociation succeeded. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c>: The association or disassociation failed. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IN_PROGRESS</c>: The association or disassociation is still in progress. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public NodeAssociationStatus NodeAssociationStatus
        {
            get { return this._nodeAssociationStatus; }
            set { this._nodeAssociationStatus = value; }
        }

        // Check to see if NodeAssociationStatus property is set
        internal bool IsSetNodeAssociationStatus()
        {
            return this._nodeAssociationStatus != null;
        }

    }
}