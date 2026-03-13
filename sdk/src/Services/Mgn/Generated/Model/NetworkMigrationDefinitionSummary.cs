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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
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
namespace Amazon.Mgn.Model
{
    /// <summary>
    /// A summary of a network migration definition.
    /// </summary>
    public partial class NetworkMigrationDefinitionSummary
    {
        private string _arn;
        private string _name;
        private string _networkMigrationDefinitionID;
        private Dictionary<string, string> _scopeTags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private SourceEnvironment _sourceEnvironment;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the network migration definition.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the network migration definition.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// Gets and sets the property NetworkMigrationDefinitionID. 
        /// <para>
        /// The unique identifier of the network migration definition.
        /// </para>
        /// </summary>
        [AWSProperty(Min=21, Max=21)]
        public string NetworkMigrationDefinitionID
        {
            get { return this._networkMigrationDefinitionID; }
            set { this._networkMigrationDefinitionID = value; }
        }

        // Check to see if NetworkMigrationDefinitionID property is set
        internal bool IsSetNetworkMigrationDefinitionID()
        {
            return this._networkMigrationDefinitionID != null;
        }

        /// <summary>
        /// Gets and sets the property ScopeTags. 
        /// <para>
        /// Scope tags for the network migration definition.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=40)]
        public Dictionary<string, string> ScopeTags
        {
            get { return this._scopeTags; }
            set { this._scopeTags = value; }
        }

        // Check to see if ScopeTags property is set
        internal bool IsSetScopeTags()
        {
            return this._scopeTags != null && (this._scopeTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SourceEnvironment. 
        /// <para>
        /// The source environment configuration.
        /// </para>
        /// </summary>
        public SourceEnvironment SourceEnvironment
        {
            get { return this._sourceEnvironment; }
            set { this._sourceEnvironment = value; }
        }

        // Check to see if SourceEnvironment property is set
        internal bool IsSetSourceEnvironment()
        {
            return this._sourceEnvironment != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags assigned to the network migration definition.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}