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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Returns details of a resource evaluation based on the selected filter.
    /// </summary>
    public partial class ResourceEvaluationFilters
    {
        private string _evaluationContextIdentifier;
        private EvaluationMode _evaluationMode;
        private TimeWindow _timeWindow;

        /// <summary>
        /// Gets and sets the property EvaluationContextIdentifier. 
        /// <para>
        /// Filters evaluations for a given infrastructure deployment. For example: CFN Stack.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string EvaluationContextIdentifier
        {
            get { return this._evaluationContextIdentifier; }
            set { this._evaluationContextIdentifier = value; }
        }

        // Check to see if EvaluationContextIdentifier property is set
        internal bool IsSetEvaluationContextIdentifier()
        {
            return this._evaluationContextIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluationMode. 
        /// <para>
        /// Filters all resource evaluations results based on an evaluation mode. the valid value
        /// for this API is <code>Proactive</code>.
        /// </para>
        /// </summary>
        public EvaluationMode EvaluationMode
        {
            get { return this._evaluationMode; }
            set { this._evaluationMode = value; }
        }

        // Check to see if EvaluationMode property is set
        internal bool IsSetEvaluationMode()
        {
            return this._evaluationMode != null;
        }

        /// <summary>
        /// Gets and sets the property TimeWindow. 
        /// <para>
        /// Returns a <code>TimeWindow</code> object.
        /// </para>
        /// </summary>
        public TimeWindow TimeWindow
        {
            get { return this._timeWindow; }
            set { this._timeWindow = value; }
        }

        // Check to see if TimeWindow property is set
        internal bool IsSetTimeWindow()
        {
            return this._timeWindow != null;
        }

    }
}