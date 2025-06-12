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
    /// Container for the parameters to the UpdateModelManifest operation.
    /// Updates a vehicle model (model manifest). If created vehicles are associated with
    /// a vehicle model, it can't be updated.
    /// </summary>
    public partial class UpdateModelManifestRequest : AmazonIoTFleetWiseRequest
    {
        private string _description;
        private string _name;
        private List<string> _nodesToAdd = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _nodesToRemove = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ManifestStatus _status;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  A brief description of the vehicle model. 
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
        ///  The name of the vehicle model to update. 
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
        ///  A list of <c>fullyQualifiedName</c> of nodes, which are a general abstraction of
        /// signals, to add to the vehicle model. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public List<string> NodesToAdd
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
        ///  A list of <c>fullyQualifiedName</c> of nodes, which are a general abstraction of
        /// signals, to remove from the vehicle model. 
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
        /// Gets and sets the property Status. 
        /// <para>
        ///  The state of the vehicle model. If the status is <c>ACTIVE</c>, the vehicle model
        /// can't be edited. If the status is <c>DRAFT</c>, you can edit the vehicle model. 
        /// </para>
        /// </summary>
        public ManifestStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}