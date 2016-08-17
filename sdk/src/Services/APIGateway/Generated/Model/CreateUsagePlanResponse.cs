/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// Represents a usage plan than can specify who can assess associated API stages with
    /// specified request limits and quotas.
    /// 
    ///  <div class="remarks"> 
    /// <para>
    /// In a usage plan, you associate an API by specifying the API's Id and a stage name
    /// of the specified API. You add plan customers by adding API keys to the plan. 
    /// </para>
    ///  </div> <div class="seeAlso"> <a href="http://docs.aws.amazon.com/apigateway/latest/developerguide/api-gateway-api-usage-plans.html">Create
    /// and Use Usage Plans</a> </div>
    /// </summary>
    public partial class CreateUsagePlanResponse : AmazonWebServiceResponse
    {
        private List<ApiStage> _apiStages = new List<ApiStage>();
        private string _description;
        private string _id;
        private string _name;
        private QuotaSettings _quota;
        private ThrottleSettings _throttle;

        /// <summary>
        /// Gets and sets the property ApiStages. 
        /// <para>
        /// The associated API stages of a usage plan.
        /// </para>
        /// </summary>
        public List<ApiStage> ApiStages
        {
            get { return this._apiStages; }
            set { this._apiStages = value; }
        }

        // Check to see if ApiStages property is set
        internal bool IsSetApiStages()
        {
            return this._apiStages != null && this._apiStages.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of a usage plan.
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of a <a>UsagePlan</a> resource.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of a usage plan.
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
        /// Gets and sets the property Quota. 
        /// <para>
        /// The maximum number of permitted requests per a given unit time interval.
        /// </para>
        /// </summary>
        public QuotaSettings Quota
        {
            get { return this._quota; }
            set { this._quota = value; }
        }

        // Check to see if Quota property is set
        internal bool IsSetQuota()
        {
            return this._quota != null;
        }

        /// <summary>
        /// Gets and sets the property Throttle. 
        /// <para>
        /// The request throttle limits of a usage plan.
        /// </para>
        /// </summary>
        public ThrottleSettings Throttle
        {
            get { return this._throttle; }
            set { this._throttle = value; }
        }

        // Check to see if Throttle property is set
        internal bool IsSetThrottle()
        {
            return this._throttle != null;
        }

    }
}