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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the ListStageDevices operation.
    /// Lists devices allocated to the stage, containing detailed device information and deployment
    /// status.
    /// </summary>
    public partial class ListStageDevicesRequest : AmazonSageMakerRequest
    {
        private string _edgeDeploymentPlanName;
        private bool? _excludeDevicesDeployedInOtherStage;
        private int? _maxResults;
        private string _nextToken;
        private string _stageName;

        /// <summary>
        /// Gets and sets the property EdgeDeploymentPlanName. 
        /// <para>
        /// The name of the edge deployment plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string EdgeDeploymentPlanName
        {
            get { return this._edgeDeploymentPlanName; }
            set { this._edgeDeploymentPlanName = value; }
        }

        // Check to see if EdgeDeploymentPlanName property is set
        internal bool IsSetEdgeDeploymentPlanName()
        {
            return this._edgeDeploymentPlanName != null;
        }

        /// <summary>
        /// Gets and sets the property ExcludeDevicesDeployedInOtherStage. 
        /// <para>
        /// Toggle for excluding devices deployed in other stages.
        /// </para>
        /// </summary>
        public bool? ExcludeDevicesDeployedInOtherStage
        {
            get { return this._excludeDevicesDeployedInOtherStage; }
            set { this._excludeDevicesDeployedInOtherStage = value; }
        }

        // Check to see if ExcludeDevicesDeployedInOtherStage property is set
        internal bool IsSetExcludeDevicesDeployedInOtherStage()
        {
            return this._excludeDevicesDeployedInOtherStage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of requests to select.
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The response from the last list when returning a list large enough to neeed tokening.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8192)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property StageName. 
        /// <para>
        /// The name of the stage in the deployment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string StageName
        {
            get { return this._stageName; }
            set { this._stageName = value; }
        }

        // Check to see if StageName property is set
        internal bool IsSetStageName()
        {
            return this._stageName != null;
        }

    }
}