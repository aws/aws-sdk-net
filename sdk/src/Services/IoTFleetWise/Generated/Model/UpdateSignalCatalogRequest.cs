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
 * Do not modify this file. This file is generated from the iotfleetwise-2021-06-17.normal.json service model.
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
namespace Amazon.IoTFleetWise.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateSignalCatalog operation.
    /// Updates a signal catalog.
    /// </summary>
    public partial class UpdateSignalCatalogRequest : AmazonIoTFleetWiseRequest
    {
        private string _description;
        private string _name;
        private List<Node> _nodesToAdd = AWSConfigs.InitializeCollections ? new List<Node>() : null;
        private List<string> _nodesToRemove = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<Node> _nodesToUpdate = AWSConfigs.InitializeCollections ? new List<Node>() : null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  A brief description of the signal catalog to update.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        ///  The name of the signal catalog to update. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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
        /// Gets and sets the property NodesToAdd. 
        /// <para>
        ///  A list of information about nodes to add to the signal catalog. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public List<Node> NodesToAdd
        {
            get { return this._nodesToAdd; }
            set { this._nodesToAdd = value; }
        }

        // Check to see if NodesToAdd property is set
        internal bool IsSetNodesToAdd()
        {
            return this._nodesToAdd != null && (this._nodesToAdd.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NodesToRemove. 
        /// <para>
        ///  A list of <c>fullyQualifiedName</c> of nodes to remove from the signal catalog. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public List<string> NodesToRemove
        {
            get { return this._nodesToRemove; }
            set { this._nodesToRemove = value; }
        }

        // Check to see if NodesToRemove property is set
        internal bool IsSetNodesToRemove()
        {
            return this._nodesToRemove != null && (this._nodesToRemove.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NodesToUpdate. 
        /// <para>
        ///  A list of information about nodes to update in the signal catalog. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public List<Node> NodesToUpdate
        {
            get { return this._nodesToUpdate; }
            set { this._nodesToUpdate = value; }
        }

        // Check to see if NodesToUpdate property is set
        internal bool IsSetNodesToUpdate()
        {
            return this._nodesToUpdate != null && (this._nodesToUpdate.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}