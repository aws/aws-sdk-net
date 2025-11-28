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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Details about automated evaluations.
    /// </summary>
    public partial class AutoEvaluationDetails
    {
        private bool? _autoEvaluationEnabled;
        private AutoEvaluationStatus _autoEvaluationStatus;

        /// <summary>
        /// Gets and sets the property AutoEvaluationEnabled. 
        /// <para>
        /// Whether automated evaluation is enabled.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? AutoEvaluationEnabled
        {
            get { return this._autoEvaluationEnabled; }
            set { this._autoEvaluationEnabled = value; }
        }

        // Check to see if AutoEvaluationEnabled property is set
        internal bool IsSetAutoEvaluationEnabled()
        {
            return this._autoEvaluationEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AutoEvaluationStatus. 
        /// <para>
        /// The status of the contact auto-evaluation. 
        /// </para>
        /// </summary>
        public AutoEvaluationStatus AutoEvaluationStatus
        {
            get { return this._autoEvaluationStatus; }
            set { this._autoEvaluationStatus = value; }
        }

        // Check to see if AutoEvaluationStatus property is set
        internal bool IsSetAutoEvaluationStatus()
        {
            return this._autoEvaluationStatus != null;
        }

    }
}