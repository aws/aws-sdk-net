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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
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
namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// An organization conformance pack that has information about conformance packs that
    /// Config creates in member accounts.
    /// </summary>
    public partial class OrganizationConformancePack
    {
        private List<ConformancePackInputParameter> _conformancePackInputParameters = AWSConfigs.InitializeCollections ? new List<ConformancePackInputParameter>() : null;
        private string _deliveryS3Bucket;
        private string _deliveryS3KeyPrefix;
        private List<string> _excludedAccounts = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _lastUpdateTime;
        private string _organizationConformancePackArn;
        private string _organizationConformancePackName;

        /// <summary>
        /// Gets and sets the property ConformancePackInputParameters. 
        /// <para>
        /// A list of <c>ConformancePackInputParameter</c> objects.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=60)]
        public List<ConformancePackInputParameter> ConformancePackInputParameters
        {
            get { return this._conformancePackInputParameters; }
            set { this._conformancePackInputParameters = value; }
        }

        // Check to see if ConformancePackInputParameters property is set
        internal bool IsSetConformancePackInputParameters()
        {
            return this._conformancePackInputParameters != null && (this._conformancePackInputParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DeliveryS3Bucket. 
        /// <para>
        /// The name of the Amazon S3 bucket where Config stores conformance pack templates. 
        /// </para>
        ///  <note> 
        /// <para>
        /// This field is optional.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=0, Max=63)]
        public string DeliveryS3Bucket
        {
            get { return this._deliveryS3Bucket; }
            set { this._deliveryS3Bucket = value; }
        }

        // Check to see if DeliveryS3Bucket property is set
        internal bool IsSetDeliveryS3Bucket()
        {
            return this._deliveryS3Bucket != null;
        }

        /// <summary>
        /// Gets and sets the property DeliveryS3KeyPrefix. 
        /// <para>
        /// Any folder structure you want to add to an Amazon S3 bucket.
        /// </para>
        ///  <note> 
        /// <para>
        /// This field is optional.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string DeliveryS3KeyPrefix
        {
            get { return this._deliveryS3KeyPrefix; }
            set { this._deliveryS3KeyPrefix = value; }
        }

        // Check to see if DeliveryS3KeyPrefix property is set
        internal bool IsSetDeliveryS3KeyPrefix()
        {
            return this._deliveryS3KeyPrefix != null;
        }

        /// <summary>
        /// Gets and sets the property ExcludedAccounts. 
        /// <para>
        /// A comma-separated list of accounts excluded from organization conformance pack.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public List<string> ExcludedAccounts
        {
            get { return this._excludedAccounts; }
            set { this._excludedAccounts = value; }
        }

        // Check to see if ExcludedAccounts property is set
        internal bool IsSetExcludedAccounts()
        {
            return this._excludedAccounts != null && (this._excludedAccounts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LastUpdateTime. 
        /// <para>
        /// Last time when organization conformation pack was updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastUpdateTime
        {
            get { return this._lastUpdateTime; }
            set { this._lastUpdateTime = value; }
        }

        // Check to see if LastUpdateTime property is set
        internal bool IsSetLastUpdateTime()
        {
            return this._lastUpdateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OrganizationConformancePackArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of organization conformance pack.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string OrganizationConformancePackArn
        {
            get { return this._organizationConformancePackArn; }
            set { this._organizationConformancePackArn = value; }
        }

        // Check to see if OrganizationConformancePackArn property is set
        internal bool IsSetOrganizationConformancePackArn()
        {
            return this._organizationConformancePackArn != null;
        }

        /// <summary>
        /// Gets and sets the property OrganizationConformancePackName. 
        /// <para>
        /// The name you assign to an organization conformance pack.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string OrganizationConformancePackName
        {
            get { return this._organizationConformancePackName; }
            set { this._organizationConformancePackName = value; }
        }

        // Check to see if OrganizationConformancePackName property is set
        internal bool IsSetOrganizationConformancePackName()
        {
            return this._organizationConformancePackName != null;
        }

    }
}