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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Backup.Model
{
    /// <summary>
    /// Contains detailed information about all of the controls of a framework. Each framework
    /// must contain at least one control.
    /// </summary>
    public partial class FrameworkControl
    {
        private List<ControlInputParameter> _controlInputParameters = AWSConfigs.InitializeCollections ? new List<ControlInputParameter>() : null;
        private string _controlName;
        private ControlScope _controlScope;

        /// <summary>
        /// Gets and sets the property ControlInputParameters. 
        /// <para>
        /// The name/value pairs.
        /// </para>
        /// </summary>
        public List<ControlInputParameter> ControlInputParameters
        {
            get { return this._controlInputParameters; }
            set { this._controlInputParameters = value; }
        }

        // Check to see if ControlInputParameters property is set
        internal bool IsSetControlInputParameters()
        {
            return this._controlInputParameters != null && (this._controlInputParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ControlName. 
        /// <para>
        /// The name of a control. This name is between 1 and 256 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ControlName
        {
            get { return this._controlName; }
            set { this._controlName = value; }
        }

        // Check to see if ControlName property is set
        internal bool IsSetControlName()
        {
            return this._controlName != null;
        }

        /// <summary>
        /// Gets and sets the property ControlScope. 
        /// <para>
        /// The scope of a control. The control scope defines what the control will evaluate.
        /// Three examples of control scopes are: a specific backup plan, all backup plans with
        /// a specific tag, or all backup plans.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/aws-backup/latest/devguide/API_ControlScope.html">
        /// <c>ControlScope</c>.</a> 
        /// </para>
        /// </summary>
        public ControlScope ControlScope
        {
            get { return this._controlScope; }
            set { this._controlScope = value; }
        }

        // Check to see if ControlScope property is set
        internal bool IsSetControlScope()
        {
            return this._controlScope != null;
        }

    }
}