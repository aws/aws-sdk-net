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
 * Do not modify this file. This file is generated from the opsworkscm-2016-11-01.normal.json service model.
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
    ///  A <c>ValidationException</c> is raised when parameters of the request are not valid.
    /// A <c>ResourceNotFoundException</c> is thrown when the server does not exist. An <c>InvalidStateException</c>
    /// is thrown when the server is in any of the following states: CREATING, TERMINATED,
    /// FAILED or DELETING. 
    /// </para>
    /// </summary>
    public partial class ExportServerEngineAttributeRequest : AmazonOpsWorksCMRequest
    {
        private string _exportAttributeName;
        private List<EngineAttribute> _inputAttributes = AWSConfigs.InitializeCollections ? new List<EngineAttribute>() : null;
        private string _serverName;

        /// <summary>
        /// Gets and sets the property ExportAttributeName. 
        /// <para>
        /// The name of the export attribute. Currently, the supported export attribute is <c>Userdata</c>.
        /// This exports a user data script that includes parameters and values provided in the
        /// <c>InputAttributes</c> list.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=10000)]
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
        /// The list of engine attributes. The list type is <c>EngineAttribute</c>. An <c>EngineAttribute</c>
        /// list item is a pair that includes an attribute name and its value. For the <c>Userdata</c>
        /// ExportAttributeName, the following are supported engine attribute names.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>RunList</b> In Chef, a list of roles or recipes that are run in the specified
        /// order. In Puppet, this parameter is ignored.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>OrganizationName</b> In Chef, an organization name. OpsWorks for Chef Automate
        /// always creates the organization <c>default</c>. In Puppet, this parameter is ignored.
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EngineAttribute> InputAttributes
        {
            get { return this._inputAttributes; }
            set { this._inputAttributes = value; }
        }

        // Check to see if InputAttributes property is set
        internal bool IsSetInputAttributes()
        {
            return this._inputAttributes != null && (this._inputAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ServerName. 
        /// <para>
        /// The name of the server from which you are exporting the attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=40)]
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