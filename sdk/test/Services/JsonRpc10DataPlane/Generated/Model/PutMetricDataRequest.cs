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
 * Do not modify this file. This file is generated from the jsonrpc10dataplane-1999-12-31.normal.json service model.
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
namespace Amazon.JsonRpc10DataPlane.Model
{
    /// <summary>
    /// Container for the parameters to the PutMetricData operation.
    /// <pre><c>As seen in Amazon CloudWatch. </c></pre>
    /// </summary>
    public partial class PutMetricDataRequest : AmazonJsonRpc10DataPlaneRequest
    {
        private List<EntityMetricDatum> _entityMetricData = AWSConfigs.InitializeCollections ? new List<EntityMetricDatum>() : null;
        private List<MetricDatum> _metricData = AWSConfigs.InitializeCollections ? new List<MetricDatum>() : null;
        private string _awsNamespace;
        private bool? _strictEntityValidation;

        /// <summary>
        /// Gets and sets the property EntityMetricData.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EntityMetricDatum> EntityMetricData
        {
            get { return this._entityMetricData; }
            set { this._entityMetricData = value; }
        }

        // Check to see if EntityMetricData property is set
        internal bool IsSetEntityMetricData()
        {
            return this._entityMetricData != null && (this._entityMetricData.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MetricData.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MetricDatum> MetricData
        {
            get { return this._metricData; }
            set { this._metricData = value; }
        }

        // Check to see if MetricData property is set
        internal bool IsSetMetricData()
        {
            return this._metricData != null && (this._metricData.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Namespace.
        /// </summary>
        [AWSProperty(Required=true)]
        public string Namespace
        {
            get { return this._awsNamespace; }
            set { this._awsNamespace = value; }
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this._awsNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property StrictEntityValidation.
        /// </summary>
        public bool? StrictEntityValidation
        {
            get { return this._strictEntityValidation; }
            set { this._strictEntityValidation = value; }
        }

        // Check to see if StrictEntityValidation property is set
        internal bool IsSetStrictEntityValidation()
        {
            return this._strictEntityValidation.HasValue; 
        }

    }
}