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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Contains an asset metric property. With metrics, you can calculate aggregate functions,
    /// such as an average, maximum, or minimum, as specified through an expression. A metric
    /// maps several values to a single value (such as a sum).
    /// 
    ///  
    /// <para>
    /// The maximum number of dependent/cascading variables used in any one metric calculation
    /// is 10. Therefore, a <i>root</i> metric can have up to 10 cascading metrics in its
    /// computational dependency tree. Additionally, a metric can only have a data type of
    /// <c>DOUBLE</c> and consume properties with data types of <c>INTEGER</c> or <c>DOUBLE</c>.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/asset-properties.html#metrics">Metrics</a>
    /// in the <i>IoT SiteWise User Guide</i>.
    /// </para>
    /// </summary>
    public partial class Metric
    {
        private string _expression;
        private MetricProcessingConfig _processingConfig;
        private List<ExpressionVariable> _variables = AWSConfigs.InitializeCollections ? new List<ExpressionVariable>() : null;
        private MetricWindow _window;

        /// <summary>
        /// Gets and sets the property Expression. 
        /// <para>
        /// The mathematical expression that defines the metric aggregation function. You can
        /// specify up to 10 variables per expression. You can specify up to 10 functions per
        /// expression. 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/quotas.html">Quotas</a>
        /// in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Expression
        {
            get { return this._expression; }
            set { this._expression = value; }
        }

        // Check to see if Expression property is set
        internal bool IsSetExpression()
        {
            return this._expression != null;
        }

        /// <summary>
        /// Gets and sets the property ProcessingConfig. 
        /// <para>
        /// The processing configuration for the given metric property. You can configure metrics
        /// to be computed at the edge or in the Amazon Web Services Cloud. By default, metrics
        /// are forwarded to the cloud.
        /// </para>
        /// </summary>
        public MetricProcessingConfig ProcessingConfig
        {
            get { return this._processingConfig; }
            set { this._processingConfig = value; }
        }

        // Check to see if ProcessingConfig property is set
        internal bool IsSetProcessingConfig()
        {
            return this._processingConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Variables. 
        /// <para>
        /// The list of variables used in the expression.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ExpressionVariable> Variables
        {
            get { return this._variables; }
            set { this._variables = value; }
        }

        // Check to see if Variables property is set
        internal bool IsSetVariables()
        {
            return this._variables != null && (this._variables.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Window. 
        /// <para>
        /// The window (time interval) over which IoT SiteWise computes the metric's aggregation
        /// expression. IoT SiteWise computes one data point per <c>window</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MetricWindow Window
        {
            get { return this._window; }
            set { this._window = value; }
        }

        // Check to see if Window property is set
        internal bool IsSetWindow()
        {
            return this._window != null;
        }

    }
}