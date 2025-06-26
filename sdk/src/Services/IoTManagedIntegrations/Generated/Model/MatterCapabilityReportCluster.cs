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
 * Do not modify this file. This file is generated from the iot-managed-integrations-2025-03-03.normal.json service model.
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
namespace Amazon.IoTManagedIntegrations.Model
{
    /// <summary>
    /// Capability used in Matter capability report.
    /// </summary>
    public partial class MatterCapabilityReportCluster
    {
        private List<MatterCapabilityReportAttribute> _attributes = AWSConfigs.InitializeCollections ? new List<MatterCapabilityReportAttribute>() : null;
        private List<string> _commands = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _events = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _fabricIndex;
        private long? _featureMap;
        private List<string> _generatedCommands = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _id;
        private string _name;
        private string _publicId;
        private int? _revision;
        private string _specVersion;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// The attributes of the Amazon Web Services Matter capability report.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<MatterCapabilityReportAttribute> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && (this._attributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Commands. 
        /// <para>
        /// The commands used with the Amazon Web Services Matter capability report.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> Commands
        {
            get { return this._commands; }
            set { this._commands = value; }
        }

        // Check to see if Commands property is set
        internal bool IsSetCommands()
        {
            return this._commands != null && (this._commands.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Events. 
        /// <para>
        /// The events used with the Amazon Web Services Matter capability report.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> Events
        {
            get { return this._events; }
            set { this._events = value; }
        }

        // Check to see if Events property is set
        internal bool IsSetEvents()
        {
            return this._events != null && (this._events.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FabricIndex. 
        /// <para>
        /// The fabric index for the Amazon Web Services Matter capability report.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=4096)]
        public int? FabricIndex
        {
            get { return this._fabricIndex; }
            set { this._fabricIndex = value; }
        }

        // Check to see if FabricIndex property is set
        internal bool IsSetFabricIndex()
        {
            return this._fabricIndex.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FeatureMap. 
        /// <para>
        /// 32 bit-map used to indicate which features a cluster supports.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=4294967295)]
        public long? FeatureMap
        {
            get { return this._featureMap; }
            set { this._featureMap = value; }
        }

        // Check to see if FeatureMap property is set
        internal bool IsSetFeatureMap()
        {
            return this._featureMap.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GeneratedCommands. 
        /// <para>
        /// Matter clusters used in capability report.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<string> GeneratedCommands
        {
            get { return this._generatedCommands; }
            set { this._generatedCommands = value; }
        }

        // Check to see if GeneratedCommands property is set
        internal bool IsSetGeneratedCommands()
        {
            return this._generatedCommands != null && (this._generatedCommands.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The id of the Amazon Web Services Matter capability report cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=24)]
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
        /// The capability name used in the Amazon Web Services Matter capability report.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// Gets and sets the property PublicId. 
        /// <para>
        /// The id of the schema version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=7, Max=128)]
        public string PublicId
        {
            get { return this._publicId; }
            set { this._publicId = value; }
        }

        // Check to see if PublicId property is set
        internal bool IsSetPublicId()
        {
            return this._publicId != null;
        }

        /// <summary>
        /// Gets and sets the property Revision. 
        /// <para>
        /// The id of the revision for the Amazon Web Services Matter capability report.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public int? Revision
        {
            get { return this._revision; }
            set { this._revision = value; }
        }

        // Check to see if Revision property is set
        internal bool IsSetRevision()
        {
            return this._revision.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SpecVersion. 
        /// <para>
        /// The spec version used in the Amazon Web Services Matter capability report.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string SpecVersion
        {
            get { return this._specVersion; }
            set { this._specVersion = value; }
        }

        // Check to see if SpecVersion property is set
        internal bool IsSetSpecVersion()
        {
            return this._specVersion != null;
        }

    }
}