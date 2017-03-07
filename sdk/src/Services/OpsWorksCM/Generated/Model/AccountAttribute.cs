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
 * Do not modify this file. This file is generated from the opsworkscm-2016-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorksCM.Model
{
    /// <summary>
    /// Stores account attributes.
    /// </summary>
    public partial class AccountAttribute
    {
        private int? _maximum;
        private string _name;
        private int? _used;

        /// <summary>
        /// Gets and sets the property Maximum. 
        /// <para>
        ///  The maximum allowed value. 
        /// </para>
        /// </summary>
        public int Maximum
        {
            get { return this._maximum.GetValueOrDefault(); }
            set { this._maximum = value; }
        }

        // Check to see if Maximum property is set
        internal bool IsSetMaximum()
        {
            return this._maximum.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The attribute name. The following are supported attribute names. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>ServerLimit:</i> The number of current servers/maximum number of servers allowed.
        /// By default, you can have a maximum of 10 servers. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>ManualBackupLimit:</i> The number of current manual backups/maximum number of
        /// backups allowed. By default, you can have a maximum of 50 manual backups saved. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Used. 
        /// <para>
        ///  The current usage, such as the current number of servers that are associated with
        /// the account. 
        /// </para>
        /// </summary>
        public int Used
        {
            get { return this._used.GetValueOrDefault(); }
            set { this._used = value; }
        }

        // Check to see if Used property is set
        internal bool IsSetUsed()
        {
            return this._used.HasValue; 
        }

    }
}