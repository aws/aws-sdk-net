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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// A response that contains details on the results of a finding aggregation by repository.
    /// </summary>
    public partial class RepositoryAggregationResponse
    {
        private string _accountId;
        private long? _affectedImages;
        private string _cloudAccountId;
        private string _cloudOrgId;
        private string _cloudPartition;
        private Provider _cloudProvider;
        private string _cloudRegion;
        private string _repository;
        private SeverityCounts _severityCounts;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account associated with the findings.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property AffectedImages. 
        /// <para>
        /// The number of container images impacted by the findings.
        /// </para>
        /// </summary>
        public long? AffectedImages
        {
            get { return this._affectedImages; }
            set { this._affectedImages = value; }
        }

        // Check to see if AffectedImages property is set
        internal bool IsSetAffectedImages()
        {
            return this._affectedImages.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CloudAccountId. 
        /// <para>
        /// The cloud account ID for the repository aggregation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=36)]
        public string CloudAccountId
        {
            get { return this._cloudAccountId; }
            set { this._cloudAccountId = value; }
        }

        // Check to see if CloudAccountId property is set
        internal bool IsSetCloudAccountId()
        {
            return this._cloudAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property CloudOrgId. 
        /// <para>
        /// The cloud organization ID for the repository aggregation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=36)]
        public string CloudOrgId
        {
            get { return this._cloudOrgId; }
            set { this._cloudOrgId = value; }
        }

        // Check to see if CloudOrgId property is set
        internal bool IsSetCloudOrgId()
        {
            return this._cloudOrgId != null;
        }

        /// <summary>
        /// Gets and sets the property CloudPartition. 
        /// <para>
        /// The cloud infrastructure partition associated with this repository aggregation. Valid
        /// values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>aws</c> – Amazon Web Services commercial Regions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>aws-cn</c> – Amazon Web Services China Regions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>aws-us-gov</c> – Amazon Web Services GovCloud (US) Regions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AzureCloud</c> – Azure commercial Regions.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string CloudPartition
        {
            get { return this._cloudPartition; }
            set { this._cloudPartition = value; }
        }

        // Check to see if CloudPartition property is set
        internal bool IsSetCloudPartition()
        {
            return this._cloudPartition != null;
        }

        /// <summary>
        /// Gets and sets the property CloudProvider. 
        /// <para>
        /// The cloud service provider associated with this repository aggregation. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AWS</c> – Findings from Amazon Web Services resources.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AZURE</c> – Findings from Microsoft Azure resources.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public Provider CloudProvider
        {
            get { return this._cloudProvider; }
            set { this._cloudProvider = value; }
        }

        // Check to see if CloudProvider property is set
        internal bool IsSetCloudProvider()
        {
            return this._cloudProvider != null;
        }

        /// <summary>
        /// Gets and sets the property CloudRegion. 
        /// <para>
        /// The cloud Region associated with this repository aggregation. The value format depends
        /// on the cloud provider:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// An Amazon Web Services Region, such as <c>us-east-1</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An Azure region, such as <c>eastus</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string CloudRegion
        {
            get { return this._cloudRegion; }
            set { this._cloudRegion = value; }
        }

        // Check to see if CloudRegion property is set
        internal bool IsSetCloudRegion()
        {
            return this._cloudRegion != null;
        }

        /// <summary>
        /// Gets and sets the property Repository. 
        /// <para>
        /// The name of the repository associated with the findings.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string Repository
        {
            get { return this._repository; }
            set { this._repository = value; }
        }

        // Check to see if Repository property is set
        internal bool IsSetRepository()
        {
            return this._repository != null;
        }

        /// <summary>
        /// Gets and sets the property SeverityCounts. 
        /// <para>
        /// An object that represent the count of matched findings per severity.
        /// </para>
        /// </summary>
        public SeverityCounts SeverityCounts
        {
            get { return this._severityCounts; }
            set { this._severityCounts = value; }
        }

        // Check to see if SeverityCounts property is set
        internal bool IsSetSeverityCounts()
        {
            return this._severityCounts != null;
        }

    }
}