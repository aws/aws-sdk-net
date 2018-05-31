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
 * Do not modify this file. This file is generated from the neptune-2018-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Neptune.Model
{
    /// <summary>
    /// Contains status information for a DB cluster option group.
    /// </summary>
    public partial class DBClusterOptionGroupStatus
    {
        private string _dbClusterOptionGroupName;
        private string _status;

        /// <summary>
        /// Gets and sets the property DBClusterOptionGroupName. 
        /// <para>
        /// Specifies the name of the DB cluster option group.
        /// </para>
        /// </summary>
        public string DBClusterOptionGroupName
        {
            get { return this._dbClusterOptionGroupName; }
            set { this._dbClusterOptionGroupName = value; }
        }

        // Check to see if DBClusterOptionGroupName property is set
        internal bool IsSetDBClusterOptionGroupName()
        {
            return this._dbClusterOptionGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Specifies the status of the DB cluster option group.
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