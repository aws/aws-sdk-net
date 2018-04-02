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
    /// Container for the parameters to the CreateUsagePlan operation.
    /// Creates a usage plan with the throttle and quota limits, as well as the associated
    /// API stages, specified in the payload.
    /// </summary>
    public partial class CreateUsagePlanRequest : AmazonAPIGatewayRequest
    {
        private List<ApiStage> _apiStages = new List<ApiStage>();
        private string _description;
        private string _name;
        private QuotaSettings _quota;
        private ThrottleSettings _throttle;

        /// <summary>
        /// Gets and sets the property ApiStages. 
        /// <para>
        /// The associated API stages of the usage plan.
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
        /// The description of the usage plan.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// [Required] The name of the usage plan.
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
        /// The quota of the usage plan.
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
        /// The throttling limits of the usage plan.
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