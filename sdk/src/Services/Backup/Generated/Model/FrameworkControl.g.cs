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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property ControlInputParameters. 
        /// <para>
        /// The name/value pairs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ControlInputParameter> ControlInputParameters { get; set; } = AWSConfigs.InitializeCollections ? new List<ControlInputParameter>() : null;

        /// <summary>
        /// Checks to see if the ControlInputParameters property is set.
        /// </summary>
        internal bool IsSetControlInputParameters() => this.ControlInputParameters != null && (this.ControlInputParameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ControlName. 
        /// <para>
        /// The name of a control. This name is between 1 and 256 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ControlName { get; set; }

        /// <summary>
        /// Checks to see if the ControlName property is set.
        /// </summary>
        internal bool IsSetControlName() => this.ControlName != null;

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
        public ControlScope ControlScope { get; set; }

        /// <summary>
        /// Checks to see if the ControlScope property is set.
        /// </summary>
        internal bool IsSetControlScope() => this.ControlScope != null;
    }
}
