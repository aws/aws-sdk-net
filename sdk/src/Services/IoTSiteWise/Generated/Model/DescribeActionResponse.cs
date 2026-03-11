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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// This is the response object from the DescribeAction operation.
    /// </summary>
    public partial class DescribeActionResponse : AmazonWebServiceResponse
    {
        private string _actionDefinitionId;
        private string _actionId;
        private ActionPayload _actionPayload;
        private DateTime? _executionTime;
        private ResolveTo _resolveTo;
        private TargetResource _targetResource;

        /// <summary>
        /// Gets and sets the property ActionDefinitionId. 
        /// <para>
        /// The ID of the action definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string ActionDefinitionId
        {
            get { return this._actionDefinitionId; }
            set { this._actionDefinitionId = value; }
        }

        // Check to see if ActionDefinitionId property is set
        internal bool IsSetActionDefinitionId()
        {
            return this._actionDefinitionId != null;
        }

        /// <summary>
        /// Gets and sets the property ActionId. 
        /// <para>
        /// The ID of the action.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string ActionId
        {
            get { return this._actionId; }
            set { this._actionId = value; }
        }

        // Check to see if ActionId property is set
        internal bool IsSetActionId()
        {
            return this._actionId != null;
        }

        /// <summary>
        /// Gets and sets the property ActionPayload. 
        /// <para>
        /// The JSON payload of the action.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ActionPayload ActionPayload
        {
            get { return this._actionPayload; }
            set { this._actionPayload = value; }
        }

        // Check to see if ActionPayload property is set
        internal bool IsSetActionPayload()
        {
            return this._actionPayload != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionTime. 
        /// <para>
        /// The time the action was executed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? ExecutionTime
        {
            get { return this._executionTime; }
            set { this._executionTime = value; }
        }

        // Check to see if ExecutionTime property is set
        internal bool IsSetExecutionTime()
        {
            return this._executionTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResolveTo. 
        /// <para>
        /// The detailed resource this action resolves to.
        /// </para>
        /// </summary>
        public ResolveTo ResolveTo
        {
            get { return this._resolveTo; }
            set { this._resolveTo = value; }
        }

        // Check to see if ResolveTo property is set
        internal bool IsSetResolveTo()
        {
            return this._resolveTo != null;
        }

        /// <summary>
        /// Gets and sets the property TargetResource. 
        /// <para>
        /// The resource the action will be taken on.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TargetResource TargetResource
        {
            get { return this._targetResource; }
            set { this._targetResource = value; }
        }

        // Check to see if TargetResource property is set
        internal bool IsSetTargetResource()
        {
            return this._targetResource != null;
        }

    }
}