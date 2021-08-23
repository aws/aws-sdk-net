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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Backup.Model
{
    /// <summary>
    /// A framework consists of one or more controls. Each control has its own control scope.
    /// The control scope defines what the control will evaluate. Three examples of control
    /// scopes are: a specific backup plan, all backup plans with a specific tag, or all backup
    /// plans.
    /// 
    ///  <note> 
    /// <para>
    /// To set a control scope that includes all of a particular resource, leave the <code>ControlScope</code>
    /// empty or do not pass it when calling <code>CreateFramework</code>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ControlScope
    {
        private List<string> _complianceResourceIds = new List<string>();
        private List<string> _complianceResourceTypes = new List<string>();
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property ComplianceResourceIds. 
        /// <para>
        /// Describes whether the control scope includes a specific resource identified by its
        /// unique Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> ComplianceResourceIds
        {
            get { return this._complianceResourceIds; }
            set { this._complianceResourceIds = value; }
        }

        // Check to see if ComplianceResourceIds property is set
        internal bool IsSetComplianceResourceIds()
        {
            return this._complianceResourceIds != null && this._complianceResourceIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ComplianceResourceTypes. 
        /// <para>
        /// Describes whether the control scope includes one or more types of resources, such
        /// as <code>EFS</code> or <code>RDS</code>.
        /// </para>
        /// </summary>
        public List<string> ComplianceResourceTypes
        {
            get { return this._complianceResourceTypes; }
            set { this._complianceResourceTypes = value; }
        }

        // Check to see if ComplianceResourceTypes property is set
        internal bool IsSetComplianceResourceTypes()
        {
            return this._complianceResourceTypes != null && this._complianceResourceTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Describes whether the control scope includes resources with one or more tags. Each
        /// tag is a key-value pair.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}