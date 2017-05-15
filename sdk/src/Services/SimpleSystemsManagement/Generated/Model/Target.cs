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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// An array of search criteria that targets instances using a Key,Value combination that
    /// you specify. Targets is required if you don't provide one or more instance IDs in
    /// the call.
    /// </summary>
    public partial class Target
    {
        private string _key;
        private List<string> _values = new List<string>();

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// User-defined criteria for sending commands that target instances that meet the criteria.
        /// Key can be tag:&lt;Amazon EC2 tag&gt; or InstanceIds. For more information about how
        /// to send commands that target instances using Key,Value parameters, see <a href="http://docs.aws.amazon.com/systems-manager/latest/userguide/run-command.html">Executing
        /// a Command Using Systems Manager Run Command</a>.
        /// </para>
        /// </summary>
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// User-defined criteria that maps to Key. For example, if you specified tag:ServerRole,
        /// you could specify value:WebServer to execute a command on instances that include Amazon
        /// EC2 tags of ServerRole,WebServer. For more information about how to send commands
        /// that target instances using Key,Value parameters, see <a href="http://docs.aws.amazon.com/systems-manager/latest/userguide/run-command.html">Executing
        /// a Command Using Systems Manager Run Command</a>.
        /// </para>
        /// </summary>
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && this._values.Count > 0; 
        }

    }
}