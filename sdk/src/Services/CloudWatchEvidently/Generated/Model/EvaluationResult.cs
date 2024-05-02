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
 * Do not modify this file. This file is generated from the evidently-2021-02-01.normal.json service model.
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
namespace Amazon.CloudWatchEvidently.Model
{
    /// <summary>
    /// This structure displays the results of one feature evaluation assignment to one user
    /// session.
    /// </summary>
    public partial class EvaluationResult
    {
        private string _details;
        private string _entityId;
        private string _feature;
        private string _project;
        private string _reason;
        private VariableValue _value;
        private string _variation;

        /// <summary>
        /// Gets and sets the property Details. 
        /// <para>
        /// If this user was assigned to a launch or experiment, this field lists the launch or
        /// experiment name.
        /// </para>
        /// </summary>
        public string Details
        {
            get { return this._details; }
            set { this._details = value; }
        }

        // Check to see if Details property is set
        internal bool IsSetDetails()
        {
            return this._details != null;
        }

        /// <summary>
        /// Gets and sets the property EntityId. 
        /// <para>
        /// An internal ID that represents a unique user session of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string EntityId
        {
            get { return this._entityId; }
            set { this._entityId = value; }
        }

        // Check to see if EntityId property is set
        internal bool IsSetEntityId()
        {
            return this._entityId != null;
        }

        /// <summary>
        /// Gets and sets the property Feature. 
        /// <para>
        /// The name of the feature being evaluated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=127)]
        public string Feature
        {
            get { return this._feature; }
            set { this._feature = value; }
        }

        // Check to see if Feature property is set
        internal bool IsSetFeature()
        {
            return this._feature != null;
        }

        /// <summary>
        /// Gets and sets the property Project. 
        /// <para>
        /// The name or ARN of the project that contains the feature being evaluated.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string Project
        {
            get { return this._project; }
            set { this._project = value; }
        }

        // Check to see if Project property is set
        internal bool IsSetProject()
        {
            return this._project != null;
        }

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// Specifies the reason that the user session was assigned this variation. Possible values
        /// include <c>DEFAULT</c>, meaning the user was served the default variation; <c>LAUNCH_RULE_MATCH</c>,
        /// if the user session was enrolled in a launch; or <c>EXPERIMENT_RULE_MATCH</c>, if
        /// the user session was enrolled in an experiment.
        /// </para>
        /// </summary>
        public string Reason
        {
            get { return this._reason; }
            set { this._reason = value; }
        }

        // Check to see if Reason property is set
        internal bool IsSetReason()
        {
            return this._reason != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value assigned to this variation to differentiate it from the other variations
        /// of this feature.
        /// </para>
        /// </summary>
        public VariableValue Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

        /// <summary>
        /// Gets and sets the property Variation. 
        /// <para>
        /// The name of the variation that was served to the user session.
        /// </para>
        /// </summary>
        public string Variation
        {
            get { return this._variation; }
            set { this._variation = value; }
        }

        // Check to see if Variation property is set
        internal bool IsSetVariation()
        {
            return this._variation != null;
        }

    }
}