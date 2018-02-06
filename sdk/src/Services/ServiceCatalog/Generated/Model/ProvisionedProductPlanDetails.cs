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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// Information about a plan.
    /// </summary>
    public partial class ProvisionedProductPlanDetails
    {
        private DateTime? _createdTime;
        private List<string> _notificationArns = new List<string>();
        private string _pathId;
        private string _planId;
        private string _planName;
        private ProvisionedProductPlanType _planType;
        private string _productId;
        private string _provisioningArtifactId;
        private List<UpdateProvisioningParameter> _provisioningParameters = new List<UpdateProvisioningParameter>();
        private string _provisionProductId;
        private string _provisionProductName;
        private ProvisionedProductPlanStatus _status;
        private string _statusMessage;
        private List<Tag> _tags = new List<Tag>();
        private DateTime? _updatedTime;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The UTC time stamp of the creation time.
        /// </para>
        /// </summary>
        public DateTime CreatedTime
        {
            get { return this._createdTime.GetValueOrDefault(); }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NotificationArns. 
        /// <para>
        /// Passed to CloudFormation. The SNS topic ARNs to which to publish stack-related events.
        /// </para>
        /// </summary>
        public List<string> NotificationArns
        {
            get { return this._notificationArns; }
            set { this._notificationArns = value; }
        }

        // Check to see if NotificationArns property is set
        internal bool IsSetNotificationArns()
        {
            return this._notificationArns != null && this._notificationArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PathId. 
        /// <para>
        /// The path identifier of the product. This value is optional if the product has a default
        /// path, and required if the product has more than one path. To list the paths for a
        /// product, use <a>ListLaunchPaths</a>.
        /// </para>
        /// </summary>
        public string PathId
        {
            get { return this._pathId; }
            set { this._pathId = value; }
        }

        // Check to see if PathId property is set
        internal bool IsSetPathId()
        {
            return this._pathId != null;
        }

        /// <summary>
        /// Gets and sets the property PlanId. 
        /// <para>
        /// The plan identifier.
        /// </para>
        /// </summary>
        public string PlanId
        {
            get { return this._planId; }
            set { this._planId = value; }
        }

        // Check to see if PlanId property is set
        internal bool IsSetPlanId()
        {
            return this._planId != null;
        }

        /// <summary>
        /// Gets and sets the property PlanName. 
        /// <para>
        /// The name of the plan.
        /// </para>
        /// </summary>
        public string PlanName
        {
            get { return this._planName; }
            set { this._planName = value; }
        }

        // Check to see if PlanName property is set
        internal bool IsSetPlanName()
        {
            return this._planName != null;
        }

        /// <summary>
        /// Gets and sets the property PlanType. 
        /// <para>
        /// The plan type.
        /// </para>
        /// </summary>
        public ProvisionedProductPlanType PlanType
        {
            get { return this._planType; }
            set { this._planType = value; }
        }

        // Check to see if PlanType property is set
        internal bool IsSetPlanType()
        {
            return this._planType != null;
        }

        /// <summary>
        /// Gets and sets the property ProductId. 
        /// <para>
        /// The product identifier.
        /// </para>
        /// </summary>
        public string ProductId
        {
            get { return this._productId; }
            set { this._productId = value; }
        }

        // Check to see if ProductId property is set
        internal bool IsSetProductId()
        {
            return this._productId != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisioningArtifactId. 
        /// <para>
        /// The identifier of the provisioning artifact.
        /// </para>
        /// </summary>
        public string ProvisioningArtifactId
        {
            get { return this._provisioningArtifactId; }
            set { this._provisioningArtifactId = value; }
        }

        // Check to see if ProvisioningArtifactId property is set
        internal bool IsSetProvisioningArtifactId()
        {
            return this._provisioningArtifactId != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisioningParameters. 
        /// <para>
        /// Parameters specified by the administrator that are required for provisioning the product.
        /// </para>
        /// </summary>
        public List<UpdateProvisioningParameter> ProvisioningParameters
        {
            get { return this._provisioningParameters; }
            set { this._provisioningParameters = value; }
        }

        // Check to see if ProvisioningParameters property is set
        internal bool IsSetProvisioningParameters()
        {
            return this._provisioningParameters != null && this._provisioningParameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ProvisionProductId. 
        /// <para>
        /// The product identifier.
        /// </para>
        /// </summary>
        public string ProvisionProductId
        {
            get { return this._provisionProductId; }
            set { this._provisionProductId = value; }
        }

        // Check to see if ProvisionProductId property is set
        internal bool IsSetProvisionProductId()
        {
            return this._provisionProductId != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisionProductName. 
        /// <para>
        /// The user-friendly name of the provisioned product.
        /// </para>
        /// </summary>
        public string ProvisionProductName
        {
            get { return this._provisionProductName; }
            set { this._provisionProductName = value; }
        }

        // Check to see if ProvisionProductName property is set
        internal bool IsSetProvisionProductName()
        {
            return this._provisionProductName != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status.
        /// </para>
        /// </summary>
        public ProvisionedProductPlanStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The status message.
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// One or more tags.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property UpdatedTime. 
        /// <para>
        /// The time when the plan was last updated.
        /// </para>
        /// </summary>
        public DateTime UpdatedTime
        {
            get { return this._updatedTime.GetValueOrDefault(); }
            set { this._updatedTime = value; }
        }

        // Check to see if UpdatedTime property is set
        internal bool IsSetUpdatedTime()
        {
            return this._updatedTime.HasValue; 
        }

    }
}