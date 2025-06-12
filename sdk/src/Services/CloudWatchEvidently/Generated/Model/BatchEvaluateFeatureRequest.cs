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
    /// Container for the parameters to the BatchEvaluateFeature operation.
    /// This operation assigns feature variation to user sessions. For each user session,
    /// you pass in an <c>entityID</c> that represents the user. Evidently then checks the
    /// evaluation rules and assigns the variation.
    /// 
    ///  
    /// <para>
    /// The first rules that are evaluated are the override rules. If the user's <c>entityID</c>
    /// matches an override rule, the user is served the variation specified by that rule.
    /// </para>
    ///  
    /// <para>
    /// Next, if there is a launch of the feature, the user might be assigned to a variation
    /// in the launch. The chance of this depends on the percentage of users that are allocated
    /// to that launch. If the user is enrolled in the launch, the variation they are served
    /// depends on the allocation of the various feature variations used for the launch.
    /// </para>
    ///  
    /// <para>
    /// If the user is not assigned to a launch, and there is an ongoing experiment for this
    /// feature, the user might be assigned to a variation in the experiment. The chance of
    /// this depends on the percentage of users that are allocated to that experiment. If
    /// the user is enrolled in the experiment, the variation they are served depends on the
    /// allocation of the various feature variations used for the experiment. 
    /// </para>
    ///  
    /// <para>
    /// If the user is not assigned to a launch or experiment, they are served the default
    /// variation.
    /// </para>
    /// </summary>
    public partial class BatchEvaluateFeatureRequest : AmazonCloudWatchEvidentlyRequest
    {
        private string _project;
        private List<EvaluationRequest> _requests = AWSConfigs.InitializeCollections ? new List<EvaluationRequest>() : null;

        /// <summary>
        /// Gets and sets the property Project. 
        /// <para>
        /// The name or ARN of the project that contains the feature being evaluated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
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
        /// Gets and sets the property Requests. 
        /// <para>
        /// An array of structures, where each structure assigns a feature variation to one user
        /// session.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public List<EvaluationRequest> Requests
        {
            get { return this._requests; }
            set { this._requests = value; }
        }

        // Check to see if Requests property is set
        internal bool IsSetRequests()
        {
            return this._requests != null && (this._requests.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}