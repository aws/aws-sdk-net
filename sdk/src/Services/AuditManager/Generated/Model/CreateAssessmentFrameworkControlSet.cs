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
 * Do not modify this file. This file is generated from the auditmanager-2017-07-25.normal.json service model.
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
namespace Amazon.AuditManager.Model
{
    /// <summary>
    /// A <c>controlSet</c> entity that represents a collection of controls in Audit Manager.
    /// This doesn't contain the control set ID.
    /// </summary>
    public partial class CreateAssessmentFrameworkControlSet
    {
        private List<CreateAssessmentFrameworkControl> _controls = AWSConfigs.InitializeCollections ? new List<CreateAssessmentFrameworkControl>() : null;
        private string _name;

        /// <summary>
        /// Gets and sets the property Controls. 
        /// <para>
        ///  The list of controls within the control set. This doesn't contain the control set
        /// ID. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<CreateAssessmentFrameworkControl> Controls
        {
            get { return this._controls; }
            set { this._controls = value; }
        }

        // Check to see if Controls property is set
        internal bool IsSetControls()
        {
            return this._controls != null && (this._controls.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the control set. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=300)]
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

    }
}