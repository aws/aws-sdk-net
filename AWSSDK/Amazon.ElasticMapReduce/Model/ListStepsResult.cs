/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// This output contains the list of steps.
    /// </summary>
    public partial class ListStepsResult
    {
        private string _marker;
        private List<StepSummary> _steps = new List<StepSummary>();


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


        /// <summary>
        /// Sets the Marker property
        /// </summary>
        /// <param name="marker">The value to set for the Marker property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListStepsResult WithMarker(string marker)
        {
            this._marker = marker;
            return this;
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }


        /// <summary>
        /// Gets and sets the property Steps. 
        /// <para>
        /// The filtered list of steps for the cluster.
        /// </para>
        /// </summary>
        public List<StepSummary> Steps
        {
            get { return this._steps; }
            set { this._steps = value; }
        }

        /// <summary>
        /// Sets the Steps property
        /// </summary>
        /// <param name="steps">The values to add to the Steps collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListStepsResult WithSteps(params StepSummary[] steps)
        {
            foreach (var element in steps)
            {
                this._steps.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the Steps property
        /// </summary>
        /// <param name="steps">The values to add to the Steps collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListStepsResult WithSteps(IEnumerable<StepSummary> steps)
        {
            foreach (var element in steps)
            {
                this._steps.Add(element);
            }
            return this;
        }
        // Check to see if Steps property is set
        internal bool IsSetSteps()
        {
            return this._steps != null && this._steps.Count > 0; 
        }

    }
}