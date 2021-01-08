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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the CreateTrial operation.
    /// Creates an Amazon SageMaker <i>trial</i>. A trial is a set of steps called <i>trial
    /// components</i> that produce a machine learning model. A trial is part of a single
    /// Amazon SageMaker <i>experiment</i>.
    /// 
    ///  
    /// <para>
    /// When you use Amazon SageMaker Studio or the Amazon SageMaker Python SDK, all experiments,
    /// trials, and trial components are automatically tracked, logged, and indexed. When
    /// you use the AWS SDK for Python (Boto), you must use the logging APIs provided by the
    /// SDK.
    /// </para>
    ///  
    /// <para>
    /// You can add tags to a trial and then use the <a>Search</a> API to search for the tags.
    /// </para>
    ///  
    /// <para>
    /// To get a list of all your trials, call the <a>ListTrials</a> API. To view a trial's
    /// properties, call the <a>DescribeTrial</a> API. To create a trial component, call the
    /// <a>CreateTrialComponent</a> API.
    /// </para>
    /// </summary>
    public partial class CreateTrialRequest : AmazonSageMakerRequest
    {
        private string _displayName;
        private string _experimentName;
        private MetadataProperties _metadataProperties;
        private List<Tag> _tags = new List<Tag>();
        private string _trialName;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The name of the trial as displayed. The name doesn't need to be unique. If <code>DisplayName</code>
        /// isn't specified, <code>TrialName</code> is displayed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=120)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property ExperimentName. 
        /// <para>
        /// The name of the experiment to associate the trial with.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=120)]
        public string ExperimentName
        {
            get { return this._experimentName; }
            set { this._experimentName = value; }
        }

        // Check to see if ExperimentName property is set
        internal bool IsSetExperimentName()
        {
            return this._experimentName != null;
        }

        /// <summary>
        /// Gets and sets the property MetadataProperties.
        /// </summary>
        public MetadataProperties MetadataProperties
        {
            get { return this._metadataProperties; }
            set { this._metadataProperties = value; }
        }

        // Check to see if MetadataProperties property is set
        internal bool IsSetMetadataProperties()
        {
            return this._metadataProperties != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags to associate with the trial. You can use <a>Search</a> API to search
        /// on the tags.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TrialName. 
        /// <para>
        /// The name of the trial. The name must be unique in your AWS account and is not case-sensitive.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=120)]
        public string TrialName
        {
            get { return this._trialName; }
            set { this._trialName = value; }
        }

        // Check to see if TrialName property is set
        internal bool IsSetTrialName()
        {
            return this._trialName != null;
        }

    }
}