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
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
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
namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Describes supported operating systems in OpsWorks Stacks.
    /// </summary>
    public partial class OperatingSystem
    {
        private List<OperatingSystemConfigurationManager> _configurationManagers = AWSConfigs.InitializeCollections ? new List<OperatingSystemConfigurationManager>() : null;
        private string _id;
        private string _name;
        private string _reportedName;
        private string _reportedVersion;
        private bool? _supported;
        private string _type;

        /// <summary>
        /// Gets and sets the property ConfigurationManagers. 
        /// <para>
        /// Supported configuration manager name and versions for an OpsWorks Stacks operating
        /// system.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<OperatingSystemConfigurationManager> ConfigurationManagers
        {
            get { return this._configurationManagers; }
            set { this._configurationManagers = value; }
        }

        // Check to see if ConfigurationManagers property is set
        internal bool IsSetConfigurationManagers()
        {
            return this._configurationManagers != null && (this._configurationManagers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of a supported operating system, such as <c>Amazon Linux 2</c>.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the operating system, such as <c>Amazon Linux 2</c>.
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
        /// Gets and sets the property ReportedName. 
        /// <para>
        /// A short name for the operating system manufacturer.
        /// </para>
        /// </summary>
        public string ReportedName
        {
            get { return this._reportedName; }
            set { this._reportedName = value; }
        }

        // Check to see if ReportedName property is set
        internal bool IsSetReportedName()
        {
            return this._reportedName != null;
        }

        /// <summary>
        /// Gets and sets the property ReportedVersion. 
        /// <para>
        /// The version of the operating system, including the release and edition, if applicable.
        /// </para>
        /// </summary>
        public string ReportedVersion
        {
            get { return this._reportedVersion; }
            set { this._reportedVersion = value; }
        }

        // Check to see if ReportedVersion property is set
        internal bool IsSetReportedVersion()
        {
            return this._reportedVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Supported. 
        /// <para>
        /// Indicates that an operating system is not supported for new instances.
        /// </para>
        /// </summary>
        public bool? Supported
        {
            get { return this._supported; }
            set { this._supported = value; }
        }

        // Check to see if Supported property is set
        internal bool IsSetSupported()
        {
            return this._supported.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of a supported operating system, either <c>Linux</c> or <c>Windows</c>.
        /// </para>
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}