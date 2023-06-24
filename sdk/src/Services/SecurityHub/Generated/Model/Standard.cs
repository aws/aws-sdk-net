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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides information about a specific security standard.
    /// </summary>
    public partial class Standard
    {
        private string _description;
        private bool? _enabledByDefault;
        private string _name;
        private string _standardsArn;
        private StandardsManagedBy _standardsManagedBy;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the standard.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EnabledByDefault. 
        /// <para>
        /// Whether the standard is enabled by default. When Security Hub is enabled from the
        /// console, if a standard is enabled by default, the check box for that standard is selected
        /// by default.
        /// </para>
        ///  
        /// <para>
        /// When Security Hub is enabled using the <code>EnableSecurityHub</code> API operation,
        /// the standard is enabled by default unless <code>EnableDefaultStandards</code> is set
        /// to <code>false</code>.
        /// </para>
        /// </summary>
        public bool EnabledByDefault
        {
            get { return this._enabledByDefault.GetValueOrDefault(); }
            set { this._enabledByDefault = value; }
        }

        // Check to see if EnabledByDefault property is set
        internal bool IsSetEnabledByDefault()
        {
            return this._enabledByDefault.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the standard.
        /// </para>
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
        /// Gets and sets the property StandardsArn. 
        /// <para>
        /// The ARN of a standard.
        /// </para>
        /// </summary>
        public string StandardsArn
        {
            get { return this._standardsArn; }
            set { this._standardsArn = value; }
        }

        // Check to see if StandardsArn property is set
        internal bool IsSetStandardsArn()
        {
            return this._standardsArn != null;
        }

        /// <summary>
        /// Gets and sets the property StandardsManagedBy. 
        /// <para>
        /// Provides details about the management of a standard. 
        /// </para>
        /// </summary>
        public StandardsManagedBy StandardsManagedBy
        {
            get { return this._standardsManagedBy; }
            set { this._standardsManagedBy = value; }
        }

        // Check to see if StandardsManagedBy property is set
        internal bool IsSetStandardsManagedBy()
        {
            return this._standardsManagedBy != null;
        }

    }
}