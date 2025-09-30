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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
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
namespace Amazon.ECS.Model
{
    /// <summary>
    /// A deployment lifecycle hook runs custom logic at specific stages of the deployment
    /// process. Currently, you can use Lambda functions as hook targets.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/deployment-lifecycle-hooks.html">Lifecycle
    /// hooks for Amazon ECS service deployments</a> in the <i> Amazon Elastic Container Service
    /// Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class DeploymentLifecycleHook
    {
        private Amazon.Runtime.Documents.Document _hookDetails;
        private string _hookTargetArn;
        private List<string> _lifecycleStages = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property HookDetails. 
        /// <para>
        /// The details of the deployment lifecycle hook. This provides additional configuration
        /// for how the hook should be executed during deployment operations on Amazon ECS Managed
        /// Instances.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document HookDetails
        {
            get { return this._hookDetails; }
            set { this._hookDetails = value; }
        }

        // Check to see if HookDetails property is set
        internal bool IsSetHookDetails()
        {
            return !this._hookDetails.IsNull();
        }

        /// <summary>
        /// Gets and sets the property HookTargetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the hook target. Currently, only Lambda function
        /// ARNs are supported.
        /// </para>
        ///  
        /// <para>
        /// You must provide this parameter when configuring a deployment lifecycle hook.
        /// </para>
        /// </summary>
        public string HookTargetArn
        {
            get { return this._hookTargetArn; }
            set { this._hookTargetArn = value; }
        }

        // Check to see if HookTargetArn property is set
        internal bool IsSetHookTargetArn()
        {
            return this._hookTargetArn != null;
        }

        /// <summary>
        /// Gets and sets the property LifecycleStages. 
        /// <para>
        /// The lifecycle stages at which to run the hook. Choose from these valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// RECONCILE_SERVICE
        /// </para>
        ///  
        /// <para>
        /// The reconciliation stage that only happens when you start a new service deployment
        /// with more than 1 service revision in an ACTIVE state.
        /// </para>
        ///  
        /// <para>
        /// You can use a lifecycle hook for this stage.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PRE_SCALE_UP
        /// </para>
        ///  
        /// <para>
        /// The green service revision has not started. The blue service revision is handling
        /// 100% of the production traffic. There is no test traffic.
        /// </para>
        ///  
        /// <para>
        /// You can use a lifecycle hook for this stage.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POST_SCALE_UP
        /// </para>
        ///  
        /// <para>
        /// The green service revision has started. The blue service revision is handling 100%
        /// of the production traffic. There is no test traffic.
        /// </para>
        ///  
        /// <para>
        /// You can use a lifecycle hook for this stage.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// TEST_TRAFFIC_SHIFT
        /// </para>
        ///  
        /// <para>
        /// The blue and green service revisions are running. The blue service revision handles
        /// 100% of the production traffic. The green service revision is migrating from 0% to
        /// 100% of test traffic.
        /// </para>
        ///  
        /// <para>
        /// You can use a lifecycle hook for this stage.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POST_TEST_TRAFFIC_SHIFT
        /// </para>
        ///  
        /// <para>
        /// The test traffic shift is complete. The green service revision handles 100% of the
        /// test traffic.
        /// </para>
        ///  
        /// <para>
        /// You can use a lifecycle hook for this stage.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PRODUCTION_TRAFFIC_SHIFT
        /// </para>
        ///  
        /// <para>
        /// Production traffic is shifting to the green service revision. The green service revision
        /// is migrating from 0% to 100% of production traffic.
        /// </para>
        ///  
        /// <para>
        /// You can use a lifecycle hook for this stage.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// POST_PRODUCTION_TRAFFIC_SHIFT
        /// </para>
        ///  
        /// <para>
        /// The production traffic shift is complete.
        /// </para>
        ///  
        /// <para>
        /// You can use a lifecycle hook for this stage.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You must provide this parameter when configuring a deployment lifecycle hook.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> LifecycleStages
        {
            get { return this._lifecycleStages; }
            set { this._lifecycleStages = value; }
        }

        // Check to see if LifecycleStages property is set
        internal bool IsSetLifecycleStages()
        {
            return this._lifecycleStages != null && (this._lifecycleStages.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that grants Amazon ECS permission to
        /// call Lambda functions on your behalf.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/blue-green-permissions.html">Permissions
        /// required for Lambda functions in Amazon ECS blue/green deployments</a> in the <i>
        /// Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

    }
}