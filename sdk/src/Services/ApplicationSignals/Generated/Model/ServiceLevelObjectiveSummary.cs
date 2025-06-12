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
 * Do not modify this file. This file is generated from the application-signals-2024-04-15.normal.json service model.
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
namespace Amazon.ApplicationSignals.Model
{
    /// <summary>
    /// A structure that contains information about one service level objective (SLO) created
    /// in Application Signals.
    /// </summary>
    public partial class ServiceLevelObjectiveSummary
    {
        private string _arn;
        private DateTime? _createdTime;
        private DependencyConfig _dependencyConfig;
        private EvaluationType _evaluationType;
        private Dictionary<string, string> _keyAttributes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private MetricSourceType _metricSourceType;
        private string _name;
        private string _operationName;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of this service level objective.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
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
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The date and time that this service level objective was created. It is expressed as
        /// the number of milliseconds since Jan 1, 1970 00:00:00 UTC.
        /// </para>
        /// </summary>
        public DateTime? CreatedTime
        {
            get { return this._createdTime; }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DependencyConfig. 
        /// <para>
        /// Identifies the dependency using the <c>DependencyKeyAttributes</c> and <c>DependencyOperationName</c>.
        /// 
        /// </para>
        /// </summary>
        public DependencyConfig DependencyConfig
        {
            get { return this._dependencyConfig; }
            set { this._dependencyConfig = value; }
        }

        // Check to see if DependencyConfig property is set
        internal bool IsSetDependencyConfig()
        {
            return this._dependencyConfig != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluationType. 
        /// <para>
        /// Displays whether this is a period-based SLO or a request-based SLO.
        /// </para>
        /// </summary>
        public EvaluationType EvaluationType
        {
            get { return this._evaluationType; }
            set { this._evaluationType = value; }
        }

        // Check to see if EvaluationType property is set
        internal bool IsSetEvaluationType()
        {
            return this._evaluationType != null;
        }

        /// <summary>
        /// Gets and sets the property KeyAttributes. 
        /// <para>
        /// This is a string-to-string map. It can include the following fields.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Type</c> designates the type of object this service level objective is for.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ResourceType</c> specifies the type of the resource. This field is used only when
        /// the value of the <c>Type</c> field is <c>Resource</c> or <c>AWS::Resource</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Name</c> specifies the name of the object. This is used only if the value of the
        /// <c>Type</c> field is <c>Service</c>, <c>RemoteService</c>, or <c>AWS::Service</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Identifier</c> identifies the resource objects of this resource. This is used
        /// only if the value of the <c>Type</c> field is <c>Resource</c> or <c>AWS::Resource</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Environment</c> specifies the location where this object is hosted, or what it
        /// belongs to.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=4)]
        public Dictionary<string, string> KeyAttributes
        {
            get { return this._keyAttributes; }
            set { this._keyAttributes = value; }
        }

        // Check to see if KeyAttributes property is set
        internal bool IsSetKeyAttributes()
        {
            return this._keyAttributes != null && (this._keyAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MetricSourceType. 
        /// <para>
        /// Displays the SLI metric source type for this SLO. Supported types are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Service operation
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Service dependency
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CloudWatch metric
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public MetricSourceType MetricSourceType
        {
            get { return this._metricSourceType; }
            set { this._metricSourceType = value; }
        }

        // Check to see if MetricSourceType property is set
        internal bool IsSetMetricSourceType()
        {
            return this._metricSourceType != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the service level objective.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property OperationName. 
        /// <para>
        /// If this service level objective is specific to a single operation, this field displays
        /// the name of that operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string OperationName
        {
            get { return this._operationName; }
            set { this._operationName = value; }
        }

        // Check to see if OperationName property is set
        internal bool IsSetOperationName()
        {
            return this._operationName != null;
        }

    }
}