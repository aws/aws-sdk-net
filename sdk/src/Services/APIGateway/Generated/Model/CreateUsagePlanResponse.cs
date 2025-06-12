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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
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
namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// Represents a usage plan used to specify who can assess associated API stages. Optionally,
    /// target request rate and quota limits can be set. In some cases clients can exceed
    /// the targets that you set. Don’t rely on usage plans to control costs. Consider using
    /// <a href="https://docs.aws.amazon.com/cost-management/latest/userguide/budgets-managing-costs.html">Amazon
    /// Web Services Budgets</a> to monitor costs and <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">WAF</a>
    /// to manage API requests.
    /// </summary>
    public partial class CreateUsagePlanResponse : AmazonWebServiceResponse
    {
        private List<ApiStage> _apiStages = AWSConfigs.InitializeCollections ? new List<ApiStage>() : null;
        private string _description;
        private string _id;
        private string _name;
        private string _productCode;
        private QuotaSettings _quota;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private ThrottleSettings _throttle;

        /// <summary>
        /// Gets and sets the property ApiStages. 
        /// <para>
        /// The associated API stages of a usage plan.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ApiStage> ApiStages
        {
            get { return this._apiStages; }
            set { this._apiStages = value; }
        }

        // Check to see if ApiStages property is set
        internal bool IsSetApiStages()
        {
            return this._apiStages != null && (this._apiStages.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// The identifier of a UsagePlan resource.
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
        /// Gets and sets the property ProductCode. 
        /// <para>
        /// The Amazon Web Services Marketplace product identifier to associate with the usage
        /// plan as a SaaS product on the Amazon Web Services Marketplace.
        /// </para>
        /// </summary>
        public string ProductCode
        {
            get { return this._productCode; }
            set { this._productCode = value; }
        }

        // Check to see if ProductCode property is set
        internal bool IsSetProductCode()
        {
            return this._productCode != null;
        }

        /// <summary>
        /// Gets and sets the property Quota. 
        /// <para>
        /// The target maximum number of permitted requests per a given unit time interval.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The collection of tags. Each tag element is associated with a given resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Throttle. 
        /// <para>
        /// A map containing method level throttling information for API stage in a usage plan.
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