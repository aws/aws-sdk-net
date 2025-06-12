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
 * Do not modify this file. This file is generated from the supplychain-2024-01-01.normal.json service model.
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
namespace Amazon.SupplyChain.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDataIntegrationFlow operation.
    /// Enables you to programmatically update an existing data pipeline to ingest data from
    /// the source systems such as, Amazon S3 buckets, to a predefined Amazon Web Services
    /// Supply Chain dataset (product, inbound_order) or a temporary dataset along with the
    /// data transformation query provided with the API.
    /// </summary>
    public partial class UpdateDataIntegrationFlowRequest : AmazonSupplyChainRequest
    {
        private string _instanceId;
        private string _name;
        private List<DataIntegrationFlowSource> _sources = AWSConfigs.InitializeCollections ? new List<DataIntegrationFlowSource>() : null;
        private DataIntegrationFlowTarget _target;
        private DataIntegrationFlowTransformation _transformation;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The Amazon Web Services Supply Chain instance identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the DataIntegrationFlow to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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
        /// Gets and sets the property Sources. 
        /// <para>
        /// The new source configurations for the DataIntegrationFlow.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=40)]
        public List<DataIntegrationFlowSource> Sources
        {
            get { return this._sources; }
            set { this._sources = value; }
        }

        // Check to see if Sources property is set
        internal bool IsSetSources()
        {
            return this._sources != null && (this._sources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// The new target configurations for the DataIntegrationFlow.
        /// </para>
        /// </summary>
        public DataIntegrationFlowTarget Target
        {
            get { return this._target; }
            set { this._target = value; }
        }

        // Check to see if Target property is set
        internal bool IsSetTarget()
        {
            return this._target != null;
        }

        /// <summary>
        /// Gets and sets the property Transformation. 
        /// <para>
        /// The new transformation configurations for the DataIntegrationFlow.
        /// </para>
        /// </summary>
        public DataIntegrationFlowTransformation Transformation
        {
            get { return this._transformation; }
            set { this._transformation = value; }
        }

        // Check to see if Transformation property is set
        internal bool IsSetTransformation()
        {
            return this._transformation != null;
        }

    }
}