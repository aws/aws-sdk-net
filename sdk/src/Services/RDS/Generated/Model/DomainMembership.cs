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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// An Active Directory Domain membership record associated with the DB instance.
    /// </summary>
    public partial class DomainMembership
    {
        private string _connectivity;
        private string _domain;
        private string _status;

        /// <summary>
        /// Gets and sets the property Connectivity. 
        /// <para>
        ///  The observed connectivity of the Active Directory Domain. 
        /// </para>
        /// </summary>
        public string Connectivity
        {
            get { return this._connectivity; }
            set { this._connectivity = value; }
        }

        // Check to see if Connectivity property is set
        internal bool IsSetConnectivity()
        {
            return this._connectivity != null;
        }

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        ///  The identifier of the Active Directory Domain. 
        /// </para>
        /// </summary>
        public string Domain
        {
            get { return this._domain; }
            set { this._domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this._domain != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The status of the DB instance's Active Directory Domain membership (e.g. joined,
        /// pending-join, failed etc). 
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}