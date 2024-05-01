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
 * Do not modify this file. This file is generated from the kafkaconnect-2021-09-14.normal.json service model.
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
namespace Amazon.KafkaConnect.Model
{
    /// <summary>
    /// This is the response object from the DescribeCustomPlugin operation.
    /// </summary>
    public partial class DescribeCustomPluginResponse : AmazonWebServiceResponse
    {
        private DateTime? _creationTime;
        private string _customPluginArn;
        private CustomPluginState _customPluginState;
        private string _description;
        private CustomPluginRevisionSummary _latestRevision;
        private string _name;
        private StateDescription _stateDescription;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time that the custom plugin was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CustomPluginArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the custom plugin.
        /// </para>
        /// </summary>
        public string CustomPluginArn
        {
            get { return this._customPluginArn; }
            set { this._customPluginArn = value; }
        }

        // Check to see if CustomPluginArn property is set
        internal bool IsSetCustomPluginArn()
        {
            return this._customPluginArn != null;
        }

        /// <summary>
        /// Gets and sets the property CustomPluginState. 
        /// <para>
        /// The state of the custom plugin.
        /// </para>
        /// </summary>
        public CustomPluginState CustomPluginState
        {
            get { return this._customPluginState; }
            set { this._customPluginState = value; }
        }

        // Check to see if CustomPluginState property is set
        internal bool IsSetCustomPluginState()
        {
            return this._customPluginState != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the custom plugin.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property LatestRevision. 
        /// <para>
        /// The latest successfully created revision of the custom plugin. If there are no successfully
        /// created revisions, this field will be absent.
        /// </para>
        /// </summary>
        public CustomPluginRevisionSummary LatestRevision
        {
            get { return this._latestRevision; }
            set { this._latestRevision = value; }
        }

        // Check to see if LatestRevision property is set
        internal bool IsSetLatestRevision()
        {
            return this._latestRevision != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the custom plugin.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property StateDescription. 
        /// <para>
        /// Details about the state of a custom plugin.
        /// </para>
        /// </summary>
        public StateDescription StateDescription
        {
            get { return this._stateDescription; }
            set { this._stateDescription = value; }
        }

        // Check to see if StateDescription property is set
        internal bool IsSetStateDescription()
        {
            return this._stateDescription != null;
        }

    }
}