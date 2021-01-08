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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Container for the parameters to the ListSteps operation.
    /// Provides a list of steps for the cluster in reverse order unless you specify <code>stepIds</code>
    /// with the request of filter by <code>StepStates</code>. You can specify a maximum of
    /// ten <code>stepIDs</code>.
    /// </summary>
    public partial class ListStepsRequest : AmazonElasticMapReduceRequest
    {
        private string _clusterId;
        private string _marker;
        private List<string> _stepIds = new List<string>();
        private List<string> _stepStates = new List<string>();

        /// <summary>
        /// Gets and sets the property ClusterId. 
        /// <para>
        /// The identifier of the cluster for which to list the steps.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ClusterId
        {
            get { return this._clusterId; }
            set { this._clusterId = value; }
        }

        // Check to see if ClusterId property is set
        internal bool IsSetClusterId()
        {
            return this._clusterId != null;
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// The pagination token that indicates the next set of results to retrieve.
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property StepIds. 
        /// <para>
        /// The filter to limit the step list based on the identifier of the steps. You can specify
        /// a maximum of ten Step IDs. The character constraint applies to the overall length
        /// of the array.
        /// </para>
        /// </summary>
        public List<string> StepIds
        {
            get { return this._stepIds; }
            set { this._stepIds = value; }
        }

        // Check to see if StepIds property is set
        internal bool IsSetStepIds()
        {
            return this._stepIds != null && this._stepIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StepStates. 
        /// <para>
        /// The filter to limit the step list based on certain states.
        /// </para>
        /// </summary>
        public List<string> StepStates
        {
            get { return this._stepStates; }
            set { this._stepStates = value; }
        }

        // Check to see if StepStates property is set
        internal bool IsSetStepStates()
        {
            return this._stepStates != null && this._stepStates.Count > 0; 
        }

    }
}