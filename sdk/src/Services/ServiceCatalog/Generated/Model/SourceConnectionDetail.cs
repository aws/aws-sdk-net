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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// Provides details about the configured <code>SourceConnection</code>.
    /// </summary>
    public partial class SourceConnectionDetail
    {
        private SourceConnectionParameters _connectionParameters;
        private LastSync _lastSync;
        private SourceType _type;

        /// <summary>
        /// Gets and sets the property ConnectionParameters. 
        /// <para>
        /// The connection details based on the connection <code>Type</code>.
        /// </para>
        /// </summary>
        public SourceConnectionParameters ConnectionParameters
        {
            get { return this._connectionParameters; }
            set { this._connectionParameters = value; }
        }

        // Check to see if ConnectionParameters property is set
        internal bool IsSetConnectionParameters()
        {
            return this._connectionParameters != null;
        }

        /// <summary>
        /// Gets and sets the property LastSync. 
        /// <para>
        /// Provides details about the product's connection sync and contains the following sub-fields.
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>LastSyncTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LastSyncStatus</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LastSyncStatusMessage</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LastSuccessfulSyncTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LastSuccessfulSyncProvisioningArtifactID</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public LastSync LastSync
        {
            get { return this._lastSync; }
            set { this._lastSync = value; }
        }

        // Check to see if LastSync property is set
        internal bool IsSetLastSync()
        {
            return this._lastSync != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The only supported <code>SourceConnection</code> type is Codestar.
        /// </para>
        /// </summary>
        public SourceType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}