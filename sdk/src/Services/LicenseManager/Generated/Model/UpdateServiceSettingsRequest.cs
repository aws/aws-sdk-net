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
 * Do not modify this file. This file is generated from the license-manager-2018-08-01.normal.json service model.
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
namespace Amazon.LicenseManager.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateServiceSettings operation.
    /// Updates License Manager settings for the current Region.
    /// </summary>
    public partial class UpdateServiceSettingsRequest : AmazonLicenseManagerRequest
    {
        private bool? _enableCrossAccountsDiscovery;
        private OrganizationConfiguration _organizationConfiguration;
        private string _s3BucketArn;
        private string _snsTopicArn;

        /// <summary>
        /// Gets and sets the property EnableCrossAccountsDiscovery. 
        /// <para>
        /// Activates cross-account discovery.
        /// </para>
        /// </summary>
        public bool? EnableCrossAccountsDiscovery
        {
            get { return this._enableCrossAccountsDiscovery; }
            set { this._enableCrossAccountsDiscovery = value; }
        }

        // Check to see if EnableCrossAccountsDiscovery property is set
        internal bool IsSetEnableCrossAccountsDiscovery()
        {
            return this._enableCrossAccountsDiscovery.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OrganizationConfiguration. 
        /// <para>
        /// Enables integration with Organizations for cross-account discovery.
        /// </para>
        /// </summary>
        public OrganizationConfiguration OrganizationConfiguration
        {
            get { return this._organizationConfiguration; }
            set { this._organizationConfiguration = value; }
        }

        // Check to see if OrganizationConfiguration property is set
        internal bool IsSetOrganizationConfiguration()
        {
            return this._organizationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property S3BucketArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the Amazon S3 bucket where the License Manager information
        /// is stored.
        /// </para>
        /// </summary>
        public string S3BucketArn
        {
            get { return this._s3BucketArn; }
            set { this._s3BucketArn = value; }
        }

        // Check to see if S3BucketArn property is set
        internal bool IsSetS3BucketArn()
        {
            return this._s3BucketArn != null;
        }

        /// <summary>
        /// Gets and sets the property SnsTopicArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the Amazon SNS topic used for License Manager alerts.
        /// </para>
        /// </summary>
        public string SnsTopicArn
        {
            get { return this._snsTopicArn; }
            set { this._snsTopicArn = value; }
        }

        // Check to see if SnsTopicArn property is set
        internal bool IsSetSnsTopicArn()
        {
            return this._snsTopicArn != null;
        }

    }
}