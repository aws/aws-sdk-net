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
    /// Container for the parameters to the ProvisionProduct operation.
    /// Requests a <i>provision</i> of a specified product. A <i>provisioned product</i> is
    /// a resourced instance for a product. For example, provisioning a CloudFormation-template-backed
    /// product results in launching a CloudFormation stack and all the underlying resources
    /// that come with it. 
    /// 
    ///  
    /// <para>
    /// You can check the status of this request using the <a>DescribeRecord</a> operation.
    /// The error "Parameter validation failed: Missing required parameter in Tags[<i>N</i>]:<i>Value</i>"
    /// indicates that your request contains a tag which has a tag key but no corresponding
    /// tag value (value is empty or null). Your call may have included values returned from
    /// a <code>DescribeProvisioningParameters</code> call that resulted in a TagOption key
    /// with an empty list. This happens when TagOption keys are in conflict. For more information,
    /// see <a>DescribeProvisioningParameters</a>.
    /// </para>
    /// </summary>
    public partial class ProvisionProductRequest : AmazonServiceCatalogRequest
    {
        private string _acceptLanguage;
        private List<string> _notificationArns = new List<string>();
        private string _pathId;
        private string _productId;
        private string _provisionedProductName;
        private string _provisioningArtifactId;
        private List<ProvisioningParameter> _provisioningParameters = new List<ProvisioningParameter>();
        private string _provisionToken;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property AcceptLanguage. 
        /// <para>
        /// The language code to use for this operation. Supported language codes are as follows:
        /// </para>
        ///  
        /// <para>
        /// "en" (English)
        /// </para>
        ///  
        /// <para>
        /// "jp" (Japanese)
        /// </para>
        ///  
        /// <para>
        /// "zh" (Chinese)
        /// </para>
        ///  
        /// <para>
        /// If no code is specified, "en" is used as the default.
        /// </para>
        /// </summary>
        public string AcceptLanguage
        {
            get { return this._acceptLanguage; }
            set { this._acceptLanguage = value; }
        }

        // Check to see if AcceptLanguage property is set
        internal bool IsSetAcceptLanguage()
        {
            return this._acceptLanguage != null;
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
        /// The identifier of the path for this product's provisioning. This value is optional
        /// if the product has a default path, and is required if there is more than one path
        /// for the specified product.
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
        /// Gets and sets the property ProvisionedProductName. 
        /// <para>
        /// A user-friendly name to identify the ProvisionedProduct object. This value must be
        /// unique for the AWS account and cannot be updated after the product is provisioned.
        /// </para>
        /// </summary>
        public string ProvisionedProductName
        {
            get { return this._provisionedProductName; }
            set { this._provisionedProductName = value; }
        }

        // Check to see if ProvisionedProductName property is set
        internal bool IsSetProvisionedProductName()
        {
            return this._provisionedProductName != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisioningArtifactId. 
        /// <para>
        /// The provisioning artifact identifier for this product. This is sometimes referred
        /// to as the product version.
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
        public List<ProvisioningParameter> ProvisioningParameters
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
        /// Gets and sets the property ProvisionToken. 
        /// <para>
        /// An idempotency token that uniquely identifies the provisioning request. 
        /// </para>
        /// </summary>
        public string ProvisionToken
        {
            get { return this._provisionToken; }
            set { this._provisionToken = value; }
        }

        // Check to see if ProvisionToken property is set
        internal bool IsSetProvisionToken()
        {
            return this._provisionToken != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags to use as provisioning options.
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

    }
}