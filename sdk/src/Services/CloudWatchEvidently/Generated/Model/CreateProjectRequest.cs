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

namespace Amazon.CloudWatchEvidently.Model
{
    /// <summary>
    /// Container for the parameters to the CreateProject operation.
    /// Creates a project, which is the logical object in Evidently that can contain features,
    /// launches, and experiments. Use projects to group similar features together.
    /// 
    ///  
    /// <para>
    /// To update an existing project, use <a href="https://docs.aws.amazon.com/cloudwatchevidently/latest/APIReference/API_UpdateProject.html">UpdateProject</a>.
    /// </para>
    /// </summary>
    public partial class CreateProjectRequest : AmazonCloudWatchEvidentlyRequest
    {
        private ProjectAppConfigResourceConfig _appConfigResource;
        private ProjectDataDeliveryConfig _dataDelivery;
        private string _description;
        private string _name;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property AppConfigResource. 
        /// <para>
        /// Use this parameter if the project will use <i>client-side evaluation powered by AppConfig</i>.
        /// Client-side evaluation allows your application to assign variations to user sessions
        /// locally instead of by calling the <a href="https://docs.aws.amazon.com/cloudwatchevidently/latest/APIReference/API_EvaluateFeature.html">EvaluateFeature</a>
        /// operation. This mitigates the latency and availability risks that come with an API
        /// call. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Evidently-client-side-evaluation.html">
        /// Client-side evaluation - powered by AppConfig.</a> 
        /// </para>
        ///  
        /// <para>
        /// This parameter is a structure that contains information about the AppConfig application
        /// and environment that will be used as for client-side evaluation.
        /// </para>
        ///  
        /// <para>
        /// To create a project that uses client-side evaluation, you must have the <code>evidently:ExportProjectAsConfiguration</code>
        /// permission.
        /// </para>
        /// </summary>
        public ProjectAppConfigResourceConfig AppConfigResource
        {
            get { return this._appConfigResource; }
            set { this._appConfigResource = value; }
        }

        // Check to see if AppConfigResource property is set
        internal bool IsSetAppConfigResource()
        {
            return this._appConfigResource != null;
        }

        /// <summary>
        /// Gets and sets the property DataDelivery. 
        /// <para>
        /// A structure that contains information about where Evidently is to store evaluation
        /// events for longer term storage, if you choose to do so. If you choose not to store
        /// these events, Evidently deletes them after using them to produce metrics and other
        /// experiment results that you can view.
        /// </para>
        /// </summary>
        public ProjectDataDeliveryConfig DataDelivery
        {
            get { return this._dataDelivery; }
            set { this._dataDelivery = value; }
        }

        // Check to see if DataDelivery property is set
        internal bool IsSetDataDelivery()
        {
            return this._dataDelivery != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional description of the project.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=160)]
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the project.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=127)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Assigns one or more tags (key-value pairs) to the project.
        /// </para>
        ///  
        /// <para>
        /// Tags can help you organize and categorize your resources. You can also use them to
        /// scope user permissions by granting a user permission to access or change only resources
        /// with certain tag values.
        /// </para>
        ///  
        /// <para>
        /// Tags don't have any semantic meaning to Amazon Web Services and are interpreted strictly
        /// as strings of characters.
        /// </para>
        ///  
        /// <para>
        /// You can associate as many as 50 tags with a project.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// Amazon Web Services resources</a>.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Tags
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