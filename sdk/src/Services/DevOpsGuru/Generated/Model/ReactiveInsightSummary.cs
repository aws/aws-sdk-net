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
 * Do not modify this file. This file is generated from the devops-guru-2020-12-01.normal.json service model.
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
namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// Information about a reactive insight. This object is returned by <c>DescribeInsight.</c>
    /// </summary>
    public partial class ReactiveInsightSummary
    {
        private List<string> _associatedResourceArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _id;
        private InsightTimeRange _insightTimeRange;
        private string _name;
        private ResourceCollection _resourceCollection;
        private ServiceCollection _serviceCollection;
        private InsightSeverity _severity;
        private InsightStatus _status;

        /// <summary>
        /// Gets and sets the property AssociatedResourceArns. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the Amazon Web Services resources that generated
        /// this insight.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AssociatedResourceArns
        {
            get { return this._associatedResourceArns; }
            set { this._associatedResourceArns = value; }
        }

        // Check to see if AssociatedResourceArns property is set
        internal bool IsSetAssociatedResourceArns()
        {
            return this._associatedResourceArns != null && (this._associatedResourceArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        ///  The ID of a reactive summary. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// Gets and sets the property InsightTimeRange.
        /// </summary>
        public InsightTimeRange InsightTimeRange
        {
            get { return this._insightTimeRange; }
            set { this._insightTimeRange = value; }
        }

        // Check to see if InsightTimeRange property is set
        internal bool IsSetInsightTimeRange()
        {
            return this._insightTimeRange != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of a reactive insight. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=530)]
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
        /// Gets and sets the property ResourceCollection.
        /// </summary>
        public ResourceCollection ResourceCollection
        {
            get { return this._resourceCollection; }
            set { this._resourceCollection = value; }
        }

        // Check to see if ResourceCollection property is set
        internal bool IsSetResourceCollection()
        {
            return this._resourceCollection != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceCollection. 
        /// <para>
        /// A collection of the names of Amazon Web Services services.
        /// </para>
        /// </summary>
        public ServiceCollection ServiceCollection
        {
            get { return this._serviceCollection; }
            set { this._serviceCollection = value; }
        }

        // Check to see if ServiceCollection property is set
        internal bool IsSetServiceCollection()
        {
            return this._serviceCollection != null;
        }

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// The severity of the insight. For more information, see <a href="https://docs.aws.amazon.com/devops-guru/latest/userguide/working-with-insights.html#understanding-insights-severities">Understanding
        /// insight severities</a> in the <i>Amazon DevOps Guru User Guide</i>.
        /// </para>
        /// </summary>
        public InsightSeverity Severity
        {
            get { return this._severity; }
            set { this._severity = value; }
        }

        // Check to see if Severity property is set
        internal bool IsSetSeverity()
        {
            return this._severity != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The status of a reactive insight. 
        /// </para>
        /// </summary>
        public InsightStatus Status
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