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
    /// Container for the parameters to the ExportServerEngineAttribute operation.
    /// Exports a specified server engine attribute as a base64-encoded string. For example,
    /// you can export user data that you can use in EC2 to associate nodes with a server.
    /// 
    /// 
    ///  
    /// <para>
    ///  This operation is synchronous. 
    /// </para>
    ///  
    /// <para>
    ///  A <code>ValidationException</code> is raised when parameters of the request are not
    /// valid. A <code>ResourceNotFoundException</code> is thrown when the server does not
    /// exist. An <code>InvalidStateException</code> is thrown when the server is in any of
    /// the following states: CREATING, TERMINATED, FAILED or DELETING. 
    /// </para>
    /// </summary>
    public partial class ExportServerEngineAttributeRequest : AmazonOpsWorksCMRequest
    {
        private string _exportAttributeName;
        private List<EngineAttribute> _inputAttributes = new List<EngineAttribute>();
        private string _serverName;

        /// <summary>
        /// Gets and sets the property ExportAttributeName. 
        /// <para>
        /// The name of the export attribute. Currently, the supported export attribute is <code>Userdata</code>.
        /// This exports a user data script that includes parameters and values provided in the
        /// <code>InputAttributes</code> list.
        /// </para>
        /// </summary>
        public string ExportAttributeName
        {
            get { return this._exportAttributeName; }
            set { this._exportAttributeName = value; }
        }

        // Check to see if ExportAttributeName property is set
        internal bool IsSetExportAttributeName()
        {
            return this._exportAttributeName != null;
        }

        /// <summary>
        /// Gets and sets the property InputAttributes. 
        /// <para>
        /// The list of engine attributes. The list type is <code>EngineAttribute</code>. An <code>EngineAttribute</code>
        /// list item is a pair that includes an attribute name and its value. For the <code>Userdata</code>
        /// ExportAttributeName, the following are supported engine attribute names.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>RunList</b> In Chef, a list of roles or recipes that are run in the specified
        /// order. In Puppet, this parameter is ignored.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>OrganizationName</b> In Chef, an organization name. AWS OpsWorks for Chef Automate
        /// always creates the organization <code>default</code>. In Puppet, this parameter is
        /// ignored.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>NodeEnvironment</b> In Chef, a node environment (for example, development, staging,
        /// or one-box). In Puppet, this parameter is ignored.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>NodeClientVersion</b> In Chef, the version of the Chef engine (three numbers separated
        /// by dots, such as 13.8.5). If this attribute is empty, OpsWorks for Chef Automate uses
        /// the most current version. In Puppet, this parameter is ignored.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<EngineAttribute> InputAttributes
        {
            get { return this._inputAttributes; }
            set { this._inputAttributes = value; }
        }

        // Check to see if InputAttributes property is set
        internal bool IsSetInputAttributes()
        {
            return this._inputAttributes != null && this._inputAttributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ServerName. 
        /// <para>
        /// The name of the server from which you are exporting the attribute.
        /// </para>
        /// </summary>
        public string ServerName
        {
            get { return this._serverName; }
            set { this._serverName = value; }
        }

        // Check to see if ServerName property is set
        internal bool IsSetServerName()
        {
            return this._serverName != null;
        }

    }
}