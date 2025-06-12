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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// An object containing configuration for a compute environment (such as Spark, Python
    /// or Athena) returned by the <c>DescribeConnectionType</c> API.
    /// </summary>
    public partial class ComputeEnvironmentConfiguration
    {
        private ComputeEnvironment _computeEnvironment;
        private Dictionary<string, string> _connectionOptionNameOverrides = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Dictionary<string, Property> _connectionOptions = AWSConfigs.InitializeCollections ? new Dictionary<string, Property>() : null;
        private List<string> _connectionPropertiesRequiredOverrides = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Dictionary<string, string> _connectionPropertyNameOverrides = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _description;
        private string _name;
        private bool? _physicalConnectionPropertiesRequired;
        private List<string> _supportedAuthenticationTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ComputeEnvironment. 
        /// <para>
        /// The type of compute environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ComputeEnvironment ComputeEnvironment
        {
            get { return this._computeEnvironment; }
            set { this._computeEnvironment = value; }
        }

        // Check to see if ComputeEnvironment property is set
        internal bool IsSetComputeEnvironment()
        {
            return this._computeEnvironment != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionOptionNameOverrides. 
        /// <para>
        /// The connection option name overrides for the compute environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, string> ConnectionOptionNameOverrides
        {
            get { return this._connectionOptionNameOverrides; }
            set { this._connectionOptionNameOverrides = value; }
        }

        // Check to see if ConnectionOptionNameOverrides property is set
        internal bool IsSetConnectionOptionNameOverrides()
        {
            return this._connectionOptionNameOverrides != null && (this._connectionOptionNameOverrides.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ConnectionOptions. 
        /// <para>
        /// The parameters used as connection options for the compute environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, Property> ConnectionOptions
        {
            get { return this._connectionOptions; }
            set { this._connectionOptions = value; }
        }

        // Check to see if ConnectionOptions property is set
        internal bool IsSetConnectionOptions()
        {
            return this._connectionOptions != null && (this._connectionOptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ConnectionPropertiesRequiredOverrides. 
        /// <para>
        /// The connection properties that are required as overrides for the compute environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> ConnectionPropertiesRequiredOverrides
        {
            get { return this._connectionPropertiesRequiredOverrides; }
            set { this._connectionPropertiesRequiredOverrides = value; }
        }

        // Check to see if ConnectionPropertiesRequiredOverrides property is set
        internal bool IsSetConnectionPropertiesRequiredOverrides()
        {
            return this._connectionPropertiesRequiredOverrides != null && (this._connectionPropertiesRequiredOverrides.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ConnectionPropertyNameOverrides. 
        /// <para>
        /// The connection property name overrides for the compute environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, string> ConnectionPropertyNameOverrides
        {
            get { return this._connectionPropertyNameOverrides; }
            set { this._connectionPropertyNameOverrides = value; }
        }

        // Check to see if ConnectionPropertyNameOverrides property is set
        internal bool IsSetConnectionPropertyNameOverrides()
        {
            return this._connectionPropertyNameOverrides != null && (this._connectionPropertyNameOverrides.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the compute environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
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
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for the compute environment configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// Gets and sets the property PhysicalConnectionPropertiesRequired. 
        /// <para>
        /// Indicates whether <c>PhysicalConnectionProperties</c> are required for the compute
        /// environment.
        /// </para>
        /// </summary>
        public bool? PhysicalConnectionPropertiesRequired
        {
            get { return this._physicalConnectionPropertiesRequired; }
            set { this._physicalConnectionPropertiesRequired = value; }
        }

        // Check to see if PhysicalConnectionPropertiesRequired property is set
        internal bool IsSetPhysicalConnectionPropertiesRequired()
        {
            return this._physicalConnectionPropertiesRequired.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SupportedAuthenticationTypes. 
        /// <para>
        /// The supported authentication types for the compute environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> SupportedAuthenticationTypes
        {
            get { return this._supportedAuthenticationTypes; }
            set { this._supportedAuthenticationTypes = value; }
        }

        // Check to see if SupportedAuthenticationTypes property is set
        internal bool IsSetSupportedAuthenticationTypes()
        {
            return this._supportedAuthenticationTypes != null && (this._supportedAuthenticationTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}