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
    /// Container for the parameters to the CreateExperiment operation.
    /// Creates a SageMaker <i>experiment</i>. An experiment is a collection of <i>trials</i>
    /// that are observed, compared and evaluated as a group. A trial is a set of steps, called
    /// <i>trial components</i>, that produce a machine learning model.
    /// 
    ///  <note> 
    /// <para>
    /// In the Studio UI, trials are referred to as <i>run groups</i> and trial components
    /// are referred to as <i>runs</i>.
    /// </para>
    ///  </note> 
    /// <para>
    /// The goal of an experiment is to determine the components that produce the best model.
    /// Multiple trials are performed, each one isolating and measuring the impact of a change
    /// to one or more inputs, while keeping the remaining inputs constant.
    /// </para>
    ///  
    /// <para>
    /// When you use SageMaker Studio or the SageMaker Python SDK, all experiments, trials,
    /// and trial components are automatically tracked, logged, and indexed. When you use
    /// the Amazon Web Services SDK for Python (Boto), you must use the logging APIs provided
    /// by the SDK.
    /// </para>
    ///  
    /// <para>
    /// You can add tags to experiments, trials, trial components and then use the <a>Search</a>
    /// API to search for the tags.
    /// </para>
    ///  
    /// <para>
    /// To add a description to an experiment, specify the optional <code>Description</code>
    /// parameter. To add a description later, or to change the description, call the <a>UpdateExperiment</a>
    /// API.
    /// </para>
    ///  
    /// <para>
    /// To get a list of all your experiments, call the <a>ListExperiments</a> API. To view
    /// an experiment's properties, call the <a>DescribeExperiment</a> API. To get a list
    /// of all the trials associated with an experiment, call the <a>ListTrials</a> API. To
    /// create a trial call the <a>CreateTrial</a> API.
    /// </para>
    /// </summary>
    public partial class CreateExperimentRequest : AmazonSageMakerRequest
    {
        private string _description;
        private string _displayName;
        private string _experimentName;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the experiment.
        /// </para>
        /// </summary>
        [AWSProperty(Max=3072)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The name of the experiment as displayed. The name doesn't need to be unique. If you
        /// don't specify <code>DisplayName</code>, the value in <code>ExperimentName</code> is
        /// displayed.
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
        /// The name of the experiment. The name must be unique in your Amazon Web Services account
        /// and is not case-sensitive.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags to associate with the experiment. You can use <a>Search</a> API to
        /// search on the tags.
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

    }
}