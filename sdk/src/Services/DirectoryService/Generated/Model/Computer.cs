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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Contains information about a computer account in a directory.
    /// </summary>
    public partial class Computer
    {
        private List<Attribute> _computerAttributes = new List<Attribute>();
        private string _computerId;
        private string _computerName;

        /// <summary>
        /// Gets and sets the property ComputerAttributes. 
        /// <para>
        /// An array of <a>Attribute</a> objects that contain the LDAP attributes that belong
        /// to the computer account.
        /// </para>
        /// </summary>
        public List<Attribute> ComputerAttributes
        {
            get { return this._computerAttributes; }
            set { this._computerAttributes = value; }
        }

        // Check to see if ComputerAttributes property is set
        internal bool IsSetComputerAttributes()
        {
            return this._computerAttributes != null && this._computerAttributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ComputerId. 
        /// <para>
        /// The identifier of the computer.
        /// </para>
        /// </summary>
        public string ComputerId
        {
            get { return this._computerId; }
            set { this._computerId = value; }
        }

        // Check to see if ComputerId property is set
        internal bool IsSetComputerId()
        {
            return this._computerId != null;
        }

        /// <summary>
        /// Gets and sets the property ComputerName. 
        /// <para>
        /// The computer name.
        /// </para>
        /// </summary>
        public string ComputerName
        {
            get { return this._computerName; }
            set { this._computerName = value; }
        }

        // Check to see if ComputerName property is set
        internal bool IsSetComputerName()
        {
            return this._computerName != null;
        }

    }
}